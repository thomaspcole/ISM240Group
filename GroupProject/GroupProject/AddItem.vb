Imports MySql.Data.MySqlClient

Public Class AddItem

    Dim gameID As Integer = 0

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim gameName As String = txtName.Text
        Dim gamePrice As String = txtPrice.Text
        Dim gameRating As String = txtRating.Text

        If gameName = "" Or gamePrice = "" Or gameRating = "" Then
            MsgBox("Please enter a value for all fields.")
            Return
        End If

        gameID = getNextID()

        If gameID <> 0 Then
            MainForm.ExecuteQuery("INSERT INTO games(game_id,game_name,game_price,game_rating) VALUES('" + gameID.ToString() + "','" + gameName + "','" + gamePrice + "','" + gameRating + "')")
        End If

        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Function getNextID()
        Dim sqlReader As MySqlDataReader = MainForm.ExecuteQueryWithReturn("SELECT MAX(game_id) FROM games")
        Dim id As Integer

        'read data from sql
        While sqlReader.Read
            id = sqlReader.GetValue(0)
        End While
        sqlReader.Close()

        Return id + 1
    End Function
End Class