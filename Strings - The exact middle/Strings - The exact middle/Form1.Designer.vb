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
        Me.Tb1 = New System.Windows.Forms.TextBox
        Me.Bn1 = New System.Windows.Forms.Button
        Me.Tb2 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Tb1
        '
        Me.Tb1.Location = New System.Drawing.Point(12, 12)
        Me.Tb1.Name = "Tb1"
        Me.Tb1.Size = New System.Drawing.Size(195, 20)
        Me.Tb1.TabIndex = 0
        '
        'Bn1
        '
        Me.Bn1.Location = New System.Drawing.Point(42, 99)
        Me.Bn1.Name = "Bn1"
        Me.Bn1.Size = New System.Drawing.Size(134, 23)
        Me.Bn1.TabIndex = 1
        Me.Bn1.Text = "Find Middle"
        Me.Bn1.UseVisualStyleBackColor = True
        '
        'Tb2
        '
        Me.Tb2.Enabled = False
        Me.Tb2.Location = New System.Drawing.Point(12, 53)
        Me.Tb2.Name = "Tb2"
        Me.Tb2.Size = New System.Drawing.Size(195, 20)
        Me.Tb2.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(219, 146)
        Me.Controls.Add(Me.Tb2)
        Me.Controls.Add(Me.Bn1)
        Me.Controls.Add(Me.Tb1)
        Me.Name = "Form1"
        Me.Text = "Exact Middle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tb1 As System.Windows.Forms.TextBox
    Friend WithEvents Bn1 As System.Windows.Forms.Button
    Friend WithEvents Tb2 As System.Windows.Forms.TextBox

End Class
