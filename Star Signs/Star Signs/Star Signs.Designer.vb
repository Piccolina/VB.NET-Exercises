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
        Me.Bn1 = New System.Windows.Forms.Button
        Me.Lb1 = New System.Windows.Forms.Label
        Me.Lb2 = New System.Windows.Forms.Label
        Me.Tb1 = New System.Windows.Forms.TextBox
        Me.Tb2 = New System.Windows.Forms.TextBox
        Me.Pb1 = New System.Windows.Forms.PictureBox
        CType(Me.Pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bn1
        '
        Me.Bn1.Location = New System.Drawing.Point(75, 102)
        Me.Bn1.Name = "Bn1"
        Me.Bn1.Size = New System.Drawing.Size(147, 23)
        Me.Bn1.TabIndex = 0
        Me.Bn1.Text = "Get my prediction"
        Me.Bn1.UseVisualStyleBackColor = True
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.Location = New System.Drawing.Point(105, 19)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(93, 20)
        Me.Lb1.TabIndex = 1
        Me.Lb1.Text = "Star Signs"
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.Location = New System.Drawing.Point(95, 48)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(103, 13)
        Me.Lb2.TabIndex = 2
        Me.Lb2.Text = "Enter Your Star Sign"
        '
        'Tb1
        '
        Me.Tb1.Location = New System.Drawing.Point(75, 64)
        Me.Tb1.Name = "Tb1"
        Me.Tb1.Size = New System.Drawing.Size(147, 20)
        Me.Tb1.TabIndex = 3
        '
        'Tb2
        '
        Me.Tb2.Location = New System.Drawing.Point(12, 131)
        Me.Tb2.Multiline = True
        Me.Tb2.Name = "Tb2"
        Me.Tb2.Size = New System.Drawing.Size(152, 109)
        Me.Tb2.TabIndex = 4
        '
        'Pb1
        '
        Me.Pb1.Location = New System.Drawing.Point(170, 131)
        Me.Pb1.Name = "Pb1"
        Me.Pb1.Size = New System.Drawing.Size(100, 109)
        Me.Pb1.TabIndex = 5
        Me.Pb1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 263)
        Me.Controls.Add(Me.Pb1)
        Me.Controls.Add(Me.Tb2)
        Me.Controls.Add(Me.Tb1)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me.Bn1)
        Me.Name = "Form1"
        Me.Text = "Star Signs"
        CType(Me.Pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bn1 As System.Windows.Forms.Button
    Friend WithEvents Lb1 As System.Windows.Forms.Label
    Friend WithEvents Lb2 As System.Windows.Forms.Label
    Friend WithEvents Tb1 As System.Windows.Forms.TextBox
    Friend WithEvents Tb2 As System.Windows.Forms.TextBox
    Friend WithEvents Pb1 As System.Windows.Forms.PictureBox

End Class
