Imports System.Data.Common
Imports System.Data.OleDb
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

    Dim MpesaStatus As Boolean = False
    Private Sub conDB()

        conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SaccoDB.accdb"
        myconnection.ConnectionString = conString
        myconnection.Open()

    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        BunifuPage.SetPage(0)
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        BunifuPage.SetPage(1)
    End Sub



    Private Sub btnJoin_Click(sender As Object, e As EventArgs) Handles btnJoin.Click
        BunifuPage.SetPage(2)
    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        Call conDB()
        command = "INSERT into MembersDetails([FirstName],[MiddleName],[LastName],[DOB],[Gender],[PhoneNumber],[IDNo]) VALUES('" & txtFirstName.Text & "','" & txtMiddleName.Text & "','" & txtSurname.Text & "','" & txtDOB.Value & "','" & txtGender.Text & "','" & txtPhone.Text & "','" & txtID.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)

        cmd.Parameters.Add(New OleDbParameter("FirstName", CType(txtFirstName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MiddleName", CType(txtMiddleName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("LastName", CType(txtSurname.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("DOB", CType(txtDOB.Value, Date)))
        cmd.Parameters.Add(New OleDbParameter("Gender", CType(txtGender.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("PhoneNumber", CType(txtPhone.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("IDNo", CType(txtID.Text, String)))

        Try
            cmd
            'cmd.ExecuteNonQuery()
            'cmd.Dispose()
            'myconnection.Close()
            MessageBox.Show("Account Created Successfully")
            MainForm.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        MainForm.Show()
        Me.Hide()
    End Sub


    Private Sub btnMpesa_Click(sender As Object, e As EventArgs) Handles btnMpesa.Click
        MpesaStatus = True
    End Sub
End Class
