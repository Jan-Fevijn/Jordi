Imports System.IO
Imports System.Data

Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub btnAanmelden_Click(sender As Object, e As EventArgs) Handles btnAanmelden.Click
        Dim connStr As String = "server=localhost;user=root;database=databasegip;port=3307;password=usbw;"
        Dim conn As New MySqlConnection(connStr)

        conn.Open()

        Dim command As New MySqlCommand("SELECT `idadmin`, `wachtwoord` FROM `admin` WHERE `gebruikersnaam` = @username AND `wachtwoord` = @password", conn)

        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = txtNaam.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = txtWachtwoord.Text

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count = 0 Then

            MessageBox.Show("Naam en/of wachtwoord is fout")
            txtNaam.Text = ""
            txtWachtwoord.Text = ""

        Else

            MessageBox.Show("Logged In")

            Dim wwForm As New changewachtwoord
            wwForm.gebruikersnaamPass = txtNaam.Text
            wwForm.Show()
            Me.Hide()

        End If

    End Sub
End Class
