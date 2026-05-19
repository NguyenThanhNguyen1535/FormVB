Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class SQLDatabase
    ' Cập nhật tên CSDL mặc định thành Quanlitiendienthoai2
    Public Shared strConn As String = "Data Source=localhost;Initial Catalog=Quanlitiendienthoai2;Integrated Security=True;TrustServerCertificate=True"

    Public Shared Function GetData(ByVal sql As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As New SqlConnection(strConn)
                Dim da As New SqlDataAdapter(sql, conn)
                da.Fill(dt)
            End Using
        Catch ex As Exception
            MsgBox("Lỗi GetData: " & ex.Message)
        End Try
        Return dt
    End Function

    ' Overload với Parameters
    Public Shared Function GetData(ByVal sql As String, ParamArray parameters As SqlParameter()) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As New SqlConnection(strConn)
                Dim cmd As New SqlCommand(sql, conn)
                If parameters IsNot Nothing Then
                    For Each p In parameters
                        cmd.Parameters.Add(p)
                    Next
                End If
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
        Catch ex As Exception
            MsgBox("Lỗi GetData: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Shared Function Execute(ByVal sql As String) As Integer
        Dim result As Integer = 0
        Try
            Using conn As New SqlConnection(strConn)
                Dim cmd As New SqlCommand(sql, conn)
                conn.Open()
                result = cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox("Lỗi Execute: " & ex.Message)
        End Try
        Return result
    End Function

    ' Overload với Parameters
    Public Shared Function Execute(ByVal sql As String, ParamArray parameters As SqlParameter()) As Integer
        Dim result As Integer = 0
        Try
            Using conn As New SqlConnection(strConn)
                Dim cmd As New SqlCommand(sql, conn)
                If parameters IsNot Nothing Then
                    For Each p In parameters
                        cmd.Parameters.Add(p)
                    Next
                End If
                conn.Open()
                result = cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox("Lỗi Execute: " & ex.Message)
        End Try
        Return result
    End Function

    ' Bổ sung hàm tiện ích ExecuteScalar phục vụ lấy các giá trị đơn
    Public Shared Function ExecuteScalar(ByVal sql As String) As Object
        Dim result As Object = Nothing
        Try
            Using conn As New SqlConnection(strConn)
                Dim cmd As New SqlCommand(sql, conn)
                conn.Open()
                result = cmd.ExecuteScalar()
            End Using
        Catch ex As Exception
            MsgBox("Lỗi ExecuteScalar: " & ex.Message)
        End Try
        Return result
    End Function

    ' Overload với Parameters
    Public Shared Function ExecuteScalar(ByVal sql As String, ParamArray parameters As SqlParameter()) As Object
        Dim result As Object = Nothing
        Try
            Using conn As New SqlConnection(strConn)
                Dim cmd As New SqlCommand(sql, conn)
                If parameters IsNot Nothing Then
                    For Each p In parameters
                        cmd.Parameters.Add(p)
                    Next
                End If
                conn.Open()
                result = cmd.ExecuteScalar()
            End Using
        Catch ex As Exception
            MsgBox("Lỗi ExecuteScalar: " & ex.Message)
        End Try
        Return result
    End Function

End Class
