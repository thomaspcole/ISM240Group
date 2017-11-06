Imports MySql.Data.MySqlClient

Public Class MainForm
    'declare new instances of forms
    Dim frmTransactionMode As New TransactionForm
    Dim frmInventoryManager As New InventoryForm

    'create new sql connection
    Dim mySQLConnection As New MySqlConnection

    Private Sub btnTransactionMode_Click(sender As Object, e As EventArgs) Handles btnTransactionMode.Click
        Me.Hide() 'hide base form 
        frmTransactionMode.ShowDialog() 'show new form
        Me.Show() 'when new form is closed show origional form
    End Sub

    Private Sub btnInventoryManager_Click(sender As Object, e As EventArgs) Handles btnInventoryManager.Click
        Me.Hide()
        frmInventoryManager.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'this is called when the form/program loads it is used for initialization 
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        ConnectToDB()
    End Sub

    'this is called when the form/program unloads 
    Private Sub Form_Unload(sender As Object, e As EventArgs) Handles Me.Closing
        mySQLConnection.Close()
    End Sub

    'connect to the mysql database
    Private Sub ConnectToDB()
        Dim DatabaseName As String = "ism240"
        Dim ServerUrl As String = "vortimoosegames.ddns.net"
        Dim Username As String = "visual"
        Dim Password As String = "eA5MxKFM2En2DMhzgX5J" 'NOTE THIS PASS WORD DOES NOT WORK ANYMORE. It turns out that putting a password in plaintext on github is a bad idea

        If Not mySQLConnection Is Nothing Then mySQLConnection.Close()

        mySQLConnection.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", ServerUrl, Username, Password, DatabaseName)
        Try
            mySQLConnection.Open()
            Console.WriteLine("CONNECTED TO DB!!!")
        Catch ex As Exception
            Console.WriteLine("Could not connect to DB" + ex.ToString())
        End Try
    End Sub

    'take in sql command and retrun a datareader
    Public Function ExecuteQuery(query As String)
        Dim sqlQuery As New MySqlCommand(query, mySQLConnection)
        Dim sqlReader As MySqlDataReader = sqlQuery.ExecuteReader()

        Return sqlReader
        sqlReader.Close()
    End Function
End Class
