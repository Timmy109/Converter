Public Class frmMeasure
    Private Sub btnTempForm_Click(sender As Object, e As EventArgs)

        frmTemp.Location = Me.Location()
        Me.Hide()
        frmTemp.Show()

    End Sub

    Private Sub btnMeasureForm_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' Defining variables
        Dim input As Double
        Dim output As Double
        Dim comboInput = cmbInput.Text()
        Dim comboOutput = cmbOutput.Text()
        Dim mm = "Millimetres"
        Dim cm = "Centermetres"
        Dim m = "Metres"
        Dim km = "Kilometres"

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

        If comboInput = (mm) And comboOutput = (cm) Then
            txtOutput.Text = input / 10
        End If

        If comboInput = (cm) And comboOutput = (mm) Then
            txtOutput.Text = input * 10
        End If

        If comboInput = (cm) And comboOutput = (m) Then
            txtOutput.Text = input / 100
        End If

        If comboInput = (m) And comboOutput = (cm) Then
            txtOutput.Text = input * 100
        End If

        If comboInput = (km) And comboOutput = (m) Then
            txtOutput.Text = input / 1000
        End If

        If comboInput = (m) And comboOutput = (km) Then
            txtOutput.Text = input * 1000
        End If

        If comboInput = (mm) And comboOutput = (m) Then
            txtOutput.Text = input / 1000
        End If

        If comboInput = (m) And comboOutput = (mm) Then
            txtOutput.Text = input * 1000
        End If

        If comboInput = (cm) And comboOutput = (km) Then
            txtOutput.Text = input / 100000
        End If

        If comboInput = (km) And comboOutput = (cm) Then
            txtOutput.Text = input * 100000
        End If

        If comboInput = (mm) And comboOutput = (km) Then
            txtOutput.Text = input / 1000000
        End If

        If comboInput = (km) And comboOutput = (mm) Then
            txtOutput.Text = input * 1000000
        End If

    End Sub

    Private Sub btnTempForm_Click_1(sender As Object, e As EventArgs) Handles btnTempForm.Click
        frmTemp.Location = Me.Location
        Me.Hide()
        frmTemp.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmTemp.Close()
        frmData.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtInput.Clear()
        txtOutput.Clear()
        cmbInput.Text = ""
        cmbOutput.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnDataForm.Click
        frmData.Location = Me.Location

        Me.Hide()
        frmData.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnMeasureForm.Click

    End Sub
End Class