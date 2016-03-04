Imports System.Data.SqlClient
Public Class frmDangnhap
    'khai bao bien toan cuc de ket noi CSDL
    Private _connectionstring As String = "workstation id=QuanLiBanHang.mssql.somee.com;packet size=4096;user id=duytcps03483_SQLLogin_1;pwd=p7ejcpv4fs;data source=QuanLiBanHang.mssql.somee.com;persist security info=False;initial catalog=QuanLiBanHang"
    Private conn As SqlConnection
    Private da As SqlDataAdapter

    'Dinh nghia ham lay du lieu do vao bảng
    Private Function getdatatable(sqlQuery As String) As DataTable
        Dim dTable As New DataTable
        'khoi tao bien conn
        conn = New SqlConnection(_connectionstring)
        'khoi tao bien da
        da = New SqlDataAdapter(sqlQuery, conn)
        Try
            ' mo connection
            conn.Open()
            'do du lieu vao dTable
            da.Fill(dTable)
        Catch ex As Exception
            'thong bao loi neu co loi xay ra
            MessageBox.Show(ex.Message, "Lỗi")
        Finally
            'dong ket noi
            conn.Close()
        End Try
        Return dTable
    End Function
    ' dinh nghia ham kiem tra taikhoan va matkhau
    Private Function checklogin(user As String, pass As String)
        Dim sqlQuery As String = String.Format("Select * from dbo.taikhoan where username= '{0}' and pass='{1}'", user, pass)
        Dim Dtable As DataTable = getdatatable(sqlQuery)
        Return Dtable.Rows.Count > 0
    End Function
    ' dinh nghia hàm kiem tra user, pass nhap vao co rong hay khong
    Private Function rong() As Boolean
        ' ham tra ve true neu username va pass la rong
        Return String.IsNullOrEmpty(Me.txttk.Text) OrElse String.IsNullOrEmpty(Me.txtmk.Text)
    End Function
    Private Sub btnDangnhap_Click(sender As Object, e As EventArgs) Handles btnDangnhap.Click
        'kiem tra username va pass co nhap vao hay khong
        If rong() Then
            MessageBox.Show("Tài khoản, mật khẩu không được rỗng")
        Else
            If checklogin(Me.txttk.Text.ToLower, Me.txtmk.Text.ToLower) Then
                'dang nhap thanh cong
                Me.DialogResult = DialogResult.OK
                MessageBox.Show("Đăng nhập thành công")
                Me.Close()
            Else ' truong hop sai username va pass 
                MessageBox.Show("Tài khoản và mật khẩu không đúng, yêu cầu nhập lại")
                txtmk.Text = Nothing
                txttk.Text = Nothing
            End If
        End If
    End Sub
    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnDangki.Click
        frmDangki.Show()
    End Sub
    Private Sub txtTacGia_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles txtmk.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            btnDangnhap.PerformClick()
        End If
    End Sub
End Class