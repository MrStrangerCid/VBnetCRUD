'Need to import sql data package
Imports MySql.Data.MySqlClient

'seperate database connetion for cleaner code, just call the variable
Module Database

    Public conn As New MySqlConnection 'It is used to open and close the connection to the database.
    Public cmd As New MySqlCommand 'To define and execute SQL commands
    Public dr As MySqlDataReader 'When you execute a SQL SELECT query with cmd.ExecuteReader()

    'subroutine/function for db connect, just call the function name every transaction in your program
    Sub openCon()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.ConnectionString = "server=localhost; username=root; password=; database=crud"
        conn.Open()
    End Sub
End Module
