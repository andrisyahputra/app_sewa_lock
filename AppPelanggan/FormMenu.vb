

Imports MySql.Data.MySqlClient

Public Class FormMenu

    Dim imgsetlock As Bitmap
    Dim imgdtunit As Bitmap
    Dim imghistory As Bitmap
    Dim peringatan As String
    Dim txtjatuhtempo As Date
    Dim txtBayarr As String
    Dim DateBTempoo As Date
    Dim txtjambuka As String
    Dim txtjamtutup As String
    Dim jamsekarang As String

    'per akses
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

    'tutup akses

    Public Sub clearMenu()
        btnTutup.Visible = False
        txtCari.Visible = False
        txtJam.Visible = False
        Label3.Visible = False
        DataGridLock.Visible = False
        Label11.Visible = False
        Label4.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        lblTutup.Visible = False
    End Sub
    Public Sub tampilMenu()
        btnTutup.Visible = True
        txtCari.Visible = True
        txtJam.Visible = True
        Label3.Visible = True
        DataGridLock.Visible = True
        Label11.Visible = True
        Label4.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        lblTutup.Visible = True

    End Sub


    Private Sub btnUser_Click(sender As Object, e As EventArgs)
        FormTambahUser.ShowDialog()
    End Sub
    Sub switchPanel(ByVal panel As Form)
        PanelMenu.Controls.Clear()
        'btnTutup.Visible = False
        panel.TopLevel = False
        PanelMenu.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btnPelanggan_Click(sender As Object, e As EventArgs) Handles btnPelanggan.Click
        'PanelAkses.Visible = False
        clearMenu()
        'FormPelanggan.FormPelanggan_Load(sender, e)
        switchPanel(FormPelanggan)
    End Sub
    Private Sub btnUnit_Click(sender As Object, e As EventArgs) Handles btnUnit.Click
        'PanelAkses.Visible = False
        'FormUnit.ShowDialog()
        clearMenu()
        FormUnit.FormUnit_Load(sender, e)
        switchPanel(FormUnit)

    End Sub

    Private Sub btnJamLock_Click(sender As Object, e As EventArgs) Handles btnJamLock.Click
        'PanelAkses.Visible = False
        'FormUnit.ShowDialog()
        FormHistory.FormHistory_Load(sender, e)
        FormHistory.btnTutup_Click(sender, e)
        clearMenu()
        switchPanel(FormHistory)
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub KondisiAwal()


        imgsetlock = AppPelanggan.My.Resources.Resources.setlock
        imgdtunit = AppPelanggan.My.Resources.Resources.unit
        imghistory = AppPelanggan.My.Resources.Resources.history

        btnJamLock.Image = imgsetlock
        btnJamLock.ImageAlign = ContentAlignment.MiddleLeft
        btnUnit.Image = imgdtunit
        btnUnit.ImageAlign = ContentAlignment.MiddleLeft
    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs)
        FormLaporPerbulan.ShowDialog()
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs)
        FormIDCard.ShowDialog()
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblTutup.Click
        Me.Close()
        FormLogin.Show()
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
    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        If e.KeyChar = Chr(13) Then

            pembayaran()
            kirimhistory()
        End If
    End Sub

    Public Sub FormMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtCari.Text = ""
        Try
            DataGridLock.DataSource.clear()
        Catch ex As Exception

        End Try
        KoneksiKeDatabase()
        Timer1.Start()
    End Sub
End Class