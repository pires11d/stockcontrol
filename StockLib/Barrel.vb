
''' <summary>
''' Class representing the identified Barrel objects
''' </summary>
Public Class Barrel

    Inherits Item

    Public Sub New(id)
        MyBase.New(id)
        MyBase.Kind = Item.Kinds.Barril
    End Sub

    Public Shared Types As New List(Of String) From {
        "E-30L",
        "E-50L",
        "S-10L",
        "S-15L",
        "S-30L"
    }

End Class
