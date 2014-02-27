Public Class LargeListView

    Public Sub LoadListView(ByVal lsv As ListView)
        Me.Text = "Large View " & lsv.Tag.ToString
        lsv.Dock = DockStyle.Fill
        Me.pnlMain.Controls.Add(lsv)
    End Sub

    Private Sub btnRefreshList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshList.Click
        'Me.pnlMain.Controls(0).Refresh()
    End Sub
End Class