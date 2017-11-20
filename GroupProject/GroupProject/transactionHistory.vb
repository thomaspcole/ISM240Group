Imports MySql.Data.MySqlClient

Public Class transactionHistory
    Dim frmTransactionInfo As New transactionDetails

    Private Sub btnViewTransaction_Click(sender As Object, e As EventArgs) Handles btnViewTransaction.Click
        If lstTransaction.SelectedItem = "" Then
            MsgBox("Please select a transaction to view")
        Else
            Me.Hide()
            Dim splitString As String() = lstTransaction.SelectedItem.ToString.Split(":")
            Dim tID As String() = splitString(1).Split(" ")

            frmTransactionInfo.loadInfoFromDB(tID(0))
            frmTransactionInfo.ShowDialog()
            Me.Show()
        End If
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Me.Close()
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadTransactions()
    End Sub

    Function loadTransactions()
        Dim query As String = "SELECT * FROM transactions"

        Dim sqlReader As MySqlDataReader = MainForm.ExecuteQueryWithReturn(query)

        lstTransaction.Items.Clear()

        While sqlReader.Read
            lstTransaction.Items.Add("Transaction ID:" + sqlReader.GetValue(0).ToString() + " Transaction Date: " + sqlReader.GetValue(1).ToString() + " Transaction Amount: " + sqlReader.GetDouble(2).ToString("c"))
        End While
        sqlReader.Close()


        Return 1
    End Function

End Class