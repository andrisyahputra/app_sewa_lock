Imports MySql.Data.MySqlClient
Module Module1
    Public Conn As New MySql.Data.MySqlClient.MySqlConnection
    Public daData As New MySqlDataAdapter
    Public dsData As New DataSet
    Public Query As String
    Public cmd As New MySqlCommand
    Public RD As MySqlDataReader

    Public Sub KoneksiKeDatabase()
        Try
            Dim str As String = "Server=localhost;user id=root;database=app_pelanggan"
            Conn = New MySqlConnection(str)
            If Conn.State = ConnectionState.Closed Then
                Try
                    Conn.Open()
                Catch ex As Exception
                    MsgBox("Koneksi ke server gagal")
                End Try
            End If
        Catch ex As System.Data.SqlClient.SqlException
            'MsgBox("Koneksi ke server gagal")
        End Try

    End Sub
End Module
