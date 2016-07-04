Imports System.ComponentModel
Imports System.IO
Imports System.Xml.Serialization

Public Class Accueil

    Private WithEvents _jfrm As JournalForm

    Private _jrnl As New Journal
    Private _type As Type
    Private _evnt As Evenement
    Private _locJrnl As String = vbNullString

    Private sl_categ As New SortedList(Of Integer, String)
    Private sl_mots As New SortedList(Of Integer, BindingList(Of String))

    Private _listMotsClesEvent As New BindingList(Of String)

    Private Sub Accueil_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        e.Cancel = fermer()

    End Sub

    Private Sub SortirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SortirToolStripMenuItem.Click

        If fermer() Then : Exit Sub
        Else : Application.Exit()
        End If

    End Sub
    ''' <summary>
    ''' La méthode est apple a la ferméture de la form Accueil  
    ''' </summary>
    ''' <returns>Boolean</returns>
    ''' <remarks>Enregistre les modification OUI NO Cancel </remarks>
    Private Function fermer() As Boolean

        If Me.Text.Contains("*") Then

            Dim rep = MessageBox.Show("Voulez-vous enregistrer les événememts ajouter?", "Confirmer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk)
            If rep = Windows.Forms.DialogResult.Yes Then : EnregistrerToolStripMenuItem_Click(Nothing, Nothing)
                Return False
            ElseIf rep = Windows.Forms.DialogResult.Cancel Then
                Return True
            End If
        End If

        Return False

    End Function


    ''' <summary>
    ''' Chargement de 'Form' Accueil 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>la methode <see cref="activeComponents" >activeComponents</see> est appelée pour desactiver certains panel</remarks>
    Private Sub Accueil_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ListBox5MotsCles.DataSource = _listMotsClesEvent
        activeComponents(False)

    End Sub

    ''' <summary>
    ''' La méthode est utiliser pour ouvrir un journal déjà enregistré 
    ''' </summary>
    ''' <param name="sender">Bouton ouvrir de menu Journal</param>
    ''' <param name="e">Click</param>
    ''' <remarks>la méthode <see cref="jrnlActive">jrnlActif</see> est applée pour affecter les controleurs est charger les liste </remarks> 
    Private Sub OuvrirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OuvrirToolStripMenuItem.Click

        If Me.Text.Contains("*") Then

            Dim rep = MessageBox.Show("Voulez-vous enregistrer les événememts ajouter?", "Confirmer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk)
            If rep = Windows.Forms.DialogResult.Yes Then : EnregistrerToolStripMenuItem_Click(sender, e)
                MessageBox.Show("Les événements ont été enregistre." & vbCrLf & "Vous pouvez ouvrir un autre journal.", "Confirmation")
            ElseIf rep = Windows.Forms.DialogResult.Cancel Then : Exit Sub
            End If
        End If

        Using ofd As New Windows.Forms.OpenFileDialog

            ofd.InitialDirectory = Application.StartupPath & "\Journaux"
            If DialogResult.OK = ofd.ShowDialog Then
                _locJrnl = ofd.FileName
                Try
                    Dim xmlForamtFichierC As New XmlSerializer(_jrnl.GetType)
                    Dim fichier As New FileStream(_locJrnl, FileMode.Open, FileAccess.Read)
                    _jrnl = xmlForamtFichierC.Deserialize(fichier)

                    fichier.Close()

                    jrnlActive(ofd.SafeFileName, True, ofd.FileName)
                    btnTrieChronInver_Click(sender, e)

                Catch ex As Exception
                    MessageBox.Show("Le fichier est corrompu!!!", "Avertissement", Nothing, MessageBoxIcon.Warning)
                End Try
            End If
        End Using

    End Sub
    
    ''' <summary>
    ''' Creer un nouveau Journal.
    ''' </summary>
    ''' <param name="value">le type pour creer un journal dans la collection _listType</param>
    ''' <remarks>la methode est appeler par le bouton OK de <see cref="JournalForm.OK_Button">JournalForm</see>. 
    ''' La méthode <see cref="jrnlActive">jrnlActif</see> est applée pour affecter les controleurs est charger les liste</remarks>
    Private Sub creerJournal(ByVal value As Type) Handles _jfrm._type_select

        _jrnl = New Journal(value)
        jrnlActive("." & _jrnl.TYPE.Extension, True, vbNullString)

    End Sub

    Private Sub jrnlActive(ByVal fn As String, ByVal nouveauJRNL As Boolean, ByVal locJ As String)
        sl_categ.Clear()
        sl_mots.Clear()

        Dim i = 0
        For Each e In _jrnl.Evenements
            sl_categ.Add(i, e.Categorie)
            sl_mots.Add(i, e.Mots_Cles)
            i += 1
            lbw.Items.Add(e)
        Next

        If nouveauJRNL Then
            _locJrnl = locJ
            Me.Text = fn

            lblExtJournal.Text = "." & _jrnl.TYPE.Extension

            ListBox_cATEGORIE.DataSource = _jrnl.TYPE.Categories
            ListBox_mOTScLES.DataSource = _jrnl.TYPE.MotCles
            ListBox5MotsCles.DataSource = _listMotsClesEvent

            activeComponents(True)

        End If

    End Sub

    Sub activeComponents(ByVal value As Boolean)

        panelTRieEX.Enabled = value
        Panel_MotsClesCateg.Enabled = value
        EnregistrerToolStripMenuItem.Enabled = value
        panelEnregAnnuler.Enabled = value
        lbw.Enabled = value
    End Sub



    Private Sub NouveauToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NouveauToolStripMenuItem.Click
        _jfrm = New JournalForm : _jfrm.ShowDialog()
    End Sub
   
    Private Sub btnAjoutMotCleEvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjoutMotCleEvent.Click, ListBox_mOTScLES.DoubleClick

        If _listMotsClesEvent.Count < 5 And ListBox_mOTScLES.SelectedIndex > -1 Then
            Dim mot = ListBox_mOTScLES.SelectedItem

            If _listMotsClesEvent.Contains(mot) Then
                MessageBox.Show("Le mot-clé <" & mot & "> éxiste déjà!", vbNullString, Nothing, MessageBoxIcon.Information)
            Else : _listMotsClesEvent.Add(ListBox_mOTScLES.SelectedItem)
                ListBox_cATEGORIE.Enabled = False
            End If
        Else
            If ListBox_mOTScLES.SelectedIndex = -1 Then
                MessageBox.Show("Il faut selectionner un mot-cles!", "MEMO", Nothing, MessageBoxIcon.Asterisk)
            Else
                MessageBox.Show("La limit de mots-cles a été atteint!", "Atention!", Nothing, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub btnEnregEvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnregEvent.Click

        If _listMotsClesEvent.Count > 0 And ListBox_cATEGORIE.SelectedIndex > -1 Then

            _evnt = New Evenement(ListBox_cATEGORIE.SelectedItem, _listMotsClesEvent, txtBxDescEvent.Text)
            _jrnl.Evenements.Add(_evnt)

            ListBox_cATEGORIE.Enabled = True
            txtBxDescEvent.Text = vbNullString
            _listMotsClesEvent = New BindingList(Of String)
            ListBox5MotsCles.DataSource = _listMotsClesEvent

            Dim evenemEnreg = _jrnl.Evenements.Count

            jrnlActive(vbNullString, False, vbNullString)

            btnTrieChron_Click(sender, e)

            If evenemEnreg > 0 Then : lbw.SelectedIndex = evenemEnreg - 1 : End If

            If Me.Text.Contains("*") Then : Exit Sub : Else : Me.Text &= "*" : End If

        Else
            If ListBox_cATEGORIE.SelectedIndex = -1 Then
                MessageBox.Show("Il faut selectionner une catégorie" & vbCrLf & "pour enrégistrer un evenement!", "MEMO", Nothing, MessageBoxIcon.Asterisk)
                ListBox_cATEGORIE.Enabled = True
            Else
                MessageBox.Show("Il faut ajouter minimum un mot-clé" & vbCrLf & "pour enrégistrer un evenement!", "MEMO", Nothing, MessageBoxIcon.Asterisk)
                Exit Sub
            End If
            
        End If
    End Sub

    Private Sub btnTrieChronInver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrieChronInver.Click
        ListBox_cATEGORIE.SelectedIndex = -1
        ListBox_mOTScLES.SelectedIndex = -1

        lbw.Items.Clear()
        Dim list = _jrnl.Evenements
        Dim i = list.Count - 1
        For Each a In list
            lbw.Items.Add(list(i))
            i -= 1
        Next
        
    End Sub

    Private Sub btnTrieChron_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrieChron.Click
        ListBox_cATEGORIE.SelectedIndex = -1
        ListBox_mOTScLES.SelectedIndex = -1
        lbw.Items.Clear()
        For Each a In _jrnl.Evenements
            lbw.Items.Add(a)
        Next

    End Sub


   

    Private Sub EnregistrerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnregistrerToolStripMenuItem.Click

        If _jrnl Is Nothing Then
            Exit Sub
        Else

            If _locJrnl Is vbNullString Then

                Dim ext As String = _jrnl.TYPE.Extension

                Dim sfd As New Windows.Forms.SaveFileDialog

                sfd.InitialDirectory = Application.StartupPath & "\Journaux"

                sfd.Filter = "Journal (." & ext & ")|." & ext & ""
                sfd.AddExtension = True
                sfd.DefaultExt = ext

                Dim reponse = sfd.ShowDialog

                If reponse = Windows.Forms.DialogResult.OK Then : _locJrnl = sfd.FileName : Else : Exit Sub : End If

            End If

            enregJrnl_ofd(_locJrnl)

            If Me.Text.Contains("*") Then : Me.Text &= Me.Text.Substring(0, Me.Text.Length - 1) : End If


        End If
    End Sub


    Private Sub enregJrnl_ofd(ByVal fn As String)

        Try
            Dim xmlFormatClient As New XmlSerializer(_jrnl.GetType)

            Dim fstrC As New FileStream(fn, FileMode.OpenOrCreate, FileAccess.Write)
            Dim fwrC As New StreamWriter(fstrC, System.Text.Encoding.UTF8)

            xmlFormatClient.Serialize(fwrC, _jrnl)

            fwrC.Close()
            fstrC.Close()

            Me.Text = Me.Text.Substring(0, Me.Text.Length - 1)
        Catch ex As Exception
            MessageBox.Show("Le fichier n'a pas été enregisté!", "Alerte!", Nothing, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnAnulCommMotsCle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnulCommMotsCle.Click
        btnTrieChronInver_Click(sender, e)
        ListBox_cATEGORIE.SelectedIndex = -1
        ListBox_mOTScLES.SelectedIndex = -1
        txtBxDescEvent.Text = vbNullString
        _listMotsClesEvent.Clear()
        ListBox_cATEGORIE.Enabled = True

    End Sub

    Private Sub ListBox_mOTScLES_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox_mOTScLES.SelectedIndexChanged
        lbw.Items.Clear()
        Dim s = ListBox_mOTScLES.SelectedItem
        Dim l = _jrnl.Evenements()
        Dim k = sl_mots.Keys
        For Each a In k
            If sl_mots.Item(a).Contains(s) Then
                lbw.Items.Add(l(a))
            End If
        Next
    End Sub

    Private Sub ListBox_cATEGORIE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox_cATEGORIE.SelectedIndexChanged
        lbw.Items.Clear()
        Dim s = ListBox_cATEGORIE.SelectedItem
        Dim l = _jrnl.Evenements()
        Dim k = sl_categ.Keys
        For Each a In k
            If sl_categ.Item(a).Equals(s) Then
                lbw.Items.Add(l(a))
            End If
        Next
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        MessageBox.Show("Realiser de:" & vbCrLf & "Maxim Fluieraru")
    End Sub


End Class
