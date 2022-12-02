Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions

Public Class LoginForm
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

    Private Sub conDB()
        Try
            conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\Education\Daystar Work\Semesters\Aug 2022\ACS 216\Project\SaccoDB.accdb"
            myconnection.ConnectionString = conString
            myconnection.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        BunifuPage.SetPage(0)
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        BunifuPage.SetPage(1)
    End Sub



    Private Sub btnJoin_Click(sender As Object, e As EventArgs) Handles btnJoin.Click
        If txtEmail.Text = "" Then
            MsgBox("Please enter email address")
            txtEmail.Focus()
            txtEmail.BorderColorIdle = Color.Red
        ElseIf txtJoinPass.Text = "" Then
            MsgBox("Please enter Password")
            txtJoinPass.Focus()
            txtJoinPass.BorderColorIdle = Color.Red
        ElseIf txtPasswordConfirm.Text = "" Then
            MsgBox("Pleae enter password confirmation")
            txtPasswordConfirm.Focus()
            txtPasswordConfirm.BorderColorIdle = Color.Red
        ElseIf txtPasswordConfirm.Text <> txtJoinPass.Text Then
            MsgBox("Password does not match")
            txtPasswordConfirm.Focus()
            txtPasswordConfirm.BorderColorIdle = Color.Red
        Else
            BunifuPage.SetPage(2)
        End If


    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click

        If txtFirstName.Text = "" Then
            MsgBox("Please Enter First Name")
            txtFirstName.Focus()
            txtFirstName.BorderColorIdle = Color.Red
        ElseIf txtSurname.Text = "" Then
            MsgBox("Please Enter Last Name")
            txtSurname.Focus()
            txtSurname.BorderColorIdle = Color.Red
        ElseIf txtPhone.Text = "" Then
            MsgBox("Please Enter Email")
            txtPhone.Focus()
            txtPhone.BorderColorIdle = Color.Red
        ElseIf txtGender.Text = "" Then
            MsgBox("Please enter Gender")
            txtGender.Focus()

        ElseIf txtID.Text = "" Then
            MsgBox("Please Enter ID Number")
            txtID.Focus()
            txtID.BorderColorIdle = Color.Red
        ElseIf txtMpesa.Text = "" Then
            MsgBox("Please confirm payment")
            txtMpesa.Focus()
            txtMpesa.BorderColorIdle = Color.Red
        ElseIf cboQuestion.Text = "" Then
            MsgBox("Please select a security question")
            cboQuestion.Focus()

        ElseIf txtResponse.Text = "" Then
            MsgBox("Please enter a response")
            txtResponse.Focus()

        Else
            Call conDB()
            command = "INSERT INTO MembersDetails ([FirstName],[MiddleName],[LastName],[DOB],[Gender],[PhoneNumber],[IDNo],[RegistrationFee],[Email],[Password],[SecurityQuestion],[Response]) VALUES ('" & txtFirstName.Text & "','" & txtMiddleName.Text & "','" & txtSurname.Text & "','" & dtpDOB.Value & "','" & txtGender.Text & "','" & txtPhone.Text & "','" & txtID.Text & "','" & txtMpesa.Text & "','" & txtEmail.Text & "','" & txtJoinPass.Text & "','" & cboQuestion.Text & "','" & txtResponse.Text & "');"

            Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)
            cmd.Parameters.Add(New OleDbParameter("FirstName", CType(txtFirstName.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("MiddleName", CType(txtMiddleName.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("LastName", CType(txtSurname.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("DOB", CType(dtpDOB.Value, Date)))
            cmd.Parameters.Add(New OleDbParameter("Gender", CType(txtGender.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("PhoneNumber", CType(txtPhone.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("IDNo", CType(txtID.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("RegistrationFee", CType(txtMpesa.Text, Integer)))
            cmd.Parameters.Add(New OleDbParameter("Email", CType(txtEmail.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Password", CType(txtPassword.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("SecurityQuestion", CType(cboQuestion.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Response", CType(txtResponse.Text, String)))

            Try

                cmd.ExecuteNonQuery()
                cmd.Dispose()
                myconnection.Close()
                MessageBox.Show("Account Created Successfully")
                BunifuPage.SetPage(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        If txtUsername.Text = "" Then
            MessageBox.Show("Please Enter Username")
            txtUsername.Focus()
        ElseIf txtPassword.Text = "" Then
            MessageBox.Show("Please Enter Password")
            txtPassword.Focus()
        Else
            Call conDB()
            command = "SELECT * FROM MembersDetails WHERE [Email] = '" & txtUsername.Text & "' AND [Password] = '" & txtPassword.Text & "'"
            Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)
            cmd.Parameters.Add(New OleDbParameter("Email", CType(txtUsername.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Password", CType(txtPassword.Text, String)))
            Try
                dr = cmd.ExecuteReader
                Dim count As Integer
                count = 0
                While dr.Read
                    count = count + 1
                End While
                If count = 1 Then
                    MsgBox("Login Successful", MsgBoxStyle.Information, "Sacco")

                    MainForm.txtEmail.Text = txtUsername.Text
                    myconnection.Close()
                    MainForm.Show()
                    Me.Hide()
                ElseIf count > 1 Then
                    MessageBox.Show("Duplicate Username and Password")
                Else
                    MsgBox("Incorrect username and password!", MsgBoxStyle.Exclamation, "Sacco")
                    myconnection.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub


    Private Sub btnMpesa_Click(sender As Object, e As EventArgs) Handles btnMpesa.Click
        MsgBox("Payment Successful", MsgBoxStyle.Information, "Sacco")
        txtMpesa.Text = 1
    End Sub

    Private Sub btnGoogle_Click(sender As Object, e As EventArgs) Handles btnGoogle.Click
        MsgBox("Still in Development. Apologies for any inconviniences caused", MsgBoxStyle.Information, "Sacco")
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        MsgBox("Still in Development. Apologies for any inconviniences caused", MsgBoxStyle.Information, "Sacco")
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub txtUsername_LostFocus(sender As Object, e As EventArgs) Handles txtUsername.LostFocus

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Focus()
    End Sub

    Private Sub txtUsername_ModifiedChanged(sender As Object, e As EventArgs) Handles txtUsername.ModifiedChanged
        If Not Regex.IsMatch(txtUsername.Text, "^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$") Then
            MsgBox("Incorrect email format", MsgBoxStyle.Exclamation, "Sacco")
            txtUsername.Focus()
            txtUsername.Text = ""
        End If
    End Sub



    Private Sub txtEmail_ModifiedChanged(sender As Object, e As EventArgs) Handles txtEmail.ModifiedChanged
        If Not Regex.IsMatch(txtUsername.Text, "^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$") Then
            MsgBox("Incorrect email format", MsgBoxStyle.Exclamation, "Sacco")
            txtEmail.Focus()
            txtEmail.Text = ""
        End If
    End Sub
End Class
