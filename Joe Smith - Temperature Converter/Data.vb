Public Class frmData
    Private Sub btnTempForm_Click(sender As Object, e As EventArgs) Handles btnTempForm.Click
        frmTemp.Location = Me.Location
        Me.Hide()
        frmTemp.Show()
    End Sub

    Private Sub btnMeasure_Click(sender As Object, e As EventArgs) Handles btnMeasure.Click
        frmMeasure.Location = Me.Location
        Me.Hide()
        frmMeasure.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInput.Clear()
        txtOutput.Clear()
        cmbInput.Text = Nothing
        cmbOutput.Text = Nothing
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmMeasure.Close()
        frmTemp.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' Defining variables
        Dim input As Double
        Dim output As Double
        Dim comboInput = cmbInput.Text()
        Dim comboOutput = cmbOutput.Text()
        Dim b = "Bytes"
        Dim kb = "Kilobytes"
        Dim mb = "Megabytes"
        Dim gb = "Gigabytes"

        ' Converting the string to a double data type and setting the text box to the correct variables
        Double.TryParse(txtInput.Text, input)
        Double.TryParse(txtOutput.Text, output)

        If IsNumeric(input) = False Then
            MessageBox.Show("You did not enter a number to convert!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If comboInput = comboOutput Then
            txtOutput.Text = input
        End If

        If comboInput = (b) And comboOutput = (kb) Then
            txtOutput.Text = input / 1000
        End If

        If comboInput = (kb) And comboOutput = (b) Then
            txtOutput.Text = input * 1000
        End If

        If comboInput = (kb) And comboOutput = (mb) Then
            txtOutput.Text = input / 1000
        End If

        If comboInput = (mb) And comboOutput = (kb) Then
            txtOutput.Text = input * 1000
        End If

        If comboInput = (mb) And comboOutput = (gb) Then
            txtOutput.Text = input / 1000
        End If

        If comboInput = (gb) And comboOutput = (mb) Then
            txtOutput.Text = input * 1000
        End If

        If comboInput = (b) And comboOutput = (mb) Then
            txtOutput.Text = input / 1000000
        End If

        If comboInput = (mb) And comboOutput = (b) Then
            txtOutput.Text = input * 1000000
        End If

        If comboInput = (b) And comboOutput = (gb) Then
            txtOutput.Text = input / 1e+9
        End If

        If comboInput = (gb) And comboOutput = (b) Then
            txtOutput.Text = input * 1e+9
        End If

        If comboInput = (kb) And comboOutput = (gb) Then
            txtOutput.Text = input / 1e+6

        End If

        If comboInput = (gb) And comboOutput = (kb) Then
            txtOutput.Text = input * 1e+6

        End If

    End Sub
End Class