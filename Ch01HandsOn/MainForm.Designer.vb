<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.BooksButton = New System.Windows.Forms.Button()
        Me.MusicButton = New System.Windows.Forms.Button()
        Me.PeriodicalsButton = New System.Windows.Forms.Button()
        Me.CoffeeBarButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PromotionLabel = New System.Windows.Forms.Label()
        Me.PromotionCodeLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BooksButton
        '
        Me.BooksButton.Location = New System.Drawing.Point(29, 91)
        Me.BooksButton.Name = "BooksButton"
        Me.BooksButton.Size = New System.Drawing.Size(101, 30)
        Me.BooksButton.TabIndex = 0
        Me.BooksButton.Text = "Books"
        Me.BooksButton.UseVisualStyleBackColor = True
        '
        'MusicButton
        '
        Me.MusicButton.Location = New System.Drawing.Point(29, 127)
        Me.MusicButton.Name = "MusicButton"
        Me.MusicButton.Size = New System.Drawing.Size(101, 30)
        Me.MusicButton.TabIndex = 1
        Me.MusicButton.Text = "Music"
        Me.MusicButton.UseVisualStyleBackColor = True
        '
        'PeriodicalsButton
        '
        Me.PeriodicalsButton.Location = New System.Drawing.Point(29, 163)
        Me.PeriodicalsButton.Name = "PeriodicalsButton"
        Me.PeriodicalsButton.Size = New System.Drawing.Size(101, 30)
        Me.PeriodicalsButton.TabIndex = 2
        Me.PeriodicalsButton.Text = "Periodicals"
        Me.PeriodicalsButton.UseVisualStyleBackColor = True
        '
        'CoffeeBarButton
        '
        Me.CoffeeBarButton.Location = New System.Drawing.Point(29, 199)
        Me.CoffeeBarButton.Name = "CoffeeBarButton"
        Me.CoffeeBarButton.Size = New System.Drawing.Size(101, 30)
        Me.CoffeeBarButton.TabIndex = 3
        Me.CoffeeBarButton.Text = "Coffee Bar"
        Me.CoffeeBarButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(29, 269)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(101, 30)
        Me.PrintButton.TabIndex = 4
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(29, 305)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(101, 30)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(159, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Current Promotion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(168, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Promotion Code"
        '
        'PromotionLabel
        '
        Me.PromotionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PromotionLabel.Location = New System.Drawing.Point(256, 100)
        Me.PromotionLabel.Name = "PromotionLabel"
        Me.PromotionLabel.Size = New System.Drawing.Size(290, 34)
        Me.PromotionLabel.TabIndex = 8
        Me.PromotionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PromotionCodeLabel
        '
        Me.PromotionCodeLabel.AutoEllipsis = True
        Me.PromotionCodeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PromotionCodeLabel.Location = New System.Drawing.Point(256, 154)
        Me.PromotionCodeLabel.Name = "PromotionCodeLabel"
        Me.PromotionCodeLabel.Size = New System.Drawing.Size(96, 30)
        Me.PromotionCodeLabel.TabIndex = 9
        Me.PromotionCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(499, 325)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Programmed by Victoria Brown"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 347)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PromotionCodeLabel)
        Me.Controls.Add(Me.PromotionLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.CoffeeBarButton)
        Me.Controls.Add(Me.PeriodicalsButton)
        Me.Controls.Add(Me.MusicButton)
        Me.Controls.Add(Me.BooksButton)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "R 'n R--For Reading and Refreshment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BooksButton As Button
    Friend WithEvents MusicButton As Button
    Friend WithEvents PeriodicalsButton As Button
    Friend WithEvents CoffeeBarButton As Button
    Friend WithEvents PrintButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PromotionLabel As Label
    Friend WithEvents PromotionCodeLabel As Label
    Friend WithEvents Label3 As Label
End Class
