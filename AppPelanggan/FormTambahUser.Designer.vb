<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTambahUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTambahUser))
        Me.LblKode = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtUserID = New System.Windows.Forms.TextBox()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.CBLevel = New System.Windows.Forms.ComboBox()
        Me.DateTanggalLahir = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBPerempuan = New System.Windows.Forms.RadioButton()
        Me.RBLaki = New System.Windows.Forms.RadioButton()
        Me.TxtAlamat = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TxtNamaLengkap = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNoWa = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtUsia = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblKode
        '
        Me.LblKode.BackColor = System.Drawing.Color.Transparent
        Me.LblKode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblKode.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKode.Image = Global.AppPelanggan.My.Resources.Resources.search
        Me.LblKode.Location = New System.Drawing.Point(390, 350)
        Me.LblKode.Name = "LblKode"
        Me.LblKode.Size = New System.Drawing.Size(40, 44)
        Me.LblKode.TabIndex = 41
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(387, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(0, 0)
        Me.Button1.TabIndex = 40
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TxtUserID
        '
        Me.TxtUserID.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUserID.Location = New System.Drawing.Point(251, 75)
        Me.TxtUserID.Name = "TxtUserID"
        Me.TxtUserID.Size = New System.Drawing.Size(131, 29)
        Me.TxtUserID.TabIndex = 39
        '
        'BtnTutup
        '
        Me.BtnTutup.BackColor = System.Drawing.Color.Navy
        Me.BtnTutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTutup.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.BtnTutup.ForeColor = System.Drawing.Color.White
        Me.BtnTutup.Location = New System.Drawing.Point(832, 358)
        Me.BtnTutup.Margin = New System.Windows.Forms.Padding(3, 10, 10, 3)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(109, 36)
        Me.BtnTutup.TabIndex = 34
        Me.BtnTutup.Text = "TUTUP"
        Me.BtnTutup.UseVisualStyleBackColor = False
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.Navy
        Me.BtnHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHapus.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.BtnHapus.ForeColor = System.Drawing.Color.White
        Me.BtnHapus.Location = New System.Drawing.Point(710, 358)
        Me.BtnHapus.Margin = New System.Windows.Forms.Padding(3, 10, 10, 3)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(109, 36)
        Me.BtnHapus.TabIndex = 35
        Me.BtnHapus.Text = "HAPUS"
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.Navy
        Me.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdit.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.BtnEdit.ForeColor = System.Drawing.Color.White
        Me.BtnEdit.Location = New System.Drawing.Point(588, 358)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(3, 10, 10, 3)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(109, 36)
        Me.BtnEdit.TabIndex = 37
        Me.BtnEdit.Text = "EDIT"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnTambah
        '
        Me.BtnTambah.BackColor = System.Drawing.Color.Navy
        Me.BtnTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambah.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.BtnTambah.ForeColor = System.Drawing.Color.White
        Me.BtnTambah.Location = New System.Drawing.Point(467, 358)
        Me.BtnTambah.Margin = New System.Windows.Forms.Padding(3, 10, 10, 3)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(109, 36)
        Me.BtnTambah.TabIndex = 36
        Me.BtnTambah.Text = "TAMBAH"
        Me.BtnTambah.UseVisualStyleBackColor = False
        '
        'CBLevel
        '
        Me.CBLevel.Font = New System.Drawing.Font("Times New Roman", 14.25!)
        Me.CBLevel.FormattingEnabled = True
        Me.CBLevel.Location = New System.Drawing.Point(667, 298)
        Me.CBLevel.Name = "CBLevel"
        Me.CBLevel.Size = New System.Drawing.Size(212, 29)
        Me.CBLevel.TabIndex = 33
        '
        'DateTanggalLahir
        '
        Me.DateTanggalLahir.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTanggalLahir.Font = New System.Drawing.Font("Times New Roman", 14.25!)
        Me.DateTanggalLahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTanggalLahir.Location = New System.Drawing.Point(249, 219)
        Me.DateTanggalLahir.Name = "DateTanggalLahir"
        Me.DateTanggalLahir.Size = New System.Drawing.Size(128, 29)
        Me.DateTanggalLahir.TabIndex = 32
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RBPerempuan)
        Me.GroupBox1.Controls.Add(Me.RBLaki)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(252, 164)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 46)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pilih"
        '
        'RBPerempuan
        '
        Me.RBPerempuan.AutoSize = True
        Me.RBPerempuan.Location = New System.Drawing.Point(133, 18)
        Me.RBPerempuan.Name = "RBPerempuan"
        Me.RBPerempuan.Size = New System.Drawing.Size(102, 22)
        Me.RBPerempuan.TabIndex = 0
        Me.RBPerempuan.TabStop = True
        Me.RBPerempuan.Text = "Perempuan"
        Me.RBPerempuan.UseVisualStyleBackColor = True
        '
        'RBLaki
        '
        Me.RBLaki.AutoSize = True
        Me.RBLaki.Location = New System.Drawing.Point(15, 18)
        Me.RBLaki.Name = "RBLaki"
        Me.RBLaki.Size = New System.Drawing.Size(84, 22)
        Me.RBLaki.TabIndex = 0
        Me.RBLaki.TabStop = True
        Me.RBLaki.Text = "Laki Laki"
        Me.RBLaki.UseVisualStyleBackColor = True
        '
        'TxtAlamat
        '
        Me.TxtAlamat.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAlamat.Location = New System.Drawing.Point(664, 106)
        Me.TxtAlamat.Multiline = True
        Me.TxtAlamat.Name = "TxtAlamat"
        Me.TxtAlamat.Size = New System.Drawing.Size(215, 57)
        Me.TxtAlamat.TabIndex = 30
        '
        'TxtPassword
        '
        Me.TxtPassword.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.Location = New System.Drawing.Point(664, 240)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(215, 29)
        Me.TxtPassword.TabIndex = 29
        '
        'TxtUsername
        '
        Me.TxtUsername.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsername.Location = New System.Drawing.Point(664, 181)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(215, 29)
        Me.TxtUsername.TabIndex = 28
        '
        'TxtNamaLengkap
        '
        Me.TxtNamaLengkap.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNamaLengkap.Location = New System.Drawing.Point(252, 120)
        Me.TxtNamaLengkap.Name = "TxtNamaLengkap"
        Me.TxtNamaLengkap.Size = New System.Drawing.Size(261, 29)
        Me.TxtNamaLengkap.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(528, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 33)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Alamat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(48, 214)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 33)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Tanggal Lahir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 33)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(528, 297)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 33)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Level"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(528, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 33)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 33)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "ID User"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(528, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 33)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 33)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nama Lengkap"
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(54, 405)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(887, 298)
        Me.ListView1.TabIndex = 42
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'txtCari
        '
        Me.txtCari.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.Location = New System.Drawing.Point(163, 363)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(207, 29)
        Me.txtCari.TabIndex = 44
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(53, 363)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 27)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Cari Data :"
        '
        'txtNoWa
        '
        Me.txtNoWa.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoWa.Location = New System.Drawing.Point(249, 296)
        Me.txtNoWa.Name = "txtNoWa"
        Me.txtNoWa.Size = New System.Drawing.Size(261, 29)
        Me.txtNoWa.TabIndex = 46
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(54, 290)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(145, 33)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Nomor WA"
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(423, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(153, 55)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "USER"
        '
        'txtUsia
        '
        Me.txtUsia.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsia.Location = New System.Drawing.Point(250, 261)
        Me.txtUsia.Name = "txtUsia"
        Me.txtUsia.Size = New System.Drawing.Size(261, 29)
        Me.txtUsia.TabIndex = 48
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(54, 254)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 33)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Usia"
        '
        'FormTambahUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(968, 713)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtUsia)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtNoWa)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.LblKode)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtUserID)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.CBLevel)
        Me.Controls.Add(Me.DateTanggalLahir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtAlamat)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.TxtNamaLengkap)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormTambahUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormTambahUser"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblKode As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtUserID As TextBox
    Friend WithEvents BtnTutup As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnTambah As Button
    Friend WithEvents CBLevel As ComboBox
    Friend WithEvents DateTanggalLahir As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RBPerempuan As RadioButton
    Friend WithEvents RBLaki As RadioButton
    Friend WithEvents TxtAlamat As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtNamaLengkap As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents txtCari As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNoWa As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtUsia As TextBox
    Friend WithEvents Label12 As Label
End Class
