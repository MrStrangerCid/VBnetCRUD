Public Class loginForm

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        openCon()
        Try
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM `users` WHERE `username` = @username AND `password` = @password"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@username", txtboxUname.Text)
            cmd.Parameters.AddWithValue("@password", txtboxPw.Text)
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                MessageBox.Show("Login Success!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Form1.Show()
            Else
                MsgBox("No users found")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub linkSignup_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkSignup.LinkClicked
        signupForm.Show()
        Me.Close()
    End Sub

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtboxPw.UseSystemPasswordChar = True
    End Sub

    Private Sub chkboxShowPw_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxShowPw.CheckedChanged
        txtboxPw.UseSystemPasswordChar = Not chkboxShowPw.Checked
    End Sub
End Class