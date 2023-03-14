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
            Query = "Select * from relasicard where id_card='" & txtCari.Text & "'"
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
                DataGridHistory.Rows.Clear()
                DataGridHistory.Refresh()
            Else
                Call KoneksiKeDatabase()

                Query = "SELECT * FROM relasihistori WHERE id_card LIKE '%" & Trim(txtCari.Text) & "%'"
                daData = New MySqlDataAdapter(Query, Conn)
                dsData = New DataSet
                daData.Fill(dsData, "relasihistori")
                DataGridHistory.DataSource = dsData.Tables("relasihistori")

                DataGridHistory.Columns(0).Width = 110
                DataGridHistory.Columns(1).Width = 100
                DataGridHistory.Columns(2).Width = 150
                DataGridHistory.Columns(3).Width = 150
                DataGridHistory.Columns(4).Width = 80
                DataGridHistory.Columns(5).Width = 90
                DataGridHistory.Columns(6).Width = 70
                DataGridHistory.Columns(7).Width = 70
                DataGridHistory.Columns(8).Width = 70
                DataGridHistory.Columns(9).Width = 70
                DataGridHistory.Columns(10).Width = 90

                DataGridHistory.Columns(0).DataPropertyName = "nama_pelanggan"
                DataGridHistory.Columns(1).DataPropertyName = "id_kendaraan"
                DataGridHistory.Columns(2).DataPropertyName = "tgl_k_buka"
                DataGridHistory.Columns(3).DataPropertyName = "tgl_k_tutup"
                DataGridHistory.Columns(4).DataPropertyName = "nama_unit"
                DataGridHistory.Columns(5).DataPropertyName = "alamat_unit"
                DataGridHistory.Columns(6).DataPropertyName = "type_unit"
                DataGridHistory.Columns(7).DataPropertyName = "kamar"
                DataGridHistory.Columns(8).DataPropertyName = "tipe_bayar"
                DataGridHistory.Columns(9).DataPropertyName = "harga"
                DataGridHistory.Columns(10).DataPropertyName = "tgl_jatuh_tempo"

                DataGridHistory.Columns(0).HeaderText = "NAMA PELANGGAN"
                DataGridHistory.Columns(1).HeaderText = "ID KENDARAAN"
                DataGridHistory.Columns(2).HeaderText = "KELUAR"
                DataGridHistory.Columns(3).HeaderText = "MASUK"
                DataGridHistory.Columns(4).HeaderText = "NAMA UNIT"
                DataGridHistory.Columns(5).HeaderText = "ALAMAT UNIT"
                DataGridHistory.Columns(6).HeaderText = "TYPE UNIT"
                DataGridHistory.Columns(7).HeaderText = "KAMAR"
                DataGridHistory.Columns(8).HeaderText = "TIPE BAYAR"
                DataGridHistory.Columns(9).HeaderText = "HARGA"
                DataGridHistory.Columns(10).HeaderText = "TGL JATUH TEMPO"


                DataGridHistory.Columns(11).Visible = False
                DataGridHistory.Columns(12).Visible = False
                DataGridHistory.Columns(13).Visible = False
                DataGridHistory.Columns(14).Visible = False
                DataGridHistory.Columns(15).Visible = False
                DataGridHistory.Columns(16).Visible = False
                DataGridHistory.Columns(17).Visible = False
                DataGridHistory.Columns(18).Visible = False
                DataGridHistory.Columns(19).Visible = False
                DataGridHistory.Columns(20).Visible = False
                DataGridHistory.Columns(21).Visible = False
                DataGridHistory.Columns(22).Visible = False
                DataGridHistory.Columns(23).Visible = False
                DataGridHistory.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DataGridHistory.EnableHeadersVisualStyles = False
                DataGridHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue
                DataGridHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                DataGridHistory.ColumnHeadersDefaultCellStyle.Font = New Font(DataGridView.DefaultFont, FontStyle.Bold)
                DataGridHistory.DefaultCellStyle.ForeColor = Color.DarkRed
                DataGridHistory.RowsDefaultCellStyle.BackColor = Color.SkyBlue
                DataGridHistory.AlternatingRowsDefaultCellStyle.BackColor = Color.Wheat
                DataGridHistory.GridColor = Color.DarkRed
            End If
            'AturGridUnit()


        Catch ex As Exception
            MsgBox("Gagal tampil data unit")

        End Try
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Try
            DataGridHistory.DataSource.clear()
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
            Query = "Select * from relasicard where id_card='" & Trim(txtCari.Text) & "'"
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