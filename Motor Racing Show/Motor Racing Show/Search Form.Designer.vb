<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search_Form
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
        Me.SearchTextBox1 = New System.Windows.Forms.TextBox()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.BtnSearchExit = New System.Windows.Forms.Button()
        Me.NOT_FOUD = New System.Windows.Forms.PictureBox()
        Me.Found = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Result = New System.Windows.Forms.Label()
        CType(Me.NOT_FOUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Found, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchTextBox1
        '
        Me.SearchTextBox1.Location = New System.Drawing.Point(47, 12)
        Me.SearchTextBox1.Name = "SearchTextBox1"
        Me.SearchTextBox1.Size = New System.Drawing.Size(287, 20)
        Me.SearchTextBox1.TabIndex = 1
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(47, 87)
        Me.SearchTextBox.Multiline = True
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(423, 262)
        Me.SearchTextBox.TabIndex = 2
        '
        'BtnSearchExit
        '
        Me.BtnSearchExit.Location = New System.Drawing.Point(395, 366)
        Me.BtnSearchExit.Name = "BtnSearchExit"
        Me.BtnSearchExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnSearchExit.TabIndex = 6
        Me.BtnSearchExit.Text = "Exit"
        Me.BtnSearchExit.UseVisualStyleBackColor = True
        '
        'NOT_FOUD
        '
        Me.NOT_FOUD.Image = Global.Motor_Racing_Show.My.Resources.Resources.download
        Me.NOT_FOUD.Location = New System.Drawing.Point(376, 12)
        Me.NOT_FOUD.Name = "NOT_FOUD"
        Me.NOT_FOUD.Size = New System.Drawing.Size(94, 69)
        Me.NOT_FOUD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.NOT_FOUD.TabIndex = 4
        Me.NOT_FOUD.TabStop = False
        '
        'Found
        '
        Me.Found.Image = Global.Motor_Racing_Show.My.Resources.Resources.check_mark_md
        Me.Found.Location = New System.Drawing.Point(376, 12)
        Me.Found.Name = "Found"
        Me.Found.Size = New System.Drawing.Size(94, 69)
        Me.Found.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Found.TabIndex = 3
        Me.Found.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(272, 366)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Result
        '
        Me.Result.AutoSize = True
        Me.Result.Location = New System.Drawing.Point(44, 48)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(10, 13)
        Me.Result.TabIndex = 5
        Me.Result.Text = "."
        '
        'Search_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 407)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnSearchExit)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.NOT_FOUD)
        Me.Controls.Add(Me.Found)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.SearchTextBox1)
        Me.Name = "Search_Form"
        Me.Text = "Search_Form"
        CType(Me.NOT_FOUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Found, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SearchTextBox1 As TextBox
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents Found As PictureBox
    Friend WithEvents NOT_FOUD As PictureBox
    Friend WithEvents BtnSearchExit As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Result As Label
End Class
