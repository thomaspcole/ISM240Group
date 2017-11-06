Imports MySql.Data.MySqlClient

Public Class InventoryForm

    Dim conn = MainForm.mySQLConnection

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Me.Close()
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Console.WriteLine("LoadedInventoryForm")

        MainForm.ExecuteQuery("SELECT * FROM games")
    End Sub
End Class