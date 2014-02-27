Public Class FontToColor

    Public Event FontToColorForm_OK(ByVal sender As Object, ByVal e As EventArgs)

    Private strArr_ As ArrayList

    Public Property strArr() As ArrayList
        Get
            Return Me.strArr_
        End Get
        Set(ByVal value As ArrayList)
            Me.strArr_ = value
        End Set
    End Property

#Region "Methods"
    Public Sub XmlRead()
        Me.clbStrList.Items.Clear()

        Dim dt As DataTable = New DataTable
        Dim xml As DLL_FileReaderWriter.XML = New DLL_FileReaderWriter.XML
        dt = xml.ReadXMLFile(Application.StartupPath & "\" & "xml_FontToColor.xml")

        For Each dr As DataRow In dt.Rows
            Me.clbStrList.Items.Add(dr(0).ToString)
        Next
    End Sub

    Public Sub XmlWrite()
        Dim dt As DataTable = New DataTable
        dt.Columns.Add("Fonts")
        Dim xml As DLL_FileReaderWriter.XML = New DLL_FileReaderWriter.XML

        Dim dr As DataRow

        For Each itm As Object In Me.clbStrList.Items
            dr = dt.NewRow
            dr(0) = itm.ToString
            dt.Rows.Add(dr)
        Next

        xml.XMLFileWriter(dt, Application.StartupPath & "\" & "xml_FontToColor.xml")
    End Sub
#End Region

    '
    'Add Items
    '
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        If Not Me.txtItem.Text.Trim.Length = 0 Then
            Me.clbStrList.Items.Add(Me.txtItem.Text.Trim)
            XmlWrite()
        Else
            MessageBox.Show("Bir String Giriniz..!", "String Yok !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Me.txtItem.Focus()
        End If
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Dim Changed As Boolean = False

        For i As Integer = Me.clbStrList.Items.Count - 1 To 0 Step -1
            If Me.clbStrList.GetItemCheckState(i) = CheckState.Checked Then
                Me.clbStrList.Items.RemoveAt(i)
                Changed = True
            End If
        Next

        If Changed = True Then XmlWrite()
    End Sub

    '
    'Form Load
    '
    Private Sub FontToColor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        XmlRead()
    End Sub

    '
    'Select Items
    '
    Private Sub btnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectAll.Click
        For i As Integer = 0 To Me.clbStrList.Items.Count - 1
            Me.clbStrList.SetItemChecked(i, True)
        Next
    End Sub

    Private Sub btnUnselectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnselectAll.Click
        For i As Integer = 0 To Me.clbStrList.Items.Count - 1
            Me.clbStrList.SetItemChecked(i, False)
        Next
    End Sub


    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If Not Me.clbStrList.CheckedItems.Count = 0 Then
            Me.strArr_ = New ArrayList

            For Each itm As Object In Me.clbStrList.CheckedItems
                Me.strArr_.Add(itm.ToString)
            Next

            RaiseEvent FontToColorForm_OK(sender, e)
        End If

        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class