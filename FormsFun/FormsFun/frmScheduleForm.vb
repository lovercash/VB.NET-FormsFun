Public Class frmScheduleForm
    Private Sub frmScheduleForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub

    Private Sub brnBackToMain_Click(sender As Object, e As EventArgs) Handles brnBackToMain.Click
        StartUpForm.Focus()
    End Sub
End Class