<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHelloUser
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFN = New System.Windows.Forms.TextBox()
        Me.txtLN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnClickMe = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(22, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name:"
        '
        'txtFN
        '
        Me.txtFN.Location = New System.Drawing.Point(122, 17)
        Me.txtFN.Name = "txtFN"
        Me.txtFN.Size = New System.Drawing.Size(115, 23)
        Me.txtFN.TabIndex = 1
        Me.txtFN.Text = "John"
        '
        'txtLN
        '
        Me.txtLN.Location = New System.Drawing.Point(122, 46)
        Me.txtLN.Name = "txtLN"
        Me.txtLN.Size = New System.Drawing.Size(115, 23)
        Me.txtLN.TabIndex = 3
        Me.txtLN.Text = "Doe"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(22, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Last Name:"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(122, 75)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(115, 23)
        Me.txtAge.TabIndex = 4
        Me.txtAge.Text = "22"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(22, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Age:"
        '
        'lblMessage
        '
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMessage.Location = New System.Drawing.Point(22, 112)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(215, 44)
        Me.lblMessage.TabIndex = 6
        '
        'btnClickMe
        '
        Me.btnClickMe.Location = New System.Drawing.Point(12, 168)
        Me.btnClickMe.Name = "btnClickMe"
        Me.btnClickMe.Size = New System.Drawing.Size(75, 23)
        Me.btnClickMe.TabIndex = 7
        Me.btnClickMe.Text = "&Click Me"
        Me.btnClickMe.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(93, 168)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(174, 168)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmHelloUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(261, 203)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnClickMe)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtLN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFN)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmHelloUser"
        Me.Text = "Click Me"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFN As TextBox
    Friend WithEvents txtLN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents btnClickMe As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
End Class
