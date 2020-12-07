<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTemp))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.grpBox2 = New System.Windows.Forms.GroupBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpBox1 = New System.Windows.Forms.GroupBox()
        Me.rdFahren = New System.Windows.Forms.RadioButton()
        Me.rdCelsius = New System.Windows.Forms.RadioButton()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDataForm = New System.Windows.Forms.Button()
        Me.btnMeasureForm = New System.Windows.Forms.Button()
        Me.btnTempForm = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout
        Me.grpBox2.SuspendLayout
        Me.grpBox1.SuspendLayout
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnCalculate)
        Me.Panel1.Controls.Add(Me.grpBox2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.grpBox1)
        Me.Panel1.Controls.Add(Me.cmbUnit)
        Me.Panel1.Controls.Add(Me.txtInput)
        Me.Panel1.Location = New System.Drawing.Point(0, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 212)
        Me.Panel1.TabIndex = 3
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(191, 117)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = true
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(191, 60)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = true
        '
        'grpBox2
        '
        Me.grpBox2.Controls.Add(Me.lblResult)
        Me.grpBox2.Location = New System.Drawing.Point(28, 147)
        Me.grpBox2.Name = "grpBox2"
        Me.grpBox2.Size = New System.Drawing.Size(264, 38)
        Me.grpBox2.TabIndex = 6
        Me.grpBox2.TabStop = false
        '
        'lblResult
        '
        Me.lblResult.AutoSize = true
        Me.lblResult.Location = New System.Drawing.Point(6, 16)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(140, 13)
        Me.lblResult.TabIndex = 0
        Me.lblResult.Text = "Result will be displayed here"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(22, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Input:"
        '
        'grpBox1
        '
        Me.grpBox1.Controls.Add(Me.rdFahren)
        Me.grpBox1.Controls.Add(Me.rdCelsius)
        Me.grpBox1.Location = New System.Drawing.Point(28, 60)
        Me.grpBox1.Name = "grpBox1"
        Me.grpBox1.Size = New System.Drawing.Size(133, 80)
        Me.grpBox1.TabIndex = 4
        Me.grpBox1.TabStop = false
        Me.grpBox1.Text = "Convert to:"
        '
        'rdFahren
        '
        Me.rdFahren.AutoSize = true
        Me.rdFahren.Location = New System.Drawing.Point(24, 48)
        Me.rdFahren.Name = "rdFahren"
        Me.rdFahren.Size = New System.Drawing.Size(75, 17)
        Me.rdFahren.TabIndex = 1
        Me.rdFahren.TabStop = true
        Me.rdFahren.Text = "Fahrenheit"
        Me.rdFahren.UseVisualStyleBackColor = true
        '
        'rdCelsius
        '
        Me.rdCelsius.AutoSize = true
        Me.rdCelsius.Location = New System.Drawing.Point(24, 25)
        Me.rdCelsius.Name = "rdCelsius"
        Me.rdCelsius.Size = New System.Drawing.Size(58, 17)
        Me.rdCelsius.TabIndex = 0
        Me.rdCelsius.TabStop = true
        Me.rdCelsius.Text = "Celsius"
        Me.rdCelsius.UseVisualStyleBackColor = true
        '
        'cmbUnit
        '
        Me.cmbUnit.FormattingEnabled = true
        Me.cmbUnit.Items.AddRange(New Object() {"Celsius", "Fahrenheit"})
        Me.cmbUnit.Location = New System.Drawing.Point(191, 17)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(75, 21)
        Me.cmbUnit.TabIndex = 2
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(61, 17)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 20)
        Me.txtInput.TabIndex = 0
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(191, 89)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = true
        '
        'btnDataForm
        '
        Me.btnDataForm.BackColor = System.Drawing.Color.Azure
        Me.btnDataForm.FlatAppearance.BorderSize = 0
        Me.btnDataForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDataForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnDataForm.Location = New System.Drawing.Point(208, -8)
        Me.btnDataForm.Name = "btnDataForm"
        Me.btnDataForm.Size = New System.Drawing.Size(105, 76)
        Me.btnDataForm.TabIndex = 13
        Me.btnDataForm.Text = "Data"
        Me.btnDataForm.UseVisualStyleBackColor = false
        '
        'btnMeasureForm
        '
        Me.btnMeasureForm.BackColor = System.Drawing.Color.Azure
        Me.btnMeasureForm.FlatAppearance.BorderSize = 0
        Me.btnMeasureForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMeasureForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnMeasureForm.Location = New System.Drawing.Point(106, -8)
        Me.btnMeasureForm.Name = "btnMeasureForm"
        Me.btnMeasureForm.Size = New System.Drawing.Size(105, 76)
        Me.btnMeasureForm.TabIndex = 12
        Me.btnMeasureForm.Text = "Measure"
        Me.btnMeasureForm.UseVisualStyleBackColor = false
        '
        'btnTempForm
        '
        Me.btnTempForm.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnTempForm.FlatAppearance.BorderSize = 0
        Me.btnTempForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTempForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnTempForm.Location = New System.Drawing.Point(-1, -8)
        Me.btnTempForm.Name = "btnTempForm"
        Me.btnTempForm.Size = New System.Drawing.Size(111, 76)
        Me.btnTempForm.TabIndex = 11
        Me.btnTempForm.Text = "Temp"
        Me.btnTempForm.UseVisualStyleBackColor = false
        '
        'frmTemp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(316, 265)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnMeasureForm)
        Me.Controls.Add(Me.btnTempForm)
        Me.Controls.Add(Me.btnDataForm)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmTemp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Temperature Converter"
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.grpBox2.ResumeLayout(false)
        Me.grpBox2.PerformLayout
        Me.grpBox1.ResumeLayout(false)
        Me.grpBox1.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents grpBox1 As GroupBox
    Friend WithEvents rdFahren As RadioButton
    Friend WithEvents rdCelsius As RadioButton
    Friend WithEvents cmbUnit As ComboBox
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents grpBox2 As GroupBox
    Friend WithEvents lblResult As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDataForm As Button
    Friend WithEvents btnMeasureForm As Button
    Friend WithEvents btnTempForm As Button
End Class
