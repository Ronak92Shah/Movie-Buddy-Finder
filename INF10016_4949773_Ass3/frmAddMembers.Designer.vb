<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddMembers
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
        Me.lblAssName1 = New System.Windows.Forms.Label()
        Me.lblAssName2 = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPhoneNo = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblAgeDifference = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblSeeking = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPhoneNo = New System.Windows.Forms.TextBox()
        Me.txtAgeDifference = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.grpGender = New System.Windows.Forms.GroupBox()
        Me.radGenderMale = New System.Windows.Forms.RadioButton()
        Me.radGenderFemale = New System.Windows.Forms.RadioButton()
        Me.grpSeeking = New System.Windows.Forms.GroupBox()
        Me.radSeekingMale = New System.Windows.Forms.RadioButton()
        Me.radSeekingFemale = New System.Windows.Forms.RadioButton()
        Me.lblFavouriteGeneres = New System.Windows.Forms.Label()
        Me.clbFavouriteGenres = New System.Windows.Forms.CheckedListBox()
        Me.grpFavouriteGenres = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.grpGender.SuspendLayout()
        Me.grpSeeking.SuspendLayout()
        Me.grpFavouriteGenres.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAssName1
        '
        Me.lblAssName1.AutoSize = True
        Me.lblAssName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssName1.Location = New System.Drawing.Point(107, 13)
        Me.lblAssName1.Name = "lblAssName1"
        Me.lblAssName1.Size = New System.Drawing.Size(317, 37)
        Me.lblAssName1.TabIndex = 0
        Me.lblAssName1.Text = "Movie Buddy Finder"
        '
        'lblAssName2
        '
        Me.lblAssName2.AutoSize = True
        Me.lblAssName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssName2.Location = New System.Drawing.Point(121, 50)
        Me.lblAssName2.Name = "lblAssName2"
        Me.lblAssName2.Size = New System.Drawing.Size(290, 18)
        Me.lblAssName2.TabIndex = 1
        Me.lblAssName2.Text = "making dreams come true since 2009"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(37, 103)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(25, 15)
        Me.lblId.TabIndex = 2
        Me.lblId.Text = "ID:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(37, 152)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(49, 15)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Name:"
        '
        'lblPhoneNo
        '
        Me.lblPhoneNo.AutoSize = True
        Me.lblPhoneNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNo.Location = New System.Drawing.Point(37, 201)
        Me.lblPhoneNo.Name = "lblPhoneNo"
        Me.lblPhoneNo.Size = New System.Drawing.Size(70, 15)
        Me.lblPhoneNo.TabIndex = 4
        Me.lblPhoneNo.Text = "PhoneNo:"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(37, 240)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(35, 15)
        Me.lblAge.TabIndex = 5
        Me.lblAge.Text = "Age:"
        '
        'lblAgeDifference
        '
        Me.lblAgeDifference.AutoSize = True
        Me.lblAgeDifference.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgeDifference.Location = New System.Drawing.Point(37, 381)
        Me.lblAgeDifference.Name = "lblAgeDifference"
        Me.lblAgeDifference.Size = New System.Drawing.Size(105, 15)
        Me.lblAgeDifference.TabIndex = 6
        Me.lblAgeDifference.Text = "Age Difference:"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(37, 279)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(54, 15)
        Me.lblGender.TabIndex = 7
        Me.lblGender.Text = "Gender"
        '
        'lblSeeking
        '
        Me.lblSeeking.AutoSize = True
        Me.lblSeeking.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeeking.Location = New System.Drawing.Point(37, 328)
        Me.lblSeeking.Name = "lblSeeking"
        Me.lblSeeking.Size = New System.Drawing.Size(59, 15)
        Me.lblSeeking.TabIndex = 8
        Me.lblSeeking.Text = "Seeking"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(150, 102)
        Me.txtId.MaxLength = 5
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 9
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(150, 151)
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 10
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.Location = New System.Drawing.Point(150, 196)
        Me.txtPhoneNo.MaxLength = 10
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(100, 20)
        Me.txtPhoneNo.TabIndex = 11
        '
        'txtAgeDifference
        '
        Me.txtAgeDifference.Location = New System.Drawing.Point(153, 383)
        Me.txtAgeDifference.MaxLength = 2
        Me.txtAgeDifference.Name = "txtAgeDifference"
        Me.txtAgeDifference.Size = New System.Drawing.Size(100, 20)
        Me.txtAgeDifference.TabIndex = 12
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(150, 242)
        Me.txtAge.MaxLength = 2
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(100, 20)
        Me.txtAge.TabIndex = 13
        '
        'grpGender
        '
        Me.grpGender.Controls.Add(Me.radGenderMale)
        Me.grpGender.Controls.Add(Me.radGenderFemale)
        Me.grpGender.Location = New System.Drawing.Point(150, 281)
        Me.grpGender.Name = "grpGender"
        Me.grpGender.Size = New System.Drawing.Size(121, 33)
        Me.grpGender.TabIndex = 14
        Me.grpGender.TabStop = False
        '
        'radGenderMale
        '
        Me.radGenderMale.AutoSize = True
        Me.radGenderMale.Checked = True
        Me.radGenderMale.Location = New System.Drawing.Point(67, 16)
        Me.radGenderMale.Name = "radGenderMale"
        Me.radGenderMale.Size = New System.Drawing.Size(48, 17)
        Me.radGenderMale.TabIndex = 1
        Me.radGenderMale.TabStop = True
        Me.radGenderMale.Text = "Male"
        Me.radGenderMale.UseVisualStyleBackColor = True
        '
        'radGenderFemale
        '
        Me.radGenderFemale.AutoSize = True
        Me.radGenderFemale.Location = New System.Drawing.Point(3, 16)
        Me.radGenderFemale.Name = "radGenderFemale"
        Me.radGenderFemale.Size = New System.Drawing.Size(59, 17)
        Me.radGenderFemale.TabIndex = 0
        Me.radGenderFemale.Text = "Female"
        Me.radGenderFemale.UseVisualStyleBackColor = True
        '
        'grpSeeking
        '
        Me.grpSeeking.Controls.Add(Me.radSeekingMale)
        Me.grpSeeking.Controls.Add(Me.radSeekingFemale)
        Me.grpSeeking.Location = New System.Drawing.Point(153, 330)
        Me.grpSeeking.Name = "grpSeeking"
        Me.grpSeeking.Size = New System.Drawing.Size(121, 34)
        Me.grpSeeking.TabIndex = 15
        Me.grpSeeking.TabStop = False
        '
        'radSeekingMale
        '
        Me.radSeekingMale.AutoSize = True
        Me.radSeekingMale.Location = New System.Drawing.Point(64, 16)
        Me.radSeekingMale.Name = "radSeekingMale"
        Me.radSeekingMale.Size = New System.Drawing.Size(48, 17)
        Me.radSeekingMale.TabIndex = 1
        Me.radSeekingMale.Text = "Male"
        Me.radSeekingMale.UseVisualStyleBackColor = True
        '
        'radSeekingFemale
        '
        Me.radSeekingFemale.AutoSize = True
        Me.radSeekingFemale.Checked = True
        Me.radSeekingFemale.Location = New System.Drawing.Point(3, 16)
        Me.radSeekingFemale.Name = "radSeekingFemale"
        Me.radSeekingFemale.Size = New System.Drawing.Size(59, 17)
        Me.radSeekingFemale.TabIndex = 0
        Me.radSeekingFemale.TabStop = True
        Me.radSeekingFemale.Text = "Female"
        Me.radSeekingFemale.UseVisualStyleBackColor = True
        '
        'lblFavouriteGeneres
        '
        Me.lblFavouriteGeneres.AutoSize = True
        Me.lblFavouriteGeneres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFavouriteGeneres.Location = New System.Drawing.Point(27, 16)
        Me.lblFavouriteGeneres.Name = "lblFavouriteGeneres"
        Me.lblFavouriteGeneres.Size = New System.Drawing.Size(136, 16)
        Me.lblFavouriteGeneres.TabIndex = 0
        Me.lblFavouriteGeneres.Text = "Favourite Generes"
        '
        'clbFavouriteGenres
        '
        Me.clbFavouriteGenres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbFavouriteGenres.FormattingEnabled = True
        Me.clbFavouriteGenres.Items.AddRange(New Object() {"Comedy", "Drama", "Romance", "Action", "Horror", "Family", "SciFi"})
        Me.clbFavouriteGenres.Location = New System.Drawing.Point(20, 61)
        Me.clbFavouriteGenres.Name = "clbFavouriteGenres"
        Me.clbFavouriteGenres.Size = New System.Drawing.Size(120, 140)
        Me.clbFavouriteGenres.TabIndex = 1
        '
        'grpFavouriteGenres
        '
        Me.grpFavouriteGenres.Controls.Add(Me.clbFavouriteGenres)
        Me.grpFavouriteGenres.Controls.Add(Me.lblFavouriteGeneres)
        Me.grpFavouriteGenres.Location = New System.Drawing.Point(297, 102)
        Me.grpFavouriteGenres.Name = "grpFavouriteGenres"
        Me.grpFavouriteGenres.Size = New System.Drawing.Size(200, 262)
        Me.grpFavouriteGenres.TabIndex = 16
        Me.grpFavouriteGenres.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(422, 396)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 17
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(336, 396)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 18
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'frmAddMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(509, 446)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.grpFavouriteGenres)
        Me.Controls.Add(Me.grpSeeking)
        Me.Controls.Add(Me.grpGender)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtAgeDifference)
        Me.Controls.Add(Me.txtPhoneNo)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblSeeking)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblAgeDifference)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblPhoneNo)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.lblAssName2)
        Me.Controls.Add(Me.lblAssName1)
        Me.Name = "frmAddMembers"
        Me.Text = "Add Members"
        Me.grpGender.ResumeLayout(False)
        Me.grpGender.PerformLayout()
        Me.grpSeeking.ResumeLayout(False)
        Me.grpSeeking.PerformLayout()
        Me.grpFavouriteGenres.ResumeLayout(False)
        Me.grpFavouriteGenres.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAssName1 As System.Windows.Forms.Label
    Friend WithEvents lblAssName2 As System.Windows.Forms.Label
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblPhoneNo As System.Windows.Forms.Label
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents lblAgeDifference As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblSeeking As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtPhoneNo As System.Windows.Forms.TextBox
    Friend WithEvents txtAgeDifference As System.Windows.Forms.TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents grpGender As System.Windows.Forms.GroupBox
    Friend WithEvents radGenderMale As System.Windows.Forms.RadioButton
    Friend WithEvents radGenderFemale As System.Windows.Forms.RadioButton
    Friend WithEvents grpSeeking As System.Windows.Forms.GroupBox
    Friend WithEvents radSeekingMale As System.Windows.Forms.RadioButton
    Friend WithEvents radSeekingFemale As System.Windows.Forms.RadioButton
    Friend WithEvents lblFavouriteGeneres As System.Windows.Forms.Label
    Friend WithEvents clbFavouriteGenres As System.Windows.Forms.CheckedListBox
    Friend WithEvents grpFavouriteGenres As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
End Class
