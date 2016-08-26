Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports VbDemoMyMGM

Namespace Controllers
    Public Class LocalEventsController
        Inherits System.Web.Mvc.Controller

        Private db As New LocalEventDBContext

        ' GET: LocalEvents
        Function Index() As ActionResult
            Return View(db.LocalEvents.ToList())
        End Function

        ' GET: LocalEvents/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim localEvent As LocalEvent = db.LocalEvents.Find(id)
            If IsNothing(localEvent) Then
                Return HttpNotFound()
            End If
            Return View(localEvent)
        End Function

        ' GET: LocalEvents/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: LocalEvents/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ID,Title,StartDate,Description,Url,Address,Category")> ByVal localEvent As LocalEvent) As ActionResult
            If ModelState.IsValid Then
                db.LocalEvents.Add(localEvent)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(localEvent)
        End Function

        ' GET: LocalEvents/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim localEvent As LocalEvent = db.LocalEvents.Find(id)
            If IsNothing(localEvent) Then
                Return HttpNotFound()
            End If
            Return View(localEvent)
        End Function

        ' POST: LocalEvents/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ID,Title,StartDate,Description,Url,Address,Category")> ByVal localEvent As LocalEvent) As ActionResult
            If ModelState.IsValid Then
                db.Entry(localEvent).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(localEvent)
        End Function

        ' GET: LocalEvents/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim localEvent As LocalEvent = db.LocalEvents.Find(id)
            If IsNothing(localEvent) Then
                Return HttpNotFound()
            End If
            Return View(localEvent)
        End Function

        ' POST: LocalEvents/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim localEvent As LocalEvent = db.LocalEvents.Find(id)
            db.LocalEvents.Remove(localEvent)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
