﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.but_Anal = New System.Windows.Forms.Button()
        Me.but_sync = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.But_selAll = New System.Windows.Forms.Button()
        Me.But_UnSel = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.lb_peret1 = New System.Windows.Forms.Label()
        Me.bt_LoadCfg = New System.Windows.Forms.Button()
        Me.bt_setManualMainChekedNode = New System.Windows.Forms.Button()
        Me.bt_saveAllCfg = New System.Windows.Forms.Button()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.TreeViewContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ПереименоватьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.УдалитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.lb_peret2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lb_NewGPath = New System.Windows.Forms.Label()
        Me.lb_NewGId = New System.Windows.Forms.Label()
        Me.bt_showCheckedNodesButton = New System.Windows.Forms.Button()
        Me.TreeView2 = New System.Windows.Forms.TreeView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bt_pasteNewGen = New System.Windows.Forms.Button()
        Me.bt_replaceNewGen = New System.Windows.Forms.Button()
        Me.bt_LoadNewGen = New System.Windows.Forms.Button()
        Me.bt_compare = New System.Windows.Forms.Button()
        Me.bt_saveID = New System.Windows.Forms.Button()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lb_maxId = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lb_cfgId = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lb_cfgPath = New System.Windows.Forms.Label()
        Me.lb_mainChekedNode = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tbManualDir = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LogTextBox = New System.Windows.Forms.RichTextBox()
        Me.TreeImageList = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TreeViewContextMenu.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(370, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 38)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Настройка синхронизации..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(19, 17)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(95, 20)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "192.168.209.17"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView1.Location = New System.Drawing.Point(4, 98)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(964, 382)
        Me.DataGridView1.TabIndex = 4
        '
        'but_Anal
        '
        Me.but_Anal.Location = New System.Drawing.Point(4, 10)
        Me.but_Anal.Name = "but_Anal"
        Me.but_Anal.Size = New System.Drawing.Size(141, 38)
        Me.but_Anal.TabIndex = 5
        Me.but_Anal.Text = "Анализ"
        Me.but_Anal.UseVisualStyleBackColor = True
        '
        'but_sync
        '
        Me.but_sync.Enabled = False
        Me.but_sync.Location = New System.Drawing.Point(4, 55)
        Me.but_sync.Name = "but_sync"
        Me.but_sync.Size = New System.Drawing.Size(141, 38)
        Me.but_sync.TabIndex = 10
        Me.but_sync.Text = "Синхронизация"
        Me.but_sync.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 15)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(49, 17)
        Me.RadioButton1.TabIndex = 11
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Туда"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 37)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(52, 17)
        Me.RadioButton2.TabIndex = 12
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Сюда"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 60)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(79, 17)
        Me.RadioButton3.TabIndex = 13
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Туда-Сюда"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Location = New System.Drawing.Point(151, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(98, 88)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Куда?"
        '
        'But_selAll
        '
        Me.But_selAll.Location = New System.Drawing.Point(255, 54)
        Me.But_selAll.Name = "But_selAll"
        Me.But_selAll.Size = New System.Drawing.Size(109, 38)
        Me.But_selAll.TabIndex = 15
        Me.But_selAll.Text = "Выбрать всё"
        Me.But_selAll.UseVisualStyleBackColor = True
        '
        'But_UnSel
        '
        Me.But_UnSel.Location = New System.Drawing.Point(255, 10)
        Me.But_UnSel.Name = "But_UnSel"
        Me.But_UnSel.Size = New System.Drawing.Size(109, 38)
        Me.But_UnSel.TabIndex = 16
        Me.But_UnSel.Text = "Снять выбор"
        Me.But_UnSel.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(984, 512)
        Me.TabControl1.TabIndex = 17
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SplitContainer2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.lb_maxId)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.lb_cfgId)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.lb_cfgPath)
        Me.TabPage2.Controls.Add(Me.lb_mainChekedNode)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(976, 486)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "ID для Alpha.Server"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.lb_peret1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.bt_LoadCfg)
        Me.SplitContainer2.Panel1.Controls.Add(Me.bt_setManualMainChekedNode)
        Me.SplitContainer2.Panel1.Controls.Add(Me.bt_saveAllCfg)
        Me.SplitContainer2.Panel1.Controls.Add(Me.TreeView1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.TabControl2)
        Me.SplitContainer2.Size = New System.Drawing.Size(973, 402)
        Me.SplitContainer2.SplitterDistance = 458
        Me.SplitContainer2.TabIndex = 43
        '
        'lb_peret1
        '
        Me.lb_peret1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_peret1.AutoSize = True
        Me.lb_peret1.BackColor = System.Drawing.Color.White
        Me.lb_peret1.ForeColor = System.Drawing.Color.DarkGray
        Me.lb_peret1.Location = New System.Drawing.Point(186, 210)
        Me.lb_peret1.Name = "lb_peret1"
        Me.lb_peret1.Size = New System.Drawing.Size(97, 13)
        Me.lb_peret1.TabIndex = 25
        Me.lb_peret1.Text = "+ Перетащи сюда"
        Me.lb_peret1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'bt_LoadCfg
        '
        Me.bt_LoadCfg.Location = New System.Drawing.Point(5, 3)
        Me.bt_LoadCfg.Name = "bt_LoadCfg"
        Me.bt_LoadCfg.Size = New System.Drawing.Size(100, 36)
        Me.bt_LoadCfg.TabIndex = 29
        Me.bt_LoadCfg.Text = "Загрузить конфигурацию"
        Me.bt_LoadCfg.UseVisualStyleBackColor = True
        '
        'bt_setManualMainChekedNode
        '
        Me.bt_setManualMainChekedNode.Enabled = False
        Me.bt_setManualMainChekedNode.Location = New System.Drawing.Point(215, 3)
        Me.bt_setManualMainChekedNode.Name = "bt_setManualMainChekedNode"
        Me.bt_setManualMainChekedNode.Size = New System.Drawing.Size(81, 36)
        Me.bt_setManualMainChekedNode.TabIndex = 40
        Me.bt_setManualMainChekedNode.Text = "Установить на замену"
        Me.bt_setManualMainChekedNode.UseVisualStyleBackColor = True
        '
        'bt_saveAllCfg
        '
        Me.bt_saveAllCfg.Location = New System.Drawing.Point(109, 3)
        Me.bt_saveAllCfg.Name = "bt_saveAllCfg"
        Me.bt_saveAllCfg.Size = New System.Drawing.Size(100, 36)
        Me.bt_saveAllCfg.TabIndex = 36
        Me.bt_saveAllCfg.Text = "Сохранить конфигурацию"
        Me.bt_saveAllCfg.UseVisualStyleBackColor = True
        '
        'TreeView1
        '
        Me.TreeView1.AllowDrop = True
        Me.TreeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.ContextMenuStrip = Me.TreeViewContextMenu
        Me.TreeView1.HideSelection = False
        Me.TreeView1.Location = New System.Drawing.Point(3, 45)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(452, 353)
        Me.TreeView1.TabIndex = 27
        '
        'TreeViewContextMenu
        '
        Me.TreeViewContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ПереименоватьToolStripMenuItem, Me.УдалитьToolStripMenuItem})
        Me.TreeViewContextMenu.Name = "TreeViewContextMenu"
        Me.TreeViewContextMenu.Size = New System.Drawing.Size(162, 48)
        '
        'ПереименоватьToolStripMenuItem
        '
        Me.ПереименоватьToolStripMenuItem.Enabled = False
        Me.ПереименоватьToolStripMenuItem.Name = "ПереименоватьToolStripMenuItem"
        Me.ПереименоватьToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ПереименоватьToolStripMenuItem.Text = "Переименовать"
        '
        'УдалитьToolStripMenuItem
        '
        Me.УдалитьToolStripMenuItem.Enabled = False
        Me.УдалитьToolStripMenuItem.Name = "УдалитьToolStripMenuItem"
        Me.УдалитьToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.УдалитьToolStripMenuItem.Text = "Удалить"
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Location = New System.Drawing.Point(3, 3)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(505, 396)
        Me.TabControl2.TabIndex = 42
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.lb_peret2)
        Me.TabPage5.Controls.Add(Me.Label3)
        Me.TabPage5.Controls.Add(Me.lb_NewGPath)
        Me.TabPage5.Controls.Add(Me.lb_NewGId)
        Me.TabPage5.Controls.Add(Me.bt_showCheckedNodesButton)
        Me.TabPage5.Controls.Add(Me.TreeView2)
        Me.TabPage5.Controls.Add(Me.Label2)
        Me.TabPage5.Controls.Add(Me.bt_pasteNewGen)
        Me.TabPage5.Controls.Add(Me.bt_replaceNewGen)
        Me.TabPage5.Controls.Add(Me.bt_LoadNewGen)
        Me.TabPage5.Controls.Add(Me.bt_compare)
        Me.TabPage5.Controls.Add(Me.bt_saveID)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(497, 370)
        Me.TabPage5.TabIndex = 0
        Me.TabPage5.Text = "Импорт"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'lb_peret2
        '
        Me.lb_peret2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_peret2.AutoSize = True
        Me.lb_peret2.BackColor = System.Drawing.Color.White
        Me.lb_peret2.ForeColor = System.Drawing.Color.DarkGray
        Me.lb_peret2.Location = New System.Drawing.Point(210, 185)
        Me.lb_peret2.Name = "lb_peret2"
        Me.lb_peret2.Size = New System.Drawing.Size(97, 13)
        Me.lb_peret2.TabIndex = 24
        Me.lb_peret2.Text = "+ Перетащи сюда"
        Me.lb_peret2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 353)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Путь:"
        '
        'lb_NewGPath
        '
        Me.lb_NewGPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lb_NewGPath.AutoSize = True
        Me.lb_NewGPath.Location = New System.Drawing.Point(45, 352)
        Me.lb_NewGPath.Name = "lb_NewGPath"
        Me.lb_NewGPath.Size = New System.Drawing.Size(28, 13)
        Me.lb_NewGPath.TabIndex = 13
        Me.lb_NewGPath.Text = "###"
        '
        'lb_NewGId
        '
        Me.lb_NewGId.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lb_NewGId.AutoSize = True
        Me.lb_NewGId.Location = New System.Drawing.Point(45, 334)
        Me.lb_NewGId.Name = "lb_NewGId"
        Me.lb_NewGId.Size = New System.Drawing.Size(28, 13)
        Me.lb_NewGId.TabIndex = 14
        Me.lb_NewGId.Text = "###"
        '
        'bt_showCheckedNodesButton
        '
        Me.bt_showCheckedNodesButton.Enabled = False
        Me.bt_showCheckedNodesButton.Location = New System.Drawing.Point(417, 6)
        Me.bt_showCheckedNodesButton.Name = "bt_showCheckedNodesButton"
        Me.bt_showCheckedNodesButton.Size = New System.Drawing.Size(75, 36)
        Me.bt_showCheckedNodesButton.TabIndex = 41
        Me.bt_showCheckedNodesButton.Text = "Отметить несколько"
        Me.bt_showCheckedNodesButton.UseVisualStyleBackColor = True
        '
        'TreeView2
        '
        Me.TreeView2.AllowDrop = True
        Me.TreeView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView2.HideSelection = False
        Me.TreeView2.Location = New System.Drawing.Point(6, 45)
        Me.TreeView2.Name = "TreeView2"
        Me.TreeView2.Size = New System.Drawing.Size(485, 286)
        Me.TreeView2.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 334)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Id:"
        '
        'bt_pasteNewGen
        '
        Me.bt_pasteNewGen.Enabled = False
        Me.bt_pasteNewGen.Location = New System.Drawing.Point(6, 6)
        Me.bt_pasteNewGen.Name = "bt_pasteNewGen"
        Me.bt_pasteNewGen.Size = New System.Drawing.Size(67, 36)
        Me.bt_pasteNewGen.TabIndex = 39
        Me.bt_pasteNewGen.Text = "< Вставить"
        Me.bt_pasteNewGen.UseVisualStyleBackColor = True
        '
        'bt_replaceNewGen
        '
        Me.bt_replaceNewGen.Enabled = False
        Me.bt_replaceNewGen.Location = New System.Drawing.Point(80, 6)
        Me.bt_replaceNewGen.Name = "bt_replaceNewGen"
        Me.bt_replaceNewGen.Size = New System.Drawing.Size(55, 36)
        Me.bt_replaceNewGen.TabIndex = 34
        Me.bt_replaceNewGen.Text = "< Замена"
        Me.bt_replaceNewGen.UseVisualStyleBackColor = True
        '
        'bt_LoadNewGen
        '
        Me.bt_LoadNewGen.Location = New System.Drawing.Point(141, 6)
        Me.bt_LoadNewGen.Name = "bt_LoadNewGen"
        Me.bt_LoadNewGen.Size = New System.Drawing.Size(118, 36)
        Me.bt_LoadNewGen.TabIndex = 30
        Me.bt_LoadNewGen.Text = "Загрузить сгенеренный файл"
        Me.bt_LoadNewGen.UseVisualStyleBackColor = True
        '
        'bt_compare
        '
        Me.bt_compare.Enabled = False
        Me.bt_compare.Location = New System.Drawing.Point(265, 6)
        Me.bt_compare.Name = "bt_compare"
        Me.bt_compare.Size = New System.Drawing.Size(70, 36)
        Me.bt_compare.TabIndex = 31
        Me.bt_compare.Text = "Раздать ID"
        Me.bt_compare.UseVisualStyleBackColor = True
        '
        'bt_saveID
        '
        Me.bt_saveID.Location = New System.Drawing.Point(341, 6)
        Me.bt_saveID.Name = "bt_saveID"
        Me.bt_saveID.Size = New System.Drawing.Size(70, 36)
        Me.bt_saveID.TabIndex = 35
        Me.bt_saveID.Text = "Сохранить c ID"
        Me.bt_saveID.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.DataGridView3)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(497, 370)
        Me.TabPage6.TabIndex = 1
        Me.TabPage6.Text = "Свойства"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AllowUserToResizeRows = False
        Me.DataGridView3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView3.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView3.Location = New System.Drawing.Point(6, 20)
        Me.DataGridView3.MultiSelect = False
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersVisible = False
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.ShowEditingIcon = False
        Me.DataGridView3.Size = New System.Drawing.Size(485, 344)
        Me.DataGridView3.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 457)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "На замену:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 422)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Max Id:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lb_maxId
        '
        Me.lb_maxId.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lb_maxId.AutoSize = True
        Me.lb_maxId.Location = New System.Drawing.Point(79, 422)
        Me.lb_maxId.Name = "lb_maxId"
        Me.lb_maxId.Size = New System.Drawing.Size(28, 13)
        Me.lb_maxId.TabIndex = 9
        Me.lb_maxId.Text = "###"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 405)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Id:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lb_cfgId
        '
        Me.lb_cfgId.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lb_cfgId.AutoSize = True
        Me.lb_cfgId.Location = New System.Drawing.Point(79, 405)
        Me.lb_cfgId.Name = "lb_cfgId"
        Me.lb_cfgId.Size = New System.Drawing.Size(28, 13)
        Me.lb_cfgId.TabIndex = 8
        Me.lb_cfgId.Text = "###"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 440)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Путь:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lb_cfgPath
        '
        Me.lb_cfgPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lb_cfgPath.AutoSize = True
        Me.lb_cfgPath.Location = New System.Drawing.Point(79, 440)
        Me.lb_cfgPath.Name = "lb_cfgPath"
        Me.lb_cfgPath.Size = New System.Drawing.Size(28, 13)
        Me.lb_cfgPath.TabIndex = 7
        Me.lb_cfgPath.Text = "###"
        '
        'lb_mainChekedNode
        '
        Me.lb_mainChekedNode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lb_mainChekedNode.AutoSize = True
        Me.lb_mainChekedNode.Location = New System.Drawing.Point(79, 459)
        Me.lb_mainChekedNode.Name = "lb_mainChekedNode"
        Me.lb_mainChekedNode.Size = New System.Drawing.Size(28, 13)
        Me.lb_mainChekedNode.TabIndex = 37
        Me.lb_mainChekedNode.Text = "###"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.Button8)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.But_UnSel)
        Me.TabPage1.Controls.Add(Me.But_selAll)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.but_sync)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.but_Anal)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(976, 486)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Синхронизация файлов ВУ"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(506, 73)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(130, 20)
        Me.Button5.TabIndex = 34
        Me.Button5.Text = "Открыть на удал."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tbManualDir)
        Me.GroupBox4.Location = New System.Drawing.Point(506, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(130, 43)
        Me.GroupBox4.TabIndex = 32
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Папка с проектом:"
        '
        'tbManualDir
        '
        Me.tbManualDir.Location = New System.Drawing.Point(6, 17)
        Me.tbManualDir.Name = "tbManualDir"
        Me.tbManualDir.Size = New System.Drawing.Size(118, 20)
        Me.tbManualDir.TabIndex = 3
        Me.tbManualDir.Text = "C:\Dynamics\SSN"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(506, 53)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(130, 20)
        Me.Button8.TabIndex = 31
        Me.Button8.Text = "Открыть"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(370, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(130, 43)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Удаленная машина"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox6)
        Me.TabPage3.Controls.Add(Me.DateTimePicker1)
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Controls.Add(Me.Button3)
        Me.TabPage3.Controls.Add(Me.DataGridView2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(976, 486)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Backup"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TextBox2)
        Me.GroupBox6.Location = New System.Drawing.Point(151, 49)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(206, 43)
        Me.GroupBox6.TabIndex = 33
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Папка с проектом:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(6, 17)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(194, 20)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = "C:\Dynamics\SSN"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(157, 17)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 13
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(4, 55)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 38)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Бэкап"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(4, 10)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(141, 38)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Найти"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView2.Location = New System.Drawing.Point(4, 98)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.ShowEditingIcon = False
        Me.DataGridView2.Size = New System.Drawing.Size(558, 178)
        Me.DataGridView2.TabIndex = 5
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SaveFileDialog1
        '
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Заменить выбранный узел"
        '
        'LogTextBox
        '
        Me.LogTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.LogTextBox.Location = New System.Drawing.Point(0, 514)
        Me.LogTextBox.Name = "LogTextBox"
        Me.LogTextBox.ReadOnly = True
        Me.LogTextBox.Size = New System.Drawing.Size(984, 44)
        Me.LogTextBox.TabIndex = 18
        Me.LogTextBox.Text = ""
        '
        'TreeImageList
        '
        Me.TreeImageList.ImageStream = CType(resources.GetObject("TreeImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.TreeImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.TreeImageList.Images.SetKeyName(0, "folder.png")
        Me.TreeImageList.Images.SetKeyName(1, "1.png")
        Me.TreeImageList.Images.SetKeyName(2, "2.png")
        Me.TreeImageList.Images.SetKeyName(3, "3.png")
        Me.TreeImageList.Images.SetKeyName(4, "4.png")
        Me.TreeImageList.Images.SetKeyName(5, "5.png")
        Me.TreeImageList.Images.SetKeyName(6, "6.png")
        Me.TreeImageList.Images.SetKeyName(7, "7.png")
        Me.TreeImageList.Images.SetKeyName(8, "8.png")
        Me.TreeImageList.Images.SetKeyName(9, "9.png")
        Me.TreeImageList.Images.SetKeyName(10, "10.png")
        Me.TreeImageList.Images.SetKeyName(11, "11.png")
        Me.TreeImageList.Images.SetKeyName(12, "12.png")
        Me.TreeImageList.Images.SetKeyName(13, "13.png")
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.LogTextBox)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "MainForm"
        Me.Text = "Для ВУ"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.TreeViewContextMenu.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents but_Anal As System.Windows.Forms.Button
    Friend WithEvents but_sync As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents But_selAll As System.Windows.Forms.Button
    Friend WithEvents But_UnSel As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents bt_saveID As Button
    Friend WithEvents bt_saveAllCfg As Button
    Friend WithEvents bt_compare As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lb_NewGPath As Label
    Friend WithEvents lb_NewGId As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents bt_replaceNewGen As Button
    Friend WithEvents TreeView2 As TreeView
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents bt_LoadNewGen As Button
    Friend WithEvents bt_LoadCfg As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents lb_peret2 As Label
    Friend WithEvents lb_peret1 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Public WithEvents TextBox1 As TextBox
    Public WithEvents tbManualDir As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents GroupBox6 As GroupBox
    Public WithEvents TextBox2 As TextBox
    Friend WithEvents LogTextBox As RichTextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents lb_mainChekedNode As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lb_cfgPath As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lb_cfgId As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lb_maxId As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bt_pasteNewGen As Button
    Friend WithEvents bt_setManualMainChekedNode As Button
    Friend WithEvents bt_showCheckedNodesButton As Button
    Friend WithEvents TreeViewContextMenu As ContextMenuStrip
    Friend WithEvents ПереименоватьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents УдалитьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TreeImageList As ImageList
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents DataGridView3 As DataGridView
End Class
