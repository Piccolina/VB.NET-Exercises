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
        Me.Lb1 = New System.Windows.Forms.Label
        Me.Lb2 = New System.Windows.Forms.Label
        Me.Lb3 = New System.Windows.Forms.Label
        Me.Lb4 = New System.Windows.Forms.Label
        Me.Lb5 = New System.Windows.Forms.Label
        Me.Lb6 = New System.Windows.Forms.Label
        Me.Tb1 = New System.Windows.Forms.TextBox
        Me.Tb2 = New System.Windows.Forms.TextBox
        Me.Tb3 = New System.Windows.Forms.TextBox
        Me.Tb4 = New System.Windows.Forms.TextBox
        Me.Tb5 = New System.Windows.Forms.TextBox
        Me.Tb6 = New System.Windows.Forms.TextBox
        Me.Bn1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.Location = New System.Drawing.Point(16, 39)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(69, 13)
        Me.Lb1.TabIndex = 0
        Me.Lb1.Text = "Enter a string"
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.Location = New System.Drawing.Point(16, 98)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(84, 13)
        Me.Lb2.TabIndex = 1
        Me.Lb2.Text = "First Five Letters"
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.Location = New System.Drawing.Point(16, 125)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(93, 13)
        Me.Lb3.TabIndex = 2
        Me.Lb3.Text = "Last Three Letters"
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.Location = New System.Drawing.Point(16, 151)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(77, 13)
        Me.Lb4.TabIndex = 3
        Me.Lb4.Text = "Any Six Letters"
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.Location = New System.Drawing.Point(16, 178)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(74, 13)
        Me.Lb5.TabIndex = 4
        Me.Lb5.Text = "Capital Letters"
        '
        'Lb6
        '
        Me.Lb6.AutoSize = True
        Me.Lb6.Location = New System.Drawing.Point(16, 207)
        Me.Lb6.Name = "Lb6"
        Me.Lb6.Size = New System.Drawing.Size(67, 13)
        Me.Lb6.TabIndex = 5
        Me.Lb6.Text = "Small Letters"
        '
        'Tb1
        '
        Me.Tb1.Location = New System.Drawing.Point(133, 37)
        Me.Tb1.Name = "Tb1"
        Me.Tb1.Size = New System.Drawing.Size(117, 20)
        Me.Tb1.TabIndex = 6
        '
        'Tb2
        '
        Me.Tb2.Enabled = False
        Me.Tb2.Location = New System.Drawing.Point(133, 95)
        Me.Tb2.Name = "Tb2"
        Me.Tb2.Size = New System.Drawing.Size(117, 20)
        Me.Tb2.TabIndex = 7
        '
        'Tb3
        '
        Me.Tb3.Enabled = False
        Me.Tb3.Location = New System.Drawing.Point(133, 122)
        Me.Tb3.Name = "Tb3"
        Me.Tb3.Size = New System.Drawing.Size(117, 20)
        Me.Tb3.TabIndex = 8
        '
        'Tb4
        '
        Me.Tb4.Enabled = False
        Me.Tb4.Location = New System.Drawing.Point(133, 151)
        Me.Tb4.Name = "Tb4"
        Me.Tb4.Size = New System.Drawing.Size(117, 20)
        Me.Tb4.TabIndex = 9
        '
        'Tb5
        '
        Me.Tb5.Enabled = False
        Me.Tb5.Location = New System.Drawing.Point(133, 177)
        Me.Tb5.Name = "Tb5"
        Me.Tb5.Size = New System.Drawing.Size(117, 20)
        Me.Tb5.TabIndex = 10
        '
        'Tb6
        '
        Me.Tb6.Enabled = False
        Me.Tb6.Location = New System.Drawing.Point(133, 204)
        Me.Tb6.Name = "Tb6"
        Me.Tb6.Size = New System.Drawing.Size(117, 20)
        Me.Tb6.TabIndex = 11
        '
        'Bn1
        '
        Me.Bn1.Location = New System.Drawing.Point(74, 63)
        Me.Bn1.Name = "Bn1"
        Me.Bn1.Size = New System.Drawing.Size(125, 23)
        Me.Bn1.TabIndex = 12
        Me.Bn1.Text = "Display Answers"
        Me.Bn1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 266)
        Me.Controls.Add(Me.Bn1)
        Me.Controls.Add(Me.Tb6)
        Me.Controls.Add(Me.Tb5)
        Me.Controls.Add(Me.Tb4)
        Me.Controls.Add(Me.Tb3)
        Me.Controls.Add(Me.Tb2)
        Me.Controls.Add(Me.Tb1)
        Me.Controls.Add(Me.Lb6)
        Me.Controls.Add(Me.Lb5)
        Me.Controls.Add(Me.Lb4)
        Me.Controls.Add(Me.Lb3)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.Lb1)
        Me.Name = "Form1"
        Me.Text = "String Functions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lb1 As System.Windows.Forms.Label
    Friend WithEvents Lb2 As System.Windows.Forms.Label
    Friend WithEvents Lb3 As System.Windows.Forms.Label
    Friend WithEvents Lb4 As System.Windows.Forms.Label
    Friend WithEvents Lb5 As System.Windows.Forms.Label
    Friend WithEvents Lb6 As System.Windows.Forms.Label
    Friend WithEvents Tb1 As System.Windows.Forms.TextBox
    Friend WithEvents Tb2 As System.Windows.Forms.TextBox
    Friend WithEvents Tb3 As System.Windows.Forms.TextBox
    Friend WithEvents Tb4 As System.Windows.Forms.TextBox
    Friend WithEvents Tb5 As System.Windows.Forms.TextBox
    Friend WithEvents Tb6 As System.Windows.Forms.TextBox
    Friend WithEvents Bn1 As System.Windows.Forms.Button

End Class
