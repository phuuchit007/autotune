Imports System.Configuration.ConfigurationSettings
Imports System.Xml
Imports MySql.Data.MySqlClient
Public Class frmConfig
    Dim user As String = ""
    Dim pass As String = ""
    Dim db_name As String = ""
    Dim server As String = ""
    Dim sv_config As String = My.Settings.conAuthen
    Private Sub frmConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Server =192.168.0.239;Initial Catalog=hos;Persist Security Info=True;User ID=sa;Password=sa
        Dim splitt = sv_config.Split(";"c)
        If (splitt.Count <= 6) Then
            server = splitt(0).ToString
            db_name = splitt(1).ToString
            user = splitt(3).ToString
            pass = splitt(4).ToString
        End If
        'split server
        splitt = server.Split("="c)
        server = splitt(1).ToString
        'db
        splitt = db_name.Split("="c)
        db_name = splitt(1).ToString
        'user
        splitt = user.Split("="c)
        user = splitt(1).ToString
        'pass
        splitt = pass.Split("="c)
        pass = splitt(1).ToString
        'splitt = sv_config.Split("="c)
        'If (splitt.Count <= 5) Then
        '    server = splitt(1).ToString

        'End If

        tb_server.Text = server
        tb_user.Text = user
        tb_pass.Text = pass
        tb_db.Text = db_name
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        show_server()
        Me.Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        server = tb_server.Text
        user = tb_user.Text
        pass = tb_pass.Text
        db_name = tb_db.Text
        'sv_config = "Server =192.168.0.239;Initial Catalog=hos;Persist Security Info=True;User ID=sa;Password=sa"
        sv_config = "Server =" & server & ";Initial Catalog=" & db_name & ";Persist Security Info=True;User ID=" & user & ";Password=" & pass & ""
        My.Settings.conAuthen = sv_config
        My.Settings.Save()
        ConStrsql = My.Settings.conAuthen
        'Dim t As New Threading.Thread(AddressOf tt)
        't.Start()
        'Me.Refresh()
    End Sub
    Sub tt()
        'My.Settings.Reset()
        My.Settings.Reload()
    End Sub
    Private Sub btn_testcon_Click(sender As Object, e As EventArgs) Handles btn_testcon.Click
        Dim cmd As New MySqlCommand
        cmd.Connection = New MySqlConnection(ConStrsql)

        Try
            cmd.Connection.Open()
            frmmain.lb_con.Text = "Connection Success"
            MsgBox("Connection Success")
        Catch ex As Exception
            frmmain.lb_con.Text = "Connection Fail"
            MsgBox("Connection fail")
        Finally
            cmd.Connection.Close()
            cmd.Connection.Dispose()
        End Try
    End Sub
End Class