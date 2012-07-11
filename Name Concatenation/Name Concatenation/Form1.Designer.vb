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
        Me.bn1 = New System.Windows.Forms.Button
        Me.Tb1 = New System.Windows.Forms.TextBox
        Me.Tb2 = New System.Windows.Forms.TextBox
        Me.Tb3 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.Location = New System.Drawing.Point(59, 39)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(57, 13)
        Me.Lb1.TabIndex = 0
        Me.Lb1.Text = "First Name"
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.Location = New System.Drawing.Point(41, 81)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(75, 13)
        Me.Lb2.TabIndex = 1
        Me.Lb2.Text = "Second Name"
        '
        'bn1
        '
        Me.bn1.Location = New System.Drawing.Point(103, 104)
        Me.bn1.Name = "bn1"
        Me.bn1.Size = New System.Drawing.Size(75, 23)
        Me.bn1.TabIndex = 2
        Me.bn1.Text = "Enter"
        Me.bn1.UseVisualStyleBackColor = True
        '
        'Tb1
        '
        Me.Tb1.Location = New System.Drawing.Point(166, 36)
        Me.Tb1.Name = "Tb1"
        Me.Tb1.Size = New System.Drawing.Size(100, 20)
        Me.Tb1.TabIndex = 3
        '
        'Tb2
        '
        Me.Tb2.Location = New System.Drawing.Point(166, 78)
        Me.Tb2.Name = "Tb2"
        Me.Tb2.Size = New System.Drawing.Size(100, 20)
        Me.Tb2.TabIndex = 4
        '
        'Tb3
        '
        Me.Tb3.Location = New System.Drawing.Point(44, 145)
        Me.Tb3.Name = "Tb3"
        Me.Tb3.Size = New System.Drawing.Size(222, 20)
        Me.Tb3.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 202)
        Me.Controls.Add(Me.Tb3)
        Me.Controls.Add(Me.Tb2)
        Me.Controls.Add(Me.Tb1)
        Me.Controls.Add(Me.bn1)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.Lb1)
        Me.Name = "Form1"
        Me.Text = "Name Program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lb1 As System.Windows.Forms.Label
    Friend WithEvents Lb2 As System.Windows.Forms.Label
    Friend WithEvents bn1 As System.Windows.Forms.Button
    Friend WithEvents Tb1 As System.Windows.Forms.TextBox
    Friend WithEvents Tb2 As System.Windows.Forms.TextBox
    Friend WithEvents Tb3 As System.Windows.Forms.TextBox

End Class
