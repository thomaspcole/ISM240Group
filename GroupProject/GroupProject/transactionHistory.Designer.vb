<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transactionHistory
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
        Me.lstTransaction = New System.Windows.Forms.ListBox()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btnViewTransaction = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstTransaction
        '
        Me.lstTransaction.FormattingEnabled = True
        Me.lstTransaction.ItemHeight = 25
        Me.lstTransaction.Location = New System.Drawing.Point(13, 13)
        Me.lstTransaction.Name = "lstTransaction"
        Me.lstTransaction.Size = New System.Drawing.Size(863, 404)
        Me.lstTransaction.TabIndex = 0
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(684, 442)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(192, 62)
        Me.btnDone.TabIndex = 1
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'btnViewTransaction
        '
        Me.btnViewTransaction.Location = New System.Drawing.Point(12, 442)
        Me.btnViewTransaction.Name = "btnViewTransaction"
        Me.btnViewTransaction.Size = New System.Drawing.Size(256, 62)
        Me.btnViewTransaction.TabIndex = 2
        Me.btnViewTransaction.Text = "View Transaction"
        Me.btnViewTransaction.UseVisualStyleBackColor = True
        '
        'transactionHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 516)
        Me.Controls.Add(Me.btnViewTransaction)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.lstTransaction)
        Me.Name = "transactionHistory"
        Me.Text = "Transaction History"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstTransaction As ListBox
    Friend WithEvents btnDone As Button
    Friend WithEvents btnViewTransaction As Button
End Class
