Imports System.Data.Odbc
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class classExcute
    Public Function Fill(ByVal cmd As MySqlCommand) As DataTable
        Dim dt As New DataTable
        '   Dim conStr As String = "server = 192.168.0.199 ; userid = birdproject; password = misbanh; database = hos"
        cmd.Connection = New MySqlConnection(ConStrsql)
        Try
            cmd.Connection.Open()
            Using da As New MySqlDataAdapter(cmd)
                If Not dt Is Nothing Then dt.Clear()
                da.Fill(dt)
                Return dt
            End Using
        Catch ex As Exception
            Return Nothing
        Finally
            cmd.Connection.Close()
            cmd.Connection.Dispose()
        End Try
    End Function

    Public Function ExecuteNonQuery(ByVal cmd As MySqlCommand) As Boolean
        Dim ret As Boolean
        Using conn As New MySqlConnection(ConStrsql)
            conn.Open()
            Dim trans As MySqlTransaction = conn.BeginTransaction
            cmd.Connection = conn
            cmd.Transaction = trans
            Try
                cmd.ExecuteNonQuery()
                trans.Commit()
                ret = True
            Catch ex As SqlException
                ret = False
            Finally
                conn.Close()
                conn.Dispose()
            End Try
        End Using
        Return ret
    End Function
End Class
