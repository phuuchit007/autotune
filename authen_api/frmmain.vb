Imports MySql.Data.MySqlClient
Imports ThaiNationalIDCard
Imports PCSC
Imports System.ComponentModel
Imports System.Text
'Imports Microsoft.Reporting.WebForms
Imports Newtonsoft.Json
Imports System.Net


Public Class frmmain
    Implements IDisposable

    'Dim sb As New StringBuilder()
    'Dim da As New MySqlDataAdapter 'ตัวแปร อ่านข้อมูลที่เรา excute ออกมา
    'Dim dt As New DataTable 'ตารางไว้เก็บข้อมูลจาก dataAdapter
    'Dim CONNECTION As MySqlConnection 'ตัวแปร เชื่อม database
    'Dim COMMAND As MySqlCommand 'ตัวแปร sqlcommand
    'Dim bgWorker As New BackgroundWorker 'ตัวแปร BackgroundWorker 

    Private WithEvents idcard As New ThaiIDCard
    Dim check As Personal = idcard.readAllPhoto
    Dim data As String = ""
    Dim status_card As String = ""
    Dim reader As String()


    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim pt_detail = New uc_pt_detail
        Me.panel_pt_detail.Controls.Clear()
        pt_detail.Height = Me.panel_pt_detail.Height
        pt_detail.Width = Me.panel_pt_detail.Width
        Me.panel_pt_detail.Controls.Add(pt_detail)
        pt_detail.btn_success.Enabled = False
        SPcard.PortName = "COM3"
        SPcard.BaudRate = 115200
        'SPcard.Open()
        Dim cmd As New MySqlCommand
        cmd.Connection = New MySqlConnection(ConStrsql)
        Try
            cmd.Connection.Open()
            lb_con.Text = "Connection Success"
            'MsgBox("Connection Success")
        Catch ex As Exception
            lb_con.Text = "Connection Fail"
            'MsgBox("Connection fail")
        Finally
            cmd.Connection.Close()
            cmd.Connection.Dispose()
        End Try
        tbcon.Text = My.Settings.conAuthen
        show_server()
        Try
            idcard = New ThaiIDCard()
            reader = idcard.GetReaders()
            idcard.MonitorStart(reader(0).ToString)
            tb_cardreader.Text = idcard.GetReaders(0)
        Catch ex As Exception

        End Try

        'ProgressBar1.Visible = False

        '// Initialized BackGroundWorker
        'With bgWorker
        '    .WorkerReportsProgress = True
        '    .WorkerSupportsCancellation = True
        'End With
        ''// *********** IMPORTANT ***********
        Control.CheckForIllegalCrossThreadCalls = False
        ''// Add Event Handler.
        'AddHandler bgWorker.DoWork, AddressOf BgWorker_DoWork
        'AddHandler bgWorker.RunWorkerCompleted, AddressOf bgWorker_RunWorkerCompleted


        AddHandler idcard.eventCardInserted, AddressOf iv_read

        'ผูก Sub Clear เข้ากับเหตุการณ์ eventCardRemoved
        AddHandler idcard.eventCardRemoved, AddressOf iv_clear
        'เช็คเครื่องอ่านบัตร
        If Not GetReader() Then Return

    End Sub

    Sub iv_read()
        lb_status_smart.Text = "Reading Card"
        BeginInvoke(New MethodInvoker(AddressOf ReadData))
    End Sub

    Sub iv_clear()
        BeginInvoke(New MethodInvoker(AddressOf clears))
    End Sub

    Sub monitor_strat()
        Try
            idcard = New ThaiIDCard()
            reader = idcard.GetReaders()
            idcard.MonitorStart(reader(0).ToString)
            tb_cardreader.Text = idcard.GetReaders(0)
            Refresh()
            'With bgWorker
            '    .WorkerReportsProgress = True
            '    .WorkerSupportsCancellation = True
            'End With
            ''// *********** IMPORTANT ***********
            'Control.CheckForIllegalCrossThreadCalls = False
            ''// Add Event Handler.
            'AddHandler bgWorker.DoWork, AddressOf BgWorker_DoWork
            'AddHandler bgWorker.RunWorkerCompleted, AddressOf bgWorker_RunWorkerCompleted


            AddHandler idcard.eventCardInserted, AddressOf iv_read

            'ผูก Sub Clear เข้ากับเหตุการณ์ eventCardRemoved
            AddHandler idcard.eventCardRemoved, AddressOf iv_clear
        Catch ex As Exception

        End Try

    End Sub
    Sub ReadData()
        tm_check_smcard_true.Stop()
        'Dim reader As Personal = idcard.readAllPhoto
        'Dim id As ThaiIDCard = New ThaiIDCard
        'Dim personal As Personal = id.readAllPhoto

        'toolt.Visible = True
        Try
            If Not reader Is Nothing Then
                'Dim cliamdate As DateTime
                'Dim checkdate As DateTime
                Dim cliam As String = ""
                Dim check As String = ""
                Dim json As String = ""
                Dim client = New WebClient()
                Try
                    client.Encoding = Encoding.UTF8
                    json = client.DownloadString("http://localhost:8189/api/smartcard/read?readImageFlag=false")
                    'json = client.DownloadString("http://localhost:8189/api/nhso-service/latest-authen-code/" & cid & "")
                    'Dim last_authen As json_lastauthen
                    'last_authen = JsonConvert.DeserializeObject(Of json_lastauthen)(json)
                    'cliamdate = Convert.ToDateTime(last_authen.claimDateTime)
                    'checkdate = Convert.ToDateTime(last_authen.checkDate)
                    'cliam = cliamdate.ToString("yyyy-MM-dd")
                    'check = checkdate.ToString("yyyy-MM-dd")
                    Dim obj As json_result
                    obj = JsonConvert.DeserializeObject(Of json_result)(json)
                    'condition
                    cid = obj.pid
                    patient_name = obj.fname + " " + obj.lname
                    main_pttype = obj.mainInscl
                    sub_pttype = obj.subInscl
                    correlationId = obj.correlationId
                    claim_type = "PG0060001"
                    claim_type_name = "เข้ารับบริการรักษาทั่วไป (OPD/ IPD/ PP)"
                    hos_main = ""
                    hos_main_name = ""
                    cur_date = CStr(CInt(DateTime.Now.ToString("yyyy")) - 543) + DateTime.Now.ToString("-MM-dd")
                    cur_time = DateTime.Now.ToString("HH:mm:ss")

                    'If cliam = check Then
                    '    Dim show As New mb.ShowMessagebox
                    '    show.Fonts(New Font("TH SarabunPSK", 28, FontStyle.Bold))
                    '    show.ShowBox(" คุณเคยขอ Authen แล้ว ", mb.MStyle.ok, mb.FStyle.Critical, "การแจ้งเตือนสถานะ")
                    'Else
                    Dim pt_detail = New uc_pt_detail
                        Me.panel_pt_detail.Controls.Clear()
                        pt_detail.Height = Me.panel_pt_detail.Height
                        pt_detail.Width = Me.panel_pt_detail.Width
                        Me.panel_pt_detail.Controls.Add(pt_detail)
                    'End If
                    btn_header.Text = "ตรวจสอบข้อมูลส่วนตัว และกดยืนยัน"
                Catch ex As Exception
                    Dim show As New mb.ShowMessagebox
                    show.Fonts(New Font("TH SarabunPSK", 28, FontStyle.Bold))
                    show.ShowBox(" การเขื่อมต่อล้มเหลว ", mb.MStyle.ok, mb.FStyle.Critical, "การแจ้งเตือนสถานะ")
                End Try

            ElseIf idcard.ErrorCode > 0 Then
                Select Case idcard.ErrorCode
                    Case Is = 256
                        MsgBox("ยังไม่ได้เชื่อมต่อเครื่องอ่านบัตรประชาชน" & vbCrLf & idcard.Error, CType(vbOKOnly + vbCritical, MsgBoxStyle), "Error")
                        ' Timer1.Stop()
                    Case Else
                        MsgBox(vbCrLf & idcard.Error, CType(vbOKOnly + vbCritical, MsgBoxStyle), "Error")
                End Select
            End If
        Catch ex As Exception
            Dim show As New mb.ShowMessagebox
            show.Fonts(New Font("TH SarabunPSK", 28, FontStyle.Bold))
            show.ShowBox(" มีบางอย่างพิดพลาด ", mb.MStyle.ok, mb.FStyle.Critical, "การแจ้งเตือนสถานะ")
        End Try
        lb_status_smart.Text = "Read Card Success"
    End Sub
    Sub clears()
        lb_status_smart.Text = "Waiting Insert Card"
        resetValue()
        cleartb()
        frmkeyborad.tb_addphone.Text = ""
        Dim pt_detail = New uc_pt_detail
        Me.panel_pt_detail.Controls.Clear()
        pt_detail.Height = Me.panel_pt_detail.Height
        pt_detail.Width = Me.panel_pt_detail.Width
        Me.panel_pt_detail.Controls.Add(pt_detail)
        btn_header.Text = "กรุณาเสียบบัตรประชาชน"
    End Sub

    'ฟังก์ชั่นเช็คเครื่องอ่านบัตร
    Function GetReader() As Boolean
        Try
            Dim ID As New ThaiIDCard
            Dim readers = ID.GetReaders
            If readers Is Nothing Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            status_card = "not found"
            'MessageBox.Show("Smart Card Reader not found.", "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            tm_check_smcard.Start()
            Return False
        End Try
    End Function

    Function GetReadernotfound() As String
        Try
            Dim ID As New ThaiIDCard
            Dim readers = ID.GetReaders
            If readers Is Nothing Then
                status_card = "not found"
                Return False
            Else
                status_card = "found"
                Return True
            End If
        Catch ex As Exception
            status_card = "not found"
            tb_cardreader.Text = status_card
            'MessageBox.Show("Smart Card Reader not found.", "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End Try
    End Function
    'การทำงาน bgworker
    'Private Sub BgWorker_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs)

    'End Sub
    'Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs)
    '    'ProgressBar1.Visible = False
    '    'MessageBox.Show("Done Complete.", "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
    'End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim show As New mb.ShowMessagebox
        show.ButtonText("ตกลง", "ยกเลิก")
        show.Fonts(New Font("supermarket", 16, FontStyle.Regular))
        Dim submit = show.ShowBox("คุณแน่ใจจะออกโปรแกรมใช่หรือไม่", mb.MStyle.YesNo, mb.FStyle.Question, "สถานะแจ้งเตือน")
        'Dim submit = MessageBox.Show("ออกโปรแกรม ใช่หรือไม่", "สถานะแจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If submit = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
        'Me.Close()
    End Sub
    Private Sub btn_config_Click(sender As Object, e As EventArgs) Handles btn_config.Click
        frmConfig.ShowDialog()
        Me.Refresh()
    End Sub

    Private Sub tm_check_smcard_Tick(sender As Object, e As EventArgs) Handles tm_check_smcard.Tick
        Try
            GetReadernotfound()
            If status_card <> "not found" Then
                tm_check_smcard.Stop()
                tm_check_smcard_true.Start()
                monitor_strat()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Sub ListOfDevices(ByVal DeviceCmb As ComboBox)
        Try
            DeviceCmb.Items.Clear()
            DeviceCmb.SelectedIndex = -1
            DeviceCmb.SelectedText = String.Empty
            DeviceCmb.Text = String.Empty
            DeviceCmb.Refresh()
            Dim idcard As ThaiIDCard = New ThaiIDCard()
            Dim readers As String() = idcard.GetReaders()
            If readers Is Nothing Then Return
            For Each r As String In readers
                DeviceCmb.Items.Add(r)
            Next
            DeviceCmb.DroppedDown = True
        Catch ex As Exception

        End Try

    End Sub

    Private Sub tm_check_smcard_true_Tick(sender As Object, e As EventArgs) Handles tm_check_smcard_true.Tick
        GetReader()
        If status_card = "not found" Then
            tm_check_smcard_true.Stop()
            monitor_strat()
            tm_check_smcard.Start()
        End If
    End Sub
End Class
