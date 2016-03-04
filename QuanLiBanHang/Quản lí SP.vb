Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmQuanliSP
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=QuanLiBanHang.mssql.somee.com;packet size=4096;user id=duytcps03483_SQLLogin_1;pwd=p7ejcpv4fs;data source=QuanLiBanHang.mssql.somee.com;persist security info=False;initial catalog=QuanLiBanHang"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnTim_Click(sender As Object, e As EventArgs) Handles btnTim.Click
        conn.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select MA_SP as 'Mã sản phẩm',MALOAI_SP as 'Mã Loại', TEN_SP as 'Tên sản phẩm',SOLUONG as 'Số lượng',DONVITINH as 'Đơn vị tính',DONGIA as'Đơn giá' from SANPHAM where SANPHAM.MA_SP='" & txttim.Text & "'", conn)
        Try
            If txttim.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                db.Clear()
                dgvSanpham.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvSanpham.DataSource = db.DefaultView
                    txttim.Text = Nothing
                Else
                    MessageBox.Show("Không tìm thấy")
                    txttim.Text = Nothing
                End If
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Không tìm thấy")
        End Try
    End Sub
    Private Sub quanlisanpham_load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MA_SP as 'Mã sản phẩm',MALOAI_SP as 'Mã Loại', TEN_SP as 'Tên sản phẩm',SOLUONG as 'Số lượng',DONVITINH as 'Đơn vị tính',DONGIA as'Đơn giá' from SANPHAM", conn)
        db.Clear()
        refesh.Fill(db)
        dgvSanpham.DataSource = db.DefaultView
        conn.Close()
        Dim a As New Class1
        cbbMASP.DataSource = a.SANPHAM("MA_SP").Tables(0)
        cbbMASP.DisplayMember = "MA_SP"
        cbbMASP.DataSource = a.LOAISANPHAM("MALOAI_SP").Tables(0)
        cbbMASP.DisplayMember = "MALOAI_SP"
        txttim.Font = New Font(txttim.Font, FontStyle.Italic)
        txttim.ForeColor = Color.Gainsboro
        txttim.Text = "nhập mã sản phẩm"
    End Sub
    Private Sub dgvSanpham_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSanpham.CellContentClick
        Dim click As Integer = dgvSanpham.CurrentCell.RowIndex
        txtMA_SP.Text = dgvSanpham.Item(0, click).Value
        cbbMASP.Text = dgvSanpham.Item(1, click).Value
        txtTEN_SP.Text = dgvSanpham.Item(2, click).Value
        txtDonvitinh.Text = dgvSanpham.Item(4, click).Value
        txtSoluong.Text = dgvSanpham.Item(3, click).Value
        txtDONGIA.Text = dgvSanpham.Item(5, click).Value
    End Sub
    Private Sub LoadData()
        conn.Open()
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MA_SP as 'Mã sản phẩm',MALOAI_SP as 'Mã Loại', TEN_SP as 'Tên sản phẩm',SOLUONG as 'Số lượng',DONVITINH as 'Đơn vị tính',DONGIA as'Đơn giá' from SANPHAM", conn)
        load.Fill(db)
        dgvSanpham.DataSource = db.DefaultView
        conn.Close()
    End Sub
    Private Sub btnCapnhat_Click(sender As Object, e As EventArgs) Handles btnCapnhat.Click
        Dim updatequery As String = "update SANPHAM set MA_SP=@MASP,MALOAI_SP=@MALOAI, TEN_SP=@TENSP, DONVITINH=@DONVITINH, SOLUONG=@SOLUONG, DONGIA=@DONGIA where MA_SP=@MASP "
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        Try
            txtMA_SP.Focus()
            If txtMA_SP.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMA_SP.Focus()
                If txtTEN_SP.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTEN_SP.Focus()
                    If txtDonvitinh.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập mã loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtDonvitinh.Focus()
                        If txtSoluong.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập số lượng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtSoluong.Focus()
                            If txtDONGIA.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập đơn giá ", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                addupdate.Parameters.AddWithValue("@MASP", txtMA_SP.Text)
                                addupdate.Parameters.AddWithValue("@MALOAI", cbbMASP.Text)
                                addupdate.Parameters.AddWithValue("@TENSP", txtTEN_SP.Text)
                                addupdate.Parameters.AddWithValue("@DONVITINH", txtDonvitinh.Text)
                                addupdate.Parameters.AddWithValue("@SOLUONG", txtSoluong.Text)
                                addupdate.Parameters.AddWithValue("@DONGIA", txtDONGIA.Text)
                                addupdate.ExecuteNonQuery()
                                conn.Close() 'đóng kết nối
                                MessageBox.Show("Cập nhật thành công")
                                txtMA_SP.Text = Nothing
                                txtTEN_SP.Text = Nothing
                                txtDonvitinh.Text = Nothing
                                txtSoluong.Text = Nothing
                                txtDONGIA.Text = Nothing
                            End If
                        End If
                    End If
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
        conn.Close()
    End Sub
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim delquery As String = "delete from CHITIET_HOADON where MA_SP=@MA_SP delete from SANPHAM where MA_SP=@MA_SP"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If txtMA_SP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtMA_SP.Focus()
            Else
                If resulft = DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MA_SP", txtMA_SP.Text)
                    delete.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox
                    txtMA_SP.Text = Nothing
                    txtTEN_SP.Text = Nothing
                    txtDonvitinh.Text = Nothing
                    txtSoluong.Text = Nothing
                    txtDONGIA.Text = Nothing
                    txtMA_SP.Focus()
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
        conn.Close()
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into SANPHAM values(@MASP,@MALOAI_SP,@TENSP,@DONVITINH,@DONGIA,@SOLUONG)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
            txtMA_SP.Focus()
            If txtMA_SP.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMA_SP.Focus()
                If txtTEN_SP.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTEN_SP.Focus()
                    If txtDonvitinh.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập Đơn vị tính", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtDonvitinh.Focus()
                        If txtSoluong.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập số lượng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtSoluong.Focus()
                            If txtDONGIA.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập đơn giá", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                save.Parameters.AddWithValue("@MASP", txtMA_SP.Text)
                                save.Parameters.AddWithValue("@MALOAI_SP", cbbMASP.Text)
                                save.Parameters.AddWithValue("@TENSP", txtTEN_SP.Text)
                                save.Parameters.AddWithValue("@DONVITINH", txtDonvitinh.Text)
                                save.Parameters.AddWithValue("@SOLUONG", (txtSoluong.Text))
                                save.Parameters.AddWithValue("@DONGIA", (txtDONGIA.Text))
                                save.ExecuteNonQuery()
                                MessageBox.Show("Thêm thành công")
                                'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                                txtMA_SP.Text = Nothing
                                cbbMASP.Text = Nothing
                                txtTEN_SP.Text = Nothing
                                txtDonvitinh.Text = Nothing
                                txtSoluong.Text = Nothing
                                txtDONGIA.Text = Nothing
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã sản phẩm", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MA_SP as 'Mã sản phẩm',MALOAI_SP as 'Mã Loại', TEN_SP as 'Tên sản phẩm',SOLUONG as 'Số lượng',DONVITINH as 'Đơn vị tính',DONGIA as'Đơn giá' from SANPHAM", conn)
        db.Clear()
        refesh.Fill(db)
        dgvSanpham.DataSource = db.DefaultView
        conn.Close()
    End Sub
    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MA_SP as 'Mã sản phẩm',MALOAI_SP as 'Mã Loại', TEN_SP as 'Tên sản phẩm',SOLUONG as 'Số lượng',DONVITINH as 'Đơn vị tính',DONGIA as'Đơn giá' from SANPHAM", conn)
        db.Clear()
        refesh.Fill(db)
        dgvSanpham.DataSource = db.DefaultView
        conn.Close()
    End Sub
    Private Sub txtTacGia_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles txttim.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            btnTim.PerformClick()
        End If
    End Sub
    Private Sub txttim_MouseLeave(sender As Object, e As EventArgs) Handles txttim.MouseLeave
        txttim.Font = New Font(txttim.Font, FontStyle.Italic)
        txttim.ForeColor = Color.Gainsboro
        txttim.Text = "nhập mã sản phẩm"
    End Sub
    Private Sub txttim_MouseHover(sender As Object, e As EventArgs) Handles txttim.MouseHover
        txttim.Text = ""
        txttim.ForeColor = Color.Black
    End Sub

End Class
