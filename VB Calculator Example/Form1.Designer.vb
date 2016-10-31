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
        Me.cmd2 = New System.Windows.Forms.Button()
        Me.cmd1 = New System.Windows.Forms.Button()
        Me.cmdEnter = New System.Windows.Forms.Button()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.cmdC = New System.Windows.Forms.Button()
        Me.cmdOpSum = New System.Windows.Forms.Button()
        Me.cmdOpMulti = New System.Windows.Forms.Button()
        Me.txt3 = New System.Windows.Forms.Button()
        Me.txt4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmd2
        '
        Me.cmd2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cmd2.Location = New System.Drawing.Point(127, 89)
        Me.cmd2.Name = "cmd2"
        Me.cmd2.Size = New System.Drawing.Size(55, 48)
        Me.cmd2.TabIndex = 0
        Me.cmd2.Text = "2"
        Me.cmd2.UseVisualStyleBackColor = True
        '
        'cmd1
        '
        Me.cmd1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cmd1.Location = New System.Drawing.Point(56, 89)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(55, 48)
        Me.cmd1.TabIndex = 1
        Me.cmd1.Text = "1"
        Me.cmd1.UseVisualStyleBackColor = True
        '
        'cmdEnter
        '
        Me.cmdEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cmdEnter.Location = New System.Drawing.Point(56, 201)
        Me.cmdEnter.Name = "cmdEnter"
        Me.cmdEnter.Size = New System.Drawing.Size(126, 48)
        Me.cmdEnter.TabIndex = 2
        Me.cmdEnter.Text = "="
        Me.cmdEnter.UseVisualStyleBackColor = True
        '
        'txtDisplay
        '
        Me.txtDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtDisplay.Location = New System.Drawing.Point(56, 28)
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(202, 44)
        Me.txtDisplay.TabIndex = 3
        Me.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdC
        '
        Me.cmdC.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cmdC.ForeColor = System.Drawing.Color.Red
        Me.cmdC.Location = New System.Drawing.Point(203, 201)
        Me.cmdC.Name = "cmdC"
        Me.cmdC.Size = New System.Drawing.Size(55, 45)
        Me.cmdC.TabIndex = 4
        Me.cmdC.Text = "C"
        Me.cmdC.UseVisualStyleBackColor = True
        '
        'cmdOpSum
        '
        Me.cmdOpSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cmdOpSum.Location = New System.Drawing.Point(203, 89)
        Me.cmdOpSum.Name = "cmdOpSum"
        Me.cmdOpSum.Size = New System.Drawing.Size(55, 48)
        Me.cmdOpSum.TabIndex = 5
        Me.cmdOpSum.Text = "+"
        Me.cmdOpSum.UseVisualStyleBackColor = True
        '
        'cmdOpMulti
        '
        Me.cmdOpMulti.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cmdOpMulti.Location = New System.Drawing.Point(203, 147)
        Me.cmdOpMulti.Name = "cmdOpMulti"
        Me.cmdOpMulti.Size = New System.Drawing.Size(55, 48)
        Me.cmdOpMulti.TabIndex = 6
        Me.cmdOpMulti.Text = "*"
        Me.cmdOpMulti.UseVisualStyleBackColor = True
        '
        'txt3
        '
        Me.txt3.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txt3.Location = New System.Drawing.Point(56, 147)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(55, 48)
        Me.txt3.TabIndex = 7
        Me.txt3.Text = "3"
        Me.txt3.UseVisualStyleBackColor = True
        '
        'txt4
        '
        Me.txt4.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txt4.Location = New System.Drawing.Point(127, 147)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(55, 48)
        Me.txt4.TabIndex = 8
        Me.txt4.Text = "4"
        Me.txt4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 279)
        Me.Controls.Add(Me.txt4)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.cmdOpMulti)
        Me.Controls.Add(Me.cmdOpSum)
        Me.Controls.Add(Me.cmdC)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.cmdEnter)
        Me.Controls.Add(Me.cmd1)
        Me.Controls.Add(Me.cmd2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd2 As System.Windows.Forms.Button
    Friend WithEvents cmd1 As System.Windows.Forms.Button
    Friend WithEvents cmdEnter As System.Windows.Forms.Button
    Friend WithEvents txtDisplay As System.Windows.Forms.TextBox
    Friend WithEvents cmdC As System.Windows.Forms.Button
    Friend WithEvents cmdOpSum As System.Windows.Forms.Button
    Friend WithEvents cmdOpMulti As System.Windows.Forms.Button
    Friend WithEvents txt3 As System.Windows.Forms.Button
    Friend WithEvents txt4 As System.Windows.Forms.Button

End Class
