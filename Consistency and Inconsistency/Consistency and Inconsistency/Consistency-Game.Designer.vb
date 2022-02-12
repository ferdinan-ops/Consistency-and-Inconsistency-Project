<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consistency_Game
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consistency_Game))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btoff = New Guna.UI.WinForms.GunaButton()
        Me.bton = New Guna.UI.WinForms.GunaButton()
        Me.btdisplay = New Guna.UI.WinForms.GunaCircleButton()
        Me.lbl_display = New System.Windows.Forms.Label()
        Me.GunaElipsePanel3 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_waktutunggu = New System.Windows.Forms.Label()
        Me.TimerON = New System.Windows.Forms.Timer(Me.components)
        Me.TimerOFF = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaElipsePanel5 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GunaTransfarantPictureBox1 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaElipsePanel2 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.greencar = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaElipsePanel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GunaElipsePanel5.SuspendLayout()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaElipsePanel2.SuspendLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaElipsePanel1.SuspendLayout()
        CType(Me.greencar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 333)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1334, 10)
        Me.Label1.TabIndex = 74
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(0, 586)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1334, 10)
        Me.Label2.TabIndex = 75
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btoff
        '
        Me.btoff.Animated = True
        Me.btoff.AnimationHoverSpeed = 0.07!
        Me.btoff.AnimationSpeed = 0.03!
        Me.btoff.BackColor = System.Drawing.Color.Transparent
        Me.btoff.BaseColor = System.Drawing.Color.Red
        Me.btoff.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btoff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btoff.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btoff.FocusedColor = System.Drawing.Color.Empty
        Me.btoff.Font = New System.Drawing.Font("Poppins", 13.77391!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoff.ForeColor = System.Drawing.Color.White
        Me.btoff.Image = Nothing
        Me.btoff.ImageSize = New System.Drawing.Size(20, 20)
        Me.btoff.Location = New System.Drawing.Point(99, 631)
        Me.btoff.Margin = New System.Windows.Forms.Padding(4)
        Me.btoff.Name = "btoff"
        Me.btoff.OnHoverBaseColor = System.Drawing.Color.Red
        Me.btoff.OnHoverBorderColor = System.Drawing.Color.Red
        Me.btoff.OnHoverForeColor = System.Drawing.Color.White
        Me.btoff.OnHoverImage = Nothing
        Me.btoff.OnPressedColor = System.Drawing.Color.Black
        Me.btoff.Size = New System.Drawing.Size(75, 64)
        Me.btoff.TabIndex = 77
        Me.btoff.Text = "OFF"
        Me.btoff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bton
        '
        Me.bton.Animated = True
        Me.bton.AnimationHoverSpeed = 0.07!
        Me.bton.AnimationSpeed = 0.03!
        Me.bton.BackColor = System.Drawing.Color.Transparent
        Me.bton.BaseColor = System.Drawing.Color.LimeGreen
        Me.bton.BorderColor = System.Drawing.Color.LimeGreen
        Me.bton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bton.FocusedColor = System.Drawing.Color.Empty
        Me.bton.Font = New System.Drawing.Font("Poppins", 13.77391!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bton.ForeColor = System.Drawing.Color.White
        Me.bton.Image = Nothing
        Me.bton.ImageSize = New System.Drawing.Size(20, 20)
        Me.bton.Location = New System.Drawing.Point(205, 631)
        Me.bton.Margin = New System.Windows.Forms.Padding(4)
        Me.bton.Name = "bton"
        Me.bton.OnHoverBaseColor = System.Drawing.Color.LimeGreen
        Me.bton.OnHoverBorderColor = System.Drawing.Color.LimeGreen
        Me.bton.OnHoverForeColor = System.Drawing.Color.White
        Me.bton.OnHoverImage = Nothing
        Me.bton.OnPressedColor = System.Drawing.Color.Black
        Me.bton.Size = New System.Drawing.Size(75, 64)
        Me.bton.TabIndex = 78
        Me.bton.Text = "ON"
        Me.bton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btdisplay
        '
        Me.btdisplay.AnimationHoverSpeed = 0.07!
        Me.btdisplay.AnimationSpeed = 0.03!
        Me.btdisplay.BaseColor = System.Drawing.Color.LimeGreen
        Me.btdisplay.BorderColor = System.Drawing.Color.LimeGreen
        Me.btdisplay.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btdisplay.FocusedColor = System.Drawing.Color.Empty
        Me.btdisplay.Font = New System.Drawing.Font("Poppins", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdisplay.ForeColor = System.Drawing.Color.White
        Me.btdisplay.Image = Nothing
        Me.btdisplay.ImageSize = New System.Drawing.Size(52, 52)
        Me.btdisplay.Location = New System.Drawing.Point(613, 188)
        Me.btdisplay.Name = "btdisplay"
        Me.btdisplay.OnHoverBaseColor = System.Drawing.Color.LimeGreen
        Me.btdisplay.OnHoverBorderColor = System.Drawing.Color.LimeGreen
        Me.btdisplay.OnHoverForeColor = System.Drawing.Color.White
        Me.btdisplay.OnHoverImage = Nothing
        Me.btdisplay.OnPressedColor = System.Drawing.Color.Black
        Me.btdisplay.Size = New System.Drawing.Size(120, 120)
        Me.btdisplay.TabIndex = 79
        Me.btdisplay.Text = "Start"
        '
        'lbl_display
        '
        Me.lbl_display.BackColor = System.Drawing.Color.Transparent
        Me.lbl_display.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_display.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_display.Location = New System.Drawing.Point(4, 61)
        Me.lbl_display.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_display.Name = "lbl_display"
        Me.lbl_display.Size = New System.Drawing.Size(206, 36)
        Me.lbl_display.TabIndex = 81
        Me.lbl_display.Text = "0"
        Me.lbl_display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaElipsePanel3
        '
        Me.GunaElipsePanel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel3.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel3.Controls.Add(Me.lbl_time)
        Me.GunaElipsePanel3.Controls.Add(Me.Label4)
        Me.GunaElipsePanel3.Location = New System.Drawing.Point(312, 23)
        Me.GunaElipsePanel3.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaElipsePanel3.Name = "GunaElipsePanel3"
        Me.GunaElipsePanel3.Size = New System.Drawing.Size(236, 123)
        Me.GunaElipsePanel3.TabIndex = 82
        '
        'lbl_time
        '
        Me.lbl_time.BackColor = System.Drawing.Color.Transparent
        Me.lbl_time.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_time.Location = New System.Drawing.Point(4, 63)
        Me.lbl_time.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(228, 34)
        Me.lbl_time.TabIndex = 12
        Me.lbl_time.Text = "0"
        Me.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(4, 15)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(228, 34)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Time (ms)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaButton2
        '
        Me.GunaButton2.Animated = True
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton2.BaseColor = System.Drawing.Color.White
        Me.GunaButton2.BorderColor = System.Drawing.Color.White
        Me.GunaButton2.BorderSize = 2
        Me.GunaButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton2.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.GunaButton2.Image = Nothing
        Me.GunaButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton2.Location = New System.Drawing.Point(1118, 38)
        Me.GunaButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.MediumAquamarine
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Radius = 10
        Me.GunaButton2.Size = New System.Drawing.Size(175, 88)
        Me.GunaButton2.TabIndex = 83
        Me.GunaButton2.Text = "Play"
        Me.GunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'Timer4
        '
        '
        'lbl_waktutunggu
        '
        Me.lbl_waktutunggu.AutoSize = True
        Me.lbl_waktutunggu.BackColor = System.Drawing.Color.Transparent
        Me.lbl_waktutunggu.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_waktutunggu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_waktutunggu.Location = New System.Drawing.Point(929, 261)
        Me.lbl_waktutunggu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_waktutunggu.Name = "lbl_waktutunggu"
        Me.lbl_waktutunggu.Size = New System.Drawing.Size(28, 36)
        Me.lbl_waktutunggu.TabIndex = 86
        Me.lbl_waktutunggu.Text = "0"
        Me.lbl_waktutunggu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_waktutunggu.Visible = False
        '
        'TimerON
        '
        '
        'TimerOFF
        '
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel1.Controls.Add(Me.GunaElipsePanel5)
        Me.Panel1.Controls.Add(Me.GunaElipsePanel2)
        Me.Panel1.Controls.Add(Me.GunaElipsePanel1)
        Me.Panel1.Controls.Add(Me.GunaElipsePanel3)
        Me.Panel1.Controls.Add(Me.GunaButton2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1333, 171)
        Me.Panel1.TabIndex = 87
        '
        'GunaElipsePanel5
        '
        Me.GunaElipsePanel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel5.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel5.Controls.Add(Me.Label3)
        Me.GunaElipsePanel5.Controls.Add(Me.GunaTransfarantPictureBox1)
        Me.GunaElipsePanel5.Location = New System.Drawing.Point(811, 23)
        Me.GunaElipsePanel5.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaElipsePanel5.Name = "GunaElipsePanel5"
        Me.GunaElipsePanel5.Size = New System.Drawing.Size(267, 123)
        Me.GunaElipsePanel5.TabIndex = 85
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(1, 46)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 34)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Guide :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaTransfarantPictureBox1
        '
        Me.GunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaTransfarantPictureBox1.Image = CType(resources.GetObject("GunaTransfarantPictureBox1.Image"), System.Drawing.Image)
        Me.GunaTransfarantPictureBox1.Location = New System.Drawing.Point(111, 0)
        Me.GunaTransfarantPictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaTransfarantPictureBox1.Name = "GunaTransfarantPictureBox1"
        Me.GunaTransfarantPictureBox1.Size = New System.Drawing.Size(152, 132)
        Me.GunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox1.TabIndex = 32
        Me.GunaTransfarantPictureBox1.TabStop = False
        '
        'GunaElipsePanel2
        '
        Me.GunaElipsePanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel2.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel2.Controls.Add(Me.Label16)
        Me.GunaElipsePanel2.Controls.Add(Me.GunaCirclePictureBox1)
        Me.GunaElipsePanel2.Location = New System.Drawing.Point(24, 23)
        Me.GunaElipsePanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaElipsePanel2.Name = "GunaElipsePanel2"
        Me.GunaElipsePanel2.Size = New System.Drawing.Size(267, 123)
        Me.GunaElipsePanel2.TabIndex = 84
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(116, 42)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(147, 41)
        Me.Label16.TabIndex = 61
        Me.Label16.Text = "Username"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Image = CType(resources.GetObject("GunaCirclePictureBox1.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(25, 21)
        Me.GunaCirclePictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(76, 76)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 59
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel1.Controls.Add(Me.Label5)
        Me.GunaElipsePanel1.Controls.Add(Me.lbl_display)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(571, 23)
        Me.GunaElipsePanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(214, 123)
        Me.GunaElipsePanel1.TabIndex = 83
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(4, 15)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(206, 34)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Experiment"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'greencar
        '
        Me.greencar.BackColor = System.Drawing.Color.Transparent
        Me.greencar.BaseColor = System.Drawing.Color.Black
        Me.greencar.Image = CType(resources.GetObject("greencar.Image"), System.Drawing.Image)
        Me.greencar.Location = New System.Drawing.Point(7, 409)
        Me.greencar.Name = "greencar"
        Me.greencar.Size = New System.Drawing.Size(357, 96)
        Me.greencar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.greencar.TabIndex = 76
        Me.greencar.TabStop = False
        '
        'Consistency_Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1333, 730)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl_waktutunggu)
        Me.Controls.Add(Me.btdisplay)
        Me.Controls.Add(Me.bton)
        Me.Controls.Add(Me.btoff)
        Me.Controls.Add(Me.greencar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Consistency_Game"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GunaElipsePanel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GunaElipsePanel5.ResumeLayout(False)
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaElipsePanel2.ResumeLayout(False)
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaElipsePanel1.ResumeLayout(False)
        CType(Me.greencar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents greencar As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents btoff As Guna.UI.WinForms.GunaButton
    Friend WithEvents bton As Guna.UI.WinForms.GunaButton
    Friend WithEvents btdisplay As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents lbl_display As System.Windows.Forms.Label
    Friend WithEvents GunaElipsePanel3 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents lbl_time As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents lbl_waktutunggu As System.Windows.Forms.Label
    Friend WithEvents TimerON As System.Windows.Forms.Timer
    Friend WithEvents TimerOFF As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GunaElipsePanel2 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaElipsePanel5 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GunaTransfarantPictureBox1 As Guna.UI.WinForms.GunaTransfarantPictureBox
End Class
