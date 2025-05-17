<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form15
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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(156, 403)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(90, 23)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Back"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(762, 50)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(26, 347)
        Me.VScrollBar1.TabIndex = 21
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(12, 373)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(776, 24)
        Me.HScrollBar1.TabIndex = 20
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 50)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(776, 347)
        Me.RichTextBox1.TabIndex = 19
        Me.RichTextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(325, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 23)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Base Premium"
        '
        'Form15
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form15"
        Me.Text = "Form15"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
End Class
