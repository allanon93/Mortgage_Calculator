<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        lblTitle = New Label()
        lblPrice = New Label()
        txtPrice = New TextBox()
        txtDownPayment = New TextBox()
        lblDownPayment = New Label()
        txtInterest = New TextBox()
        lblInterestRate = New Label()
        btnCalculate = New Button()
        lblTaxMillage = New Label()
        lblInsurance = New Label()
        lblYears = New Label()
        txtYears = New TextBox()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitle.Location = New Point(121, 32)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(251, 32)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Mortgage Calculator"
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Location = New Point(167, 97)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(72, 15)
        lblPrice.TabIndex = 1
        lblPrice.Text = "Home Price:"
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(245, 94)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(100, 23)
        txtPrice.TabIndex = 2
        ' 
        ' txtDownPayment
        ' 
        txtDownPayment.Location = New Point(245, 123)
        txtDownPayment.Name = "txtDownPayment"
        txtDownPayment.Size = New Size(100, 23)
        txtDownPayment.TabIndex = 4
        ' 
        ' lblDownPayment
        ' 
        lblDownPayment.AutoSize = True
        lblDownPayment.Location = New Point(148, 126)
        lblDownPayment.Name = "lblDownPayment"
        lblDownPayment.Size = New Size(91, 15)
        lblDownPayment.TabIndex = 3
        lblDownPayment.Text = "Down Payment:"
        ' 
        ' txtInterest
        ' 
        txtInterest.Location = New Point(245, 152)
        txtInterest.Name = "txtInterest"
        txtInterest.Size = New Size(100, 23)
        txtInterest.TabIndex = 6
        ' 
        ' lblInterestRate
        ' 
        lblInterestRate.AutoSize = True
        lblInterestRate.Location = New Point(164, 155)
        lblInterestRate.Name = "lblInterestRate"
        lblInterestRate.Size = New Size(75, 15)
        lblInterestRate.TabIndex = 5
        lblInterestRate.Text = "Interest Rate:"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(209, 286)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(75, 23)
        btnCalculate.TabIndex = 10
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' lblTaxMillage
        ' 
        lblTaxMillage.AutoSize = True
        lblTaxMillage.Location = New Point(144, 225)
        lblTaxMillage.Name = "lblTaxMillage"
        lblTaxMillage.Size = New Size(210, 15)
        lblTaxMillage.TabIndex = 9
        lblTaxMillage.Text = "Estimated Tax Millage: $0.83 per $1,000"
        lblTaxMillage.UseMnemonic = False
        ' 
        ' lblInsurance
        ' 
        lblInsurance.AutoSize = True
        lblInsurance.Location = New Point(132, 249)
        lblInsurance.Name = "lblInsurance"
        lblInsurance.Size = New Size(229, 15)
        lblInsurance.TabIndex = 11
        lblInsurance.Text = "Estimated Insurance Cost: $3.50 per $1,000"
        ' 
        ' lblYears
        ' 
        lblYears.AutoSize = True
        lblYears.Location = New Point(202, 184)
        lblYears.Name = "lblYears"
        lblYears.Size = New Size(37, 15)
        lblYears.TabIndex = 7
        lblYears.Text = "Years:"
        ' 
        ' txtYears
        ' 
        txtYears.Location = New Point(245, 181)
        txtYears.Name = "txtYears"
        txtYears.Size = New Size(100, 23)
        txtYears.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(493, 341)
        Controls.Add(txtYears)
        Controls.Add(lblYears)
        Controls.Add(lblInsurance)
        Controls.Add(lblTaxMillage)
        Controls.Add(btnCalculate)
        Controls.Add(txtInterest)
        Controls.Add(lblInterestRate)
        Controls.Add(txtDownPayment)
        Controls.Add(lblDownPayment)
        Controls.Add(txtPrice)
        Controls.Add(lblPrice)
        Controls.Add(lblTitle)
        Name = "Form1"
        Text = "Mortgage Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtDownPayment As TextBox
    Friend WithEvents lblDownPayment As Label
    Friend WithEvents txtInterest As TextBox
    Friend WithEvents lblInterestRate As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblTaxMillage As Label
    Friend WithEvents lblInsurance As Label
    Friend WithEvents lblYears As Label
    Friend WithEvents txtYears As TextBox
End Class
