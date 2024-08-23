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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbResidential = New System.Windows.Forms.RadioButton()
        Me.rbCommercial = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbPipeSize = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblTotalConsumption = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBoxPresent = New System.Windows.Forms.TextBox()
        Me.txtBoxPrevious = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblMinCharge = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PaymentDate = New System.Windows.Forms.DateTimePicker()
        Me.ReadingDate = New System.Windows.Forms.DateTimePicker()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.rbResidential)
        Me.GroupBox1.Controls.Add(Me.rbCommercial)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(12, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 125)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(63, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Classification"
        '
        'rbResidential
        '
        Me.rbResidential.AutoSize = True
        Me.rbResidential.Location = New System.Drawing.Point(63, 84)
        Me.rbResidential.Name = "rbResidential"
        Me.rbResidential.Size = New System.Drawing.Size(103, 24)
        Me.rbResidential.TabIndex = 1
        Me.rbResidential.TabStop = True
        Me.rbResidential.Text = "Residential"
        Me.rbResidential.UseVisualStyleBackColor = True
        '
        'rbCommercial
        '
        Me.rbCommercial.AutoSize = True
        Me.rbCommercial.Location = New System.Drawing.Point(63, 54)
        Me.rbCommercial.Name = "rbCommercial"
        Me.rbCommercial.Size = New System.Drawing.Size(110, 24)
        Me.rbCommercial.TabIndex = 0
        Me.rbCommercial.TabStop = True
        Me.rbCommercial.Text = "Commercial"
        Me.rbCommercial.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cbPipeSize)
        Me.GroupBox2.Location = New System.Drawing.Point(268, 85)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(250, 125)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(50, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Select Pipe Size"
        '
        'cbPipeSize
        '
        Me.cbPipeSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPipeSize.FormattingEnabled = True
        Me.cbPipeSize.Items.AddRange(New Object() {"1/2""", "3/4""", "1""", "1 1/2""", "2""", "3""", "4"""})
        Me.cbPipeSize.Location = New System.Drawing.Point(57, 64)
        Me.cbPipeSize.Name = "cbPipeSize"
        Me.cbPipeSize.Size = New System.Drawing.Size(151, 28)
        Me.cbPipeSize.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTotalConsumption)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtBoxPresent)
        Me.GroupBox3.Controls.Add(Me.txtBoxPrevious)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 225)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(250, 206)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'lblTotalConsumption
        '
        Me.lblTotalConsumption.AutoSize = True
        Me.lblTotalConsumption.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTotalConsumption.ForeColor = System.Drawing.Color.Black
        Me.lblTotalConsumption.Location = New System.Drawing.Point(63, 175)
        Me.lblTotalConsumption.Name = "lblTotalConsumption"
        Me.lblTotalConsumption.Size = New System.Drawing.Size(76, 28)
        Me.lblTotalConsumption.TabIndex = 6
        Me.lblTotalConsumption.Text = "--------"
        Me.lblTotalConsumption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTotalConsumption.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(53, 156)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(142, 20)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Total Consumption"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(24, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(206, 28)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Consumption Reading"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Present"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Previous"
        '
        'txtBoxPresent
        '
        Me.txtBoxPresent.Location = New System.Drawing.Point(90, 105)
        Me.txtBoxPresent.Name = "txtBoxPresent"
        Me.txtBoxPresent.PlaceholderText = "Input present reading"
        Me.txtBoxPresent.Size = New System.Drawing.Size(125, 27)
        Me.txtBoxPresent.TabIndex = 1
        Me.txtBoxPresent.Text = "0"
        '
        'txtBoxPrevious
        '
        Me.txtBoxPrevious.Location = New System.Drawing.Point(90, 72)
        Me.txtBoxPrevious.Name = "txtBoxPrevious"
        Me.txtBoxPrevious.PlaceholderText = "Input previous reading"
        Me.txtBoxPrevious.Size = New System.Drawing.Size(125, 27)
        Me.txtBoxPrevious.TabIndex = 0
        Me.txtBoxPrevious.Text = "0"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblMinCharge)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(524, 85)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(250, 125)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'lblMinCharge
        '
        Me.lblMinCharge.AutoSize = True
        Me.lblMinCharge.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblMinCharge.ForeColor = System.Drawing.Color.Brown
        Me.lblMinCharge.Location = New System.Drawing.Point(71, 77)
        Me.lblMinCharge.Name = "lblMinCharge"
        Me.lblMinCharge.Size = New System.Drawing.Size(97, 31)
        Me.lblMinCharge.TabIndex = 1
        Me.lblMinCharge.Text = "Label12"
        Me.lblMinCharge.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MINIMUM CHARGE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(169, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(449, 50)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "WATER BILLING SYSTEM"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Panel1)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.PaymentDate)
        Me.GroupBox5.Controls.Add(Me.ReadingDate)
        Me.GroupBox5.Controls.Add(Me.lblDiscount)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Location = New System.Drawing.Point(268, 225)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(503, 266)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Location = New System.Drawing.Point(231, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 222)
        Me.Panel1.TabIndex = 12
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 134)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(218, 60)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "             5% DIscount " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "if you pay your bills 11-15 days " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "after reading"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(80, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 28)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "NOTICE"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(20, 61)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(210, 60)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "             10% DIscount " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "if you pay your bills 0-10 days " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "after reading"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(24, 203)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(184, 20)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Days after meter reading"
        '
        'PaymentDate
        '
        Me.PaymentDate.Location = New System.Drawing.Point(24, 138)
        Me.PaymentDate.Name = "PaymentDate"
        Me.PaymentDate.Size = New System.Drawing.Size(184, 27)
        Me.PaymentDate.TabIndex = 10
        '
        'ReadingDate
        '
        Me.ReadingDate.Location = New System.Drawing.Point(24, 73)
        Me.ReadingDate.Name = "ReadingDate"
        Me.ReadingDate.Size = New System.Drawing.Size(184, 27)
        Me.ReadingDate.TabIndex = 9
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDiscount.ForeColor = System.Drawing.Color.Black
        Me.lblDiscount.Location = New System.Drawing.Point(67, 226)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(86, 28)
        Me.lblDiscount.TabIndex = 8
        Me.lblDiscount.Text = "Label12"
        Me.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblDiscount.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(60, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 28)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "DISCOUNTS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(57, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 20)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Date of Payment"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(57, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 20)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Date of Reading"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 440)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(129, 51)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(147, 440)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(115, 51)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(789, 511)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Water Billing System"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbResidential As RadioButton
    Friend WithEvents rbCommercial As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbPipeSize As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtBoxPresent As TextBox
    Friend WithEvents txtBoxPrevious As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblMinCharge As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblTotalConsumption As Label
    Friend WithEvents ReadingDate As DateTimePicker
    Friend WithEvents PaymentDate As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel1 As Panel
End Class
