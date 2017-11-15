<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm     





' jsdklfjs;l
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.btnTransactionMode = New System.Windows.Forms.Button()
        Me.btnInventoryManager = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnTransactionHistory = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTransactionMode
        '
        Me.btnTransactionMode.Location = New System.Drawing.Point(12, 12)
        Me.btnTransactionMode.Name = "btnTransactionMode"
        Me.btnTransactionMode.Size = New System.Drawing.Size(250, 75)
        Me.btnTransactionMode.TabIndex = 0
        Me.btnTransactionMode.Text = "Transaction Mode"
        Me.btnTransactionMode.UseVisualStyleBackColor = True
        '
        'btnInventoryManager
        '
        Me.btnInventoryManager.Location = New System.Drawing.Point(12, 93)
        Me.btnInventoryManager.Name = "btnInventoryManager"
        Me.btnInventoryManager.Size = New System.Drawing.Size(250, 75)
        Me.btnInventoryManager.TabIndex = 1
        Me.btnInventoryManager.Text = "Inventory Manager"
        Me.btnInventoryManager.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(12, 482)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(250, 75)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(382, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(360, 480)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btnTransactionHistory
        '
        Me.btnTransactionHistory.Location = New System.Drawing.Point(12, 174)
        Me.btnTransactionHistory.Name = "btnTransactionHistory"
        Me.btnTransactionHistory.Size = New System.Drawing.Size(250, 75)
        Me.btnTransactionHistory.TabIndex = 4
        Me.btnTransactionHistory.Text = "Transaction History"
        Me.btnTransactionHistory.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 569)
        Me.Controls.Add(Me.btnTransactionHistory)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnInventoryManager)
        Me.Controls.Add(Me.btnTransactionMode)
        Me.Name = "MainForm"
        Me.Text = "Game Store"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnTransactionMode As Button
    Friend WithEvents btnInventoryManager As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnTransactionHistory As Button
End Class
