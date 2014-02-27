#Region "imports"
Imports System.Text
Imports System.Drawing
#End Region

Public Class ClassControl

    Private FocusLsv As ListView
    Private frmFontToColor As FontToColor

#Region "Methods"
    Private Sub cmnuListViewsMenuItemsProcess(ByVal btn As ToolStripMenuItem)
        Select Case btn.Name.ToString

            Case "cmnuMoveUp"
                Dim index As Integer = Me.FocusLsv.FocusedItem.Index

                If Not index = -1 Then
                    Dim itm As ListViewItem = Me.FocusLsv.FocusedItem
                    If Not index = 0 Then
                        Me.FocusLsv.Items.RemoveAt(index)
                        Me.FocusLsv.Items.Insert(index - 1, itm)
                        Me.FocusLsv.Items(index - 1).Focused = True
                    End If
                End If

            Case "cmnuMoveDown"
                Dim index As Integer = Me.FocusLsv.FocusedItem.Index

                If Not index = -1 Then
                    Dim itm As ListViewItem = Me.FocusLsv.FocusedItem
                    If Not index = Me.FocusLsv.Items.Count - 1 Then
                        Me.FocusLsv.Items.RemoveAt(index)
                        Me.FocusLsv.Items.Insert(index + 1, itm)
                        Me.FocusLsv.Items(index + 1).Focused = True
                    End If
                End If

            Case "cmnuSelectedDelete"
                For Each itm As ListViewItem In Me.FocusLsv.CheckedItems
                    itm.Remove()
                Next

                Dim objLsvPro As objListViewProperty = CType(FocusLsv.Tag, objListViewProperty)
                ToolStripStatus_WriteCountLabel(FocusLsv)

            Case "cmnuDeleteAll"
                Me.FocusLsv.Items.Clear()

                Dim objLsvPro As objListViewProperty = CType(FocusLsv.Tag, objListViewProperty)
                ToolStripStatus_WriteCountLabel(FocusLsv)

            Case "cmnuSelectAll"
                For Each itm As ListViewItem In Me.FocusLsv.Items
                    itm.Checked = True
                Next

            Case "cmnuUnselectAll"
                For Each itm As ListViewItem In Me.FocusLsv.Items
                    itm.Checked = False
                Next

            Case "cmnuLargeViewList"
                Dim frm As LargeListView = New LargeListView
                frm.LoadListView(FocusLsv)
                frm.Show()
        End Select
    End Sub

    Public Sub ToolStripStatus_WriteCountLabel(ByVal lsv As ListView)
        Dim objLsvPro As objListViewProperty = CType(lsv.Tag, objListViewProperty)
        Dim lbl As ToolStripStatusLabel = objLsvPro.lblCount

        Select Case objLsvPro.lsvCaption.ToString
            Case "Variable List"
                lbl.Text = "Variables Count : " & lsv.Items.Count.ToString
                Me.sstVariableList.Items.Clear()
                Me.sstVariableList.Items.Add(objLsvPro.lblCount)
            Case "Sub List"
                lbl.Text = "Subs Count : " & lsv.Items.Count.ToString
                Me.sstSubList.Items.Clear()
                Me.sstSubList.Items.Add(objLsvPro.lblCount)
            Case "Inheritance List"
                lbl.Text = "Inheritances Count : " & lsv.Items.Count.ToString
                Me.sstInheritanceList.Items.Clear()
                Me.sstInheritanceList.Items.Add(objLsvPro.lblCount)
            Case "Importance List"
                lbl.Text = "Importances Count : " & lsv.Items.Count.ToString
                Me.sstImportList.Items.Clear()
                Me.sstImportList.Items.Add(objLsvPro.lblCount)
        End Select

        objLsvPro.lblCount = lbl
    End Sub

    Public Sub OpenSaveFile(ByVal sender As Object, ByVal e As EventArgs)
        Me.OpenFileDialog1.Filter = "Property Generator Save File(*.pgd)|*.pgd"

        If Me.OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim FName As String = Me.OpenFileDialog1.FileName.ToString
            Dim dt As DataTable = New DataTable

            dt.ReadXmlSchema(FName.Substring(0, FName.LastIndexOf(".") + 1) & "pgs")
            dt.ReadXml(FName)

            'Dim f As Form = New Form
            'Dim d As DataGridView = New DataGridView
            'd.Dock = DockStyle.Fill
            'd.DataSource = dt

            'f.Controls.Add(d)
            'f.Show()

            Me.txtClassName.Text = dt.TableName.ToString

            Dim itm As ListViewItem

            For Each dr As DataRow In dt.Rows

                'VariableLÝst
                If Not dr(0) Is DBNull.Value AndAlso Not dr(0) Is DBNull.Value Then
                    itm = New ListViewItem

                    itm.Text = dr(0).ToString
                    itm.SubItems.Add(dr(1).ToString)

                    Me.lsvVariableList.Items.Add(itm)
                End If

                'SubList
                If Not dr(2) Is DBNull.Value AndAlso Not dr(3) Is DBNull.Value AndAlso Not dr(4) Is DBNull.Value AndAlso Not dr(5) Is DBNull.Value AndAlso Not dr(6) Is DBNull.Value Then
                    itm = New ListViewItem

                    itm.Text = dr(2).ToString
                    itm.SubItems.Add(dr(3).ToString)
                    itm.SubItems.Add(dr(4).ToString)
                    itm.SubItems.Add(dr(5).ToString)
                    itm.SubItems.Add(dr(6).ToString)

                    Me.lsvSubList.Items.Add(itm)
                End If

                'ImportList
                If Not dr(7) Is DBNull.Value Then
                    itm = New ListViewItem

                    itm.Text = dr(7).ToString

                    Me.lsvImportList.Items.Add(itm)
                End If

                'InheritanceList
                If Not dr(8) Is DBNull.Value Then
                    itm = New ListViewItem

                    itm.Text = dr(8).ToString

                    Me.lsvInheritanceList.Items.Add(itm)
                End If
            Next

            If System.IO.File.Exists(FName.Substring(0, FName.LastIndexOf(".") + 1) & "rtf") = True Then
                Dim FWR As DLL_FileReaderWriter.FileReading = New DLL_FileReaderWriter.FileReading
                Me.rtbCode.Rtf = FWR.FileRead(FName.Substring(0, FName.LastIndexOf(".") + 1) & "rtf")
            Else
                Me.rtbCode.Text = ""
            End If
        End If
    End Sub

    Public Sub CreateSaveFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim dt As DataTable = New DataTable(Me.txtClassName.Text)
        Dim dr As DataRow

        dt.Columns.AddRange(New DataColumn() {New DataColumn("VarListVarName"), New DataColumn("VarListVarType"), New DataColumn("SubListSubArrival"), New DataColumn("SubListSubType"), New DataColumn("SubListSubName"), New DataColumn("SubListParams"), New DataColumn("SubListFuncType"), New DataColumn("ImpListImp"), New DataColumn("InhListInh")})

        Dim arrListCount As ArrayList = New ArrayList
        arrListCount.Add(Me.lsvVariableList.Items.Count)
        arrListCount.Add(Me.lsvSubList.Items.Count)
        arrListCount.Add(Me.lsvInheritanceList.Items.Count)
        arrListCount.Add(Me.lsvImportList.Items.Count)

        arrListCount.Sort()

        For i As Integer = 0 To CInt(arrListCount(3).ToString) - 1
            dr = dt.NewRow

            'VariableLÝst
            If i < Me.lsvVariableList.Items.Count Then
                dr(0) = Me.lsvVariableList.Items(i).SubItems(0).Text
                dr(1) = Me.lsvVariableList.Items(i).SubItems(1).Text
            Else
                dr(0) = DBNull.Value
                dr(1) = DBNull.Value
            End If

            'SubList
            If i < Me.lsvSubList.Items.Count Then
                dr(2) = Me.lsvSubList.Items(i).SubItems(0).Text
                dr(3) = Me.lsvSubList.Items(i).SubItems(1).Text
                dr(4) = Me.lsvSubList.Items(i).SubItems(2).Text
                dr(5) = Me.lsvSubList.Items(i).SubItems(3).Text
                dr(6) = Me.lsvSubList.Items(i).SubItems(4).Text
            Else
                dr(2) = DBNull.Value
                dr(3) = DBNull.Value
                dr(4) = DBNull.Value
                dr(5) = DBNull.Value
                dr(6) = DBNull.Value
            End If

            'ImportList
            If i < Me.lsvImportList.Items.Count Then
                dr(7) = Me.lsvImportList.Items(i).SubItems(0).Text
            Else
                dr(7) = DBNull.Value
            End If

            'InheritanceList
            If i < Me.lsvInheritanceList.Items.Count Then
                dr(8) = Me.lsvInheritanceList.Items(i).SubItems(0).Text
            Else
                dr(8) = DBNull.Value
            End If

            dt.Rows.Add(dr)
        Next

        'Dim f As Form = New Form
        'Dim d As DataGridView = New DataGridView
        'd.Dock = DockStyle.Fill
        'd.DataSource = dt

        'f.Controls.Add(d)
        'f.Show()

        Me.SaveFileDialog1.Filter = "Property Generator Save File(*.pgd)|*.pgd"

        If Me.SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Dim FName As String = Me.SaveFileDialog1.FileName.ToString

            dt.WriteXmlSchema(FName.Substring(0, FName.LastIndexOf(".") + 1) & "pgs")
            dt.WriteXml(FName)

            If Me.rtbCode.Text.Trim.Length <> 0 Then Me.rtbCode.SaveFile(FName.Substring(0, FName.LastIndexOf(".") + 1) & "rtf")
        End If
    End Sub
#End Region

#Region "ComboboxTextSave"
    Public Function ComboboxTextSave(ByVal cmb As ComboBox) As Boolean
        ComboboxTextSave = True
        Dim IsThere As Boolean = False

        For Each dr As DataRow In Me.dsLists.Tables(cmb.Tag.ToString).Rows
            If dr(0).ToString.ToLower = cmb.Text.ToLower Then
                IsThere = True
                Exit For
            End If
        Next

        If IsThere = False Then
            'Eðer ilk karakter sayý ise uyarý verilir.
            If IsNumeric(cmb.Text.Substring(0, 1)) = True Then
                Me.errProvider.SetError(cmb, "Invalid Character! First character does not numeric character..")
                ComboboxTextSave = False
                Exit Function
            Else
                Me.errProvider.SetError(cmb, "")
            End If

            'Boþluklar giderilir..
            Dim sf As StringFunctions = New StringFunctions
            cmb.Text = sf.JoinFromWhiteSpace(cmb.Text, False)

            'Eðer combobox'a yazýlan ifade combobox'da yoksa combobox'a eklenir ve xml'e iþlenir..
            Dim dr As DataRow = dsLists.Tables(cmb.Tag.ToString).NewRow
            dr(0) = cmb.Text

            dsLists.Tables(cmb.Tag.ToString).Rows.Add(dr)
            dsLists.Tables(cmb.Tag.ToString).WriteXml(cmb.Tag.ToString & ".xml")

            cmb.Refresh()

            If Not cmb.Items.Count = 0 Then cmb.SelectedIndex = cmb.Items.Count - 1
        End If

        Return ComboboxTextSave
    End Function
#End Region

#Region "AddListViewItemToListViewControl"
    Public Function CreateParamString() As String
        CreateParamString = ""

        If Me.rdbSubParamList.Checked AndAlso _
            Me.lsvVariableList.CheckedItems.Count <> 0 Then

            Dim Param As StringBuilder = New StringBuilder
            Param.Append("(")

            For Each citm As ListViewItem In Me.lsvVariableList.CheckedItems
                Param.Append("ByVal " & citm.SubItems(0).Text & " As " & citm.SubItems(1).Text & ", ")
            Next

            Param.Remove(Param.Length - 2, 2)
            Param.Append(")")

            CreateParamString = Param.ToString
        Else
            CreateParamString = "None"
        End If

        Return CreateParamString
    End Function

    Public Sub CreateListViewItem(ByVal SubArrival As String, ByVal SubType As String, ByVal SubName As String, ByVal FuncType As String, ByVal SubList As ListView)
        Dim itm As ListViewItem

        Select Case SubType.ToLower

            Case "property", "readonly property"
                For Each citm As ListViewItem In Me.lsvVariableList.CheckedItems
                    itm = New ListViewItem
                    itm.Text = SubArrival
                    itm.SubItems.Add(SubType)
                    itm.SubItems.Add(citm.SubItems(0).Text)
                    itm.SubItems.Add("None")
                    itm.SubItems.Add(citm.SubItems(1).Text)

                    SubList.Items.Add(itm)
                Next
                Exit Sub

            Case "function"
                itm = New ListViewItem
                itm.Text = SubArrival
                itm.SubItems.Add(SubType)
                itm.SubItems.Add(SubName)
                itm.SubItems.Add(CreateParamString)
                itm.SubItems.Add(FuncType)

            Case "variable"
                For Each citm As ListViewItem In Me.lsvVariableList.CheckedItems
                    itm = New ListViewItem
                    itm.Text = SubArrival
                    itm.SubItems.Add(SubType)
                    itm.SubItems.Add(citm.SubItems(0).Text)
                    itm.SubItems.Add("None")
                    itm.SubItems.Add(citm.SubItems(1).Text)

                    SubList.Items.Add(itm)
                Next
                Exit Sub

            Case Else
                itm = New ListViewItem
                itm.Text = SubArrival
                itm.SubItems.Add(SubType)
                itm.SubItems.Add(SubName)
                itm.SubItems.Add(CreateParamString)
                itm.SubItems.Add("None")
        End Select

        SubList.Items.Add(itm)
    End Sub

    Public Sub AddItmListView(ByVal lsv As ListView)
        Dim itm As ListViewItem = New ListViewItem
        Dim objLsvPro As objListViewProperty = CType(lsv.Tag, objListViewProperty)

        Select Case objLsvPro.lsvCaption.ToString
            Case "Variable List"
                itm.Text = Me.cmbVariableName.Text
                itm.SubItems.Add(Me.cmbVariableType.Text)
            Case "Sub List"
                CreateListViewItem(Me.cmbSubArrival.Text, Me.cmbSubType.Text, Me.cmbSubName.Text, Me.cmbFuncType.Text, Me.lsvSubList)
                Exit Sub
            Case "Inheritance List"
                itm.Text = Me.cmbInheritanceName.Text
            Case "Importance List"
                itm.Text = Me.cmbImportName.Text
        End Select

        lsv.Items.Add(itm)
    End Sub
#End Region

#Region "Form & Combobox Events"
    Private Sub ClassControl_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.lsvImportList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        Me.lsvInheritanceList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        Me.lsvSubList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        Me.lsvVariableList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        Dim Path As String = Application.StartupPath.ToString & "\"

        Me.dsLists.Tables("xml_VariableName").ReadXml(Path & "xml_VariableName.xml")
        Me.dsLists.Tables("xml_VariableType").ReadXml(Path & "xml_VariableType.xml")
        Me.dsLists.Tables("xml_SubArrival").ReadXml(Path & "xml_SubArrival.xml")
        Me.dsLists.Tables("xml_SubType").ReadXml(Path & "xml_SubType.xml")
        Me.dsLists.Tables("xml_SubName").ReadXml(Path & "xml_SubName.xml")
        Me.dsLists.Tables("xml_FuncType").ReadXml(Path & "xml_FuncType.xml")
        Me.dsLists.Tables("xml_Inheritance").ReadXml(Path & "xml_Inheritance.xml")
        Me.dsLists.Tables("xml_Importance").ReadXml(Path & "xml_Importance.xml")

        For Each ctrl As Control In Me.SplitContainer1.Panel1.Controls
            'Combobox'larýn DataSource,DisplayMember,MemberValue özelliklerinin belirtilmesi..
            If TypeOf ctrl Is GroupBox Then
                For Each ctrl2 As Control In ctrl.Controls
                    If TypeOf ctrl2 Is ComboBox Then
                        Dim cmb As ComboBox = CType(ctrl2, ComboBox)
                        cmb.DataSource = Me.dsLists.Tables(cmb.Tag.ToString)
                        cmb.DisplayMember = Me.dsLists.Tables(cmb.Tag.ToString).Columns(0).ToString
                        cmb.ValueMember = Me.dsLists.Tables(cmb.Tag.ToString).Columns(0).ToString

                        'ListView'ýn baþlýðý ve içindeki item sayýsýný belirten status label'ý tag'a objListViewProperty class yapýsýnda kaydediyoruz..
                    ElseIf TypeOf ctrl2 Is ListView Then
                        Dim lsv As ListView = CType(ctrl2, ListView)
                        Dim objLsvPro As objListViewProperty
                        Dim tss_lbl As ToolStripStatusLabel

                        For Each ctrl3 As Control In ctrl.Controls
                            If TypeOf ctrl3 Is StatusStrip Then
                                tss_lbl = CType(ctrl3, StatusStrip).Items(0)
                                Exit For
                            End If
                        Next

                        objLsvPro = New objListViewProperty(CType(ctrl, GroupBox).Text.Substring(3).ToString, tss_lbl)
                        lsv.Tag = objLsvPro
                    End If
                Next
            End If
        Next

        'Overrides ToString Metodunu kullanarak FontFamily'den Font ismini getirebilmek için objFont Class'ýný yarattýk.
        If Me.cmbFonts.Items.Count = 0 Then
            For Each fmly As FontFamily In FontFamily.Families
                Dim fnt As objFont = New objFont(fmly)
                Me.cmbFonts.Items.Add(fnt)
            Next
        End If

        If Me.cmbFontSize.Items.Count = 0 Then
            For i As Single = 6 To 72
                Me.cmbFontSize.Items.Add(i)
            Next
        End If

        Me.cmbFonts.SelectedIndex = 0
        Me.cmbFontSize.SelectedIndex = 0

    End Sub

    Private Sub cmbSubType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSubType.SelectedIndexChanged
        If Me.cmbSubType.Text.ToLower = "function" Then
            Me.cmbFuncType.Enabled = True
        Else
            Me.cmbFuncType.Text = "None"
            Me.cmbFuncType.Enabled = False
        End If

        If Me.cmbSubType.Text.ToLower = "property" OrElse Me.cmbSubType.Text.ToLower = "readonly property" OrElse Me.cmbSubType.Text.ToLower = "variable" Then
            Me.cmbSubName.Enabled = False
            Me.rdbSubParamList.Checked = True
            Me.rdbSubParamList.Enabled = False
            Me.rdbSubParamNone.Enabled = False
        Else
            Me.cmbSubName.Enabled = True
            Me.rdbSubParamList.Enabled = True
            Me.rdbSubParamNone.Enabled = True
        End If
    End Sub
#End Region

#Region "Buttons"
    Private Sub btnAddVariable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddVariable.Click
        For Each ctrl As Control In Me.grpVariableList.Controls
            If TypeOf ctrl Is ComboBox Then
                ComboboxTextSave(CType(ctrl, ComboBox))
            End If
        Next

        AddItmListView(Me.lsvVariableList)
        ToolStripStatus_WriteCountLabel(Me.lsvVariableList)
    End Sub

    Private Sub btnAddSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSub.Click
        For Each ctrl As Control In Me.grpSubType.Controls
            If TypeOf ctrl Is ComboBox Then
                ComboboxTextSave(CType(ctrl, ComboBox))
            End If
        Next

        AddItmListView(Me.lsvSubList)
        ToolStripStatus_WriteCountLabel(Me.lsvSubList)
    End Sub

    Private Sub btnAddInheritance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddInheritance.Click
        For Each ctrl As Control In Me.grpInheritanceList.Controls
            If TypeOf ctrl Is ComboBox Then
                ComboboxTextSave(CType(ctrl, ComboBox))
            End If
        Next

        AddItmListView(Me.lsvInheritanceList)
        ToolStripStatus_WriteCountLabel(Me.lsvInheritanceList)
    End Sub

    Private Sub btnAddImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddImport.Click
        For Each ctrl As Control In Me.grpImportanceList.Controls
            If TypeOf ctrl Is ComboBox Then
                ComboboxTextSave(CType(ctrl, ComboBox))
            End If
        Next

        AddItmListView(Me.lsvImportList)
        ToolStripStatus_WriteCountLabel(Me.lsvImportList)
    End Sub
#End Region

    Private Sub btnMainSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainSave.Click
        CreateSaveFile(sender, e)
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        OpenSaveFile(sender, e)
    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        Dim usp As UserControlProcess = New UserControlProcess
        Me.rtbCode.Text = usp.CreateClassText(Me.txtClassName.Text, Me.lsvSubList, Me.lsvInheritanceList, Me.lsvImportList)
    End Sub

    Private Sub txtClassName_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtClassName.Click
        Me.txtClassName.SelectAll()
    End Sub

    Private Sub cmnuListViewMenuItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuMoveUp.Click, cmnuMoveDown.Click, cmnuSelectedDelete.Click, cmnuDeleteAll.Click, cmnuLargeViewList.Click, cmnuSelectAll.Click, cmnuUnselectAll.Click
        cmnuListViewsMenuItemsProcess(CType(sender, ToolStripMenuItem))
    End Sub

    Private Sub ListViews_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsvVariableList.MouseHover, lsvSubList.MouseHover, lsvInheritanceList.MouseHover, lsvImportList.MouseHover
        Me.FocusLsv = CType(sender, ListView)
    End Sub

#Region "CodeMenuStandartItems"
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Me.rtbCode.Text = Nothing
    End Sub

    Private Sub btnSaveCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveCode.Click
        Me.SaveFileDialog1.Filter = "Rich-Text File(*.rtf)|*.rtf|VB Class(*.vb)|*.vb"
        Me.SaveFileDialog1.FilterIndex = 0

        If Me.SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Me.rtbCode.SaveFile(Me.SaveFileDialog1.FileName, RichTextBoxStreamType.RichText)
            MessageBox.Show("Save Successfully!", "Save Successfully !", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub CutCopyPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCut.Click, btnCopy.Click, btnPaste.Click
        Select Case CType(sender, ToolStripButton).Name.ToString
            Case "btnCut"
                Me.rtbCode.Cut()
            Case "btnCopy"
                Me.rtbCode.Copy()
            Case "btnPaste"
                Me.rtbCode.Paste()
        End Select
    End Sub
#End Region

#Region "Font & Color Process"
    Private Sub ApplyFontOptions(ByVal fnt As System.Drawing.Font)
        Try

            If fnt.Bold = True Then
                Me.btnBold.ForeColor = Color.Red
            Else
                Me.btnBold.ForeColor = Color.Black
            End If

            If fnt.Italic = True Then
                Me.btnItalic.ForeColor = Color.Red
            Else
                Me.btnItalic.ForeColor = Color.Black
            End If

            If fnt.Underline = True Then
                Me.btnUnderline.ForeColor = Color.Red
            Else
                Me.btnUnderline.ForeColor = Color.Black
            End If

            For Each itm As Object In Me.cmbFonts.Items
                If CType(itm, objFont).FntFmly.Name = fnt.Name Then
                    Me.cmbFonts.SelectedItem = CType(itm, objFont)
                    Exit For
                End If
            Next

            For Each itm As Single In Me.cmbFontSize.Items
                If CType(itm, Integer) = CInt(fnt.Size) Then
                    Me.cmbFontSize.SelectedItem = itm
                    Exit For
                End If
            Next

        Catch ex As Exception
            Me.cmbFonts.SelectedItem = Nothing
            Me.cmbFontSize.SelectedItem = Nothing
            Me.btnBold.ForeColor = Color.Black
            Me.btnItalic.ForeColor = Color.Black
            Me.btnUnderline.ForeColor = Color.Black
        End Try
    End Sub

    Private Function CreateFont() As Font

        Dim FontStyBold As FontStyle = New FontStyle
        Dim FontStyItalic As FontStyle = New FontStyle
        Dim FontStyUndLine As FontStyle = New FontStyle

        Try

            If Me.btnBold.ForeColor = Color.Red OrElse Me.btnItalic.ForeColor = Color.Red OrElse Me.btnUnderline.ForeColor = Color.Red Then
                If Me.btnBold.ForeColor = Color.Red Then FontStyBold = FontStyle.Bold
                If Me.btnItalic.ForeColor = Color.Red Then FontStyItalic = FontStyle.Italic
                If Me.btnUnderline.ForeColor = Color.Red Then FontStyUndLine = FontStyle.Underline

                CreateFont = New Font(CType(Me.cmbFonts.SelectedItem, objFont).FntFmly, CType(Me.cmbFontSize.SelectedItem.ToString, Single), FontStyBold Or FontStyItalic Or FontStyUndLine)
            Else
                CreateFont = New Font(CType(Me.cmbFonts.SelectedItem, objFont).FntFmly, CType(Me.cmbFontSize.SelectedItem.ToString, Single), FontStyle.Regular)
            End If

        Catch ex As Exception
            FontStyItalic = FontStyle.Italic
            Me.btnItalic.ForeColor = Color.Black
            CreateFont = New Font(CType(Me.cmbFonts.SelectedItem, objFont).FntFmly, CType(Me.cmbFontSize.SelectedItem.ToString, Single), FontStyBold Or FontStyItalic Or FontStyUndLine)
        End Try

        Return CreateFont
    End Function

    Private Sub Font_TypeAndSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbFonts.SelectedIndexChanged, cmbFontSize.SelectedIndexChanged
        If Not Me.cmbFonts.SelectedItem Is Nothing AndAlso Not Me.cmbFontSize.SelectedItem Is Nothing Then Me.rtbCode.SelectionFont = CreateFont()
    End Sub

    Private Sub BoldItalicUnderline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBold.Click, btnItalic.Click, btnUnderline.Click
        If CType(sender, ToolStripButton).ForeColor = Color.Black Then
            CType(sender, ToolStripButton).ForeColor = Color.Red
            Me.rtbCode.SelectionFont = CreateFont()
        Else
            CType(sender, ToolStripButton).ForeColor = Color.Black
            Me.rtbCode.SelectionFont = CreateFont()
        End If
    End Sub

    Private Sub rtbCode_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtbCode.Click, rtbCode.SelectionChanged, cmnuPaintString.Click
        ApplyFontOptions(Me.rtbCode.SelectionFont)
    End Sub

    Private Sub btnFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFont.Click
        Me.FontDialog1.Font = Me.rtbCode.SelectionFont

        If Me.FontDialog1.ShowDialog = DialogResult.OK Then ApplyFontOptions(Me.FontDialog1.Font)

    End Sub

    Private Sub btnFontColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFontColor.Click
        Dim clrDia As ColorDialog = New ColorDialog
        clrDia.FullOpen = True

        If clrDia.ShowDialog = DialogResult.OK Then
            Me.rtbCode.SelectionColor = clrDia.Color
            Me.btnCurrentColor.ForeColor = clrDia.Color
        End If
    End Sub

    Private Sub btnCurrentColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCurrentColor.Click
        Me.rtbCode.SelectionColor = Me.btnCurrentColor.ForeColor
    End Sub
#End Region

#Region "Paint To Text"
    Private Sub FontToColor(ByVal sender As Object, ByVal e As EventArgs)

        If frmFontToColor.strArr.Count = 0 Then Exit Sub

        For Each obj As Object In frmFontToColor.strArr

            Dim Start As Integer = 0

            Do
                Me.rtbCode.Find(obj.ToString, Start, RichTextBoxFinds.None)

                'Eðer Region'un End'i ise baþýnda "#" iþareti olucaktýr. 
                'Bunu Mavi Yapmamak lazým..
                If Me.rtbCode.Text.Substring(Me.rtbCode.SelectionStart - 1, 1) <> "#" Then
                    Me.rtbCode.SelectionColor = Color.Blue
                End If

                If Me.rtbCode.SelectionStart + 1 = Start Then
                    Me.rtbCode.SelectionLength = 0
                End If

                Start = Me.rtbCode.SelectionStart + 1

            Loop While (Me.rtbCode.SelectionLength <> 0)
        Next
    End Sub

    Private Sub btnPaintToFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPaintToFont.Click
        frmFontToColor = New FontToColor
        AddHandler frmFontToColor.FontToColorForm_OK, AddressOf FontToColor

        frmFontToColor.Show()
    End Sub
#End Region

#Region "Find Proccess"
    Private FindStart As Integer

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click

        Dim frmFind As Find = New Find
        AddHandler frmFind.Find_Click, AddressOf FindProcess
        AddHandler frmFind.Reset_Click, AddressOf FindReset
        frmFind.Show()
        FindStart = 0

    End Sub

    Public Sub FindProcess(ByVal sender As Object, ByVal e As EventArgs, ByVal str As String)

        Me.rtbCode.Find(str.ToString, FindStart, RichTextBoxFinds.None)

        If Me.rtbCode.SelectionStart + 1 = FindStart Then
            Me.rtbCode.SelectionLength = 0
        End If

        FindStart = Me.rtbCode.SelectionStart + 1

    End Sub

    Public Sub FindReset(ByVal Sender As Object, ByVal e As EventArgs)
        FindStart = 0
    End Sub
#End Region

#Region "ContextMenu Events rtbCode"

    Private Sub cmnuCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuCut.Click
        Me.rtbCode.Cut()
    End Sub

    Private Sub cmnuCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuCopy.Click
        Me.rtbCode.Copy()
    End Sub

    Private Sub cmnuPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuPaste.Click
        Me.rtbCode.Paste()
    End Sub

    Private Sub cmnuSelectAllCodeText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuSelectAllCodeText.Click
       Me.rtbCode.SelectAll()
    End Sub

    Private Sub btnUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUndo.Click, cmnuUndo.Click
        Me.rtbCode.Undo()
    End Sub
#End Region


End Class
