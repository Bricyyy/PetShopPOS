Imports MySql.Data.MySqlClient

Public Class myConnection
    Private ReadOnly connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=0102bryan;database=accountdb")

    ReadOnly Property getConnection() As MySqlConnection
        Get
            Return connection
        End Get
    End Property

    Public Sub openConnection()
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
    End Sub

    Public Sub closeConnection()
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

End Class
