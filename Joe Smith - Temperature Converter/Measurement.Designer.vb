<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMeasure
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMeasure))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.cmbOutput = New System.Windows.Forms.ComboBox()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.cmbInput = New System.Windows.Forms.ComboBox()
        Me.btnMeasureForm = New System.Windows.Forms.Button()
        Me.btnTempForm = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDataForm = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnCalculate)
        Me.Panel1.Controls.Add(Me.txtOutput)
        Me.Panel1.Controls.Add(Me.lblOutput)
        Me.Panel1.Controls.Add(Me.lblInput)
        Me.Panel1.Controls.Add(Me.cmbOutput)
        Me.Panel1.Controls.Add(Me.txtInput)
        Me.Panel1.Controls.Add(Me.cmbInput)
        Me.Panel1.Location = New System.Drawing.Point(0, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(316, 208)
        Me.Panel1.TabIndex = 7
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(226, 78)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(78, 42)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = true
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(22, 145)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(172, 20)
        Me.txtOutput.TabIndex = 5
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = true
        Me.lblOutput.Font = New System.Drawing.Font("Consolas", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblOutput.Location = New System.Drawing.Point(18, 123)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(63, 19)
        Me.lblOutput.TabIndex = 4
        Me.lblOutput.Text = "Output"
        '
        'lblInput
        '
        Me.lblInput.AutoSize = true
        Me.lblInput.Font = New System.Drawing.Font("Consolas", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblInput.Location = New System.Drawing.Point(18, 27)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(54, 19)
        Me.lblInput.TabIndex = 3
        Me.lblInput.Text = "Input"
        '
        'cmbOutput
        '
        Me.cmbOutput.FormattingEnabled = true
        Me.cmbOutput.Items.AddRange(New Object() {"Millimetres", "Centimetres", "Metres", "Kilometres"})
        Me.cmbOutput.Location = New System.Drawing.Point(94, 123)
        Me.cmbOutput.Name = "cmbOutput"
        Me.cmbOutput.Size = New System.Drawing.Size(100, 21)
        Me.cmbOutput.TabIndex = 2
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(22, 49)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(172, 20)
        Me.txtInput.TabIndex = 1
        '
        'cmbInput
        '
        Me.cmbInput.FormattingEnabled = true
        Me.cmbInput.Items.AddRange(New Object() {"Millimetres", "Centimetres", "Metres", "Kilometres"})
        Me.cmbInput.Location = New System.Drawing.Point(94, 27)
        Me.cmbInput.Name = "cmbInput"
        Me.cmbInput.Size = New System.Drawing.Size(100, 21)
        Me.cmbInput.TabIndex = 0
        '
        'btnMeasureForm
        '
        Me.btnMeasureForm.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnMeasureForm.FlatAppearance.BorderSize = 0
        Me.btnMeasureForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMeasureForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnMeasureForm.Location = New System.Drawing.Point(107, 0)
        Me.btnMeasureForm.Name = "btnMeasureForm"
        Me.btnMeasureForm.Size = New System.Drawing.Size(105, 59)
        Me.btnMeasureForm.TabIndex = 9
        Me.btnMeasureForm.Text = "Measure"
        Me.btnMeasureForm.UseVisualStyleBackColor = false
        '
        'btnTempForm
        '
        Me.btnTempForm.BackColor = System.Drawing.Color.Azure
        Me.btnTempForm.FlatAppearance.BorderSize = 0
        Me.btnTempForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTempForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnTempForm.Location = New System.Drawing.Point(0, 0)
        Me.btnTempForm.Name = "btnTempForm"
        Me.btnTempForm.Size = New System.Drawing.Size(111, 59)
        Me.btnTempForm.TabIndex = 8
        Me.btnTempForm.Text = "Temp"
        Me.btnTempForm.UseVisualStyleBackColor = false
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(226, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 24)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(226, 141)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(78, 24)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = true
        '
        'btnDataForm
        '
        Me.btnDataForm.BackColor = System.Drawing.Color.Azure
        Me.btnDataForm.FlatAppearance.BorderSize = 0
        Me.btnDataForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDataForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnDataForm.Location = New System.Drawing.Point(211, 0)
        Me.btnDataForm.Name = "btnDataForm"
        Me.btnDataForm.Size = New System.Drawing.Size(105, 59)
        Me.btnDataForm.TabIndex = 10
        Me.btnDataForm.Text = "Data"
        Me.btnDataForm.UseVisualStyleBackColor = false
        '
        'frmMeasure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(316, 265)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnDataForm)
        Me.Controls.Add(Me.btnMeasureForm)
        Me.Controls.Add(Me.btnTempForm)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmMeasure"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Measurement Converter"
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents lblInput As Label
    Friend WithEvents cmbOutput As ComboBox
    Friend WithEvents txtInput As TextBox
    Friend WithEvents cmbInput As ComboBox
    Friend WithEvents btnMeasureForm As Button
    Friend WithEvents btnTempForm As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnDataForm As Button
End Class
