Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmQuanliKH
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=QuanLiBanHang.mssql.somee.com;packet size=4096;user id=duytcps03483_SQLLogin_1;pwd=p7ejcpv4fs;data source=QuanLiBanHang.mssql.somee.com;persist security info=False;initial catalog=QuanLiBanHang"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub dgvKH_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKH.CellContentClick
        Dim click As Integer = dgvKH.CurrentCell.RowIndex
        txtMaKH.Text = dgvKH.Item(0, click).Value
        txtHOKH.Text = dgvKH.Item(1, click).Value
        txtTENKH.Text = dgvKH.Item(2, click).Value
        txtDiachi.Text = dgvKH.Item(3, click).Value
        txtSDT.Text = dgvKH.Item(4, click).Value
        txtEmail.Text = dgvKH.Item(5, click).Value
    End Sub
    Private Sub LoadData()
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MA_KH as 'Mã KH' , HO_KH as 'Họ Khách Hàng', TEN_KH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', DIENTHOAI as 'SĐT', EMAIL from KHACHHANG", conn)
        conn.Open()
        load.Fill(db)
        dgvKH.DataSource = db.DefaultView
        conn.Close()
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim query As String = "insert into KHACHHANG values(@MA_KH,@HO_KH,@TEN_KH,@DIACHI,@DIENTHOAI,@EMAIL)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
            txtMaKH.Focus()
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn chưa nhập Mã Khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMaKH.Focus()
                If txtTENKH.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtDiachi.Focus()
                    If txtSDT.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập số điện thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtSDT.Focus()
                        If txtEmail.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập email", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            txtEmail.Focus()
                        Else
                            save.Parameters.AddWithValue("@MA_KH", txtMaKH.Text)
                            save.Parameters.AddWithValue("@HO_KH", txtHOKH.Text)
                            save.Parameters.AddWithValue("@TEN_KH", txtTENKH.Text)
                            save.Parameters.AddWithValue("@DIACHI", txtDiachi.Text)
                            save.Parameters.AddWithValue("@DIENTHOAI", txtSDT.Text)
                            save.Parameters.AddWithValue("@EMAIL", txtEmail.Text)
                            save.ExecuteNonQuery()
                            MessageBox.Show("Thêm thành công")
                            'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                            txtMaKH.Text = Nothing
                            txtHOKH.Text = Nothing
                            txtTENKH.Text = Nothing
                            txtDiachi.Text = Nothing
                            txtSDT.Text = Nothing
                            txtEmail.Text = Nothing

                        End If
                    End If
                End If
            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã khách hàng", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MA_KH as 'Mã KH' , HO_KH as 'Họ Khách Hàng', TEN_KH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', DIENTHOAI as 'SĐT', EMAIL from KHACHHANG", conn)
        db.Clear()
        refesh.Fill(db)
        dgvKH.DataSource = db.DefaultView
        conn.Close()
    End Sub
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim delquery As String = "delete from KHACHHANG where MA_KH=@MA_KH"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtMaKH.Focus()
            Else
                If resulft = DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MA_KH", txtMaKH.Text)
                    delete.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox, combox và date....
                    txtMaKH.Text = Nothing
                    txtHOKH.Text = Nothing
                    txtTENKH.Text = Nothing
                    txtDiachi.Text = Nothing
                    txtSDT.Text = Nothing
                    txtEmail.Text = Nothing
                    txtMaKH.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã khách hàng cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
        'làm mới bảng
        db.Clear()
        dgvKH.DataSource = db
        dgvKH.DataSource = Nothing
        LoadData()
        conn.Close()
    End Sub
    Private Sub btnCapnhat_Click(sender As Object, e As EventArgs) Handles btnCapnhat.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update KHACHHANG set MA_KH=@MA_KH, HO_KH=@HO_KH, TEN_KH=@TEN_KH, DIACHI=@DIACHI, DIENTHOAI=@SDT, EMAIL=@EMAIL where MA_KH=@MA_KH"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        Try
            txtMaKH.Focus()
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMaKH.Focus()
                If txtHOKH.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập họ khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtHOKH.Focus()
                    If txtTENKH.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtTENKH.Focus()
                        If txtDiachi.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập địa chỉ khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtDiachi.Focus()
                            If txtSDT.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập số điện thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                txtSDT.Focus()
                                If txtEmail.Text = "" Then
                                    MessageBox.Show("Bạn chưa nhập email", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                                Else
                                    addupdate.Parameters.AddWithValue("@MA_KH", txtMaKH.Text)
                                    addupdate.Parameters.AddWithValue("@HO_KH", txtHOKH.Text)
                                    addupdate.Parameters.AddWithValue("@TEN_KH", txtTENKH.Text)
                                    addupdate.Parameters.AddWithValue("@DIACHI", txtDiachi.Text)
                                    addupdate.Parameters.AddWithValue("@SDT", txtSDT.Text)
                                    addupdate.Parameters.AddWithValue("@EMAIL", txtEmail.Text)
                                    addupdate.ExecuteNonQuery()
                                    conn.Close()
                                    'đóng kết nối
                                    MessageBox.Show("Cập nhật thành công")
                                    txtMaKH.Text = Nothing
                                    txtHOKH.Text = Nothing
                                    txtTENKH.Text = Nothing
                                    txtDiachi.Text = Nothing
                                    txtSDT.Text = Nothing
                                    txtEmail.Text = Nothing
                                End If
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
        dgvKH.DataSource = db
        dgvKH.DataSource = Nothing
        LoadData()
        conn.Close()
    End Sub
    Private Sub btntim_click(sender As Object, e As EventArgs) Handles btnTim.Click
        conn.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select MA_KH as 'Mã KH' , HO_KH as 'Họ Khách Hàng', TEN_KH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', DIENTHOAI as 'SĐT', EMAIL from KHACHHANG where MA_KH='" & txttim.Text & "'", conn)
        Try
            If txttim.Text = "" Then
                MessageBox.Show("Bạn cần nhập MAKH", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                db.Clear()
                dgvKH.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvKH.DataSource = db.DefaultView
                    txttim.Text = Nothing
                    btnXoa.Enabled = True
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
    Private Sub btnLoad_Click_1(sender As Object, e As EventArgs) Handles btnLoad.Click
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MA_KH as 'Mã KH' , HO_KH as 'Họ Khách Hàng', TEN_KH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', DIENTHOAI as 'SĐT', EMAIL from KHACHHANG", conn)
        db.Clear()
        refesh.Fill(db)
        dgvKH.DataSource = db.DefaultView
        conn.Close()
    End Sub
    Private Sub frmQuanliKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MA_KH as 'Mã KH' , HO_KH as 'Họ Khách Hàng', TEN_KH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', DIENTHOAI as 'SĐT', EMAIL from KHACHHANG", conn)
        db.Clear()
        refesh.Fill(db)
        dgvKH.DataSource = db.DefaultView
        conn.Close()
        txttim.Font = New Font(txttim.Font, FontStyle.Italic)
        txttim.ForeColor = Color.Gainsboro
        txttim.Text = "nhập mã sản phẩm"
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