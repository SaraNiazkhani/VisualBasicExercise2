<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        firstNum = New Label()
        SecondNum = New Label()
        Button1 = New Button()
        Button2 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Outputlbl = New Label()
        SuspendLayout()
        ' 
        ' firstNum
        ' 
        firstNum.AutoSize = True
        firstNum.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        firstNum.Location = New Point(146, 73)
        firstNum.Name = "firstNum"
        firstNum.Size = New Size(83, 19)
        firstNum.TabIndex = 0
        firstNum.Text = "عدد اول  :"
        ' 
        ' SecondNum
        ' 
        SecondNum.AutoSize = True
        SecondNum.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        SecondNum.Location = New Point(142, 121)
        SecondNum.Name = "SecondNum"
        SecondNum.Size = New Size(87, 19)
        SecondNum.TabIndex = 1
        SecondNum.Text = "عدد دوم  :"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkGray
        Button1.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(445, 57)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 35)
        Button1.TabIndex = 2
        Button1.Text = "ضرب"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DarkGray
        Button2.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(445, 111)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 38)
        Button2.TabIndex = 3
        Button2.Text = "مربعات"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' ExitButton
        ' 

        EndButton.BackColor = Color.Salmon
        EndButton.Location = New Point(244, 223)
        EndButton.Name = "ExitButton"
        EndButton.Size = New Size(80, 30)
        EndButton.TabIndex = 1
        EndButton.Text = "خروج"
        EndButton.UseVisualStyleBackColor = False
        
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(249, 58)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(162, 40)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(249, 111)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(162, 38)
        TextBox2.TabIndex = 5
        ' 
        ' Outputlbl
        ' 
        Outputlbl.AutoSize = True
        Outputlbl.Font = New Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Outputlbl.Location = New Point(327, 206)
        Outputlbl.Name = "Outputlbl"
        Outputlbl.Size = New Size(0, 33)
        Outputlbl.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(706, 320)
        Controls.Add(Outputlbl)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(SecondNum)
        Controls.Add(firstNum)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Exercise02"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents firstNum As Label
    Friend WithEvents SecondNum As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Outputlbl As Label
End Class
