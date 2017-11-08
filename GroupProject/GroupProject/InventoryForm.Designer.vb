<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventoryForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnEditExistingItem = New System.Windows.Forms.Button()
        Me.btnDeleteItem = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.lstInventory = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnAddItem
        '
        Me.btnAddItem.Location = New System.Drawing.Point(6, 269)
        Me.btnAddItem.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(65, 21)
        Me.btnAddItem.TabIndex = 0
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'btnEditExistingItem
        '
        Me.btnEditExistingItem.Location = New System.Drawing.Point(74, 269)
        Me.btnEditExistingItem.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEditExistingItem.Name = "btnEditExistingItem"
        Me.btnEditExistingItem.Size = New System.Drawing.Size(65, 21)
        Me.btnEditExistingItem.TabIndex = 1
        Me.btnEditExistingItem.Text = "Edit Item"
        Me.btnEditExistingItem.UseVisualStyleBackColor = True
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.Location = New System.Drawing.Point(142, 269)
        Me.btnDeleteItem.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Size = New System.Drawing.Size(65, 21)
        Me.btnDeleteItem.TabIndex = 2
        Me.btnDeleteItem.Text = "Delete Item"
        Me.btnDeleteItem.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(316, 269)
        Me.btnDone.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(65, 21)
        Me.btnDone.TabIndex = 3
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'lstInventory
        '
        Me.lstInventory.FormattingEnabled = True
        Me.lstInventory.Location = New System.Drawing.Point(6, 6)
        Me.lstInventory.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstInventory.Name = "lstInventory"
        Me.lstInventory.Size = New System.Drawing.Size(377, 251)
        Me.lstInventory.TabIndex = 4
        '
        'InventoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 296)
        Me.Controls.Add(Me.lstInventory)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnDeleteItem)
        Me.Controls.Add(Me.btnEditExistingItem)
        Me.Controls.Add(Me.btnAddItem)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "InventoryForm"
        Me.Text = "InventoryForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddItem As Button
    Friend WithEvents btnEditExistingItem As Button
    Friend WithEvents btnDeleteItem As Button
    Friend WithEvents btnDone As Button
    Friend WithEvents lstInventory As ListBox
End Class
