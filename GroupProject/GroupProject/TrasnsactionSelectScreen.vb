Imports MySql.Data.MySqlClient

Public Class TrasnsactionSelectScreen

    Dim strGameandPrices As New ArrayList

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        loadListFromDB(txtSearch.Text)
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        radAll.Select()
        loadListFromDB("")
    End Sub

    'event handler for radio button checkchanged event
    Private Sub radCheckChanged(sender As Object, e As EventArgs) Handles radT.CheckedChanged, radM.CheckedChanged, radE.CheckedChanged, radAll.CheckedChanged
        loadListFromDB(txtSearch.Text)
    End Sub

    Function loadListFromDB(filter As String)
        Dim query As String = "SELECT * FROM games"

        If filter <> "" Then
            query = query + " WHERE game_name LIKE '%" + filter + "%'"
        Else
            query = query + " WHERE game_name IS NOT NULL"
        End If

        If radE.Checked = True Then
            query = query + " AND game_rating LIKE '%E%'"
        ElseIf radT.Checked = True Then
            query = query + " AND game_rating LIKE '%T%'"
        ElseIf radM.Checked = True Then
            query = query + " AND game_rating LIKE '%M%'"
        ElseIf radAll.Checked = True Then
            'leave the query alone
        End If

        'for testing remove me
        Console.WriteLine(query)

        Dim sqlReader As MySqlDataReader = MainForm.ExecuteQueryWithReturn(query)

        'clear the lists 
        lstInventory.Items.Clear()
        strGameandPrices.Clear()

        'read data from sql and insert it into the arraylist
        While sqlReader.Read
            strGameandPrices.Add(sqlReader.GetValue(1).ToString() + ", " + sqlReader.GetValue(2).ToString())
        End While
        sqlReader.Close()

        'copy contents of arraylist to the list box
        For Each game In strGameandPrices
            lstInventory.Items.Add(game)
        Next

        Return 1
    End Function
End Class