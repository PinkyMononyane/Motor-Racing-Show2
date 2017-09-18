Imports System.IO
Imports System.Text
Imports System.Data.OleDb

Public Class Search_Form

    Dim cnn As New OleDbConnection

    Private Sub Search_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EventsDB.accdb;"

    End Sub

    Private Sub SearchTextBox2_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged

    End Sub

    Private Sub SearchTextBox1_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox1.TextChanged
        cnn.Open()

        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("SELECT * FROM membersclub WHERE MembershipNum = '" + SearchTextBox1.Text + "'", cnn)
        da.Fill(dt)

        cnn.Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Found.Click

    End Sub

    Private Sub BtnSearchExit_Click(sender As Object, e As EventArgs) Handles BtnSearchExit.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Managing_Motor_Racing.Show()
        Me.Hide()
    End Sub

    Private Sub Result_Click(sender As Object, e As EventArgs) Handles Result.Click

    End Sub
End Class