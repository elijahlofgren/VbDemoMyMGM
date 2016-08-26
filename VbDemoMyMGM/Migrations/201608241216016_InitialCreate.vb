Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class InitialCreate
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.LocalEvents",
                Function(c) New With
                    {
                        .ID = c.Int(nullable := False, identity := True),
                        .Title = c.String(),
                        .StartDate = c.DateTime(nullable := False),
                        .Description = c.String(),
                        .Url = c.String()
                    }) _
                .PrimaryKey(Function(t) t.ID)
            
        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.LocalEvents")
        End Sub
    End Class
End Namespace
