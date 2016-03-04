<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDanhsachSP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDanhsachSP))
        Me.btnXemall = New System.Windows.Forms.Button()
        Me.btnXem = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvxemsp = New System.Windows.Forms.DataGridView()
        Me.cbbsanpham = New System.Windows.Forms.ComboBox()
        Me.cbbloai = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txttim = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbbtim = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgvxemsp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnXemall
        '
        Me.btnXemall.BackgroundImage = CType(resources.GetObject("btnXemall.BackgroundImage"), System.Drawing.Image)
        Me.btnXemall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnXemall.Location = New System.Drawing.Point(10, 91)
        Me.btnXemall.Name = "btnXemall"
        Me.btnXemall.Size = New System.Drawing.Size(54, 50)
        Me.btnXemall.TabIndex = 6
        Me.btnXemall.UseVisualStyleBackColor = True
        '
        'btnXem
        '
        Me.btnXem.BackgroundImage = CType(resources.GetObject("btnXem.BackgroundImage"), System.Drawing.Image)
        Me.btnXem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnXem.Location = New System.Drawing.Point(10, 32)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(54, 50)
        Me.btnXem.TabIndex = 5
        Me.btnXem.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(55, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Mã sản phẩm :"
        '
        'dgvxemsp
        '
        Me.dgvxemsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvxemsp.Location = New System.Drawing.Point(6, 13)
        Me.dgvxemsp.Name = "dgvxemsp"
        Me.dgvxemsp.Size = New System.Drawing.Size(660, 172)
        Me.dgvxemsp.TabIndex = 46
        Me.dgvxemsp.TabStop = False
        '
        'cbbsanpham
        '
        Me.cbbsanpham.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbsanpham.FormattingEnabled = True
        Me.cbbsanpham.Location = New System.Drawing.Point(167, 50)
        Me.cbbsanpham.Name = "cbbsanpham"
        Me.cbbsanpham.Size = New System.Drawing.Size(94, 23)
        Me.cbbsanpham.TabIndex = 2
        '
        'cbbloai
        '
        Me.cbbloai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbloai.FormattingEnabled = True
        Me.cbbloai.Items.AddRange(New Object() {"MA_SP", "MALOAI_SP"})
        Me.cbbloai.Location = New System.Drawing.Point(167, 77)
        Me.cbbloai.Name = "cbbloai"
        Me.cbbloai.Size = New System.Drawing.Size(94, 23)
        Me.cbbloai.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(55, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 18)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Mã loại :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(561, 148)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin tìm kiếm:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txttim)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.cbbsanpham)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.cbbtim)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.cbbloai)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 17)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(545, 125)
        Me.GroupBox3.TabIndex = 51
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Nội dung cần tìm:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(275, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 18)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Tên sản phẩm :"
        '
        'txttim
        '
        Me.txttim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttim.Location = New System.Drawing.Point(405, 23)
        Me.txttim.Name = "txttim"
        Me.txttim.Size = New System.Drawing.Size(121, 21)
        Me.txttim.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(24, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 18)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Tìm theo :"
        '
        'cbbtim
        '
        Me.cbbtim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbtim.FormattingEnabled = True
        Me.cbbtim.Items.AddRange(New Object() {"Mã sản phẩm", "Loại sản phẩm"})
        Me.cbbtim.Location = New System.Drawing.Point(114, 21)
        Me.cbbtim.Name = "cbbtim"
        Me.cbbtim.Size = New System.Drawing.Size(147, 23)
        Me.cbbtim.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.dgvxemsp)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 203)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(673, 191)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Danh sách sản phẩm"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.btnXemall)
        Me.GroupBox4.Controls.Add(Me.btnXem)
        Me.GroupBox4.Location = New System.Drawing.Point(594, 55)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(76, 148)
        Me.GroupBox4.TabIndex = 51
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Chức năng:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(209, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(300, 31)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "DANH SÁCH SẢN PHẨM"
        '
        'frmDanhsachSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(681, 400)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDanhsachSP"
        CType(Me.dgvxemsp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnXemall As Button
    Friend WithEvents btnXem As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvxemsp As DataGridView
    Friend WithEvents cbbsanpham As ComboBox
    Friend WithEvents cbbloai As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbbtim As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txttim As TextBox
    Friend WithEvents Label5 As Label
End Class
