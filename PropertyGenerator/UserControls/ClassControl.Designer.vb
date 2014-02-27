<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClassControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClassControl))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.grpImportanceList = New System.Windows.Forms.GroupBox
        Me.lsvImportList = New System.Windows.Forms.ListView
        Me.clmImportanceName = New System.Windows.Forms.ColumnHeader
        Me.cmnuListRightClick = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmnuMoveUp = New System.Windows.Forms.ToolStripMenuItem
        Me.cmnuMoveDown = New System.Windows.Forms.ToolStripMenuItem
        Me.cmnuSelectedDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmnuDeleteAll = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.cmnuSelectAll = New System.Windows.Forms.ToolStripMenuItem
        Me.cmnuUnselectAll = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.cmnuLargeViewList = New System.Windows.Forms.ToolStripMenuItem
        Me.btnAddImport = New System.Windows.Forms.Button
        Me.sstImportList = New System.Windows.Forms.StatusStrip
        Me.tssImportCount = New System.Windows.Forms.ToolStripStatusLabel
        Me.cmbImportName = New System.Windows.Forms.ComboBox
        Me.dsLists = New System.Data.DataSet
        Me.tblVariableName = New System.Data.DataTable
        Me.dcVariableName = New System.Data.DataColumn
        Me.tblVariableType = New System.Data.DataTable
        Me.dcVariableType = New System.Data.DataColumn
        Me.tblSubArrival = New System.Data.DataTable
        Me.dcSubArrival = New System.Data.DataColumn
        Me.tblSubType = New System.Data.DataTable
        Me.dcSubType = New System.Data.DataColumn
        Me.tblSubName = New System.Data.DataTable
        Me.dcSubName = New System.Data.DataColumn
        Me.tblFuncType = New System.Data.DataTable
        Me.dcFuncType = New System.Data.DataColumn
        Me.tblInheritance = New System.Data.DataTable
        Me.dcInheritanceName = New System.Data.DataColumn
        Me.tblImportance = New System.Data.DataTable
        Me.dcImportanceName = New System.Data.DataColumn
        Me.grpInheritanceList = New System.Windows.Forms.GroupBox
        Me.lsvInheritanceList = New System.Windows.Forms.ListView
        Me.clmInheritanceName = New System.Windows.Forms.ColumnHeader
        Me.btnAddInheritance = New System.Windows.Forms.Button
        Me.sstInheritanceList = New System.Windows.Forms.StatusStrip
        Me.tssInheritanceCount = New System.Windows.Forms.ToolStripStatusLabel
        Me.cmbInheritanceName = New System.Windows.Forms.ComboBox
        Me.grpSubType = New System.Windows.Forms.GroupBox
        Me.rdbSubParamNone = New System.Windows.Forms.RadioButton
        Me.rdbSubParamList = New System.Windows.Forms.RadioButton
        Me.cmbSubName = New System.Windows.Forms.ComboBox
        Me.btnAddSub = New System.Windows.Forms.Button
        Me.cmbFuncType = New System.Windows.Forms.ComboBox
        Me.cmbSubType = New System.Windows.Forms.ComboBox
        Me.cmbSubArrival = New System.Windows.Forms.ComboBox
        Me.grpVariableList = New System.Windows.Forms.GroupBox
        Me.btnAddVariable = New System.Windows.Forms.Button
        Me.sstVariableList = New System.Windows.Forms.StatusStrip
        Me.tssVariableCount = New System.Windows.Forms.ToolStripStatusLabel
        Me.lsvVariableList = New System.Windows.Forms.ListView
        Me.clmVariableName = New System.Windows.Forms.ColumnHeader
        Me.clmVariableType = New System.Windows.Forms.ColumnHeader
        Me.cmbVariableType = New System.Windows.Forms.ComboBox
        Me.cmbVariableName = New System.Windows.Forms.ComboBox
        Me.grpSubList = New System.Windows.Forms.GroupBox
        Me.lsvSubList = New System.Windows.Forms.ListView
        Me.clmSubArrival = New System.Windows.Forms.ColumnHeader
        Me.clmSubType = New System.Windows.Forms.ColumnHeader
        Me.clmSubName = New System.Windows.Forms.ColumnHeader
        Me.clmSubParameterList = New System.Windows.Forms.ColumnHeader
        Me.clmReturnType = New System.Windows.Forms.ColumnHeader
        Me.sstSubList = New System.Windows.Forms.StatusStrip
        Me.tssSubCount = New System.Windows.Forms.ToolStripStatusLabel
        Me.tstClass = New System.Windows.Forms.ToolStrip
        Me.tslClassName = New System.Windows.Forms.ToolStripLabel
        Me.txtClassName = New System.Windows.Forms.ToolStripTextBox
        Me.btnCreate = New System.Windows.Forms.ToolStripButton
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.cmbFonts = New System.Windows.Forms.ToolStripComboBox
        Me.btnFont = New System.Windows.Forms.ToolStripButton
        Me.cmbFontSize = New System.Windows.Forms.ToolStripComboBox
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnBold = New System.Windows.Forms.ToolStripButton
        Me.btnItalic = New System.Windows.Forms.ToolStripButton
        Me.btnUnderline = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCurrentColor = New System.Windows.Forms.ToolStripButton
        Me.btnFontColor = New System.Windows.Forms.ToolStripButton
        Me.rtbCode = New System.Windows.Forms.RichTextBox
        Me.cmnuCodeText = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmnuCut = New System.Windows.Forms.ToolStripMenuItem
        Me.cmnuCopy = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.cmnuPaste = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator
        Me.cmnuUndo = New System.Windows.Forms.ToolStripMenuItem
        Me.cmnuSelectAllCodeText = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator
        Me.cmnuPaintString = New System.Windows.Forms.ToolStripMenuItem
        Me.sstCodeStatus = New System.Windows.Forms.StatusStrip
        Me.tssCodeLineCount = New System.Windows.Forms.ToolStripStatusLabel
        Me.tstCode = New System.Windows.Forms.ToolStrip
        Me.btnNew = New System.Windows.Forms.ToolStripButton
        Me.btnSaveCode = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.btnUndo = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.btnCut = New System.Windows.Forms.ToolStripButton
        Me.btnCopy = New System.Windows.Forms.ToolStripButton
        Me.btnPaste = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnPaintToFont = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.btnFind = New System.Windows.Forms.ToolStripButton
        Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.btnMainSave = New System.Windows.Forms.ToolStripButton
        Me.btnOpen = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.grpImportanceList.SuspendLayout()
        Me.cmnuListRightClick.SuspendLayout()
        Me.sstImportList.SuspendLayout()
        CType(Me.dsLists, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblVariableName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblVariableType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblSubArrival, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblSubType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblSubName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblFuncType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblInheritance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblImportance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInheritanceList.SuspendLayout()
        Me.sstInheritanceList.SuspendLayout()
        Me.grpSubType.SuspendLayout()
        Me.grpVariableList.SuspendLayout()
        Me.sstVariableList.SuspendLayout()
        Me.grpSubList.SuspendLayout()
        Me.sstSubList.SuspendLayout()
        Me.tstClass.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStripContainer2.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer2.ContentPanel.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.cmnuCodeText.SuspendLayout()
        Me.sstCodeStatus.SuspendLayout()
        Me.tstCode.SuspendLayout()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.grpImportanceList)
        Me.SplitContainer1.Panel1.Controls.Add(Me.grpInheritanceList)
        Me.SplitContainer1.Panel1.Controls.Add(Me.grpSubType)
        Me.SplitContainer1.Panel1.Controls.Add(Me.grpVariableList)
        Me.SplitContainer1.Panel1.Controls.Add(Me.grpSubList)
        Me.SplitContainer1.Panel1.Controls.Add(Me.tstClass)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(5, 0, 5, 5)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStripContainer1)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(5, 0, 5, 5)
        Me.SplitContainer1.Size = New System.Drawing.Size(908, 581)
        Me.SplitContainer1.SplitterDistance = 498
        Me.SplitContainer1.TabIndex = 0
        '
        'grpImportanceList
        '
        Me.grpImportanceList.Controls.Add(Me.lsvImportList)
        Me.grpImportanceList.Controls.Add(Me.btnAddImport)
        Me.grpImportanceList.Controls.Add(Me.sstImportList)
        Me.grpImportanceList.Controls.Add(Me.cmbImportName)
        Me.grpImportanceList.Location = New System.Drawing.Point(253, 405)
        Me.grpImportanceList.Name = "grpImportanceList"
        Me.grpImportanceList.Padding = New System.Windows.Forms.Padding(5, 10, 5, 5)
        Me.grpImportanceList.Size = New System.Drawing.Size(237, 176)
        Me.grpImportanceList.TabIndex = 14
        Me.grpImportanceList.TabStop = False
        Me.grpImportanceList.Text = "5. Importance List"
        '
        'lsvImportList
        '
        Me.lsvImportList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsvImportList.CheckBoxes = True
        Me.lsvImportList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmImportanceName})
        Me.lsvImportList.ContextMenuStrip = Me.cmnuListRightClick
        Me.lsvImportList.FullRowSelect = True
        Me.lsvImportList.Location = New System.Drawing.Point(8, 79)
        Me.lsvImportList.Name = "lsvImportList"
        Me.lsvImportList.Size = New System.Drawing.Size(221, 70)
        Me.lsvImportList.TabIndex = 8
        Me.lsvImportList.Tag = "ImportanceList"
        Me.lsvImportList.UseCompatibleStateImageBehavior = False
        Me.lsvImportList.View = System.Windows.Forms.View.Details
        '
        'clmImportanceName
        '
        Me.clmImportanceName.Text = Global.PropertyGenerator.My.MySettings.Default.clmImportanceName
        Me.clmImportanceName.Width = Global.PropertyGenerator.My.MySettings.Default.clmImportanceNameWidth
        '
        'cmnuListRightClick
        '
        Me.cmnuListRightClick.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuMoveUp, Me.cmnuMoveDown, Me.cmnuSelectedDelete, Me.ToolStripMenuItem1, Me.cmnuDeleteAll, Me.ToolStripMenuItem2, Me.cmnuSelectAll, Me.cmnuUnselectAll, Me.ToolStripMenuItem3, Me.cmnuLargeViewList})
        Me.cmnuListRightClick.Name = "cmnuListRightClick"
        Me.cmnuListRightClick.Size = New System.Drawing.Size(161, 176)
        '
        'cmnuMoveUp
        '
        Me.cmnuMoveUp.Name = "cmnuMoveUp"
        Me.cmnuMoveUp.Size = New System.Drawing.Size(160, 22)
        Me.cmnuMoveUp.Text = "Move Up"
        '
        'cmnuMoveDown
        '
        Me.cmnuMoveDown.Name = "cmnuMoveDown"
        Me.cmnuMoveDown.Size = New System.Drawing.Size(160, 22)
        Me.cmnuMoveDown.Text = "Move Down"
        '
        'cmnuSelectedDelete
        '
        Me.cmnuSelectedDelete.Name = "cmnuSelectedDelete"
        Me.cmnuSelectedDelete.Size = New System.Drawing.Size(160, 22)
        Me.cmnuSelectedDelete.Text = "Selected Delete"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(157, 6)
        '
        'cmnuDeleteAll
        '
        Me.cmnuDeleteAll.Name = "cmnuDeleteAll"
        Me.cmnuDeleteAll.Size = New System.Drawing.Size(160, 22)
        Me.cmnuDeleteAll.Text = "Delete All"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(157, 6)
        '
        'cmnuSelectAll
        '
        Me.cmnuSelectAll.Name = "cmnuSelectAll"
        Me.cmnuSelectAll.Size = New System.Drawing.Size(160, 22)
        Me.cmnuSelectAll.Text = "Select All"
        '
        'cmnuUnselectAll
        '
        Me.cmnuUnselectAll.Name = "cmnuUnselectAll"
        Me.cmnuUnselectAll.Size = New System.Drawing.Size(160, 22)
        Me.cmnuUnselectAll.Text = "Unselect All"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(157, 6)
        '
        'cmnuLargeViewList
        '
        Me.cmnuLargeViewList.Name = "cmnuLargeViewList"
        Me.cmnuLargeViewList.Size = New System.Drawing.Size(160, 22)
        Me.cmnuLargeViewList.Text = "Large View List"
        '
        'btnAddImport
        '
        Me.btnAddImport.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddImport.Location = New System.Drawing.Point(154, 50)
        Me.btnAddImport.Name = "btnAddImport"
        Me.btnAddImport.Size = New System.Drawing.Size(75, 22)
        Me.btnAddImport.TabIndex = 6
        Me.btnAddImport.Text = "Add"
        Me.ToolTip1.SetToolTip(Me.btnAddImport, "Add Importance To Importance List.")
        Me.btnAddImport.UseVisualStyleBackColor = True
        '
        'sstImportList
        '
        Me.sstImportList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sstImportList.AutoSize = False
        Me.sstImportList.Dock = System.Windows.Forms.DockStyle.None
        Me.sstImportList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssImportCount})
        Me.sstImportList.Location = New System.Drawing.Point(8, 149)
        Me.sstImportList.Name = "sstImportList"
        Me.sstImportList.Size = New System.Drawing.Size(221, 22)
        Me.sstImportList.TabIndex = 7
        Me.sstImportList.Text = "StatusStrip5"
        '
        'tssImportCount
        '
        Me.tssImportCount.Name = "tssImportCount"
        Me.tssImportCount.Size = New System.Drawing.Size(83, 17)
        Me.tssImportCount.Text = "Imports Count :"
        '
        'cmbImportName
        '
        Me.cmbImportName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbImportName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.PropertyGenerator.My.MySettings.Default, "ImportName", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbImportName.DataSource = Me.dsLists
        Me.cmbImportName.DisplayMember = "xml_Importance.ImportanceName"
        Me.cmbImportName.FormattingEnabled = True
        Me.cmbImportName.Location = New System.Drawing.Point(8, 23)
        Me.cmbImportName.Name = "cmbImportName"
        Me.cmbImportName.Size = New System.Drawing.Size(200, 21)
        Me.cmbImportName.TabIndex = 0
        Me.cmbImportName.Tag = "xml_Importance"
        Me.cmbImportName.Text = Global.PropertyGenerator.My.MySettings.Default.ImportName
        Me.ToolTip1.SetToolTip(Me.cmbImportName, "Importance.")
        Me.cmbImportName.ValueMember = "xml_Importance.ImportanceName"
        '
        'dsLists
        '
        Me.dsLists.DataSetName = "DataSetOfLists"
        Me.dsLists.Tables.AddRange(New System.Data.DataTable() {Me.tblVariableName, Me.tblVariableType, Me.tblSubArrival, Me.tblSubType, Me.tblSubName, Me.tblFuncType, Me.tblInheritance, Me.tblImportance})
        '
        'tblVariableName
        '
        Me.tblVariableName.Columns.AddRange(New System.Data.DataColumn() {Me.dcVariableName})
        Me.tblVariableName.TableName = "xml_VariableName"
        '
        'dcVariableName
        '
        Me.dcVariableName.ColumnName = "VariableName"
        '
        'tblVariableType
        '
        Me.tblVariableType.Columns.AddRange(New System.Data.DataColumn() {Me.dcVariableType})
        Me.tblVariableType.TableName = "xml_VariableType"
        '
        'dcVariableType
        '
        Me.dcVariableType.ColumnName = "VariableType"
        '
        'tblSubArrival
        '
        Me.tblSubArrival.Columns.AddRange(New System.Data.DataColumn() {Me.dcSubArrival})
        Me.tblSubArrival.TableName = "xml_SubArrival"
        '
        'dcSubArrival
        '
        Me.dcSubArrival.ColumnName = "SubArrival"
        '
        'tblSubType
        '
        Me.tblSubType.Columns.AddRange(New System.Data.DataColumn() {Me.dcSubType})
        Me.tblSubType.TableName = "xml_SubType"
        '
        'dcSubType
        '
        Me.dcSubType.ColumnName = "SubType"
        '
        'tblSubName
        '
        Me.tblSubName.Columns.AddRange(New System.Data.DataColumn() {Me.dcSubName})
        Me.tblSubName.TableName = "xml_SubName"
        '
        'dcSubName
        '
        Me.dcSubName.ColumnName = "SubName"
        '
        'tblFuncType
        '
        Me.tblFuncType.Columns.AddRange(New System.Data.DataColumn() {Me.dcFuncType})
        Me.tblFuncType.TableName = "xml_FuncType"
        '
        'dcFuncType
        '
        Me.dcFuncType.ColumnName = "FuncType"
        '
        'tblInheritance
        '
        Me.tblInheritance.Columns.AddRange(New System.Data.DataColumn() {Me.dcInheritanceName})
        Me.tblInheritance.TableName = "xml_Inheritance"
        '
        'dcInheritanceName
        '
        Me.dcInheritanceName.ColumnName = "InheritanceName"
        '
        'tblImportance
        '
        Me.tblImportance.Columns.AddRange(New System.Data.DataColumn() {Me.dcImportanceName})
        Me.tblImportance.TableName = "xml_Importance"
        '
        'dcImportanceName
        '
        Me.dcImportanceName.ColumnName = "ImportanceName"
        '
        'grpInheritanceList
        '
        Me.grpInheritanceList.Controls.Add(Me.lsvInheritanceList)
        Me.grpInheritanceList.Controls.Add(Me.btnAddInheritance)
        Me.grpInheritanceList.Controls.Add(Me.sstInheritanceList)
        Me.grpInheritanceList.Controls.Add(Me.cmbInheritanceName)
        Me.grpInheritanceList.Location = New System.Drawing.Point(8, 405)
        Me.grpInheritanceList.Name = "grpInheritanceList"
        Me.grpInheritanceList.Padding = New System.Windows.Forms.Padding(5, 10, 5, 5)
        Me.grpInheritanceList.Size = New System.Drawing.Size(239, 176)
        Me.grpInheritanceList.TabIndex = 13
        Me.grpInheritanceList.TabStop = False
        Me.grpInheritanceList.Text = "4. Inheritance List"
        '
        'lsvInheritanceList
        '
        Me.lsvInheritanceList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsvInheritanceList.CheckBoxes = True
        Me.lsvInheritanceList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmInheritanceName})
        Me.lsvInheritanceList.ContextMenuStrip = Me.cmnuListRightClick
        Me.lsvInheritanceList.FullRowSelect = True
        Me.lsvInheritanceList.Location = New System.Drawing.Point(8, 79)
        Me.lsvInheritanceList.Name = "lsvInheritanceList"
        Me.lsvInheritanceList.Size = New System.Drawing.Size(223, 70)
        Me.lsvInheritanceList.TabIndex = 8
        Me.lsvInheritanceList.Tag = "InheritanceList"
        Me.lsvInheritanceList.UseCompatibleStateImageBehavior = False
        Me.lsvInheritanceList.View = System.Windows.Forms.View.Details
        '
        'clmInheritanceName
        '
        Me.clmInheritanceName.Text = Global.PropertyGenerator.My.MySettings.Default.clmInheritanceName
        Me.clmInheritanceName.Width = Global.PropertyGenerator.My.MySettings.Default.clmInheritanceNameWidth
        '
        'btnAddInheritance
        '
        Me.btnAddInheritance.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddInheritance.Location = New System.Drawing.Point(156, 50)
        Me.btnAddInheritance.Name = "btnAddInheritance"
        Me.btnAddInheritance.Size = New System.Drawing.Size(75, 22)
        Me.btnAddInheritance.TabIndex = 6
        Me.btnAddInheritance.Text = "Add"
        Me.ToolTip1.SetToolTip(Me.btnAddInheritance, "Add Inheritance To Inheritance List.")
        Me.btnAddInheritance.UseVisualStyleBackColor = True
        '
        'sstInheritanceList
        '
        Me.sstInheritanceList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sstInheritanceList.AutoSize = False
        Me.sstInheritanceList.Dock = System.Windows.Forms.DockStyle.None
        Me.sstInheritanceList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssInheritanceCount})
        Me.sstInheritanceList.Location = New System.Drawing.Point(8, 149)
        Me.sstInheritanceList.Name = "sstInheritanceList"
        Me.sstInheritanceList.Size = New System.Drawing.Size(223, 22)
        Me.sstInheritanceList.TabIndex = 7
        Me.sstInheritanceList.Text = "StatusStrip4"
        '
        'tssInheritanceCount
        '
        Me.tssInheritanceCount.Name = "tssInheritanceCount"
        Me.tssInheritanceCount.Size = New System.Drawing.Size(106, 17)
        Me.tssInheritanceCount.Text = "Inheritances Count :"
        '
        'cmbInheritanceName
        '
        Me.cmbInheritanceName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbInheritanceName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.PropertyGenerator.My.MySettings.Default, "InheritanceName", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbInheritanceName.DataSource = Me.dsLists
        Me.cmbInheritanceName.DisplayMember = "xml_Inheritance.InheritanceName"
        Me.cmbInheritanceName.FormattingEnabled = True
        Me.cmbInheritanceName.Location = New System.Drawing.Point(8, 23)
        Me.cmbInheritanceName.Name = "cmbInheritanceName"
        Me.cmbInheritanceName.Size = New System.Drawing.Size(200, 21)
        Me.cmbInheritanceName.TabIndex = 0
        Me.cmbInheritanceName.Tag = "xml_Inheritance"
        Me.cmbInheritanceName.Text = Global.PropertyGenerator.My.MySettings.Default.InheritanceName
        Me.ToolTip1.SetToolTip(Me.cmbInheritanceName, "Inheritance.")
        Me.cmbInheritanceName.ValueMember = "xml_Inheritance.InheritanceName"
        '
        'grpSubType
        '
        Me.grpSubType.Controls.Add(Me.rdbSubParamNone)
        Me.grpSubType.Controls.Add(Me.rdbSubParamList)
        Me.grpSubType.Controls.Add(Me.cmbSubName)
        Me.grpSubType.Controls.Add(Me.btnAddSub)
        Me.grpSubType.Controls.Add(Me.cmbFuncType)
        Me.grpSubType.Controls.Add(Me.cmbSubType)
        Me.grpSubType.Controls.Add(Me.cmbSubArrival)
        Me.grpSubType.Location = New System.Drawing.Point(253, 28)
        Me.grpSubType.Name = "grpSubType"
        Me.grpSubType.Padding = New System.Windows.Forms.Padding(5, 10, 5, 5)
        Me.grpSubType.Size = New System.Drawing.Size(237, 189)
        Me.grpSubType.TabIndex = 11
        Me.grpSubType.TabStop = False
        Me.grpSubType.Text = "2. Sub Type"
        '
        'rdbSubParamNone
        '
        Me.rdbSubParamNone.AutoSize = True
        Me.rdbSubParamNone.Location = New System.Drawing.Point(122, 108)
        Me.rdbSubParamNone.Name = "rdbSubParamNone"
        Me.rdbSubParamNone.Size = New System.Drawing.Size(51, 17)
        Me.rdbSubParamNone.TabIndex = 22
        Me.rdbSubParamNone.TabStop = True
        Me.rdbSubParamNone.Text = "None"
        Me.ToolTip1.SetToolTip(Me.rdbSubParamNone, "No Variables.")
        Me.rdbSubParamNone.UseVisualStyleBackColor = True
        '
        'rdbSubParamList
        '
        Me.rdbSubParamList.AutoSize = True
        Me.rdbSubParamList.Checked = True
        Me.rdbSubParamList.Location = New System.Drawing.Point(8, 108)
        Me.rdbSubParamList.Name = "rdbSubParamList"
        Me.rdbSubParamList.Size = New System.Drawing.Size(108, 17)
        Me.rdbSubParamList.TabIndex = 21
        Me.rdbSubParamList.TabStop = True
        Me.rdbSubParamList.Text = "From Variable List"
        Me.ToolTip1.SetToolTip(Me.rdbSubParamList, "Use Checked Items(Variables) On Variable List.")
        Me.rdbSubParamList.UseVisualStyleBackColor = True
        '
        'cmbSubName
        '
        Me.cmbSubName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSubName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.PropertyGenerator.My.MySettings.Default, "SubName", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbSubName.DataSource = Me.dsLists
        Me.cmbSubName.DisplayMember = "xml_SubName.SubName"
        Me.cmbSubName.FormattingEnabled = True
        Me.cmbSubName.Location = New System.Drawing.Point(8, 77)
        Me.cmbSubName.Name = "cmbSubName"
        Me.cmbSubName.Size = New System.Drawing.Size(200, 21)
        Me.cmbSubName.TabIndex = 20
        Me.cmbSubName.Tag = "xml_SubName"
        Me.ToolTip1.SetToolTip(Me.cmbSubName, "Sub Name.")
        Me.cmbSubName.ValueMember = "xml_SubName.SubName"
        '
        'btnAddSub
        '
        Me.btnAddSub.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddSub.Location = New System.Drawing.Point(154, 158)
        Me.btnAddSub.Name = "btnAddSub"
        Me.btnAddSub.Size = New System.Drawing.Size(75, 22)
        Me.btnAddSub.TabIndex = 19
        Me.btnAddSub.Text = "Add"
        Me.ToolTip1.SetToolTip(Me.btnAddSub, "Add Sub To Sub List.")
        Me.btnAddSub.UseVisualStyleBackColor = True
        '
        'cmbFuncType
        '
        Me.cmbFuncType.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbFuncType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.PropertyGenerator.My.MySettings.Default, "FunctionType", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbFuncType.DataSource = Me.dsLists
        Me.cmbFuncType.DisplayMember = "xml_FuncType.FuncType"
        Me.cmbFuncType.Enabled = False
        Me.cmbFuncType.FormattingEnabled = True
        Me.cmbFuncType.Location = New System.Drawing.Point(8, 131)
        Me.cmbFuncType.Name = "cmbFuncType"
        Me.cmbFuncType.Size = New System.Drawing.Size(200, 21)
        Me.cmbFuncType.TabIndex = 18
        Me.cmbFuncType.Tag = "xml_FuncType"
        Me.ToolTip1.SetToolTip(Me.cmbFuncType, "Function Type.")
        Me.cmbFuncType.ValueMember = "xml_FuncType.FuncType"
        '
        'cmbSubType
        '
        Me.cmbSubType.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSubType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.PropertyGenerator.My.MySettings.Default, "SubType", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbSubType.DataSource = Me.dsLists
        Me.cmbSubType.DisplayMember = "xml_SubType.SubType"
        Me.cmbSubType.FormattingEnabled = True
        Me.cmbSubType.Location = New System.Drawing.Point(8, 50)
        Me.cmbSubType.Name = "cmbSubType"
        Me.cmbSubType.Size = New System.Drawing.Size(200, 21)
        Me.cmbSubType.TabIndex = 17
        Me.cmbSubType.Tag = "xml_SubType"
        Me.ToolTip1.SetToolTip(Me.cmbSubType, "Sub Type.")
        Me.cmbSubType.ValueMember = "xml_SubType.SubType"
        '
        'cmbSubArrival
        '
        Me.cmbSubArrival.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSubArrival.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.PropertyGenerator.My.MySettings.Default, "SubArrival", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbSubArrival.DataSource = Me.dsLists
        Me.cmbSubArrival.DisplayMember = "xml_SubArrival.SubArrival"
        Me.cmbSubArrival.FormattingEnabled = True
        Me.cmbSubArrival.Location = New System.Drawing.Point(8, 23)
        Me.cmbSubArrival.Name = "cmbSubArrival"
        Me.cmbSubArrival.Size = New System.Drawing.Size(200, 21)
        Me.cmbSubArrival.TabIndex = 16
        Me.cmbSubArrival.Tag = "xml_SubArrival"
        Me.ToolTip1.SetToolTip(Me.cmbSubArrival, "Sub Arrival.")
        Me.cmbSubArrival.ValueMember = "xml_SubArrival.SubArrival"
        '
        'grpVariableList
        '
        Me.grpVariableList.Controls.Add(Me.btnAddVariable)
        Me.grpVariableList.Controls.Add(Me.sstVariableList)
        Me.grpVariableList.Controls.Add(Me.lsvVariableList)
        Me.grpVariableList.Controls.Add(Me.cmbVariableType)
        Me.grpVariableList.Controls.Add(Me.cmbVariableName)
        Me.grpVariableList.Location = New System.Drawing.Point(8, 28)
        Me.grpVariableList.Name = "grpVariableList"
        Me.grpVariableList.Padding = New System.Windows.Forms.Padding(5, 10, 5, 5)
        Me.grpVariableList.Size = New System.Drawing.Size(239, 371)
        Me.grpVariableList.TabIndex = 10
        Me.grpVariableList.TabStop = False
        Me.grpVariableList.Text = "1. Variable List"
        '
        'btnAddVariable
        '
        Me.btnAddVariable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddVariable.Location = New System.Drawing.Point(156, 76)
        Me.btnAddVariable.Name = "btnAddVariable"
        Me.btnAddVariable.Size = New System.Drawing.Size(75, 22)
        Me.btnAddVariable.TabIndex = 14
        Me.btnAddVariable.Text = "Add"
        Me.ToolTip1.SetToolTip(Me.btnAddVariable, "Add Variable To Variable List.")
        Me.btnAddVariable.UseVisualStyleBackColor = True
        '
        'sstVariableList
        '
        Me.sstVariableList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sstVariableList.AutoSize = False
        Me.sstVariableList.Dock = System.Windows.Forms.DockStyle.None
        Me.sstVariableList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssVariableCount})
        Me.sstVariableList.Location = New System.Drawing.Point(8, 344)
        Me.sstVariableList.Name = "sstVariableList"
        Me.sstVariableList.Size = New System.Drawing.Size(223, 22)
        Me.sstVariableList.TabIndex = 13
        Me.sstVariableList.Text = "StatusStrip2"
        '
        'tssVariableCount
        '
        Me.tssVariableCount.Name = "tssVariableCount"
        Me.tssVariableCount.Size = New System.Drawing.Size(89, 17)
        Me.tssVariableCount.Text = "Variables Count :"
        '
        'lsvVariableList
        '
        Me.lsvVariableList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsvVariableList.CheckBoxes = True
        Me.lsvVariableList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmVariableName, Me.clmVariableType})
        Me.lsvVariableList.ContextMenuStrip = Me.cmnuListRightClick
        Me.lsvVariableList.FullRowSelect = True
        Me.lsvVariableList.Location = New System.Drawing.Point(8, 104)
        Me.lsvVariableList.Name = "lsvVariableList"
        Me.lsvVariableList.Size = New System.Drawing.Size(223, 240)
        Me.lsvVariableList.TabIndex = 12
        Me.lsvVariableList.Tag = "VariableList"
        Me.lsvVariableList.UseCompatibleStateImageBehavior = False
        Me.lsvVariableList.View = System.Windows.Forms.View.Details
        '
        'clmVariableName
        '
        Me.clmVariableName.Text = Global.PropertyGenerator.My.MySettings.Default.clmVariableName
        Me.clmVariableName.Width = Global.PropertyGenerator.My.MySettings.Default.clmVariableNameWidth
        '
        'clmVariableType
        '
        Me.clmVariableType.Text = Global.PropertyGenerator.My.MySettings.Default.clmVariableType
        Me.clmVariableType.Width = Global.PropertyGenerator.My.MySettings.Default.clmVariableTypeWidth
        '
        'cmbVariableType
        '
        Me.cmbVariableType.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbVariableType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.PropertyGenerator.My.MySettings.Default, "VariableType", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbVariableType.DataSource = Me.dsLists
        Me.cmbVariableType.DisplayMember = "xml_VariableType.VariableType"
        Me.cmbVariableType.FormattingEnabled = True
        Me.cmbVariableType.Location = New System.Drawing.Point(8, 50)
        Me.cmbVariableType.Name = "cmbVariableType"
        Me.cmbVariableType.Size = New System.Drawing.Size(200, 21)
        Me.cmbVariableType.TabIndex = 11
        Me.cmbVariableType.Tag = "xml_VariableType"
        Me.ToolTip1.SetToolTip(Me.cmbVariableType, "Variable Type.")
        Me.cmbVariableType.ValueMember = "xml_VariableType.VariableType"
        '
        'cmbVariableName
        '
        Me.cmbVariableName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbVariableName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.PropertyGenerator.My.MySettings.Default, "VariableName", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbVariableName.DataSource = Me.dsLists
        Me.cmbVariableName.DisplayMember = "xml_VariableName.VariableName"
        Me.cmbVariableName.FormattingEnabled = True
        Me.cmbVariableName.Location = New System.Drawing.Point(8, 23)
        Me.cmbVariableName.Name = "cmbVariableName"
        Me.cmbVariableName.Size = New System.Drawing.Size(200, 21)
        Me.cmbVariableName.TabIndex = 10
        Me.cmbVariableName.Tag = "xml_VariableName"
        Me.ToolTip1.SetToolTip(Me.cmbVariableName, "Variable Name.")
        Me.cmbVariableName.ValueMember = "xml_VariableName.VariableName"
        '
        'grpSubList
        '
        Me.grpSubList.Controls.Add(Me.lsvSubList)
        Me.grpSubList.Controls.Add(Me.sstSubList)
        Me.grpSubList.Location = New System.Drawing.Point(253, 223)
        Me.grpSubList.Name = "grpSubList"
        Me.grpSubList.Padding = New System.Windows.Forms.Padding(5, 10, 5, 5)
        Me.grpSubList.Size = New System.Drawing.Size(237, 176)
        Me.grpSubList.TabIndex = 12
        Me.grpSubList.TabStop = False
        Me.grpSubList.Text = "3. Sub List"
        '
        'lsvSubList
        '
        Me.lsvSubList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsvSubList.CheckBoxes = True
        Me.lsvSubList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmSubArrival, Me.clmSubType, Me.clmSubName, Me.clmSubParameterList, Me.clmReturnType})
        Me.lsvSubList.ContextMenuStrip = Me.cmnuListRightClick
        Me.lsvSubList.FullRowSelect = True
        Me.lsvSubList.Location = New System.Drawing.Point(8, 24)
        Me.lsvSubList.Name = "lsvSubList"
        Me.lsvSubList.Size = New System.Drawing.Size(221, 125)
        Me.lsvSubList.TabIndex = 3
        Me.lsvSubList.Tag = "SubList"
        Me.lsvSubList.UseCompatibleStateImageBehavior = False
        Me.lsvSubList.View = System.Windows.Forms.View.Details
        '
        'clmSubArrival
        '
        Me.clmSubArrival.Text = Global.PropertyGenerator.My.MySettings.Default.clmSubArrival
        Me.clmSubArrival.Width = Global.PropertyGenerator.My.MySettings.Default.clmSubArrivalWidth
        '
        'clmSubType
        '
        Me.clmSubType.Text = Global.PropertyGenerator.My.MySettings.Default.clmSubType
        Me.clmSubType.Width = Global.PropertyGenerator.My.MySettings.Default.clmSubTypeWidth
        '
        'clmSubName
        '
        Me.clmSubName.Text = Global.PropertyGenerator.My.MySettings.Default.clmSubName
        Me.clmSubName.Width = Global.PropertyGenerator.My.MySettings.Default.clmSubNameWidth
        '
        'clmSubParameterList
        '
        Me.clmSubParameterList.Text = Global.PropertyGenerator.My.MySettings.Default.clmSubParameterList
        Me.clmSubParameterList.Width = Global.PropertyGenerator.My.MySettings.Default.clmSubParameterListWidth
        '
        'clmReturnType
        '
        Me.clmReturnType.Text = Global.PropertyGenerator.My.MySettings.Default.clmReturnType
        Me.clmReturnType.Width = Global.PropertyGenerator.My.MySettings.Default.clmReturnTypeWidth
        '
        'sstSubList
        '
        Me.sstSubList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sstSubList.AutoSize = False
        Me.sstSubList.Dock = System.Windows.Forms.DockStyle.None
        Me.sstSubList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssSubCount})
        Me.sstSubList.Location = New System.Drawing.Point(8, 149)
        Me.sstSubList.Name = "sstSubList"
        Me.sstSubList.Size = New System.Drawing.Size(221, 22)
        Me.sstSubList.TabIndex = 2
        Me.sstSubList.Text = "StatusStrip3"
        '
        'tssSubCount
        '
        Me.tssSubCount.Name = "tssSubCount"
        Me.tssSubCount.Size = New System.Drawing.Size(69, 17)
        Me.tssSubCount.Text = "Subs Count :"
        '
        'tstClass
        '
        Me.tstClass.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnOpen, Me.btnMainSave, Me.ToolStripSeparator6, Me.tslClassName, Me.txtClassName, Me.btnCreate})
        Me.tstClass.Location = New System.Drawing.Point(5, 0)
        Me.tstClass.Name = "tstClass"
        Me.tstClass.Size = New System.Drawing.Size(488, 25)
        Me.tstClass.TabIndex = 9
        Me.tstClass.Text = "ToolStrip2"
        '
        'tslClassName
        '
        Me.tslClassName.Name = "tslClassName"
        Me.tslClassName.Size = New System.Drawing.Size(69, 22)
        Me.tslClassName.Text = "Class Name :"
        '
        'txtClassName
        '
        Me.txtClassName.Name = "txtClassName"
        Me.txtClassName.Size = New System.Drawing.Size(100, 25)
        Me.txtClassName.Text = Global.PropertyGenerator.My.MySettings.Default.ClassName
        Me.txtClassName.ToolTipText = "Class Name."
        '
        'btnCreate
        '
        Me.btnCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCreate.Image = Global.PropertyGenerator.My.Resources.Resources.git
        Me.btnCreate.ImageTransparentColor = System.Drawing.Color.White
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(23, 22)
        Me.btnCreate.Text = "Create Code."
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.ToolStripContainer2)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(396, 551)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(5, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(396, 576)
        Me.ToolStripContainer1.TabIndex = 1
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.tstCode)
        '
        'ToolStripContainer2
        '
        '
        'ToolStripContainer2.BottomToolStripPanel
        '
        Me.ToolStripContainer2.BottomToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.rtbCode)
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.sstCodeStatus)
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(396, 501)
        Me.ToolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.Size = New System.Drawing.Size(396, 551)
        Me.ToolStripContainer2.TabIndex = 1
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmbFonts, Me.btnFont, Me.cmbFontSize, Me.ToolStripSeparator2, Me.btnBold, Me.btnItalic, Me.btnUnderline, Me.ToolStripSeparator3, Me.btnCurrentColor, Me.btnFontColor})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(362, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmbFonts
        '
        Me.cmbFonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFonts.Name = "cmbFonts"
        Me.cmbFonts.Size = New System.Drawing.Size(121, 25)
        Me.cmbFonts.ToolTipText = "Select Font Type For Selection Text On Textbox."
        '
        'btnFont
        '
        Me.btnFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFont.Image = CType(resources.GetObject("btnFont.Image"), System.Drawing.Image)
        Me.btnFont.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFont.Name = "btnFont"
        Me.btnFont.Size = New System.Drawing.Size(23, 22)
        Me.btnFont.Text = "ToolStripButton2"
        Me.btnFont.ToolTipText = "Select Advanced Font."
        '
        'cmbFontSize
        '
        Me.cmbFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFontSize.Name = "cmbFontSize"
        Me.cmbFontSize.Size = New System.Drawing.Size(75, 25)
        Me.cmbFontSize.ToolTipText = "Select Font Size For Selection Text On Textbox."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnBold
        '
        Me.btnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnBold.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBold.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBold.Name = "btnBold"
        Me.btnBold.Size = New System.Drawing.Size(23, 22)
        Me.btnBold.Text = "B"
        Me.btnBold.ToolTipText = "Bold."
        '
        'btnItalic
        '
        Me.btnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnItalic.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnItalic.Image = CType(resources.GetObject("btnItalic.Image"), System.Drawing.Image)
        Me.btnItalic.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnItalic.Name = "btnItalic"
        Me.btnItalic.Size = New System.Drawing.Size(23, 22)
        Me.btnItalic.Text = "I"
        Me.btnItalic.ToolTipText = "Italic."
        '
        'btnUnderline
        '
        Me.btnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnUnderline.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.btnUnderline.Image = CType(resources.GetObject("btnUnderline.Image"), System.Drawing.Image)
        Me.btnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUnderline.Name = "btnUnderline"
        Me.btnUnderline.Size = New System.Drawing.Size(23, 22)
        Me.btnUnderline.Text = "U"
        Me.btnUnderline.ToolTipText = "Underline."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnCurrentColor
        '
        Me.btnCurrentColor.BackColor = System.Drawing.SystemColors.Control
        Me.btnCurrentColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnCurrentColor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnCurrentColor.ForeColor = System.Drawing.Color.Black
        Me.btnCurrentColor.Image = CType(resources.GetObject("btnCurrentColor.Image"), System.Drawing.Image)
        Me.btnCurrentColor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCurrentColor.Name = "btnCurrentColor"
        Me.btnCurrentColor.Size = New System.Drawing.Size(23, 22)
        Me.btnCurrentColor.Text = "C"
        Me.btnCurrentColor.ToolTipText = "Current Color."
        '
        'btnFontColor
        '
        Me.btnFontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFontColor.Image = CType(resources.GetObject("btnFontColor.Image"), System.Drawing.Image)
        Me.btnFontColor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFontColor.Name = "btnFontColor"
        Me.btnFontColor.Size = New System.Drawing.Size(23, 22)
        Me.btnFontColor.Text = "ToolStripButton1"
        Me.btnFontColor.ToolTipText = "Color."
        '
        'rtbCode
        '
        Me.rtbCode.AutoWordSelection = True
        Me.rtbCode.ContextMenuStrip = Me.cmnuCodeText
        Me.rtbCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbCode.Location = New System.Drawing.Point(0, 0)
        Me.rtbCode.Name = "rtbCode"
        Me.rtbCode.Size = New System.Drawing.Size(396, 479)
        Me.rtbCode.TabIndex = 6
        Me.rtbCode.Text = ""
        '
        'cmnuCodeText
        '
        Me.cmnuCodeText.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuCut, Me.cmnuCopy, Me.ToolStripMenuItem4, Me.cmnuPaste, Me.ToolStripMenuItem5, Me.cmnuUndo, Me.cmnuSelectAllCodeText, Me.ToolStripMenuItem6, Me.cmnuPaintString})
        Me.cmnuCodeText.Name = "cmnuCodeText"
        Me.cmnuCodeText.Size = New System.Drawing.Size(201, 154)
        '
        'cmnuCut
        '
        Me.cmnuCut.Name = "cmnuCut"
        Me.cmnuCut.Size = New System.Drawing.Size(200, 22)
        Me.cmnuCut.Text = "Cut"
        Me.cmnuCut.ToolTipText = "Cut"
        '
        'cmnuCopy
        '
        Me.cmnuCopy.Name = "cmnuCopy"
        Me.cmnuCopy.Size = New System.Drawing.Size(200, 22)
        Me.cmnuCopy.Text = "Copy"
        Me.cmnuCopy.ToolTipText = "Copy"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(197, 6)
        '
        'cmnuPaste
        '
        Me.cmnuPaste.Name = "cmnuPaste"
        Me.cmnuPaste.Size = New System.Drawing.Size(200, 22)
        Me.cmnuPaste.Text = "Paste"
        Me.cmnuPaste.ToolTipText = "Paste"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(197, 6)
        '
        'cmnuUndo
        '
        Me.cmnuUndo.Name = "cmnuUndo"
        Me.cmnuUndo.Size = New System.Drawing.Size(200, 22)
        Me.cmnuUndo.Text = "Undo"
        '
        'cmnuSelectAllCodeText
        '
        Me.cmnuSelectAllCodeText.Name = "cmnuSelectAllCodeText"
        Me.cmnuSelectAllCodeText.Size = New System.Drawing.Size(200, 22)
        Me.cmnuSelectAllCodeText.Text = "Select All"
        Me.cmnuSelectAllCodeText.ToolTipText = "Select All Text."
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(197, 6)
        '
        'cmnuPaintString
        '
        Me.cmnuPaintString.Name = "cmnuPaintString"
        Me.cmnuPaintString.Size = New System.Drawing.Size(200, 22)
        Me.cmnuPaintString.Text = "Paint with Current Color"
        Me.cmnuPaintString.ToolTipText = "Paint with Current Color."
        '
        'sstCodeStatus
        '
        Me.sstCodeStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssCodeLineCount})
        Me.sstCodeStatus.Location = New System.Drawing.Point(0, 479)
        Me.sstCodeStatus.Name = "sstCodeStatus"
        Me.sstCodeStatus.Size = New System.Drawing.Size(396, 22)
        Me.sstCodeStatus.TabIndex = 5
        Me.sstCodeStatus.Text = "StatusStrip1"
        '
        'tssCodeLineCount
        '
        Me.tssCodeLineCount.Name = "tssCodeLineCount"
        Me.tssCodeLineCount.Size = New System.Drawing.Size(70, 17)
        Me.tssCodeLineCount.Text = "Lines Count :"
        '
        'tstCode
        '
        Me.tstCode.Dock = System.Windows.Forms.DockStyle.None
        Me.tstCode.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnSaveCode, Me.ToolStripSeparator4, Me.btnUndo, Me.toolStripSeparator, Me.btnCut, Me.btnCopy, Me.btnPaste, Me.toolStripSeparator1, Me.btnPaintToFont, Me.ToolStripSeparator5, Me.btnFind})
        Me.tstCode.Location = New System.Drawing.Point(3, 0)
        Me.tstCode.Name = "tstCode"
        Me.tstCode.Size = New System.Drawing.Size(220, 25)
        Me.tstCode.TabIndex = 1
        Me.tstCode.Text = "ToolStrip1"
        '
        'btnNew
        '
        Me.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(23, 22)
        Me.btnNew.Text = "&New"
        '
        'btnSaveCode
        '
        Me.btnSaveCode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSaveCode.Image = CType(resources.GetObject("btnSaveCode.Image"), System.Drawing.Image)
        Me.btnSaveCode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSaveCode.Name = "btnSaveCode"
        Me.btnSaveCode.Size = New System.Drawing.Size(23, 22)
        Me.btnSaveCode.Text = "&Save"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'btnUndo
        '
        Me.btnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnUndo.Image = CType(resources.GetObject("btnUndo.Image"), System.Drawing.Image)
        Me.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(23, 22)
        Me.btnUndo.Text = "ToolStripButton1"
        Me.btnUndo.ToolTipText = "Undo."
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'btnCut
        '
        Me.btnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCut.Image = CType(resources.GetObject("btnCut.Image"), System.Drawing.Image)
        Me.btnCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCut.Name = "btnCut"
        Me.btnCut.Size = New System.Drawing.Size(23, 22)
        Me.btnCut.Text = "C&ut"
        '
        'btnCopy
        '
        Me.btnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCopy.Image = CType(resources.GetObject("btnCopy.Image"), System.Drawing.Image)
        Me.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(23, 22)
        Me.btnCopy.Text = "&Copy"
        '
        'btnPaste
        '
        Me.btnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPaste.Image = CType(resources.GetObject("btnPaste.Image"), System.Drawing.Image)
        Me.btnPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Size = New System.Drawing.Size(23, 22)
        Me.btnPaste.Text = "&Paste"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnPaintToFont
        '
        Me.btnPaintToFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPaintToFont.Image = CType(resources.GetObject("btnPaintToFont.Image"), System.Drawing.Image)
        Me.btnPaintToFont.ImageTransparentColor = System.Drawing.Color.White
        Me.btnPaintToFont.Name = "btnPaintToFont"
        Me.btnPaintToFont.Size = New System.Drawing.Size(23, 22)
        Me.btnPaintToFont.Text = "ToolStripButton2"
        Me.btnPaintToFont.ToolTipText = "Paint To Text."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'btnFind
        '
        Me.btnFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFind.Image = CType(resources.GetObject("btnFind.Image"), System.Drawing.Image)
        Me.btnFind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(23, 22)
        Me.btnFind.Text = "ToolStripButton3"
        Me.btnFind.ToolTipText = "Find."
        '
        'errProvider
        '
        Me.errProvider.ContainerControl = Me
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Info :"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'btnMainSave
        '
        Me.btnMainSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnMainSave.Image = CType(resources.GetObject("btnMainSave.Image"), System.Drawing.Image)
        Me.btnMainSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMainSave.Name = "btnMainSave"
        Me.btnMainSave.Size = New System.Drawing.Size(23, 22)
        Me.btnMainSave.Text = "ToolStripButton1"
        '
        'btnOpen
        '
        Me.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnOpen.Image = CType(resources.GetObject("btnOpen.Image"), System.Drawing.Image)
        Me.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(23, 22)
        Me.btnOpen.Text = "&Open"
        Me.btnOpen.ToolTipText = "Taslak Aç"
        '
        'ClassControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ClassControl"
        Me.Size = New System.Drawing.Size(908, 581)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.grpImportanceList.ResumeLayout(False)
        Me.cmnuListRightClick.ResumeLayout(False)
        Me.sstImportList.ResumeLayout(False)
        Me.sstImportList.PerformLayout()
        CType(Me.dsLists, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblVariableName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblVariableType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblSubArrival, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblSubType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblSubName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblFuncType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblInheritance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblImportance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInheritanceList.ResumeLayout(False)
        Me.sstInheritanceList.ResumeLayout(False)
        Me.sstInheritanceList.PerformLayout()
        Me.grpSubType.ResumeLayout(False)
        Me.grpSubType.PerformLayout()
        Me.grpVariableList.ResumeLayout(False)
        Me.sstVariableList.ResumeLayout(False)
        Me.sstVariableList.PerformLayout()
        Me.grpSubList.ResumeLayout(False)
        Me.sstSubList.ResumeLayout(False)
        Me.sstSubList.PerformLayout()
        Me.tstClass.ResumeLayout(False)
        Me.tstClass.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStripContainer2.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer2.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer2.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer2.ContentPanel.PerformLayout()
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.cmnuCodeText.ResumeLayout(False)
        Me.sstCodeStatus.ResumeLayout(False)
        Me.sstCodeStatus.PerformLayout()
        Me.tstCode.ResumeLayout(False)
        Me.tstCode.PerformLayout()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents tstClass As System.Windows.Forms.ToolStrip
    Friend WithEvents grpImportanceList As System.Windows.Forms.GroupBox
    Friend WithEvents lsvImportList As System.Windows.Forms.ListView
    Friend WithEvents btnAddImport As System.Windows.Forms.Button
    Friend WithEvents sstImportList As System.Windows.Forms.StatusStrip
    Friend WithEvents cmbImportName As System.Windows.Forms.ComboBox
    Friend WithEvents grpInheritanceList As System.Windows.Forms.GroupBox
    Friend WithEvents lsvInheritanceList As System.Windows.Forms.ListView
    Friend WithEvents btnAddInheritance As System.Windows.Forms.Button
    Friend WithEvents sstInheritanceList As System.Windows.Forms.StatusStrip
    Friend WithEvents cmbInheritanceName As System.Windows.Forms.ComboBox
    Friend WithEvents grpSubType As System.Windows.Forms.GroupBox
    Friend WithEvents grpVariableList As System.Windows.Forms.GroupBox
    Friend WithEvents grpSubList As System.Windows.Forms.GroupBox
    Friend WithEvents tslClassName As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtClassName As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnCreate As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssInheritanceCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssImportCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tstCode As System.Windows.Forms.ToolStrip
    Friend WithEvents clmInheritanceName As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmImportanceName As System.Windows.Forms.ColumnHeader
    Friend WithEvents dsLists As System.Data.DataSet
    Friend WithEvents tblVariableName As System.Data.DataTable
    Friend WithEvents dcVariableName As System.Data.DataColumn
    Friend WithEvents tblVariableType As System.Data.DataTable
    Friend WithEvents tblSubArrival As System.Data.DataTable
    Friend WithEvents tblSubType As System.Data.DataTable
    Friend WithEvents tblSubName As System.Data.DataTable
    Friend WithEvents tblFuncType As System.Data.DataTable
    Friend WithEvents tblInheritance As System.Data.DataTable
    Friend WithEvents tblImportance As System.Data.DataTable
    Friend WithEvents dcVariableType As System.Data.DataColumn
    Friend WithEvents dcSubArrival As System.Data.DataColumn
    Friend WithEvents dcSubType As System.Data.DataColumn
    Friend WithEvents dcSubName As System.Data.DataColumn
    Friend WithEvents dcFuncType As System.Data.DataColumn
    Friend WithEvents dcInheritanceName As System.Data.DataColumn
    Friend WithEvents dcImportanceName As System.Data.DataColumn
    Friend WithEvents errProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmbSubName As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddSub As System.Windows.Forms.Button
    Friend WithEvents cmbFuncType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSubType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSubArrival As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddVariable As System.Windows.Forms.Button
    Friend WithEvents sstVariableList As System.Windows.Forms.StatusStrip
    Friend WithEvents tssVariableCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lsvVariableList As System.Windows.Forms.ListView
    Friend WithEvents clmVariableName As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmVariableType As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmbVariableType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbVariableName As System.Windows.Forms.ComboBox
    Friend WithEvents lsvSubList As System.Windows.Forms.ListView
    Friend WithEvents clmSubArrival As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmSubType As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmSubName As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmSubParameterList As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmReturnType As System.Windows.Forms.ColumnHeader
    Friend WithEvents sstSubList As System.Windows.Forms.StatusStrip
    Friend WithEvents tssSubCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents rdbSubParamNone As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSubParamList As System.Windows.Forms.RadioButton
    Friend WithEvents cmnuListRightClick As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmnuMoveUp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuMoveDown As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuSelectedDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmnuDeleteAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmnuLargeViewList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSaveCode As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCut As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPaste As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cmnuSelectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuUnselectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStripContainer2 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents rtbCode As System.Windows.Forms.RichTextBox
    Friend WithEvents sstCodeStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents tssCodeLineCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cmbFonts As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnFontColor As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnFont As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnBold As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnItalic As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnUnderline As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbFontSize As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnPaintToFont As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnFind As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCurrentColor As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmnuCodeText As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmnuCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmnuPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmnuSelectAllCodeText As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmnuPaintString As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnUndo As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmnuUndo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMainSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator

End Class
