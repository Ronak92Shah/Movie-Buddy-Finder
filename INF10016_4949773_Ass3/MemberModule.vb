Module MemberModule




    Public vFileName As String = "C:\temp\Members.txt"

    Public Class Member
        Public vstrMemberID As String
        Public chrGender As Char
        Public vstrName As String
        Public vstrPhone As String
        Public vintAge As Integer
        Public chrSeeksGender As Char
        Public vintSeeksAgeDifference As Integer
        Public chrLikesComedy As Char
        Public chrLikesDrama As Char
        Public chrLikesRomance As Char
        Public chrLikesAction As Char
        Public chrLikesHorror As Char
        Public chrLikesFamily As Char
        Public chrLikesSciFi As Char

        Public Function favouritecount(ByVal vclsMember As Member) As Integer
            Dim vincount As Integer = 0

            If vclsMember.chrLikesAction = "T" Then
                vincount = vincount + 1
            End If
            If vclsMember.chrLikesComedy = "T" Then
                vincount = vincount + 1
            End If
            If vclsMember.chrLikesDrama = "T" Then
                vincount = vincount + 1
            End If
            If vclsMember.chrLikesFamily = "T" Then
                vincount = vincount + 1
            End If
            If vclsMember.chrLikesHorror = "T" Then
                vincount = vincount + 1
            End If
            If vclsMember.chrLikesRomance = "T" Then
                vincount = vincount + 1
            End If
            If vclsMember.chrLikesSciFi = "T" Then
                vincount = vincount + 1
            End If
            Return vincount
        End Function



    End Class




End Module
