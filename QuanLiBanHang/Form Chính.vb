Imports QuanLiBanHang.frmDangnhap
Public Class frmChinh
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles QuanliKH.Click
        frmQuanliKH.Show()
    End Sub
    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles DanhsachKH.Click
        frmDanhsachKH.Show()
    End Sub
    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles QuanliloaiSP.Click
        frmQuanliLSP.Show()
    End Sub
    Private Sub QuanliSP_Click(sender As Object, e As EventArgs) Handles QuanliSP.Click
        frmQuanliSP.Show()
    End Sub

    Private Sub DanhsachSP_Click(sender As Object, e As EventArgs) Handles DanhsachSP.Click
        frmDanhsachSP.Show()
    End Sub
    Private Sub GiớiThiệuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles gioithieu.Click
        frmGioithieu.Show()
    End Sub
    Private loginresult As DialogResult

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim frm As New frmDangnhap
        frm.ShowDialog()
        loginresult = frm.DialogResult

    End Sub
End Class