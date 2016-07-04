Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Xml.Serialization
Imports System.IO

Public Class JournalForm

    Private WithEvents _tfrm As TypeForm
    Private _fn As String = Application.StartupPath & "\Journaux\listtype.xml"
    Private Shared _listType As New BindingList(Of Type)
    Public Event _type_select(ByVal value As Type)
    Private nb_de_Type As Integer

    Private Sub JournalForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Dim xmlForamtFichierC As New XmlSerializer(_listType.GetType)
            Dim fichier As New FileStream(_fn, FileMode.Open, FileAccess.Read)
            _listType = xmlForamtFichierC.Deserialize(fichier)
            fichier.Close()
        Catch ex As Exception
            MessageBox.Show("Aucun type de journal enregistré!", "Info", Nothing, MessageBoxIcon.Information)
        End Try

        listBox_ListType.DataSource = _listType
        nb_de_Type = _listType.Count

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        _tfrm = New TypeForm : _tfrm.ShowDialog()
    End Sub

    ''' <summary>
    ''' Ajouter un nouveau type de journal dans la collectione _listeType
    ''' </summary>
    ''' <param name="value">le nouveau type cree</param>
    ''' <remarks>methode est appeler par lr bouton OK de TypeForm</remarks>
    Private Sub ajouterType(ByVal value As Type) Handles _tfrm._nouveauType
        _listType.Add(value)
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click, listBox_ListType.DoubleClick

        If listBox_ListType.SelectedIndex <> -1 Then
            RaiseEvent _type_select(listBox_ListType.SelectedItem)
            Me.Close()
        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub JournalForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        If nb_de_Type <> _listType.Count Then

            Try
                Dim xmlFormatClient As New XmlSerializer(_listType.GetType)

                Dim fstrC As New FileStream(_fn, FileMode.OpenOrCreate, FileAccess.Write)
                Dim fwrC As New StreamWriter(fstrC, System.Text.Encoding.UTF8)

                xmlFormatClient.Serialize(fwrC, _listType)

                fwrC.Close()
                fstrC.Close()

            Catch ex As Exception
                MessageBox.Show("Les type n'ont pas été enrégistrés!" & vbCrLf & "SVP contactez l'administrateur.", "Alerte!", Nothing, MessageBoxIcon.Warning)
            End Try

        End If

    
    End Sub


End Class
