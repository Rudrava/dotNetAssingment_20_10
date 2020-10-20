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
        Me.Input = New System.Windows.Forms.TextBox()
        Me.AddElementButton = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ArrayExceedErr = New System.Windows.Forms.Label()
        Me.ArrayOutput = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SortTrueButton = New System.Windows.Forms.Button()
        Me.ArrEmptyErr = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Input
        '
        Me.Input.Location = New System.Drawing.Point(49, 149)
        Me.Input.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Input.Name = "Input"
        Me.Input.Size = New System.Drawing.Size(154, 33)
        Me.Input.TabIndex = 0
        '
        'AddElementButton
        '
        Me.AddElementButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.AddElementButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AddElementButton.Location = New System.Drawing.Point(217, 149)
        Me.AddElementButton.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.AddElementButton.Name = "AddElementButton"
        Me.AddElementButton.Size = New System.Drawing.Size(116, 33)
        Me.AddElementButton.TabIndex = 1
        Me.AddElementButton.Text = "Add"
        Me.AddElementButton.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Location = New System.Drawing.Point(1190, 135)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(255, 329)
        Me.ListBox1.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1246, 479)
        Me.Button2.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(163, 44)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(313, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Array sorter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(285, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Enter element to add "
        '
        'ArrayExceedErr
        '
        Me.ArrayExceedErr.AutoSize = True
        Me.ArrayExceedErr.Font = New System.Drawing.Font("Fira Code", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArrayExceedErr.ForeColor = System.Drawing.Color.OrangeRed
        Me.ArrayExceedErr.Location = New System.Drawing.Point(144, 188)
        Me.ArrayExceedErr.Name = "ArrayExceedErr"
        Me.ArrayExceedErr.Size = New System.Drawing.Size(189, 13)
        Me.ArrayExceedErr.TabIndex = 7
        Me.ArrayExceedErr.Text = "** array Size exceeded (5)"
        Me.ArrayExceedErr.Visible = False
        '
        'ArrayOutput
        '
        Me.ArrayOutput.FormattingEnabled = True
        Me.ArrayOutput.ItemHeight = 25
        Me.ArrayOutput.Location = New System.Drawing.Point(560, 107)
        Me.ArrayOutput.Name = "ArrayOutput"
        Me.ArrayOutput.Size = New System.Drawing.Size(140, 179)
        Me.ArrayOutput.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(585, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "OutPut"
        '
        'SortTrueButton
        '
        Me.SortTrueButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SortTrueButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SortTrueButton.Location = New System.Drawing.Point(575, 292)
        Me.SortTrueButton.Name = "SortTrueButton"
        Me.SortTrueButton.Size = New System.Drawing.Size(115, 33)
        Me.SortTrueButton.TabIndex = 9
        Me.SortTrueButton.Text = "Sort"
        Me.SortTrueButton.UseVisualStyleBackColor = False
        '
        'ArrEmptyErr
        '
        Me.ArrEmptyErr.AutoSize = True
        Me.ArrEmptyErr.Font = New System.Drawing.Font("Fira Code", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArrEmptyErr.ForeColor = System.Drawing.Color.OrangeRed
        Me.ArrEmptyErr.Location = New System.Drawing.Point(550, 340)
        Me.ArrEmptyErr.Name = "ArrEmptyErr"
        Me.ArrEmptyErr.Size = New System.Drawing.Size(161, 13)
        Me.ArrEmptyErr.TabIndex = 7
        Me.ArrEmptyErr.Text = "** NOTHING TO SORT !!!"
        Me.ArrEmptyErr.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(804, 386)
        Me.Controls.Add(Me.SortTrueButton)
        Me.Controls.Add(Me.ArrayOutput)
        Me.Controls.Add(Me.ArrEmptyErr)
        Me.Controls.Add(Me.ArrayExceedErr)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.AddElementButton)
        Me.Controls.Add(Me.Input)
        Me.Font = New System.Drawing.Font("Fira Code", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "Form1"
        Me.Text = "array Sorter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Input As TextBox
    Friend WithEvents AddElementButton As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ArrayExceedErr As Label
    Friend WithEvents ArrayOutput As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SortTrueButton As Button
    Friend WithEvents ArrEmptyErr As Label
End Class
