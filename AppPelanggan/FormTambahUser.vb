Imports MySql.Data.MySqlClient

Public Class FormTambahUser
    Dim gender As String
    Dim user As String
    Dim idNilai As String
    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        If BtnTutup.Text = "TUTUP" Then
            Me.Close()
            ListView1.Clear()
            CBLevel.Items.Clear()
        Else
            CBLevel.Items.Clear()
            FormTambahUser_Load(sender, e)
            BtnHapus.Visible = True
            KondisiAwal()
            ListView1.Enabled = True
        End If
    End Sub
    Function calculateAge(dateOfBird As Date, fromDate As Date) As String
        Dim dateNow As Date
        Dim tgl As Date

        Dim years As Long
        Dim months As Long

        Dim yearWord As String
        Dim monthWord As String

        dateNow = fromDate
        tgl = dateOfBird

        ' menghitung tahun
        years = DateDiff("yyyy", tgl, dateNow)
        If Month(tgl) > Month(dateNow) Then
            years = years - 1
        ElseIf Month(tgl) = Month(dateNow) And tgl.Day > dateNow.Day Then
            years = years - 1
        ElseIf Month(tgl) = Month(dateNow) And tgl.Day = dateNow.Day Then
            GoTo Finish ' jika bulan dan tanggal sama maka perhitungan selesai
        End If

        ' menghitung bulan
        tgl = DateAdd("yyyy", years, tgl)
        months = DateDiff("m", tgl, dateNow)
        If tgl.Day > dateNow.Day Then
            months = months - 1
        ElseIf Month(tgl) = Month(dateNow) And tgl.Day >= dateNow.Day Then
            months = months - 1
        End If

        tgl = DateAdd("m", months, tgl)

Finish:
        yearWord = IIf(years = 0, "", years & " Tahun ")
        monthWord = IIf(months = 0, "", months & " Bulan ")

        calculateAge = yearWord & monthWord
        calculateAge = Trim(calculateAge)
    End Function
    Private Sub PosisiList()
        With ListView1.Columns
            .Add("ID", 50)
            .Add("NAMA LENGKAP", 130)
            .Add("JENIS KELAMIN", 70)
            .Add("ALAMAT", 150)
            .Add("TANGGAL LAHIR", 70)
            .Add("USIA", 100)
            .Add("NOMOR WA", 100)
            .Add("USERNAME", 80)
            .Add("PASSWORD", 80)
            .Add("LEVEL", 50)
        End With
        ListView1.BackColor = Color.SkyBlue
    End Sub

    Private Sub KosongkanData()
        TxtUserID.Text = ""
        TxtNamaLengkap.Text = ""
        TxtAlamat.Text = ""
        TxtPassword.Text = ""
        TxtUsername.Text = ""
        CBLevel.Text = ""
        txtNoWa.Text = ""
        txtUsia.Text = ""
        RBLaki.Checked = False
        RBPerempuan.Checked = False
        DateTanggalLahir.Value = Today
    End Sub

    Private Sub KondisiAwal()
        Dim a As Integer
        Try
            TxtNamaLengkap.Text = ""
            TxtAlamat.Text = ""
            TxtPassword.Text = ""
            TxtUsername.Text = ""
            txtNoWa.Text = ""
            txtUsia.Text = ""
            RBLaki.Text = "Laki Laki"
            RBPerempuan.Text = "Perempuan"
            DateTanggalLahir.Text = Today

            TxtUserID.Enabled = False
            TxtNamaLengkap.Enabled = False
            TxtAlamat.Enabled = False
            TxtPassword.Enabled = False
            TxtUsername.Enabled = False
            CBLevel.Enabled = False
            RBLaki.Enabled = False
            RBPerempuan.Enabled = False
            DateTanggalLahir.Enabled = False
            txtNoWa.Enabled = False
            txtUsia.Enabled = False
            TxtUsername.MaxLength = 10
            TxtPassword.MaxLength = 10
            txtNoWa.MaxLength = 15

            RBLaki.Checked = False
            RBPerempuan.Checked = False

            BtnTambah.Text = "INPUT"
            BtnEdit.Text = "EDIT"
            BtnHapus.Text = "HAPUS"
            BtnTutup.Text = "TUTUP"

            BtnTambah.Enabled = True
            BtnHapus.Enabled = False
            BtnEdit.Enabled = False
            BtnTutup.Enabled = True

            Query = "Select * FROM tbl_user ORDER BY id_user"
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
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(8))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(9))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(5))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(6))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(7))
                End With
            Next
            'MsgBox("database berhasil di tampil")
        Catch ex As Exception
            'MsgBox("database gagal di tampil")
        End Try
    End Sub
    Private Sub FieldAktif()
        ' untuk mengaktifkan form
        TxtNamaLengkap.Enabled = True
        TxtAlamat.Enabled = True
        TxtPassword.Enabled = True
        TxtUsername.Enabled = True
        CBLevel.Enabled = True
        RBLaki.Enabled = True
        RBPerempuan.Enabled = True
        RBLaki.Checked = False
        RBPerempuan.Checked = False
        DateTanggalLahir.Enabled = True
        BtnHapus.Enabled = True
        txtNoWa.Enabled = True
    End Sub
    Private Sub no_user()

        Try
            cmd = New MySqlCommand("select * from tbl_user where id_user in(select max(id_user) from tbl_user) order by id_user DESC", Conn)
            RD = cmd.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                TxtUserID.Text = "U" + "001"
            Else
                TxtUserID.Text = Val(Microsoft.VisualBasic.Mid(RD.Item("id_user").ToString, 2, 3)) + 1
                If Len(TxtUserID.Text) = 1 Then
                    TxtUserID.Text = "U00" & TxtUserID.Text & ""
                ElseIf Len(TxtUserID.Text) = 2 Then
                    TxtUserID.Text = "U0" & TxtUserID.Text & ""
                ElseIf Len(TxtUserID.Text) = 3 Then
                    TxtUserID.Text = "U" & TxtUserID.Text & ""
                End If
            End If
            user = TxtUserID.Text
        Catch ex As Exception
            MsgBox("Gagal")
        End Try

    End Sub


    Private Sub FormTambahUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBLevel.DropDownStyle = ComboBoxStyle.DropDownList
        CBLevel.Items.Add("Admin")
        CBLevel.Items.Add("Kasir")
        KoneksiKeDatabase()
        PosisiList()
        KondisiAwal()
        no_user()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Try
            If BtnTambah.Text = "INPUT" Then
                BtnTambah.Text = "SIMPAN"
                If TxtUserID.Text = "" Then
                    Call no_user()
                Else
                    TxtUserID.Text = user
                End If

                BtnEdit.Text = "CLEAR"
                BtnHapus.Visible = False
                BtnTutup.Text = "BATAL"
                Call FieldAktif()
                TxtUserID.Enabled = False
                ListView1.Enabled = False
                TxtNamaLengkap.Focus()
            Else

                If TxtUserID.Text = "" Then
                    MsgBox("Silahkan isi ID untuk edit data")
                ElseIf TxtNamaLengkap.Text = "" Or
                    TxtAlamat.Text = "" Or
                    TxtPassword.Text = "" Or
                    TxtUsername.Text = "" Or
                    txtNoWa.Text = "" Or
                    txtUsia.Text = "" Or
                    CBLevel.Text = "" Or
                    RBLaki.Checked = False And RBPerempuan.Checked = False Then
                    MsgBox("Silahkan Isi Semua Data")
                ElseIf DateTanggalLahir.Text = Today Then
                    MsgBox("Tanggal Lahir belum input")
                ElseIf DateTanggalLahir.Text > Today Then
                    MsgBox("Tanggal Lahir Kelewatan tahun")
                ElseIf Not txtNoWa.Text.Length >= 12 Then
                    MsgBox("Minimal Nomor Wa 12 angka")
                ElseIf Not TxtUsername.Text.Length >= 5 Then
                    MsgBox("Minimal 5 Username")
                ElseIf Not TxtPassword.Text.Length >= 5 Then
                    MsgBox("Minimal 5 Password")
                Else
                    Call KoneksiKeDatabase()
                    cmd = New MySqlCommand("SELECT * FROM tbl_user where user_name='" & TxtUsername.Text & "' OR no_hp='" & txtNoWa.Text & "'", Conn)
                    RD = cmd.ExecuteReader
                    RD.Read()
                    If RD.HasRows = True Then
                        MsgBox("Username atau No Wa Tidak boleh sama", MsgBoxStyle.Critical, "Data Dulpicat")

                    Else
                        Call KoneksiKeDatabase()
                        If RBLaki.Checked = True Then
                            gender = RBLaki.Text
                        ElseIf RBPerempuan.Checked = True Then
                            gender = RBPerempuan.Text
                        End If
                        Query = "INSERT INTO tbl_user values ('" & TxtUserID.Text & "','" & TxtNamaLengkap.Text & "','" & gender & "','" & TxtAlamat.Text & "','" & Format(DateTanggalLahir.Value, "yyyy-MM-dd") & "','" & TxtUsername.Text & "','" & TxtPassword.Text & "','" & CBLevel.Text & "','" & txtUsia.Text & "','" & txtNoWa.Text & "','-')"
                        daData = New MySqlDataAdapter(Query, Conn)
                        dsData = New DataSet
                        daData.Fill(dsData)
                        MsgBox("Input data berhasil")
                        BtnHapus.Visible = True
                        ListView1.Enabled = True
                        Call KondisiAwal()
                        Call KosongkanData()
                    End If



                End If
            End If
        Catch ex As Exception
            MsgBox("Tidak berhasil tambah data")
        End Try
    End Sub

    Private Sub DateTanggalLahir_ValueChanged(sender As Object, e As EventArgs) Handles DateTanggalLahir.ValueChanged
        txtUsia.Text = calculateAge(DateTanggalLahir.Value, Now)
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If BtnEdit.Text = "CLEAR" Then
            TxtNamaLengkap.Text = ""
            TxtAlamat.Text = ""
            TxtPassword.Text = ""
            TxtUsername.Text = ""
            CBLevel.Text = ""
            RBLaki.Checked = False
            RBPerempuan.Checked = False
            DateTanggalLahir.Value = Today
            TxtNamaLengkap.Focus()
            Exit Sub
        End If

        If BtnEdit.Text = "EDIT" Then
            BtnEdit.Text = "UPDATE"

            FieldAktif()
            BtnHapus.Enabled = False
        Else
            Try
                Call KoneksiKeDatabase()
                Query = "UPDATE tbl_user SET nama_lengkap='" & TxtNamaLengkap.Text & "',jenis_kelamin='" & gender & "',alamat='" & TxtAlamat.Text & "',tanggal_lahir='" & Format(DateTanggalLahir.Value, "yyyy-MM-dd") & "',user_name='" & TxtUsername.Text & "',pwd='" & TxtPassword.Text & "',lvl='" & CBLevel.Text & "',usia='" & txtUsia.Text & "',no_hp='" & txtNoWa.Text & "',c='-'where id_user='" & TxtUserID.Text & "'"
                daData = New MySqlDataAdapter(Query, Conn)
                dsData = New DataSet
                daData.Fill(dsData)
                MsgBox("Edit data berhasil")
                ListView1.Enabled = True
                Call KondisiAwal()
            Catch ex As Exception
                MsgBox("Username sudah tersedia")
                CBLevel.Items.Clear()
                FormTambahUser_Load(sender, e)
                BtnHapus.Visible = True
                KondisiAwal()
                ListView1.Enabled = True
            End Try


        End If


    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If BtnHapus.Text = "HAPUS" Then
            BtnHapus.Text = "DELETE"
            BtnEdit.Enabled = False
            BtnTambah.Enabled = False
            BtnTutup.Text = "BATAL"
            ListView1.Enabled = False
            TxtUserID.Enabled = False
            TxtNamaLengkap.Enabled = False
            TxtAlamat.Enabled = False
            TxtUsername.Enabled = False
            TxtPassword.Enabled = False
            RBLaki.Enabled = False
            RBPerempuan.Enabled = False
            CBLevel.Enabled = False

        Else
            If TxtUserID.Text = "" Then
                MsgBox("Silahkan isi ID untuk hapus data")
            Else
                Call KoneksiKeDatabase()
                Dim HapusData As String = "delete from tbl_user where id_user='" & TxtUserID.Text & "'"
                cmd = New MySqlCommand(HapusData, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Hapus data berhasil")
                ListView1.Enabled = True
                Call KondisiAwal()
            End If
        End If
    End Sub
    Private Sub AmbilDatadariListView()
        With ListView1.SelectedItems
            'If BtnEdit.Text = "CLEAR" Then
            '    TxtNamaLengkap.Text = ""
            '    TxtAlamat.Text = ""
            '    TxtPassword.Text = ""
            '    TxtUsername.Text = ""
            '    CBLevel.Text = ""
            '    RBLaki.Checked = False
            '    RBPerempuan.Checked = False
            '    DateTanggalLahir.Value = Today
            '    TxtNamaLengkap.Focus()
            '    Exit Sub
            'End If


            BtnEdit.Enabled = True
            BtnHapus.Enabled = True
            BtnTambah.Enabled = False
            BtnTutup.Text = "BATAL"

            TxtUserID.Focus()

            idNilai = .Item(0).SubItems(0).Text
            TxtUserID.Text = idNilai
            TxtNamaLengkap.Text = .Item(0).SubItems(1).Text
            gender = .Item(0).SubItems(2).Text
            If gender = RBLaki.Text Then
                RBLaki.Checked = True
            ElseIf gender = RBPerempuan.Text Then
                RBPerempuan.Checked = True
            Else
                RBLaki.Checked = False
                RBPerempuan.Checked = False
            End If
            TxtAlamat.Text = .Item(0).SubItems(3).Text
            DateTanggalLahir.Text = .Item(0).SubItems(4).Text
            txtNoWa.Text = .Item(0).SubItems(6).Text
            TxtUsername.Text = .Item(0).SubItems(7).Text
            TxtPassword.Text = .Item(0).SubItems(8).Text
            CBLevel.Text = .Item(0).SubItems(9).Text

            TxtUserID.Enabled = False
            TxtNamaLengkap.Enabled = False
            TxtAlamat.Enabled = False
            RBLaki.Enabled = False
            RBPerempuan.Enabled = False
            DateTanggalLahir.Enabled = False
            TxtUsername.Enabled = False
            TxtPassword.Enabled = False
            txtUsia.Enabled = False
            txtNoWa.Enabled = False
            CBLevel.Enabled = False
        End With

    End Sub

    Private Sub LblKode_Click(sender As Object, e As EventArgs) Handles LblKode.Click
        Caridata()
    End Sub
    Private Sub aturListView()
        'DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'DataGridView1.EnableHeadersVisualStyles = False
        'DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue
        'DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        'DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font(DataGridView.DefaultFont, FontStyle.Bold)
        'DataGridView1.DefaultCellStyle.ForeColor = Color.DarkRed
        'DataGridView1.RowsDefaultCellStyle.BackColor = Color.SkyBlue
        'DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Wheat
        'DataGridView1.GridColor = Color.DarkRed
        'ListView1.Items.Item(1).Font.Bold
        ListView1.BackColor = Color.SkyBlue
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        AmbilDatadariListView()
        ListView1.Enabled = False

    End Sub


    Private Sub txtNoWa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoWa.KeyPress
        If Not Char.IsDigit(CChar(CStr(e.KeyChar))) Or txtNoWa.Text.Length >= 15 Then e.Handled = True
        If e.KeyChar = ChrW(Keys.Back) Then e.Handled = False
    End Sub

    Private Sub Caridata()
        Dim a As Integer
        Try
            Call KoneksiKeDatabase()
            Query = "SELECT * FROM tbl_user WHERE user_name LIKE '%" & Trim(txtCari.Text) & "%' OR nama_lengkap LIKE '%" & Trim(txtCari.Text) & "%'"
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
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(8))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(9))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(5))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(6))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(7))
                End With
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged

    End Sub

    Private Sub txtNoWa_TextChanged(sender As Object, e As EventArgs) Handles txtNoWa.TextChanged

    End Sub

    Private Sub TxtUserID_TextChanged(sender As Object, e As EventArgs) Handles TxtUserID.TextChanged

    End Sub
End Class