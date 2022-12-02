Imports System.Data.OleDb
Imports System.Drawing.Text
Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp

Public Class MainForm
    Dim pro As String
    Dim conString As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim da As New OleDbDataAdapter
    Dim con As New OleDbConnection
    Dim dt As New DataTable
    Dim dr As OleDbDataReader
    Dim Qry As String
    ' Dim C As New conection
    Dim cmd As OleDbCommand

    Dim currentYearID As Integer
    Private Sub conDB()
        Try
            conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\Education\Daystar Work\Semesters\Aug 2022\ACS 216\Project\SaccoDB.accdb"
            myconnection.ConnectionString = conString
            myconnection.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub


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
        lblBanner.Text = "Welcome Home, " & txtFirstName.Text & ". "

        Call conDB()
        command = "SELECT ContributionMonth.MemberID, Sum(ContributionMonth.Amount) AS SumOfAmount FROM ContributionMonth GROUP BY ContributionMonth.MemberID HAVING (((ContributionMonth.MemberID)=" & txtMemberID.Text & "));"
        Dim cmd As New OleDbCommand(command, myconnection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        If dr.Read Then
            txtTotalContribution.Text = dr("SumOfAmount")
            myconnection.Close()
        End If


        ActivateButton(sender, RGBColors.color1)
        BunifuPages.SetPage(1)

    End Sub

    Private Sub btnContribution_Click(sender As Object, e As EventArgs)
        ActivateButton(sender, RGBColors.color2)
        BunifuPages.SetPage(2)
    End Sub
    Dim contrAmount As Double
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinueContr.Click
        Call conDB()

        Dim sql1 As String = "SELECT [YearID] FROM CurrentYear"
        Dim cmd1 As New OleDbCommand(sql1, myconnection)
        cmd1.Parameters.Add(New OleDbParameter("YearID", CType(currentYearID, Integer)))
        Dim dr1 As OleDbDataReader = cmd1.ExecuteReader

        While dr1.Read
            currentYearID = dr1("YearID")

        End While
        txtYearID.Text = currentYearID
        myconnection.Close()

        Call conDB()
        Dim query = "SELECT [YearID], [Month]
                         FROM ContributionMonth
                        WHERE YearID=" & currentYearID & " AND Month= '" & cboMonth.Text & "'"
        Dim cmd As New OleDbCommand(query, myconnection)
        cmd.Parameters.Add(New OleDbParameter("YearID", CType(currentYearID, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Month", CType(cboMonth.Text, String)))

        Dim dr As OleDbDataReader = cmd.ExecuteReader


        If txtContrAmount.Text = "" Then
            MsgBox("Please enter the amount you want to contribute", MsgBoxStyle.Exclamation, "Sacco")
            txtContrAmount.Focus()
        ElseIf cboMonth.Text = "" Then
            MsgBox("Please select the month you want to contribute", MsgBoxStyle.Exclamation, "Sacco")
            cboMonth.Focus()
        ElseIf dr.HasRows Then
            MsgBox("You have already contributed for this month", MsgBoxStyle.Exclamation, "Sacco")
            myconnection.Close()
            cboMonth.Focus()
        ElseIf Double.TryParse(txtContrAmount.Text, contrAmount) Then
            contrAmount = txtContrAmount.Text
            If contrAmount < 1000 Then
                MsgBox("The minimum contribution amount is Ksh. 1000", MsgBoxStyle.Exclamation, "Sacco")
                txtContrAmount.Focus()
            Else
                contrAmount = txtContrAmount.Text
                myconnection.Close()
                BunifuPages.SetPage(3)
            End If
        Else
            MsgBox("Please enter a valid amount", MsgBoxStyle.Exclamation, "Sacco")
            txtContrAmount.Focus()

        End If

    End Sub

    Private Sub btnLoan_Click(sender As Object, e As EventArgs) Handles btnLoan.Click

        Call conDB()
        Dim query = "SELECT [MemberID]
                         FROM LoanApplication
                        WHERE MemberID= " & txtMemberID.Text & ""
        Dim cmd As New OleDbCommand(query, myconnection)
        cmd.Parameters.Add(New OleDbParameter("MemberID", CType(txtMemberID.Text, Integer)))
        Dim dr As OleDbDataReader = cmd.ExecuteReader

        If dr.HasRows Then
            MsgBox("You have already have a loan", MsgBoxStyle.Exclamation, "Sacco")
            myconnection.Close()

            Call conDB()
            command = "SELECT * FROM LoanApplication WHERE MemberID=" & txtMemberID.Text & ""
            Dim cmd1 As New OleDbCommand(command, myconnection)
            Dim dr1 As OleDbDataReader = cmd1.ExecuteReader
            If dr1.Read Then
                txtReLoanID.Text = dr1("LoanID")
                txtLoanReType.Text = dr1("LoanType")
                txtReLoanAmount.Text = dr1("LoanAmount")
                txtInterestAmount.Text = dr1("Interest")
                txtTotalLoan.Text = dr1("TotalLoan")
                txtReMonthlyInstallment.Text = dr1("MonthlyRepayment")

                myconnection.Close()
            End If

            BunifuPages.SetPage(10)

        Else
            ActivateButton(sender, RGBColors.color3)
            BunifuPages.SetPage(4)
        End If

    End Sub

    Private Sub btnContinueLoan_Click(sender As Object, e As EventArgs) Handles btnContinueLoan.Click
        BunifuPages.SetPage(5)
    End Sub

    Private Sub btnContinueLoan2_Click(sender As Object, e As EventArgs)
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


        If txtPayment.Text = "" Then
            MsgBox("Please enter the ensure payment is done", MsgBoxStyle.Exclamation, "Sacco")
            txtPayment.Focus()
        Else

            Call conDB()
            Dim sql2 As String = "INSERT INTO ContributionMonth ([MemberID], [Amount], [Month], [YearID], [DatePaid]) 
                                        VALUES ('" & txtMemberID.Text & "', '" & txtContrAmount.Text & "', '" & cboMonth.Text & "','" & currentYearID & "','" & Date.Today & "')"
            Dim cmd2 As New OleDbCommand(sql2, myconnection)
            cmd2.Parameters.Add(New OleDbParameter("MemberID", CType(txtMemberID.Text, String)))
            cmd2.Parameters.Add(New OleDbParameter("Amount", CType(txtContrAmount.Text, Double)))
            cmd2.Parameters.Add(New OleDbParameter("Month", CType(cboMonth.Text, String)))
            cmd2.Parameters.Add(New OleDbParameter("YearID", CType(txtYearID.Text, Integer)))
            cmd2.Parameters.Add(New OleDbParameter("DatePaid", CType(Date.Today, Date)))
            cmd2.ExecuteNonQuery()
            myconnection.Close()

            MsgBox("Thank you for your contribution", MsgBoxStyle.Information, "Sacco")
            BunifuPages.SetPage(1)


        End If
    End Sub

    Private Sub BunifuSeparator5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Help_Click(sender As Object, e As EventArgs) Handles Help.Click

    End Sub

    Private Sub btnMpesa_Click(sender As Object, e As EventArgs) Handles btnMpesa.Click
        txtPayment.Text = 1
        MessageBox.Show("Payment Successful")
    End Sub

    Private Sub btnMasterCard_Click(sender As Object, e As EventArgs) Handles btnMasterCard.Click
        txtPayment.Text = 2
        MessageBox.Show("Payment Successful")
    End Sub

    Private Sub btnVisa_Click(sender As Object, e As EventArgs) Handles btnVisa.Click
        txtPayment.Text = 3
        MessageBox.Show("Payment Successful")
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call conDB()
        Dim sql As String = "SELECT [MemberID] FROM MembersDetails WHERE Email = '" & txtEmail.Text & "'"
        Dim sql2 As String = "SELECT [CurrentYear] FROM CurrentYear"
        Dim sql3 As String = "SELECT [CurrentID] FROM CurrentYear"
        Dim sqlArray() As String = {sql, sql2}
        Dim returnedValues(2) As String
        Dim requiredFields() As String = {"MemberID", "CurrentYear"}
        Dim i As Integer
        For i = 0 To sqlArray.Length - 1
            Dim cmd As New OleDbCommand(sqlArray(i), myconnection)
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            While dr.Read
                returnedValues(i) = dr(requiredFields(i))
            End While
            dr.Close()
        Next

        myconnection.Close()
        txtMemberID.Text = returnedValues(0)
        txtCurrentYear.Text = returnedValues(1)

        Call conDB()
        Dim sql4 As String = "SELECT * FROM MembersDetails WHERE Email = '" & txtEmail.Text & "'"
        Dim cmd2 As New OleDbCommand(sql4, myconnection)
        Dim dr2 As OleDbDataReader = cmd2.ExecuteReader
        cmd2.Parameters.Add(New OleDbParameter("FirstName", CType(txtFirstName.Text, String)))
        cmd2.Parameters.Add(New OleDbParameter("MiddleName", CType(txtMiddleName.Text, String)))
        cmd2.Parameters.Add(New OleDbParameter("LastName", CType(txtLastName.Text, String)))
        cmd2.Parameters.Add(New OleDbParameter("DOB", CType(txtDOB.Text, String)))
        cmd2.Parameters.Add(New OleDbParameter("Gender", CType(txtGender.Text, String)))
        cmd2.Parameters.Add(New OleDbParameter("PhoneNumber", CType(txtPhone.Text, String)))
        cmd2.Parameters.Add(New OleDbParameter("IDNo", CType(txtIDNumber.Text, String)))
        'cmd.Parameters.Add(New OleDbParameter("RegistrationFee", CType(txtMpesa.Text, Integer)))
        cmd2.Parameters.Add(New OleDbParameter("Email", CType(txtEmail.Text, String)))
        'cmd.Parameters.Add(New OleDbParameter("Password", CType(txtPassword.Text, String)))
        'cmd.Parameters.Add(New OleDbParameter("SecurityQuestion", CType(cboQuestion.Text, String)))
        'cmd.Parameters.Add(New OleDbParameter("Response", CType(txtResponse.Text, String)))
        Try
            While dr2.Read
                txtMemberID.Text = dr2("MemberID")
                txtFirstName.Text = dr2("FirstName")
                txtLastName.Text = dr2("LastName")
                txtMiddleName.Text = dr2("MiddleName")
                txtEmail.Text = dr2("Email")
                txtPhone.Text = dr2("PhoneNumber")
                txtIDNumber.Text = dr2("IDNo")
                txtDOB.Text = dr2("DOB")
                txtGender.Text = dr2("Gender")
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            myconnection.Close()
        End Try
        myconnection.Close()


    End Sub

    Private Sub cboLoanType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLoanType.SelectedIndexChanged
        If cboLoanType.Text = "Emergency Loan" Then
            lblPeriod.Text = "12 months"
            lblRate.Text = "10%"
        Else
            lblPeriod.Text = "24 months"
            lblRate.Text = "15%"
        End If
    End Sub

    Private Sub BunifuTextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Dim loanAmount As Integer
    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        Try
            loanAmount = txtLoanAmount.Text
            BunifuPages.SetPage(6)
            If cboLoanType.Text = "Emergency Loan" Then
                txtLoan.Text = loanAmount
                txtInterest.Text = loanAmount * 0.1
                txtTotalLoan.Text = loanAmount + txtInterest.Text
                txtMonthly.Text = txtTotalLoan.Text / 12
                txtDateOfRepayment.Text = Date.Today.AddMonths(12)
                txtDateTaken.Text = Date.Today

            Else
                txtLoan.Text = loanAmount
                txtInterest.Text = loanAmount * 0.15
                txtTotalLoan.Text = loanAmount + txtInterest.Text
                txtMonthly.Text = txtTotalLoan.Text / 24
                txtDateOfRepayment.Text = Date.Today.AddMonths(24)
            End If

        Catch ex As Exception
            MsgBox("Please enter a valid amount", MsgBoxStyle.Exclamation, "Sacco")
            txtLoanAmount.Focus()
        End Try

    End Sub

    Private Sub iconProfile_Click(sender As Object, e As EventArgs) Handles iconProfile.Click
        BunifuPages.SetPage(0)
    End Sub

    Private Sub btnApplyLoan_Click(sender As Object, e As EventArgs) Handles btnApplyLoan.Click
        Dim sql As String = "INSERT INTO LoanApplication (LoanID, MemberID, LoanType, LoanAmount, DateTaken, ExpectedReturnDate,Interest, TotalLoan,CurrentYear,MonthlyRepayment) VALUES ('" & txtMemberID.Text & "','" & txtMemberID.Text & "','" & cboLoanType.Text & "','" & txtLoanAmount.Text & "','" & txtDateTaken.Text & "','" & txtDateOfRepayment.Text & "','" & txtInterest.Text & "','" & txtTotalLoan.Text & "','" & txtCurrentYear.Text & "','" & txtMonthly.Text & "')"
        Dim cmd As New OleDbCommand(sql, myconnection)
        cmd.Parameters.Add(New OleDbParameter("MemberID", CType(txtMemberID.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("LoanType", CType(cboLoanType.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("LoanAmount", CType(txtLoan.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("DateTaken", CType(txtDateTaken.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Interest", CType(txtInterest.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("TotalLoan", CType(txtTotalLoan.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("MonthlyRepayment", CType(txtMonthly.Text, Double)))
        cmd.Parameters.Add(New OleDbParameter("DateOfRepayment", CType(txtDateOfRepayment.Text, Date)))
        cmd.Parameters.Add(New OleDbParameter("CurrentYear", CType(txtCurrentYear.Text, String)))
        Try
            myconnection.Open()
            cmd.ExecuteNonQuery()
            myconnection.Close()
            MsgBox("Loan application successful", MsgBoxStyle.Information, "Sacco")
            BunifuPages.SetPage(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            myconnection.Close()
        End Try

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        MsgBox("Are you sure you want to Log out?", MsgBoxStyle.YesNo, "Sacco")
        If MsgBoxResult.Yes Then
            Me.Hide()
            LoginForm.Show()
        End If
    End Sub

    Private Sub cboLoanRepayment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLoanRepayment.SelectedIndexChanged
        If cboLoanRepayment.Text = "Mpesa" Then
            btnLoanMpesa.Visible = True
            btnLoanMaster.Visible = False
            btnLoanVisa.Visible = False
        ElseIf cboLoanRepayment.Text = "Mastercard" Then
            btnLoanMpesa.Visible = False
            btnLoanMaster.Visible = True
            btnLoanVisa.Visible = False
        Else
            btnLoanMpesa.Visible = False
            btnLoanMaster.Visible = False
            btnLoanVisa.Visible = True
        End If
    End Sub

    Private Sub btnLoanMpesa_Click(sender As Object, e As EventArgs) Handles btnLoanMpesa.Click, btnLoanMaster.Click, btnLoanVisa.Click

        MsgBox("Are you sure you want to pay use the payment method?", MsgBoxStyle.YesNo, "Sacco")
        If MsgBoxResult.Yes Then
            MsgBox("Payment successful", MsgBoxStyle.Information, "Sacco")
            txtRePayCheck.Text = 1
        End If


    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        BunifuPages.SetPage(11)

    End Sub

    Private Sub BunifuButton1_Click_1(sender As Object, e As EventArgs) Handles btnFinish.Click
        Dim balance = txtTotalLoan.Text - txtReMonthlyInstallment.Text
        If txtRePayCheck.Text = 1 Then
            Dim sql As String = "INSERT INTO LoanRepayment (LoanID,MemberID, Amount, Balance, RepDate, RepMethod) 
                                VALUES (" & txtReLoanID.Text & "," & txtMemberID.Text & ", " & txtReMonthlyInstallment.Text & ", " & balance & "," & Date.Today & ", " & cboLoanRepayment.Text & ")"
            Dim cmd As New OleDbCommand(sql, myconnection)
            cmd.Parameters.Add(New OleDbParameter("LoanID", CType(txtReLoanID.Text, Integer)))
            cmd.Parameters.Add(New OleDbParameter("MemberID", CType(txtMemberID.Text, Integer)))
            cmd.Parameters.Add(New OleDbParameter("Amount", CType(txtReMonthlyInstallment.Text, Double)))
            cmd.Parameters.Add(New OleDbParameter("Balance", CType(balance, Double)))
            cmd.Parameters.Add(New OleDbParameter("RepMethod", CType(cboLoanRepayment.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("RepDate", CType(Date.Today, Date)))
            Try
                myconnection.Open()
                cmd.ExecuteNonQuery()
                myconnection.Close()
                MsgBox("Loan Repayment successful", MsgBoxStyle.Information, "Sacco")
                BunifuPages.SetPage(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                myconnection.Close()
            End Try

        Else
            MsgBox("Please pay the loan first", MsgBoxStyle.Exclamation, "Sacco")
        End If
    End Sub
End Class