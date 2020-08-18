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
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txtres = New System.Windows.Forms.TextBox()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnsub = New System.Windows.Forms.Button()
        Me.resetbtn = New System.Windows.Forms.Button()
        Me.exitbtn = New System.Windows.Forms.Button()
        Me.divbtn = New System.Windows.Forms.Button()
        Me.mulbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(192, 88)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(175, 22)
        Me.txt2.TabIndex = 0
        '
        'txtres
        '
        Me.txtres.Location = New System.Drawing.Point(192, 209)
        Me.txtres.Name = "txtres"
        Me.txtres.Size = New System.Drawing.Size(175, 22)
        Me.txtres.TabIndex = 1
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(192, 146)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(175, 22)
        Me.txt1.TabIndex = 2
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(0, 290)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(111, 23)
        Me.btnadd.TabIndex = 3
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnsub
        '
        Me.btnsub.Location = New System.Drawing.Point(278, 290)
        Me.btnsub.Name = "btnsub"
        Me.btnsub.Size = New System.Drawing.Size(111, 23)
        Me.btnsub.TabIndex = 4
        Me.btnsub.Text = "SUBSCTRACT"
        Me.btnsub.UseVisualStyleBackColor = True
        '
        'resetbtn
        '
        Me.resetbtn.Location = New System.Drawing.Point(0, 416)
        Me.resetbtn.Name = "resetbtn"
        Me.resetbtn.Size = New System.Drawing.Size(75, 37)
        Me.resetbtn.TabIndex = 5
        Me.resetbtn.Text = "RESET"
        Me.resetbtn.UseVisualStyleBackColor = True
        '
        'exitbtn
        '
        Me.exitbtn.Location = New System.Drawing.Point(343, 416)
        Me.exitbtn.Name = "exitbtn"
        Me.exitbtn.Size = New System.Drawing.Size(75, 37)
        Me.exitbtn.TabIndex = 6
        Me.exitbtn.Text = "EXIT"
        Me.exitbtn.UseVisualStyleBackColor = True
        '
        'divbtn
        '
        Me.divbtn.Location = New System.Drawing.Point(278, 350)
        Me.divbtn.Name = "divbtn"
        Me.divbtn.Size = New System.Drawing.Size(111, 23)
        Me.divbtn.TabIndex = 7
        Me.divbtn.Text = "DIVIDE"
        Me.divbtn.UseVisualStyleBackColor = True
        '
        'mulbtn
        '
        Me.mulbtn.Location = New System.Drawing.Point(0, 350)
        Me.mulbtn.Name = "mulbtn"
        Me.mulbtn.Size = New System.Drawing.Size(111, 23)
        Me.mulbtn.TabIndex = 8
        Me.mulbtn.Text = "MULTIPLY"
        Me.mulbtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-3, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ENTER 1ST NUMBER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-3, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "RESULT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-3, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "ENTER 2ND NUMBER"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mulbtn)
        Me.Controls.Add(Me.divbtn)
        Me.Controls.Add(Me.exitbtn)
        Me.Controls.Add(Me.resetbtn)
        Me.Controls.Add(Me.btnsub)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.txtres)
        Me.Controls.Add(Me.txt2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt2 As TextBox
    Friend WithEvents txtres As TextBox
    Friend WithEvents txt1 As TextBox
    Friend WithEvents btnadd As Button
    Friend WithEvents btnsub As Button
    Friend WithEvents resetbtn As Button
    Friend WithEvents exitbtn As Button
    Friend WithEvents divbtn As Button
    Friend WithEvents mulbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
