<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQuanliSP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanliSP))
        Me.txtSoluong = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvSanpham = New System.Windows.Forms.DataGridView()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnCapnhat = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnTim = New System.Windows.Forms.Button()
        Me.txtDonvitinh = New System.Windows.Forms.TextBox()
        Me.txtDONGIA = New System.Windows.Forms.TextBox()
        Me.txtTEN_SP = New System.Windows.Forms.TextBox()
        Me.txtMA_SP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbbMASP = New System.Windows.Forms.ComboBox()
        Me.btnload = New System.Windows.Forms.Button()
        Me.txttim = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Grb = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvSanpham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grb.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSoluong
        '
        Me.txtSoluong.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSoluong.Location = New System.Drawing.Point(386, 50)
        Me.txtSoluong.Name = "txtSoluong"
        Me.txtSoluong.Size = New System.Drawing.Size(105, 21)
        Me.txtSoluong.TabIndex = 5
        Me.txtSoluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label7.Location = New System.Drawing.Point(282, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 18)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Số lượng :"
        '
        'dgvSanpham
        '
        Me.dgvSanpham.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvSanpham.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSanpham.Location = New System.Drawing.Point(6, 15)
        Me.dgvSanpham.Name = "dgvSanpham"
        Me.dgvSanpham.Size = New System.Drawing.Size(643, 160)
        Me.dgvSanpham.TabIndex = 45
        Me.dgvSanpham.TabStop = False
        '
        'btnXoa
        '
        Me.btnXoa.BackgroundImage = CType(resources.GetObject("btnXoa.BackgroundImage"), System.Drawing.Image)
        Me.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.Location = New System.Drawing.Point(20, 51)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(34, 38)
        Me.btnXoa.TabIndex = 8
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnCapnhat
        '
        Me.btnCapnhat.BackgroundImage = CType(resources.GetObject("btnCapnhat.BackgroundImage"), System.Drawing.Image)
        Me.btnCapnhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCapnhat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapnhat.Location = New System.Drawing.Point(20, 87)
        Me.btnCapnhat.Name = "btnCapnhat"
        Me.btnCapnhat.Size = New System.Drawing.Size(34, 36)
        Me.btnCapnhat.TabIndex = 9
        Me.btnCapnhat.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.BackgroundImage = CType(resources.GetObject("btnThem.BackgroundImage"), System.Drawing.Image)
        Me.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Location = New System.Drawing.Point(20, 14)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(34, 38)
        Me.btnThem.TabIndex = 7
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnTim
        '
        Me.btnTim.BackgroundImage = CType(resources.GetObject("btnTim.BackgroundImage"), System.Drawing.Image)
        Me.btnTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTim.ForeColor = System.Drawing.Color.Black
        Me.btnTim.Location = New System.Drawing.Point(118, 8)
        Me.btnTim.Name = "btnTim"
        Me.btnTim.Size = New System.Drawing.Size(28, 31)
        Me.btnTim.TabIndex = 21
        Me.btnTim.TabStop = False
        Me.btnTim.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTim.UseVisualStyleBackColor = True
        '
        'txtDonvitinh
        '
        Me.txtDonvitinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDonvitinh.Location = New System.Drawing.Point(386, 24)
        Me.txtDonvitinh.Name = "txtDonvitinh"
        Me.txtDonvitinh.Size = New System.Drawing.Size(74, 21)
        Me.txtDonvitinh.TabIndex = 4
        '
        'txtDONGIA
        '
        Me.txtDONGIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDONGIA.Location = New System.Drawing.Point(386, 77)
        Me.txtDONGIA.Name = "txtDONGIA"
        Me.txtDONGIA.Size = New System.Drawing.Size(105, 21)
        Me.txtDONGIA.TabIndex = 6
        Me.txtDONGIA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTEN_SP
        '
        Me.txtTEN_SP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTEN_SP.Location = New System.Drawing.Point(89, 77)
        Me.txtTEN_SP.Name = "txtTEN_SP"
        Me.txtTEN_SP.Size = New System.Drawing.Size(187, 21)
        Me.txtTEN_SP.TabIndex = 3
        '
        'txtMA_SP
        '
        Me.txtMA_SP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMA_SP.Location = New System.Drawing.Point(89, 24)
        Me.txtMA_SP.Name = "txtMA_SP"
        Me.txtMA_SP.Size = New System.Drawing.Size(99, 21)
        Me.txtMA_SP.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(282, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 18)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Đơn vị tính :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label6.Location = New System.Drawing.Point(282, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 18)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Đơn giá :"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.BackColor = System.Drawing.Color.Transparent
        Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.ForeColor = System.Drawing.Color.SteelBlue
        Me.label10.Location = New System.Drawing.Point(10, 78)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(65, 18)
        Me.label10.TabIndex = 30
        Me.label10.Text = "Tên SP :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(10, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 18)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Mã SP :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(10, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 18)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Mã loại :"
        '
        'cbbMASP
        '
        Me.cbbMASP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbMASP.FormattingEnabled = True
        Me.cbbMASP.Location = New System.Drawing.Point(89, 51)
        Me.cbbMASP.Name = "cbbMASP"
        Me.cbbMASP.Size = New System.Drawing.Size(99, 23)
        Me.cbbMASP.TabIndex = 2
        '
        'btnload
        '
        Me.btnload.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.btnload.BackgroundImage = CType(resources.GetObject("btnload.BackgroundImage"), System.Drawing.Image)
        Me.btnload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnload.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnload.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnload.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnload.Location = New System.Drawing.Point(20, 120)
        Me.btnload.Name = "btnload"
        Me.btnload.Size = New System.Drawing.Size(34, 38)
        Me.btnload.TabIndex = 10
        Me.btnload.UseVisualStyleBackColor = True
        '
        'txttim
        '
        Me.txttim.Location = New System.Drawing.Point(12, 13)
        Me.txttim.Name = "txttim"
        Me.txttim.Size = New System.Drawing.Size(100, 20)
        Me.txttim.TabIndex = 20
        Me.txttim.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(217, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(254, 31)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "QUẢN LÍ SẢN PHẨM"
        '
        'Grb
        '
        Me.Grb.BackColor = System.Drawing.Color.Transparent
        Me.Grb.Controls.Add(Me.Label1)
        Me.Grb.Controls.Add(Me.label10)
        Me.Grb.Controls.Add(Me.Label6)
        Me.Grb.Controls.Add(Me.Label4)
        Me.Grb.Controls.Add(Me.cbbMASP)
        Me.Grb.Controls.Add(Me.txtMA_SP)
        Me.Grb.Controls.Add(Me.Label2)
        Me.Grb.Controls.Add(Me.txtTEN_SP)
        Me.Grb.Controls.Add(Me.txtSoluong)
        Me.Grb.Controls.Add(Me.txtDONGIA)
        Me.Grb.Controls.Add(Me.Label7)
        Me.Grb.Controls.Add(Me.txtDonvitinh)
        Me.Grb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grb.Location = New System.Drawing.Point(42, 59)
        Me.Grb.Name = "Grb"
        Me.Grb.Size = New System.Drawing.Size(537, 111)
        Me.Grb.TabIndex = 54
        Me.Grb.TabStop = False
        Me.Grb.Text = "Thông tin:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.dgvSanpham)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(4, 195)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(657, 185)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chi tiết sản phẩm:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnXoa)
        Me.GroupBox2.Controls.Add(Me.btnThem)
        Me.GroupBox2.Controls.Add(Me.btnCapnhat)
        Me.GroupBox2.Controls.Add(Me.btnload)
        Me.GroupBox2.Location = New System.Drawing.Point(585, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(76, 162)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chức năng:"
        '
        'frmQuanliSP
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(665, 384)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Grb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txttim)
        Me.Controls.Add(Me.btnTim)
        Me.ForeColor = System.Drawing.Color.SteelBlue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQuanliSP"
        CType(Me.dgvSanpham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grb.ResumeLayout(False)
        Me.Grb.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSoluong As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvSanpham As DataGridView
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnCapnhat As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents btnTim As Button
    Friend WithEvents txtDonvitinh As TextBox
    Friend WithEvents txtDONGIA As TextBox
    Friend WithEvents txtTEN_SP As TextBox
    Friend WithEvents txtMA_SP As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbbMASP As ComboBox
    Friend WithEvents btnload As Button
    Friend WithEvents txttim As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Grb As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
