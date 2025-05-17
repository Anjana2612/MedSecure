<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form14
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(156, 379)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(90, 23)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Back"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(292, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Prospectus List"
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(63, 355)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(654, 21)
        Me.HScrollBar1.TabIndex = 20
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(717, 53)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(21, 320)
        Me.VScrollBar1.TabIndex = 19
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(63, 53)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(675, 320)
        Me.RichTextBox1.TabIndex = 18
        Me.RichTextBox1.Text = ""
        '
        'Form14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "Form14"
        Me.Text = "Form14"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
