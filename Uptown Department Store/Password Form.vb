Imports System.Data.OleDb
Public Class PasswordEntry
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles PasswordField.TextChanged

    End Sub

    Private Sub PasswordOK_Click(sender As System.Object, e As System.EventArgs) Handles PasswordOK.Click
        provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source ="
        'Change the following to your access database location
        dataFile = "M:\Dropbox\School\UNR\Year 2\IS 350\userAccounts.mdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()

        'the query:
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [users] WHERE [username] = '" & PasswordEmployee.Text & "' AND [password] = '" & PasswordField.Text & "'", myConnection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found
        Dim userFound As Boolean = False
        ' the following variables will hold the user first and last name if found.
        Dim FirstName As String = ""
        Dim LastName As String = ""
        Dim UserClass As String = ""

        'if found:
        While dr.Read
            userFound = True
            FirstName = dr("FirstName").ToString
            LastName = dr("LastName").ToString
            UserClass = dr("UserClass").ToString
        End While

        'checking the result
        If userFound = True Then
            MainMenu.Show()
            MsgBox("Welcome " & UserClass & " " & FirstName & " " & LastName)
        Else
            MsgBox("Sorry, username or password not found", MsgBoxStyle.OkOnly, "Invalid Login")
        End If
        myConnection.Close()
    End Sub

    Private Sub PasswordCancel_Click(sender As Object, e As EventArgs) Handles PasswordCancel.Click
        Close()
    End Sub
End Class
