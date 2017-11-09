Public Class TransactionForm
    Const dblSalesTax As Double = 0.07 '7%

    Dim frmItemSelect As New TrasnsactionSelectScreen

    'add item to transaction
    Private Sub bntAddItem_Click(sender As Object, e As EventArgs) Handles bntAddItem.Click
        Me.Hide()
        frmItemSelect.ShowDialog()

        If frmItemSelect.getSelectedItem <> "" Then
            lstItems.Items.Add(frmItemSelect.getSelectedItem())
        End If

        Me.Show()
    End Sub

    'remove item from transaction
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
        Dim dblSubTotal As Double = calcSubTotal()
        Dim dblSalesTax As Double = calcSalesTax(dblSubTotal)
        Dim dblTotal As Double = dblSalesTax + dblSubTotal

        MsgBox("Subtotal: " + dblSubTotal.ToString("c") + vbNewLine + "Tax: " + dblSalesTax.ToString("c") + vbNewLine + "Total: " + dblTotal.ToString("c"))

        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        lstItems.Items.Clear()
        Me.Close()
    End Sub

    Function calcSubTotal()
        Dim subTotal As Double

        For Each item In lstItems.Items
            'split the entry in the list box at the $. 
            'EX: Test Entry, $12.95 -> {"Test Entry, $", "12.95"}
            Dim splitString As String() = item.ToString.Split("$")

            subTotal = subTotal + CDbl(splitString.Last)
        Next

        Return subTotal
    End Function

    Function calcSalesTax(subTotal As Double)
        Return subTotal * dblSalesTax
    End Function
End Class