Imports System.Data
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Linq
Imports System.Net
Imports System.Net.Http
Imports System.Web.Http
Imports System.Web.Http.Description
Imports VbDemoMyMGM

Namespace Controllers
    Public Class LocalEventsApiController
        Inherits System.Web.Http.ApiController

        Private db As New LocalEventDBContext

        ' GET: api/LocalEventsApi
        Function GetLocalEvents() As IQueryable(Of LocalEvent)
            Return db.LocalEvents
        End Function

        ' GET: api/LocalEventsApi/5
        <ResponseType(GetType(LocalEvent))>
        Function GetLocalEvent(ByVal id As Integer) As IHttpActionResult
            Dim localEvent As LocalEvent = db.LocalEvents.Find(id)
            If IsNothing(localEvent) Then
                Return NotFound()
            End If

            Return Ok(localEvent)
        End Function

        ' PUT: api/LocalEventsApi/5
        <ResponseType(GetType(Void))>
        Function PutLocalEvent(ByVal id As Integer, ByVal localEvent As LocalEvent) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            If Not id = localEvent.ID Then
                Return BadRequest()
            End If

            db.Entry(localEvent).State = EntityState.Modified

            Try
                db.SaveChanges()
            Catch ex As DbUpdateConcurrencyException
                If Not (LocalEventExists(id)) Then
                    Return NotFound()
                Else
                    Throw
                End If
            End Try

            Return StatusCode(HttpStatusCode.NoContent)
        End Function

        ' POST: api/LocalEventsApi
        <ResponseType(GetType(LocalEvent))>
        Function PostLocalEvent(ByVal localEvent As LocalEvent) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            db.LocalEvents.Add(localEvent)
            db.SaveChanges()

            Return CreatedAtRoute("DefaultApi", New With {.id = localEvent.ID}, localEvent)
        End Function

        ' DELETE: api/LocalEventsApi/5
        <ResponseType(GetType(LocalEvent))>
        Function DeleteLocalEvent(ByVal id As Integer) As IHttpActionResult
            Dim localEvent As LocalEvent = db.LocalEvents.Find(id)
            If IsNothing(localEvent) Then
                Return NotFound()
            End If

            db.LocalEvents.Remove(localEvent)
            db.SaveChanges()

            Return Ok(localEvent)
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Function LocalEventExists(ByVal id As Integer) As Boolean
            Return db.LocalEvents.Count(Function(e) e.ID = id) > 0
        End Function
    End Class
End Namespace