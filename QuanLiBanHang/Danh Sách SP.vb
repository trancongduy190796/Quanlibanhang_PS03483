Imports System.Data.SqlClient
Imports System.Data.DataSet

Public Class frmDanhsachSP

    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=QuanLiBanHang.mssql.somee.com;packet size=4096;user id=duytcps03483_SQLLogin_1;pwd=p7ejcpv4fs;data source=QuanLiBanHang.mssql.somee.com;persist security info=False;initial catalog=QuanLiBanHang"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub dvg_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MA_SP as 'Mã sản phẩm',MALOAI_SP as 'Mã Loại', TEN_SP as 'Tên sản phẩm',SOLUONG as 'Số lượng',DONVITINH as 'Đơn vị tính',DONGIA as'Đơn giá' from SANPHAM", conn)
        db.Clear()
        refesh.Fill(db)
        dgvxemsp.DataSource = db.DefaultView
        Dim a As New Class1
        'dgvxemsp.DataSource = a.Loadsanpham.Tables(0)
        cbbloai.DataSource = a.LOAISANPHAM("MALOAI_SP").Tables(0)
        cbbloai.DisplayMember = "MALOAI_SP"
        cbbsanpham.DataSource = a.SANPHAM("MA_SP").Tables(0)
        cbbsanpham.DisplayMember = "MA_SP"
    End Sub

    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnXem.Click
        Try
            If Me.cbbtim.SelectedIndex = 0 Then
                conn.Open()
                Dim xemMAKH As SqlDataAdapter = New SqlDataAdapter("select MA_SP as 'Mã sản phẩm',MALOAI_SP as 'Mã Loại', TEN_SP as 'Tên sản phẩm',SOLUONG as 'Số lượng',DONVITINH as 'Đơn vị tính',DONGIA as'Đơn giá' from SANPHAM where MA_SP='" & cbbsanpham.Text & "'", conn)

                If cbbsanpham.Text = "" Then
                    MessageBox.Show("Bạn cần nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    db.Clear()
                    dgvxemsp.DataSource = Nothing
                    xemMAKH.Fill(db)
                    If db.Rows.Count > 0 Then
                        dgvxemsp.DataSource = db.DefaultView
                        cbbsanpham.Text = Nothing
                    Else
                        MessageBox.Show("Không tìm thấy")
                        cbbsanpham.Text = Nothing
                    End If
                End If
                conn.Close()
            ElseIf Me.cbbtim.SelectedIndex = 1 Then
                conn.Open()
                Dim xemTENKH As SqlDataAdapter = New SqlDataAdapter("select MA_SP as 'Mã sản phẩm',MALOAI_SP as 'Mã Loại', TEN_SP as 'Tên sản phẩm',SOLUONG as 'Số lượng',DONVITINH as 'Đơn vị tính',DONGIA as'Đơn giá' from SANPHAM where MALOAI_SP='" & cbbloai.Text & "'", conn)

                If cbbloai.Text = "" Then
                    MessageBox.Show("Bạn cần nhập mã loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    db.Clear()
                    dgvxemsp.DataSource = Nothing
                    xemTENKH.Fill(db)
                    If db.Rows.Count > 0 Then
                        dgvxemsp.DataSource = db.DefaultView
                        cbbloai.Text = Nothing
                    Else
                        MessageBox.Show("Không tìm thấy")
                        cbbloai.Text = Nothing
                    End If
                End If
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("lỗi")
        End Try
    End Sub

    Private Sub btnXemall_Click(sender As Object, e As EventArgs) Handles btnXemall.Click
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MA_SP as 'Mã sản phẩm',MALOAI_SP as 'Mã Loại', TEN_SP as 'Tên sản phẩm',SOLUONG as 'Số lượng',DONVITINH as 'Đơn vị tính',DONGIA as'Đơn giá' from SANPHAM", conn)
        db.Clear()
        refesh.Fill(db)
        dgvxemsp.DataSource = db.DefaultView
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub txttimsp_TextChanged(sender As Object, e As EventArgs)
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MA_SP as 'Mã sản phẩm',MALOAI_SP as 'Mã Loại', TEN_SP as 'Tên sản phẩm',SOLUONG as 'Số lượng',DONVITINH as 'Đơn vị tính',DONGIA as'Đơn giá' from SANPHAM where TEN_SP like '" & "%" & txttim.Text & "%" & "'", conn)
        db.Clear()
        refesh.Fill(db)
        dgvxemsp.DataSource = db.DefaultView
    End Sub

End Class