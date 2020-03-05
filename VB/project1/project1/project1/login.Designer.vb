<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.txtWW = New System.Windows.Forms.TextBox()
        Me.btnInloggen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "naam"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ww"
        '
        'txtNaam
        '
        Me.txtNaam.Location = New System.Drawing.Point(87, 37)
        Me.txtNaam.Name = "txtNaam"
        Me.txtNaam.Size = New System.Drawing.Size(100, 20)
        Me.txtNaam.TabIndex = 2
        '
        'txtWW
        '
        Me.txtWW.Location = New System.Drawing.Point(87, 80)
        Me.txtWW.Name = "txtWW"
        Me.txtWW.Size = New System.Drawing.Size(100, 20)
        Me.txtWW.TabIndex = 3
        '
        'btnInloggen
        '
        Me.btnInloggen.Location = New System.Drawing.Point(112, 129)
        Me.btnInloggen.Name = "btnInloggen"
        Me.btnInloggen.Size = New System.Drawing.Size(75, 23)
        Me.btnInloggen.TabIndex = 4
        Me.btnInloggen.Text = "Log in"
        Me.btnInloggen.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(213, 184)
        Me.Controls.Add(Me.btnInloggen)
        Me.Controls.Add(Me.txtWW)
        Me.Controls.Add(Me.txtNaam)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "login"
        Me.Text = "login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNaam As TextBox
    Friend WithEvents txtWW As TextBox
    Friend WithEvents btnInloggen As Button
End Class
