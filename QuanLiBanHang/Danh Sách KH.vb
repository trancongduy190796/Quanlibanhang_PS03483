Imports System.Data.SqlClient
Imports System.Data.DataSet
Public Class frmDanhsachKH

    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=QuanLiBanHang.mssql.somee.com;packet size=4096;user id=duytcps03483_SQLLogin_1;pwd=p7ejcpv4fs;data source=QuanLiBanHang.mssql.somee.com;persist security info=False;initial catalog=QuanLiBanHang"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub dvg_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim a As New Class1
        dgvxemsp.DataSource = a.Loadkhachang.Tables(0)
        cbbMAKH.DataSource = a.KHACHHANG("MA_KH").Tables(0)
        cbbMAKH.DisplayMember = "MA_KH"
    End Sub

    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnXem.Click
        conn.Open()
        Dim xemMAKH As SqlDataAdapter = New SqlDataAdapter("select MA_KH as 'Mã KH', HO_KH as 'Họ Khách Hàng',TEN_KH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', DIENTHOAI as 'SĐT', EMAIL from KHACHHANG where MA_KH='" & cbbMAKH.Text & "'", conn)
        Try
            If cbbMAKH.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                db.Clear()
                dgvxemsp.DataSource = Nothing
                xemMAKH.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvxemsp.DataSource = db.DefaultView
                    cbbMAKH.Text = Nothing
                Else
                    MessageBox.Show("Không tìm thấy")
                    cbbMAKH.Text = Nothing
                End If
            End If
            conn.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnDong_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnXemall_Click(sender As Object, e As EventArgs) Handles btnXemall.Click
        Dim a As New Class1
        dgvxemsp.DataSource = a.Loadkhachang.Tables(0)
    End Sub
    'Private Sub timkiem(value As String)
    '  Dim sqlquery As String = String.Format("Select SANPHAM.MA_SP as 'Mã sản phẩm', LOAI_SANPHAM.MALOAI_SP as 'Mã Loại',SANPHAM.TEN_SP as 'Tên sản phẩm', LOAI_SANPHAM.TENLOAI_SP as 'Tên Loại',SANPHAM.SOLUONG as 'Số lượng',SANPHAM.DONVITINH as 'Đơn vị tính',SANPHAM.DONGIA as'Đơn giá' from SANPHAM inner join LOAI_SANPHAM on SANPHAM.MALOAI_SP = LOAI_SANPHAM.MALOAI_SP where ")
    '  If Me.cbbsanpham.SelectedIndex = 0 Then
    '    sqlquery += String.Format(" SANPHAM.MA_SP like '{0}%'", value)
    'ElseIf Me.cbbsanpham.SelectedIndex = 1 Then
    ' sqlquery += String.Format(" LOAI_SANPHAM.MALOAI_SP like '{0}%'", value)
    'Dim dtable As DataTable = _data.GetDataTable(sqlquery)
    'Me.dgvxemsp.DataSource = dtable
    'End If
    'End Sub

    'Private Sub txtTim_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    'timkiem(Me.txtTim.Text)
    'Dim DV As New DataView(db)
    'DV.RowFilter = String.Format("MA_SP like '%{0}'", txtTim.Text)
    'dgvxemsp.DataSource = DV
    'End Sub


    Private Sub txttenkh_TextChanged(sender As Object, e As EventArgs) Handles txttenkh.TextChanged
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MA_KH as 'Mã KH', HO_KH as 'Họ Khách Hàng',TEN_KH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', DIENTHOAI as 'SĐT', EMAIL from KHACHHANG where TEN_KH like '" & "%" & txttenkh.Text & "%" & "'", conn)
        db.Clear()
        refesh.Fill(db)
        dgvxemsp.DataSource = db.DefaultView
    End Sub
End Class