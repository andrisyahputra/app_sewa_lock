<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormIDCard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormIDCard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnTutup = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridHistory = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtJam = New System.Windows.Forms.Label()
        Me.btnUnit = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.btnTutup)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1137, 57)
        Me.Panel1.TabIndex = 50
        '
        'btnTutup
        '
        Me.btnTutup.BackColor = System.Drawing.Color.Transparent
        Me.btnTutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTutup.Image = Global.AppPelanggan.My.Resources.Resources.close
        Me.btnTutup.Location = New System.Drawing.Point(1084, 0)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(50, 39)
        Me.btnTutup.TabIndex = 56
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(455, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(183, 55)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "AKSES"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.75!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(40, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 26)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "ID CARD"
        '
        'DataGridHistory
        '
        Me.DataGridHistory.AllowUserToAddRows = False
        Me.DataGridHistory.AllowUserToDeleteRows = False
        Me.DataGridHistory.BackgroundColor = System.Drawing.Color.White
        Me.DataGridHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridHistory.Location = New System.Drawing.Point(12, 150)
        Me.DataGridHistory.Name = "DataGridHistory"
        Me.DataGridHistory.ReadOnly = True
        Me.DataGridHistory.Size = New System.Drawing.Size(1113, 433)
        Me.DataGridHistory.TabIndex = 93
        '
        'Timer1
        '
        '
        'txtJam
        '
        Me.txtJam.AutoSize = True
        Me.txtJam.BackColor = System.Drawing.Color.Transparent
        Me.txtJam.Font = New System.Drawing.Font("Times New Roman", 16.75!)
        Me.txtJam.ForeColor = System.Drawing.Color.White
        Me.txtJam.Location = New System.Drawing.Point(905, 60)
        Me.txtJam.Name = "txtJam"
        Me.txtJam.Size = New System.Drawing.Size(56, 26)
        Me.txtJam.TabIndex = 54
        Me.txtJam.Text = "JAM"
        '
        'btnUnit
        '
        Me.btnUnit.BackColor = System.Drawing.Color.Navy
        Me.btnUnit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnit.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnit.ForeColor = System.Drawing.Color.White
        Me.btnUnit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUnit.Location = New System.Drawing.Point(318, 69)
        Me.btnUnit.Name = "btnUnit"
        Me.btnUnit.Size = New System.Drawing.Size(100, 39)
        Me.btnUnit.TabIndex = 94
        Me.btnUnit.Text = "DETAIL"
        Me.btnUnit.UseVisualStyleBackColor = False
        '
        'txtCari
        '
        Me.txtCari.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.Location = New System.Drawing.Point(150, 79)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(142, 29)
        Me.txtCari.TabIndex = 97
        '
        'FormIDCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(1137, 595)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.btnUnit)
        Me.Controls.Add(Me.DataGridHistory)
        Me.Controls.Add(Me.txtJam)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormIDCard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormHistory"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnTutup As Label
    Friend WithEvents DataGridHistory As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtJam As Label
    Friend WithEvents btnUnit As Button
    Friend WithEvents txtCari As TextBox
End Class
