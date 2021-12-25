<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.nudCodeSet = New System.Windows.Forms.NumericUpDown()
        Me.btnSetCode = New System.Windows.Forms.Button()
        Me.Lbl_btnCode = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudCodeSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.nudCodeSet)
        Me.GroupBox1.Controls.Add(Me.btnSetCode)
        Me.GroupBox1.Location = New System.Drawing.Point(59, 134)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(273, 172)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Set new Code"
        '
        'nudCodeSet
        '
        Me.nudCodeSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCodeSet.Location = New System.Drawing.Point(43, 26)
        Me.nudCodeSet.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudCodeSet.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudCodeSet.Minimum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudCodeSet.Name = "nudCodeSet"
        Me.nudCodeSet.Size = New System.Drawing.Size(188, 30)
        Me.nudCodeSet.TabIndex = 3
        Me.nudCodeSet.Value = New Decimal(New Integer() {10000, 0, 0, 0})
        '
        'btnSetCode
        '
        Me.btnSetCode.Location = New System.Drawing.Point(43, 70)
        Me.btnSetCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSetCode.Name = "btnSetCode"
        Me.btnSetCode.Size = New System.Drawing.Size(188, 84)
        Me.btnSetCode.TabIndex = 4
        Me.btnSetCode.Text = "Set new button code to open plugin"
        Me.btnSetCode.UseVisualStyleBackColor = True
        '
        'Lbl_btnCode
        '
        Me.Lbl_btnCode.AutoSize = True
        Me.Lbl_btnCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_btnCode.Location = New System.Drawing.Point(321, 71)
        Me.Lbl_btnCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_btnCode.Name = "Lbl_btnCode"
        Me.Lbl_btnCode.Size = New System.Drawing.Size(65, 20)
        Me.Lbl_btnCode.TabIndex = 7
        Me.Lbl_btnCode.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(270, 50)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "The current button code " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "assigned to open plugin is:"
        '
        'ConfigForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 348)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Lbl_btnCode)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ConfigForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Config for UC_Engrave"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.nudCodeSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents nudCodeSet As Windows.Forms.NumericUpDown
    Friend WithEvents btnSetCode As Windows.Forms.Button
    Friend WithEvents Lbl_btnCode As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
End Class
