Imports System.Data.OleDb
Imports System.IO

Public Class Management_Of_Racing_Drivers
    Dim MDBConnString_ As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EventsDB.accdb;"
    Dim ds As New DataSet
    Dim cnn As OleDbConnection = New OleDbConnection(MDBConnString_)

    Dim yearJoined As String
    Dim yearOfBirth As String


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim query As String

        Dim gender As String
        If Female.Checked = True Then
            gender = "Female"

        ElseIf Male.Checked = True Then
            gender = "Male"
        Else
            gender = "Not Specified"
        End If
        query = "INSERT INTO membersclub (MembershipNum, Name_Surname,DateOfBirth, Gender,JoinedDate, OutstandingAmount, Completed) VALUES ('" + Member_Number.Text + "', '" + Name_Surname.Text + "','" + BirthDate.Value.ToString + "','" + gender + "', '" + JoinedDate.Value.ToString + "', '" + OutstandingAmount.Text + "','" + Completed.Text + "');"


        Try
            cnn.Open()

            MessageBox.Show(query)

            Dim cmd As New OleDbCommand(query, cnn)
            cmd.ExecuteNonQuery()

            cnn.Close()


            MessageBox.Show("Thank you " + Name_Surname.Text + " We have received your subscribtion.", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            If ex.ToString.Contains("duplicate") Then
                MessageBox.Show("Dear " + Name_Surname.Text + " We are Currently unable to process your request, as there is an existing Member with Similar Memeber Number! ", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Dear " + Name_Surname.Text + " We are Currently unable to process your request, Due to an Unknown error wihin the system.  Please Try again Later! ", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)



            End If
            cnn.Close()


        End Try


        'MessageBox.Show(FILE_NAME)


    End Sub

    Private Sub Management_Of_Racing_Drivers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cnn.Open()

            cnn.Close()


        Catch ex As Exception
            MessageBox.Show("DB Not Connected " + ex.ToString)
        End Try
        yearJoined = Date.Today.ToString("yyy")

        Member_Number.Text = yearJoined





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Name_Surname.Clear()
        Completed.Clear()
        OutstandingAmount.Clear()
        Member_Number.Clear()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Member_Number.TextChanged

        If Member_Number.Text.Length > 1 Then
            If IsNumeric(Member_Number.Text) Then

                'Do What u wanna do here 
            Else

                OutstandingAmount.Text = ""
                MessageBox.Show("You can only input number")
            End If

        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles OutstandingAmount.TextChanged

        If OutstandingAmount.Text.Length > 1 Then
            If IsNumeric(OutstandingAmount.Text) Then

                If IsNumeric(OutstandingAmount.Text) Then

                    'Do What u wanna do here 
                Else

                    OutstandingAmount.Text = ""
                    MessageBox.Show("You can only input number")
                End If
            End If

        End If

    End Sub
    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        Member_Number.ResetText()
        Name_Surname.ResetText()
        OutstandingAmount.ResetText()
        Completed.ResetText()
        Female.Checked = False
        Male.Checked = False
    End Sub

    Private Sub BirthDate_ValueChanged(sender As Object, e As EventArgs) Handles BirthDate.ValueChanged
        yearOfBirth = BirthDate.Value.ToString("yyy")
        Member_Number.ResetText()

        Member_Number.Text = yearJoined + yearOfBirth
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Managing_Motor_Racing.Show()
        Me.Close()
    End Sub

    Private Sub ButtonModify_Click(sender As Object, e As EventArgs) Handles ButtonModify.Click
        Edit_Profile.Show()

        Me.Hide()

    End Sub
End Class