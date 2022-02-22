Imports System.Data.SqlClient
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class clsQuery
    Dim clsexc As New classExcute
    Dim sb As New StringBuilder

    Public Function insert_authen(ByVal pid As String, ByVal name As String, ByVal claim_type As String,
                                ByVal claim_type_name As String, ByVal main_incscl As String,
                                ByVal sub_incscl As String, ByVal hmain_code As String,
                                ByVal hmain_name As String, ByVal correlation_id As String,
                                ByVal mobile As String, ByVal created_date As String,
                                ByVal created_time As String, ByVal claim_code As String)
        sb.Clear()
        sb.Append("insert into authenhos (pid,name,claim_type,claim_type_name,main_incscl,sub_incscl," & vbCrLf)
        sb.Append("hmain_code,hmain_name,correlation_id,mobile,created_date,created_time,claim_code) " & vbCrLf)
        sb.Append("VALUES (" & vbCrLf)
        sb.Append("'" & pid & "'," & vbCrLf)
        sb.Append("'" & name & "'," & vbCrLf)
        sb.Append("'" & claim_type & "'," & vbCrLf)
        sb.Append("'" & claim_type_name & "'," & vbCrLf)
        sb.Append("'" & main_incscl & "'," & vbCrLf)
        sb.Append("'" & sub_incscl & "'," & vbCrLf)
        sb.Append("'" & hmain_code & "'," & vbCrLf)
        sb.Append("'" & hmain_name & "'," & vbCrLf)
        sb.Append("'" & correlation_id & "'," & vbCrLf)
        sb.Append("'" & mobile & "'," & vbCrLf)
        sb.Append("'" & created_date & "'," & vbCrLf)
        sb.Append("'" & created_time & "'," & vbCrLf)
        sb.Append("'" & claim_code & "')" & vbCrLf)
        Using cmd As New MySqlCommand(sb.ToString)
            Return clsexc.ExecuteNonQuery(cmd)
        End Using
    End Function

End Class
