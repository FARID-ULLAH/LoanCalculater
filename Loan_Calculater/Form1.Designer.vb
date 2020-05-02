<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bttnShowPayment = New System.Windows.Forms.Button()
        Me.bttnExit = New System.Windows.Forms.Button()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.chkPayEarly = New System.Windows.Forms.CheckBox()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.DTPick1 = New System.Windows.Forms.DateTimePicker()
        Me.DTPick2 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe MDL2 Assets", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.Label1.Size = New System.Drawing.Size(210, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Loan Calculater"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Loan Amount"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(101, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Interest Rate(Annual)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(101, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "From ( Loan Duration )"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(101, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Monthly Payment"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(101, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Early Payment"
        '
        'bttnShowPayment
        '
        Me.bttnShowPayment.Location = New System.Drawing.Point(12, 338)
        Me.bttnShowPayment.Name = "bttnShowPayment"
        Me.bttnShowPayment.Size = New System.Drawing.Size(88, 34)
        Me.bttnShowPayment.TabIndex = 6
        Me.bttnShowPayment.Text = "Monthly Payment"
        Me.bttnShowPayment.UseVisualStyleBackColor = True
        '
        'bttnExit
        '
        Me.bttnExit.Location = New System.Drawing.Point(367, 338)
        Me.bttnExit.Name = "bttnExit"
        Me.bttnExit.Size = New System.Drawing.Size(79, 34)
        Me.bttnExit.TabIndex = 7
        Me.bttnExit.Text = "Exit"
        Me.bttnExit.UseVisualStyleBackColor = True
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(293, 72)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAmount.Size = New System.Drawing.Size(97, 20)
        Me.txtAmount.TabIndex = 8
        '
        'chkPayEarly
        '
        Me.chkPayEarly.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkPayEarly.Location = New System.Drawing.Point(293, 241)
        Me.chkPayEarly.Name = "chkPayEarly"
        Me.chkPayEarly.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkPayEarly.Size = New System.Drawing.Size(97, 24)
        Me.chkPayEarly.TabIndex = 11
        Me.chkPayEarly.Text = "Early Payment"
        Me.chkPayEarly.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPayEarly.UseVisualStyleBackColor = True
        '
        'txtPayment
        '
        Me.txtPayment.Location = New System.Drawing.Point(293, 280)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.ReadOnly = True
        Me.txtPayment.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPayment.Size = New System.Drawing.Size(97, 20)
        Me.txtPayment.TabIndex = 12
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(293, 107)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRate.Size = New System.Drawing.Size(97, 20)
        Me.txtRate.TabIndex = 9
        '
        'DTPick1
        '
        Me.DTPick1.Location = New System.Drawing.Point(293, 142)
        Me.DTPick1.Name = "DTPick1"
        Me.DTPick1.Size = New System.Drawing.Size(200, 20)
        Me.DTPick1.TabIndex = 13
        '
        'DTPick2
        '
        Me.DTPick2.Location = New System.Drawing.Point(293, 177)
        Me.DTPick2.Name = "DTPick2"
        Me.DTPick2.Size = New System.Drawing.Size(200, 20)
        Me.DTPick2.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(101, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "To ( Loan Duration )"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(102, 219)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Total Loan Duration"
        '
        'txtDuration
        '
        Me.txtDuration.Location = New System.Drawing.Point(293, 211)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.ReadOnly = True
        Me.txtDuration.Size = New System.Drawing.Size(100, 20)
        Me.txtDuration.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 384)
        Me.Controls.Add(Me.txtDuration)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DTPick2)
        Me.Controls.Add(Me.DTPick1)
        Me.Controls.Add(Me.txtPayment)
        Me.Controls.Add(Me.chkPayEarly)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.bttnExit)
        Me.Controls.Add(Me.bttnShowPayment)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Loan Calculater"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents bttnShowPayment As Button
    Friend WithEvents bttnExit As Button
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents chkPayEarly As CheckBox
    Friend WithEvents txtRate As TextBox
    Friend WithEvents DTPick1 As DateTimePicker
    Friend WithEvents DTPick2 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDuration As TextBox
End Class
