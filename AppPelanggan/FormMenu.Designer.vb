<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnPelanggan = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl_level = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbl_nama = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnJamLock = New System.Windows.Forms.Button()
        Me.btnUnit = New System.Windows.Forms.Button()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnTutup = New System.Windows.Forms.Label()
        Me.PanelAkses = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridHistory = New System.Windows.Forms.DataGridView()
        Me.lblTutup = New System.Windows.Forms.Label()
        Me.txtJam = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.PanelAkses.SuspendLayout()
        CType(Me.DataGridHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel3.Controls.Add(Me.btnPelanggan)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.btnJamLock)
        Me.Panel3.Controls.Add(Me.btnUnit)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(366, 749)
        Me.Panel3.TabIndex = 5
        '
        'btnPelanggan
        '
        Me.btnPelanggan.BackColor = System.Drawing.Color.Navy
        Me.btnPelanggan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPelanggan.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPelanggan.ForeColor = System.Drawing.Color.White
        Me.btnPelanggan.Image = Global.AppPelanggan.My.Resources.Resources.user
        Me.btnPelanggan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPelanggan.Location = New System.Drawing.Point(12, 287)
        Me.btnPelanggan.Name = "btnPelanggan"
        Me.btnPelanggan.Size = New System.Drawing.Size(336, 63)
        Me.btnPelanggan.TabIndex = 8
        Me.btnPelanggan.Text = "DATA PELANGGAN"
        Me.btnPelanggan.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Navy
        Me.Panel4.Controls.Add(Me.lbl_level)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.lbl_nama)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 668)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(366, 81)
        Me.Panel4.TabIndex = 4
        '
        'lbl_level
        '
        Me.lbl_level.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_level.AutoSize = True
        Me.lbl_level.BackColor = System.Drawing.Color.Transparent
        Me.lbl_level.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_level.ForeColor = System.Drawing.Color.White
        Me.lbl_level.Location = New System.Drawing.Point(99, 41)
        Me.lbl_level.Name = "lbl_level"
        Me.lbl_level.Size = New System.Drawing.Size(94, 20)
        Me.lbl_level.TabIndex = 91
        Me.lbl_level.Text = "Level User"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(19, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 20)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Level    :"
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(19, 15)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 20)
        Me.Label18.TabIndex = 94
        Me.Label18.Text = "Nama   :"
        '
        'lbl_nama
        '
        Me.lbl_nama.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_nama.AutoSize = True
        Me.lbl_nama.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nama.ForeColor = System.Drawing.Color.White
        Me.lbl_nama.Location = New System.Drawing.Point(100, 15)
        Me.lbl_nama.Name = "lbl_nama"
        Me.lbl_nama.Size = New System.Drawing.Size(98, 20)
        Me.lbl_nama.TabIndex = 93
        Me.lbl_nama.Text = "Nama User"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Navy
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 3, 3, 40)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(366, 100)
        Me.Panel5.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(-3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(370, 73)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "WELCOME"
        '
        'btnJamLock
        '
        Me.btnJamLock.BackColor = System.Drawing.Color.Navy
        Me.btnJamLock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnJamLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJamLock.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJamLock.ForeColor = System.Drawing.Color.White
        Me.btnJamLock.Image = Global.AppPelanggan.My.Resources.Resources.setlock
        Me.btnJamLock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnJamLock.Location = New System.Drawing.Point(12, 481)
        Me.btnJamLock.Margin = New System.Windows.Forms.Padding(30, 3, 3, 3)
        Me.btnJamLock.Name = "btnJamLock"
        Me.btnJamLock.Size = New System.Drawing.Size(336, 63)
        Me.btnJamLock.TabIndex = 5
        Me.btnJamLock.Text = "HISTORY"
        Me.btnJamLock.UseVisualStyleBackColor = False
        '
        'btnUnit
        '
        Me.btnUnit.BackColor = System.Drawing.Color.Navy
        Me.btnUnit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnit.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnit.ForeColor = System.Drawing.Color.White
        Me.btnUnit.Image = Global.AppPelanggan.My.Resources.Resources.unit
        Me.btnUnit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUnit.Location = New System.Drawing.Point(12, 384)
        Me.btnUnit.Name = "btnUnit"
        Me.btnUnit.Size = New System.Drawing.Size(336, 63)
        Me.btnUnit.TabIndex = 4
        Me.btnUnit.Text = "DATA UNIT"
        Me.btnUnit.UseVisualStyleBackColor = False
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(1004, 749)
        Me.PanelMenu.TabIndex = 47
        '
        'btnTutup
        '
        Me.btnTutup.BackColor = System.Drawing.Color.Navy
        Me.btnTutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTutup.Image = Global.AppPelanggan.My.Resources.Resources.close
        Me.btnTutup.Location = New System.Drawing.Point(1313, 3)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(50, 39)
        Me.btnTutup.TabIndex = 114
        '
        'PanelAkses
        '
        Me.PanelAkses.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.PanelAkses.Controls.Add(Me.Button2)
        Me.PanelAkses.Controls.Add(Me.Label3)
        Me.PanelAkses.Controls.Add(Me.Button3)
        Me.PanelAkses.Controls.Add(Me.DataGridHistory)
        Me.PanelAkses.Controls.Add(Me.lblTutup)
        Me.PanelAkses.Controls.Add(Me.txtJam)
        Me.PanelAkses.Controls.Add(Me.Label11)
        Me.PanelAkses.Controls.Add(Me.txtCari)
        Me.PanelAkses.Controls.Add(Me.Label4)
        Me.PanelAkses.Controls.Add(Me.PanelMenu)
        Me.PanelAkses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelAkses.Location = New System.Drawing.Point(366, 0)
        Me.PanelAkses.Name = "PanelAkses"
        Me.PanelAkses.Size = New System.Drawing.Size(1004, 749)
        Me.PanelAkses.TabIndex = 123
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Navy
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.AppPelanggan.My.Resources.Resources.setlock
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(64, 540)
        Me.Button2.Margin = New System.Windows.Forms.Padding(30, 3, 3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(336, 63)
        Me.Button2.TabIndex = 125
        Me.Button2.Text = "BUKA"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 16.75!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(24, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 26)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "ID CARD"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Navy
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = Global.AppPelanggan.My.Resources.Resources.setlock
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(602, 540)
        Me.Button3.Margin = New System.Windows.Forms.Padding(30, 3, 3, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(336, 63)
        Me.Button3.TabIndex = 130
        Me.Button3.Text = "TUTUP"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'DataGridHistory
        '
        Me.DataGridHistory.AllowUserToAddRows = False
        Me.DataGridHistory.AllowUserToDeleteRows = False
        Me.DataGridHistory.BackgroundColor = System.Drawing.Color.White
        Me.DataGridHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridHistory.Location = New System.Drawing.Point(27, 142)
        Me.DataGridHistory.Name = "DataGridHistory"
        Me.DataGridHistory.ReadOnly = True
        Me.DataGridHistory.Size = New System.Drawing.Size(581, 359)
        Me.DataGridHistory.TabIndex = 128
        '
        'lblTutup
        '
        Me.lblTutup.BackColor = System.Drawing.Color.Navy
        Me.lblTutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTutup.Image = Global.AppPelanggan.My.Resources.Resources.close
        Me.lblTutup.Location = New System.Drawing.Point(954, 3)
        Me.lblTutup.Name = "lblTutup"
        Me.lblTutup.Size = New System.Drawing.Size(50, 39)
        Me.lblTutup.TabIndex = 123
        '
        'txtJam
        '
        Me.txtJam.AutoSize = True
        Me.txtJam.BackColor = System.Drawing.Color.Transparent
        Me.txtJam.Font = New System.Drawing.Font("Times New Roman", 16.75!)
        Me.txtJam.ForeColor = System.Drawing.Color.White
        Me.txtJam.Location = New System.Drawing.Point(22, 74)
        Me.txtJam.Name = "txtJam"
        Me.txtJam.Size = New System.Drawing.Size(56, 26)
        Me.txtJam.TabIndex = 127
        Me.txtJam.Text = "JAM"
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Navy
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(404, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(183, 55)
        Me.Label11.TabIndex = 124
        Me.Label11.Text = "AKSES"
        '
        'txtCari
        '
        Me.txtCari.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.Location = New System.Drawing.Point(144, 107)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(277, 29)
        Me.txtCari.TabIndex = 129
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(-3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1026, 63)
        Me.Label4.TabIndex = 131
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.PanelAkses)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.PanelAkses.ResumeLayout(False)
        Me.PanelAkses.PerformLayout()
        CType(Me.DataGridHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnPelanggan As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbl_level As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lbl_nama As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnJamLock As Button
    Friend WithEvents btnUnit As Button
    Friend WithEvents btnTutup As Label
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelAkses As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridHistory As DataGridView
    Friend WithEvents lblTutup As Label
    Friend WithEvents txtJam As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents Label4 As Label
End Class
