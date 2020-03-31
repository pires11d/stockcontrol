
''' <summary>
''' Class representing the Valve objects
''' </summary>
Public Class Valve

    Inherits Item

    Public Sub New(id)
        MyBase.New(id)
    End Sub

    Public Shared Types As New List(Of String) From {
        "Simples",
        "Simples c/ Manômetro",
        "Dupla"
    }

End Class
