<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnUitvoeren = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBedrag = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbInkomsten = New System.Windows.Forms.RadioButton()
        Me.rbUitgaven = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cbOmschrijving = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotaal = New System.Windows.Forms.Label()
        Me.btnInlezen = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.dlopenFile = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'btnUitvoeren
        '
        Me.btnUitvoeren.Location = New System.Drawing.Point(16, 218)
        Me.btnUitvoeren.Name = "btnUitvoeren"
        Me.btnUitvoeren.Size = New System.Drawing.Size(97, 49)
        Me.btnUitvoeren.TabIndex = 1
        Me.btnUitvoeren.Text = "Uitvoeren"
        Me.btnUitvoeren.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bedrag :"
        '
        'txtBedrag
        '
        Me.txtBedrag.Location = New System.Drawing.Point(122, 97)
        Me.txtBedrag.Name = "txtBedrag"
        Me.txtBedrag.Size = New System.Drawing.Size(131, 20)
        Me.txtBedrag.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Omschrijving :"
        '
        'rbInkomsten
        '
        Me.rbInkomsten.AutoSize = True
        Me.rbInkomsten.Location = New System.Drawing.Point(12, 23)
        Me.rbInkomsten.Name = "rbInkomsten"
        Me.rbInkomsten.Size = New System.Drawing.Size(74, 17)
        Me.rbInkomsten.TabIndex = 6
        Me.rbInkomsten.TabStop = True
        Me.rbInkomsten.Text = "Inkomsten"
        Me.rbInkomsten.UseVisualStyleBackColor = True
        '
        'rbUitgaven
        '
        Me.rbUitgaven.AutoSize = True
        Me.rbUitgaven.Location = New System.Drawing.Point(138, 23)
        Me.rbUitgaven.Name = "rbUitgaven"
        Me.rbUitgaven.Size = New System.Drawing.Size(68, 17)
        Me.rbUitgaven.TabIndex = 7
        Me.rbUitgaven.TabStop = True
        Me.rbUitgaven.Text = "Uitgaven"
        Me.rbUitgaven.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-mm-dd"
        Me.DateTimePicker1.Location = New System.Drawing.Point(53, 56)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 8
        '
        'cbOmschrijving
        '
        Me.cbOmschrijving.FormattingEnabled = True
        Me.cbOmschrijving.Location = New System.Drawing.Point(122, 144)
        Me.cbOmschrijving.Name = "cbOmschrijving"
        Me.cbOmschrijving.Size = New System.Drawing.Size(131, 21)
        Me.cbOmschrijving.TabIndex = 9
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(166, 243)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 24)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(146, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Totaal :"
        '
        'lblTotaal
        '
        Me.lblTotaal.AutoSize = True
        Me.lblTotaal.Location = New System.Drawing.Point(214, 197)
        Me.lblTotaal.Name = "lblTotaal"
        Me.lblTotaal.Size = New System.Drawing.Size(16, 13)
        Me.lblTotaal.TabIndex = 12
        Me.lblTotaal.Text = "..."
        '
        'btnInlezen
        '
        Me.btnInlezen.Location = New System.Drawing.Point(16, 187)
        Me.btnInlezen.Name = "btnInlezen"
        Me.btnInlezen.Size = New System.Drawing.Size(97, 23)
        Me.btnInlezen.TabIndex = 13
        Me.btnInlezen.Text = "Inlezen"
        Me.btnInlezen.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(379, 187)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "testen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(273, 23)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(178, 147)
        Me.ListBox1.TabIndex = 15
        '
        'dlopenFile
        '
        Me.dlopenFile.FileName = "dlopenFile"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 279)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnInlezen)
        Me.Controls.Add(Me.lblTotaal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.cbOmschrijving)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.rbUitgaven)
        Me.Controls.Add(Me.rbInkomsten)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBedrag)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUitvoeren)
        Me.Name = "Form1"
        Me.Text = "Inkomsten/uitgaven"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUitvoeren As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBedrag As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents rbInkomsten As RadioButton
    Friend WithEvents rbUitgaven As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cbOmschrijving As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotaal As Label
    Friend WithEvents btnInlezen As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents dlopenFile As OpenFileDialog
End Class
