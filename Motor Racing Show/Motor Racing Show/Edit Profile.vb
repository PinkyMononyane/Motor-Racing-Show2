Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Edit_Profile
    Dim MDBConnString_ As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EventsDB.accdb;"
    Dim ds As New DataSet
    Dim cnn As OleDbConnection = New OleDbConnection(MDBConnString_)
    Dim daMyName As New OleDbDataAdapter

    Dim dsMyName As New DataSet
    Dim mySelectQuery As String

    Private Sub Edit_Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        cnn.Open()
        Try

            dsMyName = New DataSet

            'RELOADING TABLE 
            mySelectQuery = "SELECT * FROM membersclub WHERE MembershipNum = '" + Member_Number.Text.Trim + "'"

            Dim myCommand As New OleDbCommand(mySelectQuery, cnn)


            daMyName.SelectCommand = myCommand

            daMyName.Fill(dsMyName)


            MessageBox.Show(dsMyName.Tables(0).Rows(0).Item("Name_Surname").ToString)

            Name_Surname.Text = dsMyName.Tables(0).Rows(0).Item("Name_Surname").ToString
            BirthDate.Value = dsMyName.Tables(0).Rows(0).Item("DateOfBirth").ToString

            Dim gender As String
            gender = dsMyName.Tables(0).Rows(0).Item("Gender").ToString

            If gender = "Male" Then
                Male.Checked = True
            ElseIf gender = "Female" Then
                Female.Checked = True
            End If

            JoinedDate.Value = dsMyName.Tables(0).Rows(0).Item("JoinedDate").ToString
            OutstandingAmount.Text = dsMyName.Tables(0).Rows(0).Item("OutstandingAmount").ToString
            Completed.Text = dsMyName.Tables(0).Rows(0).Item("Completed").ToString

        Catch ex As Exception
            MessageBox.Show("Member Not Found please try again ")
        End Try

        cnn.Close()
    End Sub

    Private Sub ButtonModify_Click(sender As Object, e As EventArgs) Handles ButtonModify.Click
        cnn.Open()

        Dim query As String

        Dim gender As String
        If Female.Checked = True Then
            gender = "Female"

        ElseIf Male.Checked = True Then
            gender = "Male"
        Else
            gender = "Not Specified"
        End If
        query = "Update membersclub SET MembershipNum = '" + Member_Number.Text + "', Name_Surname = '" + Name_Surname.Text + "' ,DateOfBirth = '" + BirthDate.Value.ToString + "', Gender = '" + gender + "',JoinedDate = '" + JoinedDate.Value.ToString + "', OutstandingAmount = '" + OutstandingAmount.Text + "', Completed = '" + Completed.Text + "' WHERE MembershipNum = '" + Member_Number.Text + "'"

        Try
            Dim cmd As New OleDbCommand(query, cnn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Thank you " + Name_Surname.Text + " FOR UPDATING YOUR RECORDS", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            If ex.ToString.Contains("duplicate") Then
                MessageBox.Show("Dear " + Name_Surname.Text + " We are Currently unable to process your request, as there is an existing Member with Similar Memeber Number! ", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Dear " + Name_Surname.Text + " We are Currently unable to process your request, Due to an Unknown error wihin the system.  Please Try again Later! ", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If


            'RELOADING TABLE 
            mySelectQuery = "SELECT * FROM membersclub WHERE MembershipNum = '" + Member_Number.Text + "'"

            Dim myCommand As New OleDbCommand(mySelectQuery, cnn)



            daMyName.SelectCommand = myCommand

            daMyName.Fill(dsMyName)


            MessageBox.Show(dsMyName.Tables(0).Rows(0).Item("Name_Surname").ToString)

            Name_Surname.Text = dsMyName.Tables(0).Rows(0).Item("Name_Surname").ToString
            BirthDate.Value = dsMyName.Tables(0).Rows(0).Item("DateOfBirth").ToString


            gender = dsMyName.Tables(0).Rows(0).Item("Gender").ToString

            If gender = "Male" Then
                Male.Checked = True
            ElseIf gender = "Female" Then
                Female.Checked = True
            End If


            JoinedDate.Value = dsMyName.Tables(0).Rows(0).Item("JoinedDate").ToString
            OutstandingAmount.Text = dsMyName.Tables(0).Rows(0).Item("OutstandingAmount").ToString
            Completed.Text = dsMyName.Tables(0).Rows(0).Item("Completed").ToString

        End Try
        cnn.Close()

    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        cnn.Open()
        Dim query As String

        Dim gender As String
        If Female.Checked = True Then
            gender = "Female"

        ElseIf Male.Checked = True Then
            gender = "Male"
        Else
            gender = "Not Specified"
        End If
        query = "DELETE FROM  membersclub WHERE  MembershipNum ='" + Member_Number.Text + ";"


        Try


            MessageBox.Show(query)

            Dim cmd As New OleDbCommand(query, cnn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Thank you " + Name_Surname.Text + " We have received your subscribtion.", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            If ex.ToString.Contains("duplicate") Then
                MessageBox.Show("Dear " + Name_Surname.Text + " We are Currently unable to process your request, as there is an existing Member with Similar Memeber Number! ", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Dear " + Name_Surname.Text + " We are Currently unable to process your request, Due to an Unknown error wihin the system.  Please Try again Later! " + ex.ToString, "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        End Try
        cnn.Close()

        'MessageBox.Show(FILE_NAME)

    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub
End Class