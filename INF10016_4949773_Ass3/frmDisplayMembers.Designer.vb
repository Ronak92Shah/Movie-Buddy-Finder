<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplayMembers
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
        Me.btnDisplayOnlyMales = New System.Windows.Forms.Button()
        Me.btnDisplayAllMembers = New System.Windows.Forms.Button()
        Me.btnDisplayOnlyFemales = New System.Windows.Forms.Button()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAssName1
        '
        Me.lblAssName1.AutoSize = True
        Me.lblAssName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssName1.Location = New System.Drawing.Point(117, 19)
        Me.lblAssName1.Name = "lblAssName1"
        Me.lblAssName1.Size = New System.Drawing.Size(317, 37)
        Me.lblAssName1.TabIndex = 0
        Me.lblAssName1.Text = "Movie Buddy Finder"
        '
        'lblAssName2
        '
        Me.lblAssName2.AutoSize = True
        Me.lblAssName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssName2.Location = New System.Drawing.Point(131, 56)
        Me.lblAssName2.Name = "lblAssName2"
        Me.lblAssName2.Size = New System.Drawing.Size(290, 18)
        Me.lblAssName2.TabIndex = 1
        Me.lblAssName2.Text = "making dreams come true since 2009"
        '
        'btnDisplayOnlyMales
        '
        Me.btnDisplayOnlyMales.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayOnlyMales.Location = New System.Drawing.Point(30, 99)
        Me.btnDisplayOnlyMales.Name = "btnDisplayOnlyMales"
        Me.btnDisplayOnlyMales.Size = New System.Drawing.Size(119, 54)
        Me.btnDisplayOnlyMales.TabIndex = 2
        Me.btnDisplayOnlyMales.Text = "Display Only Males"
        Me.btnDisplayOnlyMales.UseVisualStyleBackColor = True
        '
        'btnDisplayAllMembers
        '
        Me.btnDisplayAllMembers.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayAllMembers.Location = New System.Drawing.Point(210, 99)
        Me.btnDisplayAllMembers.Name = "btnDisplayAllMembers"
        Me.btnDisplayAllMembers.Size = New System.Drawing.Size(113, 54)
        Me.btnDisplayAllMembers.TabIndex = 3
        Me.btnDisplayAllMembers.Text = "Display All Members"
        Me.btnDisplayAllMembers.UseVisualStyleBackColor = True
        '
        'btnDisplayOnlyFemales
        '
        Me.btnDisplayOnlyFemales.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayOnlyFemales.Location = New System.Drawing.Point(367, 99)
        Me.btnDisplayOnlyFemales.Name = "btnDisplayOnlyFemales"
        Me.btnDisplayOnlyFemales.Size = New System.Drawing.Size(124, 54)
        Me.btnDisplayOnlyFemales.TabIndex = 4
        Me.btnDisplayOnlyFemales.Text = "Display Only Female"
        Me.btnDisplayOnlyFemales.UseVisualStyleBackColor = True
        '
        'lstDisplay
        '
        Me.lstDisplay.BackColor = System.Drawing.Color.White
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.Location = New System.Drawing.Point(30, 193)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(461, 212)
        Me.lstDisplay.TabIndex = 5
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(406, 439)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(85, 31)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmDisplayMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(537, 482)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.btnDisplayOnlyFemales)
        Me.Controls.Add(Me.btnDisplayAllMembers)
        Me.Controls.Add(Me.btnDisplayOnlyMales)
        Me.Controls.Add(Me.lblAssName2)
        Me.Controls.Add(Me.lblAssName1)
        Me.Name = "frmDisplayMembers"
        Me.Text = "Display Member"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAssName1 As System.Windows.Forms.Label
    Friend WithEvents lblAssName2 As System.Windows.Forms.Label
    Friend WithEvents btnDisplayOnlyMales As System.Windows.Forms.Button
    Friend WithEvents btnDisplayAllMembers As System.Windows.Forms.Button
    Friend WithEvents btnDisplayOnlyFemales As System.Windows.Forms.Button
    Friend WithEvents lstDisplay As System.Windows.Forms.ListBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
