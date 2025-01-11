'A simple CRUD program, provided module for cleaner sql data bindings
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTable()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Application.Exit()
    End Sub

    Sub loadTable()
        openCon()
        DataGridView1.Rows.Clear()
        Try
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM student_info"
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("fname"), dr.Item("age"), dr.Item("bday"), dr.Item("course"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conn.Close() 'ALWAYS CLOSE CONNECTION AFTER DB TRANSACTIONS!!
        End Try
    End Sub

    'To add click fuctionality to the table
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtName.Text = DataGridView1.CurrentRow.Cells(0).Value
        txtAge.Text = DataGridView1.CurrentRow.Cells(1).Value
        bday.Text = DataGridView1.CurrentRow.Cells(2).Value
        cmbProgram.Text = DataGridView1.CurrentRow.Cells(3).Value

        'disable add button on edit
        btnAdd.Enabled = False
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Clear()
        txtAge.Clear()
        cmbProgram.Text = ""
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        openCon()
        Try
            cmd.Connection = conn
            cmd.CommandText = "INSERT INTO `student_info` (`fname`, `age`, `bday`, `course`) VALUES (@fname, @age, @bday, @course)"
            cmd.Parameters.Clear() 'prepare the data

            'assigning the data
            cmd.Parameters.AddWithValue("@fname", txtName.Text)
            cmd.Parameters.AddWithValue("@age", txtAge.Text)
            cmd.Parameters.AddWithValue("@bday", bday.Value.ToString("yyyy/MM/dd"))
            cmd.Parameters.AddWithValue("@course", cmbProgram.Text)

            'sending the data to db
            cmd.ExecuteNonQuery()
            MsgBox("Student Added!")
        Catch ex As Exception
            MsgBox(ex.ToString)
            conn.Close()
        End Try
        conn.Close() 'ALWAYS CLOSE CONNECTION AFTER DB TRANSACTIONS!!
        loadTable() 'reload the table every finished db transaction

    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        openCon()
        Try
            cmd.Connection = conn
            cmd.CommandText = "UPDATE `student_info` SET `fname`=@fname, `age`=@age, `bday`=@bday, `course`=@course WHERE `fname`=@fname"
            cmd.Parameters.Clear() 'prepare the data

            'assigning the data
            cmd.Parameters.AddWithValue("@fname", txtName.Text)
            cmd.Parameters.AddWithValue("@age", txtAge.Text)
            cmd.Parameters.AddWithValue("@bday", bday.Value.ToString("yyyy/MM/dd"))
            cmd.Parameters.AddWithValue("@course", cmbProgram.Text)

            'sending the data to db
            cmd.ExecuteNonQuery()
            MsgBox("Student Updated!")
        Catch ex As Exception
            MsgBox(ex.ToString)
            conn.Close()
        End Try
        conn.Close() 'ALWAYS CLOSE CONNECTION AFTER DB TRANSACTIONS!!
        loadTable()  'reload the table every finished db transaction
    End Sub

    Private Sub btnDetele_Click(sender As Object, e As EventArgs) Handles btnDetele.Click
        If MsgBox("Are you sure you want to delete?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            openCon()
            Try
                cmd.Connection = conn
                cmd.CommandText = "DELETE FROM `student_info` WHERE `fname`=@fname"
                cmd.Parameters.Clear()

                cmd.Parameters.AddWithValue("@fname", txtName.Text)

                cmd.ExecuteNonQuery()
                MsgBox("Student Deleted!")
            Catch ex As Exception
                MsgBox(ex.ToString)
                conn.Close()
            End Try
            conn.Close() 'ALWAYS CLOSE CONNECTION AFTER DB TRANSACTIONS!!
            loadTable()  'reload the table every finished db transaction
        End If
    End Sub

    'This is for search function
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtbxSearch.TextChanged
        openCon()
        DataGridView1.Rows.Clear()
        Try
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM student_info WHERE fname like '%" & txtbxSearch.Text & "%'" 'SQL command
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("fname"), dr.Item("age"), dr.Item("bday"), dr.Item("course"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conn.Close() 'ALWAYS CLOSE CONNECTION AFTER DB TRANSACTIONS!!
        End Try
    End Sub
End Class
