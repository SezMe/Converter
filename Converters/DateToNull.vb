Imports System.Globalization

Public Class DateToNull

	Implements IValueConverter

	Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert
		Dim val As Date? = CDate(value)
		Return If(val > #1/1/1900#, val, Nothing)
	End Function
	Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
		If IsDate(value) Then
			Dim val As Date = CDate(value)
			Return If(val > #1/1/1900#, val, Nothing)
		Else
			Return Nothing
		End If
	End Function

End Class