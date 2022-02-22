<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc_pt_detail
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uc_pt_detail))
        Me.gb_main = New Guna.UI.WinForms.GunaGroupBox()
        Me.tb_name = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lb_sub_pt = New System.Windows.Forms.Label()
        Me.tb_sub_pt = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lb_main_pt = New System.Windows.Forms.Label()
        Me.tb_main_pt = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lb_name = New System.Windows.Forms.Label()
        Me.lb_cid = New System.Windows.Forms.Label()
        Me.tb_cid = New Guna.UI.WinForms.GunaLineTextBox()
        Me.gb_sub = New Guna.UI.WinForms.GunaGroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GunaLineTextBox4 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_phonenum = New Guna.UI.WinForms.GunaLineTextBox()
        Me.btn_success = New Guna.UI.WinForms.GunaButton()
        Me.btn_pic = New Guna.UI.WinForms.GunaPictureBox()
        Me.gb_main.SuspendLayout()
        Me.gb_sub.SuspendLayout()
        CType(Me.btn_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_main
        '
        Me.gb_main.BackColor = System.Drawing.Color.Transparent
        Me.gb_main.BaseColor = System.Drawing.Color.White
        Me.gb_main.BorderColor = System.Drawing.Color.LightGray
        Me.gb_main.BorderSize = 1
        Me.gb_main.Controls.Add(Me.tb_name)
        Me.gb_main.Controls.Add(Me.lb_sub_pt)
        Me.gb_main.Controls.Add(Me.tb_sub_pt)
        Me.gb_main.Controls.Add(Me.lb_main_pt)
        Me.gb_main.Controls.Add(Me.tb_main_pt)
        Me.gb_main.Controls.Add(Me.lb_name)
        Me.gb_main.Controls.Add(Me.lb_cid)
        Me.gb_main.Controls.Add(Me.tb_cid)
        Me.gb_main.Font = New System.Drawing.Font("supermarket", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.gb_main.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.gb_main.LineBottom = 10
        Me.gb_main.LineColor = System.Drawing.Color.LimeGreen
        Me.gb_main.LineLeft = 10
        Me.gb_main.LineRight = 10
        Me.gb_main.LineTop = 65
        Me.gb_main.Location = New System.Drawing.Point(99, 46)
        Me.gb_main.Name = "gb_main"
        Me.gb_main.Radius = 20
        Me.gb_main.Size = New System.Drawing.Size(724, 493)
        Me.gb_main.TabIndex = 0
        Me.gb_main.Text = "ตรวจสอบข้อมูลส่วนตัว"
        Me.gb_main.TextLocation = New System.Drawing.Point(10, 8)
        Me.gb_main.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias
        '
        'tb_name
        '
        Me.tb_name.BackColor = System.Drawing.Color.White
        Me.tb_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_name.Enabled = False
        Me.tb_name.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_name.Font = New System.Drawing.Font("supermarket", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tb_name.LineColor = System.Drawing.Color.DodgerBlue
        Me.tb_name.Location = New System.Drawing.Point(349, 202)
        Me.tb_name.Name = "tb_name"
        Me.tb_name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_name.SelectedText = ""
        Me.tb_name.Size = New System.Drawing.Size(321, 65)
        Me.tb_name.TabIndex = 11
        '
        'lb_sub_pt
        '
        Me.lb_sub_pt.AutoSize = True
        Me.lb_sub_pt.Font = New System.Drawing.Font("supermarket", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lb_sub_pt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_sub_pt.Location = New System.Drawing.Point(44, 375)
        Me.lb_sub_pt.Name = "lb_sub_pt"
        Me.lb_sub_pt.Size = New System.Drawing.Size(175, 83)
        Me.lb_sub_pt.TabIndex = 7
        Me.lb_sub_pt.Text = "สิทธิย่อย"
        '
        'tb_sub_pt
        '
        Me.tb_sub_pt.BackColor = System.Drawing.Color.White
        Me.tb_sub_pt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_sub_pt.Enabled = False
        Me.tb_sub_pt.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_sub_pt.Font = New System.Drawing.Font("supermarket", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_sub_pt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tb_sub_pt.LineColor = System.Drawing.Color.DodgerBlue
        Me.tb_sub_pt.Location = New System.Drawing.Point(349, 378)
        Me.tb_sub_pt.Name = "tb_sub_pt"
        Me.tb_sub_pt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_sub_pt.SelectedText = ""
        Me.tb_sub_pt.Size = New System.Drawing.Size(321, 65)
        Me.tb_sub_pt.TabIndex = 6
        '
        'lb_main_pt
        '
        Me.lb_main_pt.AutoSize = True
        Me.lb_main_pt.Font = New System.Drawing.Font("supermarket", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lb_main_pt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_main_pt.Location = New System.Drawing.Point(44, 289)
        Me.lb_main_pt.Name = "lb_main_pt"
        Me.lb_main_pt.Size = New System.Drawing.Size(175, 83)
        Me.lb_main_pt.TabIndex = 5
        Me.lb_main_pt.Text = "สิทธิหลัก"
        '
        'tb_main_pt
        '
        Me.tb_main_pt.BackColor = System.Drawing.Color.White
        Me.tb_main_pt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_main_pt.Enabled = False
        Me.tb_main_pt.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_main_pt.Font = New System.Drawing.Font("supermarket", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_main_pt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tb_main_pt.LineColor = System.Drawing.Color.DodgerBlue
        Me.tb_main_pt.Location = New System.Drawing.Point(349, 292)
        Me.tb_main_pt.Name = "tb_main_pt"
        Me.tb_main_pt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_main_pt.SelectedText = ""
        Me.tb_main_pt.Size = New System.Drawing.Size(321, 65)
        Me.tb_main_pt.TabIndex = 4
        '
        'lb_name
        '
        Me.lb_name.AutoSize = True
        Me.lb_name.Font = New System.Drawing.Font("supermarket", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lb_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_name.Location = New System.Drawing.Point(44, 196)
        Me.lb_name.Name = "lb_name"
        Me.lb_name.Size = New System.Drawing.Size(259, 83)
        Me.lb_name.TabIndex = 3
        Me.lb_name.Text = "ชื่อ - นามสกุล"
        '
        'lb_cid
        '
        Me.lb_cid.AutoSize = True
        Me.lb_cid.Font = New System.Drawing.Font("supermarket", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lb_cid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_cid.Location = New System.Drawing.Point(44, 101)
        Me.lb_cid.Name = "lb_cid"
        Me.lb_cid.Size = New System.Drawing.Size(299, 83)
        Me.lb_cid.TabIndex = 1
        Me.lb_cid.Text = "เลขบัตรประชาชน"
        '
        'tb_cid
        '
        Me.tb_cid.BackColor = System.Drawing.Color.White
        Me.tb_cid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_cid.Enabled = False
        Me.tb_cid.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_cid.Font = New System.Drawing.Font("supermarket", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tb_cid.LineColor = System.Drawing.Color.DodgerBlue
        Me.tb_cid.Location = New System.Drawing.Point(349, 105)
        Me.tb_cid.Name = "tb_cid"
        Me.tb_cid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_cid.SelectedText = ""
        Me.tb_cid.Size = New System.Drawing.Size(321, 65)
        Me.tb_cid.TabIndex = 0
        '
        'gb_sub
        '
        Me.gb_sub.BackColor = System.Drawing.Color.Transparent
        Me.gb_sub.BaseColor = System.Drawing.Color.White
        Me.gb_sub.BorderColor = System.Drawing.Color.LightGray
        Me.gb_sub.BorderSize = 1
        Me.gb_sub.Controls.Add(Me.Label4)
        Me.gb_sub.Controls.Add(Me.GunaLineTextBox4)
        Me.gb_sub.Controls.Add(Me.Label5)
        Me.gb_sub.Controls.Add(Me.tb_phonenum)
        Me.gb_sub.Font = New System.Drawing.Font("supermarket", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.gb_sub.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gb_sub.LineBottom = 10
        Me.gb_sub.LineColor = System.Drawing.Color.LimeGreen
        Me.gb_sub.LineLeft = 10
        Me.gb_sub.LineRight = 10
        Me.gb_sub.LineTop = 65
        Me.gb_sub.Location = New System.Drawing.Point(858, 46)
        Me.gb_sub.Name = "gb_sub"
        Me.gb_sub.Radius = 20
        Me.gb_sub.Size = New System.Drawing.Size(796, 369)
        Me.gb_sub.TabIndex = 10
        Me.gb_sub.Text = "กรอกข้อมูลเพิ่มเติม"
        Me.gb_sub.TextLocation = New System.Drawing.Point(10, 8)
        Me.gb_sub.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("supermarket", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(25, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(197, 65)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "บริการที่เข้ารับ"
        '
        'GunaLineTextBox4
        '
        Me.GunaLineTextBox4.BackColor = System.Drawing.Color.White
        Me.GunaLineTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaLineTextBox4.Enabled = False
        Me.GunaLineTextBox4.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaLineTextBox4.Font = New System.Drawing.Font("supermarket", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GunaLineTextBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GunaLineTextBox4.LineColor = System.Drawing.Color.DodgerBlue
        Me.GunaLineTextBox4.Location = New System.Drawing.Point(220, 166)
        Me.GunaLineTextBox4.Name = "GunaLineTextBox4"
        Me.GunaLineTextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox4.SelectedText = ""
        Me.GunaLineTextBox4.Size = New System.Drawing.Size(520, 74)
        Me.GunaLineTextBox4.TabIndex = 2
        Me.GunaLineTextBox4.Text = "เข้ารับบริการรักษาทั่วไป (OPD/ IPD/ PP)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("supermarket", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(25, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(189, 65)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "เบอร์โทรศัพท์"
        '
        'tb_phonenum
        '
        Me.tb_phonenum.BackColor = System.Drawing.Color.White
        Me.tb_phonenum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_phonenum.Enabled = False
        Me.tb_phonenum.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_phonenum.Font = New System.Drawing.Font("supermarket", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tb_phonenum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tb_phonenum.LineColor = System.Drawing.Color.DodgerBlue
        Me.tb_phonenum.Location = New System.Drawing.Point(220, 92)
        Me.tb_phonenum.Name = "tb_phonenum"
        Me.tb_phonenum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_phonenum.SelectedText = ""
        Me.tb_phonenum.Size = New System.Drawing.Size(520, 74)
        Me.tb_phonenum.TabIndex = 0
        '
        'btn_success
        '
        Me.btn_success.AnimationHoverSpeed = 0.07!
        Me.btn_success.AnimationSpeed = 0.03!
        Me.btn_success.BackColor = System.Drawing.Color.Transparent
        Me.btn_success.BaseColor = System.Drawing.Color.Aquamarine
        Me.btn_success.BorderColor = System.Drawing.Color.Black
        Me.btn_success.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_success.Enabled = False
        Me.btn_success.FocusedColor = System.Drawing.Color.Empty
        Me.btn_success.Font = New System.Drawing.Font("supermarket", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_success.ForeColor = System.Drawing.Color.Black
        Me.btn_success.Image = Nothing
        Me.btn_success.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_success.Location = New System.Drawing.Point(858, 430)
        Me.btn_success.Name = "btn_success"
        Me.btn_success.OnHoverBaseColor = System.Drawing.Color.Aquamarine
        Me.btn_success.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_success.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_success.OnHoverImage = Nothing
        Me.btn_success.OnPressedColor = System.Drawing.Color.Black
        Me.btn_success.Radius = 10
        Me.btn_success.Size = New System.Drawing.Size(651, 109)
        Me.btn_success.TabIndex = 11
        Me.btn_success.Text = "บันทึกข้อมูล"
        Me.btn_success.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_success.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias
        '
        'btn_pic
        '
        Me.btn_pic.BackColor = System.Drawing.Color.Transparent
        Me.btn_pic.BaseColor = System.Drawing.Color.White
        Me.btn_pic.ErrorImage = Nothing
        Me.btn_pic.Image = CType(resources.GetObject("btn_pic.Image"), System.Drawing.Image)
        Me.btn_pic.InitialImage = CType(resources.GetObject("btn_pic.InitialImage"), System.Drawing.Image)
        Me.btn_pic.Location = New System.Drawing.Point(1527, 430)
        Me.btn_pic.Name = "btn_pic"
        Me.btn_pic.Radius = 10
        Me.btn_pic.Size = New System.Drawing.Size(127, 109)
        Me.btn_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_pic.TabIndex = 12
        Me.btn_pic.TabStop = False
        '
        'uc_pt_detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_pic)
        Me.Controls.Add(Me.btn_success)
        Me.Controls.Add(Me.gb_sub)
        Me.Controls.Add(Me.gb_main)
        Me.Name = "uc_pt_detail"
        Me.Size = New System.Drawing.Size(1767, 648)
        Me.gb_main.ResumeLayout(False)
        Me.gb_main.PerformLayout()
        Me.gb_sub.ResumeLayout(False)
        Me.gb_sub.PerformLayout()
        CType(Me.btn_pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb_main As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents lb_sub_pt As Label
    Friend WithEvents tb_sub_pt As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents lb_main_pt As Label
    Friend WithEvents tb_main_pt As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents lb_name As Label
    Friend WithEvents lb_cid As Label
    Friend WithEvents tb_cid As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents gb_sub As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_phonenum As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents btn_success As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLineTextBox4 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents tb_name As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents btn_pic As Guna.UI.WinForms.GunaPictureBox
End Class
