Public Class frmMain


    Private Sub btnDisplayMembers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayMembers.Click

        Call DisplayMembers()

    End Sub

    Private Sub btnAddMembers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddMembers.Click

        Call AddMembers()

    End Sub

    Private Sub btnSearchMembers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchMembers.Click

        Call SearchMembers()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Call CLoseApplication()

    End Sub

    Private Sub DisplayMembers()
        ' to tranfer to display member form 
        Dim rtvForm As New frmDisplayMembers
        rtvForm.ShowDialog()
        rtvForm = Nothing

    End Sub

    Private Sub AddMembers()
        ' to transfer to add member form
        Dim rtvForm As New frmAddMembers
        rtvForm.ShowDialog()
        rtvForm = Nothing

    End Sub

    Private Sub SearchMembers()
        ' to transfer to search member form
        Dim rtvForm As New frmSearchMember
        rtvForm.ShowDialog()
        rtvForm = Nothing

    End Sub


    Private Sub CLoseApplication()

        ' Validates if the user want to exit the program or not.
        Dim vintClose As DialogResult = MessageBox.Show("Are you sure you want to close this Application ?",
                                                         "Message Box", MessageBoxButtons.YesNo)
        If vintClose = DialogResult.Yes Then
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
