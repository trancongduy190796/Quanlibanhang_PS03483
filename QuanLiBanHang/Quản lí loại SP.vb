Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmQuanliLSP
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=QuanLiBanHang.mssql.somee.com;packet size=4096;user id=duytcps03483_SQLLogin_1;pwd=p7ejcpv4fs;data source=QuanLiBanHang.mssql.somee.com;persist security info=False;initial catalog=QuanLiBanHang"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnTim.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select * from LOAI_SANPHAM where MALOAI_SP='" & txtMALOAI_SP.Text & "'", connect)
        Try

            If txtMALOAI_SP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                db.Clear()
                dgvSanpham.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvSanpham.DataSource = db.DefaultView
                    txtMALOAI_SP.Text = Nothing
                Else
                    MessageBox.Show("Không tìm thấy")
                    txtMALOAI_SP.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub quanlisanpham_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select * from LOAI_SANPHAM", conn)
        db.Clear()
        refesh.Fill(db)
        dgvSanpham.DataSource = db.DefaultView
    End Sub
    Private Sub dgvSanpham_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSanpham.CellContentClick
        Dim click As Integer = dgvSanpham.CurrentCell.RowIndex
        txtMALOAI_SP.Text = dgvSanpham.Item(0, click).Value
        txtTenloai_SP.Text = dgvSanpham.Item(1, click).Value
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select * from LOAI_SANPHAM", conn)
        conn.Open()
        load.Fill(db)
        dgvSanpham.DataSource = db.DefaultView
    End Sub
    Private Sub btnCapnhat_Click(sender As Object, e As EventArgs) Handles btnCapnhat.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update LOAI_SANPHAM set MALOAI_SP=@MALOAI, TENLOAI_SP=@TENLOAI where MALOAI_SP=@MALOAI"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        Try
            txtMALOAI_SP.Focus()
            If txtMALOAI_SP.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMALOAI_SP.Focus()
                If txtTenloai_SP.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    addupdate.Parameters.AddWithValue("@MALOAI", txtMALOAI_SP.Text)
                    addupdate.Parameters.AddWithValue("@TENLOAI", txtTenloai_SP.Text)
                    addupdate.ExecuteNonQuery()
                    conn.Close() 'đóng kết nối
                    MessageBox.Show("Cập nhật thành công")
                    txtMALOAI_SP.Text = Nothing
                    txtTenloai_SP.Text = Nothing
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvSanpham.DataSource = db
        dgvSanpham.DataSource = Nothing
        LoadData()
    End Sub
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim delquery As String = "delete from SANPHAM where MALOAI_SP=@MALOAI delete from LOAI_SANPHAM where MALOAI_SP=@MALOAI"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If txtMALOAI_SP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtMALOAI_SP.Focus()
            Else
                If resulft = DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MALOAI", txtMALOAI_SP.Text)
                    delete.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox
                    txtMALOAI_SP.Text = Nothing
                    txtTenloai_SP.Text = Nothing
                    txtMALOAI_SP.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã sản phẩm cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
        'làm mới bảng
        db.Clear()
        dgvSanpham.DataSource = db
        dgvSanpham.DataSource = Nothing
        LoadData()
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into LOAI_SANPHAM values(@MALOAI,@TENLOAI)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
            txtMALOAI_SP.Focus()
            If txtMALOAI_SP.Text = "" Then
                MessageBox.Show("Bạn chưa nhập tên loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMALOAI_SP.Focus()
                If txtTenloai_SP.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập Đơn vị tính", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    save.Parameters.AddWithValue("@MALOAI", txtMALOAI_SP.Text)
                    save.Parameters.AddWithValue("@TENLOAI", txtTenloai_SP.Text)
                    save.ExecuteNonQuery()
                    MessageBox.Show("Lưu thành công")
                    'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                    txtMALOAI_SP.Text = Nothing
                    txtTenloai_SP.Text = Nothing
                End If
            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã sản phẩm", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select * from LOAI_SANPHAM", conn)
        db.Clear()
        refesh.Fill(db)
        dgvSanpham.DataSource = db.DefaultView
    End Sub
End Class