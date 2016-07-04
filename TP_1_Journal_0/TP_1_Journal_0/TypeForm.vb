Imports System.Windows.Forms
Imports System.ComponentModel

Imports System.Text.RegularExpressions

Public Class TypeForm
    Public Event _nouveauType(ByVal value As Type)

    Dim listCateg As BindingList(Of String)
    Dim listMotsCles As BindingList(Of String)

    Private Sub TypeForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        listCateg = New BindingList(Of String)
        listMotsCles = New BindingList(Of String)
        ListBoxCateg.DataSource = listCateg
        ListBoxMotsCles.DataSource = listMotsCles
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        ErrorProvider1.Clear()

        If String.IsNullOrWhiteSpace(txtBxExten.Text) Or String.IsNullOrEmpty(txtBxExten.Text) Then
            ErrorProvider1.SetError(txtBxExten, "Ajouter un extension SVP!")
        ElseIf Not Regex.IsMatch(txtBxExten.Text, "^[a-zA-Z]+$") Then
            ErrorProvider1.SetError(txtBxExten, "[A-z]")
        ElseIf Not listCateg.Count > 0 Then
            ErrorProvider1.SetError(txtBxCateg, "Il faut ajouter une categorie SVP")
        ElseIf Not listMotsCles.Count > 0 Then
            ErrorProvider1.SetError(txtBxMotsCles, "Il faut ajouter un mot cles SVP") 
        Else
            Dim a As Type = newType()

            RaiseEvent _nouveauType(a)

            Me.Close()
        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Function newType() As Type
        Return New Type(txtBxExten.Text.Trim, listMotsCles, listCateg)
    End Function

    Private Sub btnAjoutCateg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjoutCateg.Click

        Dim text_ As String = txtBxCateg.Text.Trim
        If Not String.IsNullOrWhiteSpace(text_) Or Not String.IsNullOrEmpty(text_) Then

            If listCateg.Contains(text_) Then
                MessageBox.Show("La catégorie <" & text_ & "> éxiste déjà!", vbNullString, Nothing, MessageBoxIcon.Information)
            Else
                listCateg.Add(text_)
                txtBxCateg.Clear()
            End If
        End If
        txtBxCateg.Focus()

    End Sub

    Private Sub btnAjoutMotCle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjoutMotCle.Click

        Dim text_ As String = txtBxMotsCles.Text.Trim

        If Not String.IsNullOrWhiteSpace(text_) Or Not String.IsNullOrEmpty(text_) Then

            If listMotsCles.Contains(text_) Then
                MessageBox.Show("Le mot-clé <" & text_ & "> éxiste déjà!", vbNullString, Nothing, MessageBoxIcon.Information)
            Else
                listMotsCles.Add(text_)
                txtBxMotsCles.Clear()
            End If
        End If
        txtBxMotsCles.Focus()

    End Sub


    Private Sub btnEffaceCateg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEffaceCateg.Click

        Dim rep = MessageBox.Show("Voulez-vous effacer la catégorie <" & ListBoxCateg.SelectedItem & ">?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)

        If rep = Windows.Forms.DialogResult.Yes Then
            Dim i As Integer = ListBoxCateg.SelectedIndex
            If i <> -1 Then
                listCateg.RemoveAt(i)
            End If
        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEffacerMotCles.Click

        Dim rep = MessageBox.Show("Voulez-vous effacer le mot-clé <" & ListBoxMotsCles.SelectedItem & ">?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)

        If rep = Windows.Forms.DialogResult.Yes Then
            Dim i As Integer = ListBoxMotsCles.SelectedIndex
            If i <> -1 Then
                listMotsCles.RemoveAt(i)
            End If
        End If

    End Sub

    Private Sub txtBxCateg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBxCateg.TextChanged, txtBxExten.TextChanged, txtBxMotsCles.TextChanged
        ErrorProvider1.Clear()
    End Sub

End Class
