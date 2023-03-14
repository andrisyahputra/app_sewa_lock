Imports MySql.Data.MySqlClient
Public Class FormPelanggan
    Dim ImgInput As Bitmap
    Dim ImgEdit As Bitmap
    Dim ImgHapus As Bitmap
    Dim ImgClear As Bitmap
    Dim ImgTutup As Bitmap
    Dim imgBatal As Bitmap
    Dim imgSimpan As Bitmap
    Dim imgUpdate As Bitmap


    Dim user As String
    Dim idNilai As String
    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtTanggal.Text = Format(Now, "MM/dd/yyyy")
        txtJam.Text = Format(Now, "HH:mm:ss")
    End Sub
    Private Sub PosisiList()
        With lvpelanggan.Columns
            .Add("ID PELANGGAN", 0)
            .Add("NAMA PELANGGAN", 130)
            .Add("ID UNIT", 0)
            .Add("NAMA UNIT", 80)
            .Add("ID KAMAR", 0)
            .Add("NAMA KAMAR", 100)
            .Add("ID KENDARAAN", 100)
            .Add("TGL KENDARAAN", 110)
            .Add("TGL BAYAR", 100)
            .Add("TGL JATUH TEMPO", 120)
            .Add("PEMBAYARAN", 100)
            .Add("HARGA", 60)
            .Add("KASIR", 100)
        End With
        lvpelanggan.BackColor = Color.LightSeaGreen

    End Sub
    Private Sub KosongkanData()
        txtId.Text = ""
        txtNama.Text = ""
        CBIDUnit.Text = ""
        CBIDKamar.Text = ""
        txtKamar.Text = ""
        txtUnit.Text = ""
        txtKendaraa.Text = ""
        DateKendaraan.Value = Today
        CBBayar.Text = ""
        txtHarga.Text = ""
        DateBayar.Value = Today
        DateJTempo.Value = Today
        txtPembayaran.Text = "0"
    End Sub
    Private Sub FieldAktif()
        txtNama.Enabled = True
        CBIDUnit.Enabled = True
        CBIDKamar.Enabled = True
        txtKendaraa.Enabled = True
        DateKendaraan.Enabled = True
        CBBayar.Enabled = True
        DateBayar.Enabled = True
    End Sub
    Private Sub KondisiAwal()
        Dim a As Integer
        Try



            txtId.Text = ""
            txtNama.Text = ""
            CBIDUnit.Text = ""
            CBIDKamar.Text = ""
            txtKamar.Text = ""
            txtUnit.Text = ""
            txtKendaraa.Text = ""
            DateKendaraan.Value = Today
            CBBayar.Text = ""
            txtHarga.Text = ""
            DateBayar.Value = Today
            DateJTempo.Value = Today
            txtPembayaran.Text = "0"

            txtId.Enabled = False
            CBIDUnit.Enabled = False
            CBIDKamar.Enabled = False
            txtKamar.Enabled = False
            txtUnit.Enabled = False
            txtNama.Enabled = False
            CBIDKamar.Enabled = False
            txtKendaraa.Enabled = False
            DateKendaraan.Enabled = False
            CBBayar.Enabled = False
            txtHarga.Enabled = False
            DateBayar.Enabled = False
            DateJTempo.Enabled = False
            txtTanggal.Enabled = False
            txtKasir.Enabled = False
            txtJam.Enabled = False
            txtHarga.MaxLength = 20

            ImgInput = AppPelanggan.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_7_Save_256
            ImgEdit = AppPelanggan.My.Resources.Resources.update
            ImgHapus = AppPelanggan.My.Resources.Resources.sampah
            ImgClear = AppPelanggan.My.Resources.Resources.clear
            imgBatal = AppPelanggan.My.Resources.Resources.batal
            imgSimpan = AppPelanggan.My.Resources.Resources.simpan
            imgUpdate = AppPelanggan.My.Resources.Resources.edit

            BtnTambah.Text = "INPUT"
            BtnTambah.Image = ImgInput
            BtnEdit.Text = "EDIT"
            BtnEdit.Image = ImgEdit
            btnHapus.Text = "HAPUS"
            btnHapus.Image = ImgHapus
            btnLapor.Image = AppPelanggan.My.Resources.Resources.lapor

            BtnTambah.Enabled = True
            btnHapus.Enabled = False
            BtnEdit.Enabled = False

            KoneksiKeDatabase()
            Query = "Select * FROM relasipelanggan ORDER BY id_pelanggan"
            daData = New MySqlDataAdapter(Query, Conn)
            dsData = New DataSet
            daData.Fill(dsData)
            lvpelanggan.Items.Clear()
            For a = 0 To dsData.Tables(0).Rows.Count - 1
                With lvpelanggan
                    .Items.Add(dsData.Tables(0).Rows(a).Item(0))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(1))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(2))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(6))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(5))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(7))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(11))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(12))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(13))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(14))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(16))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(15))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(17))
                End With


            Next
            'MsgBox("database berhasil di tampil")
        Catch ex As Exception
            MsgBox("database gagal di tampil")
        End Try
    End Sub
    Private Sub no_user()
        Try
            cmd = New MySqlCommand("select * from tbl_pelanggan where id_pelanggan in(select max(id_pelanggan) from tbl_pelanggan) order by id_pelanggan DESC", Conn)
            RD = cmd.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                txtId.Text = "P" + "001"
            Else
                txtId.Text = Val(Microsoft.VisualBasic.Mid(RD.Item("id_pelanggan").ToString, 2, 3)) + 1
                If Len(txtId.Text) = 1 Then
                    txtId.Text = "P00" & txtId.Text & ""
                ElseIf Len(txtId.Text) = 2 Then
                    txtId.Text = "P0" & txtId.Text & ""
                ElseIf Len(txtId.Text) = 3 Then
                    txtId.Text = "P" & txtId.Text & ""
                End If
            End If
            user = txtId.Text
        Catch ex As Exception
            'MsgBox("Gagal")
        End Try

    End Sub
    Private Sub comboBoxIDUnit()
        Try
            Call KoneksiKeDatabase()
            Query = "Select * FROM tbl_unit ORDER BY id_unit"
            cmd = New MySqlCommand(Query, Conn)
            RD = cmd.ExecuteReader
            If RD.HasRows Then
                Do While RD.Read
                    CBIDUnit.Items.Add(RD("id_unit"))
                Loop

            End If
        Catch ex As Exception
            MsgBox("Gagal tampil Unit")
        End Try
    End Sub
    Private Sub comboBoxIDKamar()
        Try
            Call KoneksiKeDatabase()
            Query = "Select * from tbl_kamar where id_unit='" & CBIDUnit.Text & "'"
            cmd = New MySqlCommand(Query, Conn)
            RD = cmd.ExecuteReader
            If RD.HasRows Then
                Do While RD.Read
                    CBIDKamar.Items.Add(RD("id_kamar"))
                Loop
            End If
        Catch ex As Exception
            MsgBox("Gagal tampil Kamar!!")
        End Try
    End Sub
    Private Sub biayaPer()
        Try
            Call KoneksiKeDatabase()
            Query = "Select * from tbl_kamar where id_unit='" & CBIDUnit.Text & "'and kamar='" & txtKamar.Text & "'"
            cmd = New MySqlCommand(Query, Conn)
            RD = cmd.ExecuteReader
            If RD.HasRows Then
                Do While RD.Read
                    If CBBayar.Text = "Perbulan" Then
                        txtHarga.Text = RD.Item("harga_bulanan")
                        txtPembayaran.Text = RD.Item("harga_bulanan")
                    Else
                        txtHarga.Text = RD.Item("harga_tahunan")
                        txtPembayaran.Text = RD.Item("harga_tahunan")
                    End If
                    'txtHarga.Text = RD("harga")
                    'txtPembayaran.Text = RD("harga")
                Loop
            Else

                MsgBox("Kamar Belum tersedia")
            End If
        Catch ex As Exception
            MsgBox("Gagal tampil Kamar!!")
        End Try
    End Sub

    Private Sub FormPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBIDKamar.DropDownStyle = ComboBoxStyle.DropDownList
        CBIDUnit.DropDownStyle = ComboBoxStyle.DropDownList
        CBBayar.DropDownStyle = ComboBoxStyle.DropDownList
        CBBayar.Items.Add("Perbulan")
        CBBayar.Items.Add("Pertahun")



        comboBoxIDUnit()
        KoneksiKeDatabase()
        KondisiAwal()
        PosisiList()

    End Sub
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Try

            If BtnTambah.Text = "CLEAR" Then
                CBIDUnit.Enabled = True
                txtNama.Text = ""
                CBIDUnit.Text = ""
                CBIDKamar.Text = ""
                txtKamar.Text = ""
                txtUnit.Text = ""
                txtKendaraa.Text = ""
                DateKendaraan.Value = Today
                CBBayar.Text = ""
                txtHarga.Text = ""
                txtPembayaran.Text = "0"
                DateBayar.Value = Today
                DateJTempo.Value = Today
                txtNama.Focus()
                CBIDKamar.Items.Clear()
                Exit Sub
            End If

            If BtnTambah.Text = "INPUT" Then
                BtnTambah.Image = imgSimpan
                BtnTambah.Text = "SIMPAN"
                If txtId.Text = "" Then
                    Call no_user()
                Else
                    txtId.Text = user
                End If
                BtnEdit.Text = "CLEAR"
                BtnEdit.Image = ImgClear
                btnHapus.Text = "BATAL"
                btnHapus.Image = imgBatal
                BtnEdit.Enabled = True
                btnHapus.Enabled = True
                Call FieldAktif()
                txtId.Enabled = False
                btnLapor.Enabled = False
                lvpelanggan.Enabled = False
                txtNama.Focus()
            Else
                If txtId.Text = "" Then
                    MsgBox("Silahkan isi ID")
                ElseIf txtNama.Text = "" Or
                txtKendaraa.Text = "" Then
                    MsgBox("Silahkan ISI Nama dan ID Kendaraan")
                ElseIf CBIDUnit.Text = "" Then
                    MsgBox("Silahkan isi UNIT di FORM UNIT")
                ElseIf CBIDKamar.Text = "" Then
                    MsgBox("Silahkan isi KAMAR di FORM KAMAR")
                ElseIf txtId.Text = "" Or
                    txtId.Text = "" Or
                    txtNama.Text = "" Or
                    txtKamar.Text = "" Or
                    txtUnit.Text = "" Or
                                        CBBayar.Text = "" Or
                    txtHarga.Text = "" Or
                    txtKendaraa.Text = "" Then
                    MsgBox("Silahkan Isi Semua Data")
                ElseIf Not DateKendaraan.Text >= Today Then
                    MsgBox("Tanggal kendraan kesalahan!!!")
                ElseIf Not DateBayar.Text >= Today Then
                    MsgBox("Tanggal bayar kesalahan!!!")
                ElseIf Not DateJTempo.Text >= DateBayar.Text Then
                    MsgBox("Tanggal jtempo kelewatan")
                ElseIf Not txtHarga.Text.Length >= 6 Then
                    MsgBox("Kamar tidak tersedia")
                Else
                    Call KoneksiKeDatabase()
                    cmd = New MySqlCommand("SELECT * FROM tbl_pelanggan where nama_pelanggan='" & txtNama.Text & "' OR id_kendaraan='" & txtKendaraa.Text & "'", Conn)
                    RD = cmd.ExecuteReader
                    RD.Read()
                    If RD.HasRows = True Then
                        MsgBox("Nama dan Kendaran sudah ada terisi", MsgBoxStyle.Critical, "Data duplikat")

                    Else
                        Call KoneksiKeDatabase()
                        cmd = New MySqlCommand("SELECT * FROM tbl_kamar where sts='penuh'", Conn)
                        RD = cmd.ExecuteReader
                        RD.Read()
                        If RD.HasRows = True Then
                            MsgBox("Kamar Sudah ada pelanggan", MsgBoxStyle.Critical, "Data duplikat")

                        Else

                            Call KoneksiKeDatabase()
                            Query = "INSERT INTO tbl_pelanggan values ('" & txtId.Text & "','" & txtNama.Text & "','" & CBIDUnit.Text & "','" & CBIDKamar.Text & "','" & txtKendaraa.Text & "','" & Format(DateKendaraan.Value, "yyyy-MM-dd") & "','" & Format(DateBayar.Value, "yyyy-MM-dd") & "','" & Format(DateJTempo.Value, "yyyy-MM-dd") & "','" & txtHarga.Text & "','" & CBBayar.Text & "','" & txtKasir.Text & "','-')"
                            daData = New MySqlDataAdapter(Query, Conn)
                            dsData = New DataSet
                            daData.Fill(dsData)

                            Dim penuh As String = "UPDATE tbl_kamar SET sts='penuh' where id_kamar='" & CBIDKamar.Text & "'"
                            daData = New MySqlDataAdapter(penuh, Conn)
                            dsData = New DataSet
                            daData.Fill(dsData)
                            Dim A As String
                            A = MsgBox("Silahkan tambah id card...?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "Daftar Sukses")
                            Select Case A
                                Case vbCancel
                                    MsgBox("Input data berhasil")
                                    lvpelanggan.Clear()
                                    CBIDKamar.Items.Clear()
                                    CBIDUnit.Items.Clear()
                                    CBBayar.Items.Clear()
                                    FormPelanggan_Load(sender, e)
                                    lvpelanggan.Enabled = True
                                    btnLapor.Enabled = True
                                    Call KosongkanData()
                                    'MsgBox("Data pelanggan Tidak hapus", MsgBoxStyle.OkOnly, "Hapus Data")
                                    Exit Sub
                                Case vbOK
                                    'MsgBox("Input data berhasil")
                                    'lvpelanggan.Clear()
                                    '    CBIDKamar.Items.Clear()
                                    '    CBIDUnit.Items.Clear()
                                    '    CBBayar.Items.Clear()
                                    '    FormPelanggan_Load(sender, e)
                                    '    lvpelanggan.Enabled = True
                                    '    btnLapor.Enabled = True
                                    '    Call KosongkanData()
                                    'MsgBox("Data pelanggan Berhasil Di hapus", MsgBoxStyle.OkOnly, "Hapus Data")
                                    FormIDCard.ShowDialog()
                            End Select

                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Tidak berhasil tambah data")
        End Try
    End Sub
    Private Sub CBIDUnit_SelectedValueChanged(sender As Object, e As EventArgs) Handles CBIDUnit.SelectedValueChanged
        Try
            Call KoneksiKeDatabase()
            cmd = New MySqlCommand("select * from tbl_unit where id_unit='" & CBIDUnit.Text & "'", Conn)
            RD = cmd.ExecuteReader
            RD.Read()
            If RD.HasRows = True Then
                txtUnit.Text = RD.Item("nama_unit")
            End If
            CBIDUnit.Enabled = False
        Catch ex As Exception

        End Try
    End Sub
    Private Sub CBIDKamar_SelectedValueChanged(sender As Object, e As EventArgs) Handles CBIDKamar.SelectedValueChanged
        Try

            Call KoneksiKeDatabase()
            cmd = New MySqlCommand("select * from tbl_kamar where id_kamar='" & CBIDKamar.Text & "'", Conn)
            RD = cmd.ExecuteReader
            RD.Read()
            If RD.HasRows = True Then
                txtKamar.Text = RD.Item("kamar")
            End If
            CBBayar.Text = ""
            txtHarga.Text = "0"
            txtPembayaran.Text = "0"


        Catch ex As Exception

        End Try
    End Sub
    Private Sub DateBayar_ValueChanged(sender As Object, e As EventArgs) Handles DateBayar.ValueChanged
        Dim kondisiBayar As Integer
        If CBBayar.Text = "Perbulan" Then
            kondisiBayar = 1
        Else
            kondisiBayar = 12
        End If
        Dim tglbayar_v As Date = Date.Parse(DateBayar.Value)
        DateJTempo.Value = DateAdd(DateInterval.Month, kondisiBayar, tglbayar_v)
    End Sub
    Private Sub CBBayar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBBayar.SelectedIndexChanged
        Dim kondisiBayar As Integer
        If CBBayar.Text = "Perbulan" Then
            kondisiBayar = 1
        Else
            kondisiBayar = 12
        End If
        Dim tglbayar_v As Date = Date.Parse(DateBayar.Value)
        DateJTempo.Value = DateAdd(DateInterval.Month, kondisiBayar, tglbayar_v)
        biayaPer()

    End Sub
    Private Sub txtUnit_TextChanged(sender As Object, e As EventArgs) Handles txtUnit.TextChanged
        comboBoxIDKamar()
    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Try
            If BtnEdit.Text = "BATAL" Then
                BtnEdit.Location = New Point(1179, 412)
                BtnTambah.Location = New Point(1086, 412)
                CBIDKamar.Items.Clear()
                CBIDUnit.Items.Clear()
                CBBayar.Items.Clear()
                lvpelanggan.Clear()
                FormPelanggan_Load(sender, e)
                lvpelanggan.Enabled = True
                btnLapor.Enabled = True
                Call KosongkanData()
                Exit Sub
            End If

            If BtnEdit.Text = "CLEAR" Then
                CBIDUnit.Enabled = True
                txtNama.Text = ""
                CBIDUnit.Text = ""
                CBIDKamar.Text = ""
                txtKamar.Text = ""
                txtUnit.Text = ""
                txtKendaraa.Text = ""
                DateKendaraan.Value = Today
                CBBayar.Text = ""
                txtHarga.Text = ""
                txtPembayaran.Text = "0"
                DateBayar.Value = Today
                DateJTempo.Value = Today
                txtNama.Focus()
                CBIDKamar.Items.Clear()
                Exit Sub
            End If

            If BtnEdit.Text = "EDIT" Then
                BtnEdit.Image = imgUpdate
                BtnEdit.Text = "UPDATE"
                btnHapus.Enabled = True
                BtnTambah.Enabled = True
                btnHapus.Text = "BATAL"
                btnHapus.Image = imgBatal
                BtnTambah.Text = "CLEAR"
                BtnTambah.Image = ImgClear
                btnLapor.Enabled = False
                FieldAktif()
                BtnTambah.Location = New Point(1179, 412)
                BtnEdit.Location = New Point(1086, 412)
                'txtId.Enabled = False
                'txtNKamar.Enabled = True
                'txtNUnit.Enabled = False
                'txtHarga.Enabled = True
                'CBTHarga.Enabled = True
                'CBIDUnit.Enabled = True
            Else
                If txtId.Text = "" Then
                    MsgBox("Silahkan isi ID")
                ElseIf Not txtHarga.Text.Length >= 6 Then
                    MsgBox("Minimal Ratusan")
                ElseIf txtId.Text = "" Or
                    txtId.Text = "" Or
                    txtNama.Text = "" Or
                    CBIDUnit.Text = "" Or
                    CBIDKamar.Text = "" Or
                    txtKamar.Text = "" Or
                    txtUnit.Text = "" Or
                    CBBayar.Text = "" Or
                    txtHarga.Text = "0" Or
                    txtKendaraa.Text = "" Then
                    MsgBox("Silahkan Isi Semua Data")
                ElseIf Not DateKendaraan.Text >= Today Then
                    MsgBox("Tanggal kendraan kesalahan!!!")
                ElseIf Not DateBayar.Text >= Today Then
                    MsgBox("Tanggal bayar kesalahan!!!")
                ElseIf Not DateJTempo.Text >= DateBayar.Text Then
                    MsgBox("Tanggal jtempo kelewatan")
                Else

                    Call KoneksiKeDatabase()
                    Query = "UPDATE tbl_pelanggan SET nama_pelanggan='" & txtNama.Text & "',id_unit='" & CBIDUnit.Text & "',id_kamar='" & CBIDKamar.Text & "',id_kendaraan='" & txtKendaraa.Text & "',tgl_kendaraan='" & Format(DateKendaraan.Value, "yyyy-MM-dd") & "',tgl_bayar='" & Format(DateBayar.Value, "yyyy-MM-dd") & "',tgl_jatuh_tempo='" & Format(DateJTempo.Value, "yyyy-MM-dd") & "',harga='" & txtHarga.Text & "',tipe_bayar='" & CBBayar.Text & "',kasir='" & txtKasir.Text & "',c='-'where id_pelanggan='" & txtId.Text & "'"
                    daData = New MySqlDataAdapter(Query, Conn)
                    dsData = New DataSet
                    daData.Fill(dsData)
                    BtnEdit.Location = New Point(1179, 412)
                    BtnTambah.Location = New Point(1086, 412)
                    btnLapor.Enabled = True
                    MsgBox("Edit data berhasil")

                    Call KondisiAwal()
                    lvpelanggan.Enabled = True
                End If
            End If
        Catch ex As Exception
            BtnEdit.Location = New Point(1179, 412)
            BtnTambah.Location = New Point(1086, 412)
            CBIDKamar.Items.Clear()
            CBIDUnit.Items.Clear()
            CBBayar.Items.Clear()
            lvpelanggan.Clear()
            FormPelanggan_Load(sender, e)
            btnLapor.Enabled = True
            lvpelanggan.Enabled = True
            Call KosongkanData()
            MsgBox("Gagal!! data kamar tidak di temukan!", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If btnHapus.Text = "BATAL" Then
            BtnEdit.Location = New Point(1179, 412)
            BtnTambah.Location = New Point(1086, 412)
            CBIDKamar.Items.Clear()
            CBIDUnit.Items.Clear()
            CBBayar.Items.Clear()
            lvpelanggan.Clear()
            FormPelanggan_Load(sender, e)
            btnLapor.Enabled = True
            lvpelanggan.Enabled = True
            Call KosongkanData()
            Exit Sub
        End If


        If btnHapus.Text = "HAPUS" Then
            btnHapus.Text = "DELETE"
            btnHapus.Image = ImgHapus
            BtnEdit.Enabled = True
            BtnEdit.Text = "BATAL"
            BtnEdit.Image = imgBatal
            BtnTambah.Enabled = False
            lvpelanggan.Enabled = False

            txtId.Enabled = False
            CBIDUnit.Enabled = False
            CBIDKamar.Enabled = False
            txtKamar.Enabled = False
            txtUnit.Enabled = False
            txtNama.Enabled = False
            CBIDKamar.Enabled = False
            txtKendaraa.Enabled = False
            DateKendaraan.Enabled = False
            CBBayar.Enabled = False
            txtHarga.Enabled = False
            DateBayar.Enabled = False
            DateJTempo.Enabled = False
            txtTanggal.Enabled = False
            txtKasir.Enabled = False
            txtJam.Enabled = False
            btnLapor.Enabled = False
        Else

            Try
                Dim A As String
                A = MsgBox("Benar data mau dihapus...?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "Hapus Data")
                Select Case A
                    Case vbCancel
                        BtnEdit.Location = New Point(1179, 412)
                        BtnTambah.Location = New Point(1086, 412)
                        CBIDKamar.Items.Clear()
                        CBIDUnit.Items.Clear()
                        CBBayar.Items.Clear()
                        lvpelanggan.Clear()
                        FormPelanggan_Load(sender, e)
                        lvpelanggan.Enabled = True
                        Call KosongkanData()
                        MsgBox("Data pelanggan Tidak hapus", MsgBoxStyle.OkOnly, "Hapus Data")
                        Exit Sub
                    Case vbOK
                        If txtId.Text = "" Then
                            MsgBox("Silahkan isi ID untuk hapus data")
                        Else
                            Call KoneksiKeDatabase()

                            Dim adaKamar As String = "UPDATE tbl_kamar SET sts='ada' where id_kamar='" & CBIDKamar.Text & "'"
                            daData = New MySqlDataAdapter(adaKamar, Conn)
                            dsData = New DataSet
                            daData.Fill(dsData)

                            Query = "delete from tbl_pelanggan where id_pelanggan='" & txtId.Text & "'"
                            cmd = New MySqlCommand(Query, Conn)
                            cmd.ExecuteNonQuery()




                            lvpelanggan.Enabled = True
                            btnLapor.Enabled = True
                            Call KondisiAwal()
                            MsgBox("Data pelanggan Berhasil Di hapus", MsgBoxStyle.OkOnly, "Hapus Data")
                        End If
                End Select
            Catch ex As Exception
                MsgBox("Data Tidak bisa di Hapus", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Hapus Data")
            End Try
        End If

    End Sub
    Private Sub AmbilDatadariListView()
        With lvpelanggan.SelectedItems
            Try


                BtnEdit.Text = "EDIT"
                btnHapus.Text = "HAPUS"
                BtnEdit.Image = ImgEdit
                BtnEdit.Enabled = True
                btnHapus.Enabled = True
                BtnTambah.Enabled = False
                btnLapor.Enabled = False

                idNilai = .Item(0).SubItems(0).Text
                txtId.Text = idNilai
                txtNama.Text = .Item(0).SubItems(1).Text
                CBIDUnit.Text = .Item(0).SubItems(2).Text
                txtUnit.Text = .Item(0).SubItems(3).Text
                CBIDKamar.Text = .Item(0).SubItems(4).Text
                txtKamar.Text = .Item(0).SubItems(5).Text
                txtKendaraa.Text = .Item(0).SubItems(6).Text
                DateKendaraan.Text = .Item(0).SubItems(7).Text
                DateBayar.Text = .Item(0).SubItems(8).Text
                DateJTempo.Text = .Item(0).SubItems(9).Text
                CBBayar.Text = .Item(0).SubItems(10).Text
                txtHarga.Text = .Item(0).SubItems(11).Text
                DateJTempo.Text = .Item(0).SubItems(12).Text
                DateJTempo.Text = .Item(0).SubItems(12).Text



            Catch ex As Exception
            End Try
        End With

    End Sub
    Private Sub lvpelanggan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvpelanggan.SelectedIndexChanged
        lvpelanggan.Enabled = False
        AmbilDatadariListView()
        txtPembayaran.Text = txtHarga.Text
    End Sub

    Private Sub txtPembayaran_TextChanged(sender As Object, e As EventArgs) Handles txtPembayaran.TextChanged
        If txtHarga.Text = "" Then
            txtPembayaran.Text = "0"
        Else
            txtPembayaran.Text = String.Format("Rp. {0:n0}", CType(txtHarga.Text, Integer))
        End If

    End Sub

    Private Sub Caridata()
        Dim a As Integer
        Try
            KoneksiKeDatabase()
            Query = "SELECT * FROM relasipelanggan WHERE nama_pelanggan LIKE '%" & Trim(txtCari.Text) & "%' OR id_kendaraan LIKE '%" & Trim(txtCari.Text) & "%'"
            daData = New MySqlDataAdapter(Query, Conn)
            dsData = New DataSet
            daData.Fill(dsData)
            lvpelanggan.Items.Clear()
            For a = 0 To dsData.Tables(0).Rows.Count - 1
                With lvpelanggan
                    .Items.Add(dsData.Tables(0).Rows(a).Item(0))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(1))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(2))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(6))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(5))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(7))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(11))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(12))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(13))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(14))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(16))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(15))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(17))
                End With
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LblKode_Click(sender As Object, e As EventArgs) Handles LblKode.Click
        Caridata()
    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles btnLapor.Click
        FormLaporPerbulan.ShowDialog()
    End Sub

    Private Sub btnJamLock_Click(sender As Object, e As EventArgs) Handles btnJamLock.Click
        FormLock.ShowDialog()
    End Sub
End Class