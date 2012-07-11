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
        Me.Bn1 = New System.Windows.Forms.Button
        Me.Tb1 = New System.Windows.Forms.TextBox
        Me.Tb2 = New System.Windows.Forms.TextBox
        Me.Tb3 = New System.Windows.Forms.TextBox
        Me.Tb4 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.Location = New System.Drawing.Point(78, 31)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(119, 20)
        Me.Lb1.TabIndex = 0
        Me.Lb1.Text = "VB Calculator"
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.Location = New System.Drawing.Point(58, 75)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(66, 13)
        Me.Lb2.TabIndex = 1
        Me.Lb2.Text = "First Number"
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.Location = New System.Drawing.Point(58, 121)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(48, 13)
        Me.Lb3.TabIndex = 2
        Me.Lb3.Text = "Operator"
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.Location = New System.Drawing.Point(58, 166)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(84, 13)
        Me.Lb4.TabIndex = 3
        Me.Lb4.Text = "Second Number"
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.Location = New System.Drawing.Point(69, 246)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(37, 13)
        Me.Lb5.TabIndex = 4
        Me.Lb5.Text = "Result"
        '
        'Bn1
        '
        Me.Bn1.Location = New System.Drawing.Point(101, 197)
        Me.Bn1.Name = "Bn1"
        Me.Bn1.Size = New System.Drawing.Size(114, 36)
        Me.Bn1.TabIndex = 5
        Me.Bn1.Text = "Go Calculate!"
        Me.Bn1.UseVisualStyleBackColor = True
        '
        'Tb1
        '
        Me.Tb1.Location = New System.Drawing.Point(167, 77)
        Me.Tb1.Name = "Tb1"
        Me.Tb1.Size = New System.Drawing.Size(100, 20)
        Me.Tb1.TabIndex = 6
        '
        'Tb2
        '
        Me.Tb2.Location = New System.Drawing.Point(167, 121)
        Me.Tb2.Name = "Tb2"
        Me.Tb2.Size = New System.Drawing.Size(100, 20)
        Me.Tb2.TabIndex = 7
        '
        'Tb3
        '
        Me.Tb3.Location = New System.Drawing.Point(167, 171)
        Me.Tb3.Name = "Tb3"
        Me.Tb3.Size = New System.Drawing.Size(100, 20)
        Me.Tb3.TabIndex = 8
        '
        'Tb4
        '
        Me.Tb4.Enabled = False
        Me.Tb4.Location = New System.Drawing.Point(167, 239)
        Me.Tb4.Name = "Tb4"
        Me.Tb4.Size = New System.Drawing.Size(100, 20)
        Me.Tb4.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 297)
        Me.Controls.Add(Me.Tb4)
        Me.Controls.Add(Me.Tb3)
        Me.Controls.Add(Me.Tb2)
        Me.Controls.Add(Me.Tb1)
        Me.Controls.Add(Me.Bn1)
        Me.Controls.Add(Me.Lb5)
        Me.Controls.Add(Me.Lb4)
        Me.Controls.Add(Me.Lb3)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.Lb1)
        Me.Name = "Form1"
        Me.Text = "VB Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lb1 As System.Windows.Forms.Label
    Friend WithEvents Lb2 As System.Windows.Forms.Label
    Friend WithEvents Lb3 As System.Windows.Forms.Label
    Friend WithEvents Lb4 As System.Windows.Forms.Label
    Friend WithEvents Lb5 As System.Windows.Forms.Label
    Friend WithEvents Bn1 As System.Windows.Forms.Button
    Friend WithEvents Tb1 As System.Windows.Forms.TextBox
    Friend WithEvents Tb2 As System.Windows.Forms.TextBox
    Friend WithEvents Tb3 As System.Windows.Forms.TextBox
    Friend WithEvents Tb4 As System.Windows.Forms.TextBox

End Class
