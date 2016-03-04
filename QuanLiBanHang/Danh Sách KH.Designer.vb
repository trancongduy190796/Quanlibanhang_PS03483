<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDanhsachKH

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDanhsachKH))
        Me.btnXem = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvxemsp = New System.Windows.Forms.DataGridView()
        Me.cbbMAKH = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txttenkh = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnXemall = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvxemsp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnXem
        '
        Me.btnXem.BackgroundImage = CType(resources.GetObject("btnXem.BackgroundImage"), System.Drawing.Image)
        Me.btnXem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnXem.Location = New System.Drawing.Point(14, 19)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(54, 45)
        Me.btnXem.TabIndex = 3
        Me.btnXem.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(17, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Mã khách hàng :"
        '
        'dgvxemsp
        '
        Me.dgvxemsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvxemsp.Location = New System.Drawing.Point(6, 19)
        Me.dgvxemsp.Name = "dgvxemsp"
        Me.dgvxemsp.Size = New System.Drawing.Size(660, 172)
        Me.dgvxemsp.TabIndex = 46
        Me.dgvxemsp.TabStop = False
        '
        'cbbMAKH
        '
        Me.cbbMAKH.FormattingEnabled = True
        Me.cbbMAKH.Items.AddRange(New Object() {"MA_SP", "MALOAI_SP"})
        Me.cbbMAKH.Location = New System.Drawing.Point(144, 35)
        Me.cbbMAKH.Name = "cbbMAKH"
        Me.cbbMAKH.Size = New System.Drawing.Size(121, 21)
        Me.cbbMAKH.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(17, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 18)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Tên khách hàng :"
        '
        'txttenkh
        '
        Me.txttenkh.Location = New System.Drawing.Point(144, 65)
        Me.txttenkh.Name = "txttenkh"
        Me.txttenkh.Size = New System.Drawing.Size(121, 20)
        Me.txttenkh.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbbMAKH)
        Me.GroupBox1.Controls.Add(Me.txttenkh)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(341, 126)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Điều kiện xem"
        '
        'btnXemall
        '
        Me.btnXemall.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnXemall.BackgroundImage = CType(resources.GetObject("btnXemall.BackgroundImage"), System.Drawing.Image)
        Me.btnXemall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnXemall.Location = New System.Drawing.Point(14, 72)
        Me.btnXemall.Name = "btnXemall"
        Me.btnXemall.Size = New System.Drawing.Size(54, 45)
        Me.btnXemall.TabIndex = 4
        Me.btnXemall.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.dgvxemsp)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 187)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(674, 196)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Danh sách khách hàng"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btnXemall)
        Me.GroupBox3.Controls.Add(Me.btnXem)
        Me.GroupBox3.Location = New System.Drawing.Point(385, 58)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(82, 123)
        Me.GroupBox3.TabIndex = 54
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Chức năng:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label7.Location = New System.Drawing.Point(174, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(333, 29)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "DANH SÁCH KHÁCH HÀNG"
        '
        'frmDanhsachKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(684, 387)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDanhsachKH"
        CType(Me.dgvxemsp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnXem As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvxemsp As DataGridView
    Friend WithEvents cbbMAKH As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txttenkh As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnXemall As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
End Class
