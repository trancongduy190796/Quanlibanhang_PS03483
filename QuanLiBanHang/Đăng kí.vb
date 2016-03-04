Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmDangki
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=QuanLiBanHang.mssql.somee.com;packet size=4096;user id=duytcps03483_SQLLogin_1;pwd=p7ejcpv4fs;data source=QuanLiBanHang.mssql.somee.com;persist security info=False;initial catalog=QuanLiBanHang"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub btnTao_Click(sender As Object, e As EventArgs) Handles btnTao.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into taikhoan values(@username,@pass)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
            txtusername.Focus()
            If txtusername.Text = "" Then
                MessageBox.Show("Bạn chưa nhập tên tài khoản", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtusername.Focus()
                If txtpass.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập mật khẩu", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    save.Parameters.AddWithValue("@username", txtusername.Text)
                    save.Parameters.AddWithValue("@pass", txtpass.Text)
                    save.ExecuteNonQuery()
                    MessageBox.Show("Tạo thành công")
                    'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....                    
                    Me.Close()
                End If
            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Tài khoản đã tồn tại", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtTacGia_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles txtpass.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            btnTao.PerformClick()
        End If
    End Sub

End Class
