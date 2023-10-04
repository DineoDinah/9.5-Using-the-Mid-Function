Public Class Form1
	Private Sub BtnShow_Click(sender As Object, e As EventArgs) Handles BtnShow.Click
		Dim myPhrase As String
		Dim LblPhrase
		Dim LblExtract
		myPhrase = InputBox("Enter your phrase")

		LblPhrase = myPhrase

		LblExtract = MsgBox(Mid(myPhrase, 2, 6)) ' the starting position is 2 , then we extract 6 characters iclusing the space

	End Sub
End Class
