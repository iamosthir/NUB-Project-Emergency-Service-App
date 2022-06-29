Public Class Form1
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub button_blood_form_Click(sender As Object, e As EventArgs) Handles button_blood_form.Click
        Dim blood_form As New bloodForm
        blood_form.Show()
        Me.Hide()
    End Sub

    Private Sub HospitalsAmbulanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HospitalsAmbulanceToolStripMenuItem.Click

    End Sub

    Private Sub BloodDonorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BloodDonorsToolStripMenuItem.Click
        Dim blood_form As New bloodForm
        blood_form.Show()
        Me.Hide()
    End Sub
End Class
