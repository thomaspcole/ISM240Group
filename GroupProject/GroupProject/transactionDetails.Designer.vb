<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transactionDetails
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTDate = New System.Windows.Forms.Label()
        Me.lblTAmount = New System.Windows.Forms.Label()
        Me.lblTItems = New System.Windows.Forms.Label()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Transaction Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Transaction Amount:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Items:"
        '
        'lblTDate
        '
        Me.lblTDate.AutoSize = True
        Me.lblTDate.Location = New System.Drawing.Point(235, 13)
        Me.lblTDate.Name = "lblTDate"
        Me.lblTDate.Size = New System.Drawing.Size(0, 25)
        Me.lblTDate.TabIndex = 3
        '
        'lblTAmount
        '
        Me.lblTAmount.AutoSize = True
        Me.lblTAmount.Location = New System.Drawing.Point(235, 61)
        Me.lblTAmount.Name = "lblTAmount"
        Me.lblTAmount.Size = New System.Drawing.Size(0, 25)
        Me.lblTAmount.TabIndex = 4
        '
        'lblTItems
        '
        Me.lblTItems.AutoSize = True
        Me.lblTItems.Location = New System.Drawing.Point(235, 112)
        Me.lblTItems.Name = "lblTItems"
        Me.lblTItems.Size = New System.Drawing.Size(0, 25)
        Me.lblTItems.TabIndex = 5
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(611, 404)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(154, 63)
        Me.btnDone.TabIndex = 6
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'transactionDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 479)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.lblTItems)
        Me.Controls.Add(Me.lblTAmount)
        Me.Controls.Add(Me.lblTDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "transactionDetails"
        Me.Text = "Transaction Info"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTDate As Label
    Friend WithEvents lblTAmount As Label
    Friend WithEvents lblTItems As Label
    Friend WithEvents btnDone As Button
End Class
