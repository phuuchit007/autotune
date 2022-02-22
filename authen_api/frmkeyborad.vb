
Public Class frmkeyborad
    Dim main As New frmmain
    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        tb_addphone.Text += "1"
    End Sub

    Private Sub frmkeyborad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_addphone.Select()
    End Sub

    Private Sub btn_2_Click(sender As Object, e As EventArgs) Handles btn_2.Click
        tb_addphone.Text += "2"
    End Sub

    Private Sub btn_3_Click(sender As Object, e As EventArgs) Handles btn_3.Click
        tb_addphone.Text += "3"
    End Sub

    Private Sub btn_4_Click(sender As Object, e As EventArgs) Handles btn_4.Click
        tb_addphone.Text += "4"
    End Sub

    Private Sub btn_5_Click(sender As Object, e As EventArgs) Handles btn_5.Click
        tb_addphone.Text += "5"
    End Sub

    Private Sub btn_6_Click(sender As Object, e As EventArgs) Handles btn_6.Click
        tb_addphone.Text += "6"
    End Sub

    Private Sub btn_7_Click(sender As Object, e As EventArgs) Handles btn_7.Click
        tb_addphone.Text += "7"
    End Sub

    Private Sub btn_8_Click(sender As Object, e As EventArgs) Handles btn_8.Click
        tb_addphone.Text += "8"
    End Sub

    Private Sub btn_9_Click(sender As Object, e As EventArgs) Handles btn_9.Click
        tb_addphone.Text += "9"
    End Sub

    Private Sub btn_0_Click(sender As Object, e As EventArgs) Handles btn_0.Click
        tb_addphone.Text += "0"
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Dim pt_detail As New uc_pt_detail
        If tb_addphone.Text.Count <> 10 Then
            Dim show As New mb.ShowMessagebox
            show.Fonts(New Font("TH SarabunPSK", 28, FontStyle.Bold))
            show.ShowBox(" กรอกหมายเลขโทรศัพท์ไม่ครบ ", mb.MStyle.ok, mb.FStyle.Critical, "การแจ้งเตือนสถานะ")
            tb_addphone.Clear()
        ElseIf tb_addphone.Text.Count = 10 Then
            phone_number = tb_addphone.Text
            main.panel_pt_detail.Controls.Clear()
            pt_detail.Height = main.panel_pt_detail.Height
            pt_detail.Width = main.panel_pt_detail.Width
            main.panel_pt_detail.Controls.Add(pt_detail)

            Me.Close()
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim position As Integer
        position = tb_addphone.Text.Length - 1
        tb_addphone.Text = tb_addphone.Text.Remove(position, 1)
    End Sub

    Private Sub btn_delete_all_Click(sender As Object, e As EventArgs) Handles btn_delete_all.Click
        tb_addphone.Clear()
    End Sub

    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs) Handles GunaLabel1.Click
        Dim pt_detail As New uc_pt_detail
        pt_detail.btn_success.Enabled = False
        Me.Close()
    End Sub

    Private Sub tb_addphone_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_addphone.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim pt_detail As New uc_pt_detail
            If tb_addphone.Text.Count <> 10 Then
                Dim show As New mb.ShowMessagebox
                show.Fonts(New Font("TH SarabunPSK", 28, FontStyle.Bold))
                show.ShowBox(" กรอกหมายเลขโทรศัพท์ไม่ครบ ", mb.MStyle.ok, mb.FStyle.Critical, "การแจ้งเตือนสถานะ")
                tb_addphone.Clear()
            ElseIf tb_addphone.Text.Count = 10 Then
                phone_number = tb_addphone.Text
                main.panel_pt_detail.Controls.Clear()
                pt_detail.Height = main.panel_pt_detail.Height
                pt_detail.Width = main.panel_pt_detail.Width
                main.panel_pt_detail.Controls.Add(pt_detail)
                Me.Close()
            End If
        End If
    End Sub
End Class