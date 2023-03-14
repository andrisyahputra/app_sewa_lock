<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTambahKamar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTambahKamar))
        Me.BtnTutup = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Label()
        Me.BtnEdit = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblKode = New System.Windows.Forms.Label()
        Me.BtnTambah = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHTahunan = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtNKamar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBIDUnit = New System.Windows.Forms.ComboBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.txtNUnit = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtHBulanan = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnTutup
        '
        Me.BtnTutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTutup.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!)
        Me.BtnTutup.ForeColor = System.Drawing.Color.YellowGreen
        Me.BtnTutup.Image = Global.AppPelanggan.My.Resources.Resources.home
        Me.BtnTutup.Location = New System.Drawing.Point(415, 312)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.BtnTutup.Size = New System.Drawing.Size(69, 70)
        Me.BtnTutup.TabIndex = 10
        '
        'btnHapus
        '
        Me.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!)
        Me.btnHapus.ForeColor = System.Drawing.Color.YellowGreen
        Me.btnHapus.Image = Global.AppPelanggan.My.Resources.Resources.sampah
        Me.btnHapus.Location = New System.Drawing.Point(326, 312)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.btnHapus.Size = New System.Drawing.Size(69, 70)
        Me.btnHapus.TabIndex = 9
        '
        'BtnEdit
        '
        Me.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!)
        Me.BtnEdit.ForeColor = System.Drawing.Color.YellowGreen
        Me.BtnEdit.Image = Global.AppPelanggan.My.Resources.Resources.update
        Me.BtnEdit.Location = New System.Drawing.Point(236, 312)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.BtnEdit.Size = New System.Drawing.Size(69, 70)
        Me.BtnEdit.TabIndex = 8
        '
        'txtCari
        '
        Me.txtCari.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.Location = New System.Drawing.Point(192, 380)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(299, 29)
        Me.txtCari.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(69, 382)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 27)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "Cari Data :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LawnGreen
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(636, 62)
        Me.Panel1.TabIndex = 66
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(211, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(212, 55)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "KAMAR"
        '
        'LblKode
        '
        Me.LblKode.BackColor = System.Drawing.Color.Transparent
        Me.LblKode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblKode.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKode.Image = Global.AppPelanggan.My.Resources.Resources.search
        Me.LblKode.Location = New System.Drawing.Point(497, 373)
        Me.LblKode.Name = "LblKode"
        Me.LblKode.Size = New System.Drawing.Size(40, 44)
        Me.LblKode.TabIndex = 65
        '
        'BtnTambah
        '
        Me.BtnTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!)
        Me.BtnTambah.ForeColor = System.Drawing.Color.YellowGreen
        Me.BtnTambah.Image = Global.AppPelanggan.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_7_Save_256
        Me.BtnTambah.Location = New System.Drawing.Point(143, 312)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.BtnTambah.Size = New System.Drawing.Size(69, 70)
        Me.BtnTambah.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(71, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 33)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Harga bulanan"
        '
        'txtHTahunan
        '
        Me.txtHTahunan.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHTahunan.Location = New System.Drawing.Point(260, 248)
        Me.txtHTahunan.Name = "txtHTahunan"
        Me.txtHTahunan.Size = New System.Drawing.Size(261, 29)
        Me.txtHTahunan.TabIndex = 6
        Me.txtHTahunan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(365, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(0, 0)
        Me.Button1.TabIndex = 61
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(259, 69)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(131, 29)
        Me.txtID.TabIndex = 1
        '
        'txtNKamar
        '
        Me.txtNKamar.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNKamar.Location = New System.Drawing.Point(259, 178)
        Me.txtNKamar.Name = "txtNKamar"
        Me.txtNKamar.Size = New System.Drawing.Size(261, 29)
        Me.txtNKamar.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(73, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 33)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "ID Kamar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(72, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 33)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Harga Tahunan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(71, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 33)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Nama Kamar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(72, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 33)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "ID Unit"
        '
        'CBIDUnit
        '
        Me.CBIDUnit.Font = New System.Drawing.Font("Times New Roman", 14.25!)
        Me.CBIDUnit.FormattingEnabled = True
        Me.CBIDUnit.Location = New System.Drawing.Point(260, 108)
        Me.CBIDUnit.Name = "CBIDUnit"
        Me.CBIDUnit.Size = New System.Drawing.Size(131, 29)
        Me.CBIDUnit.TabIndex = 2
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 433)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(612, 248)
        Me.ListView1.TabIndex = 75
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'txtNUnit
        '
        Me.txtNUnit.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNUnit.Location = New System.Drawing.Point(260, 143)
        Me.txtNUnit.Name = "txtNUnit"
        Me.txtNUnit.Size = New System.Drawing.Size(260, 29)
        Me.txtNUnit.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(72, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 33)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Nama Unit"
        '
        'txtHBulanan
        '
        Me.txtHBulanan.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHBulanan.Location = New System.Drawing.Point(259, 213)
        Me.txtHBulanan.Name = "txtHBulanan"
        Me.txtHBulanan.Size = New System.Drawing.Size(261, 29)
        Me.txtHBulanan.TabIndex = 5
        Me.txtHBulanan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FormTambahKamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(636, 686)
        Me.Controls.Add(Me.txtHBulanan)
        Me.Controls.Add(Me.txtNUnit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.CBIDUnit)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblKode)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtHTahunan)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtNKamar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormTambahKamar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormTambahKamar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnTutup As Label
    Friend WithEvents btnHapus As Label
    Friend WithEvents BtnEdit As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents LblKode As Label
    Friend WithEvents BtnTambah As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHTahunan As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNKamar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CBIDUnit As ComboBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents txtNUnit As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtHBulanan As TextBox
End Class
