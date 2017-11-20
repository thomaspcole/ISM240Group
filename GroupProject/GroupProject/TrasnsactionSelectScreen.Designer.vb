<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrasnsactionSelectScreen
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
        Me.lstInventory = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.gbxFilterByRating = New System.Windows.Forms.GroupBox()
        Me.radM = New System.Windows.Forms.RadioButton()
        Me.radT = New System.Windows.Forms.RadioButton()
        Me.radE = New System.Windows.Forms.RadioButton()
        Me.radAll = New System.Windows.Forms.RadioButton()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.gbxFilterByRating.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstInventory
        '
        Me.lstInventory.FormattingEnabled = True
        Me.lstInventory.ItemHeight = 25
        Me.lstInventory.Location = New System.Drawing.Point(387, 12)
        Me.lstInventory.Name = "lstInventory"
        Me.lstInventory.Size = New System.Drawing.Size(651, 554)
        Me.lstInventory.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search:"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(105, 55)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 31)
        Me.txtSearch.TabIndex = 3
        '
        'gbxFilterByRating
        '
        Me.gbxFilterByRating.Controls.Add(Me.radM)
        Me.gbxFilterByRating.Controls.Add(Me.radT)
        Me.gbxFilterByRating.Controls.Add(Me.radE)
        Me.gbxFilterByRating.Controls.Add(Me.radAll)
        Me.gbxFilterByRating.Location = New System.Drawing.Point(17, 147)
        Me.gbxFilterByRating.Name = "gbxFilterByRating"
        Me.gbxFilterByRating.Size = New System.Drawing.Size(197, 179)
        Me.gbxFilterByRating.TabIndex = 4
        Me.gbxFilterByRating.TabStop = False
        Me.gbxFilterByRating.Text = " Filter by rating"
        '
        'radM
        '
        Me.radM.AutoSize = True
        Me.radM.Location = New System.Drawing.Point(7, 136)
        Me.radM.Name = "radM"
        Me.radM.Size = New System.Drawing.Size(148, 29)
        Me.radM.TabIndex = 3
        Me.radM.TabStop = True
        Me.radM.Text = "Mature (M)"
        Me.radM.UseVisualStyleBackColor = True
        '
        'radT
        '
        Me.radT.AutoSize = True
        Me.radT.Location = New System.Drawing.Point(7, 101)
        Me.radT.Name = "radT"
        Me.radT.Size = New System.Drawing.Size(125, 29)
        Me.radT.TabIndex = 2
        Me.radT.TabStop = True
        Me.radT.Text = "Teen (T)"
        Me.radT.UseVisualStyleBackColor = True
        '
        'radE
        '
        Me.radE.AutoSize = True
        Me.radE.Location = New System.Drawing.Point(7, 66)
        Me.radE.Name = "radE"
        Me.radE.Size = New System.Drawing.Size(168, 29)
        Me.radE.TabIndex = 1
        Me.radE.TabStop = True
        Me.radE.Text = "Everyone (E)"
        Me.radE.UseVisualStyleBackColor = True
        '
        'radAll
        '
        Me.radAll.AutoSize = True
        Me.radAll.Location = New System.Drawing.Point(7, 31)
        Me.radAll.Name = "radAll"
        Me.radAll.Size = New System.Drawing.Size(67, 29)
        Me.radAll.TabIndex = 0
        Me.radAll.TabStop = True
        Me.radAll.Text = "All"
        Me.radAll.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(13, 534)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(101, 48)
        Me.btnDone.TabIndex = 5
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(120, 534)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(101, 48)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'TrasnsactionSelectScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 594)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.gbxFilterByRating)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstInventory)
        Me.Name = "TrasnsactionSelectScreen"
        Me.Text = "Inventory Selector"
        Me.gbxFilterByRating.ResumeLayout(False)
        Me.gbxFilterByRating.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstInventory As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents gbxFilterByRating As GroupBox
    Friend WithEvents radM As RadioButton
    Friend WithEvents radT As RadioButton
    Friend WithEvents radE As RadioButton
    Friend WithEvents radAll As RadioButton
    Friend WithEvents btnDone As Button
    Friend WithEvents btnCancel As Button
End Class
