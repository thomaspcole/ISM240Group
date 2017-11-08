Public Class TransactionForm
    Dim frmItemSelect As New TrasnsactionSelectScreen

    Private Sub bntAddItem_Click(sender As Object, e As EventArgs) Handles bntAddItem.Click
        Me.Hide()
        frmItemSelect.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
        If lstItems.SelectedItem <> "" Then
            Dim confirm As Integer = MsgBox("Are you sure", MsgBoxStyle.YesNo)

            'if the yes button is clicked
            If confirm = DialogResult.Yes Then
                lstItems.Items.Remove(lstItems.SelectedItem)
            End If
        Else
            MsgBox("Please select an item to delete.")
        End If
    End Sub

    Private Sub btnEndTransaction_Click(sender As Object, e As EventArgs) Handles btnEndTransaction.Click
        Console.WriteLine("Run end transaction functions.")
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class