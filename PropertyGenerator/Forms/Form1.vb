#Region "imports"
Imports System.Text
#End Region

Public Class Form1

    Private Sub CreatePage()
        Dim DocName As String = InputBox("Document Ýsmi Giriniz :", "Document Name")

        If Not DocName.Trim.Length = 0 Then
            Dim cls As ClassControl = New ClassControl
            cls.Dock = DockStyle.Fill

            Dim pnl As Panel = New Panel
            pnl.Dock = DockStyle.Fill
            pnl.Controls.Add(cls)

            Dim tp As TabPage = New TabPage
            tp.Text = DocName
            tp.Name = "tp_" & DocName
            tp.Controls.Add(pnl)

            Me.tbcDocuments.TabPages.Add(tp)
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        CreatePage()
    End Sub

    Private Sub btnCloseTab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseTab.Click
        If MessageBox.Show(Chr(34) & Me.tbcDocuments.SelectedTab.Text & Chr(34) & " adlý sekme kapatýlsýn mý?", "Sekme Kapat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Me.tbcDocuments.TabPages.Remove(Me.tbcDocuments.SelectedTab)
        End If
    End Sub
End Class
