Imports System.IO
Imports System.Data

Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class frmLogin

    Public Sub btnlogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim connStr As String = "server=localhost;user=root;database=databasegip;port=3307;password=usbw;"
        Dim conn As New MySqlConnection(connStr)
        Dim datum As String = createdate()

        conn.Open()

        Dim command As New MySqlCommand("SELECT `idleerlingen`, `wachtwoord` FROM `leerlingen` WHERE `gebruikersnaam` = @username AND `wachtwoord` = @password", conn)

        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = txtName.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = txtPassword.Text

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count = 0 Then

            MessageBox.Show("Naam en/of wachtwoord is fout")
            txtName.Text = ""
            txtPassword.Text = ""

        Else

            MessageBox.Show("U bent ingelogd")

            Dim wwForm As New nieuwwachtwoord
            wwForm.gebruikersnaamPass = txtName.Text
            wwForm.datumPass = datum
            wwForm.Show()
            Me.Hide()

        End If

    End Sub

    Private Function createdate() As String
        Dim y, m, d, h, min As String
        y = Me.DateTimePicker1.Value.Year.ToString()
        m = Me.DateTimePicker1.Value.Month.ToString()
        d = Me.DateTimePicker1.Value.Day.ToString()
        h = Me.DateTimePicker1.Value.Hour.ToString()
        min = Me.DateTimePicker1.Value.Minute.ToString()
        Return y & "/" & m & "/" & d & " " & h & ":" & min
    End Function
End Class