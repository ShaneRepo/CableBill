<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.radBusiness = New System.Windows.Forms.RadioButton()
        Me.radResidential = New System.Windows.Forms.RadioButton()
        Me.lblTotalDisplay = New System.Windows.Forms.Label()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstPremium = New System.Windows.Forms.ListBox()
        Me.lstConnect = New System.Windows.Forms.ListBox()
        Me.lblPreDisplay = New System.Windows.Forms.Label()
        Me.lblConnDisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'radBusiness
        '
        Me.radBusiness.AutoSize = True
        Me.radBusiness.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBusiness.Location = New System.Drawing.Point(23, 35)
        Me.radBusiness.Name = "radBusiness"
        Me.radBusiness.Size = New System.Drawing.Size(75, 21)
        Me.radBusiness.TabIndex = 4
        Me.radBusiness.TabStop = True
        Me.radBusiness.Text = "&Business"
        Me.radBusiness.UseVisualStyleBackColor = True
        '
        'radResidential
        '
        Me.radResidential.AutoSize = True
        Me.radResidential.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radResidential.Location = New System.Drawing.Point(23, 71)
        Me.radResidential.Name = "radResidential"
        Me.radResidential.Size = New System.Drawing.Size(89, 21)
        Me.radResidential.TabIndex = 5
        Me.radResidential.TabStop = True
        Me.radResidential.Text = "&Residential"
        Me.radResidential.UseVisualStyleBackColor = True
        '
        'lblTotalDisplay
        '
        Me.lblTotalDisplay.AutoSize = True
        Me.lblTotalDisplay.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDisplay.Location = New System.Drawing.Point(46, 219)
        Me.lblTotalDisplay.Name = "lblTotalDisplay"
        Me.lblTotalDisplay.Size = New System.Drawing.Size(66, 17)
        Me.lblTotalDisplay.TabIndex = 8
        Me.lblTotalDisplay.Text = "Total due:"
        '
        'lblTotalDue
        '
        Me.lblTotalDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalDue.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDue.Location = New System.Drawing.Point(38, 246)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(135, 39)
        Me.lblTotalDue.TabIndex = 9
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(211, 252)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(161, 33)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "Calculate Total &Due"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(418, 252)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(112, 33)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lstPremium
        '
        Me.lstPremium.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPremium.FormattingEnabled = True
        Me.lstPremium.ItemHeight = 17
        Me.lstPremium.Location = New System.Drawing.Point(211, 71)
        Me.lstPremium.Name = "lstPremium"
        Me.lstPremium.Size = New System.Drawing.Size(120, 89)
        Me.lstPremium.TabIndex = 1
        '
        'lstConnect
        '
        Me.lstConnect.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstConnect.FormattingEnabled = True
        Me.lstConnect.ItemHeight = 17
        Me.lstConnect.Location = New System.Drawing.Point(410, 71)
        Me.lstConnect.Name = "lstConnect"
        Me.lstConnect.Size = New System.Drawing.Size(120, 89)
        Me.lstConnect.TabIndex = 3
        '
        'lblPreDisplay
        '
        Me.lblPreDisplay.AutoSize = True
        Me.lblPreDisplay.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreDisplay.Location = New System.Drawing.Point(211, 52)
        Me.lblPreDisplay.Name = "lblPreDisplay"
        Me.lblPreDisplay.Size = New System.Drawing.Size(118, 17)
        Me.lblPreDisplay.TabIndex = 0
        Me.lblPreDisplay.Text = "&Premium Channels:"
        '
        'lblConnDisplay
        '
        Me.lblConnDisplay.AutoSize = True
        Me.lblConnDisplay.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnDisplay.Location = New System.Drawing.Point(410, 51)
        Me.lblConnDisplay.Name = "lblConnDisplay"
        Me.lblConnDisplay.Size = New System.Drawing.Size(82, 17)
        Me.lblConnDisplay.TabIndex = 2
        Me.lblConnDisplay.Text = "&Connections:"
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 369)
        Me.Controls.Add(Me.lblConnDisplay)
        Me.Controls.Add(Me.lblPreDisplay)
        Me.Controls.Add(Me.lstConnect)
        Me.Controls.Add(Me.lstPremium)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblTotalDue)
        Me.Controls.Add(Me.lblTotalDisplay)
        Me.Controls.Add(Me.radResidential)
        Me.Controls.Add(Me.radBusiness)
        Me.Name = "frmMain"
        Me.Text = "Cable Direct"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents radBusiness As System.Windows.Forms.RadioButton
    Friend WithEvents radResidential As System.Windows.Forms.RadioButton
    Friend WithEvents lblTotalDisplay As System.Windows.Forms.Label
    Friend WithEvents lblTotalDue As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lstPremium As System.Windows.Forms.ListBox
    Friend WithEvents lstConnect As System.Windows.Forms.ListBox
    Friend WithEvents lblPreDisplay As System.Windows.Forms.Label
    Friend WithEvents lblConnDisplay As System.Windows.Forms.Label

End Class
