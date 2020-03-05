Imports System.IO
Imports System.Data

Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim connStr As String = "server=localhost;user=root;database=project1;port=3307;password=usbw;"
    Dim conn As New MySqlConnection(connStr)
    Dim reader As MySqlDataReader
    Dim totaal As Integer = "999"
    Dim bedrag As Integer
    Dim lijstinuitgaven As New List(Of berekening)
    Private splitlijn() As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbInkomsten.Enabled = True
        rbUitgaven.Enabled = True
        lblTotaal.Text = totaal

        conn.Open()

        Dim cmd = New MySqlCommand("select IDtypeIO, inputoutput, code, omschrijving from typeio", conn)
        reader = cmd.ExecuteReader
        cbOmschrijving.Items.Clear()
        Do While reader.Read()
            cbOmschrijving.Items.Add(reader.GetString(2))
        Loop

        conn.Close()

    End Sub

    Private Sub rbInkomsten_CheckedChanged(sender As Object, e As EventArgs) Handles rbInkomsten.CheckedChanged
        rbUitgaven.Enabled = False
    End Sub

    Private Sub rbUitgaven_CheckedChanged(sender As Object, e As EventArgs) Handles rbUitgaven.CheckedChanged
        rbInkomsten.Enabled = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnUitvoeren_Click(sender As Object, e As EventArgs) Handles btnUitvoeren.Click
        Dim inout = cbOmschrijving.SelectedIndex + 1
        Dim datum As String = DateTimePicker1.Value.ToString("yyyy/M/dd")
        bedrag = txtBedrag.Text

        If txtBedrag.Text = "" Then

            MessageBox.Show("Er is geen bedrag ingegeven!!!")

        Else

            If rbInkomsten.Checked Then
                Try
                    conn.Open()

                    Dim command As New MySqlCommand("INSERT INTO verichting(IDtypeIO, datum, bedrag) VALUES ('" & inout & "','" & datum & "','" & txtBedrag.Text & "')", conn)
                    reader = command.ExecuteReader
                    lijstinuitgaven.Add(New berekening("+", txtBedrag.Text, inout, datum))

                    MessageBox.Show("Alles is opgeslaan")
                    conn.Close()

                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                Finally
                    conn.Dispose()
                End Try
                rbUitgaven.Enabled = True
                rbInkomsten.Enabled = True
                totaal = totaal + bedrag
                lblTotaal.Text = totaal

            ElseIf rbUitgaven.Checked Then
                Try
                    conn.Open()

                    Dim command As New MySqlCommand("INSERT INTO verichting(IDtypeIO, datum, bedrag) VALUES ('" & inout & "','" & datum & "','" & txtBedrag.Text & "')", conn)
                    reader = command.ExecuteReader
                    lijstinuitgaven.Add(New berekening("-", txtBedrag.Text, inout, datum))

                    MessageBox.Show("Alles is opgeslaan")
                    conn.Close()

                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                Finally
                    conn.Dispose()
                End Try
                rbInkomsten.Enabled = True
                rbUitgaven.Enabled = True
                totaal = totaal - bedrag
                lblTotaal.Text = totaal
            End If

        End If



    End Sub

    Private Sub btnInlezen_Click(sender As Object, e As EventArgs) Handles btnInlezen.Click
        With dlopenFile
            .InitialDirectory = "C:\Users\jordi.taillaert\source\repos\project1\bestanden"
        End With

        If (dlopenFile.ShowDialog = DialogResult.OK) Then

            FileOpen(1, dlopenFile.FileName, OpenMode.Input)

            Do While Not EOF(1)
                Dim lijn = LineInput(1)
                splitlijn = Split(lijn, ",")
                lijstinuitgaven.Add(New berekening(splitlijn(0), splitlijn(1), splitlijn(2), splitlijn(3)))
            Loop

            FileClose(1)

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()

        For Each berekening In lijstinuitgaven
            ListBox1.Items.Add(berekening)
        Next

    End Sub

End Class
