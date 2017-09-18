<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Management_Of_Racing_Drivers
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BirthDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Member_Number = New System.Windows.Forms.TextBox()
        Me.Name_Surname = New System.Windows.Forms.TextBox()
        Me.OutstandingAmount = New System.Windows.Forms.TextBox()
        Me.Completed = New System.Windows.Forms.TextBox()
        Me.JoinedDate = New System.Windows.Forms.DateTimePicker()
        Me.Female = New System.Windows.Forms.RadioButton()
        Me.Male = New System.Windows.Forms.RadioButton()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.ButtonModify = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Membership Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name & Surname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Birth Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gender"
        '
        'BirthDate
        '
        Me.BirthDate.Location = New System.Drawing.Point(224, 151)
        Me.BirthDate.Name = "BirthDate"
        Me.BirthDate.Size = New System.Drawing.Size(353, 20)
        Me.BirthDate.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Joined Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 334)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Outstanding Amount "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 387)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Completed "
        '
        'Member_Number
        '
        Me.Member_Number.Location = New System.Drawing.Point(224, 53)
        Me.Member_Number.Name = "Member_Number"
        Me.Member_Number.Size = New System.Drawing.Size(353, 20)
        Me.Member_Number.TabIndex = 8
        '
        'Name_Surname
        '
        Me.Name_Surname.Location = New System.Drawing.Point(224, 99)
        Me.Name_Surname.Name = "Name_Surname"
        Me.Name_Surname.Size = New System.Drawing.Size(353, 20)
        Me.Name_Surname.TabIndex = 9
        '
        'OutstandingAmount
        '
        Me.OutstandingAmount.Location = New System.Drawing.Point(224, 327)
        Me.OutstandingAmount.Name = "OutstandingAmount"
        Me.OutstandingAmount.Size = New System.Drawing.Size(353, 20)
        Me.OutstandingAmount.TabIndex = 12
        '
        'Completed
        '
        Me.Completed.Location = New System.Drawing.Point(224, 380)
        Me.Completed.Name = "Completed"
        Me.Completed.Size = New System.Drawing.Size(353, 20)
        Me.Completed.TabIndex = 13
        '
        'JoinedDate
        '
        Me.JoinedDate.Location = New System.Drawing.Point(224, 266)
        Me.JoinedDate.Name = "JoinedDate"
        Me.JoinedDate.Size = New System.Drawing.Size(353, 20)
        Me.JoinedDate.TabIndex = 14
        '
        'Female
        '
        Me.Female.AutoSize = True
        Me.Female.Location = New System.Drawing.Point(224, 210)
        Me.Female.Name = "Female"
        Me.Female.Size = New System.Drawing.Size(59, 17)
        Me.Female.TabIndex = 15
        Me.Female.TabStop = True
        Me.Female.Text = "Female"
        Me.Female.UseVisualStyleBackColor = True
        '
        'Male
        '
        Me.Male.AutoSize = True
        Me.Male.Location = New System.Drawing.Point(374, 210)
        Me.Male.Name = "Male"
        Me.Male.Size = New System.Drawing.Size(48, 17)
        Me.Male.TabIndex = 16
        Me.Male.TabStop = True
        Me.Male.Text = "Male"
        Me.Male.UseVisualStyleBackColor = True
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(34, 435)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(75, 23)
        Me.BtnBack.TabIndex = 17
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'BtnRemove
        '
        Me.BtnRemove.Location = New System.Drawing.Point(148, 435)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(75, 23)
        Me.BtnRemove.TabIndex = 18
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'ButtonModify
        '
        Me.ButtonModify.Location = New System.Drawing.Point(256, 435)
        Me.ButtonModify.Name = "ButtonModify"
        Me.ButtonModify.Size = New System.Drawing.Size(75, 23)
        Me.ButtonModify.TabIndex = 19
        Me.ButtonModify.Text = "Modify"
        Me.ButtonModify.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(374, 435)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 20
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(502, 435)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonExit.TabIndex = 21
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'Management_Of_Racing_Drivers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(624, 494)
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
        Me.Name = "Management_Of_Racing_Drivers"
        Me.Text = "Management_Of_Racing_Drivers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BirthDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Member_Number As TextBox
    Friend WithEvents Name_Surname As TextBox
    Friend WithEvents OutstandingAmount As TextBox
    Friend WithEvents Completed As TextBox
    Friend WithEvents JoinedDate As DateTimePicker
    Friend WithEvents Female As RadioButton
    Friend WithEvents Male As RadioButton
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnRemove As Button
    Friend WithEvents ButtonModify As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonExit As Button
End Class
