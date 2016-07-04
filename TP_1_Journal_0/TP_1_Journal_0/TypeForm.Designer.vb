<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TypeForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBoxCateg = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListBoxCateg = New System.Windows.Forms.ListBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtBxCateg = New System.Windows.Forms.TextBox()
        Me.btnAjoutCateg = New System.Windows.Forms.Button()
        Me.btnEffaceCateg = New System.Windows.Forms.Button()
        Me.GroupBoxExtens = New System.Windows.Forms.GroupBox()
        Me.txtBxExten = New System.Windows.Forms.TextBox()
        Me.GroupBoxMotsCles = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ListBoxMotsCles = New System.Windows.Forms.ListBox()
        Me.btnEffacerMotCles = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtBxMotsCles = New System.Windows.Forms.TextBox()
        Me.btnAjoutMotCle = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBoxCateg.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBoxExtens.SuspendLayout()
        Me.GroupBoxMotsCles.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 256)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(494, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(90, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 6
        Me.OK_Button.Text = "Enregistrer"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(337, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 7
        Me.Cancel_Button.Text = "Annuler"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBoxCateg)
        Me.Panel1.Controls.Add(Me.GroupBoxExtens)
        Me.Panel1.Controls.Add(Me.GroupBoxMotsCles)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(494, 256)
        Me.Panel1.TabIndex = 1
        '
        'GroupBoxCateg
        '
        Me.GroupBoxCateg.Controls.Add(Me.GroupBox2)
        Me.GroupBoxCateg.Controls.Add(Me.GroupBox4)
        Me.GroupBoxCateg.Controls.Add(Me.btnEffaceCateg)
        Me.GroupBoxCateg.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBoxCateg.Location = New System.Drawing.Point(0, 37)
        Me.GroupBoxCateg.Name = "GroupBoxCateg"
        Me.GroupBoxCateg.Size = New System.Drawing.Size(287, 219)
        Me.GroupBoxCateg.TabIndex = 10
        Me.GroupBoxCateg.TabStop = False
        Me.GroupBoxCateg.Text = "Categories :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListBoxCateg)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(281, 139)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'ListBoxCateg
        '
        Me.ListBoxCateg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBoxCateg.FormattingEnabled = True
        Me.ListBoxCateg.Location = New System.Drawing.Point(3, 16)
        Me.ListBoxCateg.Name = "ListBoxCateg"
        Me.ListBoxCateg.Size = New System.Drawing.Size(275, 120)
        Me.ListBoxCateg.TabIndex = 8
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtBxCateg)
        Me.GroupBox4.Controls.Add(Me.btnAjoutCateg)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(281, 38)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        '
        'txtBxCateg
        '
        Me.txtBxCateg.Location = New System.Drawing.Point(3, 8)
        Me.txtBxCateg.Name = "txtBxCateg"
        Me.txtBxCateg.Size = New System.Drawing.Size(176, 20)
        Me.txtBxCateg.TabIndex = 2
        '
        'btnAjoutCateg
        '
        Me.btnAjoutCateg.Location = New System.Drawing.Point(203, 6)
        Me.btnAjoutCateg.Name = "btnAjoutCateg"
        Me.btnAjoutCateg.Size = New System.Drawing.Size(75, 23)
        Me.btnAjoutCateg.TabIndex = 3
        Me.btnAjoutCateg.Text = "Ajouter"
        Me.btnAjoutCateg.UseVisualStyleBackColor = True
        '
        'btnEffaceCateg
        '
        Me.btnEffaceCateg.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnEffaceCateg.Location = New System.Drawing.Point(3, 193)
        Me.btnEffaceCateg.Name = "btnEffaceCateg"
        Me.btnEffaceCateg.Size = New System.Drawing.Size(281, 23)
        Me.btnEffaceCateg.TabIndex = 9
        Me.btnEffaceCateg.Text = "Effacer"
        Me.btnEffaceCateg.UseVisualStyleBackColor = True
        '
        'GroupBoxExtens
        '
        Me.GroupBoxExtens.Controls.Add(Me.txtBxExten)
        Me.GroupBoxExtens.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBoxExtens.Location = New System.Drawing.Point(0, 0)
        Me.GroupBoxExtens.Name = "GroupBoxExtens"
        Me.GroupBoxExtens.Size = New System.Drawing.Size(287, 39)
        Me.GroupBoxExtens.TabIndex = 9
        Me.GroupBoxExtens.TabStop = False
        Me.GroupBoxExtens.Text = "Extension :"
        '
        'txtBxExten
        '
        Me.txtBxExten.Location = New System.Drawing.Point(75, 12)
        Me.txtBxExten.Name = "txtBxExten"
        Me.txtBxExten.Size = New System.Drawing.Size(176, 20)
        Me.txtBxExten.TabIndex = 1
        '
        'GroupBoxMotsCles
        '
        Me.GroupBoxMotsCles.Controls.Add(Me.GroupBox3)
        Me.GroupBoxMotsCles.Controls.Add(Me.btnEffacerMotCles)
        Me.GroupBoxMotsCles.Controls.Add(Me.GroupBox1)
        Me.GroupBoxMotsCles.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBoxMotsCles.Location = New System.Drawing.Point(287, 0)
        Me.GroupBoxMotsCles.Name = "GroupBoxMotsCles"
        Me.GroupBoxMotsCles.Size = New System.Drawing.Size(207, 256)
        Me.GroupBoxMotsCles.TabIndex = 7
        Me.GroupBoxMotsCles.TabStop = False
        Me.GroupBoxMotsCles.Text = "Mots Clés :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListBoxMotsCles)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(3, 91)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(201, 139)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        '
        'ListBoxMotsCles
        '
        Me.ListBoxMotsCles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBoxMotsCles.FormattingEnabled = True
        Me.ListBoxMotsCles.Location = New System.Drawing.Point(3, 16)
        Me.ListBoxMotsCles.Name = "ListBoxMotsCles"
        Me.ListBoxMotsCles.Size = New System.Drawing.Size(195, 120)
        Me.ListBoxMotsCles.TabIndex = 10
        '
        'btnEffacerMotCles
        '
        Me.btnEffacerMotCles.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnEffacerMotCles.Location = New System.Drawing.Point(3, 230)
        Me.btnEffacerMotCles.Name = "btnEffacerMotCles"
        Me.btnEffacerMotCles.Size = New System.Drawing.Size(201, 23)
        Me.btnEffacerMotCles.TabIndex = 11
        Me.btnEffacerMotCles.Text = "Effacer"
        Me.btnEffacerMotCles.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtBxMotsCles)
        Me.GroupBox1.Controls.Add(Me.btnAjoutMotCle)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(201, 75)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'txtBxMotsCles
        '
        Me.txtBxMotsCles.Location = New System.Drawing.Point(3, 19)
        Me.txtBxMotsCles.Name = "txtBxMotsCles"
        Me.txtBxMotsCles.Size = New System.Drawing.Size(176, 20)
        Me.txtBxMotsCles.TabIndex = 4
        '
        'btnAjoutMotCle
        '
        Me.btnAjoutMotCle.Location = New System.Drawing.Point(117, 45)
        Me.btnAjoutMotCle.Name = "btnAjoutMotCle"
        Me.btnAjoutMotCle.Size = New System.Drawing.Size(75, 23)
        Me.btnAjoutMotCle.TabIndex = 5
        Me.btnAjoutMotCle.Text = "Ajouter"
        Me.btnAjoutMotCle.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'TypeForm
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(494, 285)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TypeForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TypeForm"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBoxCateg.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBoxExtens.ResumeLayout(False)
        Me.GroupBoxExtens.PerformLayout()
        Me.GroupBoxMotsCles.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtBxExten As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxMotsCles As System.Windows.Forms.GroupBox
    Friend WithEvents ListBoxCateg As System.Windows.Forms.ListBox
    Friend WithEvents GroupBoxExtens As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxCateg As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBxCateg As System.Windows.Forms.TextBox
    Friend WithEvents btnAjoutCateg As System.Windows.Forms.Button
    Friend WithEvents btnEffaceCateg As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBxMotsCles As System.Windows.Forms.TextBox
    Friend WithEvents btnAjoutMotCle As System.Windows.Forms.Button
    Friend WithEvents ListBoxMotsCles As System.Windows.Forms.ListBox
    Friend WithEvents btnEffacerMotCles As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider

End Class
