﻿Imports MySql.Data.MySqlClient
Public Class FormHistory
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
    Private Sub tabelPerCard()
        Try
            Call KoneksiKeDatabase()

            Query = "SELECT * FROM relasicard1 WHERE id_card LIKE '%" & txtCari.Text & "%'"
                daData = New MySqlDataAdapter(Query, Conn)
                dsData = New DataSet
                daData.Fill(dsData, "relasicard1")
                DataGridHistory.DataSource = dsData.Tables("relasicard1")

                'DataGridHistory.Columns(0).Width = 110
                'DataGridHistory.Columns(1).Width = 100
                'DataGridHistory.Columns(2).Width = 150
                'DataGridHistory.Columns(3).Width = 150
                'DataGridHistory.Columns(4).Width = 80
                'DataGridHistory.Columns(5).Width = 90
                'DataGridHistory.Columns(6).Width = 70
                'DataGridHistory.Columns(7).Width = 70
                'DataGridHistory.Columns(8).Width = 70
                'DataGridHistory.Columns(9).Width = 70
                'DataGridHistory.Columns(10).Width = 90

                'DataGridHistory.Columns(0).DataPropertyName = "nama_pelanggan"
                'DataGridHistory.Columns(1).DataPropertyName = "id_kendaraan"
                'DataGridHistory.Columns(2).DataPropertyName = "tgl_k_buka"
                'DataGridHistory.Columns(3).DataPropertyName = "tgl_k_tutup"
                'DataGridHistory.Columns(4).DataPropertyName = "nama_unit"
                'DataGridHistory.Columns(5).DataPropertyName = "alamat_unit"
                'DataGridHistory.Columns(6).DataPropertyName = "type_unit"
                'DataGridHistory.Columns(7).DataPropertyName = "kamar"
                'DataGridHistory.Columns(8).DataPropertyName = "tipe_bayar"
                'DataGridHistory.Columns(9).DataPropertyName = "harga"
                'DataGridHistory.Columns(10).DataPropertyName = "tgl_jatuh_tempo"

                'DataGridHistory.Columns(0).HeaderText = "NAMA PELANGGAN"
                'DataGridHistory.Columns(1).HeaderText = "ID KENDARAAN"
                'DataGridHistory.Columns(2).HeaderText = "KELUAR"
                'DataGridHistory.Columns(3).HeaderText = "MASUK"
                'DataGridHistory.Columns(4).HeaderText = "NAMA UNIT"
                'DataGridHistory.Columns(5).HeaderText = "ALAMAT UNIT"
                'DataGridHistory.Columns(6).HeaderText = "TYPE UNIT"
                'DataGridHistory.Columns(7).HeaderText = "KAMAR"
                'DataGridHistory.Columns(8).HeaderText = "TIPE BAYAR"
                'DataGridHistory.Columns(9).HeaderText = "HARGA"
                'DataGridHistory.Columns(10).HeaderText = "TGL JATUH TEMPO"


                'DataGridHistory.Columns(11).Visible = False

                DataGridHistory.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DataGridHistory.EnableHeadersVisualStyles = False
                DataGridHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue
                DataGridHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                DataGridHistory.ColumnHeadersDefaultCellStyle.Font = New Font(DataGridView.DefaultFont, FontStyle.Bold)
                DataGridHistory.DefaultCellStyle.ForeColor = Color.DarkRed
                DataGridHistory.RowsDefaultCellStyle.BackColor = Color.SkyBlue
                DataGridHistory.AlternatingRowsDefaultCellStyle.BackColor = Color.Wheat
            DataGridHistory.GridColor = Color.DarkRed
            'AturGridUnit()


        Catch ex As Exception
            MsgBox("Gagal tampil data unit")

        End Try
    End Sub

    Public Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Try
            DataGridHistory.DataSource.clear()
        Catch ex As Exception
            'MsgBox("tidak tampil data")
        End Try
        'FormMenu.PanelAkses.Visible = True
        Call FormMenu.tampilMenu()
        FormMenu.FormMenu_Load(sender, e)
        Call FormMenu.tampilMenu()
        Me.Close()
    End Sub

    Public Sub FormHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KoneksiKeDatabase()
        'comboboxIDCard()
        'CBIDCard.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub CBIDCard_SelectedIndexChanged(sender As Object, e As EventArgs)
        tabelPerCard()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged

    End Sub

    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        If e.KeyChar = Chr(13) Then
            Call KoneksiKeDatabase()
            Query = "Select * from relasicard1 where id_card='" & txtCari.Text & "'"
            cmd = New MySqlCommand(Query, Conn)
            RD = cmd.ExecuteReader
            If RD.HasRows = True Then
                tabelPerCard()
            Else
                txtCari.Text = ""
                txtCari.Focus()
                MessageBox.Show("ID CARD PELANGGAN TIDAK DITEMUKAN!!!")
            End If
        End If
    End Sub
End Class