<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanliLSP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanliLSP))
        Me.txtTenloai_SP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvSanpham = New System.Windows.Forms.DataGridView()
        Me.txtMALOAI_SP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnTim = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnCapnhat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnload = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvSanpham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTenloai_SP
        '
        Me.txtTenloai_SP.Location = New System.Drawing.Point(118, 40)
        Me.txtTenloai_SP.Name = "txtTenloai_SP"
        Me.txtTenloai_SP.Size = New System.Drawing.Size(137, 20)
        Me.txtTenloai_SP.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(16, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 17)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Tên Loại :"
        '
        'dgvSanpham
        '
        Me.dgvSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSanpham.Location = New System.Drawing.Point(6, 13)
        Me.dgvSanpham.Name = "dgvSanpham"
        Me.dgvSanpham.Size = New System.Drawing.Size(260, 167)
        Me.dgvSanpham.TabIndex = 45
        '
        'txtMALOAI_SP
        '
        Me.txtMALOAI_SP.Location = New System.Drawing.Point(118, 14)
        Me.txtMALOAI_SP.Name = "txtMALOAI_SP"
        Me.txtMALOAI_SP.Size = New System.Drawing.Size(137, 20)
        Me.txtMALOAI_SP.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(16, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 17)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Mã Loại :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Tên SP"
        '
        'btnTim
        '
        Me.btnTim.BackgroundImage = CType(resources.GetObject("btnTim.BackgroundImage"), System.Drawing.Image)
        Me.btnTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTim.Location = New System.Drawing.Point(13, 29)
        Me.btnTim.Name = "btnTim"
        Me.btnTim.Size = New System.Drawing.Size(51, 36)
        Me.btnTim.TabIndex = 41
        Me.btnTim.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.BackgroundImage = CType(resources.GetObject("btnThem.BackgroundImage"), System.Drawing.Image)
        Me.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnThem.Location = New System.Drawing.Point(13, 72)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(51, 36)
        Me.btnThem.TabIndex = 42
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnCapnhat
        '
        Me.btnCapnhat.BackgroundImage = CType(resources.GetObject("btnCapnhat.BackgroundImage"), System.Drawing.Image)
        Me.btnCapnhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCapnhat.Location = New System.Drawing.Point(13, 160)
        Me.btnCapnhat.Name = "btnCapnhat"
        Me.btnCapnhat.Size = New System.Drawing.Size(51, 36)
        Me.btnCapnhat.TabIndex = 43
        Me.btnCapnhat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.BackgroundImage = CType(resources.GetObject("btnXoa.BackgroundImage"), System.Drawing.Image)
        Me.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnXoa.Location = New System.Drawing.Point(13, 115)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(51, 36)
        Me.btnXoa.TabIndex = 44
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtTenloai_SP)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtMALOAI_SP)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 65)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.dgvSanpham)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 128)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(272, 187)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chi tiết loại sản phẩm:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btnload)
        Me.GroupBox3.Controls.Add(Me.btnXoa)
        Me.GroupBox3.Controls.Add(Me.btnThem)
        Me.GroupBox3.Controls.Add(Me.btnCapnhat)
        Me.GroupBox3.Controls.Add(Me.btnTim)
        Me.GroupBox3.Location = New System.Drawing.Point(285, 57)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(79, 258)
        Me.GroupBox3.TabIndex = 46
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Chức năng:"
        '
        'btnload
        '
        Me.btnload.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.btnload.BackgroundImage = CType(resources.GetObject("btnload.BackgroundImage"), System.Drawing.Image)
        Me.btnload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnload.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnload.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnload.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnload.Location = New System.Drawing.Point(13, 202)
        Me.btnload.Name = "btnload"
        Me.btnload.Size = New System.Drawing.Size(51, 38)
        Me.btnload.TabIndex = 45
        Me.btnload.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(26, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 31)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "QUẢN LÍ LOẠI SẢN PHẨM"
        '
        'frmQuanliLSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(371, 323)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQuanliLSP"
        CType(Me.dgvSanpham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTenloai_SP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvSanpham As DataGridView
    Friend WithEvents txtMALOAI_SP As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnTim As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents btnCapnhat As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnload As Button
End Class
