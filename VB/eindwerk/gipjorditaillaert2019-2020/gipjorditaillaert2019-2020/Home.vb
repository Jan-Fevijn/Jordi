Imports System.IO
Imports System.Data

Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Home
    Public Property naamPass As String
    Public Property datePass As String
    Dim muis As Boolean = False
    Dim toetsenbord As Boolean = False
    Dim dbDataSet As New DataTable

    Private Sub cbMuis_CheckedChanged(sender As Object, e As EventArgs) Handles cbMuis.CheckedChanged
        muis = Not muis
    End Sub

    Private Sub cbToetsenbord_CheckedChanged(sender As Object, e As EventArgs) Handles cbToetsenbord.CheckedChanged
        toetsenbord = Not toetsenbord
    End Sub

    Private Sub btnVerzenden_Click(sender As Object, e As EventArgs) Handles btnVerzenden.Click
        Dim connStr As String = "server=localhost;user=root;database=databasegip;port=3307;password=usbw;"
        Dim conn As New MySqlConnection(connStr)
        Dim reader As MySqlDataReader

        Try
            conn.Open()

            Dim command As New MySqlCommand("INSERT INTO overzicht(gebruikersnaam, muis, toetsenbord, datum) VALUES ('" & naamPass & "','" & muis & "','" & toetsenbord & "','" & datePass & "')", conn)
            reader = command.ExecuteReader

            MessageBox.Show("Alles is opgeslaan")
            conn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

        Me.Close()
        frmLogin.Close()
    End Sub
End Class