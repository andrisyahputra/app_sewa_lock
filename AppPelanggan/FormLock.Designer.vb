<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLock
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLock))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.jamTutup = New System.Windows.Forms.DateTimePicker()
        Me.BtnEdit = New System.Windows.Forms.Label()
        Me.BtnTambah = New System.Windows.Forms.Label()
        Me.jamBuka = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtKendaraan = New System.Windows.Forms.TextBox()
        Me.txtIDcard = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.CBIDP = New System.Windows.Forms.ComboBox()
        Me.btnHapus = New System.Windows.Forms.Label()
        Me.BtnTutup = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblKode = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(45, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 23)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "BUKA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(45, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 23)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "TUTUP"
        '
        'jamTutup
        '
        Me.jamTutup.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jamTutup.CustomFormat = "HH:mm"
        Me.jamTutup.Font = New System.Drawing.Font("Times New Roman", 14.25!)
        Me.jamTutup.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.jamTutup.Location = New System.Drawing.Point(227, 262)
        Me.jamTutup.Name = "jamTutup"
        Me.jamTutup.Size = New System.Drawing.Size(128, 29)
        Me.jamTutup.TabIndex = 41
        Me.jamTutup.Value = New Date(2023, 3, 1, 23, 0, 0, 0)
        '
        'BtnEdit
        '
        Me.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!)
        Me.BtnEdit.ForeColor = System.Drawing.Color.Black
        Me.BtnEdit.Image = Global.AppPelanggan.My.Resources.Resources.update
        Me.BtnEdit.Location = New System.Drawing.Point(177, 304)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(69, 70)
        Me.BtnEdit.TabIndex = 56
        '
        'BtnTambah
        '
        Me.BtnTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.ForeColor = System.Drawing.Color.Black
        Me.BtnTambah.Image = Global.AppPelanggan.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_7_Save_256
        Me.BtnTambah.Location = New System.Drawing.Point(63, 308)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(69, 58)
        Me.BtnTambah.TabIndex = 55
        '
        'jamBuka
        '
        Me.jamBuka.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jamBuka.CustomFormat = "HH:mm"
        Me.jamBuka.Font = New System.Drawing.Font("Times New Roman", 14.25!)
        Me.jamBuka.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.jamBuka.Location = New System.Drawing.Point(227, 224)
        Me.jamBuka.Name = "jamBuka"
        Me.jamBuka.Size = New System.Drawing.Size(128, 29)
        Me.jamBuka.TabIndex = 41
        Me.jamBuka.Value = New Date(2023, 3, 1, 8, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(45, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 23)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "ID CARD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(45, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 23)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Nama Pelanggan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(45, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 23)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "ID Kendaraan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(45, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 23)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "ID Card"
        '
        'txtKendaraan
        '
        Me.txtKendaraan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtKendaraan.Location = New System.Drawing.Point(227, 153)
        Me.txtKendaraan.Name = "txtKendaraan"
        Me.txtKendaraan.Size = New System.Drawing.Size(241, 24)
        Me.txtKendaraan.TabIndex = 60
        '
        'txtIDcard
        '
        Me.txtIDcard.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtIDcard.Location = New System.Drawing.Point(228, 79)
        Me.txtIDcard.Name = "txtIDcard"
        Me.txtIDcard.Size = New System.Drawing.Size(241, 24)
        Me.txtIDcard.TabIndex = 60
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtNama.Location = New System.Drawing.Point(316, 117)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(152, 24)
        Me.txtNama.TabIndex = 60
        '
        'CBIDP
        '
        Me.CBIDP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.CBIDP.FormattingEnabled = True
        Me.CBIDP.Location = New System.Drawing.Point(227, 116)
        Me.CBIDP.Name = "CBIDP"
        Me.CBIDP.Size = New System.Drawing.Size(83, 26)
        Me.CBIDP.TabIndex = 61
        '
        'btnHapus
        '
        Me.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!)
        Me.btnHapus.ForeColor = System.Drawing.Color.Black
        Me.btnHapus.Image = Global.AppPelanggan.My.Resources.Resources.sampah
        Me.btnHapus.Location = New System.Drawing.Point(292, 306)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.btnHapus.Size = New System.Drawing.Size(69, 70)
        Me.btnHapus.TabIndex = 62
        '
        'BtnTutup
        '
        Me.BtnTutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTutup.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!)
        Me.BtnTutup.ForeColor = System.Drawing.Color.Black
        Me.BtnTutup.Image = Global.AppPelanggan.My.Resources.Resources.home
        Me.BtnTutup.Location = New System.Drawing.Point(400, 306)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.BtnTutup.Size = New System.Drawing.Size(69, 68)
        Me.BtnTutup.TabIndex = 63
        '
        'txtCari
        '
        Me.txtCari.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.Location = New System.Drawing.Point(142, 377)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(304, 26)
        Me.txtCari.TabIndex = 68
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(18, 376)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 23)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "Cari Data :"
        '
        'LblKode
        '
        Me.LblKode.BackColor = System.Drawing.Color.Transparent
        Me.LblKode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblKode.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKode.Image = Global.AppPelanggan.My.Resources.Resources.search
        Me.LblKode.Location = New System.Drawing.Point(462, 366)
        Me.LblKode.Name = "LblKode"
        Me.LblKode.Size = New System.Drawing.Size(40, 44)
        Me.LblKode.TabIndex = 69
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(518, 62)
        Me.Panel1.TabIndex = 71
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(86, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(332, 55)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "SET ID CARD"
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 409)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(480, 170)
        Me.ListView1.TabIndex = 90
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'FormLock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(518, 591)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LblKode)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.CBIDP)
        Me.Controls.Add(Me.txtIDcard)
        Me.Controls.Add(Me.txtKendaraan)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.jamBuka)
        Me.Controls.Add(Me.jamTutup)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormLock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormJamLock"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents jamTutup As DateTimePicker
    Friend WithEvents BtnEdit As Label
    Friend WithEvents BtnTambah As Label
    Friend WithEvents jamBuka As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtKendaraan As TextBox
    Friend WithEvents txtIDcard As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents CBIDP As ComboBox
    Friend WithEvents btnHapus As Label
    Friend WithEvents BtnTutup As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents LblKode As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents ListView1 As ListView
End Class
