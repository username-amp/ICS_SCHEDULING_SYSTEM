﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminRegistration
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
        Panel1 = New Panel()
        Label7 = New Label()
        Button2 = New Button()
        txtfname = New TextBox()
        Panel2 = New Panel()
        Panel3 = New Panel()
        txtmname = New TextBox()
        Panel5 = New Panel()
        txtsurname = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Panel4 = New Panel()
        cbsuffix = New ComboBox()
        txtemail = New TextBox()
        Panel9 = New Panel()
        cbRole = New ComboBox()
        Panel8 = New Panel()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        nextbtn = New Button()
        Label8 = New Label()
        Panel6 = New Panel()
        cbworkstatus = New ComboBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel9.SuspendLayout()
        Panel8.SuspendLayout()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(2), CByte(47), CByte(31))
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Button2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(734, 42)
        Panel1.TabIndex = 0
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.WhiteSmoke
        Label7.Location = New Point(582, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(140, 26)
        Label7.TabIndex = 2
        Label7.Text = "REGISTRATION"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(2), CByte(47), CByte(31))
        Button2.BackgroundImage = My.Resources.Resources.backBtn_removebg_preview
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(12, 6)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(39, 30)
        Button2.TabIndex = 1
        Button2.UseVisualStyleBackColor = False
        ' 
        ' txtfname
        ' 
        txtfname.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        txtfname.BorderStyle = BorderStyle.None
        txtfname.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtfname.Location = New Point(17, 11)
        txtfname.Name = "txtfname"
        txtfname.Size = New Size(244, 20)
        txtfname.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        Panel2.Controls.Add(txtfname)
        Panel2.Location = New Point(28, 96)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(277, 42)
        Panel2.TabIndex = 2
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        Panel3.Controls.Add(txtmname)
        Panel3.Location = New Point(28, 185)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(277, 42)
        Panel3.TabIndex = 3
        ' 
        ' txtmname
        ' 
        txtmname.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        txtmname.BorderStyle = BorderStyle.None
        txtmname.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtmname.Location = New Point(17, 11)
        txtmname.Name = "txtmname"
        txtmname.Size = New Size(244, 20)
        txtmname.TabIndex = 2
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        Panel5.Controls.Add(txtsurname)
        Panel5.Location = New Point(28, 268)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(277, 42)
        Panel5.TabIndex = 4
        ' 
        ' txtsurname
        ' 
        txtsurname.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        txtsurname.BorderStyle = BorderStyle.None
        txtsurname.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtsurname.Location = New Point(17, 11)
        txtsurname.Name = "txtsurname"
        txtsurname.Size = New Size(244, 20)
        txtsurname.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Location = New Point(28, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 23)
        Label1.TabIndex = 10
        Label1.Text = "Firstname"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label2.Location = New Point(28, 159)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 23)
        Label2.TabIndex = 11
        Label2.Text = "Middlename"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label3.Location = New Point(28, 242)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 23)
        Label3.TabIndex = 12
        Label3.Text = "Surname"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        Panel4.Controls.Add(cbsuffix)
        Panel4.Location = New Point(421, 96)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(277, 42)
        Panel4.TabIndex = 5
        ' 
        ' cbsuffix
        ' 
        cbsuffix.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        cbsuffix.FlatStyle = FlatStyle.Flat
        cbsuffix.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cbsuffix.FormattingEnabled = True
        cbsuffix.Items.AddRange(New Object() {"N/A", "Jr.", "Sr.", "II", "III", "IV"})
        cbsuffix.Location = New Point(17, 7)
        cbsuffix.Name = "cbsuffix"
        cbsuffix.Size = New Size(244, 27)
        cbsuffix.TabIndex = 4
        ' 
        ' txtemail
        ' 
        txtemail.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        txtemail.BorderStyle = BorderStyle.None
        txtemail.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtemail.Location = New Point(17, 11)
        txtemail.Name = "txtemail"
        txtemail.Size = New Size(244, 20)
        txtemail.TabIndex = 5
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        Panel9.Controls.Add(txtemail)
        Panel9.Location = New Point(421, 185)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(277, 42)
        Panel9.TabIndex = 6
        ' 
        ' cbRole
        ' 
        cbRole.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        cbRole.FlatStyle = FlatStyle.Flat
        cbRole.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cbRole.FormattingEnabled = True
        cbRole.Items.AddRange(New Object() {"DEAN", "BSIT PROGRAM HEAD", "BScPE PROGRAM HEAD"})
        cbRole.Location = New Point(17, 7)
        cbRole.Name = "cbRole"
        cbRole.Size = New Size(244, 27)
        cbRole.TabIndex = 6
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        Panel8.Controls.Add(cbRole)
        Panel8.Location = New Point(421, 274)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(277, 42)
        Panel8.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label4.Location = New Point(421, 70)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 23)
        Label4.TabIndex = 13
        Label4.Text = "Suffix"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label5.Location = New Point(421, 159)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 23)
        Label5.TabIndex = 14
        Label5.Text = "Email"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label6.Location = New Point(422, 248)
        Label6.Name = "Label6"
        Label6.Size = New Size(46, 23)
        Label6.TabIndex = 15
        Label6.Text = "Role"
        ' 
        ' nextbtn
        ' 
        nextbtn.BackColor = Color.FromArgb(CByte(2), CByte(47), CByte(31))
        nextbtn.FlatStyle = FlatStyle.Popup
        nextbtn.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        nextbtn.ForeColor = Color.WhiteSmoke
        nextbtn.Location = New Point(585, 351)
        nextbtn.Name = "nextbtn"
        nextbtn.Size = New Size(113, 43)
        nextbtn.TabIndex = 7
        nextbtn.Text = "NEXT"
        nextbtn.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label8.Location = New Point(28, 326)
        Label8.Name = "Label8"
        Label8.Size = New Size(106, 23)
        Label8.TabIndex = 17
        Label8.Text = "Work Status"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        Panel6.Controls.Add(cbworkstatus)
        Panel6.Location = New Point(27, 352)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(277, 42)
        Panel6.TabIndex = 16
        ' 
        ' cbworkstatus
        ' 
        cbworkstatus.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(237))
        cbworkstatus.FlatStyle = FlatStyle.Flat
        cbworkstatus.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cbworkstatus.FormattingEnabled = True
        cbworkstatus.Items.AddRange(New Object() {"FULL-TIMER", "PART-TIMER"})
        cbworkstatus.Location = New Point(17, 7)
        cbworkstatus.Name = "cbworkstatus"
        cbworkstatus.Size = New Size(244, 27)
        cbworkstatus.TabIndex = 6
        ' 
        ' adminRegistration
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
        ClientSize = New Size(734, 407)
        Controls.Add(Label8)
        Controls.Add(Panel6)
        Controls.Add(nextbtn)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel8)
        Controls.Add(Panel9)
        Controls.Add(Panel4)
        Controls.Add(Panel5)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "adminRegistration"
        StartPosition = FormStartPosition.CenterScreen
        Text = "adminRegistration"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtfname As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtmname As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtsurname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents cbRole As ComboBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents nextbtn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents cbsuffix As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents cbworkstatus As ComboBox
End Class