Imports MySql.Data.MySqlClient

Public Class FormIDCard
    Dim peringatan As String
    Dim txtjatuhtempo As Date
    Dim txtBayarr As String
    Dim DateBTempoo As Date
    Dim txtjambuka As String
    Dim txtjamtutup As String
    Dim jamsekarang As String

    'Private Sub comboboxIDCard()
    '    Try
    '        Call KoneksiKeDatabase()
    '        Query = "Select * FROM tbl_lock ORDER BY id_card"
    '        cmd = New MySqlCommand(Query, Conn)
    '        RD = cmd.ExecuteReader
    '        If RD.HasRows Then
    '            Do While RD.Read
    '                CBIDCard.Items.Add(RD("id_card"))
    '            Loop
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub
    Private Sub pembayaran()
        Try
            Call KoneksiKeDatabase()
            Query = "Select * from relasicard1 where id_card='" & txtCari.Text & "'"
            cmd = New MySqlCommand(Query, Conn)
            RD = cmd.ExecuteReader
            If RD.HasRows Then
                Do While RD.Read
                    txtjatuhtempo = RD.Item("tgl_jatuh_tempo")
                    txtBayarr = RD.Item("tipe_bayar")
                    txtjambuka = RD("jam_masuk")
                    txtjamtutup = RD("jam_keluar")
                Loop
            Else

                'MsgBox("Pelanggan Belum tersedia")
            End If
        Catch ex As Exception
            MsgBox("Gagal tampil Kamar!!")
        End Try
    End Sub
    Private Sub tabelPerCard()
        Try
            If txtCari.Text = "" Then
                DataGridLock.Rows.Clear()
                DataGridLock.Refresh()
            Else
                Call KoneksiKeDatabase()

                Query = "SELECT * FROM relasihistori1 WHERE id_card LIKE '%" & Trim(txtCari.Text) & "%'"
                daData = New MySqlDataAdapter(Query, Conn)
                dsData = New DataSet
                daData.Fill(dsData, "relasihistori1")
                DataGridLock.DataSource = dsData.Tables("relasihistori1")

                DataGridLock.Columns(0).Width = 110
                DataGridLock.Columns(1).Width = 100
                DataGridLock.Columns(2).Width = 150
                DataGridLock.Columns(3).Width = 150
                DataGridLock.Columns(4).Width = 80
                DataGridLock.Columns(5).Width = 90
                DataGridLock.Columns(6).Width = 70
                DataGridLock.Columns(7).Width = 70
                DataGridLock.Columns(8).Width = 70
                DataGridLock.Columns(9).Width = 70
                DataGridLock.Columns(10).Width = 90

                DataGridLock.Columns(0).DataPropertyName = "nama_pelanggan"
                DataGridLock.Columns(1).DataPropertyName = "id_kendaraan"
                DataGridLock.Columns(2).DataPropertyName = "tgl_k_buka"
                DataGridLock.Columns(3).DataPropertyName = "tgl_k_tutup"
                DataGridLock.Columns(4).DataPropertyName = "nama_unit"
                DataGridLock.Columns(5).DataPropertyName = "alamat_unit"
                DataGridLock.Columns(6).DataPropertyName = "type_unit"
                DataGridLock.Columns(7).DataPropertyName = "kamar"
                DataGridLock.Columns(8).DataPropertyName = "tipe_bayar"
                DataGridLock.Columns(9).DataPropertyName = "harga"
                DataGridLock.Columns(10).DataPropertyName = "tgl_jatuh_tempo"

                DataGridLock.Columns(0).HeaderText = "NAMA PELANGGAN"
                DataGridLock.Columns(1).HeaderText = "ID KENDARAAN"
                DataGridLock.Columns(2).HeaderText = "KELUAR"
                DataGridLock.Columns(3).HeaderText = "MASUK"
                DataGridLock.Columns(4).HeaderText = "NAMA UNIT"
                DataGridLock.Columns(5).HeaderText = "ALAMAT UNIT"
                DataGridLock.Columns(6).HeaderText = "TYPE UNIT"
                DataGridLock.Columns(7).HeaderText = "KAMAR"
                DataGridLock.Columns(8).HeaderText = "TIPE BAYAR"
                DataGridLock.Columns(9).HeaderText = "HARGA"
                DataGridLock.Columns(10).HeaderText = "TGL JATUH TEMPO"


                DataGridLock.Columns(11).Visible = False
                DataGridLock.Columns(12).Visible = False
                DataGridLock.Columns(13).Visible = False
                DataGridLock.Columns(14).Visible = False
                DataGridLock.Columns(15).Visible = False
                DataGridLock.Columns(16).Visible = False
                DataGridLock.Columns(17).Visible = False
                DataGridLock.Columns(18).Visible = False
                DataGridLock.Columns(19).Visible = False
                DataGridLock.Columns(20).Visible = False
                DataGridLock.Columns(21).Visible = False
                DataGridLock.Columns(22).Visible = False
                DataGridLock.Columns(23).Visible = False
                DataGridLock.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DataGridLock.EnableHeadersVisualStyles = False
                DataGridLock.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue
                DataGridLock.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                DataGridLock.ColumnHeadersDefaultCellStyle.Font = New Font(DataGridView.DefaultFont, FontStyle.Bold)
                DataGridLock.DefaultCellStyle.ForeColor = Color.DarkRed
                DataGridLock.RowsDefaultCellStyle.BackColor = Color.SkyBlue
                DataGridLock.AlternatingRowsDefaultCellStyle.BackColor = Color.Wheat
                DataGridLock.GridColor = Color.DarkRed
            End If
            'AturGridUnit()


        Catch ex As Exception
            MsgBox("Gagal tampil data unit")

        End Try
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Try
            DataGridLock.DataSource.clear()
        Catch ex As Exception
            'MsgBox("tidak tampil data")
        End Try

        'tx.Items.Clear()
        'FormMenu.btnTutup.Visible = True

        Me.Close()
    End Sub
    Private Sub CBIDCard_SelectedIndexChanged(sender As Object, e As EventArgs)
        pembayaran()
        kirimhistory()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtJam.Text = DateTime.Now.ToString()
        jamsekarang = Format(Now, "HH:mm:ss")
    End Sub
    Private Sub pesanTempo()

        Try
            Call KoneksiKeDatabase()
            Query = "Select * from relasicard1 where id_card='" & Trim(txtCari.Text) & "'"
            cmd = New MySqlCommand(Query, Conn)
            RD = cmd.ExecuteReader
            If RD.HasRows Then
                Do While RD.Read
                    peringatan = RD.Item("tgl_jatuh_tempo")
                Loop
                'MsgBox("Tanggl jatuh tempo pembayaran anda: " & peringatan, MsgBoxStyle.Critical, "Pembayaran telat")
                Dim A As String
                A = MsgBox("Tanggal Jatuh Tempo anda: " & peringatan, MsgBoxStyle.OkOnly + MsgBoxStyle.Question, "Pembayaran Telat")
                Select Case A
                    Case vbOK
                        MsgBox("Silakan daftar ulang!!")
                        'CBIDCard.Items.Clear()
                        Me.Close()
                End Select
            Else

                MsgBox("Pelanggan Belum tersedia")
            End If
        Catch ex As Exception
            MsgBox("Gagal tampil Kamar!!")
        End Try
    End Sub

    Private Sub kirimhistory()
        Try
            If Not txtjatuhtempo >= Today Then
                pesanTempo()
            ElseIf txtjambuka >= jamsekarang Then 'jamsekarang 'jam buka 8 >= jam sekrang 'jam 8 kebawah gk kehitung
                'jam sekrang >= jam 23
                MsgBox("BUKA JAM: " & txtjambuka, MsgBoxStyle.Critical, "BUKA")
                'MsgBox("Belum buka") 'jam 8 ~
            ElseIf jamsekarang >= txtjamtutup Then 'jamsekarang >= txtjamtutup
                MsgBox("TUTUP JAM: " & txtjamtutup, MsgBoxStyle.Critical, "TUTUP")
                'MsgBox("Belum buka")

            Else
                Call KoneksiKeDatabase()
                Query = "INSERT INTO tbl_history values ('','" & txtCari.Text & "','lunas','" & txtJam.Text & "','" & txtJam.Text & "')"
                daData = New MySqlDataAdapter(Query, Conn)
                dsData = New DataSet
                daData.Fill(dsData)
                MsgBox("Input data berhasil")
                tabelPerCard()
            End If
        Catch ex As Exception
            MsgBox("Tidak bisa di tambah!", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DateBayar_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txttglbayar_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FormIDCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KoneksiKeDatabase()
        'CBIDCard.DropDownStyle = ComboBoxStyle.DropDownList
        'comboboxIDCard()
        Timer1.Start()
    End Sub

    Private Sub btnUnit_Click(sender As Object, e As EventArgs) Handles btnUnit.Click
        FormHistory.ShowDialog()
    End Sub


    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        If e.KeyChar = Chr(13) Then

            pembayaran()
            kirimhistory()
        End If
    End Sub
End Class