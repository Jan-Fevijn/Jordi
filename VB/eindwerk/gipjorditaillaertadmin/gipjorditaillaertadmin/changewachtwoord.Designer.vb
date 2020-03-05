<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changewachtwoord
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGebruiker = New System.Windows.Forms.TextBox()
        Me.txtNieuwww = New System.Windows.Forms.TextBox()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBevestigww = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Naam gebruiker:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "nieuw wachtwoord"
        '
        'txtGebruiker
        '
        Me.txtGebruiker.Location = New System.Drawing.Point(152, 57)
        Me.txtGebruiker.Name = "txtGebruiker"
        Me.txtGebruiker.Size = New System.Drawing.Size(100, 20)
        Me.txtGebruiker.TabIndex = 2
        '
        'txtNieuwww
        '
        Me.txtNieuwww.Location = New System.Drawing.Point(152, 98)
        Me.txtNieuwww.Name = "txtNieuwww"
        Me.txtNieuwww.Size = New System.Drawing.Size(100, 20)
        Me.txtNieuwww.TabIndex = 3
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(135, 186)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(117, 30)
        Me.btnChange.TabIndex = 4
        Me.btnChange.Text = "Change wachtwoord"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(268, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Change wachtwoord v/e gebruiker:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "bevestig wachtwoord"
        '
        'txtBevestigww
        '
        Me.txtBevestigww.Location = New System.Drawing.Point(152, 140)
        Me.txtBevestigww.Name = "txtBevestigww"
        Me.txtBevestigww.Size = New System.Drawing.Size(100, 20)
        Me.txtBevestigww.TabIndex = 7
        '
        'changewachtwoord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 248)
        Me.Controls.Add(Me.txtBevestigww)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.txtNieuwww)
        Me.Controls.Add(Me.txtGebruiker)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "changewachtwoord"
        Me.Text = "changewachtwoord"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGebruiker As TextBox
    Friend WithEvents txtNieuwww As TextBox
    Friend WithEvents btnChange As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBevestigww As TextBox
End Class
