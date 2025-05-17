<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.textbox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.textbox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.role = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'textbox1
        '
        Me.textbox1.BackColor = System.Drawing.Color.White
        Me.textbox1.Location = New System.Drawing.Point(85, 77)
        Me.textbox1.Name = "textbox1"
        Me.textbox1.Size = New System.Drawing.Size(276, 22)
        Me.textbox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(9, 128)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(67, 16)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Password"
        '
        'textbox2
        '
        Me.textbox2.BackColor = System.Drawing.Color.White
        Me.textbox2.Location = New System.Drawing.Point(81, 128)
        Me.textbox2.Name = "textbox2"
        Me.textbox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textbox2.Size = New System.Drawing.Size(280, 22)
        Me.textbox2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(150, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "User Login"
        Me.Label3.UseCompatibleTextRendering = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(12, 238)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 26)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(205, 238)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 26)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "User"
        '
        'role
        '
        Me.role.BackColor = System.Drawing.Color.White
        Me.role.FormattingEnabled = True
        Me.role.Items.AddRange(New Object() {"Admin", "Agent", "Manager"})
        Me.role.Location = New System.Drawing.Point(81, 183)
        Me.role.Name = "role"
        Me.role.Size = New System.Drawing.Size(280, 24)
        Me.role.TabIndex = 8
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button3.Location = New System.Drawing.Point(84, 283)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 27)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Sign Up"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.textbox1)
        Me.Panel1.Controls.Add(Me.label2)
        Me.Panel1.Controls.Add(Me.role)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.textbox2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(383, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(379, 346)
        Me.Panel1.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(115, 73)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(270, 346)
        Me.Panel2.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-33, -84)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(333, 430)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.LightCyan
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(198, 68)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.Color.Aqua
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(828, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = " Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents textbox1 As TextBox
    Friend WithEvents Label1 As Label
    Private label2 As Label
    Friend WithEvents Password As Label
    Friend WithEvents textbox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents role As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
