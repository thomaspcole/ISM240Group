Imports MySql.Data.MySqlClient

Public Class EditItem

    Dim gameName As String
    Dim gamePrice As Double
    Dim gameRating As String

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'check to make sure data has been entered if not return early so the database does not break
        If txtName.Text = "" Or txtPrice.Text = "" Or txtRating.Text = "" Then
            MsgBox("Please make sure there is a value entered for all fields!")
            Return
        End If

        saveChangesToDB()
        Me.Close()
    End Sub

    'void changes and retrun to the inventory form
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    'this is called before the form is shown to fill the data fields on the form
    Function recieveItemToEdit(game As String)
        Dim sqlReader As MySqlDataReader = MainForm.ExecuteQueryWithReturn("SELECT * FROM games WHERE game_name='" + game + "'")

        'read data from sql
        While sqlReader.Read
            gameName = sqlReader.GetString(1)
            gamePrice = sqlReader.GetDouble(2)
            gameRating = sqlReader.GetString(3)
        End While
        sqlReader.Close()

        txtName.Text = gameName
        txtPrice.Text = gamePrice
        txtRating.Text = gameRating

        Return 1
    End Function

    'writes changes to the database
    Function saveChangesToDB()
        MainForm.ExecuteQuery("UPDATE games SET game_name='" + txtName.Text + "', game_price='" + txtPrice.Text + "', game_rating='" + txtRating.Text + "' WHERE game_name='" + gameName + "'")

        Return 1
    End Function
End Class