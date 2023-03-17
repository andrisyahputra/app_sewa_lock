Imports MySql.Data.MySqlClient

Public Class FormLock
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

    Private Sub PosisiList()
        With ListView1.Columns
            .Add("ID CARD", 130)
            .Add("ID_PELANGGAN", 0)
            .Add("NAMA PELANGGAN", 120)
            .Add("ID KENDARAAN", 100)
            .Add("BUKA", 60)
            .Add("TUTUP", 60)
        End With
        ListView1.BackColor = Color.LightSeaGreen
    End Sub
    Private Sub KosongkanData()
        'txtID.Text = ""
        txtIDcard.Text = ""
        CBIDP.Text = ""
        txtNama.Text = ""
        txtKendaraan.Text = ""
    End Sub
    Private Sub KondisiAwal()
        Dim a As Integer
        Try
            txtIDcard.Text = ""
            CBIDP.Text = ""
            txtNama.Text = ""
            txtKendaraan.Text = ""

            BtnTutup.Enabled = True

            'txtID.Enabled = False
            txtIDcard.Enabled = False
            txtNama.Enabled = False
            txtKendaraan.Enabled = False
            CBIDP.Enabled = False

            ImgInput = AppPelanggan.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_7_Save_256
            ImgEdit = AppPelanggan.My.Resources.Resources.update
            ImgHapus = AppPelanggan.My.Resources.Resources.sampah
            ImgTutup = AppPelanggan.My.Resources.Resources.hm
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
            BtnTutup.Text = "TUTUP"
            BtnTutup.Image = ImgTutup

            BtnTambah.Enabled = True
            btnHapus.Enabled = False
            BtnEdit.Enabled = False
            'BtnTutup.Enabled = True

            KoneksiKeDatabase()
            Query = "Select * FROM tbl_lock ORDER BY id_card"
            daData = New MySqlDataAdapter(Query, Conn)
            dsData = New DataSet
            daData.Fill(dsData)
            ListView1.Items.Clear()
            For a = 0 To dsData.Tables(0).Rows.Count - 1
                With ListView1
                    .Items.Add(dsData.Tables(0).Rows(a).Item(0))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(1))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(2))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(3))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(4))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(5))
                End With


            Next
            'MsgBox("database berhasil di tampil")
        Catch ex As Exception
            MsgBox("database gagal di tampil")
        End Try
    End Sub
    Private Sub comboBoxID()
        Try
            Call KoneksiKeDatabase()
            Query = "Select * FROM tbl_pelanggan ORDER BY id_pelanggan"
            cmd = New MySqlCommand(Query, Conn)
            RD = cmd.ExecuteReader
            If RD.HasRows Then
                Do While RD.Read
                    CBIDP.Items.Add(RD("id_pelanggan"))
                Loop
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FormLock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        jamTutup.Format = DateTimePickerFormat.Time
        jamTutup.ShowUpDown = True
        jamBuka.Format = DateTimePickerFormat.Time
        jamBuka.ShowUpDown = True
        jamBuka.Value = "01/03/2023 08:00:00"
        jamTutup.Value = "01/03/2023 23:00:00"
        jamBuka.Enabled = False
        jamTutup.Enabled = False


        KoneksiKeDatabase()
        CBIDP.DropDownStyle = ComboBoxStyle.DropDownList
        comboBoxID()
        KondisiAwal()
        PosisiList()
    End Sub
    Private Sub FieldAktif()
        'txtID.Enabled = True
        txtIDcard.Enabled = True
        txtNama.Enabled = True
        txtKendaraan.Enabled = True
        CBIDP.Enabled = True
    End Sub
    'Private Sub no_user()

    '    Try
    '        cmd = New MySqlCommand("select * from tbl_lock where id_lock in(select max(id_lock) from tbl_lock) order by id_lock DESC", Conn)
    '        RD = cmd.ExecuteReader
    '        RD.Read()
    '        If Not RD.HasRows Then
    '            txtID.Text = "L" + "001"
    '        Else
    '            txtID.Text = Val(Microsoft.VisualBasic.Mid(RD.Item("id_lock").ToString, 2, 3)) + 1
    '            If Len(txtID.Text) = 1 Then
    '                txtID.Text = "L00" & txtID.Text & ""
    '            ElseIf Len(txtID.Text) = 2 Then
    '                txtID.Text = "L0" & txtID.Text & ""
    '            ElseIf Len(txtID.Text) = 3 Then
    '                txtID.Text = "L" & txtID.Text & ""
    '            End If
    '        End If
    '        user = txtID.Text
    '    Catch ex As Exception
    '        MsgBox("Gagal")
    '    End Try

    'End Sub


    Private Sub DateTanggalLahir_ValueChanged(sender As Object, e As EventArgs) Handles jamTutup.ValueChanged, jamBuka.ValueChanged

    End Sub

    Private Sub CBIDP_SelectedValueChanged(sender As Object, e As EventArgs) Handles CBIDP.SelectedValueChanged
        Try
            Call KoneksiKeDatabase()
            cmd = New MySqlCommand("select * from tbl_pelanggan where id_pelanggan='" & CBIDP.Text & "'", Conn)
            RD = cmd.ExecuteReader
            RD.Read()
            If RD.HasRows = True Then
                txtNama.Text = RD.Item("nama_pelanggan")
                txtKendaraan.Text = RD.Item("id_kendaraan")
                txtIDcard.Focus()
            End If
        Catch ex As Exception
            MsgBox("Gagal tampil pelanggan")
        End Try
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub status()
        Dim idkamar As String

        Call KoneksiKeDatabase()
        cmd = New MySqlCommand("SELECT * FROM relasipelanggan1 where id_pelanggan='" & CBIDP.Text & "' and sts='ada'", Conn)
        RD = cmd.ExecuteReader
        RD.Read()
        If RD.HasRows = True Then
            'MsgBox("ada sewa", MsgBoxStyle.Critical, "Data duplikat")
            idkamar = RD("id_kamar")
            Call KoneksiKeDatabase()
            Query = "UPDATE tbl_kamar SET sts='penuh'where id_kamar='" & idkamar & "'"
            daData = New MySqlDataAdapter(Query, Conn)
            dsData = New DataSet
            daData.Fill(dsData)
            Exit Sub
        End If
    End Sub
    Private Sub statusHapus()
        Dim idkamar As String

        Call KoneksiKeDatabase()
        cmd = New MySqlCommand("SELECT * FROM relasipelanggan1 where id_pelanggan='" & CBIDP.Text & "' and sts='penuh'", Conn)
        RD = cmd.ExecuteReader
        RD.Read()
        If RD.HasRows = True Then
            'MsgBox("ada sewa", MsgBoxStyle.Critical, "Data duplikat")
            idkamar = RD("id_kamar")
            Call KoneksiKeDatabase()
            Query = "UPDATE tbl_kamar SET sts='ada'where id_kamar='" & idkamar & "'"
            daData = New MySqlDataAdapter(Query, Conn)
            dsData = New DataSet
            daData.Fill(dsData)
            Exit Sub
        End If
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Try


            If BtnTambah.Text = "INPUT" Then
                BtnTambah.Image = imgSimpan
                BtnTambah.Text = "SIMPAN"
                'If txtID.Text = "" Then
                '    Call no_user()
                'Else
                '    txtID.Text = user
                'End If

                BtnEdit.Text = "CLEAR"
                BtnEdit.Image = ImgClear
                BtnEdit.Enabled = True
                btnHapus.Enabled = True

                btnHapus.Text = "BATAL"
                btnHapus.Image = imgBatal
                txtIDcard.Enabled = True
                CBIDP.Enabled = True
                ListView1.Enabled = False
                BtnTutup.Enabled = False
                CBIDP.Focus()
            Else
                If txtIDcard.Text = "" Then
                    MsgBox("data id card tidak boleh kosong")
                ElseIf CBIDP.Text = "" Then
                    MsgBox("Silahkan isi UNIT di FORM Pelanggan")
                ElseIf txtIDcard.Text = "" Then
                    MsgBox("Silahkan isi ID CARD ANDA")
                ElseIf Not txtIDcard.Text.Length >= 6 Then
                    MsgBox("Minimal ID CARD 6")
                ElseIf txtKendaraan.Text = "" Or
                txtNama.Text = "0" Or
                jamBuka.Text = "0" Or
                jamTutup.Text = "" Then
                    MsgBox("Silahkan Isi Semua Data")
                Else


                    Call KoneksiKeDatabase()
                    cmd = New MySqlCommand("SELECT * FROM tbl_lock where id_pelanggan='" & CBIDP.Text & "'", Conn)
                    RD = cmd.ExecuteReader
                    RD.Read()
                    If RD.HasRows = True Then
                        MsgBox("Setiap sewa 1 id card", MsgBoxStyle.Critical, "Data duplikat")

                    Else
                        Call status()
                        Call KoneksiKeDatabase()
                        Query = "INSERT INTO tbl_lock values ('" & txtIDcard.Text & "','" & CBIDP.Text & "','" & txtNama.Text & "','" & txtKendaraan.Text & "','" & jamBuka.Text & "','" & jamTutup.Text & "','-')"
                        daData = New MySqlDataAdapter(Query, Conn)
                        dsData = New DataSet
                        daData.Fill(dsData)
                        MsgBox("Input data berhasil")
                        ListView1.Clear()
                        CBIDP.Items.Clear()
                        FormLock_Load(sender, e)
                        ListView1.Enabled = True
                        Call KosongkanData()
                        BtnTutup.Enabled = True
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Tidak berhasil tambah data")
            BtnTutup.Enabled = True
        End Try
    End Sub

    Private Sub BtnTutup_Click_1(sender As Object, e As EventArgs) Handles BtnTutup.Click
        If BtnTutup.Text = "TUTUP" Then
            ListView1.Clear()
            CBIDP.Items.Clear()
            Me.Close()
        Else

            ListView1.Clear()
            CBIDP.Items.Clear()
            FormLock_Load(sender, e)
            ListView1.Enabled = True
            Call KosongkanData()
        End If

    End Sub

    Private Sub txtIDcard_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIDcard.KeyPress
        If Not Char.IsDigit(CChar(CStr(e.KeyChar))) Or txtIDcard.Text.Length >= 20 Then e.Handled = True
        If e.KeyChar = ChrW(Keys.Back) Then e.Handled = False
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If btnHapus.Text = "BATAL" Then
            ListView1.Clear()
            CBIDP.Items.Clear()
            FormLock_Load(sender, e)
            ListView1.Enabled = True
            Call KosongkanData()
            Exit Sub
        End If

        If btnHapus.Text = "CLEAR" Then
            txtIDcard.Text = ""
            CBIDP.Text = ""
            txtNama.Text = ""
            txtKendaraan.Text = ""
            CBIDP.Focus()
            Exit Sub
        End If

        If btnHapus.Text = "HAPUS" Then
            btnHapus.Text = "DELETE"
            btnHapus.Image = ImgHapus
            BtnEdit.Enabled = False
            BtnTambah.Enabled = False
            ListView1.Enabled = False

            'txtID.Enabled = False
            txtIDcard.Enabled = False
            txtNama.Enabled = False
            txtKendaraan.Enabled = False
            CBIDP.Enabled = False
        Else

            Try
                Dim A As String
                A = MsgBox("Benar data mau dihapus...?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "Hapus Data")
                Select Case A
                    Case vbCancel
                        ListView1.Clear()
                        CBIDP.Items.Clear()
                        FormLock_Load(sender, e)
                        ListView1.Enabled = True
                        Call KosongkanData()
                        MsgBox("Data pelanggan Tidak hapus", MsgBoxStyle.OkOnly, "Hapus Data")
                        Exit Sub
                    Case vbOK
                        If txtIDcard.Text = "" Then
                            MsgBox("Silahkan isi ID untuk hapus data")
                        Else
                            Call statusHapus()
                            Call KoneksiKeDatabase()
                            Query = "delete from tbl_lock where id_card='" & txtIDcard.Text & "'"
                            cmd = New MySqlCommand(Query, Conn)
                            cmd.ExecuteNonQuery()
                            ListView1.Clear()
                            CBIDP.Items.Clear()
                            FormLock_Load(sender, e)
                            ListView1.Enabled = True
                            Call KosongkanData()
                            MsgBox("Data pelanggan Berhasil Di hapus", MsgBoxStyle.OkOnly, "Hapus Data")
                        End If
                End Select
            Catch ex As Exception
                MsgBox("Data Tidak bisa di Hapus", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Hapus Data")
            End Try
        End If

    End Sub
    Private Sub AmbilDatadariListView()
        With ListView1.SelectedItems
            Try

                BtnTutup.Text = "BATAL"
                BtnTutup.Image = imgBatal
                BtnEdit.Text = "EDIT"
                btnHapus.Text = "HAPUS"
                BtnEdit.Image = ImgEdit
                BtnEdit.Enabled = True
                btnHapus.Enabled = True
                BtnTambah.Enabled = False

                'idNilai = .Item(0).SubItems(0).Text
                'txtID.Text = idNilai
                txtIDcard.Text = .Item(0).SubItems(0).Text
                CBIDP.Text = .Item(0).SubItems(1).Text
                txtNama.Text = .Item(0).SubItems(2).Text
                txtKendaraan.Text = .Item(0).SubItems(3).Text
                jamBuka.Text = .Item(0).SubItems(4).Text
                jamTutup.Text = .Item(0).SubItems(5).Text



            Catch ex As Exception
            End Try
        End With

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        ListView1.Enabled = False
        AmbilDatadariListView()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Try
            If BtnEdit.Text = "CLEAR" Then
                txtIDcard.Text = ""
                CBIDP.Text = ""
                txtNama.Text = ""
                txtKendaraan.Text = ""
                CBIDP.Focus()
                Exit Sub
            End If

            If BtnEdit.Text = "EDIT" Then
                BtnEdit.Image = imgUpdate
                BtnEdit.Text = "UPDATE"
                btnHapus.Enabled = True
                BtnTambah.Enabled = False
                BtnTutup.Text = "BATAL"
                BtnTutup.Image = imgBatal
                btnHapus.Text = "CLEAR"
                btnHapus.Image = ImgClear
                'txtID.Enabled = False
                CBIDP.Enabled = True
                txtNama.Enabled = False
                txtKendaraan.Enabled = False
                txtIDcard.Enabled = True
            Else
                If txtIDcard.Text = "" Then
                    MsgBox("Silahkan isi ID CARD ANDA")
                    MsgBox("data id card tidak boleh kosong")
                ElseIf CBIDP.Text = "" Then
                    MsgBox("Silahkan isi UNIT di FORM Pelanggan")
                ElseIf Not txtIDcard.Text.Length >= 6 Then
                    MsgBox("Minimal ID CARD 6")
                ElseIf txtNama.Text = "" Or
                        txtKendaraan.Text = "" Then
                    MsgBox("Nama dan Kendaraan tidak tersedia")
                ElseIf txtKendaraan.Text = "" Or
                jamBuka.Text = "" Or
                jamTutup.Text = "" Then
                    MsgBox("Silahkan Isi Semua Data")
                Else

                    Call KoneksiKeDatabase()
                    'Query = "UPDATE tbl_lock SET id_card = '" & txtIDcard.Text & "' ,id_pelanggan='" & CBIDP.Text & "',nama_pelanggan='" & txtNama.Text & "',id_kendaraan='" & txtKendaraan.Text & "',jam_masuk='" & jamBuka.Text & "',jam_keluar='" & jamTutup.Text & "',a_lock='-'where id_card='" & txtIDcard.Text & "'"
                    Query = "UPDATE `tbl_lock` SET `id_card`='" & txtIDcard.Text & "',`id_pelanggan`='" & CBIDP.Text & "',`nama_pelanggan`='" & txtNama.Text & "',`id_kendaraan`='" & txtKendaraan.Text & "',`jam_masuk`='" & jamBuka.Text & "',`jam_keluar`='" & jamTutup.Text & "',`a_lock`='-'"
                    daData = New MySqlDataAdapter(Query, Conn)
                    dsData = New DataSet
                    daData.Fill(dsData)
                    ListView1.Clear()
                    CBIDP.Items.Clear()
                    FormLock_Load(sender, e)
                    ListView1.Enabled = True
                    Call KosongkanData()
                    MsgBox("Edit data berhasil")

                End If
            End If
        Catch ex As Exception
            'BtnEdit.Location = New Point(1179, 412)
            'BtnTambah.Location = New Point(1086, 412)
            'CBIDKamar.Items.Clear()
            'CBIDUnit.Items.Clear()
            'CBBayar.Items.Clear()
            'lvpelanggan.Clear()
            'FormMenu_Load(sender, e)
            'btnLapor.Enabled = True
            'lvpelanggan.Enabled = True
            'Call KosongkanData()
            MsgBox("Gagal!! data pelanggan tidak di temukan!", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Caridata()
        Dim a As Integer
        Try
            KoneksiKeDatabase()
            Query = "SELECT * FROM relasipelanggan1 WHERE nama_pelanggan LIKE '%" & Trim(txtCari.Text) & "%' OR id_kendaraan LIKE '%" & Trim(txtCari.Text) & "%'"
            daData = New MySqlDataAdapter(Query, Conn)
            dsData = New DataSet
            daData.Fill(dsData)
            ListView1.Items.Clear()
            For a = 0 To dsData.Tables(0).Rows.Count - 1
                With ListView1
                    .Items.Add(dsData.Tables(0).Rows(a).Item(0))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(1))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(2))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(3))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(4))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(5))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(6))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(7))
                End With
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LblKode_Click(sender As Object, e As EventArgs) Handles LblKode.Click
        Caridata()
    End Sub
End Class
