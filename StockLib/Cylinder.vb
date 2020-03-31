
''' <summary>
''' Class representing the CO2 Gas Cylinder objects
''' </summary>
Public Class Cylinder

    Inherits Item

    Public Sub New(id)
        MyBase.New(id)
    End Sub

    Public Shared Types As New List(Of String) From {
        "4kg",
        "6kg",
        "9kg"
    }

End Class
