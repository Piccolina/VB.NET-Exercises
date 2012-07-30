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
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.txtNewItem = New System.Windows.Forms.TextBox
        Me.BnAdd = New System.Windows.Forms.Button
        Me.btnRemoveSel = New System.Windows.Forms.Button
        Me.btnRemoveAll = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(25, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(163, 108)
        Me.ListBox1.TabIndex = 0
        '
        'txtNewItem
        '
        Me.txtNewItem.Location = New System.Drawing.Point(194, 12)
        Me.txtNewItem.Name = "txtNewItem"
        Me.txtNewItem.Size = New System.Drawing.Size(116, 20)
        Me.txtNewItem.TabIndex = 1
        '
        'BnAdd
        '
        Me.BnAdd.Location = New System.Drawing.Point(194, 38)
        Me.BnAdd.Name = "BnAdd"
        Me.BnAdd.Size = New System.Drawing.Size(92, 23)
        Me.BnAdd.TabIndex = 2
        Me.BnAdd.Text = "Add Item"
        Me.BnAdd.UseVisualStyleBackColor = True
        '
        'btnRemoveSel
        '
        Me.btnRemoveSel.Location = New System.Drawing.Point(194, 67)
        Me.btnRemoveSel.Name = "btnRemoveSel"
        Me.btnRemoveSel.Size = New System.Drawing.Size(92, 23)
        Me.btnRemoveSel.TabIndex = 3
        Me.btnRemoveSel.Text = "Remove Item"
        Me.btnRemoveSel.UseVisualStyleBackColor = True
        '
        'btnRemoveAll
        '
        Me.btnRemoveAll.Location = New System.Drawing.Point(194, 97)
        Me.btnRemoveAll.Name = "btnRemoveAll"
        Me.btnRemoveAll.Size = New System.Drawing.Size(92, 23)
        Me.btnRemoveAll.TabIndex = 4
        Me.btnRemoveAll.Text = "Delete All"
        Me.btnRemoveAll.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 161)
        Me.Controls.Add(Me.btnRemoveAll)
        Me.Controls.Add(Me.btnRemoveSel)
        Me.Controls.Add(Me.BnAdd)
        Me.Controls.Add(Me.txtNewItem)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents txtNewItem As System.Windows.Forms.TextBox
    Friend WithEvents BnAdd As System.Windows.Forms.Button
    Friend WithEvents btnRemoveSel As System.Windows.Forms.Button
    Friend WithEvents btnRemoveAll As System.Windows.Forms.Button

End Class
