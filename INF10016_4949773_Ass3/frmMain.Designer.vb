<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnDisplayMembers = New System.Windows.Forms.Button()
        Me.btnAddMembers = New System.Windows.Forms.Button()
        Me.btnSearchMembers = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAssName1
        '
        Me.lblAssName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssName1.Location = New System.Drawing.Point(68, 19)
        Me.lblAssName1.Name = "lblAssName1"
        Me.lblAssName1.Size = New System.Drawing.Size(304, 43)
        Me.lblAssName1.TabIndex = 0
        Me.lblAssName1.Text = "Movie Buddy Finder"
        '
        'lblAssName2
        '
        Me.lblAssName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssName2.Location = New System.Drawing.Point(71, 52)
        Me.lblAssName2.Name = "lblAssName2"
        Me.lblAssName2.Size = New System.Drawing.Size(297, 23)
        Me.lblAssName2.TabIndex = 1
        Me.lblAssName2.Text = "making dreams come true since 2009"
        '
        'btnDisplayMembers
        '
        Me.btnDisplayMembers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayMembers.Location = New System.Drawing.Point(141, 119)
        Me.btnDisplayMembers.Name = "btnDisplayMembers"
        Me.btnDisplayMembers.Size = New System.Drawing.Size(153, 39)
        Me.btnDisplayMembers.TabIndex = 2
        Me.btnDisplayMembers.Text = "Display Members"
        Me.btnDisplayMembers.UseVisualStyleBackColor = True
        '
        'btnAddMembers
        '
        Me.btnAddMembers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMembers.Location = New System.Drawing.Point(141, 173)
        Me.btnAddMembers.Name = "btnAddMembers"
        Me.btnAddMembers.Size = New System.Drawing.Size(153, 39)
        Me.btnAddMembers.TabIndex = 3
        Me.btnAddMembers.Text = "Add a Members"
        Me.btnAddMembers.UseVisualStyleBackColor = True
        '
        'btnSearchMembers
        '
        Me.btnSearchMembers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchMembers.Location = New System.Drawing.Point(141, 235)
        Me.btnSearchMembers.Name = "btnSearchMembers"
        Me.btnSearchMembers.Size = New System.Drawing.Size(153, 39)
        Me.btnSearchMembers.TabIndex = 4
        Me.btnSearchMembers.Text = "Search Member"
        Me.btnSearchMembers.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(141, 298)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(153, 39)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(442, 392)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSearchMembers)
        Me.Controls.Add(Me.btnAddMembers)
        Me.Controls.Add(Me.btnDisplayMembers)
        Me.Controls.Add(Me.lblAssName2)
        Me.Controls.Add(Me.lblAssName1)
        Me.Name = "frmMain"
        Me.Text = "MainMenu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblAssName1 As System.Windows.Forms.Label
    Friend WithEvents lblAssName2 As System.Windows.Forms.Label
    Friend WithEvents btnDisplayMembers As System.Windows.Forms.Button
    Friend WithEvents btnAddMembers As System.Windows.Forms.Button
    Friend WithEvents btnSearchMembers As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
