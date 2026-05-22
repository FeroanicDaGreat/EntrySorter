<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Entries = New ListBox()
        Button2 = New Button()
        Button3 = New Button()
        CheckBox1 = New CheckBox()
        Button4 = New Button()
        Results = New ListBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(446, 221)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 0
        Button1.Text = "Add Entry"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(408, 184)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(408, 269)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 25)
        Label1.TabIndex = 2
        Label1.Text = "Label"
        ' 
        ' Entries
        ' 
        Entries.FormattingEnabled = True
        Entries.Location = New Point(570, 184)
        Entries.Name = "Entries"
        Entries.Size = New Size(180, 129)
        Entries.TabIndex = 3
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(570, 359)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 4
        Button2.Text = "Choose Entry"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(570, 319)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 34)
        Button3.TabIndex = 5
        Button3.Text = "Remove Entry"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(626, 41)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(117, 29)
        CheckBox1.TabIndex = 6
        CheckBox1.Text = "Automate"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(626, 76)
        Button4.Name = "Button4"
        Button4.Size = New Size(112, 34)
        Button4.TabIndex = 7
        Button4.Text = "Confirm"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Results
        ' 
        Results.FormattingEnabled = True
        Results.Location = New Point(378, 41)
        Results.Name = "Results"
        Results.Size = New Size(180, 129)
        Results.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Results)
        Controls.Add(Button4)
        Controls.Add(CheckBox1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Entries)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Entries As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Results As ListBox

End Class
