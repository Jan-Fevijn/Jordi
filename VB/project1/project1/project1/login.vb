Imports System.IO
Imports System.Data

Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class login

    Private Sub btnInloggen_Click(sender As Object, e As EventArgs) Handles btnInloggen.Click
        Dim connStr As String = "server=localhost;user=root;database=project1;port=3307;password=usbw;"
        Dim conn As New MySqlConnection(connStr)

        conn.Open()

        Dim command As New MySqlCommand("SELECT `idgebruiker`, `wachtwoord` FROM `gebruiker` WHERE `naam` = @username AND `wachtwoord` = @password", conn)

        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = txtNaam.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = txtWW.Text

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count = 0 Then

            MessageBox.Show("Naam en/of wachtwoord is fout")
            txtNaam.Text = ""
            txtWW.Text = ""

        Else

            MessageBox.Show("Logged In")

            Dim newForm As New Form1
            newForm.Show()
            Me.Hide()

        End If
    End Sub
End Class