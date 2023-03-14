Imports MySql.Data.MySqlClient

Public Class FormTambahKamar
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
    Private Sub statusWarna()
        Call KoneksiKeDatabase()
        cmd = New MySqlCommand("select * from tbl_kamar where sts='ada'", Conn)
        RD = cmd.ExecuteReader
        RD.Read()
        If RD.HasRows = True Then
            ListView1.BackColor = Color.Lime
        Else
            ListView1.BackColor = Color.Crimson

        End If
    End Sub

    Private Sub PosisiList()
        With ListView1.Columns
            .Add("ID KAMAR", 60)
            .Add("NAMA UNIT", 100)
            .Add("ID UNIT", 60)
            .Add("KAMAR", 100)
            .Add("HARGA BULANAN", 120)
            .Add("HARGA TAHUANAN", 120)
            .Add("STATUS", 60)
        End With

        ListView1.BackColor = Color.LightSeaGreen
    End Sub
    Private Sub KosongkanData()
        txtID.Text = ""
        CBIDUnit.Text = ""
        txtNUnit.Text = ""
        txtNKamar.Text = ""
        txtHTahunan.Text = "0"
        txtHBulanan.Text = "0"
    End Sub
    Private Sub KondisiAwal()
        Dim a As Integer
        Try
            CBIDUnit.Text = ""
            txtNUnit.Text = ""
            txtNKamar.Text = ""
            txtHTahunan.Text = "0"
            txtHBulanan.Text = "0"

            txtID.Enabled = False
            CBIDUnit.Enabled = False
            txtNUnit.Enabled = False
            txtNKamar.Enabled = False
            txtHBulanan.Enabled = False
            txtHTahunan.Enabled = False
            txtHTahunan.MaxLength = 10

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
            BtnTutup.Enabled = True

            Query = "Select * FROM tbl_kamar ORDER BY id_kamar"
            daData = New MySqlDataAdapter(Query, Conn)
            dsData = New DataSet
            daData.Fill(dsData)
            ListView1.Items.Clear()
            For a = 0 To dsData.Tables(0).Rows.Count - 1
                With ListView1
                    .Items.Add(dsData.Tables(0).Rows(a).Item(0))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(1))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(3))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(2))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(4))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(5))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(6))
                End With
            Next
            'MsgBox("database berhasil di tampil")
        Catch ex As Exception
            'MsgBox("database gagal di tampil")
        End Try
    End Sub
    Private Sub FieldAktif()
        txtID.Enabled = True
        txtNKamar.Enabled = True
        CBIDUnit.Enabled = True
        txtHBulanan.Enabled = True
        txtHTahunan.Enabled = True
    End Sub
    Private Sub no_user()

        Try
            cmd = New MySqlCommand("select * from tbl_kamar where id_kamar in(select max(id_kamar) from tbl_kamar) order by id_kamar DESC", Conn)
            RD = cmd.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                txtID.Text = "K" + "001"
            Else
                txtID.Text = Val(Microsoft.VisualBasic.Mid(RD.Item("id_kamar").ToString, 2, 3)) + 1
                If Len(txtID.Text) = 1 Then
                    txtID.Text = "K00" & txtID.Text & ""
                ElseIf Len(txtID.Text) = 2 Then
                    txtID.Text = "K0" & txtID.Text & ""
                ElseIf Len(txtID.Text) = 3 Then
                    txtID.Text = "K" & txtID.Text & ""
                End If
            End If
            user = txtID.Text
        Catch ex As Exception
            MsgBox("Gagal")
        End Try

    End Sub
    Private Sub comboBoxID()
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

        End Try
    End Sub
    Private Sub FormTambahKamar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBIDUnit.DropDownStyle = ComboBoxStyle.DropDownList
        comboBoxID()
        KoneksiKeDatabase()
        PosisiList()
        KondisiAwal()
        no_user()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Try


            If BtnTambah.Text = "INPUT" Then
                BtnTambah.Image = imgSimpan
                BtnTambah.Text = "SIMPAN"
                If txtID.Text = "" Then
                    Call no_user()
                Else
                    txtID.Text = user
                End If

                BtnEdit.Text = "CLEAR"
                BtnEdit.Image = ImgClear
                BtnEdit.Enabled = True
                btnHapus.Visible = False
                BtnTutup.Text = "BATAL"
                BtnTutup.Image = imgBatal
                Call FieldAktif()
                txtID.Enabled = False
                ListView1.Enabled = False
                CBIDUnit.Focus()
            Else
                If txtID.Text = "" Then
                    MsgBox("Silahkan isi ID untuk edit data")
                ElseIf CBIDUnit.Text = "" Then
                    MsgBox("Silahkan isi UNIT di FORM UNIT")
                ElseIf Not txtHBulanan.Text.Length >= 6 Then
                    MsgBox("Minimal Harga Bulanan Ratusan")
                ElseIf Not txtHTahunan.Text.Length >= 6 Then
                    MsgBox("Minimal Harga Tahunan Ratusan")
                ElseIf Not Val(txtHTahunan.Text) >= Val(txtHBulanan.Text) Then
                    MsgBox("Minimal Harga Tahunan lebih Besar dari Harga tahunan")
                ElseIf txtNKamar.Text = "" Or
                txtHTahunan.Text = "" Or
                txtNUnit.Text = "" Or
                txtHBulanan.Text = "0" Or
                txtHTahunan.Text = "0" Or
                CBIDUnit.Text = "" Then
                    MsgBox("Silahkan Isi Semua Data")
                Else
                    Call KoneksiKeDatabase()
                    cmd = New MySqlCommand("SELECT * FROM tbl_kamar where kamar='" & txtNKamar.Text & "'and nama_unit='" & txtNUnit.Text & "'", Conn)
                    RD = cmd.ExecuteReader
                    RD.Read()
                    If RD.HasRows = True Then
                        MsgBox("Kamar sudah ada terisi", MsgBoxStyle.Critical, "Data duplikat")
                    Else
                        Call KoneksiKeDatabase()
                        Query = "INSERT INTO tbl_kamar values ('" & txtID.Text & "','" & txtNUnit.Text & "','" & txtNKamar.Text & "','" & CBIDUnit.Text & "','" & txtHBulanan.Text & "','" & txtHTahunan.Text & "','ada','-','-','-','-')"
                        daData = New MySqlDataAdapter(Query, Conn)
                        dsData = New DataSet
                        daData.Fill(dsData)
                        MsgBox("Input data berhasil")
                        Call KondisiAwal()
                        btnHapus.Visible = True
                        ListView1.Enabled = True
                        Call KosongkanData()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Tipe kamar sudah tersedia!", MsgBoxStyle.Critical, "Error")
            txtNUnit.Focus()
        End Try
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        If BtnTutup.Text = "TUTUP" Then
            Me.Close()
            ListView1.Clear()
            CBIDUnit.Items.Clear()
        Else
            ListView1.Clear()
            CBIDUnit.Items.Clear()
            FormTambahKamar_Load(sender, e)
            KondisiAwal()
            btnHapus.Visible = True
            ListView1.Enabled = True
        End If
    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Try
            If BtnEdit.Text = "CLEAR" Then
                CBIDUnit.Text = ""
                txtNUnit.Text = ""
                txtNKamar.Text = ""
                txtHBulanan.Text = "0"
                txtHTahunan.Text = "0"
                Exit Sub
            End If

            If BtnEdit.Text = "EDIT" Then
                BtnEdit.Image = imgUpdate
                BtnEdit.Text = "UPDATE"
                btnHapus.Enabled = False
                BtnTambah.Enabled = False
                BtnTutup.Text = "BATAL"
                BtnTutup.Image = imgBatal
                LblKode.Visible = False
                txtID.Enabled = False
                txtNKamar.Enabled = True
                txtNUnit.Enabled = False
                txtHTahunan.Enabled = True
                txtHBulanan.Enabled = True
                CBIDUnit.Enabled = True
                CBIDUnit.Focus()
            Else
                If txtID.Text = "" Then
                    MsgBox("Silahkan isi ID untuk edit data")
                ElseIf Not txtHTahunan.Text.Length >= 6 Then
                    MsgBox("Minimal Ratusan")
                ElseIf Not txtHBulanan.Text.Length >= 6 Then
                    MsgBox("Minimal Ratusan")
                ElseIf Not Val(txtHTahunan.Text) >= Val(txtHBulanan.Text) Then
                    MsgBox("Minimal Harga Tahunan lebih Besar dari Harga tahunan")
                ElseIf txtNKamar.Text = "" Or
                txtHTahunan.Text = "" Or
                txtNUnit.Text = "" Or
                txtHBulanan.Text = "0" Or
                txtHTahunan.Text = "0" Or
                CBIDUnit.Text = "" Then
                    MsgBox("Silahkan Isi Semua Data")
                Else

                    Call KoneksiKeDatabase()
                    Query = "UPDATE tbl_kamar SET nama_unit='" & txtNUnit.Text & "',kamar='" & txtNKamar.Text & "',id_unit='" & CBIDUnit.Text & "',harga_bulanan='" & txtHBulanan.Text & "',harga_tahunan='" & txtHTahunan.Text & "',sts='ada',a='-',b='-',c='-',d='-'where id_kamar='" & txtID.Text & "'"
                    daData = New MySqlDataAdapter(Query, Conn)
                    dsData = New DataSet
                    daData.Fill(dsData)
                    MsgBox("Edit data berhasil")
                    Call KondisiAwal()
                    ListView1.Enabled = True
                End If
            End If
        Catch ex As Exception
            MsgBox("Tipe kamar sudah tersedia!", MsgBoxStyle.Critical, "Error")
            txtNUnit.Focus()
        End Try



    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If btnHapus.Text = "HAPUS" Then
            btnHapus.Text = "DELETE"
            btnHapus.Image = ImgHapus
            BtnEdit.Enabled = False
            BtnTambah.Enabled = False
            BtnTutup.Text = "BATAL"
            BtnTutup.Image = imgBatal
            ListView1.Enabled = False
            txtID.Enabled = False
            txtNKamar.Enabled = False
            txtNUnit.Enabled = False
            txtHTahunan.Enabled = False
            txtHBulanan.Enabled = False
            CBIDUnit.Enabled = False
        Else
            Try
                    Dim A As String
                    A = MsgBox("Benar data mau dihapus...?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "Hapus Data")
                    Select Case A
                        Case vbCancel
                        Exit Sub
                    Case vbOK
                        If txtID.Text = "" Then
                            MsgBox("Silahkan isi ID untuk hapus data")
                        Else
                            Call KoneksiKeDatabase()
                            Query = "delete from tbl_kamar where id_kamar='" & txtID.Text & "'"
                            cmd = New MySqlCommand(Query, Conn)
                            cmd.ExecuteNonQuery()
                            ListView1.Enabled = True
                            Call KondisiAwal()
                            MsgBox("Data Kamar Berhasil Di hapus", MsgBoxStyle.OkOnly, "HAPUS DATA KAMAR")
                        End If
                    End Select
                Catch ex As Exception
                    MsgBox("Data Tidak bisa di Hapus", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Hapus Data")
                End Try
            'End If
        End If
    End Sub
    Private Sub AmbilDatadariListView()
        With ListView1.SelectedItems
            Try
                'If BtnEdit.Text = "CLEAR" Then
                '    txtNKamar.Text = ""
                '    txtNUnit.Text = ""
                '    txtHarga.Text = ""
                '    CBIDUnit.Text = ""
                '    CBTHarga.Text = ""
                '    txtNUnit.Focus()
                '    Exit Sub
                'End If


                BtnEdit.Text = "EDIT"
                BtnEdit.Image = ImgEdit
                BtnEdit.Enabled = True
                btnHapus.Enabled = True
                BtnTambah.Enabled = False
                BtnTutup.Text = "BATAL"
                BtnTutup.Image = imgBatal


                txtID.Focus()

                idNilai = .Item(0).SubItems(0).Text
                txtID.Text = idNilai
                txtNUnit.Text = .Item(0).SubItems(1).Text

                CBIDUnit.Text = .Item(0).SubItems(2).Text
                txtNKamar.Text = .Item(0).SubItems(3).Text
                txtHBulanan.Text = .Item(0).SubItems(4).Text
                txtHTahunan.Text = .Item(0).SubItems(5).Text

                txtID.Enabled = False
                txtNKamar.Enabled = False
                txtHTahunan.Enabled = False
                txtNUnit.Enabled = False
                txtHBulanan.Enabled = False
                CBIDUnit.Enabled = False
                ListView1.Enabled = False
                txtNUnit.Focus()


            Catch ex As Exception
            End Try
        End With

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        AmbilDatadariListView()
    End Sub

    Private Sub CBIDUnit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBIDUnit.SelectedValueChanged
        Try
            Call KoneksiKeDatabase()
            cmd = New MySqlCommand("select * from tbl_unit where id_unit='" & CBIDUnit.Text & "'", Conn)
            RD = cmd.ExecuteReader
            RD.Read()
            If RD.HasRows = True Then
                txtNUnit.Text = RD.Item("nama_unit")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtHarga_TextChanged(sender As Object, e As EventArgs) Handles txtHTahunan.TextChanged

    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHTahunan.KeyPress
        If Not Char.IsDigit(CChar(CStr(e.KeyChar))) Or txtHTahunan.Text.Length >= 15 Then e.Handled = True
        If e.KeyChar = ChrW(Keys.Back) Then e.Handled = False
    End Sub

    Private Sub CBTHarga_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtHBulanan_TextChanged(sender As Object, e As EventArgs) Handles txtHBulanan.TextChanged

    End Sub

    Private Sub txtHBulanan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHBulanan.KeyPress
        If Not Char.IsDigit(CChar(CStr(e.KeyChar))) Or txtHBulanan.Text.Length >= 15 Then e.Handled = True
        If e.KeyChar = ChrW(Keys.Back) Then e.Handled = False
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged

    End Sub
    Private Sub Caridata()
        Dim a As Integer
        Try
            KoneksiKeDatabase()
            Query = "SELECT * FROM tbl_kamar WHERE kamar LIKE '%" & Trim(txtCari.Text) & "%' OR nama_unit LIKE '%" & Trim(txtCari.Text) & "%'"
            daData = New MySqlDataAdapter(Query, Conn)
            dsData = New DataSet
            daData.Fill(dsData)
            ListView1.Items.Clear()
            For a = 0 To dsData.Tables(0).Rows.Count - 1
                With ListView1
                    .Items.Add(dsData.Tables(0).Rows(a).Item(0))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(1))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(3))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(2))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(4))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(5))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(6))
                End With
            Next
        Catch ex As Exception
            MsgBox("Data tidak di temukan")
        End Try
    End Sub

    Private Sub LblKode_Click(sender As Object, e As EventArgs) Handles LblKode.Click
        Caridata()
    End Sub

    Private Sub FormTambahKamar_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormUnit.FormUnit_Load(sender, e)
    End Sub
End Class