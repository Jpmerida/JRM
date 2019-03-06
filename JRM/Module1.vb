Imports MySql.Data.MySqlClient


Module Module1
    Public connectionString As String
    Public mysql As String
    Public connection As MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public conn As MySqlConnection = New MySqlConnection

    Public Sub conndb()
        conn.ConnectionString = ("Server = localhost; uid = root; pwd = admin; database = jrm")
        conn.Open()

    End Sub
End Module
