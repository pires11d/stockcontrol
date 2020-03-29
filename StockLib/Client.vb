
''' <summary>
''' Class representing the Clients and all their associated information, for example:
''' <para></para>Name;
''' <para></para>Phone number;
''' <para></para>Street name + house number;
''' <para></para>Apartment number (if available);
''' <para></para>Neighborhood;
''' <para></para>Location (city and state).
''' </summary>
Public Class Client

    Public Sub New(name As String)
        Me.Name = name
    End Sub

    Private p_ID As Integer
    Public Property ID() As Integer
        Get
            Return p_ID
        End Get
        Set(ByVal value As Integer)
            p_ID = value
        End Set
    End Property

    Private p_Name As String
    Public Property Name() As String
        Get
            Return p_Name
        End Get
        Set(ByVal value As String)
            p_Name = value
        End Set
    End Property

    Private p_Phone As String
    Public Property Phone() As String
        Get
            Return p_Phone
        End Get
        Set(ByVal value As String)
            p_Phone = value
        End Set
    End Property

    Private p_Street As String
    Public Property Address() As String
        Get
            Return p_Street
        End Get
        Set(ByVal value As String)
            p_Street = value
        End Set
    End Property

    Private p_Complement As String
    Public Property AddressComplement() As String
        Get
            Return p_Complement
        End Get
        Set(ByVal value As String)
            p_Complement = value
        End Set
    End Property

    Private p_Neighborhood As String
    Public Property Neighborhood() As String
        Get
            Return p_Neighborhood
        End Get
        Set(ByVal value As String)
            p_Neighborhood = value
        End Set
    End Property

    Private p_Location As String
    Public Property Location() As String
        Get
            Return p_Location
        End Get
        Set(ByVal value As String)
            p_Location = value
        End Set
    End Property

    Public ReadOnly Property FullAddress() As String
        Get
            Dim myInfo As String() = {Address, AddressComplement, Neighborhood, Location}
            Dim result = Extensions.JoinText(myInfo)
            Return result
        End Get
    End Property




End Class
