Imports System.IO
Imports System.Data

Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class nieuwwachtwoord
    Public Property gebruikersnaamPass As String
    Public Property datumPass As String

    Private Sub btnOpslaan_Click(sender As Object, e As EventArgs) Handles btnOpslaan.Click
        Dim connStr As String = "server=localhost;user=root;database=databasegip;port=3307;password=usbw;"
        Dim conn As New MySqlConnection(connStr)

        conn.Open()

        If txtNieuwwachtwoord.Text = txtBevestig.Text Then

            Dim command As New MySqlCommand("UPDATE leerlingen SET Wachtwoord ='" & txtNieuwwachtwoord.Text & "' where Gebruikersnaam = '" & gebruikersnaamPass & "'", conn)

            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()

            adapter.Fill(table)

            MessageBox.Show("U hebt een nieuw wachtwoord")

            Dim newForm As New Home
            newForm.datePass = datumPass
            newForm.naamPass = gebruikersnaamPass
            newForm.Show()
            Me.Hide()

        ElseIf txtNieuwwachtwoord.Text <> txtBevestig.Text Then
            MessageBox.Show("De wachtwoorden matchen niet, probeer nog eens")
            txtNieuwwachtwoord.Text = ""
            txtBevestig.Text = ""
        End If


    End Sub
End Class