<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangki
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDangki))
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnTao = New System.Windows.Forms.Button()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(154, 63)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 23)
        Me.btnThoat.TabIndex = 4
        Me.btnThoat.Text = "Thoat"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnTao
        '
        Me.btnTao.Location = New System.Drawing.Point(73, 63)
        Me.btnTao.Name = "btnTao"
        Me.btnTao.Size = New System.Drawing.Size(75, 23)
        Me.btnTao.TabIndex = 3
        Me.btnTao.Text = "Tạo "
        Me.btnTao.UseVisualStyleBackColor = True
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(91, 37)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(138, 20)
        Me.txtpass.TabIndex = 2
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(91, 10)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(138, 20)
        Me.txtusername.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(91, 10)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(138, 20)
        Me.TextBox1.TabIndex = 14
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.BackColor = System.Drawing.Color.Transparent
        Me.label10.Location = New System.Drawing.Point(22, 40)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(58, 13)
        Me.label10.TabIndex = 9
        Me.label10.Text = "Mật khẩu :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(21, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Tài Khoản :"
        '
        'frmDangki
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(256, 94)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnTao)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDangki"
        Me.Text = "Đăng kí"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnThoat As Button
    Friend WithEvents btnTao As Button
    Friend WithEvents txtpass As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents label10 As Label
    Friend WithEvents Label1 As Label
End Class
