Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FormLaporPertahun
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Try
            Dim cryrpt As New ReportDocument
            Dim crtablelogoninfos As New TableLogOnInfos
            Dim crtablelogoninfo As New TableLogOnInfo
            Dim crconnectioninfo As New ConnectionInfo
            Dim crtables As Tables
            Dim crtable As Table
            Dim laporan As New LaporPertahun '<== nama file laporan crystal report
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
            CrystalReportViewer1.SelectionFormula = "year({relasipelanggan1.tgl_bayar})=" & Val(ComboBox1.Text)
            CrystalReportViewer1.ReportSource = cryrpt
            CrystalReportViewer1.Refresh()
            CrystalReportViewer1.RefreshReport()



        Catch ex As Exception
            MsgBox("Gagal Tampil Print")
        End Try
    End Sub

    Private Sub FormLaporPertahun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        CrystalReportViewer1.BackColor = Color.White
        btnView_Click(sender, e)
    End Sub

    Private Sub btnP_Click(sender As Object, e As EventArgs) Handles btnP.Click
        CrystalReportViewer1.PrintReport()
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        CrystalReportViewer1.ExportReport()
    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class