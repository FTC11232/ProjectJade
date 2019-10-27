<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mechanumSimulation
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
        Me.components = New System.ComponentModel.Container()
        Me.motorFrontLeft = New System.Windows.Forms.TextBox()
        Me.motorBackRight = New System.Windows.Forms.TextBox()
        Me.motorBackLeft = New System.Windows.Forms.TextBox()
        Me.motorFrontRight = New System.Windows.Forms.TextBox()
        Me.lblFrontLeftPower = New System.Windows.Forms.Label()
        Me.lblFrontRightPower = New System.Windows.Forms.Label()
        Me.lblBackRightPower = New System.Windows.Forms.Label()
        Me.lblBackLeftPower = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblG = New System.Windows.Forms.Label()
        Me.lblR = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'motorFrontLeft
        '
        Me.motorFrontLeft.Location = New System.Drawing.Point(12, 12)
        Me.motorFrontLeft.Name = "motorFrontLeft"
        Me.motorFrontLeft.Size = New System.Drawing.Size(100, 20)
        Me.motorFrontLeft.TabIndex = 0
        '
        'motorBackRight
        '
        Me.motorBackRight.Location = New System.Drawing.Point(202, 220)
        Me.motorBackRight.Name = "motorBackRight"
        Me.motorBackRight.Size = New System.Drawing.Size(100, 20)
        Me.motorBackRight.TabIndex = 1
        '
        'motorBackLeft
        '
        Me.motorBackLeft.Location = New System.Drawing.Point(12, 220)
        Me.motorBackLeft.Name = "motorBackLeft"
        Me.motorBackLeft.Size = New System.Drawing.Size(100, 20)
        Me.motorBackLeft.TabIndex = 2
        '
        'motorFrontRight
        '
        Me.motorFrontRight.Location = New System.Drawing.Point(202, 12)
        Me.motorFrontRight.Name = "motorFrontRight"
        Me.motorFrontRight.Size = New System.Drawing.Size(100, 20)
        Me.motorFrontRight.TabIndex = 3
        '
        'lblFrontLeftPower
        '
        Me.lblFrontLeftPower.AutoSize = True
        Me.lblFrontLeftPower.Location = New System.Drawing.Point(118, 15)
        Me.lblFrontLeftPower.Name = "lblFrontLeftPower"
        Me.lblFrontLeftPower.Size = New System.Drawing.Size(13, 13)
        Me.lblFrontLeftPower.TabIndex = 4
        Me.lblFrontLeftPower.Text = "0"
        '
        'lblFrontRightPower
        '
        Me.lblFrontRightPower.AutoSize = True
        Me.lblFrontRightPower.Location = New System.Drawing.Point(308, 15)
        Me.lblFrontRightPower.Name = "lblFrontRightPower"
        Me.lblFrontRightPower.Size = New System.Drawing.Size(13, 13)
        Me.lblFrontRightPower.TabIndex = 5
        Me.lblFrontRightPower.Text = "0"
        '
        'lblBackRightPower
        '
        Me.lblBackRightPower.AutoSize = True
        Me.lblBackRightPower.Location = New System.Drawing.Point(308, 223)
        Me.lblBackRightPower.Name = "lblBackRightPower"
        Me.lblBackRightPower.Size = New System.Drawing.Size(13, 13)
        Me.lblBackRightPower.TabIndex = 7
        Me.lblBackRightPower.Text = "0"
        '
        'lblBackLeftPower
        '
        Me.lblBackLeftPower.AutoSize = True
        Me.lblBackLeftPower.Location = New System.Drawing.Point(118, 223)
        Me.lblBackLeftPower.Name = "lblBackLeftPower"
        Me.lblBackLeftPower.Size = New System.Drawing.Size(13, 13)
        Me.lblBackLeftPower.TabIndex = 6
        Me.lblBackLeftPower.Text = "0"
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(415, 386)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 13)
        Me.Label10.TabIndex = 17
        '
        'lblG
        '
        Me.lblG.AutoSize = True
        Me.lblG.Location = New System.Drawing.Point(127, 502)
        Me.lblG.Name = "lblG"
        Me.lblG.Size = New System.Drawing.Size(0, 13)
        Me.lblG.TabIndex = 18
        '
        'lblR
        '
        Me.lblR.AutoSize = True
        Me.lblR.Location = New System.Drawing.Point(99, 502)
        Me.lblR.Name = "lblR"
        Me.lblR.Size = New System.Drawing.Size(0, 13)
        Me.lblR.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(199, 522)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 13)
        Me.Label11.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(256, 522)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 13)
        Me.Label12.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(81, 299)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 13)
        Me.Label13.TabIndex = 22
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(256, 567)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 13)
        Me.Label14.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(141, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 25
        '
        'mechanumSimulation
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(355, 276)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblR)
        Me.Controls.Add(Me.lblG)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblBackRightPower)
        Me.Controls.Add(Me.lblBackLeftPower)
        Me.Controls.Add(Me.lblFrontRightPower)
        Me.Controls.Add(Me.lblFrontLeftPower)
        Me.Controls.Add(Me.motorFrontRight)
        Me.Controls.Add(Me.motorBackLeft)
        Me.Controls.Add(Me.motorBackRight)
        Me.Controls.Add(Me.motorFrontLeft)
        Me.Name = "mechanumSimulation"
        Me.Text = "Mechanum Simulation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents motorFrontLeft As TextBox
    Friend WithEvents motorBackRight As TextBox
    Friend WithEvents motorBackLeft As TextBox
    Friend WithEvents motorFrontRight As TextBox
    Friend WithEvents lblFrontLeftPower As Label
    Friend WithEvents lblFrontRightPower As Label
    Friend WithEvents lblBackRightPower As Label
    Friend WithEvents lblBackLeftPower As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents lbluse As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblG As Label
    Friend WithEvents lblR As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
End Class
