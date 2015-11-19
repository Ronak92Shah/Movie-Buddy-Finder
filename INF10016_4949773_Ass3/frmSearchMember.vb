Public Class frmSearchMember

    Private Sub btnTask5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTask5.Click

        Call Task5()

    End Sub


    Private Sub btnTask6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTask6.Click

        Call Task6()

    End Sub

    Private Sub btnTask7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTask7.Click

        Call Task7()
    End Sub

    Private Sub btnTask8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTask8.Click

        Call Task8()

    End Sub
    Private Sub btnTask9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTask9.Click

        Call Task9()

    End Sub
    Private Sub btnTask10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTask10.Click

        Call Task10()

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Call CloseForm()

    End Sub

    Private Sub Task5()
        'When Task 5 is Called this Sub is excuted
        If System.IO.File.Exists(vFileName) = True Then
            'If File Exits then only it is excuted
            lstDisplay.Items.Clear()

            Dim vFileName As String = "C:\temp\Members.txt"
            Dim vText As String
            Dim rvSR As New IO.StreamReader(vFileName)
            'Reading from the location
            Dim vstrFirstName As String
            Dim vstrLastName1 As String
            Dim vstrLastName2 As String
            Dim vstrLastName3 As String
            Dim vstrLastName As String
            Dim vstrGender As String
            Dim vstrCalculate As String = ""
            Dim vstrGen As String
            'loop for reading every thing and spliting at required location
            Do While rvSR.Peek <> -1
                vText = rvSR.ReadLine()
                vstrFirstName = vText.Substring(8, 1)
                vstrLastName1 = vText.IndexOf(" ")
                vstrLastName2 = vText.IndexOf(",", (7 + 1))
                vstrLastName3 = vstrLastName2 - vstrLastName1
                vstrLastName = vText.Substring(vstrLastName1, vstrLastName3)
                vstrGen = vText.Substring(6, 1)

                If vstrGen = "M" Then
                    vstrGender = "Male"
                Else
                    vstrGender = "Female"
                End If

                vstrCalculate = vstrFirstName & "." & vstrLastName & "," & vstrGender
                ' to display on listbox
                lstDisplay.Items.Add(vstrCalculate)
            Loop
        Else
            MessageBox.Show("File does not exist")
        End If
    End Sub

    Private Sub Task6()
        'Excuted when Task 6 is called
        If System.IO.File.Exists(vFileName) = True Then
            'If File Exits then only it is excuted
            lstDisplay.Items.Clear()

            Dim vFileName As String = "C:\temp\Members.txt"
            Dim vText As String
            Dim vchrSplit() As Char = {","}
            Dim rvSR As New IO.StreamReader(vFileName)

            Dim vstrDisplay As String = ""

            Dim vstrArrayString(-1) As String

            Do While rvSR.Peek <> -1
                vText = rvSR.ReadLine()
                vstrArrayString = vText.Split(vchrSplit)

                Dim vstrName As String = vstrArrayString(2)
                Dim vstrGender As String = vstrArrayString(1)
                Dim vstrSeeking As String = vstrArrayString(5)

                If vstrGender = "M" Then
                    vstrGender = "Male"
                Else
                    vstrGender = "Female"
                End If

                If vstrSeeking = "M" Then
                    vstrSeeking = "Male"
                Else
                    vstrSeeking = "Female"
                End If

                vstrDisplay = vstrName & " is a " & vstrGender & " seeking a " & vstrSeeking
                lstDisplay.Items.Add(vstrDisplay)
            Loop

        Else
            MessageBox.Show("File does not exist")

        End If

    End Sub

    Private Function ArrayList() As ArrayList
        'creating an arraylist to add the details for each member 

        Dim vchrDelimeter() As Char = {","}
        Dim vstrArrayString(-1) As String
        Dim vstrReadText As String = String.Empty
        Dim valtMemberList As New ArrayList
        If System.IO.File.Exists(vFileName) = True Then
            Dim rvSR As New IO.StreamReader(vFileName)
            Do While rvSR.Peek <> -1
                vstrReadText = rvSR.ReadLine()
                vstrArrayString = vstrReadText.Split(vchrDelimeter)
                Dim vclsMember As New Member
                vclsMember.vstrMemberID = vstrArrayString(0)
                vclsMember.chrGender = vstrArrayString(1)
                vclsMember.vstrName = vstrArrayString(2)
                vclsMember.vstrPhone = vstrArrayString(3)
                vclsMember.vintAge = vstrArrayString(4)
                vclsMember.chrSeeksGender = vstrArrayString(5)
                vclsMember.vintSeeksAgeDifference = vstrArrayString(6)
                vclsMember.chrLikesComedy = vstrArrayString(7)
                vclsMember.chrLikesDrama = vstrArrayString(8)
                vclsMember.chrLikesRomance = vstrArrayString(9)
                vclsMember.chrLikesAction = vstrArrayString(10)
                vclsMember.chrLikesHorror = vstrArrayString(11)
                vclsMember.chrLikesFamily = vstrArrayString(12)
                vclsMember.chrLikesSciFi = vstrArrayString(13)
                valtMemberList.Add(vclsMember)
            Loop
            rvSR.Close()
        Else

            MessageBox.Show("File does not exist")
        End If

        Return valtMemberList

    End Function

    Private Sub Task7()
        'creating a class for each member storing the each member in an arraylist and adding  the name phone and age to a lsit box
        If System.IO.File.Exists(vFileName) = True Then
            'If File Exits then only it is excuted
            lstDisplay.Items.Clear()

            lstDisplay.Items.Clear()
            Dim valtMember As New ArrayList
            valtMember = ArrayList()
            lstDisplay.Items.Add("Name".PadRight(22) & "Phone".PadRight(12) & "Age")
            'looping through the list to display name phone and age of the member
            Dim vIndex As Integer

            For vIndex = 0 To valtMember.Count - 1
                Dim vclsmember As Member
                vclsmember = valtMember.Item(vIndex)
                'to display through listbox
                lstDisplay.Items.Add(vclsmember.vstrName.PadRight(22) & vclsmember.vstrPhone.PadRight(12) & vclsmember.vintAge)
            Next
        Else
            MessageBox.Show("File does not exist")
        End If
    End Sub

    Private Sub Task8()
        'when Task 8 is called
        If System.IO.File.Exists(vFileName) = True Then
            'If File Exits then only it is excuted
            lstDisplay.Items.Clear()

            lstDisplay.Items.Clear()
            Dim valtMember = ArrayList()
            Dim vIndex As Integer
            'Loop for display one by one
            For vIndex = 0 To valtMember.Count - 1
                DisplayMember(valtMember(vIndex))
            Next
        Else
            MessageBox.Show("File does not exist")
        End If

    End Sub

    Private Sub DisplayMember(ByVal vclsMember As Member)
        'Private sub for displaying member through message box
        Dim vstrMessage As String
        Dim vstrRange As String
        Dim vintFavCount As Integer

        vstrRange = vclsMember.vintAge - vclsMember.vintSeeksAgeDifference & " to " _
            & vclsMember.vintAge + vclsMember.vintSeeksAgeDifference

        vintFavCount = vclsMember.favouritecount(vclsMember)

        vstrMessage = "ID: " & vclsMember.vstrMemberID & ControlChars.NewLine _
            & "Name: " & vclsMember.vstrName & ControlChars.NewLine _
            & "Phone: " & vclsMember.vstrPhone & ControlChars.NewLine _
            & "Gender: " & vclsMember.vintAge & ControlChars.NewLine _
            & "Seeks Gender: " & vclsMember.chrGender & ControlChars.NewLine _
            & "Seeks Age Range: " & vstrRange & ControlChars.NewLine _
            & "Favourite Count: " & vintFavCount & ControlChars.NewLine _
            & ControlChars.NewLine & "Member Found"
        'message is being displayed through message box
        MessageBox.Show(vstrMessage)

    End Sub

    Private Sub Task9()
        If System.IO.File.Exists(vFileName) = True Then

            'searching member based o user input memberId
            lstDisplay.Items.Clear()

            Dim vstrEnterId As String = InputBox("Please Enter the Member Id To search")
            Dim vbolInputVlaidate As Boolean
            'calling the function to validate the user input
            vbolInputVlaidate = IdValidation(vstrEnterId)

            If vbolInputVlaidate = True Then
                Dim valtNewMemberList As New ArrayList
                valtNewMemberList = ArrayList()
                For vIndex = 0 To valtNewMemberList.Count - 1
                    Dim vclsNewClass As Member = valtNewMemberList(vIndex)
                    If vclsNewClass.vstrMemberID = vstrEnterId Then
                        DisplayMember(vclsNewClass)
                        Exit Sub

                    End If

                Next

                MessageBox.Show("Member not Found")

                Exit Sub


            End If


        Else

            MessageBox.Show("File does not exist")
        End If
    End Sub

    'validation for id,string is empty or not in rage or large in size

    Private Function IdValidation(ByVal vstrEnterId) As Boolean


        If vstrEnterId = String.Empty Then
            MessageBox.Show("Please enter Member Id to search")
            Return False
            Exit Function
        ElseIf Not IsNumeric(vstrEnterId) Then
            MessageBox.Show("Entered value is not numeric please enter numeric data")
            Return False
            Exit Function
        ElseIf vstrEnterId.Length <> 5 Then
            MessageBox.Show("Member Id must be of 5 Digit")
            Return False
            Exit Function
        End If
        Return True

    End Function

    Private Sub Task10()
        'searching the match for memberId provided by user

        If System.IO.File.Exists(vFileName) = True Then

            lstDisplay.Items.Clear()
            Dim valtMemberList As New ArrayList
            valtMemberList = ArrayList()
            Dim vstrUserInputId As String = InputBox("Please Enter the Member Id To search")
            Dim vbolInputVlaidate As Boolean
            'calling the function for validating the user input
            vbolInputVlaidate = IdValidation(vstrUserInputId)

            If vbolInputVlaidate Then


                Dim vintX As Integer
                Dim vbolFlagcheck As Boolean
                Dim vbolNoMemberId As Boolean = True
                Dim valtNewMemberList As New ArrayList
                valtNewMemberList = ArrayList()
                For vintX = 0 To valtNewMemberList.Count - 1

                    Dim vclsNewClass As Member = valtNewMemberList(vintX)

                    If vclsNewClass.vstrMemberID = vstrUserInputId Then
                        vbolNoMemberId = False
                        Dim vitnFavcountForSeeker As Integer = vclsNewClass.favouritecount(vclsNewClass)
                        Dim vintSeekerUpwardFavCount As Integer = vitnFavcountForSeeker + 2
                        Dim vintSeekerDownwardFavCount As Integer = vitnFavcountForSeeker - 2
                        Dim vintSeekAgeRangeUp As Integer = vclsNewClass.vintAge + vclsNewClass.vintSeeksAgeDifference
                        Dim vintSeekAgeRangeDown As Integer = vclsNewClass.vintAge - vclsNewClass.vintSeeksAgeDifference
                        Dim vintNewCount As Integer
                        For vintNewCount = 0 To valtMemberList.Count - 1
                            Dim vclsNewClassForMatch As Member = valtNewMemberList(vintNewCount)
                            If Not (vclsNewClass.vstrMemberID = vclsNewClassForMatch.vstrMemberID) Then
                                If (vclsNewClass.chrSeeksGender = vclsNewClassForMatch.chrGender) Then
                                    Dim vintMatchAgeRangeUp As Integer = vclsNewClassForMatch.vintAge + vclsNewClass.vintSeeksAgeDifference
                                    Dim vintMatchAgeRangeDown As Integer = vclsNewClassForMatch.vintAge - vclsNewClass.vintSeeksAgeDifference
                                    Dim vitnFavcountForMatch As Integer = vclsNewClassForMatch.favouritecount(vclsNewClassForMatch)

                                    If ((vitnFavcountForMatch >= vintSeekerDownwardFavCount And vitnFavcountForMatch <= vintSeekerUpwardFavCount)) Then

                                        If ((vclsNewClassForMatch.vintAge >= vintSeekAgeRangeDown And vclsNewClassForMatch.vintAge <= vintSeekAgeRangeUp) And
                                        (vclsNewClass.vintAge >= vintMatchAgeRangeDown And vclsNewClass.vintAge <= vintMatchAgeRangeUp)) Then
                                            vbolFlagcheck = True
                                            vbolNoMemberId = False
                                            DisplayMember(vclsNewClassForMatch)

                                        End If
                                    End If

                                End If
                            End If
                        Next
                        If vbolFlagcheck = False Then
                            MessageBox.Show("No match Found")
                        End If
                    End If
                Next
                If vbolNoMemberId = True Then
                    MessageBox.Show("No Member with given Id Found")
                    Exit Sub
                End If

            End If
        Else

            MessageBox.Show("File does not exist")
        End If

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

    Private Sub lstDisplay_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstDisplay.SelectedIndexChanged

    End Sub
End Class