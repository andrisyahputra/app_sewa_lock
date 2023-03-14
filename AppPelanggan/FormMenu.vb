

Public Class FormMenu

    Dim imgsetlock As Bitmap
    Dim imgdtunit As Bitmap
    Dim imghistory As Bitmap


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
        switchPanel(FormPelanggan)
    End Sub
    Private Sub btnUnit_Click(sender As Object, e As EventArgs) Handles btnUnit.Click
        'PanelAkses.Visible = False
        'FormUnit.ShowDialog()
        switchPanel(FormUnit)
    End Sub

    Private Sub btnJamLock_Click(sender As Object, e As EventArgs) Handles btnJamLock.Click
        'PanelAkses.Visible = False
        'FormUnit.ShowDialog()
        switchPanel(FormHistory)
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)
        Me.Close()
        FormLogin.Show()
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

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs)
        FormIDCard.ShowDialog()
    End Sub

    Private Sub txtJam_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class