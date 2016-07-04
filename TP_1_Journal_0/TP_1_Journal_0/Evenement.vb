Imports System.ComponentModel
<Serializable()>
Public Class Evenement

#Region "Les Membres 'Private'"

    Private _categorie As String
    Private _motsCles As BindingList(Of String)
    Private _date_Heure As DateTime
    Private _description As String

#End Region

#Region "Les Constructeurs"

    Sub New()
        Me.Date_Heure = Now
        Me.Mots_Cles = New BindingList(Of String)
    End Sub


    Sub New(ByVal categorie As String, ByVal motsCles As BindingList(Of String), ByVal description As String)
        Me.New()
        Me.Categorie = categorie
        Me.Mots_Cles = motsCles
        Me.Description = description
    End Sub

#End Region

#Region "Les 'Property' publics"

    Public Property Categorie() As String
        Get
            Return _categorie
        End Get
        Set(ByVal value As String)
            _categorie = value
        End Set
    End Property

    Public Property Mots_Cles() As BindingList(Of String)
        Get
            Return _motsCles
        End Get
        Set(ByVal value As BindingList(Of String))
            _motsCles = value
        End Set
    End Property

    Public Property Date_Heure() As DateTime
        Get
            Return _date_Heure
        End Get
        Set(ByVal value As DateTime)
            _date_Heure = value
        End Set
    End Property

    Public Property Description() As String
        Get
            Return _description
        End Get
        Set(ByVal value As String)
            If value IsNot Nothing Then
                _description = value
            End If
        End Set
    End Property

    Public Overrides Function ToString() As String

        Dim evnt As String = ""

        For Each e As String In Mots_Cles
            evnt &= e & " \ "
        Next

        Return Date_Heure & " # " & Categorie & " # " & evnt & " # " & Description
    End Function

#End Region

End Class
