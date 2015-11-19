Public Class frmAddMembers

    Private Sub frmAddMembers_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtId.KeyPress, txtAge.KeyPress, txtAgeDifference.KeyPress, txtPhoneNo.KeyPress


        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmAddMembers_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress

        If (IsNumeric(e.KeyChar)) Then

            e.Handled = True
        End If

    End Sub


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Call Add()

    End Sub

    Private Sub AddMember_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call DefaultCheck()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Call CloseForm()

    End Sub


    Private Sub DefaultCheck()
        ' to check the checkbox while lodaing
        clbFavouriteGenres.SetItemCheckState(0, CheckState.Checked)

        clbFavouriteGenres.SetItemCheckState(3, CheckState.Checked)

        clbFavouriteGenres.SetItemCheckState(4, CheckState.Checked)

        clbFavouriteGenres.SetItemCheckState(6, CheckState.Checked)

    End Sub

    Private Sub Add()
        'This fuction adds the valid data 

        If txtId.Text = String.Empty Then
            MessageBox.Show("Enter your Id No.")
            Exit Sub

        ElseIf txtId.TextLength <> 5 Then
            MessageBox.Show("ID's Length should be 5")
            Exit Sub
        End If


        Dim vbolFlag As Boolean
        Dim vintCalculate As String

        'to calculayted the digit
        vintCalculate = CalculateCheckDigit(vbolFlag)



        If vintCalculate = False Then
            MessageBox.Show("ID is not Valid")
            Exit Sub

        End If

        ' to check whether id number is taken or not
        Dim vFileName As String = "C:\temp\Members.txt"
        Dim vText As String
        Dim rvSR As New IO.StreamReader(vFileName)
        'To read the file from the given location

        Do While rvSR.Peek <> -1
            vText = rvSR.ReadLine()


            If vText.Substring(0, 5) = txtId.Text Then
                MessageBox.Show("ID Number is Taken Please try Another one")
                rvSR.Close()
                Exit Sub
            End If

        Loop
        rvSR.Close()

        'Dim vintCalculate As Integer

        'vintCalculate = CalculateCheckDigit(txtId)


        ' Dim vintCount As Integer
        Dim rvSW As New IO.StreamWriter(vFileName, True)


        'to validate the name 


        If txtName.Text = String.Empty Then
            MessageBox.Show("Enter the Name")
            rvSW.Close()
            Exit Sub

        ElseIf txtName.TextLength < 2 Or txtName.TextLength > 30 Then
            MessageBox.Show("Name should have 2 to 30 Characters")
            rvSW.Close()
            Exit Sub

        End If

        'validate the phone no

        If txtPhoneNo.Text = String.Empty Then
            MessageBox.Show("Enter the Phone Number")
            rvSW.Close()
            Exit Sub
        ElseIf txtPhoneNo.TextLength < 8 Or txtPhoneNo.TextLength > 10 Then
            MessageBox.Show("Phone No Entered is not Valid, Should be of 8 to 10 characters")
            rvSW.Close()
            Exit Sub

        End If

        'validate the age

        If txtAge.Text = String.Empty Then
            MessageBox.Show("Enter the Age")
            rvSW.Close()
            Exit Sub
        ElseIf txtAge.Text < 18 Or txtAge.Text > 99 Then
            MessageBox.Show("Age should be between 18 to 99")
            rvSW.Close()
            Exit Sub

        End If

        'validate the gender

        If radGenderFemale.Checked = False And radGenderMale.Checked = False Then
            MessageBox.Show("Please Select the Gender")
            rvSW.Close()
            Exit Sub
        End If

        If radSeekingFemale.Checked = False And radSeekingMale.Checked = False Then
            MessageBox.Show("Please Select the Seeking Gender")
            rvSW.Close()
            Exit Sub
        End If

        'validate the age difference

        If txtAgeDifference.Text = String.Empty Then
            MessageBox.Show("Enter the Age Difference")
            rvSW.Close()
            Exit Sub
        ElseIf txtAgeDifference.Text < 0 Or txtAgeDifference.Text > 99 Then
            MessageBox.Show("Age Difference should be between 0 to 99 ")
            rvSW.Close()
            Exit Sub

        End If

        Dim vstrGender As String
        Dim vstrSeeking As String
        ' validating the seeking gender
        If (radGenderFemale.Checked = True) Then
            vstrGender = "F"
        Else
            vstrGender = "M"
        End If

        If (radSeekingFemale.Checked = True) Then
            vstrSeeking = "F"
        Else
            vstrSeeking = "M"

        End If
        ' validating all the check box 

        Dim vintcountchkbox As Integer = 0

        Dim vstrchkboxVal As String = ""

        For vintcountchkbox = 0 To clbFavouriteGenres.Items.Count - 1

            If (clbFavouriteGenres.GetItemChecked(vintcountchkbox)) Then

                vstrchkboxVal += "," & "T"
            Else
                vstrchkboxVal += "," & "F"

            End If

        Next
        rvSW.WriteLine()

        rvSW.Write(txtId.Text & "," & vstrGender & "," & txtName.Text & "," & txtPhoneNo.Text & "," & txtAge.Text & "," & vstrSeeking & "," & txtAgeDifference.Text & vstrchkboxVal)

        rvSW.Close()

    End Sub

    Private Function CalculateCheckDigit(ByVal vbolFlag As Boolean) As Boolean
        ' to calculate the digit
        Dim vintA As Integer
        Dim vintB As Integer
        Dim vintC As Integer
        Dim vintD As String
        Dim vstrValue As String = txtId.Text
        vintA = vstrValue.Substring(0, 1) * 3
        vintB = vstrValue.Substring(2, 1) * 7
        vintC = vintA + vintB
        vintD = vintC + vstrValue.Substring(1, 1) + vstrValue.Substring(3, 1)

        Dim vintE As Integer
        Dim vIndex As Integer

        Do Until vintD.Length = 1
            vintE = 0
            For vIndex = 0 To vintD.Length - 1

                vintE = vintE + vintD.Substring(vIndex, 1)

            Next

            vintD = vintE

        Loop

        If (vintD = vstrValue.Substring(4, 1)) Then
            vbolFlag = True
        Else
            vbolFlag = False
        End If
        'returing the calculated digit through boolean
        Return vbolFlag
    End Function




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