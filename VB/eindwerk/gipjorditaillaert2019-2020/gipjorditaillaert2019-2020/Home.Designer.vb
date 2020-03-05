<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Me.btnVerzenden = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbToetsenbord = New System.Windows.Forms.CheckBox()
        Me.cbMuis = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVerzenden
        '
        Me.btnVerzenden.Location = New System.Drawing.Point(37, 114)
        Me.btnVerzenden.Name = "btnVerzenden"
        Me.btnVerzenden.Size = New System.Drawing.Size(126, 30)
        Me.btnVerzenden.TabIndex = 2
        Me.btnVerzenden.Text = "Verzenden"
        Me.btnVerzenden.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbToetsenbord)
        Me.GroupBox1.Controls.Add(Me.cbMuis)
        Me.GroupBox1.Controls.Add(Me.btnVerzenden)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(196, 159)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Check-up"
        '
        'cbToetsenbord
        '
        Me.cbToetsenbord.AutoSize = True
        Me.cbToetsenbord.Location = New System.Drawing.Point(6, 74)
        Me.cbToetsenbord.Name = "cbToetsenbord"
        Me.cbToetsenbord.Size = New System.Drawing.Size(86, 17)
        Me.cbToetsenbord.TabIndex = 4
        Me.cbToetsenbord.Text = "Toetsenbord"
        Me.cbToetsenbord.UseVisualStyleBackColor = True
        '
        'cbMuis
        '
        Me.cbMuis.AutoSize = True
        Me.cbMuis.Location = New System.Drawing.Point(6, 40)
        Me.cbMuis.Name = "cbMuis"
        Me.cbMuis.Size = New System.Drawing.Size(48, 17)
        Me.cbMuis.TabIndex = 3
        Me.cbMuis.Text = "Muis"
        Me.cbMuis.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(251, 201)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVerzenden As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbToetsenbord As CheckBox
    Friend WithEvents cbMuis As CheckBox
End Class
