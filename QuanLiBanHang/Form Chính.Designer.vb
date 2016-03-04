<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmChinh
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChinh))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuanliKH = New System.Windows.Forms.ToolStripMenuItem()
        Me.DanhsachKH = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuanliSP = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuanliloaiSP = New System.Windows.Forms.ToolStripMenuItem()
        Me.DanhsachSP = New System.Windows.Forms.ToolStripMenuItem()
        Me.gioithieu = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(627, 250)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem4, Me.gioithieu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(629, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuanliKH, Me.DanhsachKH})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(82, 20)
        Me.ToolStripMenuItem1.Text = "Khách hàng"
        '
        'QuanliKH
        '
        Me.QuanliKH.Name = "QuanliKH"
        Me.QuanliKH.Size = New System.Drawing.Size(177, 22)
        Me.QuanliKH.Text = "Quản lí khách hàng"
        '
        'DanhsachKH
        '
        Me.DanhsachKH.Name = "DanhsachKH"
        Me.DanhsachKH.Size = New System.Drawing.Size(177, 22)
        Me.DanhsachKH.Text = "Danh sách"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuanliSP, Me.QuanliloaiSP, Me.DanhsachSP})
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(72, 20)
        Me.ToolStripMenuItem4.Text = "Sản phẩm"
        '
        'QuanliSP
        '
        Me.QuanliSP.Name = "QuanliSP"
        Me.QuanliSP.Size = New System.Drawing.Size(167, 22)
        Me.QuanliSP.Text = "Quản lí sản phẩm"
        '
        'QuanliloaiSP
        '
        Me.QuanliloaiSP.Name = "QuanliloaiSP"
        Me.QuanliloaiSP.Size = New System.Drawing.Size(167, 22)
        Me.QuanliloaiSP.Text = "Loại sản phẩm"
        '
        'DanhsachSP
        '
        Me.DanhsachSP.Name = "DanhsachSP"
        Me.DanhsachSP.Size = New System.Drawing.Size(167, 22)
        Me.DanhsachSP.Text = "Danh sách"
        '
        'gioithieu
        '
        Me.gioithieu.Name = "gioithieu"
        Me.gioithieu.Size = New System.Drawing.Size(70, 20)
        Me.gioithieu.Text = "Giới thiệu"
        '
        'frmChinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 276)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmChinh"
        Me.Text = " "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents QuanliKH As ToolStripMenuItem
    Friend WithEvents DanhsachKH As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents QuanliSP As ToolStripMenuItem
    Friend WithEvents QuanliloaiSP As ToolStripMenuItem
    Friend WithEvents gioithieu As ToolStripMenuItem
    Friend WithEvents DanhsachSP As ToolStripMenuItem
End Class
