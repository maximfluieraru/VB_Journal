Imports System.ComponentModel

<Serializable()>
Public Class Journal

#Region "Les Membres 'Private'"

    Private _type As Type
    Private _evenements As BindingList(Of Evenement)

#End Region

#Region "Les Constructeurs"


    Sub New()

    End Sub


    Sub New(ByVal type As Type)
        Me.TYPE = type
        Me.Evenements = New BindingList(Of Evenement)
    End Sub

#End Region

#Region "Les 'Property' publics"

    Public Property TYPE() As Type
        Get
            Return _type
        End Get
        Set(ByVal value As Type)
            _type = value
        End Set
    End Property

    Public Property Evenements() As BindingList(Of Evenement)
        Get
            Return _evenements
        End Get
        Set(ByVal value As BindingList(Of Evenement))
            _evenements = value
        End Set
    End Property

#End Region

End Class
