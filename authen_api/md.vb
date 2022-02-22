
Module md
    Public ConStrsql As String = My.Settings.conAuthen
    Public pt_detail As New uc_pt_detail
    Public getrequest As String = ""
    Public JsonData As String = ""
    Public correlationId As String = ""
    Public cid As String = ""
    Public patient_name As String = ""
    Public claim_type As String = ""
    Public claim_type_name As String = ""
    Public main_pttype As String = ""
    Public sub_pttype As String = ""
    Public hos_main As String = ""
    Public hos_main_name As String = ""
    Public phone_number As String = ""
    Public claim_code As String = ""
    Public cur_date As String = ""
    Public cur_time As String = ""
    Public hosCode As String = ""


    Public Class json_result
        Public pid As String
        Public titleName As String
        Public fname As String
        Public lname As String
        Public nation As String
        Public birthDate As String
        Public sex As String
        Public transDate As String
        Public mainInscl As String
        Public subInscl As String
        Public correlationId As String
        Public age As String
        Public checkDate As String

    End Class
    Public Class json_claimcode
        Public pid As String
        Public claimType As String
        Public correlationId As String
        Public createdDate As String
        Public claimCode As String
    End Class

    Public Class json_lastauthen
        Public claimType As String
        Public claimCode As String
        Public hcode As String
        Public claimDateTime As String
        Public checkDate As String
    End Class

    Public Sub resetValue()
        getrequest = ""
        JsonData = ""
        correlationId = ""
        cid = ""
        patient_name = ""
        main_pttype = ""
        sub_pttype = ""
        hos_main = ""
        hos_main_name = ""
        phone_number = ""
        claim_code = ""
        cur_date = ""
        cur_time = ""
    End Sub
    Public Sub cleartb()
        pt_detail.tb_cid.Clear()
        pt_detail.tb_name.Clear()
        pt_detail.tb_main_pt.Clear()
        pt_detail.tb_sub_pt.Clear()
        pt_detail.tb_phonenum.Clear()
    End Sub

    Public Sub show_server()
        Dim splitt = ConStrsql.Split(";"c)
        Dim sv As String = ""
        If (splitt.Count <= 6) Then
            sv = splitt(0).ToString
        End If
        'split server
        splitt = sv.Split("="c)
        frmmain.lb_server.Text = "Server Connection : " + splitt(1).ToString

    End Sub


End Module