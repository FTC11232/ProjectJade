Imports System.Runtime.InteropServices
Imports System.Math

Public Class mechanumSimulation

    Declare Function joyGetPosEx Lib "winmm.dll" (ByVal uJoyID As Integer, ByRef pji As JOYINFOEX) As Integer

    <StructLayout(LayoutKind.Sequential)>
    Public Structure JOYINFOEX
        Public dwSize As Integer
        Public dwFlags As Integer
        Public dwXpos As Integer
        Public dwYpos As Integer
        Public dwZpos As Integer
        Public dwRpos As Integer
        Public dwUpos As Integer
        Public dwVpos As Integer
        Public dwButtons As Integer
        Public dwButtonNumber As Integer
        Public dwPOV As Integer
        Public dwReserved1 As Integer
        Public dwReserved2 As Integer
    End Structure

    Dim myjoyEX As JOYINFOEX
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        ' Get the joystick information
        Call joyGetPosEx(0, myjoyEX)

        With myjoyEX
            Dim stickX As Double = Decimal.Round(((.dwXpos - 32767) / 32767), 2, MidpointRounding.AwayFromZero)
            Dim stickY As Double = (Decimal.Round(((.dwYpos - 32767) / 32767), 2, MidpointRounding.AwayFromZero) * -1)
            Dim rotation As Integer

            Dim frontLeftPower As Double
            Dim frontRightPower As Double
            Dim backLeftPower As Double
            Dim backRightPower As Double

            Dim CurrentButton As Long

            Label1.Text = "X:" + stickX.ToString()
            Label2.Text = "Y:" + stickY.ToString()

            CurrentButton = .dwButtons

            If CurrentButton = 16 Then

                Label7.Text = "Turning Right"
                rotation = 1

            ElseIf CurrentButton = 8 Then

                Label7.Text = "Turning Left"
                rotation = -1

            ElseIf CurrentButton = 0 Then

                Label7.Text = "Not Turning"
                rotation = 0

            End If

            'wheelSpeeds[MotorType.kFrontLeft.value] = input.x + input.y + zRotation;
            'wheelSpeeds[MotorType.kFrontRight.value] = -input.x + input.y - zRotation;
            'wheelSpeeds[MotorType.kRearLeft.value] = -input.x + input.y + zRotation;
            'wheelSpeeds[MotorType.kRearRight.value] = input.x + input.y - zRotation;

            frontLeftPower = Convert.ToString(stickX + stickY + rotation)
            frontRightPower = Convert.ToString((stickX * -1) + stickY - rotation)
            backLeftPower = Convert.ToString((stickX * -1) + stickY + rotation)
            backRightPower = Convert.ToString(stickX + stickY - rotation)

            If frontLeftPower > 1 Then
                frontLeftPower = 1
            End If
            If frontRightPower > 1 Then
                frontRightPower = 1
            End If
            If backLeftPower > 1 Then
                backLeftPower = 1
            End If
            If backRightPower > 1 Then
                backRightPower = 1
            End If

            If frontLeftPower < -1 Then
                frontLeftPower = -1
            End If
            If frontRightPower < -1 Then
                frontRightPower = -1
            End If
            If backLeftPower < -1 Then
                backLeftPower = -1
            End If
            If backRightPower < -1 Then
                backRightPower = -1
            End If

            lblFrontLeftPower.Text = frontLeftPower.ToString()
            lblFrontRightPower.Text = frontRightPower.ToString()
            lblBackLeftPower.Text = backLeftPower.ToString()
            lblBackRightPower.Text = backRightPower.ToString()

            Dim frontRightColor As Double = Abs(frontRightPower * 255)
            Dim frontLeftColor As Double = Abs(frontLeftPower * 255)
            Dim backRightColor As Double = Abs(backRightPower * 255)
            Dim backLeftColor As Double = Abs(backLeftPower * 255)

            If frontRightPower > 0 Then
                motorFrontRight.BackColor = Color.FromArgb(0, frontRightColor, 0)
            End If
            If frontLeftPower > 0 Then
                motorFrontLeft.BackColor = Color.FromArgb(0, frontLeftColor, 0)
            End If
            If backRightPower > 0 Then
                motorBackRight.BackColor = Color.FromArgb(0, backRightColor, 0)
            End If
            If backLeftPower > 0 Then
                motorBackLeft.BackColor = Color.FromArgb(0, backLeftColor, 0)
            End If

            If frontRightPower < 0 Then
                motorFrontRight.BackColor = Color.FromArgb(255, 0, 0)
            End If
            If frontLeftPower < 0 Then
                motorFrontLeft.BackColor = Color.FromArgb(frontLeftColor, 0, 0)
            End If
            If backRightPower < 0 Then
                motorBackRight.BackColor = Color.FromArgb(backRightColor, 0, 0)
            End If
            If backLeftPower < 0 Then
                motorBackLeft.BackColor = Color.FromArgb(backLeftColor, 0, 0)
            End If
        End With
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        motorFrontLeft.BackColor = Color.Black
        motorFrontRight.BackColor = Color.Black
        motorBackLeft.BackColor = Color.Black
        motorBackRight.BackColor = Color.Black

        myjoyEX.dwSize = 64
        myjoyEX.dwFlags = &HFF ' All information
        Timer1.Interval = 200  'Update at 5 hz
        Timer1.Start()

    End Sub





End Class
