Public Class Find

    Public Event Find_Click(ByVal sender As Object, ByVal e As EventArgs, ByVal str As String)
    Public Event Reset_Click(ByVal sender As Object, ByVal e As EventArgs)

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        RaiseEvent Find_Click(sender, e, Me.txtFindText.Text)
        Form1.Activate()
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        RaiseEvent Reset_Click(sender, e)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class