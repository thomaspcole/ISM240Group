Public Class TransactionForm
    Private Sub bntAddItem_Click(sender As Object, e As EventArgs) Handles bntAddItem.Click
        Console.WriteLine("Open add item menu")
    End Sub

    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
        Console.WriteLine("Open remove item menu")
    End Sub

    Private Sub btnEndTransaction_Click(sender As Object, e As EventArgs) Handles btnEndTransaction.Click
        Console.WriteLine("Run end transaction functions.")
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class