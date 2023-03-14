Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FormLaporPerbulan
    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()


    End Sub
    Private Sub FormLaporPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        CrystalReportViewer1.BackColor = Color.White
        btnView_Click(sender, e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Try
            Dim cryrpt As New ReportDocument
            Dim crtablelogoninfos As New TableLogOnInfos
            Dim crtablelogoninfo As New TableLogOnInfo
            Dim crconnectioninfo As New ConnectionInfo
            Dim crtables As Tables
            Dim crtable As Table
            Dim laporan As New LaporPerbulan '<== nama file laporan crystal report
            cryrpt = laporan
            With crconnectioninfo
                .ServerName = "app_pelanggan"
                .DatabaseName = "app_pelanggan"
                .UserID = ""
                .Password = ""
            End With
            crtables = cryrpt.Database.Tables
            For Each crtable In crtables
                crtablelogoninfo = crtable.LogOnInfo
                crtablelogoninfo.ConnectionInfo = crconnectioninfo
                crtable.ApplyLogOnInfo(crtablelogoninfo)
            Next
            CrystalReportViewer1.SelectionFormula = "Month({relasipelanggan1.tgl_bayar})=" & Val(ComboBox1.Text) & " and year({relasipelanggan1.tgl_bayar})=" & Val(ComboBox2.Text)
            CrystalReportViewer1.ReportSource = cryrpt
            CrystalReportViewer1.Refresh()
            CrystalReportViewer1.RefreshReport()



        Catch ex As Exception
            MsgBox("Gagal Tampil Print")
        End Try
    End Sub

    Private Sub btnP_Click(sender As Object, e As EventArgs) Handles btnP.Click
        CrystalReportViewer1.PrintReport()
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        CrystalReportViewer1.ExportReport()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FormLaporPertahun.ShowDialog()
    End Sub
End Class