Imports System.ComponentModel

<Serializable()>
Public Class Type

#Region "Les Membres 'Private'"

    Private _extension As String
    Private _motsCles As BindingList(Of String)
    Private _categories As BindingList(Of String)

#End Region

#Region "Les Constructeurs"

    Sub New()
        Me.MotCles = New BindingList(Of String)
        Me.Categories = New BindingList(Of String)
    End Sub

    Sub New(ByVal extension As String, ByVal motscles As BindingList(Of String), ByVal categories As BindingList(Of String))
        Me.New()
        Me.Extension = extension
        Me.MotCles = motscles
        Me.Categories = categories
    End Sub


#End Region

#Region "Les 'Property' publics"

    Public Property Extension() As String
        Get
            Return _extension
        End Get
        Set(ByVal value As String)
            _extension = value
        End Set
    End Property

    Public Property MotCles() As BindingList(Of String)
        Get
            Return _motsCles
        End Get
        Set(ByVal value As BindingList(Of String))
            _motsCles = value
        End Set
    End Property

    Public Property Categories() As BindingList(Of String)
        Get
            Return _categories
        End Get
        Set(ByVal value As BindingList(Of String))
            _categories = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return concat()
    End Function

    Private Function concat() As String

        Dim cat As String = ""
        Dim mot As String = ""

        For Each catg As String In Categories
            cat &= " \ " & catg
        Next

        For Each motc As String In MotCles
            mot &= " \ " & motc
        Next

        Return "Exten. - ." & Extension & " * " & " Categ. - " & cat & " * " & " Mots-Clés - " & mot

    End Function

#End Region

End Class
