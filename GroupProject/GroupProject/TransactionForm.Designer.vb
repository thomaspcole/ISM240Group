<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionForm
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
        Me.lstItems = New System.Windows.Forms.ListBox()
        Me.bntAddItem = New System.Windows.Forms.Button()
        Me.btnRemoveItem = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnEndTransaction = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstItems
        '
        Me.lstItems.FormattingEnabled = True
        Me.lstItems.ItemHeight = 25
        Me.lstItems.Location = New System.Drawing.Point(411, 12)
        Me.lstItems.Name = "lstItems"
        Me.lstItems.Size = New System.Drawing.Size(351, 529)
        Me.lstItems.TabIndex = 0
        '
        'bntAddItem
        '
        Me.bntAddItem.Location = New System.Drawing.Point(12, 12)
        Me.bntAddItem.Name = "bntAddItem"
        Me.bntAddItem.Size = New System.Drawing.Size(200, 50)
        Me.bntAddItem.TabIndex = 1
        Me.bntAddItem.Text = "Add Item"
        Me.bntAddItem.UseVisualStyleBackColor = True
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.Location = New System.Drawing.Point(12, 68)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(200, 50)
        Me.btnRemoveItem.TabIndex = 2
        Me.btnRemoveItem.Text = "Remove Item"
        Me.btnRemoveItem.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(12, 491)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(200, 50)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnEndTransaction
        '
        Me.btnEndTransaction.Location = New System.Drawing.Point(12, 435)
        Me.btnEndTransaction.Name = "btnEndTransaction"
        Me.btnEndTransaction.Size = New System.Drawing.Size(200, 50)
        Me.btnEndTransaction.TabIndex = 4
        Me.btnEndTransaction.Text = "End Transaction"
        Me.btnEndTransaction.UseVisualStyleBackColor = True
        '
        'TransactionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 569)
        Me.Controls.Add(Me.btnEndTransaction)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnRemoveItem)
        Me.Controls.Add(Me.bntAddItem)
        Me.Controls.Add(Me.lstItems)
        Me.Name = "TransactionForm"
        Me.Text = "TransactionForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstItems As ListBox
    Friend WithEvents bntAddItem As Button
    Friend WithEvents btnRemoveItem As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnEndTransaction As Button
End Class
