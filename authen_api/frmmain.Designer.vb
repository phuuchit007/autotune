<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmain))
        Me.lbfrm = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txt_cid = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_config = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.lbhos = New System.Windows.Forms.Label()
        Me.panel_pt_detail = New Guna.UI.WinForms.GunaPanel()
        Me.btn_header = New Guna.UI.WinForms.GunaButton()
        Me.lb_server = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbstatus = New System.Windows.Forms.TextBox()
        Me.SPcard = New System.IO.Ports.SerialPort(Me.components)
        Me.lb_con = New System.Windows.Forms.Label()
        Me.tbcon = New System.Windows.Forms.TextBox()
        Me.lb_status_smart = New System.Windows.Forms.Label()
        Me.tb_cardreader = New Guna.UI.WinForms.GunaTextBox()
        Me.tm_check_smcard = New System.Windows.Forms.Timer(Me.components)
        Me.tm_check_smcard_true = New System.Windows.Forms.Timer(Me.components)
        Me.GunaTextBox1 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaCirclePictureBox2 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaCirclePictureBox3 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaCirclePictureBox4 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaCirclePictureBox5 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.btn_config, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbfrm
        '
        Me.lbfrm.AutoSize = True
        Me.lbfrm.Font = New System.Drawing.Font("supermarket", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbfrm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbfrm.Location = New System.Drawing.Point(189, 0)
        Me.lbfrm.Name = "lbfrm"
        Me.lbfrm.Size = New System.Drawing.Size(412, 111)
        Me.lbfrm.TabIndex = 0
        Me.lbfrm.Text = "Banna Hospital"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(1892, 1057)
        Me.btnClose.MinimumSize = New System.Drawing.Size(20, 23)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(28, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txt_cid
        '
        Me.txt_cid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_cid.Location = New System.Drawing.Point(1414, 217)
        Me.txt_cid.Name = "txt_cid"
        Me.txt_cid.Size = New System.Drawing.Size(123, 20)
        Me.txt_cid.TabIndex = 3
        Me.txt_cid.Visible = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(1608, 217)
        Me.Button2.MaximumSize = New System.Drawing.Size(86, 20)
        Me.Button2.MinimumSize = New System.Drawing.Size(86, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 20)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.LightPink
        Me.Panel1.Controls.Add(Me.btn_config)
        Me.Panel1.Controls.Add(Me.GunaPictureBox1)
        Me.Panel1.Controls.Add(Me.lbhos)
        Me.Panel1.Controls.Add(Me.lbfrm)
        Me.Panel1.Location = New System.Drawing.Point(-2, -6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1922, 149)
        Me.Panel1.TabIndex = 6
        '
        'btn_config
        '
        Me.btn_config.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_config.BackColor = System.Drawing.Color.Transparent
        Me.btn_config.BaseColor = System.Drawing.Color.White
        Me.btn_config.Image = CType(resources.GetObject("btn_config.Image"), System.Drawing.Image)
        Me.btn_config.Location = New System.Drawing.Point(1639, 18)
        Me.btn_config.Name = "btn_config"
        Me.btn_config.Size = New System.Drawing.Size(271, 108)
        Me.btn_config.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_config.TabIndex = 8
        Me.btn_config.TabStop = False
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(14, 18)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(190, 128)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 7
        Me.GunaPictureBox1.TabStop = False
        '
        'lbhos
        '
        Me.lbhos.AutoSize = True
        Me.lbhos.Font = New System.Drawing.Font("supermarket", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbhos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbhos.Location = New System.Drawing.Point(199, 88)
        Me.lbhos.Name = "lbhos"
        Me.lbhos.Size = New System.Drawing.Size(243, 51)
        Me.lbhos.TabIndex = 6
        Me.lbhos.Text = "Authentication NHSO"
        '
        'panel_pt_detail
        '
        Me.panel_pt_detail.BackColor = System.Drawing.Color.Transparent
        Me.panel_pt_detail.Location = New System.Drawing.Point(81, 289)
        Me.panel_pt_detail.Name = "panel_pt_detail"
        Me.panel_pt_detail.Size = New System.Drawing.Size(1767, 693)
        Me.panel_pt_detail.TabIndex = 7
        '
        'btn_header
        '
        Me.btn_header.AnimationHoverSpeed = 0.07!
        Me.btn_header.AnimationSpeed = 0.03!
        Me.btn_header.BackColor = System.Drawing.Color.Transparent
        Me.btn_header.BaseColor = System.Drawing.Color.Transparent
        Me.btn_header.BorderColor = System.Drawing.Color.Transparent
        Me.btn_header.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_header.FocusedColor = System.Drawing.Color.Empty
        Me.btn_header.Font = New System.Drawing.Font("supermarket", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_header.ForeColor = System.Drawing.Color.Black
        Me.btn_header.Image = Nothing
        Me.btn_header.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_header.Location = New System.Drawing.Point(518, 160)
        Me.btn_header.Name = "btn_header"
        Me.btn_header.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btn_header.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btn_header.OnHoverForeColor = System.Drawing.Color.Black
        Me.btn_header.OnHoverImage = Nothing
        Me.btn_header.OnPressedColor = System.Drawing.Color.Black
        Me.btn_header.Radius = 10
        Me.btn_header.Size = New System.Drawing.Size(890, 123)
        Me.btn_header.TabIndex = 8
        Me.btn_header.Text = "กรุณาเสียบบัตรประชาชน"
        Me.btn_header.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_header.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias
        '
        'lb_server
        '
        Me.lb_server.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lb_server.AutoSize = True
        Me.lb_server.Font = New System.Drawing.Font("supermarket", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lb_server.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lb_server.Location = New System.Drawing.Point(50, 1044)
        Me.lb_server.Name = "lb_server"
        Me.lb_server.Size = New System.Drawing.Size(258, 34)
        Me.lb_server.TabIndex = 9
        Me.lb_server.Text = "Server Connection : 192.168.0.239"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("supermarket", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(518, 1044)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 34)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Hospital : Banna 10864"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("supermarket", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(738, 1044)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 34)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Ver. : 1.0.3 SMC"
        '
        'tbstatus
        '
        Me.tbstatus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbstatus.Location = New System.Drawing.Point(1414, 243)
        Me.tbstatus.Name = "tbstatus"
        Me.tbstatus.Size = New System.Drawing.Size(123, 20)
        Me.tbstatus.TabIndex = 12
        Me.tbstatus.Visible = False
        '
        'lb_con
        '
        Me.lb_con.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lb_con.AutoSize = True
        Me.lb_con.Font = New System.Drawing.Font("supermarket", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lb_con.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lb_con.Location = New System.Drawing.Point(314, 1044)
        Me.lb_con.Name = "lb_con"
        Me.lb_con.Size = New System.Drawing.Size(160, 34)
        Me.lb_con.TabIndex = 13
        Me.lb_con.Text = "Connection Success"
        '
        'tbcon
        '
        Me.tbcon.Location = New System.Drawing.Point(1414, 160)
        Me.tbcon.Name = "tbcon"
        Me.tbcon.Size = New System.Drawing.Size(329, 20)
        Me.tbcon.TabIndex = 14
        Me.tbcon.Visible = False
        '
        'lb_status_smart
        '
        Me.lb_status_smart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lb_status_smart.AutoSize = True
        Me.lb_status_smart.Font = New System.Drawing.Font("supermarket", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lb_status_smart.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lb_status_smart.Location = New System.Drawing.Point(912, 1044)
        Me.lb_status_smart.Name = "lb_status_smart"
        Me.lb_status_smart.Size = New System.Drawing.Size(150, 34)
        Me.lb_status_smart.TabIndex = 15
        Me.lb_status_smart.Text = "Waiting Insert Card"
        '
        'tb_cardreader
        '
        Me.tb_cardreader.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_cardreader.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.tb_cardreader.BorderColor = System.Drawing.Color.Transparent
        Me.tb_cardreader.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_cardreader.Enabled = False
        Me.tb_cardreader.FocusedBaseColor = System.Drawing.Color.White
        Me.tb_cardreader.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_cardreader.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.tb_cardreader.Font = New System.Drawing.Font("supermarket", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cardreader.Location = New System.Drawing.Point(1615, 1044)
        Me.tb_cardreader.Name = "tb_cardreader"
        Me.tb_cardreader.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_cardreader.SelectedText = ""
        Me.tb_cardreader.Size = New System.Drawing.Size(263, 38)
        Me.tb_cardreader.TabIndex = 0
        Me.tb_cardreader.Text = "Smart Card"
        '
        'tm_check_smcard
        '
        Me.tm_check_smcard.Interval = 1000
        '
        'tm_check_smcard_true
        '
        Me.tm_check_smcard_true.Interval = 1000
        '
        'GunaTextBox1
        '
        Me.GunaTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaTextBox1.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.GunaTextBox1.BorderColor = System.Drawing.Color.Transparent
        Me.GunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox1.Enabled = False
        Me.GunaTextBox1.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox1.Font = New System.Drawing.Font("supermarket", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTextBox1.Location = New System.Drawing.Point(1472, 1044)
        Me.GunaTextBox1.Name = "GunaTextBox1"
        Me.GunaTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox1.SelectedText = ""
        Me.GunaTextBox1.Size = New System.Drawing.Size(137, 38)
        Me.GunaTextBox1.TabIndex = 16
        Me.GunaTextBox1.Text = "Status Smart Card :"
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Image = CType(resources.GetObject("GunaCirclePictureBox1.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(12, 1044)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(32, 34)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 17
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'GunaCirclePictureBox2
        '
        Me.GunaCirclePictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox2.Image = CType(resources.GetObject("GunaCirclePictureBox2.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox2.Location = New System.Drawing.Point(480, 1044)
        Me.GunaCirclePictureBox2.Name = "GunaCirclePictureBox2"
        Me.GunaCirclePictureBox2.Size = New System.Drawing.Size(32, 34)
        Me.GunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox2.TabIndex = 18
        Me.GunaCirclePictureBox2.TabStop = False
        Me.GunaCirclePictureBox2.UseTransfarantBackground = False
        '
        'GunaCirclePictureBox3
        '
        Me.GunaCirclePictureBox3.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox3.Image = CType(resources.GetObject("GunaCirclePictureBox3.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox3.Location = New System.Drawing.Point(869, 1044)
        Me.GunaCirclePictureBox3.Name = "GunaCirclePictureBox3"
        Me.GunaCirclePictureBox3.Size = New System.Drawing.Size(37, 34)
        Me.GunaCirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox3.TabIndex = 19
        Me.GunaCirclePictureBox3.TabStop = False
        Me.GunaCirclePictureBox3.UseTransfarantBackground = False
        '
        'GunaCirclePictureBox4
        '
        Me.GunaCirclePictureBox4.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox4.Image = CType(resources.GetObject("GunaCirclePictureBox4.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox4.Location = New System.Drawing.Point(700, 1044)
        Me.GunaCirclePictureBox4.Name = "GunaCirclePictureBox4"
        Me.GunaCirclePictureBox4.Size = New System.Drawing.Size(32, 34)
        Me.GunaCirclePictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox4.TabIndex = 20
        Me.GunaCirclePictureBox4.TabStop = False
        Me.GunaCirclePictureBox4.UseTransfarantBackground = False
        '
        'GunaCirclePictureBox5
        '
        Me.GunaCirclePictureBox5.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox5.Image = CType(resources.GetObject("GunaCirclePictureBox5.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox5.Location = New System.Drawing.Point(1434, 1044)
        Me.GunaCirclePictureBox5.Name = "GunaCirclePictureBox5"
        Me.GunaCirclePictureBox5.Size = New System.Drawing.Size(32, 34)
        Me.GunaCirclePictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox5.TabIndex = 21
        Me.GunaCirclePictureBox5.TabStop = False
        Me.GunaCirclePictureBox5.UseTransfarantBackground = False
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.GunaCirclePictureBox5)
        Me.Controls.Add(Me.GunaCirclePictureBox4)
        Me.Controls.Add(Me.GunaCirclePictureBox3)
        Me.Controls.Add(Me.GunaCirclePictureBox2)
        Me.Controls.Add(Me.GunaCirclePictureBox1)
        Me.Controls.Add(Me.GunaTextBox1)
        Me.Controls.Add(Me.tb_cardreader)
        Me.Controls.Add(Me.lb_status_smart)
        Me.Controls.Add(Me.tbcon)
        Me.Controls.Add(Me.lb_con)
        Me.Controls.Add(Me.tbstatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lb_server)
        Me.Controls.Add(Me.btn_header)
        Me.Controls.Add(Me.panel_pt_detail)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txt_cid)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmmain"
        Me.Text = "Mainfrm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btn_config, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbfrm As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents txt_cid As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbhos As Label
    Friend WithEvents btn_config As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents panel_pt_detail As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btn_header As Guna.UI.WinForms.GunaButton
    Friend WithEvents tbstatus As TextBox
    Friend WithEvents SPcard As IO.Ports.SerialPort
    Friend WithEvents tbcon As TextBox
    Public WithEvents lb_server As Label
    Public WithEvents Label1 As Label
    Public WithEvents Label2 As Label
    Public WithEvents lb_con As Label
    Public WithEvents lb_status_smart As Label
    Friend WithEvents tb_cardreader As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents tm_check_smcard As Timer
    Friend WithEvents tm_check_smcard_true As Timer
    Friend WithEvents GunaTextBox1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaCirclePictureBox2 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaCirclePictureBox3 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaCirclePictureBox4 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaCirclePictureBox5 As Guna.UI.WinForms.GunaCirclePictureBox
End Class
