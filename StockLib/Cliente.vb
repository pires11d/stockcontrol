﻿

Public Class Cliente

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
            Return Extensions.JoinText(myInfo)
        End Get
    End Property




End Class
