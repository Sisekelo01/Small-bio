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
        nameLabel = New Label()
        surnameLabel = New Label()
        ageLabel = New Label()
        Label4 = New Label()
        genderLabel = New Label()
        txtname = New TextBox()
        txtsurname = New TextBox()
        txtage = New TextBox()
        txttribe = New TextBox()
        aboutmeBtn = New Button()
        genderlistbox = New ListBox()
        SuspendLayout()
        ' 
        ' nameLabel
        ' 
        nameLabel.AutoSize = True
        nameLabel.Location = New Point(144, 36)
        nameLabel.Name = "nameLabel"
        nameLabel.Size = New Size(39, 15)
        nameLabel.TabIndex = 0
        nameLabel.Text = "Name"
        ' 
        ' surnameLabel
        ' 
        surnameLabel.AutoSize = True
        surnameLabel.Location = New Point(144, 77)
        surnameLabel.Name = "surnameLabel"
        surnameLabel.Size = New Size(54, 15)
        surnameLabel.TabIndex = 1
        surnameLabel.Text = "Surname"
        ' 
        ' ageLabel
        ' 
        ageLabel.AutoSize = True
        ageLabel.Location = New Point(144, 120)
        ageLabel.Name = "ageLabel"
        ageLabel.Size = New Size(28, 15)
        ageLabel.TabIndex = 2
        ageLabel.Text = "Age"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(144, 159)
        Label4.Name = "Label4"
        Label4.Size = New Size(32, 15)
        Label4.TabIndex = 3
        Label4.Text = "Tribe"
        ' 
        ' genderLabel
        ' 
        genderLabel.AutoSize = True
        genderLabel.Location = New Point(145, 192)
        genderLabel.Name = "genderLabel"
        genderLabel.Size = New Size(45, 15)
        genderLabel.TabIndex = 4
        genderLabel.Text = "Gender"
        ' 
        ' txtname
        ' 
        txtname.Location = New Point(452, 28)
        txtname.Name = "txtname"
        txtname.Size = New Size(100, 23)
        txtname.TabIndex = 5
        ' 
        ' txtsurname
        ' 
        txtsurname.Location = New Point(452, 69)
        txtsurname.Name = "txtsurname"
        txtsurname.Size = New Size(100, 23)
        txtsurname.TabIndex = 6
        ' 
        ' txtage
        ' 
        txtage.Location = New Point(452, 120)
        txtage.Name = "txtage"
        txtage.Size = New Size(100, 23)
        txtage.TabIndex = 7
        ' 
        ' txttribe
        ' 
        txttribe.Location = New Point(452, 159)
        txttribe.Name = "txttribe"
        txttribe.Size = New Size(100, 23)
        txttribe.TabIndex = 8
        ' 
        ' aboutmeBtn
        ' 
        aboutmeBtn.Location = New Point(310, 249)
        aboutmeBtn.Name = "aboutmeBtn"
        aboutmeBtn.Size = New Size(75, 23)
        aboutmeBtn.TabIndex = 10
        aboutmeBtn.Text = "About Me"
        aboutmeBtn.UseVisualStyleBackColor = True
        ' 
        ' genderlistbox
        ' 
        genderlistbox.FormattingEnabled = True
        genderlistbox.ItemHeight = 15
        genderlistbox.Items.AddRange(New Object() {"Male", "Female"})
        genderlistbox.Location = New Point(452, 204)
        genderlistbox.Name = "genderlistbox"
        genderlistbox.Size = New Size(120, 34)
        genderlistbox.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(genderlistbox)
        Controls.Add(aboutmeBtn)
        Controls.Add(txttribe)
        Controls.Add(txtage)
        Controls.Add(txtsurname)
        Controls.Add(txtname)
        Controls.Add(genderLabel)
        Controls.Add(Label4)
        Controls.Add(ageLabel)
        Controls.Add(surnameLabel)
        Controls.Add(nameLabel)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents nameLabel As Label
    Friend WithEvents surnameLabel As Label
    Friend WithEvents ageLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents genderLabel As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtsurname As TextBox
    Friend WithEvents txtage As TextBox
    Friend WithEvents txttribe As TextBox
    Friend WithEvents aboutmeBtn As Button
    Friend WithEvents genderlistbox As ListBox
End Class
