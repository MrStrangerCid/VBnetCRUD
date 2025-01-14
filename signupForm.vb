Public Class signupForm
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        loginForm.Show()
        Me.Close()
    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        openCon()
        Try
            cmd.Connection = conn
            cmd.CommandText = "INSERT INTO `users` (`username`, `password`, `email`) VALUES (@username, @password, @email)"
            cmd.Parameters.Clear() 'prepare the data

            'assigning the data
            cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@password", txtPassword.Text)
            cmd.Parameters.AddWithValue("@email", txtEmail.Text)

            'sending the data to db
            cmd.ExecuteNonQuery()
            If MsgBox("User Added!", MsgBoxStyle.OkOnly) = MsgBoxResult.Ok Then
                Me.Hide()
                loginForm.Show()
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            conn.Close()
        End Try
        conn.Close() 'ALWAYS CLOSE CONNECTION AFTER DB TRANSACTIONS!!
    End Sub
End Class