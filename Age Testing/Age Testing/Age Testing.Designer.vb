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
        Me.Tb1 = New System.Windows.Forms.TextBox
        Me.Tb2 = New System.Windows.Forms.TextBox
        Me.Bn1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.Location = New System.Drawing.Point(84, 28)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(127, 25)
        Me.Lb1.TabIndex = 0
        Me.Lb1.Text = "Age Tester"
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb2.Location = New System.Drawing.Point(78, 74)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(98, 16)
        Me.Lb2.TabIndex = 1
        Me.Lb2.Text = "Enter Your Age"
        '
        'Tb1
        '
        Me.Tb1.Location = New System.Drawing.Point(182, 73)
        Me.Tb1.Name = "Tb1"
        Me.Tb1.Size = New System.Drawing.Size(80, 20)
        Me.Tb1.TabIndex = 2
        '
        'Tb2
        '
        Me.Tb2.Enabled = False
        Me.Tb2.Location = New System.Drawing.Point(81, 160)
        Me.Tb2.Name = "Tb2"
        Me.Tb2.Size = New System.Drawing.Size(181, 20)
        Me.Tb2.TabIndex = 3
        '
        'Bn1
        '
        Me.Bn1.Location = New System.Drawing.Point(81, 110)
        Me.Bn1.Name = "Bn1"
        Me.Bn1.Size = New System.Drawing.Size(181, 32)
        Me.Bn1.TabIndex = 4
        Me.Bn1.Text = "Get My  Message"
        Me.Bn1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 230)
        Me.Controls.Add(Me.Bn1)
        Me.Controls.Add(Me.Tb2)
        Me.Controls.Add(Me.Tb1)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.Lb1)
        Me.Name = "Form1"
        Me.Text = "Age Program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lb1 As System.Windows.Forms.Label
    Friend WithEvents Lb2 As System.Windows.Forms.Label
    Friend WithEvents Tb1 As System.Windows.Forms.TextBox
    Friend WithEvents Tb2 As System.Windows.Forms.TextBox
    Friend WithEvents Bn1 As System.Windows.Forms.Button

End Class
