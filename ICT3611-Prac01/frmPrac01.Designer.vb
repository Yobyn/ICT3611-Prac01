<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prac01
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
        Me.btnDisplayMessage = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.btnDisplayAgeAsBinary = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDisplayMessage
        '
        Me.btnDisplayMessage.Location = New System.Drawing.Point(216, 52)
        Me.btnDisplayMessage.Name = "btnDisplayMessage"
        Me.btnDisplayMessage.Size = New System.Drawing.Size(117, 67)
        Me.btnDisplayMessage.TabIndex = 0
        Me.btnDisplayMessage.Text = "Display Greeting Message"
        Me.btnDisplayMessage.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NAME:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "AGE:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(89, 47)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(114, 20)
        Me.txtName.TabIndex = 3
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(89, 99)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(114, 20)
        Me.txtAge.TabIndex = 4
        '
        'btnDisplayAgeAsBinary
        '
        Me.btnDisplayAgeAsBinary.Location = New System.Drawing.Point(51, 145)
        Me.btnDisplayAgeAsBinary.Name = "btnDisplayAgeAsBinary"
        Me.btnDisplayAgeAsBinary.Size = New System.Drawing.Size(152, 28)
        Me.btnDisplayAgeAsBinary.TabIndex = 5
        Me.btnDisplayAgeAsBinary.Text = "Display Age in Binary"
        Me.btnDisplayAgeAsBinary.UseVisualStyleBackColor = True
        '
        'Prac01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 202)
        Me.Controls.Add(Me.btnDisplayAgeAsBinary)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDisplayMessage)
        Me.Name = "Prac01"
        Me.RightToLeftLayout = True
        Me.Text = "Prac01"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDisplayMessage As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents btnDisplayAgeAsBinary As System.Windows.Forms.Button

End Class
