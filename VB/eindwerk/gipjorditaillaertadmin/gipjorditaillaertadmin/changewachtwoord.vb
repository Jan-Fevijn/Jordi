Imports System.IO
Imports System.Data

Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class changewachtwoord
    Public Property gebruikersnaamPass As String
    Private Sub changewachtwoord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connStr As String = "server=localhost;user=root;database=databasegip;port=3307;password=usbw;"
        Dim conn As New MySqlConnection(connStr)

        conn.Open()

        If txtNieuwww.Text = txtBevestigww.Text Then

            Dim command As New MySqlCommand("UPDATE leerlingen SET Wachtwoord ='" & txtNieuwww.Text & "' where Gebruikersnaam = '" & txtGebruiker.Text & "'", conn)

            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()

            adapter.Fill(table)

            MessageBox.Show("De leerling heeft een nieuw wachtwoord")

        ElseIf txtNieuwww.Text <> txtBevestigww.Text Then
            MessageBox.Show("De wachtwoorden matchen niet, probeer nog eens")
            txtNieuwww.Text = ""
            txtBevestigww.Text = ""
        End If

    End Sub
End Class