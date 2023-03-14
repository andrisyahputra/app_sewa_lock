Imports MySql.Data.MySqlClient

Public Class FormUnit
    Private Sub btnJamLock_Click(sender As Object, e As EventArgs) Handles btnUnit.Click
        FormTambahUnit.ShowDialog()
    End Sub
    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        'FormMenu.PanelAkses.Visible = True
        Me.Close()
    End Sub

    Private Sub AturGridUnit()
        DataGridUnit.Columns(0).Width = 120
        DataGridUnit.Columns(1).Width = 300
        DataGridUnit.Columns(2).Width = 300
        DataGridUnit.Columns(3).Width = 150
        DataGridUnit.Columns(0).DataPropertyName = "id_unit"
        DataGridUnit.Columns(1).DataPropertyName = "nama_unit"
        DataGridUnit.Columns(2).DataPropertyName = "alamat_unit"
        DataGridUnit.Columns(3).DataPropertyName = "type_unit"
        DataGridUnit.Columns(0).HeaderText = "ID UNIT"
        DataGridUnit.Columns(1).HeaderText = "NAMA UNIT"
        DataGridUnit.Columns(2).HeaderText = "ALAMAT"
        DataGridUnit.Columns(3).HeaderText = "TIPE UNIT"
        DataGridUnit.Columns(4).Visible = False
        DataGridUnit.Columns(5).Visible = False
        DataGridUnit.Columns(6).Visible = False
        DataGridUnit.Columns(7).Visible = False
        DataGridUnit.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridUnit.EnableHeadersVisualStyles = False
        DataGridUnit.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue
        DataGridUnit.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        DataGridUnit.ColumnHeadersDefaultCellStyle.Font = New Font(DataGridView.DefaultFont, FontStyle.Bold)
        DataGridUnit.DefaultCellStyle.ForeColor = Color.DarkRed
        DataGridUnit.RowsDefaultCellStyle.BackColor = Color.SkyBlue
        DataGridUnit.AlternatingRowsDefaultCellStyle.BackColor = Color.Wheat
        DataGridUnit.GridColor = Color.DarkRed
    End Sub
    Private Sub tableUnit()
        Try
            'AturGridUnit()
            Query = "Select * FROM tbl_unit ORDER BY id_unit"
            daData = New MySqlDataAdapter(Query, Conn)
            dsData = New DataSet
            daData.Fill(dsData, "tbl_unit")
            DataGridUnit.DataSource = dsData.Tables("tbl_unit")
        Catch ex As Exception
            MsgBox("Gagal tampil data unit")

        End Try
    End Sub
    Private Sub AturGridAdaKamar()
        DataGridAdaKamar.Columns(0).Width = 70
        DataGridAdaKamar.Columns(1).Width = 150
        DataGridAdaKamar.Columns(2).Width = 70
        DataGridAdaKamar.Columns(3).Width = 250
        DataGridAdaKamar.Columns(4).Width = 150
        DataGridAdaKamar.Columns(5).Width = 100
        DataGridAdaKamar.Columns(6).Width = 95
        DataGridAdaKamar.Columns(0).DataPropertyName = "id_kamar"
        DataGridAdaKamar.Columns(1).DataPropertyName = "kamar"
        DataGridAdaKamar.Columns(2).DataPropertyName = "id_unit"
        DataGridAdaKamar.Columns(3).DataPropertyName = "nama_unit"
        DataGridAdaKamar.Columns(4).DataPropertyName = "harga_bulanan"
        DataGridAdaKamar.Columns(5).DataPropertyName = "harga_tahunan"
        DataGridAdaKamar.Columns(6).DataPropertyName = "sts"
        DataGridAdaKamar.Columns(0).HeaderText = "ID KAMAR"
        DataGridAdaKamar.Columns(1).HeaderText = "KAMAR"
        DataGridAdaKamar.Columns(2).HeaderText = "ID UNIT"
        DataGridAdaKamar.Columns(3).HeaderText = "NAMA UNIT"
        DataGridAdaKamar.Columns(4).HeaderText = "HARGA TAHUNAN"
        DataGridAdaKamar.Columns(5).HeaderText = "HARGA BULANAN"
        DataGridAdaKamar.Columns(6).HeaderText = "STATUS"
        DataGridAdaKamar.Columns(7).Visible = False
        DataGridAdaKamar.Columns(8).Visible = False
        DataGridAdaKamar.Columns(9).Visible = False
        DataGridAdaKamar.Columns(10).Visible = False

        DataGridAdaKamar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridAdaKamar.EnableHeadersVisualStyles = False
        DataGridAdaKamar.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue
        DataGridAdaKamar.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        DataGridAdaKamar.ColumnHeadersDefaultCellStyle.Font = New Font(DataGridView.DefaultFont, FontStyle.Bold)
        DataGridAdaKamar.DefaultCellStyle.ForeColor = Color.DarkRed
        DataGridAdaKamar.GridColor = Color.DarkRed
        DataGridAdaKamar.RowsDefaultCellStyle.BackColor = Color.Lime
    End Sub
    Private Sub AturGridPenuhKamar()

        With DataGridPenuhKamar
            .Columns(0).Width = 70
            .Columns(1).Width = 150
            .Columns(2).Width = 70
            .Columns(3).Width = 250
            .Columns(4).Width = 150
            .Columns(5).Width = 100
            .Columns(6).Width = 95
            .Columns(0).DataPropertyName = "id_kamar"
            .Columns(1).DataPropertyName = "kamar"
            .Columns(2).DataPropertyName = "id_unit"
            .Columns(3).DataPropertyName = "nama_unit"
            .Columns(4).DataPropertyName = "harga_bulanan"
            .Columns(5).DataPropertyName = "harga_tahunan"
            .Columns(6).DataPropertyName = "sts"
            .Columns(0).HeaderText = "ID KAMAR"
            .Columns(1).HeaderText = "KAMAR"
            .Columns(2).HeaderText = "ID UNIT"
            .Columns(3).HeaderText = "NAMA UNIT"
            .Columns(4).HeaderText = "HARGA TAHUNAN"
            .Columns(5).HeaderText = "HARGA BULANAN"
            .Columns(6).HeaderText = "STATUS"
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            .Columns(10).Visible = False

            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.Blue
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font(DataGridView.DefaultFont, FontStyle.Bold)
            .DefaultCellStyle.ForeColor = Color.White
            .GridColor = Color.White
            .RowsDefaultCellStyle.BackColor = Color.Crimson
        End With
    End Sub

    Private Sub tablePenuhKamar()
        Try
            'AturGridKamar()
            'Query = "Select * FROM tbl_kamar ORDER BY id_kamar"
            Query = "Select * FROM tbl_kamar where sts='penuh'"
            daData = New MySqlDataAdapter(Query, Conn)
            dsData = New DataSet
            daData.Fill(dsData, "tbl_kamar")
            DataGridPenuhKamar.DataSource = dsData.Tables("tbl_kamar")
        Catch ex As Exception
            MsgBox("Gagal tampil data kamar")
        End Try
    End Sub

    Private Sub tableAdaKamar()
        Try
            'AturGridKamar()
            'Query = "Select * FROM tbl_kamar ORDER BY id_kamar"
            Query = "Select * FROM tbl_kamar where sts='ada' "
            daData = New MySqlDataAdapter(Query, Conn)
            dsData = New DataSet
            daData.Fill(dsData, "tbl_kamar")
            DataGridAdaKamar.DataSource = dsData.Tables("tbl_kamar")
        Catch ex As Exception
            MsgBox("Gagal tampil data kamar")
        End Try
    End Sub


    Public Sub FormUnit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KoneksiKeDatabase()
        tableUnit()
        tableAdaKamar()
        tablePenuhKamar()
        AturGridAdaKamar()
        AturGridUnit()
        AturGridPenuhKamar()
    End Sub

    Private Sub btnKamar_Click(sender As Object, e As EventArgs) Handles btnKamar.Click
        FormTambahKamar.ShowDialog()
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        FormTambahUser.ShowDialog()
    End Sub
End Class