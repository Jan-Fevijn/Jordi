<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nieuwwachtwoord
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnOpslaan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNieuwwachtwoord = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBevestig = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnOpslaan
        '
        Me.btnOpslaan.Location = New System.Drawing.Point(209, 140)
        Me.btnOpslaan.Name = "btnOpslaan"
        Me.btnOpslaan.Size = New System.Drawing.Size(75, 23)
        Me.btnOpslaan.TabIndex = 0
        Me.btnOpslaan.Text = "Opslaan"
        Me.btnOpslaan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Vul hier uw nieuw wachtwoord in:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "nieuw wachtwoord: "
        '
        'txtNieuwwachtwoord
        '
        Me.txtNieuwwachtwoord.Location = New System.Drawing.Point(144, 58)
        Me.txtNieuwwachtwoord.Name = "txtNieuwwachtwoord"
        Me.txtNieuwwachtwoord.Size = New System.Drawing.Size(140, 20)
        Me.txtNieuwwachtwoord.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "bevestig wachtwoord: "
        '
        'txtBevestig
        '
        Me.txtBevestig.Location = New System.Drawing.Point(144, 99)
        Me.txtBevestig.Name = "txtBevestig"
        Me.txtBevestig.Size = New System.Drawing.Size(140, 20)
        Me.txtBevestig.TabIndex = 6
        '
        'nieuwwachtwoord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 175)
        Me.Controls.Add(Me.txtBevestig)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNieuwwachtwoord)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOpslaan)
        Me.Name = "nieuwwachtwoord"
        Me.Text = "nieuwwachtwoord"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOpslaan As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNieuwwachtwoord As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBevestig As TextBox
End Class
