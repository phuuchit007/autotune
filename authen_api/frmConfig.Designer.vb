<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConfig
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfig))
        Me.btn_save = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btn_testcon = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.tb_server = New Guna.UI.WinForms.GunaTextBox()
        Me.tb_user = New Guna.UI.WinForms.GunaTextBox()
        Me.tb_pass = New Guna.UI.WinForms.GunaTextBox()
        Me.tb_db = New Guna.UI.WinForms.GunaTextBox()
        Me.lb_server = New Guna.UI.WinForms.GunaLabel()
        Me.lb_user = New Guna.UI.WinForms.GunaLabel()
        Me.lb_password = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.btn_ok = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.GunaLinePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_save
        '
        Me.btn_save.AnimationHoverSpeed = 0.07!
        Me.btn_save.AnimationSpeed = 0.03!
        Me.btn_save.BackColor = System.Drawing.Color.Transparent
        Me.btn_save.BaseColor = System.Drawing.Color.MediumTurquoise
        Me.btn_save.BorderColor = System.Drawing.Color.DimGray
        Me.btn_save.BorderSize = 2
        Me.btn_save.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_save.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_save.CheckedForeColor = System.Drawing.Color.White
        Me.btn_save.CheckedImage = CType(resources.GetObject("btn_save.CheckedImage"), System.Drawing.Image)
        Me.btn_save.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_save.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_save.FocusedColor = System.Drawing.Color.Empty
        Me.btn_save.Font = New System.Drawing.Font("supermarket", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Image = Nothing
        Me.btn_save.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_save.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_save.Location = New System.Drawing.Point(85, 337)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.OnHoverBaseColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_save.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_save.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_save.OnHoverImage = Nothing
        Me.btn_save.OnHoverLineColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_save.OnPressedColor = System.Drawing.Color.Black
        Me.btn_save.Radius = 15
        Me.btn_save.Size = New System.Drawing.Size(105, 64)
        Me.btn_save.TabIndex = 0
        Me.btn_save.Text = "Save"
        Me.btn_save.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_save.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias
        '
        'btn_testcon
        '
        Me.btn_testcon.AnimationHoverSpeed = 0.07!
        Me.btn_testcon.AnimationSpeed = 0.03!
        Me.btn_testcon.BackColor = System.Drawing.Color.Transparent
        Me.btn_testcon.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_testcon.BorderColor = System.Drawing.Color.DimGray
        Me.btn_testcon.BorderSize = 2
        Me.btn_testcon.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_testcon.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_testcon.CheckedForeColor = System.Drawing.Color.White
        Me.btn_testcon.CheckedImage = CType(resources.GetObject("btn_testcon.CheckedImage"), System.Drawing.Image)
        Me.btn_testcon.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_testcon.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_testcon.FocusedColor = System.Drawing.Color.Empty
        Me.btn_testcon.Font = New System.Drawing.Font("supermarket", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_testcon.ForeColor = System.Drawing.Color.White
        Me.btn_testcon.Image = Nothing
        Me.btn_testcon.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_testcon.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_testcon.Location = New System.Drawing.Point(85, 407)
        Me.btn_testcon.Name = "btn_testcon"
        Me.btn_testcon.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_testcon.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_testcon.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_testcon.OnHoverImage = Nothing
        Me.btn_testcon.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_testcon.OnPressedColor = System.Drawing.Color.Black
        Me.btn_testcon.Radius = 15
        Me.btn_testcon.Size = New System.Drawing.Size(223, 64)
        Me.btn_testcon.TabIndex = 1
        Me.btn_testcon.Text = "Test Connection"
        Me.btn_testcon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_testcon.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias
        '
        'tb_server
        '
        Me.tb_server.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.tb_server.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.tb_server.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_server.FocusedBaseColor = System.Drawing.Color.White
        Me.tb_server.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_server.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.tb_server.Font = New System.Drawing.Font("supermarket", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_server.Location = New System.Drawing.Point(158, 70)
        Me.tb_server.Name = "tb_server"
        Me.tb_server.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_server.SelectedText = ""
        Me.tb_server.Size = New System.Drawing.Size(187, 57)
        Me.tb_server.TabIndex = 2
        '
        'tb_user
        '
        Me.tb_user.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.tb_user.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.tb_user.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_user.FocusedBaseColor = System.Drawing.Color.White
        Me.tb_user.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_user.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.tb_user.Font = New System.Drawing.Font("supermarket", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_user.Location = New System.Drawing.Point(158, 133)
        Me.tb_user.Name = "tb_user"
        Me.tb_user.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_user.SelectedText = ""
        Me.tb_user.Size = New System.Drawing.Size(187, 57)
        Me.tb_user.TabIndex = 3
        '
        'tb_pass
        '
        Me.tb_pass.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.tb_pass.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.tb_pass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_pass.FocusedBaseColor = System.Drawing.Color.White
        Me.tb_pass.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_pass.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.tb_pass.Font = New System.Drawing.Font("supermarket", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_pass.Location = New System.Drawing.Point(158, 196)
        Me.tb_pass.Name = "tb_pass"
        Me.tb_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_pass.SelectedText = ""
        Me.tb_pass.Size = New System.Drawing.Size(187, 57)
        Me.tb_pass.TabIndex = 4
        '
        'tb_db
        '
        Me.tb_db.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.tb_db.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.tb_db.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_db.FocusedBaseColor = System.Drawing.Color.White
        Me.tb_db.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_db.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.tb_db.Font = New System.Drawing.Font("supermarket", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_db.Location = New System.Drawing.Point(158, 259)
        Me.tb_db.Name = "tb_db"
        Me.tb_db.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_db.SelectedText = ""
        Me.tb_db.Size = New System.Drawing.Size(187, 57)
        Me.tb_db.TabIndex = 5
        '
        'lb_server
        '
        Me.lb_server.AutoSize = True
        Me.lb_server.Font = New System.Drawing.Font("supermarket", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_server.Location = New System.Drawing.Point(57, 80)
        Me.lb_server.Name = "lb_server"
        Me.lb_server.Size = New System.Drawing.Size(95, 47)
        Me.lb_server.TabIndex = 6
        Me.lb_server.Text = "Server :"
        Me.lb_server.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias
        '
        'lb_user
        '
        Me.lb_user.AutoSize = True
        Me.lb_user.Font = New System.Drawing.Font("supermarket", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_user.Location = New System.Drawing.Point(77, 143)
        Me.lb_user.Name = "lb_user"
        Me.lb_user.Size = New System.Drawing.Size(75, 47)
        Me.lb_user.TabIndex = 7
        Me.lb_user.Text = "User :"
        Me.lb_user.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias
        '
        'lb_password
        '
        Me.lb_password.AutoSize = True
        Me.lb_password.Font = New System.Drawing.Font("supermarket", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_password.Location = New System.Drawing.Point(25, 206)
        Me.lb_password.Name = "lb_password"
        Me.lb_password.Size = New System.Drawing.Size(127, 47)
        Me.lb_password.TabIndex = 8
        Me.lb_password.Text = "Password :"
        Me.lb_password.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("supermarket", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(30, 269)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(122, 47)
        Me.GunaLabel1.TabIndex = 9
        Me.GunaLabel1.Text = "DB Name :"
        Me.GunaLabel1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias
        '
        'btn_ok
        '
        Me.btn_ok.AnimationHoverSpeed = 0.07!
        Me.btn_ok.AnimationSpeed = 0.03!
        Me.btn_ok.BackColor = System.Drawing.Color.Transparent
        Me.btn_ok.BaseColor = System.Drawing.Color.LimeGreen
        Me.btn_ok.BorderColor = System.Drawing.Color.DimGray
        Me.btn_ok.BorderSize = 2
        Me.btn_ok.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_ok.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_ok.CheckedForeColor = System.Drawing.Color.White
        Me.btn_ok.CheckedImage = CType(resources.GetObject("btn_ok.CheckedImage"), System.Drawing.Image)
        Me.btn_ok.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_ok.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_ok.FocusedColor = System.Drawing.Color.Empty
        Me.btn_ok.Font = New System.Drawing.Font("supermarket", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.White
        Me.btn_ok.Image = Nothing
        Me.btn_ok.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_ok.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_ok.Location = New System.Drawing.Point(203, 337)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.OnHoverBaseColor = System.Drawing.Color.Lime
        Me.btn_ok.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_ok.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_ok.OnHoverImage = Nothing
        Me.btn_ok.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_ok.OnPressedColor = System.Drawing.Color.Black
        Me.btn_ok.Radius = 15
        Me.btn_ok.Size = New System.Drawing.Size(105, 64)
        Me.btn_ok.TabIndex = 10
        Me.btn_ok.Text = "Success"
        Me.btn_ok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_ok.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("supermarket", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaLabel2.Location = New System.Drawing.Point(197, 3)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(186, 47)
        Me.GunaLabel2.TabIndex = 11
        Me.GunaLabel2.Text = "Setting Database"
        Me.GunaLabel2.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.BackColor = System.Drawing.Color.LimeGreen
        Me.GunaLinePanel1.Controls.Add(Me.GunaLabel2)
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(-2, -1)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(400, 53)
        Me.GunaLinePanel1.TabIndex = 12
        '
        'frmConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 488)
        Me.Controls.Add(Me.GunaLinePanel1)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.lb_password)
        Me.Controls.Add(Me.lb_user)
        Me.Controls.Add(Me.lb_server)
        Me.Controls.Add(Me.tb_db)
        Me.Controls.Add(Me.tb_pass)
        Me.Controls.Add(Me.tb_user)
        Me.Controls.Add(Me.tb_server)
        Me.Controls.Add(Me.btn_testcon)
        Me.Controls.Add(Me.btn_save)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConfig"
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.GunaLinePanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_save As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btn_testcon As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents tb_server As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents tb_user As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents tb_pass As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents tb_db As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lb_server As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lb_user As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lb_password As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btn_ok As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
End Class
