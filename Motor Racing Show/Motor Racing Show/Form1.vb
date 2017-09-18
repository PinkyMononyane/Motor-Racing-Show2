Imports System.IO
Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Public Class Managing_Motor_Racing

    Dim MDBConnString_ As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EventsDB.accdb;"
    Dim ds As New DataSet
    Dim cnn As OleDbConnection = New OleDbConnection(MDBConnString_)

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim query As String

        query = "INSERT INTO EventsTable (EventTitle, EventDate, RegistrationFee, EventLocation,LapNumber) VALUES ('" + EventTitle.Text + "','" + EventDate.Value.ToString + "','" + RegistrationFee.Text + "', '" + EventLocation.Text + "', '" + NumberOfLaps.Text + "');"

        Try
            cnn.Open()

            MessageBox.Show(query)

            Dim cmd As New OleDbCommand(query, cnn)
            cmd.ExecuteNonQuery()

            cnn.Close()


            MessageBox.Show("Event saved ", "Successfully")

        Catch ex As Exception

            If ex.ToString.Contains("duplicate") Then
                MessageBox.Show("There is an existing Event with a Similar Name! ", "Please try again")

            Else
                MessageBox.Show("An Unknown error has occured! Please Try again Later! ")

            End If
            cnn.Close()


        End Try


        'MessageBox.Show(FILE_NAME)


    End Sub


    Private Sub ViewMembersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewMembersToolStripMenuItem.Click
        Search_Form.Show()

        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Management_Of_Racing_Drivers.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        ListTextBox.AppendText(" " + vbNewLine)
        ListTextBox.AppendText(vbTab & Label1.Text + " : " + EventTitle.Text + vbNewLine)
        ListTextBox.AppendText("===========================================" + vbNewLine)
        ListTextBox.AppendText(vbTab & Label2.Text + " : " + EventDate.Text + vbNewLine)
        ListTextBox.AppendText("===========================================" + vbNewLine)
        ListTextBox.AppendText(vbTab & Label3.Text + " : " + RegistrationFee.Text + vbNewLine)
        ListTextBox.AppendText(" " + vbNewLine)
        ListTextBox.AppendText(vbTab & Label4.Text + " : " + EventLocation.Text + vbNewLine)
        ListTextBox.AppendText(" " + vbNewLine)
        ListTextBox.AppendText(vbTab & Label5.Text + " : " + NumberOfLaps.Text + vbNewLine)
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles NumberOfLaps.TextChanged
        If IsNumeric(NumberOfLaps.Text) Then

            'Do What u wanna do here 
        Else

            NumberOfLaps.Text = ""
            MessageBox.Show("You can only input number")
        End If
    End Sub

    Private Sub AddNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewToolStripMenuItem.Click
        Management_Of_Racing_Drivers.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles RegistrationFee.TextChanged
        If IsNumeric(RegistrationFee.Text) Then

            'Do What u wanna do here 
        Else

            NumberOfLaps.Text = ""
            MessageBox.Show("You can only input number")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles RemoeButton.Click
        EventTitle.ResetText()
        EventDate.ResetText()
        RegistrationFee.ResetText()
        EventLocation.ResetText()
        NumberOfLaps.ResetText()
        ListTextBox.ResetText()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ListTextBox_TextChanged(sender As Object, e As EventArgs) Handles ListTextBox.TextChanged

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Search_Form.Show()
        Me.Hide()
    End Sub

    Private Sub Managing_Motor_Racing_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
