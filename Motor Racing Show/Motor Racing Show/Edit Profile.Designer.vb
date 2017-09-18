<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Profile
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
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonModify = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.Male = New System.Windows.Forms.RadioButton()
        Me.Female = New System.Windows.Forms.RadioButton()
        Me.JoinedDate = New System.Windows.Forms.DateTimePicker()
        Me.Completed = New System.Windows.Forms.TextBox()
        Me.OutstandingAmount = New System.Windows.Forms.TextBox()
        Me.Name_Surname = New System.Windows.Forms.TextBox()
        Me.Member_Number = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BirthDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Submit = New System.Windows.Forms.PictureBox()
        CType(Me.Submit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(515, 415)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonExit.TabIndex = 41
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(387, 415)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 40
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonModify
        '
        Me.ButtonModify.Location = New System.Drawing.Point(269, 415)
        Me.ButtonModify.Name = "ButtonModify"
        Me.ButtonModify.Size = New System.Drawing.Size(75, 23)
        Me.ButtonModify.TabIndex = 39
        Me.ButtonModify.Text = "Modify"
        Me.ButtonModify.UseVisualStyleBackColor = True
        '
        'BtnRemove
        '
        Me.BtnRemove.Location = New System.Drawing.Point(161, 415)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(75, 23)
        Me.BtnRemove.TabIndex = 38
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(47, 415)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(75, 23)
        Me.BtnBack.TabIndex = 37
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'Male
        '
        Me.Male.AutoSize = True
        Me.Male.Location = New System.Drawing.Point(387, 190)
        Me.Male.Name = "Male"
        Me.Male.Size = New System.Drawing.Size(48, 17)
        Me.Male.TabIndex = 36
        Me.Male.TabStop = True
        Me.Male.Text = "Male"
        Me.Male.UseVisualStyleBackColor = True
        '
        'Female
        '
        Me.Female.AutoSize = True
        Me.Female.Location = New System.Drawing.Point(237, 190)
        Me.Female.Name = "Female"
        Me.Female.Size = New System.Drawing.Size(59, 17)
        Me.Female.TabIndex = 35
        Me.Female.TabStop = True
        Me.Female.Text = "Female"
        Me.Female.UseVisualStyleBackColor = True
        '
        'JoinedDate
        '
        Me.JoinedDate.Location = New System.Drawing.Point(237, 246)
        Me.JoinedDate.Name = "JoinedDate"
        Me.JoinedDate.Size = New System.Drawing.Size(353, 20)
        Me.JoinedDate.TabIndex = 34
        '
        'Completed
        '
        Me.Completed.Location = New System.Drawing.Point(237, 360)
        Me.Completed.Name = "Completed"
        Me.Completed.Size = New System.Drawing.Size(353, 20)
        Me.Completed.TabIndex = 33
        '
        'OutstandingAmount
        '
        Me.OutstandingAmount.Location = New System.Drawing.Point(237, 307)
        Me.OutstandingAmount.Name = "OutstandingAmount"
        Me.OutstandingAmount.Size = New System.Drawing.Size(353, 20)
        Me.OutstandingAmount.TabIndex = 32
        '
        'Name_Surname
        '
        Me.Name_Surname.Location = New System.Drawing.Point(237, 79)
        Me.Name_Surname.Name = "Name_Surname"
        Me.Name_Surname.Size = New System.Drawing.Size(353, 20)
        Me.Name_Surname.TabIndex = 31
        '
        'Member_Number
        '
        Me.Member_Number.Location = New System.Drawing.Point(237, 33)
        Me.Member_Number.Name = "Member_Number"
        Me.Member_Number.Size = New System.Drawing.Size(225, 20)
        Me.Member_Number.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(49, 367)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Completed "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 314)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Outstanding Amount "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Joined Date"
        '
        'BirthDate
        '
        Me.BirthDate.Location = New System.Drawing.Point(237, 131)
        Me.BirthDate.Name = "BirthDate"
        Me.BirthDate.Size = New System.Drawing.Size(353, 20)
        Me.BirthDate.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Birth Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Name & Surname"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Membership Number"
        '
        'Submit
        '
        Me.Submit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Submit.Image = Global.Motor_Racing_Show.My.Resources.Resources.check_mark_md
        Me.Submit.Location = New System.Drawing.Point(577, 2)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(61, 61)
        Me.Submit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Submit.TabIndex = 42
        Me.Submit.TabStop = False
        '
        'Edit_Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 466)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonModify)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.Male)
        Me.Controls.Add(Me.Female)
        Me.Controls.Add(Me.JoinedDate)
        Me.Controls.Add(Me.Completed)
        Me.Controls.Add(Me.OutstandingAmount)
        Me.Controls.Add(Me.Name_Surname)
        Me.Controls.Add(Me.Member_Number)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BirthDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Edit_Profile"
        Me.Text = "Edit_Profile"
        CType(Me.Submit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonExit As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonModify As Button
    Friend WithEvents BtnRemove As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents Male As RadioButton
    Friend WithEvents Female As RadioButton
    Friend WithEvents JoinedDate As DateTimePicker
    Friend WithEvents Completed As TextBox
    Friend WithEvents OutstandingAmount As TextBox
    Friend WithEvents Name_Surname As TextBox
    Friend WithEvents Member_Number As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BirthDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Submit As PictureBox
End Class
