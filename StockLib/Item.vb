﻿
''' <summary>
''' Class representing any identifiable Item of all inventory objects
''' </summary>
Public MustInherit Class Item

    Public Enum Kinds
        Barrel
        Cooler
        Cylinder
        Valve
    End Enum

    Public Sub New(id As String)
        Me.ID = id
    End Sub

    Private p_ID As String
    Public Property ID() As String
        Get
            Return p_ID
        End Get
        Set(ByVal value As String)
            p_ID = value
        End Set
    End Property

    Private p_Kind As Kinds
    Public Property Kind() As Kinds
        Get
            Return p_Kind
        End Get
        Set(ByVal value As Kinds)
            p_Kind = value
        End Set
    End Property

    Private p_Type As String
    Public Property Type() As String
        Get
            Return p_Type
        End Get
        Set(ByVal value As String)
            p_Type = value
        End Set
    End Property

    Private p_State As Boolean
    Public Property State() As Boolean
        Get
            Return p_State
        End Get
        Set(ByVal value As Boolean)
            p_State = value
        End Set
    End Property

    Private p_Orders As New List(Of Order)
    Public Property Orders() As List(Of Order)
        Get
            Return p_Orders
        End Get
        Set(ByVal value As List(Of Order))
            p_Orders = value
        End Set
    End Property

End Class