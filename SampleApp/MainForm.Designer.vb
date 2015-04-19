<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbRandom = New System.Windows.Forms.TextBox()
        Me.btnRandom = New System.Windows.Forms.Button()
        Me.btnMTRandom = New System.Windows.Forms.Button()
        Me.tbMTRandom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnGoRandom = New System.Windows.Forms.Button()
        Me.btnGoMTRandom = New System.Windows.Forms.Button()
        Me.lblRandomRes = New System.Windows.Forms.Label()
        Me.lblMTRandomRes = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Use Random class"
        '
        'tbRandom
        '
        Me.tbRandom.Location = New System.Drawing.Point(15, 32)
        Me.tbRandom.Multiline = True
        Me.tbRandom.Name = "tbRandom"
        Me.tbRandom.Size = New System.Drawing.Size(622, 46)
        Me.tbRandom.TabIndex = 1
        '
        'btnRandom
        '
        Me.btnRandom.Location = New System.Drawing.Point(643, 44)
        Me.btnRandom.Name = "btnRandom"
        Me.btnRandom.Size = New System.Drawing.Size(75, 23)
        Me.btnRandom.TabIndex = 2
        Me.btnRandom.Text = "Shuffle"
        Me.btnRandom.UseVisualStyleBackColor = True
        '
        'btnMTRandom
        '
        Me.btnMTRandom.Location = New System.Drawing.Point(640, 116)
        Me.btnMTRandom.Name = "btnMTRandom"
        Me.btnMTRandom.Size = New System.Drawing.Size(75, 23)
        Me.btnMTRandom.TabIndex = 5
        Me.btnMTRandom.Text = "Shuffle"
        Me.btnMTRandom.UseVisualStyleBackColor = True
        '
        'tbMTRandom
        '
        Me.tbMTRandom.Location = New System.Drawing.Point(12, 104)
        Me.tbMTRandom.Multiline = True
        Me.tbMTRandom.Name = "tbMTRandom"
        Me.tbMTRandom.Size = New System.Drawing.Size(622, 46)
        Me.tbMTRandom.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Use MTRandom class"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Perfomance, shuffle 100000 times using:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Random class"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "MTRandom class"
        '
        'btnGoRandom
        '
        Me.btnGoRandom.Location = New System.Drawing.Point(109, 191)
        Me.btnGoRandom.Name = "btnGoRandom"
        Me.btnGoRandom.Size = New System.Drawing.Size(47, 23)
        Me.btnGoRandom.TabIndex = 9
        Me.btnGoRandom.Text = "Go"
        Me.btnGoRandom.UseVisualStyleBackColor = True
        '
        'btnGoMTRandom
        '
        Me.btnGoMTRandom.Location = New System.Drawing.Point(109, 215)
        Me.btnGoMTRandom.Name = "btnGoMTRandom"
        Me.btnGoMTRandom.Size = New System.Drawing.Size(47, 23)
        Me.btnGoMTRandom.TabIndex = 10
        Me.btnGoMTRandom.Text = "Go"
        Me.btnGoMTRandom.UseVisualStyleBackColor = True
        '
        'lblRandomRes
        '
        Me.lblRandomRes.AutoSize = True
        Me.lblRandomRes.Location = New System.Drawing.Point(174, 196)
        Me.lblRandomRes.Name = "lblRandomRes"
        Me.lblRandomRes.Size = New System.Drawing.Size(0, 13)
        Me.lblRandomRes.TabIndex = 11
        '
        'lblMTRandomRes
        '
        Me.lblMTRandomRes.AutoSize = True
        Me.lblMTRandomRes.Location = New System.Drawing.Point(174, 220)
        Me.lblMTRandomRes.Name = "lblMTRandomRes"
        Me.lblMTRandomRes.Size = New System.Drawing.Size(0, 13)
        Me.lblMTRandomRes.TabIndex = 12
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 256)
        Me.Controls.Add(Me.lblMTRandomRes)
        Me.Controls.Add(Me.lblRandomRes)
        Me.Controls.Add(Me.btnGoMTRandom)
        Me.Controls.Add(Me.btnGoRandom)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnMTRandom)
        Me.Controls.Add(Me.tbMTRandom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnRandom)
        Me.Controls.Add(Me.tbRandom)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MainForm"
        Me.Text = "Sample randomizer application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbRandom As System.Windows.Forms.TextBox
    Friend WithEvents btnRandom As System.Windows.Forms.Button
    Friend WithEvents btnMTRandom As System.Windows.Forms.Button
    Friend WithEvents tbMTRandom As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnGoRandom As System.Windows.Forms.Button
    Friend WithEvents btnGoMTRandom As System.Windows.Forms.Button
    Friend WithEvents lblRandomRes As System.Windows.Forms.Label
    Friend WithEvents lblMTRandomRes As System.Windows.Forms.Label

End Class
