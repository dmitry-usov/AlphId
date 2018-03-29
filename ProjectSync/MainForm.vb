﻿Imports System.Xml

Public Class MainForm
    Dim formWidth As Integer 'Переменная для изменения расположения элементов
    Dim bool_FormLoaded As Boolean
    Dim treeViewNormalSize As Size

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SyncSetForm.Visible = True
    End Sub

    'грузим форму
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = " " ' прячем всё лишнее
        ToolStripProgressBar1.Visible = False

        TabPage3.Parent = Nothing

        initAlpohaID() 'инициализация формы для Альфа Конфигурации
        initSyncFilePanel() 'инициализация формы для синхронизации файлов
        bool_FormLoaded = True
    End Sub



    '************************************************************************************************************************
    '***********************************ТУТА КОД ДЛЯ СИНХРОНИЗАЛКИ ФАЙЛОВ****************************************************
    '************************************************************************************************************************

    Sub initSyncFilePanel()
        Dim chk As New DataGridViewCheckBoxColumn()
        ' задаём свойства 
        With DataGridView1
            .Columns.Add(chk)
            .Columns.Add("name", "Имя")
            .Columns.Add("local", "Местный")
            .Columns.Add("remote", "Удалённый")
            .Columns.Add("directory", "Расположение")
            .Columns(0).Width = 21
            .Columns(0).ReadOnly = False
            .Columns(1).Width = 360
            .Columns(1).ReadOnly = True
            .Columns(2).Width = 110
            .Columns(2).ReadOnly = True
            .Columns(3).Width = 110
            .Columns(3).ReadOnly = True
            .Columns(4).Width = 300
            .Columns(4).ReadOnly = True
        End With

        RadioButton1.Checked = True

        ' проверяем наличие конфиг файла
        initConfig()

    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim bool_connection As Boolean = False
        but_sync.Enabled = False
    End Sub



    '===================================================Кнопки===============================================================

    Private Sub but_Anal_Click(sender As Object, e As EventArgs) Handles but_Anal.Click
        anal()
        If bool_connection = True Then but_sync.Enabled = True
    End Sub


    Private Sub but_sync_Click(sender As Object, e As EventArgs) Handles but_sync.Click
        Sync()
        anal()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        On Error GoTo err1
        Dim tempDir As String
        If tbManualDir.Text <> xElem_prjDir.Value Then ' перезаписываем папку
            tempDir = xElem_prjDir.Value
            xElem_prjDir.Value = tbManualDir.Text
            prjDir = tbManualDir.Text
        End If
        xdoc.Save(SyncFileName)
        Process.Start(prjDir)

        Exit Sub
err1:
        prjDir = tempDir
        xElem_prjDir.Value = tempDir
        MsgBox("Ошибка!", vbCritical + vbOKOnly)
    End Sub


    Private Sub But_UnSel_Click(sender As Object, e As EventArgs) Handles But_UnSel.Click
        For Each dataElem As DataGridViewRow In DataGridView1.Rows
            dataElem.Cells(cn_chk).Value = False
        Next
    End Sub


    Private Sub But_selAll_Click(sender As Object, e As EventArgs) Handles But_selAll.Click
        For Each dataElem As DataGridViewRow In DataGridView1.Rows
            dataElem.Cells(cn_chk).Value = True
        Next
    End Sub

    '=================================Конец Кнопок===========================================================================

    Private Sub tbManualDir_KeyDown(sender As Object, e As KeyEventArgs) Handles tbManualDir.KeyDown
        Dim tempDir
        If e.KeyCode = 13 Then
            If tbManualDir.Text <> xElem_prjDir.Value Then ' перезаписываем папку
                tempDir = xElem_prjDir.Value
                xElem_prjDir.Value = tbManualDir.Text
                prjDir = tbManualDir.Text
            End If
            xdoc.Save(SyncFileName)
            MsgBox("Папка перезаписана")
        End If
    End Sub


    '************************************************************************************************************************
    '***********************************КОНЕЦ КОДА ДЛЯ СИНХРОНИЗАЛКИ ФАЙЛОВ**************************************************
    '************************************************************************************************************************



    '************************************************************************************************************************
    '***********************************ТУТА КОД ДЛЯ АЛЬФА КОНФИГИ***********************************************************
    '************************************************************************************************************************
    Sub initAlpohaID() 'инициализация
        On Error GoTo err1

        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.Filter = "xmlcfg (*.xmlcfg)|*.xmlcfg"
        SaveFileDialog1.DefaultExt = "xmlcfg"
        SaveFileDialog1.Filter = "xmlcfg (*.xmlcfg)|*.xmlcfg"

        formWidth = Size.Width

        bt_saveID.Enabled = False
        MinimumSize = New Size(Size.Width, Size.Height)
        treeViewNormalSize = New Size(TreeView1.Size.Width, TreeView2.Size.Height)
        bool_FormLoaded = True
        Exit Sub

err1:
        MsgBox("Err.Number: " & Err.Number & ". " & Err.Description, vbCritical, "Ошибка")
        Resume Next
    End Sub

    '=================================Реализация функции перетаскивания файлов в окно========================================
    Private Sub TreeView1_DragEnter(sender As Object, e As DragEventArgs) Handles TreeView1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub TreeView1_DragDrop(sender As Object, e As DragEventArgs) Handles TreeView1.DragDrop
        confFullName = e.Data.GetData(DataFormats.FileDrop)(0)
        loadCfg()
    End Sub

    Private Sub TreeView2_DragEnter(sender As Object, e As DragEventArgs) Handles TreeView2.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub TreeView2_DragDrop(sender As Object, e As DragEventArgs) Handles TreeView2.DragDrop
        newGen = e.Data.GetData(DataFormats.FileDrop)(0)
        loadNewCfg()
    End Sub
    '=================================Конец реализации функции перетаскивания файлов в окно========================================



    '=================================Изменение расзмера окна и элементов========================================
    ' хз как по-нормальному сделать. Будет так:
    Private Sub AlphaCfgForm_ResizeBegin(sender As Object, e As EventArgs) Handles Me.ResizeBegin
        formWidth = Size.Width
    End Sub

    Private Sub AlphaCfgForm_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Dim deltaWidth As Integer
        deltaWidth = (Size.Width - formWidth) / 2
        TreeView1.Size = New Size(TreeView1.Size.Width + deltaWidth, TreeView1.Size.Height)
        TreeView2.Size = New Size(TreeView2.Size.Width + deltaWidth, TreeView2.Size.Height)
    End Sub



    Private Sub AlphaCfgForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then
            TreeView1.Size = New Size(Size.Width / 2.05, TreeView1.Size.Height)
            TreeView2.Size = New Size(Size.Width / 2.05, TreeView2.Size.Height)
            'ElseIf Me.WindowState = FormWindowState.Normal And treeViewNormalSize.Height <> 0 And treeViewNormalSize.Width <> 0 Then
            '    TreeView1.Size = treeViewNormalSize
            '    TreeView2.Size = treeViewNormalSize
        End If
    End Sub
    '=================================Конец изменения расзмера окна и элементов========================================



    '=================================КНОПКИ ========================================

    Private Sub bt_LoadCfg_Click(sender As Object, e As EventArgs) Handles bt_LoadCfg.Click
        bool_selectCfg = True
        If xElem_prjDir IsNot Nothing Then OpenFileDialog1.InitialDirectory = xElem_prjDir.Value
        If confPath IsNot Nothing Then OpenFileDialog1.InitialDirectory = confPath
        If OpenFileDialog1.ShowDialog() = DialogResult.Cancel Then Exit Sub
        confPath = OpenFileDialog1.FileName
        loadCfg()
    End Sub

    Private Sub bt_LoadNewGen_Click(sender As Object, e As EventArgs) Handles bt_LoadNewGen.Click
        bool_selectCfg = False
        If xElem_prjDir IsNot Nothing Then OpenFileDialog1.InitialDirectory = xElem_prjDir.Value
        If newGenPath IsNot Nothing Then OpenFileDialog1.InitialDirectory = newGenPath
        If OpenFileDialog1.ShowDialog() = DialogResult.Cancel Then Exit Sub
        newGenPath = OpenFileDialog1.FileName
        loadNewCfg()
    End Sub

    Private Sub bt_compare_Click(sender As Object, e As EventArgs) Handles bt_compare.Click
        ToolStripStatusLabel1.Text = ""

        analiz(rootNewGen, mainChekedNode)

        If mainChekedNode Is Nothing Then
            MsgBox("Главный узел сгенерённого файла не найден в конфигурации! скорее всего не ID розданы неправильно", vbCritical + vbOKOnly)
        Else
            If comparator(rootNewGen, mainChekedNode) = False Then makeEquals(mainChekedNode, rootNewGen)
        End If

        TreeView2.Nodes.Clear()
        addToTree(rootNewGen, TreeView2)
        parentNode = Nothing
        TreeView2.Nodes(0).Expand()
        bt_compare.Enabled = False
        bt_saveID.Enabled = True
        ToolStripStatusLabel1.Text = "ID розданы"
    End Sub

    Private Sub bt_saveID_Click(sender As Object, e As EventArgs) Handles bt_saveID.Click
        SaveFileDialog1.InitialDirectory = newGenPath
        SaveFileDialog1.FileName = Replace(newGen, ".xmlcfg", "") & "_id"
        If SaveFileDialog1.ShowDialog() = DialogResult.Cancel Then Exit Sub
        docNewGen.Save(saveFilePath)
        ToolStripStatusLabel1.Text = "Сгенерённый файл сохранён"
        MsgBox("Файл сохранён!")
    End Sub

    Private Sub bt_addNewGen_Click(sender As Object, e As EventArgs) Handles bt_addNewGen.Click
        Dim selectedNodeInCfg As XmlNode
        Dim selectedNode As XmlNode
        Dim newNode As XmlNode

        selectedNodeInCfg = getNodeByTreePath(TreeView2.SelectedNode.FullPath, mainChekedNode)
        selectedNode = getNodeByTreePath(TreeView2.SelectedNode.FullPath, rootNewGen)
        newNode = docConfig.ImportNode(selectedNode, True)

        selectedNodeInCfg.ParentNode.ReplaceChild(newNode, selectedNodeInCfg)

        reloadCfg()
        ToolStripStatusLabel1.Text = "Узел " & selectedNodeInCfg.Attributes("Name").Value & " заменён полностью"
        TreeView2.Select()
    End Sub

    Private Sub bt_saveAllCfg_Click(sender As Object, e As EventArgs) Handles bt_saveAllCfg.Click
        SaveFileDialog1.InitialDirectory = confPath
        SaveFileDialog1.FileName = Replace(confFullName, ".xmlcfg", "") & ""

        If SaveFileDialog1.ShowDialog() = DialogResult.Cancel Then Exit Sub
        docConfig.Save(saveFilePath)
        ToolStripStatusLabel1.Text = "Конфигурация сохранена"
        MsgBox("Файл сохранён!")
    End Sub

    '=============================КОНЕЦ КНОПКИ========================================


    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect ' что происходит после выбора узла в первом дереве

        lb_cfgPath.Text = TreeView1.SelectedNode.FullPath
        Dim tmpNdoe As XmlNode = getNodeByTreePath(TreeView1.SelectedNode.FullPath, rootConfig)

        If AttributesExist(tmpNdoe, "Id") Then
            lb_cfgId.Text = tmpNdoe.Attributes("Id").Value
        Else
            lb_cfgId.Text = "ОТСУТСТВУЕТ"
        End If

    End Sub

    Private Sub TreeView2_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView2.AfterSelect ' что происходит после выбора узла во втором дереве
        lb_NewGPath.Text = TreeView2.SelectedNode.FullPath

        Dim tmpNdoe As XmlNode = getNodeByTreePath(TreeView2.SelectedNode.FullPath, rootNewGen)

        If AttributesExist(tmpNdoe, "Id") Then
            lb_NewGId.Text = tmpNdoe.Attributes("Id").Value
        Else
            lb_NewGId.Text = "ОТСУТСТВУЕТ"
        End If

    End Sub



    Private Sub OpenFileDialog1_FileOk(sender As Object, e As ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        If bool_selectCfg Then 'если нажата кнопка загурзки конфигурации
            bool_selectCfg = Nothing
            confFullName = OpenFileDialog1.FileName
        ElseIf bool_selectCfg = False Then ' если нажата кнопка загрузки сгенеренного файла
            bool_selectCfg = Nothing
            newGen = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        saveFilePath = SaveFileDialog1.FileName
    End Sub

    '************************************************************************************************************************
    '***********************************КОНЕЦ КОДА ДЛЯ АЛЬФА КОНФИГИ*********************************************************
    '************************************************************************************************************************
End Class
