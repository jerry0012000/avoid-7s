'
' Created by SharpDevelop.
' User: Jerry
' Date: 2019/6/27
' Time: 21:22
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Module Program
	Dim Max As Integer
	Dim NumberOfDigit As Integer = 1

	Function SevenContained(ByVal A As Integer) As Boolean
		Dim StrA = CStr(A)
		For i = 1 To StrA.Length
			If Mid(StrA,i,1) = 7 Then
				Return True
			End If
		Next
	End Function
	
	Function SevenRemained(ByVal B As Integer)As Boolean
		If B Mod 7 = 0 Then
			Return True
		Else
			Return False
		End If
	End Function
	
	Sub Main()
		Console.WriteLine("Input a number")
		Max = Console.ReadLine()

		
		For j = 1 To Max
			If Not (SevenContained(j) Or SevenRemained(j)) Then
				Console.WriteLine(j)
			End If
		Next
		
		Console.Write("Press any key to continue . . . ")
		Console.ReadKey(True)
	End Sub
End Module