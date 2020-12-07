Imports System.Text.RegularExpressions

Public Class frmTemp



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' Closing both forms if the exit button is clicked so that the program exits entirely
        Me.Close()
        frmMeasure.Close()
        frmData.Close()

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' Declaring "input" variable as double
        Dim input As Double

        ' Converting the value of the input textbox to a double type and attaching it to the "input" variable
        Double.TryParse(txtInput.Text, input)

        ' Checking to see if the input unit has been selected.
        If cmbUnit.Text = "" Then
            MessageBox.Show("Please choose a unit to convert from!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Checking to see if the value entered into the input textbox is not a number
        ' Anything other than a number is not allowed in this area, so an error is thrown as a result
        If txtInput.Text = "" Or IsAlphabet(txtInput.Text) Then
            MessageBox.Show("Please enter a valid temperature", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Checking to see if the output unit has been selected
        If txtInput.Text <> "" And cmbUnit.Text <> "" And 
           rdCelsius.Checked = False And rdFahren.Checked = False Then
            MessageBox.Show("Please select a unit to convert to!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        ' Celsius -> Celsius conversion
        If cmbUnit.Text = "Celsius" And rdCelsius.Checked = True Then
            lblResult.Text = input.ToString() + " ° C = " + input.ToString() + " ° C"
        End If

        ' Fahrenheit -> Fahrenheit conversion
        If cmbUnit.Text = "Fahrenheit" And rdFahren.Checked = True Then
            lblResult.Text = input.ToString() + "° F = " + input.ToString() + " ° F"
        End If

        ' Celsius -> Fahrenheit conversion
        If cmbUnit.Text = "Celsius" And rdFahren.Checked = True Then
            Dim cToF As Double
            cToF = (input * 9/5) + 32
            lblResult.Text = input.ToString() + "° C = " + cToF.ToString() + " ° F"
        End If

        ' Fahrenheit -> Celsius conversion
        If cmbUnit.Text = "Fahrenheit" And rdCelsius.Checked = True Then
            Dim fToC As Double
            fToC = (input - 32) * 5/9
            lblResult.Text = input.ToString() + "° F = " + fToC.ToString() + "° C"
        End If

    End Sub

    ' Function to use when checking if a string is alphabet
    Public Shared Function IsAlphabet(ByVal strToCheck As String) As Boolean
        Dim pattern As Regex = New Regex("[^a-zA]")
        Return Not pattern.IsMatch(strToCheck)
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clearing all of the inputs when the clear button is clicked
        txtInput.Clear()
        cmbUnit.Text = ""
        rdCelsius.Checked = False 
        rdFahren.Checked = False
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnMeasureForm.Click
        frmMeasure.Location = Me.Location

        Me.Hide()
        frmMeasure.Show()
    End Sub

    Private Sub btnDataForm_Click(sender As Object, e As EventArgs) Handles btnDataForm.Click
        frmData.Location = Me.Location

        Me.Hide()
        frmData.Show()
    End Sub

    Private Sub btnTempForm_Click(sender As Object, e As EventArgs) Handles btnTempForm.Click

    End Sub
End Class
