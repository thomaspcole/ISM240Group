Imports MySql.Data.MySqlClient

Public Class InventoryForm
    Dim frmEditInventoryEntry As New EditItem
    Dim conn = MainForm.mySQLConnection

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Me.Close()
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Console.WriteLine("LoadedInventoryForm")

        Dim sqlReader As MySqlDataReader = MainForm.ExecuteQuery("SELECT * FROM games")

        While sqlReader.Read
            lstInventory.Items.Add(sqlReader.GetValue(1))
        End While
    End Sub

    Private Sub btnEditExistingItem_Click(sender As Object, e As EventArgs) Handles btnEditExistingItem.Click
        Me.Hide()


        frmEditInventoryEntry.ShowDialog()


        Me.Show()
    End Sub
End Class