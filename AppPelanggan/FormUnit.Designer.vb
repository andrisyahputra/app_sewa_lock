<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUnit
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUnit))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUnit = New System.Windows.Forms.Button()
        Me.btnKamar = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Label()
        Me.DataGridAdaKamar = New System.Windows.Forms.DataGridView()
        Me.DataGridUnit = New System.Windows.Forms.DataGridView()
        Me.DataGridPenuhKamar = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnUser = New System.Windows.Forms.Button()
        CType(Me.DataGridAdaKamar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridPenuhKamar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 321)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 33)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "KAMAR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 33)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "UNIT"
        '
        'btnUnit
        '
        Me.btnUnit.BackColor = System.Drawing.Color.Navy
        Me.btnUnit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnit.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnit.ForeColor = System.Drawing.Color.White
        Me.btnUnit.Location = New System.Drawing.Point(321, 626)
        Me.btnUnit.Name = "btnUnit"
        Me.btnUnit.Size = New System.Drawing.Size(249, 31)
        Me.btnUnit.TabIndex = 44
        Me.btnUnit.Text = "TAMBAH UNIT"
        Me.btnUnit.UseVisualStyleBackColor = False
        '
        'btnKamar
        '
        Me.btnKamar.BackColor = System.Drawing.Color.Navy
        Me.btnKamar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKamar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKamar.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKamar.ForeColor = System.Drawing.Color.White
        Me.btnKamar.Location = New System.Drawing.Point(33, 626)
        Me.btnKamar.Name = "btnKamar"
        Me.btnKamar.Size = New System.Drawing.Size(246, 31)
        Me.btnKamar.TabIndex = 44
        Me.btnKamar.Text = "TAMBAH KAMAR"
        Me.btnKamar.UseVisualStyleBackColor = False
        '
        'btnTutup
        '
        Me.btnTutup.BackColor = System.Drawing.Color.Transparent
        Me.btnTutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTutup.Image = Global.AppPelanggan.My.Resources.Resources.close
        Me.btnTutup.Location = New System.Drawing.Point(870, 3)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(50, 39)
        Me.btnTutup.TabIndex = 47
        '
        'DataGridAdaKamar
        '
        Me.DataGridAdaKamar.AllowUserToAddRows = False
        Me.DataGridAdaKamar.AllowUserToDeleteRows = False
        Me.DataGridAdaKamar.BackgroundColor = System.Drawing.Color.White
        Me.DataGridAdaKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridAdaKamar.Location = New System.Drawing.Point(33, 365)
        Me.DataGridAdaKamar.Name = "DataGridAdaKamar"
        Me.DataGridAdaKamar.ReadOnly = True
        Me.DataGridAdaKamar.Size = New System.Drawing.Size(831, 106)
        Me.DataGridAdaKamar.TabIndex = 61
        '
        'DataGridUnit
        '
        Me.DataGridUnit.AllowUserToAddRows = False
        Me.DataGridUnit.AllowUserToDeleteRows = False
        Me.DataGridUnit.BackgroundColor = System.Drawing.Color.White
        Me.DataGridUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridUnit.Location = New System.Drawing.Point(33, 54)
        Me.DataGridUnit.Name = "DataGridUnit"
        Me.DataGridUnit.ReadOnly = True
        Me.DataGridUnit.Size = New System.Drawing.Size(831, 252)
        Me.DataGridUnit.TabIndex = 60
        '
        'DataGridPenuhKamar
        '
        Me.DataGridPenuhKamar.AllowUserToAddRows = False
        Me.DataGridPenuhKamar.AllowUserToDeleteRows = False
        Me.DataGridPenuhKamar.BackgroundColor = System.Drawing.Color.White
        Me.DataGridPenuhKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridPenuhKamar.Location = New System.Drawing.Point(33, 491)
        Me.DataGridPenuhKamar.Name = "DataGridPenuhKamar"
        Me.DataGridPenuhKamar.ReadOnly = True
        Me.DataGridPenuhKamar.Size = New System.Drawing.Size(831, 106)
        Me.DataGridPenuhKamar.TabIndex = 63
        '
        'btnUser
        '
        Me.btnUser.BackColor = System.Drawing.Color.Navy
        Me.btnUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUser.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.ForeColor = System.Drawing.Color.White
        Me.btnUser.Location = New System.Drawing.Point(615, 626)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(249, 31)
        Me.btnUser.TabIndex = 64
        Me.btnUser.Text = "TAMBAH USER"
        Me.btnUser.UseVisualStyleBackColor = False
        '
        'FormUnit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(923, 711)
        Me.Controls.Add(Me.btnUser)
        Me.Controls.Add(Me.DataGridPenuhKamar)
        Me.Controls.Add(Me.DataGridAdaKamar)
        Me.Controls.Add(Me.DataGridUnit)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.btnKamar)
        Me.Controls.Add(Me.btnUnit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormUnit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUnit"
        CType(Me.DataGridAdaKamar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridPenuhKamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUnit As Button
    Friend WithEvents btnKamar As Button
    Friend WithEvents btnTutup As Label
    Friend WithEvents DataGridAdaKamar As DataGridView
    Friend WithEvents DataGridUnit As DataGridView
    Friend WithEvents DataGridPenuhKamar As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnUser As Button
End Class
