Imports MySql.Data.MySqlClient

Module UniversalVariables
    Public conn As New MySqlConnection
    Public ds As New DataSet
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public sql As String

    Public conn1 As New MySqlConnection
    Public ds1 As New DataSet
    Public cmd1 As New MySqlCommand
    Public dr1 As MySqlDataReader
    Public sql1 As String

    Public conn2 As New MySqlConnection
    Public ds2 As New DataSet
    Public cmd2 As New MySqlCommand
    Public dr2 As MySqlDataReader
    Public sql2 As String

    Public Sub connect()
        cmd.CommandText = sql
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        conn.Open()
        dr = cmd.ExecuteReader
    End Sub

    Public Sub connectAlt()
        cmd1.CommandText = sql1
        cmd1.CommandType = CommandType.Text
        cmd1.Connection = conn1
        conn1.Open()
        dr1 = cmd1.ExecuteReader
    End Sub

    Public Sub connectAgain()
        cmd2.CommandText = sql2
        cmd2.CommandType = CommandType.Text
        cmd2.Connection = conn2
        conn2.Open()
        dr2 = cmd2.ExecuteReader
    End Sub

End Module
