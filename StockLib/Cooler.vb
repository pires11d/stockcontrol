
''' <summary>
''' Class representing the Beer Cooler objects
''' </summary>
Public Class Cooler

    Inherits Item

    Public Sub New(id)
        MyBase.New(id)
        MyBase.Kind = Item.Kinds.Chopeira
    End Sub

    Public Shared Types As New List(Of String) From {
        "1 Torneira",
        "1 Torneira c/ Gelo",
        "2 Torneiras"
    }

End Class
