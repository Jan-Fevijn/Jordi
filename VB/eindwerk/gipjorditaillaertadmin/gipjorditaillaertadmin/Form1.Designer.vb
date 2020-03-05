<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtNaam = New System.Windows.Forms.TextBox()
        Me.txtWachtwoord = New System.Windows.Forms.TextBox()
        Me.btnAanmelden = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Naam admin:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Wachtwoord"
        '
        'txtNaam
        '
        Me.txtNaam.Location = New System.Drawing.Point(152, 64)
        Me.txtNaam.Name = "txtNaam"
        Me.txtNaam.Size = New System.Drawing.Size(100, 20)
        Me.txtNaam.TabIndex = 2
        '
        'txtWachtwoord
        '
        Me.txtWachtwoord.Location = New System.Drawing.Point(152, 120)
        Me.txtWachtwoord.Name = "txtWachtwoord"
        Me.txtWachtwoord.Size = New System.Drawing.Size(100, 20)
        Me.txtWachtwoord.TabIndex = 3
        '
        'btnAanmelden
        '
        Me.btnAanmelden.Location = New System.Drawing.Point(177, 165)
        Me.btnAanmelden.Name = "btnAanmelden"
        Me.btnAanmelden.Size = New System.Drawing.Size(75, 23)
        Me.btnAanmelden.TabIndex = 4
        Me.btnAanmelden.Text = "Aanmelden"
        Me.btnAanmelden.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(298, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Deze pagina is alleen voor de admin"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 220)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAanmelden)
        Me.Controls.Add(Me.txtWachtwoord)
        Me.Controls.Add(Me.txtNaam)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Inlog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNaam As TextBox
    Friend WithEvents txtWachtwoord As TextBox
    Friend WithEvents btnAanmelden As Button
    Friend WithEvents Label3 As Label
End Class
