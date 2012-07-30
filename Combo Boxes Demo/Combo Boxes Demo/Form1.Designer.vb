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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.BtnRemoveSel = New System.Windows.Forms.Button
        Me.BtnRemoveAll = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNewItem = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 30)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(142, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(184, 60)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(81, 23)
        Me.BtnAdd.TabIndex = 1
        Me.BtnAdd.Text = "Add Item"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnRemoveSel
        '
        Me.BtnRemoveSel.Location = New System.Drawing.Point(184, 89)
        Me.BtnRemoveSel.Name = "BtnRemoveSel"
        Me.BtnRemoveSel.Size = New System.Drawing.Size(81, 23)
        Me.BtnRemoveSel.TabIndex = 2
        Me.BtnRemoveSel.Text = "Remove Item"
        Me.BtnRemoveSel.UseVisualStyleBackColor = True
        '
        'BtnRemoveAll
        '
        Me.BtnRemoveAll.Location = New System.Drawing.Point(184, 118)
        Me.BtnRemoveAll.Name = "BtnRemoveAll"
        Me.BtnRemoveAll.Size = New System.Drawing.Size(81, 23)
        Me.BtnRemoveAll.TabIndex = 3
        Me.BtnRemoveAll.Text = "Delete All"
        Me.BtnRemoveAll.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(162, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter a new item"
        '
        'txtNewItem
        '
        Me.txtNewItem.Location = New System.Drawing.Point(165, 31)
        Me.txtNewItem.Name = "txtNewItem"
        Me.txtNewItem.Size = New System.Drawing.Size(100, 20)
        Me.txtNewItem.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 180)
        Me.Controls.Add(Me.txtNewItem)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnRemoveAll)
        Me.Controls.Add(Me.BtnRemoveSel)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Form1"
        Me.Text = "Combo Boxes Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnRemoveSel As System.Windows.Forms.Button
    Friend WithEvents BtnRemoveAll As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNewItem As System.Windows.Forms.TextBox

End Class
