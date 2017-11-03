Public Class Form1
    Private Sub btnNewForm_Click(sender As Object, e As EventArgs) Handles btnNewForm.Click
        Dim new_form As New frmNewUserForm
        new_form = New frmNewUserForm
        new_form.Show()
    End Sub

    Private Sub btnSecondForm_Click(sender As Object, e As EventArgs) Handles btnSecondForm.Click
        Dim new_form As New frmSecondForm
        new_form = New frmSecondForm
        new_form.Show()
    End Sub

    ''---------------------------------------------------''
    '' This allows the form to only be opened 1 time''
    ''---------------------------------------------------''

    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click
        NewForm.Show()
        NewForm.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NewForm = New frmScheduleForm
        StartUpForm = Me 'Initialized the StartUpForm from the modGlobalStuff
    End Sub
End Class
