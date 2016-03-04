<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangnhap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDangnhap))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttk = New System.Windows.Forms.TextBox()
        Me.txtmk = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDangnhap = New System.Windows.Forms.Button()
        Me.btnDangki = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(119, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tài khoản:"
        '
        'txttk
        '
        Me.txttk.Location = New System.Drawing.Point(207, 28)
        Me.txttk.Name = "txttk"
        Me.txttk.Size = New System.Drawing.Size(128, 20)
        Me.txttk.TabIndex = 1
        '
        'txtmk
        '
        Me.txtmk.Location = New System.Drawing.Point(207, 65)
        Me.txtmk.Name = "txtmk"
        Me.txtmk.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtmk.Size = New System.Drawing.Size(128, 20)
        Me.txtmk.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(119, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mật khẩu:"
        '
        'btnDangnhap
        '
        Me.btnDangnhap.Location = New System.Drawing.Point(260, 100)
        Me.btnDangnhap.Name = "btnDangnhap"
        Me.btnDangnhap.Size = New System.Drawing.Size(75, 28)
        Me.btnDangnhap.TabIndex = 3
        Me.btnDangnhap.Text = "Đăng nhập"
        Me.btnDangnhap.UseVisualStyleBackColor = True
        '
        'btnDangki
        '
        Me.btnDangki.Location = New System.Drawing.Point(179, 100)
        Me.btnDangki.Name = "btnDangki"
        Me.btnDangki.Size = New System.Drawing.Size(75, 28)
        Me.btnDangki.TabIndex = 4
        Me.btnDangki.Text = "Đăng kí"
        Me.btnDangki.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(12, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 135)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmDangnhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(349, 156)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnDangki)
        Me.Controls.Add(Me.btnDangnhap)
        Me.Controls.Add(Me.txtmk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txttk)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDangnhap"
        Me.Text = "   Đăng nhập"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txttk As TextBox
    Friend WithEvents txtmk As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDangnhap As Button
    Friend WithEvents btnDangki As Button
    Friend WithEvents Button1 As Button
End Class
