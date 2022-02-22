Imports System.IO
Imports System.Text
Imports Newtonsoft.Json
Imports System.Net
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports Json

Public Class uc_pt_detail
    Dim fmain As frmmain
    Dim keyb As frmkeyborad
    Dim json As String = ""
    Dim dt As New DataTable
    Dim querydata As New clsQuery

    Private Sub uc_pt_detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmmain.tm_check_smcard_true.Start()
        Dim client = New WebClient()
        client.Encoding = Encoding.UTF8
        Try

            'cid = "3160600755138"
            'json = client.DownloadString("http://localhost:8189/api/smartcard/read?readImageFlag=false")
            'Dim obj As json_result
            'obj = JsonConvert.DeserializeObject(Of json_result)(json)
            ''condition
            'cid = obj.pid
            'patient_name = obj.fname + " " + obj.lname
            'main_pttype = obj.mainInscl
            'sub_pttype = obj.subInscl
            'correlationId = obj.correlationId
            'claim_type = "PG0060001"
            'claim_type_name = "เข้ารับบริการรักษาทั่วไป (OPD/ IPD/ PP)"
            'hos_main = ""
            'hos_main_name = ""
            'cur_date = CStr(CInt(DateTime.Now.ToString("yyyy")) - 543) + DateTime.Now.ToString("-MM-dd")
            'cur_time = DateTime.Now.ToString("HH:mm:ss")

            'textbox
            tb_cid.Text = cid
            tb_name.Text = patient_name
            tb_main_pt.Text = main_pttype
            tb_sub_pt.Text = sub_pttype
            tb_phonenum.Text = phone_number

            If tb_cid.Text <> "" And tb_phonenum.Text <> "" Then
                btn_success.Enabled = True
                frmmain.tm_check_smcard_true.Start()
            End If
        Catch ex As Exception

        End Try

        'btn_success.Enabled = False
    End Sub

    Sub Main()
        'Label1.Text = myRequest.ToString
        Try
            JsonData = "{""pid"": """ & cid & """,""claimType"": """ & claim_type & """,""mobile"": """ & phone_number & """,""correlationId"": """ & correlationId & """}"
            Dim myRequest As HttpWebRequest = PostJSON(JsonData)
            getrequest = GetResponse(myRequest)
            If getrequest = "The remote server returned an error: (400) Bad Request." Then
                Dim show As New mb.ShowMessagebox
                show.Fonts(New Font("TH SarabunPSK", 28, FontStyle.Bold))
                show.ShowBox(" Error : " + getrequest, mb.MStyle.ok, mb.FStyle.Critical, "การแจ้งเตือนสถานะ")
            Else
                'get json and covert string
                Dim js_claim_code As json_claimcode
                js_claim_code = JsonConvert.DeserializeObject(Of json_claimcode)(getrequest)
                claim_code = js_claim_code.claimCode
                'insert authenhos
                querydata.insert_authen(cid, patient_name, claim_type, claim_type_name, main_pttype, sub_pttype, hos_main, hos_main_name, correlationId, phone_number, cur_date, cur_time, claim_code)

                Dim show As New mb.ShowMessagebox
                show.Fonts(New Font("TH SarabunPSK", 30, FontStyle.Bold))
                show.ShowBox(" บันทึกข้อมูลสำเร็จ กรุณานำบัตรประชาชนออก ", mb.MStyle.ok, mb.FStyle.Information, "การแจ้งเตือนสถานะ")
                frmmain.lb_status_smart.Text = "Waiting Insert Card"
            End If
        Catch ex As Exception
            Dim show As New mb.ShowMessagebox
            show.Fonts(New Font("TH SarabunPSK", 28, FontStyle.Bold))
            show.ShowBox(" Error : " + getrequest, mb.MStyle.ok, mb.FStyle.Critical, "การแจ้งเตือนสถานะ")
        End Try
        'frmmain.btn_header.Text = "กรุณาเสียบบัตรประชาชน"
    End Sub

    Private Function PostJSON(ByVal JsonData As String) As HttpWebRequest
        Dim objhttpWebRequest As HttpWebRequest
        Try
            Dim httpWebRequest = DirectCast(WebRequest.Create("http://localhost:8189/api/nhso-service/confirm-save"), HttpWebRequest)
            httpWebRequest.ContentType = "application/json; charset=UTF-8"
            httpWebRequest.Method = "POST"
            httpWebRequest.Accept = "application/json"

            Using streamWriter = New StreamWriter(httpWebRequest.GetRequestStream())
                streamWriter.Write(JsonData)
                streamWriter.Flush()
                streamWriter.Close()
            End Using

            objhttpWebRequest = httpWebRequest

        Catch ex As Exception
            Console.WriteLine("Send Request Error[{0}]", ex.Message)

            Return Nothing
        End Try

        Return objhttpWebRequest

    End Function
    Private Function GetResponse(ByVal httpWebRequest As HttpWebRequest) As String
        Dim strResponse As String = "Bad Request:400"
        Try
            Dim httpResponse = DirectCast(httpWebRequest.GetResponse(), HttpWebResponse)
            Using streamReader = New StreamReader(httpResponse.GetResponseStream())
                Dim result = streamReader.ReadToEnd()

                strResponse = result.ToString()
            End Using
        Catch ex As Exception
            Console.WriteLine("GetResponse Error[{0}]", ex.Message)

            Return ex.Message
        End Try

        Return strResponse

    End Function

    Private Sub btn_success_Click(sender As Object, e As EventArgs) Handles btn_success.Click
        Dim cliamdate As DateTime
        Dim checkdate As DateTime
        Dim cliam As String = ""
        Dim check As String = ""
        Dim json As String = ""
        Dim client = New WebClient()
        Try
            client.Encoding = Encoding.UTF8
            'json = client.DownloadString("http://localhost:8189/api/smartcard/read?readImageFlag=false")
            json = client.DownloadString("http://localhost:8189/api/nhso-service/latest-authen-code/" & cid & "")
            Dim last_authen As json_lastauthen
            last_authen = JsonConvert.DeserializeObject(Of json_lastauthen)(json)
            cliamdate = Convert.ToDateTime(last_authen.claimDateTime)
            checkdate = Convert.ToDateTime(last_authen.checkDate)
            cliam = cliamdate.ToString("yyyy-MM-dd")
            check = checkdate.ToString("yyyy-MM-dd")
            If cliam = check Then
                Dim show As New mb.ShowMessagebox
                show.Fonts(New Font("TH SarabunPSK", 28, FontStyle.Bold))
                show.ShowBox(" คุณเคยขอ Authen แล้ว กรุณานำบัตรออก ", mb.MStyle.ok, mb.FStyle.Critical, "การแจ้งเตือนสถานะ")
            Else
                Main()
            End If

        Catch ex As Exception
            Dim show As New mb.ShowMessagebox
            show.Fonts(New Font("TH SarabunPSK", 28, FontStyle.Bold))
            show.ShowBox(" การเขื่อมต่อล้มเหลว ", mb.MStyle.ok, mb.FStyle.Critical, "การแจ้งเตือนสถานะ")
        End Try

        btn_success.Enabled = False

    End Sub


    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles btn_pic.Click

        frmkeyborad.ShowDialog()
        tb_phonenum.Text = phone_number
        If tb_phonenum.Text = "" And tb_cid.Text = "" Then
            btn_success.Enabled = False
        ElseIf tb_phonenum.Text <> "" And tb_cid.Text <> "" Then
            btn_success.Enabled = True
            frmmain.tm_check_smcard_true.Start()
        End If

    End Sub


End Class
