Imports MySql.Data.MySqlClient

Public Class FormTambahUnit
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
        With LVUnit2.Columns
            .Add("ID UNIT", 70)
            .Add("NAMA UNIT", 105)
            .Add("ALAMAT UNIT", 170)
            .Add("TYPE UNIT", 100)
        End With
        LVUnit2.BackColor = Color.SkyBlue
    End Sub
    Private Sub KosongkanData()
        txtID.Text = ""
        txtNUnit.Text = ""
        txtAlamat.Text = ""
        txtType.Text = ""
    End Sub
    Private Sub KondisiAwal()
        Dim a As Integer
        Try
            txtNUnit.Text = ""
            txtAlamat.Text = ""
            txtType.Text = ""

            txtID.Enabled = False
            txtNUnit.Enabled = False
            txtAlamat.Enabled = False
            txtType.Enabled = False
            txtNUnit.MaxLength = 10

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
            btnTutup.Text = "TUTUP"
            btnTutup.Image = ImgTutup

            BtnTambah.Enabled = True
            btnHapus.Enabled = False
            BtnEdit.Enabled = False
            btnTutup.Enabled = True

            Query = "Select * FROM tbl_unit ORDER BY id_unit"
            daData = New MySqlDataAdapter(Query, Conn)
            dsData = New DataSet
            daData.Fill(dsData)
            LVUnit2.Items.Clear()
            For a = 0 To dsData.Tables(0).Rows.Count - 1
                With LVUnit2
                    .Items.Add(dsData.Tables(0).Rows(a).Item(0))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(1))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(3))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(2))
                End With
            Next
            'MsgBox("database berhasil di tampil")
        Catch ex As Exception
            'MsgBox("database gagal di tampil")
        End Try
    End Sub
    Private Sub FieldAktif()
        txtID.Enabled = True
        txtNUnit.Enabled = True
        txtType.Enabled = True
        txtAlamat.Enabled = True
    End Sub
    Private Sub no_user()

        Try
            cmd = New MySqlCommand("select * from tbl_unit where id_unit in(select max(id_unit) from tbl_unit) order by id_unit DESC", Conn)
            RD = cmd.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                txtID.Text = "U" + "001"
            Else
                txtID.Text = Val(Microsoft.VisualBasic.Mid(RD.Item("id_unit").ToString, 2, 3)) + 1
                If Len(txtID.Text) = 1 Then
                    txtID.Text = "U00" & txtID.Text & ""
                ElseIf Len(txtID.Text) = 2 Then
                    txtID.Text = "U0" & txtID.Text & ""
                ElseIf Len(txtID.Text) = 3 Then
                    txtID.Text = "U" & txtID.Text & ""
                End If
            End If
            user = txtID.Text
        Catch ex As Exception
            MsgBox("Gagal")
        End Try

    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        If btnTutup.Text = "TUTUP" Then
            LVUnit2.Clear()
            Me.Close()
        Else
            LVUnit2.Clear()
            FormTambahUnit_load(sender, e)
            KondisiAwal()
            btnHapus.Visible = True
            LVUnit2.Enabled = True
        End If

    End Sub


    Private Sub FormTambahUnit_load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                btnTutup.Text = "BATAL"
                btnTutup.Image = imgBatal
                Call FieldAktif()
                txtID.Enabled = False
                LVUnit2.Enabled = False
                txtNUnit.Focus()
            Else

                If txtID.Text = "" Then
                    MsgBox("Silahkan isi ID untuk edit data")
                ElseIf txtNUnit.Text = "" Or
                        txtAlamat.Text = "" Or
                    txtNUnit.Text = "" Or
                    txtType.Text = "" Then
                    MsgBox("Silahkan Isi Semua Data")
                Else
                    Call KoneksiKeDatabase()
                    cmd = New MySqlCommand("SELECT * FROM tbl_unit where nama_unit='" & txtNUnit.Text & "'", Conn)
                    RD = cmd.ExecuteReader
                    RD.Read()
                    If RD.HasRows = True Then
                        MsgBox("Unit sudah ada", MsgBoxStyle.Critical, "Data duplikat")

                    Else
                        Call KoneksiKeDatabase()
                        Query = "insert into tbl_unit values ('" & txtID.Text & "','" & txtNUnit.Text & "','" & txtAlamat.Text & "','" & txtType.Text & "','-','-','-','-')"
                        daData = New MySqlDataAdapter(Query, Conn)
                        dsData = New DataSet
                        daData.Fill(dsData)
                        MsgBox("Input data berhasil")
                        Call KondisiAwal()
                        FormTambahUnit_load(sender, e)
                        btnHapus.Visible = True
                        LVUnit2.Enabled = True
                        Call KosongkanData()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Tidak berhasil tambah data")
        End Try
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Try
            If BtnEdit.Text = "CLEAR" Then
                txtNUnit.Text = ""
                txtAlamat.Text = ""
                txtType.Text = ""
                txtCari.Text = ""
                Exit Sub
            End If

            If BtnEdit.Text = "EDIT" Then
                BtnEdit.Image = imgUpdate
                BtnEdit.Text = "UPDATE"
                btnHapus.Enabled = False
                BtnTambah.Enabled = False
                btnTutup.Text = "BATAL"
                btnTutup.Image = imgBatal
                LblKode.Visible = False
                txtID.Enabled = False
                txtNUnit.Enabled = False
                txtType.Enabled = True
                txtAlamat.Enabled = True
            Else
                If txtID.Text = "" Then
                    MsgBox("Silahkan isi ID untuk edit data")
                ElseIf txtAlamat.Text = "" Or
                txtNUnit.Text = "" Or
                txtType.Text = "" Then
                    MsgBox("Silahkan Isi Semua Data")
                Else


                    Call KoneksiKeDatabase()
                        Query = "UPDATE tbl_unit set nama_unit='" & txtNUnit.Text & "',alamat_unit='" & txtAlamat.Text & "',type_unit='" & txtType.Text & "',b='-',c='-',d='-',e='-'where id_unit='" & txtID.Text & "'"
                        daData = New MySqlDataAdapter(Query, Conn)
                        dsData = New DataSet
                        daData.Fill(dsData)
                        LVUnit2.Enabled = True
                        MsgBox("Data Berhasil DIUpdate!")
                        KondisiAwal()

                    End If
            End If

        Catch ex As Exception
            MsgBox("Gagal Update!", MsgBoxStyle.Critical, "Error")
            txtNUnit.Focus()
        End Try
    End Sub

    Private Sub AmbilDataListview()
        With LVUnit2.SelectedItems
            Try
                If BtnEdit.Text = "CLEAR" Then
                    txtAlamat.Text = ""
                    txtNUnit.Text = ""
                    txtType.Text = ""
                    txtNUnit.Focus()
                    Exit Sub
                End If


                BtnEdit.Text = "EDIT"
                BtnEdit.Image = ImgEdit
                BtnEdit.Enabled = True
                btnHapus.Enabled = True
                BtnTambah.Enabled = False
                btnTutup.Text = "BATAL"
                btnTutup.Image = imgBatal
                txtID.Enabled = True
                txtNUnit.Enabled = False
                txtAlamat.Enabled = False
                txtType.Enabled = False

                txtID.Focus()

                idNilai = .Item(0).SubItems(0).Text
                txtID.Text = idNilai
                txtNUnit.Text = .Item(0).SubItems(1).Text

                txtType.Text = .Item(0).SubItems(2).Text
                txtAlamat.Text = .Item(0).SubItems(3).Text

                txtID.Enabled = False
                txtAlamat.Enabled = False
                txtNUnit.Enabled = False
                txtType.Enabled = False
                txtNUnit.Focus()


            Catch ex As Exception
            End Try
        End With



    End Sub






    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub



    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Try

            If btnHapus.Text = "HAPUS" Then
                MsgBox("Semua data bakal dihapus")
                btnHapus.Text = "DELETE"
                btnHapus.Image = ImgHapus
                BtnEdit.Enabled = False
                BtnTambah.Enabled = False
                btnTutup.Text = "BATAL"
                btnTutup.Image = imgBatal
                LVUnit2.Enabled = False
                txtID.Enabled = False
                txtNUnit.Enabled = False
                txtType.Enabled = False
                txtAlamat.Enabled = False
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
                                Query = "DELETE FROM tbl_unit WHERE id_unit='" & txtID.Text & "'"
                                daData = New MySqlDataAdapter(Query, Conn)
                                dsData = New DataSet
                                daData.Fill(dsData)
                                Call KondisiAwal()
                                Call KosongkanData()
                                LVUnit2.Enabled = True
                                MsgBox("Data Unit Berhasil Di hapus", MsgBoxStyle.OkOnly, "HAPUS DATA UNIT")
                            End If
                    End Select
                Catch ex As Exception
                    MsgBox("Data Tidak bisa di Hapus", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Hapus Data")
                End Try
            End If
        Catch ex As Exception
            MsgBox("Data Tidak bisa di Hapus", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Hapus Data")
        End Try
    End Sub

    Private Sub LVUnit2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LVUnit2.SelectedIndexChanged
        LVUnit2.Enabled = False
        AmbilDataListview()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged

    End Sub
    Private Sub Caridata()
        Dim a As Integer
        Try
            KoneksiKeDatabase()
            Query = "SELECT * FROM tbl_unit WHERE id_unit LIKE '%" & Trim(txtCari.Text) & "%' OR nama_unit LIKE '%" & Trim(txtCari.Text) & "%'OR type_unit LIKE '%" & Trim(txtCari.Text) & "%'"
            daData = New MySqlDataAdapter(Query, Conn)
            dsData = New DataSet
            daData.Fill(dsData)
            LVUnit2.Items.Clear()
            For a = 0 To dsData.Tables(0).Rows.Count - 1
                With LVUnit2
                    .Items.Add(dsData.Tables(0).Rows(a).Item(0))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(1))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(2))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(3))
                End With
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LblKode_Click(sender As Object, e As EventArgs) Handles LblKode.Click
        Caridata()
    End Sub

    Public Sub FormTambahUnit_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormUnit.FormUnit_Load(sender, e)
    End Sub
End Class