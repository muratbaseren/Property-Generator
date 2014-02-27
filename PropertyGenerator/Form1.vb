#Region "imports"
Imports System.Text
#End Region

Public Class Form1

#Region "LocalVaribles"
    Private txtControl As TextBox
#End Region

#Region "ToolStrip"
    Private Sub tsbDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbDel.Click
        For Each itm As ListViewItem In Me.lsvProperty.CheckedItems
            itm.Remove()
        Next

        If Not Me.lsvProperty.Items.Count = 0 Then
            Me.tssPropertyCount.Text = Me.lsvProperty.Items.Count & " adet Property vardýr.."
        Else
            Me.tssPropertyCount.Text = ""
        End If

    End Sub

    Private Sub tsbSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSave.Click
        Dim DT As DataTable
        Dim DRow As DataRow

        If Not Me.lsvProperty.Items.Count = 0 Then
            Me.SaveFileDialog1.Filter = "XML Files(*.xml)|*.xml"

            If Me.SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                DT = New DataTable
                DT.Columns.Add("PropertyName")
                DT.Columns.Add("DataType")

                For Each itm As ListViewItem In Me.lsvProperty.Items
                    DRow = DT.NewRow()
                    DRow(0) = itm.SubItems(0).Text
                    DRow(1) = itm.SubItems(1).Text
                    DT.Rows.Add(DRow)
                Next

                Dim XmlCreator As WinCreatingXMLFileFromDataTable.CreatingXMLFile = New WinCreatingXMLFileFromDataTable.CreatingXMLFile

                XmlCreator.XMLFileWriter(DT, Me.SaveFileDialog1.FileName)
            End If
        End If

    End Sub

    Private Sub tsbOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbOpen.Click
        Dim DT As DataTable
        Dim XmlCreator As WinCreatingXMLFileFromDataTable.CreatingXMLFile

        Me.OpenFileDialog1.Filter = "XML Files(*.xml)|*.xml"

        If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            DT = New DataTable
            XmlCreator = New WinCreatingXMLFileFromDataTable.CreatingXMLFile

            DT = XmlCreator.ReadXMLFile(Me.OpenFileDialog1.FileName)

            Me.lsvProperty.Items.Clear()

            If Not DT.Rows.Count = 0 Then
                For Each Drow As DataRow In DT.Rows
                    Me.lsvProperty.Items.Add(Drow(0).ToString())
                    Me.lsvProperty.Items(Me.lsvProperty.Items.Count - 1).SubItems.Add(Drow(1).ToString())
                Next
            End If
        End If

        If Not Me.lsvProperty.Items.Count = 0 Then
            Me.tssPropertyCount.Text = Me.lsvProperty.Items.Count & " adet Property vardýr.."
        Else
            Me.tssPropertyCount.Text = ""
        End If
    End Sub

    Private Sub tsbNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNew.Click
        Me.tssPropertyCount.Text = ""
        Me.txtClass.Text = ""
        Me.txtProperty.Text = ""

        Me.lsvProperty.Items.Clear()
    End Sub

    Private Sub tsbCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCut.Click
        If Not txtControl.SelectionLength = 0 Then
            txtControl.Cut()
        End If
    End Sub

    Private Sub tsbCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCopy.Click
        If Not txtControl.SelectionLength = 0 Then
            txtControl.Copy()
        End If
    End Sub

    Private Sub tsbPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbPaste.Click
        txtControl.Paste()
    End Sub

    Private Sub tsbAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAbout.Click
        Dim frm As frmHakkinda = New frmHakkinda
        frm.ShowDialog()
    End Sub

    Private Sub tsbSaveClass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSaveClass.Click
        Me.SaveFileDialog1.Filter = "Metin Belgesi(*.txt)|*.txt|WORD Belgesi(*.doc)|*.doc|Zengin Metin Belgesi(*.rtf)|*.rft|VB Class(*.vb)|*.vb|C# Class(*.cs)|*.cs"
        Me.SaveFileDialog1.FilterIndex = 4

        If Me.SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim DllFileWriter As DLL_FileReaderWriter.WritingToTextFile = New DLL_FileReaderWriter.WritingToTextFile

            DllFileWriter.WritingCreateFile(Me.SaveFileDialog1.FileName, Me.txtClass.Text)
        End If

    End Sub
#End Region

#Region "Events"
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lsvProperty.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        Me.txtProperty.Focus()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If Trim(Me.txtProperty.Text).Length = 0 Then Exit Sub

        Dim UserProperty(1) As String

        UserProperty = Me.txtProperty.Text.Split(";")

        'Herbir dizi elemaný için..
        For i As Integer = 0 To UserProperty.Length - 1
            Dim WhiteSpace As Boolean = False
            Dim Gecici As StringBuilder = New StringBuilder
            'Eðer dizi elemaný string ifadesinin için de boþluk karakteri varsa..
            If UserProperty(i).ToString.IndexOf(" ") <> -1 Then
                'string 'in her bir karakteri için..
                For Each chr As Char In UserProperty(i).ToCharArray
                    'Eðer karakter boþluk deðilse..
                    If Char.IsWhiteSpace(chr) = False Then
                        'Eðer bu karakterden önce boþluk karakter'i okunmadýysa..
                        If Not WhiteSpace = True Then
                            'Bu karakteri yaz ve küçült..
                            Gecici.Append(Char.ToLower(chr).ToString)
                        Else
                            'Eðer bu karakterden önce boþluk okunduysa..
                            'Bu karakteri yaz ve büyüt..
                            Gecici.Append(Char.ToUpper(chr).ToString)
                            'Boþluk okunmadý olarak iþaretle, bundan sonraki karakter büyümesin diye..
                            WhiteSpace = False
                        End If
                    Else
                        'Eðer karakter boþluksa,boþluk karekterinde olduðunu iþaretle bundan sonraki karakteri büyük yapmak için..
                        WhiteSpace = True
                    End If
                Next
                UserProperty(i) = Gecici.ToString
            End If
        Next

        Me.lsvProperty.Items.Add(UserProperty(0).Substring(0, 1).ToUpper & UserProperty(0).Substring(1).ToString)
        Me.lsvProperty.Items(Me.lsvProperty.Items.Count - 1).SubItems.Add(UserProperty(1).Substring(0, 1).ToUpper & UserProperty(1).Substring(1).ToString)

        Me.tssPropertyCount.Text = Me.lsvProperty.Items.Count & " adet Property vardýr.."
    End Sub

    Private Sub lsvProperty_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvProperty.SelectedIndexChanged
        Me.txtProperty.Text = Me.lsvProperty.FocusedItem.SubItems(0).Text & ";" & Me.lsvProperty.FocusedItem.SubItems(1).Text
    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        If Me.lsvProperty.Items.Count = 0 Then Exit Sub

        Dim txt As StringBuilder = New StringBuilder
        Dim txtConstructor As StringBuilder = New StringBuilder
        Dim txtConstructor2 As StringBuilder = New StringBuilder
        Dim txtVariables As StringBuilder = New StringBuilder
        Dim txtProperties As StringBuilder = New StringBuilder
        Dim import As StringBuilder = New StringBuilder

        For Each lsvi As ListViewItem In Me.lsvProperty.Items
            If lsvi.SubItems(0).Text = "Ýmports" OrElse lsvi.SubItems(0).Text = "Imports" Then
                '===============
                'imports
                '===============
                import.Append("    Imports " & lsvi.SubItems(1).Text & vbCrLf)
            Else
                '===============
                'LocalVariables
                '===============
                txtVariables.Append("    Private " & lsvi.SubItems(0).Text & "_ As " & lsvi.SubItems(1).Text & vbCrLf)
                '===============
                'Constructor
                '===============
                txtConstructor.Append("ByVal " & lsvi.SubItems(0).Text & " As " & lsvi.SubItems(1).Text & ", ")
                txtConstructor2.Append("        Me." & lsvi.SubItems(0).Text & "_ = " & lsvi.SubItems(0).Text & vbCrLf)
                '===============
                'Properties
                '===============
                txtProperties.Append("    Public Property " & lsvi.SubItems(0).Text & "() As " & lsvi.SubItems(1).Text & vbCrLf & "        Get" & vbCrLf & "            Return Me." & lsvi.SubItems(0).Text & "_" & vbCrLf & "        End Get" & vbCrLf & "        Set(ByVal value As " & lsvi.SubItems(1).Text & ")" & vbCrLf & "            Me." & lsvi.SubItems(0).Text & "_" & " = value" & vbCrLf & "        End Set" & vbCrLf & "    End Property" & vbCrLf)
            End If
        Next

        If Not import.ToString = "" Then
            'import.AppendFormat("#Region " & Chr(34) & "Imports" & Chr(34) & vbCrLf & import.ToString & vbCrLf & "#End Region" & vbCrLf & vbCrLf)
            txt.AppendFormat(vbCrLf & "#Region " & Chr(34) & "Imports" & Chr(34) & vbCrLf & import.ToString & "#End Region" & vbCrLf & vbCrLf)
        End If

        'txtVariables = "#Region " & Chr(34) & "LocalVariables" & Chr(34) & vbCrLf & txtVariables & vbCrLf & "#End Region" & vbCrLf

        'txtProperties = "#Region " & Chr(34) & "Properties" & Chr(34) & vbCrLf & txtProperties & vbCrLf & "#End Region" & vbCrLf

        'txtConstructor = "#Region " & Chr(34) & "Constructor" & Chr(34) & vbCrLf & "    Public Sub New()" & vbCrLf & vbCrLf & "    End Sub" & vbCrLf & "    Public Sub New(" & txtConstructor & ")" & vbCrLf & vbCrLf & "    End Sub" & vbCrLf & "#End Region" & vbCrLf

        txt.AppendFormat("Public Class <ClassName>" & vbCrLf & vbCrLf & "#Region " & Chr(34) & "LocalVariables" & Chr(34) & vbCrLf & vbCrLf & txtVariables.ToString & vbCrLf & "#End Region" & vbCrLf & vbCrLf & "#Region " & Chr(34) & "Properties" & Chr(34) & vbCrLf & vbCrLf & txtProperties.ToString & vbCrLf & "#End Region" & vbCrLf & vbCrLf & "#Region " & Chr(34) & "Constructor" & Chr(34) & vbCrLf & vbCrLf & "    Public Sub New()" & vbCrLf & vbCrLf & "    End Sub" & vbCrLf & vbCrLf & "    Public Sub New(" & txtConstructor.ToString.Remove(txtConstructor.ToString.Length - 2, 2) & ")" & vbCrLf & vbCrLf & txtConstructor2.ToString & vbCrLf & "    End Sub" & vbCrLf & vbCrLf & "#End Region" & vbCrLf & vbCrLf & "End Class")

        Me.txtClass.Text = txt.ToString
    End Sub

    Private Sub txtProperty_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProperty.GotFocus
        txtControl = CType(sender, TextBox)
    End Sub

    Private Sub txtClass_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtClass.GotFocus
        txtControl = CType(sender, TextBox)
    End Sub

    Private Sub txtClass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtClass.KeyDown
        If e.Control = True AndAlso e.KeyCode = Keys.A Then
            txtClass.SelectAll()
        End If
    End Sub

    Private Sub txtProperty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtProperty.KeyDown
        If e.Control = True AndAlso e.KeyCode = Keys.A Then
            txtProperty.SelectAll()
        End If
    End Sub

#End Region

End Class
