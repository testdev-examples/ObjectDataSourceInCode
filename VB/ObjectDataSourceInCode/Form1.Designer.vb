Namespace ObjectDataSourceInCode
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.button1 = New System.Windows.Forms.Button()
            Me.button2 = New System.Windows.Forms.Button()
            Me.button3 = New System.Windows.Forms.Button()
            Me.button4 = New System.Windows.Forms.Button()
            Me.label1 = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            ' 
            ' button1
            ' 
            Me.button1.Location = New System.Drawing.Point(30, 85)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(198, 22)
            Me.button1.TabIndex = 0
            Me.button1.Text = "Sample 1"
            Me.button1.UseVisualStyleBackColor = True
            ' 
            ' button2
            ' 
            Me.button2.Location = New System.Drawing.Point(30, 126)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(198, 23)
            Me.button2.TabIndex = 0
            Me.button2.Text = "Sample 2"
            Me.button2.UseVisualStyleBackColor = True
            ' 
            ' button3
            ' 
            Me.button3.Location = New System.Drawing.Point(30, 167)
            Me.button3.Name = "button3"
            Me.button3.Size = New System.Drawing.Size(198, 23)
            Me.button3.TabIndex = 0
            Me.button3.Text = "Sample 3"
            Me.button3.UseVisualStyleBackColor = True
            ' 
            ' button4
            ' 
            Me.button4.Location = New System.Drawing.Point(30, 210)
            Me.button4.Name = "button4"
            Me.button4.Size = New System.Drawing.Size(198, 23)
            Me.button4.TabIndex = 0
            Me.button4.Text = "Sample 4"
            Me.button4.UseVisualStyleBackColor = True
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.label1.Location = New System.Drawing.Point(27, 12)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(568, 34)
            Me.label1.TabIndex = 1
            Me.label1.Text = "Use these buttons to preview reports." & ControlChars.CrLf & "These reports are bound to the object data" & " sources that are configured in differnet ways."
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(621, 262)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.button4)
            Me.Controls.Add(Me.button3)
            Me.Controls.Add(Me.button2)
            Me.Controls.Add(Me.button1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private WithEvents button1 As System.Windows.Forms.Button
        Private WithEvents button2 As System.Windows.Forms.Button
        Private WithEvents button3 As System.Windows.Forms.Button
        Private WithEvents button4 As System.Windows.Forms.Button
        Private label1 As System.Windows.Forms.Label
    End Class
End Namespace