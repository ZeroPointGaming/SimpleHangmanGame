<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.HangmanBox = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelWord = New System.Windows.Forms.Label()
        Me.UsedLettersList = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.HangmanBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HangmanBox
        '
        Me.HangmanBox.Image = CType(resources.GetObject("HangmanBox.Image"), System.Drawing.Image)
        Me.HangmanBox.Location = New System.Drawing.Point(383, 12)
        Me.HangmanBox.Name = "HangmanBox"
        Me.HangmanBox.Size = New System.Drawing.Size(100, 100)
        Me.HangmanBox.TabIndex = 0
        Me.HangmanBox.TabStop = False
        Me.HangmanBox.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Chocolate
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(116, 165)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 55)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Start Game ➤"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LabelWord
        '
        Me.LabelWord.Font = New System.Drawing.Font("Segoe UI Semibold", 40.0!, System.Drawing.FontStyle.Bold)
        Me.LabelWord.Location = New System.Drawing.Point(116, 12)
        Me.LabelWord.Name = "LabelWord"
        Me.LabelWord.Size = New System.Drawing.Size(261, 100)
        Me.LabelWord.TabIndex = 2
        Me.LabelWord.Text = "________"
        Me.LabelWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UsedLettersList
        '
        Me.UsedLettersList.BackColor = System.Drawing.Color.DimGray
        Me.UsedLettersList.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsedLettersList.ForeColor = System.Drawing.SystemColors.Window
        Me.UsedLettersList.FormattingEnabled = True
        Me.UsedLettersList.ItemHeight = 17
        Me.UsedLettersList.Location = New System.Drawing.Point(12, 12)
        Me.UsedLettersList.Name = "UsedLettersList"
        Me.UsedLettersList.ScrollAlwaysVisible = True
        Me.UsedLettersList.Size = New System.Drawing.Size(98, 208)
        Me.UsedLettersList.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Chocolate
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(238, 165)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 55)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Reset Game ➤"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Chocolate
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(363, 165)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 55)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Stop Game ➤"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(383, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 42)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Health = "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(493, 227)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.UsedLettersList)
        Me.Controls.Add(Me.LabelWord)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.HangmanBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Hangman"
        CType(Me.HangmanBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HangmanBox As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelWord As Label
    Friend WithEvents UsedLettersList As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
End Class
