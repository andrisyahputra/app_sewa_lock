<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPelanggan
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPelanggan))
        Me.btnLapor = New System.Windows.Forms.Label()
        Me.lvpelanggan = New System.Windows.Forms.ListView()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtHargaSw = New System.Windows.Forms.TextBox()
        Me.DateJTempo = New System.Windows.Forms.DateTimePicker()
        Me.txtTempo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKamar = New System.Windows.Forms.TextBox()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.CBIDUnit = New System.Windows.Forms.ComboBox()
        Me.DateKendaraan = New System.Windows.Forms.DateTimePicker()
        Me.DateBayar = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtKendaraa = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CBIDKamar = New System.Windows.Forms.ComboBox()
        Me.CBBayar = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtPembayaran = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtJam = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtKasir = New System.Windows.Forms.TextBox()
        Me.txtTanggal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblKode = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Label()
        Me.BtnEdit = New System.Windows.Forms.Label()
        Me.BtnTambah = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnJamLock = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Label()
        Me.Panel6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLapor
        '
        Me.btnLapor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLapor.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!)
        Me.btnLapor.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLapor.Image = Global.AppPelanggan.My.Resources.Resources.lapor
        Me.btnLapor.Location = New System.Drawing.Point(642, 429)
        Me.btnLapor.Name = "btnLapor"
        Me.btnLapor.Size = New System.Drawing.Size(69, 70)
        Me.btnLapor.TabIndex = 99
        Me.btnLapor.Text = "Microsoft Sans Serif; 1,5pt"
        '
        'lvpelanggan
        '
        Me.lvpelanggan.FullRowSelect = True
        Me.lvpelanggan.GridLines = True
        Me.lvpelanggan.HideSelection = False
        Me.lvpelanggan.Location = New System.Drawing.Point(35, 501)
        Me.lvpelanggan.MultiSelect = False
        Me.lvpelanggan.Name = "lvpelanggan"
        Me.lvpelanggan.Size = New System.Drawing.Size(961, 189)
        Me.lvpelanggan.TabIndex = 98
        Me.lvpelanggan.UseCompatibleStateImageBehavior = False
        Me.lvpelanggan.View = System.Windows.Forms.View.Details
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Navy
        Me.Panel6.Controls.Add(Me.GroupBox1)
        Me.Panel6.Controls.Add(Me.GroupBox2)
        Me.Panel6.Location = New System.Drawing.Point(35, 16)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(922, 409)
        Me.Panel6.TabIndex = 97
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Navy
        Me.GroupBox1.Controls.Add(Me.txtHargaSw)
        Me.GroupBox1.Controls.Add(Me.DateJTempo)
        Me.GroupBox1.Controls.Add(Me.txtTempo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtKamar)
        Me.GroupBox1.Controls.Add(Me.txtUnit)
        Me.GroupBox1.Controls.Add(Me.CBIDUnit)
        Me.GroupBox1.Controls.Add(Me.DateKendaraan)
        Me.GroupBox1.Controls.Add(Me.DateBayar)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtKendaraa)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.CBIDKamar)
        Me.GroupBox1.Controls.Add(Me.CBBayar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.txtNama)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 20.25!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(922, 333)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Pelanggan"
        '
        'txtHargaSw
        '
        Me.txtHargaSw.BackColor = System.Drawing.Color.Black
        Me.txtHargaSw.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHargaSw.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHargaSw.ForeColor = System.Drawing.Color.Orange
        Me.txtHargaSw.Location = New System.Drawing.Point(644, 246)
        Me.txtHargaSw.Multiline = True
        Me.txtHargaSw.Name = "txtHargaSw"
        Me.txtHargaSw.ReadOnly = True
        Me.txtHargaSw.Size = New System.Drawing.Size(195, 25)
        Me.txtHargaSw.TabIndex = 48
        Me.txtHargaSw.Text = "0"
        Me.txtHargaSw.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DateJTempo
        '
        Me.DateJTempo.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateJTempo.Font = New System.Drawing.Font("Times New Roman", 14.25!)
        Me.DateJTempo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateJTempo.Location = New System.Drawing.Point(697, 196)
        Me.DateJTempo.Name = "DateJTempo"
        Me.DateJTempo.Size = New System.Drawing.Size(142, 29)
        Me.DateJTempo.TabIndex = 95
        '
        'txtTempo
        '
        Me.txtTempo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTempo.Location = New System.Drawing.Point(644, 197)
        Me.txtTempo.Name = "txtTempo"
        Me.txtTempo.Size = New System.Drawing.Size(46, 25)
        Me.txtTempo.TabIndex = 94
        Me.txtTempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(423, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 27)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Tempo"
        '
        'txtKamar
        '
        Me.txtKamar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKamar.Location = New System.Drawing.Point(268, 211)
        Me.txtKamar.Name = "txtKamar"
        Me.txtKamar.Size = New System.Drawing.Size(120, 25)
        Me.txtKamar.TabIndex = 92
        '
        'txtUnit
        '
        Me.txtUnit.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.Location = New System.Drawing.Point(263, 160)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(125, 25)
        Me.txtUnit.TabIndex = 91
        '
        'CBIDUnit
        '
        Me.CBIDUnit.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.CBIDUnit.FormattingEnabled = True
        Me.CBIDUnit.Location = New System.Drawing.Point(190, 161)
        Me.CBIDUnit.Name = "CBIDUnit"
        Me.CBIDUnit.Size = New System.Drawing.Size(70, 25)
        Me.CBIDUnit.TabIndex = 88
        '
        'DateKendaraan
        '
        Me.DateKendaraan.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateKendaraan.Font = New System.Drawing.Font("Times New Roman", 14.25!)
        Me.DateKendaraan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateKendaraan.Location = New System.Drawing.Point(643, 75)
        Me.DateKendaraan.Name = "DateKendaraan"
        Me.DateKendaraan.Size = New System.Drawing.Size(195, 29)
        Me.DateKendaraan.TabIndex = 87
        '
        'DateBayar
        '
        Me.DateBayar.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateBayar.Font = New System.Drawing.Font("Times New Roman", 14.25!)
        Me.DateBayar.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateBayar.Location = New System.Drawing.Point(644, 158)
        Me.DateBayar.Name = "DateBayar"
        Me.DateBayar.Size = New System.Drawing.Size(195, 29)
        Me.DateBayar.TabIndex = 87
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(28, 162)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(101, 27)
        Me.Label17.TabIndex = 85
        Me.Label17.Text = "Tipe Unit"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(423, 244)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(127, 27)
        Me.Label16.TabIndex = 83
        Me.Label16.Text = "Harga Sewa"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(423, 120)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(118, 27)
        Me.Label15.TabIndex = 82
        Me.Label15.Text = "Tipe Bayar"
        '
        'txtKendaraa
        '
        Me.txtKendaraa.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKendaraa.Location = New System.Drawing.Point(191, 262)
        Me.txtKendaraa.Name = "txtKendaraa"
        Me.txtKendaraa.Size = New System.Drawing.Size(197, 25)
        Me.txtKendaraa.TabIndex = 77
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(423, 75)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(197, 27)
        Me.Label14.TabIndex = 75
        Me.Label14.Text = "Tanggal Kendaraan"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(33, 262)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(152, 27)
        Me.Label13.TabIndex = 74
        Me.Label13.Text = "No Kendaraan"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(423, 160)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(150, 27)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "Tanggal Bayar"
        '
        'CBIDKamar
        '
        Me.CBIDKamar.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.CBIDKamar.FormattingEnabled = True
        Me.CBIDKamar.Location = New System.Drawing.Point(191, 211)
        Me.CBIDKamar.Name = "CBIDKamar"
        Me.CBIDKamar.Size = New System.Drawing.Size(70, 25)
        Me.CBIDKamar.TabIndex = 71
        '
        'CBBayar
        '
        Me.CBBayar.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.CBBayar.FormattingEnabled = True
        Me.CBBayar.Location = New System.Drawing.Point(644, 120)
        Me.CBBayar.Name = "CBBayar"
        Me.CBBayar.Size = New System.Drawing.Size(195, 25)
        Me.CBBayar.TabIndex = 71
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 27)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Tipe Kamar"
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(189, 70)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(201, 25)
        Me.txtId.TabIndex = 69
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(187, 115)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(201, 25)
        Me.txtNama.TabIndex = 69
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 27)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "ID Pelanggan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 27)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Nama"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Navy
        Me.GroupBox2.Controls.Add(Me.txtPembayaran)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 20.25!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(0, 333)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(922, 76)
        Me.GroupBox2.TabIndex = 61
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Jumlah"
        '
        'txtPembayaran
        '
        Me.txtPembayaran.BackColor = System.Drawing.Color.Black
        Me.txtPembayaran.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPembayaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPembayaran.ForeColor = System.Drawing.Color.Lime
        Me.txtPembayaran.Location = New System.Drawing.Point(575, 19)
        Me.txtPembayaran.Name = "txtPembayaran"
        Me.txtPembayaran.ReadOnly = True
        Me.txtPembayaran.Size = New System.Drawing.Size(314, 37)
        Me.txtPembayaran.TabIndex = 47
        Me.txtPembayaran.Text = "0"
        Me.txtPembayaran.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(437, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 27)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Pembayaran"
        '
        'txtJam
        '
        Me.txtJam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJam.Enabled = False
        Me.txtJam.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJam.Location = New System.Drawing.Point(86, 705)
        Me.txtJam.Name = "txtJam"
        Me.txtJam.ReadOnly = True
        Me.txtJam.Size = New System.Drawing.Size(128, 32)
        Me.txtJam.TabIndex = 90
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(30, 705)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 27)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Jam"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(507, 710)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 27)
        Me.Label10.TabIndex = 86
        Me.Label10.Text = "Kasir"
        '
        'txtKasir
        '
        Me.txtKasir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKasir.Enabled = False
        Me.txtKasir.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        Me.txtKasir.Location = New System.Drawing.Point(577, 705)
        Me.txtKasir.Name = "txtKasir"
        Me.txtKasir.ReadOnly = True
        Me.txtKasir.Size = New System.Drawing.Size(184, 32)
        Me.txtKasir.TabIndex = 87
        Me.txtKasir.Text = "."
        '
        'txtTanggal
        '
        Me.txtTanggal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTanggal.Enabled = False
        Me.txtTanggal.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTanggal.Location = New System.Drawing.Point(305, 705)
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.ReadOnly = True
        Me.txtTanggal.Size = New System.Drawing.Size(201, 32)
        Me.txtTanggal.TabIndex = 88
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(220, 710)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 27)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "Tanggal"
        '
        'txtCari
        '
        Me.txtCari.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.Location = New System.Drawing.Point(188, 452)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(347, 29)
        Me.txtCari.TabIndex = 96
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(65, 454)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 27)
        Me.Label9.TabIndex = 95
        Me.Label9.Text = "Cari Data :"
        '
        'LblKode
        '
        Me.LblKode.BackColor = System.Drawing.Color.Transparent
        Me.LblKode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblKode.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKode.Image = Global.AppPelanggan.My.Resources.Resources.search
        Me.LblKode.Location = New System.Drawing.Point(564, 445)
        Me.LblKode.Name = "LblKode"
        Me.LblKode.Size = New System.Drawing.Size(40, 44)
        Me.LblKode.TabIndex = 94
        '
        'btnHapus
        '
        Me.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!)
        Me.btnHapus.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnHapus.Image = Global.AppPelanggan.My.Resources.Resources.sampah
        Me.btnHapus.Location = New System.Drawing.Point(914, 429)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(69, 70)
        Me.btnHapus.TabIndex = 93
        '
        'BtnEdit
        '
        Me.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnEdit.Image = Global.AppPelanggan.My.Resources.Resources.update
        Me.BtnEdit.Location = New System.Drawing.Point(824, 429)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(69, 70)
        Me.BtnEdit.TabIndex = 92
        '
        'BtnTambah
        '
        Me.BtnTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!)
        Me.BtnTambah.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnTambah.Image = Global.AppPelanggan.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_7_Save_256
        Me.BtnTambah.Location = New System.Drawing.Point(731, 429)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(69, 70)
        Me.BtnTambah.TabIndex = 91
        '
        'Timer1
        '
        '
        'btnJamLock
        '
        Me.btnJamLock.BackColor = System.Drawing.Color.Navy
        Me.btnJamLock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnJamLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJamLock.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJamLock.ForeColor = System.Drawing.Color.White
        Me.btnJamLock.Image = Global.AppPelanggan.My.Resources.Resources.setlock
        Me.btnJamLock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnJamLock.Location = New System.Drawing.Point(777, 700)
        Me.btnJamLock.Margin = New System.Windows.Forms.Padding(30, 3, 3, 3)
        Me.btnJamLock.Name = "btnJamLock"
        Me.btnJamLock.Size = New System.Drawing.Size(222, 40)
        Me.btnJamLock.TabIndex = 101
        Me.btnJamLock.Text = "SET ID CARD"
        Me.btnJamLock.UseVisualStyleBackColor = False
        '
        'btnTutup
        '
        Me.btnTutup.BackColor = System.Drawing.Color.Transparent
        Me.btnTutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTutup.Image = Global.AppPelanggan.My.Resources.Resources.close
        Me.btnTutup.Location = New System.Drawing.Point(963, 3)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(50, 39)
        Me.btnTutup.TabIndex = 100
        '
        'FormPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1016, 749)
        Me.Controls.Add(Me.txtJam)
        Me.Controls.Add(Me.btnJamLock)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLapor)
        Me.Controls.Add(Me.lvpelanggan)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.txtKasir)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.txtTanggal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LblKode)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnTambah)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormPelanggan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Menu"
        Me.Panel6.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLapor As Label
    Friend WithEvents lvpelanggan As ListView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtJam As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtKamar As TextBox
    Friend WithEvents txtUnit As TextBox
    Friend WithEvents CBIDUnit As ComboBox
    Friend WithEvents DateKendaraan As DateTimePicker
    Friend WithEvents DateBayar As DateTimePicker
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtKendaraa As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents CBIDKamar As ComboBox
    Friend WithEvents CBBayar As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtKasir As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtPembayaran As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTanggal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents LblKode As Label
    Friend WithEvents btnHapus As Label
    Friend WithEvents BtnEdit As Label
    Friend WithEvents BtnTambah As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnJamLock As Button
    Friend WithEvents txtTempo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnTutup As Label
    Friend WithEvents DateJTempo As DateTimePicker
    Friend WithEvents txtHargaSw As TextBox
End Class
