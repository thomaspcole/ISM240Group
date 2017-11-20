Imports MySql.Data.MySqlClient

Public Class transactionDetails
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Me.Close()
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Public Function loadInfoFromDB(toLoad As String)
        Dim query As String = "SELECT * FROM transactions WHERE t_id = '" + toLoad + "'"

        Dim sqlReader As MySqlDataReader = MainForm.ExecuteQueryWithReturn(query)

        While sqlReader.Read
            lblTDate.Text = sqlReader.GetValue(1).ToString()
            lblTAmount.Text = sqlReader.GetDouble(2).ToString("c")
            lblTItems.Text = sqlReader.GetString(3)
        End While
        sqlReader.Close()


        Return 1
    End Function
End Class