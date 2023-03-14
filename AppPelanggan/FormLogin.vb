Imports MySql.Data.MySqlClient

Public Class FormLogin
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            If Not TxtNama.Text.Length >= 5 Or Not TextPwd.Text.Length >= 5 Then
                MessageBox.Show("Username atau Password Minimal 5 huruf atau angka")
            ElseIf TxtNama.Text = "" Or TextPwd.Text = "" Then
                MessageBox.Show("Username atau Password Masih Kosong")
            Else
                Call KoneksiKeDatabase()
                cmd = New MySqlCommand("select * from tbl_user where user_name='" & TxtNama.Text & "' and pwd='" & TextPwd.Text & "'", Conn)
                RD = cmd.ExecuteReader
                RD.Read()
                If RD.HasRows = True Then
                    FormMenu.lbl_nama.Text = RD.Item("nama_lengkap")
                    FormPelanggan.txtKasir.Text = RD.Item("nama_lengkap")
                    FormMenu.lbl_level.Text = RD.Item("lvl")
                    Me.Hide()
                    FormMenu.Show()
                Else
                    MsgBox("Password atau Username Salah!!", MsgBoxStyle.Critical, "GAGAL LOGIN!!")
                End If
            End If
        Catch ex As Exception
            MsgBox("Gagal Login")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtNama.Text = ""
        TextPwd.Text = ""
    End Sub
End Class