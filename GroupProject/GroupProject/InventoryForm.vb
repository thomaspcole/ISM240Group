Imports MySql.Data.MySqlClient

Public Class InventoryForm
    Dim frmEditInventoryEntry As New EditItem
    Dim frmAddInventoryEntry As New AddItem

    Dim gamesList As New ArrayList

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Me.Close()
    End Sub

    'add item
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Me.Hide()

        frmAddInventoryEntry.ShowDialog()

        loadListFromDB()
        Me.Show()
    End Sub

    'edit existing
    Private Sub btnEditExistingItem_Click(sender As Object, e As EventArgs) Handles btnEditExistingItem.Click
        Me.Hide()

        'if something is selected when clicked
        If lstInventory.SelectedItem <> "" Then
            frmEditInventoryEntry.recieveItemToEdit(lstInventory.SelectedItem.ToString()) 'pass item to edit to the form
            frmEditInventoryEntry.ShowDialog()
        Else
            MsgBox("Please select an item to edit.")
        End If

        'when edit item form closes refresh the list
        loadListFromDB()
        Me.Show()
    End Sub

    'delete item
    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click

        'if something is selected when the button is clicked
        If lstInventory.SelectedItem <> "" Then
            Dim confirm As Integer = MsgBox("Are you sure?", MsgBoxStyle.YesNo)

            'if the yes button is clicked
            If confirm = DialogResult.Yes Then
                MainForm.ExecuteQuery("DELETE FROM games WHERE game_name='" + lstInventory.SelectedItem.ToString() + "'")
                loadListFromDB()
            End If
        Else
            MsgBox("Please select an item to delete.")
        End If
    End Sub

    'Runs when the form is loaded
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Console.WriteLine("LoadedInventoryForm")

        loadListFromDB()
    End Sub

    Function loadListFromDB()
        Dim sqlReader As MySqlDataReader = MainForm.ExecuteQueryWithReturn("SELECT * FROM games")

        'clear the lists 
        lstInventory.Items.Clear()
        gamesList.Clear()

        'read data from sql and insert it into the arraylist
        While sqlReader.Read
            gamesList.Add(sqlReader.GetValue(1))
        End While
        sqlReader.Close()

        'copy contents of arraylist to the list box
        For Each game In gamesList
            lstInventory.Items.Add(game)
        Next

        Return 1
    End Function

End Class