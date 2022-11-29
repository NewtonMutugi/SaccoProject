Imports System.Drawing.Text
Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp

Public Class MainForm

    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBorderBtn)

        'Form
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea


    End Sub
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()

            'Button
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.Transparent
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            'currentBtn.TextAlign = ContentAlignment.MiddleCenter
            'currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText

            'Left border
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()

            'current form icon
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor

            lblFormTitle.Text = currentBtn.Text
        End If
    End Sub
    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then

            currentBtn.BackColor = Color.Transparent
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub


    Private Sub MainForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()

    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ActivateButton(sender, RGBColors.color1)
        BunifuPages.SetPage(1)

    End Sub

    Private Sub btnContribution_Click(sender As Object, e As EventArgs)
        ActivateButton(sender, RGBColors.color2)
        BunifuPages.SetPage(2)
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinueContr.Click
        BunifuPages.SetPage(3)
    End Sub

    Private Sub btnLoan_Click(sender As Object, e As EventArgs) Handles btnLoan.Click
        ActivateButton(sender, RGBColors.color3)
        BunifuPages.SetPage(4)
    End Sub

    Private Sub btnContinueLoan_Click(sender As Object, e As EventArgs) Handles btnContinueLoan.Click
        BunifuPages.SetPage(5)
    End Sub

    Private Sub btnContinueLoan2_Click(sender As Object, e As EventArgs) Handles btnContinueLoan2.Click
        BunifuPages.SetPage(6)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ActivateButton(sender, RGBColors.color4)
        BunifuPages.SetPage(7)
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        ActivateButton(sender, RGBColors.color5)
        BunifuPages.SetPage(9)
    End Sub
    Private Sub imgHome_Click(sender As Object, e As EventArgs) Handles imgHome.Click
        Reset()
    End Sub
    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        IconCurrentForm.IconChar = IconChar.Home
        IconCurrentForm.IconColor = Color.MediumPurple
        lblFormTitle.Text = "Home"
        BunifuPages.SetPage(0)
    End Sub



    Private Sub Contribution_Click(sender As Object, e As EventArgs) Handles Contribution1.Click

    End Sub

    Private Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click

    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click

    End Sub

    Private Sub BunifuSeparator5_Click(sender As Object, e As EventArgs) Handles BunifuSeparator5.Click

    End Sub

    Private Sub Help_Click(sender As Object, e As EventArgs) Handles Help.Click

    End Sub
End Class