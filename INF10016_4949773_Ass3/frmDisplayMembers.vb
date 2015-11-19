Public Class frmDisplayMembers

    Private Sub btnDisplayAllMembers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayAllMembers.Click

        Call DisplayAllMembers()

    End Sub

    Private Sub btnDisplayOnlyMales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayOnlyMales.Click

        Call DisplayOnlyMales()

    End Sub

    Private Sub btnDisplayOnlyFemales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayOnlyFemales.Click

        Call DisplayOnlyFemale()

    End Sub



    Private Sub DisplayAllMembers()
        ' when all member is to be displayed this sub is excuted
        lstDisplay.Items.Clear()
        Dim vFileName As String = "C:\temp\Members.txt"
        Dim vText As String
        'from the c drive the date is being fetched

        If System.IO.File.Exists(vFileName) Then
            Dim rvSR As New IO.StreamReader(vFileName)
            ' lopp to fetch all the data
            Do While rvSR.Peek <> -1
                vText = rvSR.ReadLine()
                lstDisplay.Items.Add(vText)
            Loop
            rvSR.Close()
        Else
            MessageBox.Show("File does not exist")
        End If

    End Sub

    Private Sub DisplayOnlyMales()
        'when only males are to be displayed then this sub is excuted
        lstDisplay.Items.Clear()
        Dim vFileName As String = "C:\temp\Members.txt"
        Dim vText As String
        ' it fetches data from the giving location
        If System.IO.File.Exists(vFileName) Then
            Dim rvSR As New IO.StreamReader(vFileName)
            'do loop to fetch all the data
            Do While rvSR.Peek <> -1
                vText = rvSR.ReadLine()
                If vText.IndexOf("M") = 6 Then
                    lstDisplay.Items.Add(vText)
                End If
            Loop
            rvSR.Close()
        Else
            MessageBox.Show("File does not exist")
        End If

    End Sub

    Private Sub DisplayOnlyFemale()
        ' when only female is to be displayed this sub is being excuted
        lstDisplay.Items.Clear()
        Dim vFileName As String = "C:\temp\Members.txt"
        'to fetch data from the give location
        Dim vText As String
        If System.IO.File.Exists(vFileName) Then
            Dim rvSR As New IO.StreamReader(vFileName)
            'do loop for diplaying all the data
            Do While rvSR.Peek <> -1
                vText = rvSR.ReadLine()
                If vText.IndexOf("F") = 6 Then
                    lstDisplay.Items.Add(vText)
                End If
            Loop
            rvSR.Close()
        Else
            MessageBox.Show("File does not exist")
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Call CloseForm()

    End Sub

    Private Sub CloseForm()

        ' Validates if the user want to exit the program or not.
        Dim vintClose As DialogResult = MessageBox.Show("Are you sure you want to close this form ?",
                                                         "Message Box", MessageBoxButtons.YesNo)
        If vintClose = DialogResult.Yes Then
            Me.Close()
        Else
            Exit Sub
        End If


    End Sub

End Class