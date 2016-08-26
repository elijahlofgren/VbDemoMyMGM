Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddEventAddressCategory
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.LocalEvents", "Address", Function(c) c.String())
            AddColumn("dbo.LocalEvents", "Category", Function(c) c.String())
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.LocalEvents", "Category")
            DropColumn("dbo.LocalEvents", "Address")
        End Sub
    End Class
End Namespace
