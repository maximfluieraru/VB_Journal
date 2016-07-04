<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accueil))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.panelTRieEX = New System.Windows.Forms.TableLayoutPanel()
        Me.lblExtJournal = New System.Windows.Forms.Label()
        Me.btnTrieChron = New System.Windows.Forms.Button()
        Me.btnTrieChronInver = New System.Windows.Forms.Button()
        Me.lbl_L_extension = New System.Windows.Forms.Label()
        Me.lblTrier = New System.Windows.Forms.Label()
        Me.lbw = New System.Windows.Forms.ListBox()
        Me.menu_Top = New System.Windows.Forms.MenuStrip()
        Me.JournalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouveauToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnregistrerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SortirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterÉvénementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtBxDescEvent = New System.Windows.Forms.TextBox()
        Me.ListBox5MotsCles = New System.Windows.Forms.ListBox()
        Me.Panel_MotsClesCateg = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_LesMotsCles = New System.Windows.Forms.Label()
        Me.btnAjoutMotCleEvent = New System.Windows.Forms.Button()
        Me.lblLesCategories = New System.Windows.Forms.Label()
        Me.ListBox_mOTScLES = New System.Windows.Forms.ListBox()
        Me.ListBox_cATEGORIE = New System.Windows.Forms.ListBox()
        Me.lblComments = New System.Windows.Forms.Label()
        Me.panelEnregAnnuler = New System.Windows.Forms.TableLayoutPanel()
        Me.btnEnregEvent = New System.Windows.Forms.Button()
        Me.btnAnulCommMotsCle = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.panelTRieEX.SuspendLayout()
        Me.menu_Top.SuspendLayout()
        Me.ToolStripContainer2.ContentPanel.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel_MotsClesCateg.SuspendLayout()
        Me.panelEnregAnnuler.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.panelTRieEX)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.lbw)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1006, 221)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1006, 245)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.menu_Top)
        '
        'panelTRieEX
        '
        Me.panelTRieEX.ColumnCount = 1
        Me.panelTRieEX.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.panelTRieEX.Controls.Add(Me.lblExtJournal, 0, 1)
        Me.panelTRieEX.Controls.Add(Me.btnTrieChron, 0, 3)
        Me.panelTRieEX.Controls.Add(Me.btnTrieChronInver, 0, 4)
        Me.panelTRieEX.Controls.Add(Me.lbl_L_extension, 0, 0)
        Me.panelTRieEX.Controls.Add(Me.lblTrier, 0, 2)
        Me.panelTRieEX.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelTRieEX.Location = New System.Drawing.Point(800, 0)
        Me.panelTRieEX.Name = "panelTRieEX"
        Me.panelTRieEX.RowCount = 5
        Me.panelTRieEX.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.10526!))
        Me.panelTRieEX.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.89474!))
        Me.panelTRieEX.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.panelTRieEX.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66.0!))
        Me.panelTRieEX.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.panelTRieEX.Size = New System.Drawing.Size(200, 221)
        Me.panelTRieEX.TabIndex = 4
        '
        'lblExtJournal
        '
        Me.lblExtJournal.AutoSize = True
        Me.lblExtJournal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblExtJournal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExtJournal.Location = New System.Drawing.Point(3, 28)
        Me.lblExtJournal.MinimumSize = New System.Drawing.Size(145, 15)
        Me.lblExtJournal.Name = "lblExtJournal"
        Me.lblExtJournal.Size = New System.Drawing.Size(194, 38)
        Me.lblExtJournal.TabIndex = 0
        Me.lblExtJournal.Text = "*.*"
        Me.lblExtJournal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnTrieChron
        '
        Me.btnTrieChron.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnTrieChron.Location = New System.Drawing.Point(3, 93)
        Me.btnTrieChron.MinimumSize = New System.Drawing.Size(145, 21)
        Me.btnTrieChron.Name = "btnTrieChron"
        Me.btnTrieChron.Size = New System.Drawing.Size(194, 60)
        Me.btnTrieChron.TabIndex = 6
        Me.btnTrieChron.Text = "Chronologique"
        Me.btnTrieChron.UseVisualStyleBackColor = True
        '
        'btnTrieChronInver
        '
        Me.btnTrieChronInver.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnTrieChronInver.Location = New System.Drawing.Point(3, 159)
        Me.btnTrieChronInver.MinimumSize = New System.Drawing.Size(145, 21)
        Me.btnTrieChronInver.Name = "btnTrieChronInver"
        Me.btnTrieChronInver.Size = New System.Drawing.Size(194, 59)
        Me.btnTrieChronInver.TabIndex = 5
        Me.btnTrieChronInver.Text = "Chronologique Inverse"
        Me.btnTrieChronInver.UseVisualStyleBackColor = True
        '
        'lbl_L_extension
        '
        Me.lbl_L_extension.AutoSize = True
        Me.lbl_L_extension.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_L_extension.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_L_extension.Location = New System.Drawing.Point(3, 0)
        Me.lbl_L_extension.Name = "lbl_L_extension"
        Me.lbl_L_extension.Size = New System.Drawing.Size(194, 28)
        Me.lbl_L_extension.TabIndex = 8
        Me.lbl_L_extension.Text = "L'extension:"
        Me.lbl_L_extension.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblTrier
        '
        Me.lblTrier.AutoSize = True
        Me.lblTrier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTrier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTrier.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblTrier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrier.Location = New System.Drawing.Point(3, 66)
        Me.lblTrier.Name = "lblTrier"
        Me.lblTrier.Size = New System.Drawing.Size(194, 24)
        Me.lblTrier.TabIndex = 9
        Me.lblTrier.Text = "Trier :"
        Me.lblTrier.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lbw
        '
        Me.lbw.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbw.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbw.FormattingEnabled = True
        Me.lbw.ItemHeight = 18
        Me.lbw.Location = New System.Drawing.Point(0, 0)
        Me.lbw.Name = "lbw"
        Me.lbw.Size = New System.Drawing.Size(800, 221)
        Me.lbw.TabIndex = 3
        '
        'menu_Top
        '
        Me.menu_Top.Dock = System.Windows.Forms.DockStyle.None
        Me.menu_Top.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JournalToolStripMenuItem, Me.ToolStripMenuItem1, Me.AjouterÉvénementToolStripMenuItem})
        Me.menu_Top.Location = New System.Drawing.Point(0, 0)
        Me.menu_Top.Name = "menu_Top"
        Me.menu_Top.Size = New System.Drawing.Size(1006, 24)
        Me.menu_Top.TabIndex = 0
        Me.menu_Top.Text = "MenuStrip1"
        '
        'JournalToolStripMenuItem
        '
        Me.JournalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouveauToolStripMenuItem, Me.OuvrirToolStripMenuItem, Me.EnregistrerToolStripMenuItem, Me.SortirToolStripMenuItem})
        Me.JournalToolStripMenuItem.Name = "JournalToolStripMenuItem"
        Me.JournalToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.JournalToolStripMenuItem.Text = "&Journal"
        '
        'NouveauToolStripMenuItem
        '
        Me.NouveauToolStripMenuItem.Name = "NouveauToolStripMenuItem"
        Me.NouveauToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NouveauToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.NouveauToolStripMenuItem.Text = "&Nouveau"
        '
        'OuvrirToolStripMenuItem
        '
        Me.OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem"
        Me.OuvrirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OuvrirToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.OuvrirToolStripMenuItem.Text = "&Ouvrir"
        '
        'EnregistrerToolStripMenuItem
        '
        Me.EnregistrerToolStripMenuItem.Name = "EnregistrerToolStripMenuItem"
        Me.EnregistrerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.EnregistrerToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.EnregistrerToolStripMenuItem.Text = "Enregi&strer"
        '
        'SortirToolStripMenuItem
        '
        Me.SortirToolStripMenuItem.Name = "SortirToolStripMenuItem"
        Me.SortirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.SortirToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.SortirToolStripMenuItem.Text = "Sortir"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(24, 20)
        Me.ToolStripMenuItem1.Text = "&?"
        '
        'AjouterÉvénementToolStripMenuItem
        '
        Me.AjouterÉvénementToolStripMenuItem.Name = "AjouterÉvénementToolStripMenuItem"
        Me.AjouterÉvénementToolStripMenuItem.Size = New System.Drawing.Size(12, 20)
        '
        'ToolStripContainer2
        '
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.TableLayoutPanel4)
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(1006, 96)
        Me.ToolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer2.Location = New System.Drawing.Point(3, 505)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.Size = New System.Drawing.Size(1006, 121)
        Me.ToolStripContainer2.TabIndex = 3
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.txtBxDescEvent, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.ListBox5MotsCles, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1006, 96)
        Me.TableLayoutPanel4.TabIndex = 4
        '
        'txtBxDescEvent
        '
        Me.txtBxDescEvent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtBxDescEvent.Location = New System.Drawing.Point(506, 3)
        Me.txtBxDescEvent.Multiline = True
        Me.txtBxDescEvent.Name = "txtBxDescEvent"
        Me.txtBxDescEvent.Size = New System.Drawing.Size(497, 90)
        Me.txtBxDescEvent.TabIndex = 5
        '
        'ListBox5MotsCles
        '
        Me.ListBox5MotsCles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox5MotsCles.FormattingEnabled = True
        Me.ListBox5MotsCles.Location = New System.Drawing.Point(3, 3)
        Me.ListBox5MotsCles.Name = "ListBox5MotsCles"
        Me.ListBox5MotsCles.Size = New System.Drawing.Size(497, 90)
        Me.ListBox5MotsCles.TabIndex = 6
        '
        'Panel_MotsClesCateg
        '
        Me.Panel_MotsClesCateg.ColumnCount = 2
        Me.Panel_MotsClesCateg.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Panel_MotsClesCateg.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Panel_MotsClesCateg.Controls.Add(Me.lbl_LesMotsCles, 0, 0)
        Me.Panel_MotsClesCateg.Controls.Add(Me.btnAjoutMotCleEvent, 0, 2)
        Me.Panel_MotsClesCateg.Controls.Add(Me.lblLesCategories, 1, 0)
        Me.Panel_MotsClesCateg.Controls.Add(Me.ListBox_mOTScLES, 0, 1)
        Me.Panel_MotsClesCateg.Controls.Add(Me.ListBox_cATEGORIE, 1, 1)
        Me.Panel_MotsClesCateg.Controls.Add(Me.lblComments, 1, 2)
        Me.Panel_MotsClesCateg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_MotsClesCateg.Location = New System.Drawing.Point(3, 254)
        Me.Panel_MotsClesCateg.Name = "Panel_MotsClesCateg"
        Me.Panel_MotsClesCateg.RowCount = 3
        Me.Panel_MotsClesCateg.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.84615!))
        Me.Panel_MotsClesCateg.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.15385!))
        Me.Panel_MotsClesCateg.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Panel_MotsClesCateg.Size = New System.Drawing.Size(1006, 245)
        Me.Panel_MotsClesCateg.TabIndex = 7
        '
        'lbl_LesMotsCles
        '
        Me.lbl_LesMotsCles.AutoSize = True
        Me.lbl_LesMotsCles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_LesMotsCles.Location = New System.Drawing.Point(3, 0)
        Me.lbl_LesMotsCles.Name = "lbl_LesMotsCles"
        Me.lbl_LesMotsCles.Size = New System.Drawing.Size(497, 29)
        Me.lbl_LesMotsCles.TabIndex = 0
        Me.lbl_LesMotsCles.Text = "LES MOTS CLES"
        Me.lbl_LesMotsCles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAjoutMotCleEvent
        '
        Me.btnAjoutMotCleEvent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAjoutMotCleEvent.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjoutMotCleEvent.Location = New System.Drawing.Point(3, 215)
        Me.btnAjoutMotCleEvent.Name = "btnAjoutMotCleEvent"
        Me.btnAjoutMotCleEvent.Size = New System.Drawing.Size(497, 27)
        Me.btnAjoutMotCleEvent.TabIndex = 5
        Me.btnAjoutMotCleEvent.Text = "Ajouter Mot-Clé"
        '
        'lblLesCategories
        '
        Me.lblLesCategories.AutoSize = True
        Me.lblLesCategories.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLesCategories.Location = New System.Drawing.Point(506, 0)
        Me.lblLesCategories.Name = "lblLesCategories"
        Me.lblLesCategories.Size = New System.Drawing.Size(497, 29)
        Me.lblLesCategories.TabIndex = 1
        Me.lblLesCategories.Text = "LES CATEGORIES"
        Me.lblLesCategories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListBox_mOTScLES
        '
        Me.ListBox_mOTScLES.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox_mOTScLES.FormattingEnabled = True
        Me.ListBox_mOTScLES.HorizontalExtent = 4
        Me.ListBox_mOTScLES.Location = New System.Drawing.Point(3, 32)
        Me.ListBox_mOTScLES.Name = "ListBox_mOTScLES"
        Me.ListBox_mOTScLES.Size = New System.Drawing.Size(497, 177)
        Me.ListBox_mOTScLES.TabIndex = 2
        '
        'ListBox_cATEGORIE
        '
        Me.ListBox_cATEGORIE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox_cATEGORIE.FormattingEnabled = True
        Me.ListBox_cATEGORIE.Location = New System.Drawing.Point(506, 32)
        Me.ListBox_cATEGORIE.Name = "ListBox_cATEGORIE"
        Me.ListBox_cATEGORIE.Size = New System.Drawing.Size(497, 177)
        Me.ListBox_cATEGORIE.TabIndex = 3
        '
        'lblComments
        '
        Me.lblComments.AutoSize = True
        Me.lblComments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblComments.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComments.Location = New System.Drawing.Point(506, 212)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(497, 33)
        Me.lblComments.TabIndex = 6
        Me.lblComments.Text = "Commentaires:"
        Me.lblComments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelEnregAnnuler
        '
        Me.panelEnregAnnuler.ColumnCount = 2
        Me.panelEnregAnnuler.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.panelEnregAnnuler.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.panelEnregAnnuler.Controls.Add(Me.btnEnregEvent, 0, 0)
        Me.panelEnregAnnuler.Controls.Add(Me.btnAnulCommMotsCle, 1, 0)
        Me.panelEnregAnnuler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelEnregAnnuler.Location = New System.Drawing.Point(3, 632)
        Me.panelEnregAnnuler.Name = "panelEnregAnnuler"
        Me.panelEnregAnnuler.RowCount = 1
        Me.panelEnregAnnuler.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.panelEnregAnnuler.Size = New System.Drawing.Size(1006, 31)
        Me.panelEnregAnnuler.TabIndex = 2
        '
        'btnEnregEvent
        '
        Me.btnEnregEvent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEnregEvent.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnregEvent.Location = New System.Drawing.Point(3, 3)
        Me.btnEnregEvent.Name = "btnEnregEvent"
        Me.btnEnregEvent.Size = New System.Drawing.Size(497, 25)
        Me.btnEnregEvent.TabIndex = 0
        Me.btnEnregEvent.Text = "Enregistrer Evenement"
        '
        'btnAnulCommMotsCle
        '
        Me.btnAnulCommMotsCle.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAnulCommMotsCle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAnulCommMotsCle.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnulCommMotsCle.Location = New System.Drawing.Point(506, 3)
        Me.btnAnulCommMotsCle.Name = "btnAnulCommMotsCle"
        Me.btnAnulCommMotsCle.Size = New System.Drawing.Size(497, 25)
        Me.btnAnulCommMotsCle.TabIndex = 1
        Me.btnAnulCommMotsCle.Text = "Annuler "
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.panelEnregAnnuler, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel_MotsClesCateg, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStripContainer2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStripContainer1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 127.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1012, 666)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 666)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menu_Top
        Me.MaximumSize = New System.Drawing.Size(1028, 705)
        Me.Name = "Accueil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TP 1 VB.net"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.panelTRieEX.ResumeLayout(False)
        Me.panelTRieEX.PerformLayout()
        Me.menu_Top.ResumeLayout(False)
        Me.menu_Top.PerformLayout()
        Me.ToolStripContainer2.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.Panel_MotsClesCateg.ResumeLayout(False)
        Me.Panel_MotsClesCateg.PerformLayout()
        Me.panelEnregAnnuler.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents menu_Top As System.Windows.Forms.MenuStrip
    Friend WithEvents JournalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NouveauToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OuvrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjouterÉvénementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents EnregistrerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripContainer2 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents panelEnregAnnuler As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnEnregEvent As System.Windows.Forms.Button
    Friend WithEvents btnAnulCommMotsCle As System.Windows.Forms.Button
    Friend WithEvents lblExtJournal As System.Windows.Forms.Label
    Friend WithEvents btnTrieChron As System.Windows.Forms.Button
    Friend WithEvents btnTrieChronInver As System.Windows.Forms.Button
    Friend WithEvents btnAjoutMotCleEvent As System.Windows.Forms.Button
    Friend WithEvents ListBox5MotsCles As System.Windows.Forms.ListBox
    Friend WithEvents txtBxDescEvent As System.Windows.Forms.TextBox
    Friend WithEvents Panel_MotsClesCateg As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbl_LesMotsCles As System.Windows.Forms.Label
    Friend WithEvents lblLesCategories As System.Windows.Forms.Label
    Friend WithEvents ListBox_mOTScLES As System.Windows.Forms.ListBox
    Friend WithEvents ListBox_cATEGORIE As System.Windows.Forms.ListBox
    Friend WithEvents lblComments As System.Windows.Forms.Label
    Friend WithEvents lbw As System.Windows.Forms.ListBox
    Friend WithEvents lbl_L_extension As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents panelTRieEX As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblTrier As System.Windows.Forms.Label
    Friend WithEvents SortirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
