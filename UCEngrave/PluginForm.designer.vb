Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PluginForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PluginForm))
        Me.rtbGCode = New System.Windows.Forms.RichTextBox()
        Me.But_GenPlot = New System.Windows.Forms.Button()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.TB_SafeZ = New System.Windows.Forms.TextBox()
        Me.TB_DepthZ = New System.Windows.Forms.TextBox()
        Me.TB_CutFeed = New System.Windows.Forms.TextBox()
        Me.TB_speed = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TB_Xneg = New System.Windows.Forms.TextBox()
        Me.TB_Xpos = New System.Windows.Forms.TextBox()
        Me.TB_Yneg = New System.Windows.Forms.TextBox()
        Me.TB_Ypos = New System.Windows.Forms.TextBox()
        Me.TB_Xsize = New System.Windows.Forms.TextBox()
        Me.TB_Ysize = New System.Windows.Forms.TextBox()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.TB_XOffset = New System.Windows.Forms.TextBox()
        Me.TB_YOffset = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TB_DropFeed = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.gbOriginBoxes = New System.Windows.Forms.GroupBox()
        Me.rbLL = New System.Windows.Forms.RadioButton()
        Me.rbCenter = New System.Windows.Forms.RadioButton()
        Me.rbLR = New System.Windows.Forms.RadioButton()
        Me.rbTR = New System.Windows.Forms.RadioButton()
        Me.rbTL = New System.Windows.Forms.RadioButton()
        Me.cbShowPoints = New System.Windows.Forms.CheckBox()
        Me.rbWidth = New System.Windows.Forms.RadioButton()
        Me.rbHeight = New System.Windows.Forms.RadioButton()
        Me.tbZSurface = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnFont = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbRightAlign = New System.Windows.Forms.RadioButton()
        Me.rbMidALign = New System.Windows.Forms.RadioButton()
        Me.rbLeftAlign = New System.Windows.Forms.RadioButton()
        Me.rtbText = New System.Windows.Forms.RichTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.nudFontSize = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cbSendCode = New System.Windows.Forms.CheckBox()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.gbOriginBoxes.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.nudFontSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rtbGCode
        '
        Me.rtbGCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbGCode.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbGCode.Location = New System.Drawing.Point(695, 146)
        Me.rtbGCode.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.rtbGCode.Name = "rtbGCode"
        Me.rtbGCode.Size = New System.Drawing.Size(396, 428)
        Me.rtbGCode.TabIndex = 0
        Me.rtbGCode.Text = ""
        Me.rtbGCode.WordWrap = False
        '
        'But_GenPlot
        '
        Me.But_GenPlot.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_GenPlot.Location = New System.Drawing.Point(511, 26)
        Me.But_GenPlot.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.But_GenPlot.Name = "But_GenPlot"
        Me.But_GenPlot.Size = New System.Drawing.Size(156, 58)
        Me.But_GenPlot.TabIndex = 3
        Me.But_GenPlot.Text = "Generate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "G-Code"
        Me.But_GenPlot.UseVisualStyleBackColor = True
        '
        'btnCopy
        '
        Me.btnCopy.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopy.Location = New System.Drawing.Point(853, 584)
        Me.btnCopy.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(112, 48)
        Me.btnCopy.TabIndex = 4
        Me.btnCopy.Text = "Copy to Clipboard"
        Me.btnCopy.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'TB_SafeZ
        '
        Me.TB_SafeZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_SafeZ.Location = New System.Drawing.Point(30, 58)
        Me.TB_SafeZ.Name = "TB_SafeZ"
        Me.TB_SafeZ.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TB_SafeZ.Size = New System.Drawing.Size(134, 26)
        Me.TB_SafeZ.TabIndex = 7
        Me.TB_SafeZ.Text = "0.06"
        Me.ToolTip1.SetToolTip(Me.TB_SafeZ, "Set as the delta height for clearance above the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Z Surface value entered")
        '
        'TB_DepthZ
        '
        Me.TB_DepthZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_DepthZ.Location = New System.Drawing.Point(30, 184)
        Me.TB_DepthZ.Name = "TB_DepthZ"
        Me.TB_DepthZ.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TB_DepthZ.Size = New System.Drawing.Size(134, 26)
        Me.TB_DepthZ.TabIndex = 8
        Me.TB_DepthZ.Text = "-0.078"
        Me.ToolTip1.SetToolTip(Me.TB_DepthZ, "Set as the delta depth for cutting below the Z surface value")
        '
        'TB_CutFeed
        '
        Me.TB_CutFeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CutFeed.Location = New System.Drawing.Point(225, 122)
        Me.TB_CutFeed.Name = "TB_CutFeed"
        Me.TB_CutFeed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TB_CutFeed.Size = New System.Drawing.Size(134, 26)
        Me.TB_CutFeed.TabIndex = 9
        Me.TB_CutFeed.Text = "50.0"
        '
        'TB_speed
        '
        Me.TB_speed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_speed.Location = New System.Drawing.Point(221, 184)
        Me.TB_speed.Name = "TB_speed"
        Me.TB_speed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TB_speed.Size = New System.Drawing.Size(134, 26)
        Me.TB_speed.TabIndex = 10
        Me.TB_speed.Text = "8000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Z Clearance"
        Me.ToolTip1.SetToolTip(Me.Label1, "Set as the delta height for clearance above the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Z Surface value entered")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Z Depth"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(225, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Cut Feed"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(221, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Spindle Speed"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(157, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "<-X+>"
        Me.ToolTip1.SetToolTip(Me.Label6, "Calculated X Bounds (min / max)")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(490, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 16)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "<-Y+>"
        Me.ToolTip1.SetToolTip(Me.Label7, "Calculated Y Bounds (min / max)")
        '
        'TB_Xneg
        '
        Me.TB_Xneg.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Xneg.Location = New System.Drawing.Point(96, 225)
        Me.TB_Xneg.Name = "TB_Xneg"
        Me.TB_Xneg.ReadOnly = True
        Me.TB_Xneg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TB_Xneg.Size = New System.Drawing.Size(94, 22)
        Me.TB_Xneg.TabIndex = 20
        Me.TB_Xneg.Text = "*"
        Me.ToolTip1.SetToolTip(Me.TB_Xneg, "Calculated X Bounds (min / max)")
        '
        'TB_Xpos
        '
        Me.TB_Xpos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Xpos.Location = New System.Drawing.Point(196, 225)
        Me.TB_Xpos.Name = "TB_Xpos"
        Me.TB_Xpos.ReadOnly = True
        Me.TB_Xpos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TB_Xpos.Size = New System.Drawing.Size(94, 22)
        Me.TB_Xpos.TabIndex = 21
        Me.TB_Xpos.Text = "*"
        Me.ToolTip1.SetToolTip(Me.TB_Xpos, "Calculated X Bounds (min / max)")
        '
        'TB_Yneg
        '
        Me.TB_Yneg.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Yneg.Location = New System.Drawing.Point(422, 225)
        Me.TB_Yneg.Name = "TB_Yneg"
        Me.TB_Yneg.ReadOnly = True
        Me.TB_Yneg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TB_Yneg.Size = New System.Drawing.Size(94, 22)
        Me.TB_Yneg.TabIndex = 22
        Me.TB_Yneg.Text = "*"
        Me.ToolTip1.SetToolTip(Me.TB_Yneg, "Calculated Y Bounds (min / max)")
        '
        'TB_Ypos
        '
        Me.TB_Ypos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Ypos.Location = New System.Drawing.Point(522, 225)
        Me.TB_Ypos.Name = "TB_Ypos"
        Me.TB_Ypos.ReadOnly = True
        Me.TB_Ypos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TB_Ypos.Size = New System.Drawing.Size(94, 22)
        Me.TB_Ypos.TabIndex = 23
        Me.TB_Ypos.Text = "*"
        Me.ToolTip1.SetToolTip(Me.TB_Ypos, "Calculated Y Bounds (min / max)")
        '
        'TB_Xsize
        '
        Me.TB_Xsize.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Xsize.Location = New System.Drawing.Point(146, 129)
        Me.TB_Xsize.Name = "TB_Xsize"
        Me.TB_Xsize.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TB_Xsize.Size = New System.Drawing.Size(69, 22)
        Me.TB_Xsize.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.TB_Xsize, "Set size of GCode by X (Width)")
        '
        'TB_Ysize
        '
        Me.TB_Ysize.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Ysize.Location = New System.Drawing.Point(146, 159)
        Me.TB_Ysize.Name = "TB_Ysize"
        Me.TB_Ysize.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TB_Ysize.Size = New System.Drawing.Size(69, 22)
        Me.TB_Ysize.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.TB_Ysize, "Set size of GCode by Y (Height)")
        '
        'ProgressBar
        '
        Me.ProgressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProgressBar.ForeColor = System.Drawing.Color.Green
        Me.ProgressBar.Location = New System.Drawing.Point(8, 644)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(1078, 14)
        Me.ProgressBar.Step = 100
        Me.ProgressBar.TabIndex = 32
        '
        'TB_XOffset
        '
        Me.TB_XOffset.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TB_XOffset.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_XOffset.Location = New System.Drawing.Point(196, 22)
        Me.TB_XOffset.Name = "TB_XOffset"
        Me.TB_XOffset.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TB_XOffset.Size = New System.Drawing.Size(70, 22)
        Me.TB_XOffset.TabIndex = 33
        Me.TB_XOffset.Text = "0"
        Me.ToolTip1.SetToolTip(Me.TB_XOffset, resources.GetString("TB_XOffset.ToolTip"))
        '
        'TB_YOffset
        '
        Me.TB_YOffset.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TB_YOffset.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_YOffset.Location = New System.Drawing.Point(196, 55)
        Me.TB_YOffset.Name = "TB_YOffset"
        Me.TB_YOffset.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TB_YOffset.Size = New System.Drawing.Size(70, 22)
        Me.TB_YOffset.TabIndex = 34
        Me.TB_YOffset.Text = "0"
        Me.ToolTip1.SetToolTip(Me.TB_YOffset, resources.GetString("TB_YOffset.ToolTip"))
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(118, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 16)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "X Offset"
        Me.ToolTip1.SetToolTip(Me.Label12, resources.GetString("Label12.ToolTip"))
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(118, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 16)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Y Offset"
        Me.ToolTip1.SetToolTip(Me.Label13, resources.GetString("Label13.ToolTip"))
        '
        'TB_DropFeed
        '
        Me.TB_DropFeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_DropFeed.Location = New System.Drawing.Point(225, 58)
        Me.TB_DropFeed.Name = "TB_DropFeed"
        Me.TB_DropFeed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TB_DropFeed.Size = New System.Drawing.Size(134, 26)
        Me.TB_DropFeed.TabIndex = 38
        Me.TB_DropFeed.Text = "12.0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(225, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 20)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Plunge Feed"
        '
        'gbOriginBoxes
        '
        Me.gbOriginBoxes.Controls.Add(Me.rbLL)
        Me.gbOriginBoxes.Controls.Add(Me.rbCenter)
        Me.gbOriginBoxes.Controls.Add(Me.rbLR)
        Me.gbOriginBoxes.Controls.Add(Me.rbTR)
        Me.gbOriginBoxes.Controls.Add(Me.rbTL)
        Me.gbOriginBoxes.Controls.Add(Me.Label12)
        Me.gbOriginBoxes.Controls.Add(Me.TB_XOffset)
        Me.gbOriginBoxes.Controls.Add(Me.Label13)
        Me.gbOriginBoxes.Controls.Add(Me.TB_YOffset)
        Me.gbOriginBoxes.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOriginBoxes.Location = New System.Drawing.Point(225, 108)
        Me.gbOriginBoxes.Name = "gbOriginBoxes"
        Me.gbOriginBoxes.Size = New System.Drawing.Size(272, 93)
        Me.gbOriginBoxes.TabIndex = 41
        Me.gbOriginBoxes.TabStop = False
        Me.gbOriginBoxes.Text = "Origin Location:"
        Me.ToolTip1.SetToolTip(Me.gbOriginBoxes, resources.GetString("gbOriginBoxes.ToolTip"))
        '
        'rbLL
        '
        Me.rbLL.AutoSize = True
        Me.rbLL.Location = New System.Drawing.Point(10, 63)
        Me.rbLL.Name = "rbLL"
        Me.rbLL.Size = New System.Drawing.Size(14, 13)
        Me.rbLL.TabIndex = 0
        Me.rbLL.TabStop = True
        Me.ToolTip1.SetToolTip(Me.rbLL, resources.GetString("rbLL.ToolTip"))
        Me.rbLL.UseVisualStyleBackColor = True
        '
        'rbCenter
        '
        Me.rbCenter.AutoSize = True
        Me.rbCenter.Location = New System.Drawing.Point(31, 45)
        Me.rbCenter.Name = "rbCenter"
        Me.rbCenter.Size = New System.Drawing.Size(14, 13)
        Me.rbCenter.TabIndex = 0
        Me.rbCenter.TabStop = True
        Me.ToolTip1.SetToolTip(Me.rbCenter, resources.GetString("rbCenter.ToolTip"))
        Me.rbCenter.UseVisualStyleBackColor = True
        '
        'rbLR
        '
        Me.rbLR.AutoSize = True
        Me.rbLR.Location = New System.Drawing.Point(51, 63)
        Me.rbLR.Name = "rbLR"
        Me.rbLR.Size = New System.Drawing.Size(14, 13)
        Me.rbLR.TabIndex = 0
        Me.rbLR.TabStop = True
        Me.ToolTip1.SetToolTip(Me.rbLR, resources.GetString("rbLR.ToolTip"))
        Me.rbLR.UseVisualStyleBackColor = True
        '
        'rbTR
        '
        Me.rbTR.AutoSize = True
        Me.rbTR.Location = New System.Drawing.Point(51, 25)
        Me.rbTR.Name = "rbTR"
        Me.rbTR.Size = New System.Drawing.Size(14, 13)
        Me.rbTR.TabIndex = 0
        Me.rbTR.TabStop = True
        Me.ToolTip1.SetToolTip(Me.rbTR, resources.GetString("rbTR.ToolTip"))
        Me.rbTR.UseVisualStyleBackColor = True
        '
        'rbTL
        '
        Me.rbTL.AutoSize = True
        Me.rbTL.Location = New System.Drawing.Point(10, 25)
        Me.rbTL.Name = "rbTL"
        Me.rbTL.Size = New System.Drawing.Size(14, 13)
        Me.rbTL.TabIndex = 0
        Me.rbTL.TabStop = True
        Me.ToolTip1.SetToolTip(Me.rbTL, resources.GetString("rbTL.ToolTip"))
        Me.rbTL.UseVisualStyleBackColor = True
        '
        'cbShowPoints
        '
        Me.cbShowPoints.AutoSize = True
        Me.cbShowPoints.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbShowPoints.Location = New System.Drawing.Point(6, 90)
        Me.cbShowPoints.Name = "cbShowPoints"
        Me.cbShowPoints.Size = New System.Drawing.Size(98, 34)
        Me.cbShowPoints.TabIndex = 42
        Me.cbShowPoints.Text = "Show Font" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Segment Points"
        Me.ToolTip1.SetToolTip(Me.cbShowPoints, "Check to show 'segments' of fonts as points." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This can drastically slow down the " &
        "drawing!!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.cbShowPoints.UseVisualStyleBackColor = True
        '
        'rbWidth
        '
        Me.rbWidth.AutoSize = True
        Me.rbWidth.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbWidth.Location = New System.Drawing.Point(20, 132)
        Me.rbWidth.Name = "rbWidth"
        Me.rbWidth.Size = New System.Drawing.Size(85, 20)
        Me.rbWidth.TabIndex = 43
        Me.rbWidth.TabStop = True
        Me.rbWidth.Text = "Size by X:"
        Me.ToolTip1.SetToolTip(Me.rbWidth, "Set size of GCode by X (Width)")
        Me.rbWidth.UseVisualStyleBackColor = True
        '
        'rbHeight
        '
        Me.rbHeight.AutoSize = True
        Me.rbHeight.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHeight.Location = New System.Drawing.Point(20, 163)
        Me.rbHeight.Name = "rbHeight"
        Me.rbHeight.Size = New System.Drawing.Size(86, 20)
        Me.rbHeight.TabIndex = 43
        Me.rbHeight.TabStop = True
        Me.rbHeight.Text = "Size by Y:"
        Me.ToolTip1.SetToolTip(Me.rbHeight, "Set size of GCode by Y (Height)")
        Me.rbHeight.UseVisualStyleBackColor = True
        '
        'tbZSurface
        '
        Me.tbZSurface.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbZSurface.Location = New System.Drawing.Point(30, 122)
        Me.tbZSurface.Name = "tbZSurface"
        Me.tbZSurface.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbZSurface.Size = New System.Drawing.Size(134, 26)
        Me.tbZSurface.TabIndex = 8
        Me.tbZSurface.Text = "0"
        Me.ToolTip1.SetToolTip(Me.tbZSurface, "Set this to be the Z positon of the surface to engrave")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(79, 20)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Z Surface"
        Me.ToolTip1.SetToolTip(Me.Label9, "Set this to be the Z positon of the surface to engrave")
        '
        'btnFont
        '
        Me.btnFont.Location = New System.Drawing.Point(24, 27)
        Me.btnFont.Name = "btnFont"
        Me.btnFont.Size = New System.Drawing.Size(197, 36)
        Me.btnFont.TabIndex = 44
        Me.btnFont.Text = "Select Font"
        Me.ToolTip1.SetToolTip(Me.btnFont, "Select the font to use.")
        Me.btnFont.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbRightAlign)
        Me.GroupBox1.Controls.Add(Me.rbMidALign)
        Me.GroupBox1.Controls.Add(Me.rbLeftAlign)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(503, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(160, 93)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Text Alignment:"
        Me.ToolTip1.SetToolTip(Me.GroupBox1, "Align text Left/Center/Right if using multiline")
        '
        'rbRightAlign
        '
        Me.rbRightAlign.AutoSize = True
        Me.rbRightAlign.Location = New System.Drawing.Point(10, 64)
        Me.rbRightAlign.Name = "rbRightAlign"
        Me.rbRightAlign.Size = New System.Drawing.Size(56, 20)
        Me.rbRightAlign.TabIndex = 0
        Me.rbRightAlign.TabStop = True
        Me.rbRightAlign.Text = "Right"
        Me.rbRightAlign.UseVisualStyleBackColor = True
        '
        'rbMidALign
        '
        Me.rbMidALign.AutoSize = True
        Me.rbMidALign.Location = New System.Drawing.Point(10, 41)
        Me.rbMidALign.Name = "rbMidALign"
        Me.rbMidALign.Size = New System.Drawing.Size(78, 20)
        Me.rbMidALign.TabIndex = 0
        Me.rbMidALign.TabStop = True
        Me.rbMidALign.Text = "Centered"
        Me.rbMidALign.UseVisualStyleBackColor = True
        '
        'rbLeftAlign
        '
        Me.rbLeftAlign.AutoSize = True
        Me.rbLeftAlign.Location = New System.Drawing.Point(10, 18)
        Me.rbLeftAlign.Name = "rbLeftAlign"
        Me.rbLeftAlign.Size = New System.Drawing.Size(47, 20)
        Me.rbLeftAlign.TabIndex = 0
        Me.rbLeftAlign.TabStop = True
        Me.rbLeftAlign.Text = "Left"
        Me.rbLeftAlign.UseVisualStyleBackColor = True
        '
        'rtbText
        '
        Me.rtbText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbText.Location = New System.Drawing.Point(227, 27)
        Me.rtbText.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.rtbText.Name = "rtbText"
        Me.rtbText.Size = New System.Drawing.Size(436, 73)
        Me.rtbText.TabIndex = 0
        Me.rtbText.Text = "Enter Text Here!"
        Me.rtbText.WordWrap = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbSendCode)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TB_SafeZ)
        Me.GroupBox2.Controls.Add(Me.TB_DepthZ)
        Me.GroupBox2.Controls.Add(Me.TB_CutFeed)
        Me.GroupBox2.Controls.Add(Me.tbZSurface)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.But_GenPlot)
        Me.GroupBox2.Controls.Add(Me.TB_speed)
        Me.GroupBox2.Controls.Add(Me.TB_DropFeed)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 413)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(677, 223)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GCode Inputs"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.nudFontSize)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TB_Ypos)
        Me.GroupBox3.Controls.Add(Me.rtbText)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.btnFont)
        Me.GroupBox3.Controls.Add(Me.TB_Xneg)
        Me.GroupBox3.Controls.Add(Me.rbHeight)
        Me.GroupBox3.Controls.Add(Me.TB_Xpos)
        Me.GroupBox3.Controls.Add(Me.rbWidth)
        Me.GroupBox3.Controls.Add(Me.TB_Yneg)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.TB_Xsize)
        Me.GroupBox3.Controls.Add(Me.gbOriginBoxes)
        Me.GroupBox3.Controls.Add(Me.TB_Ysize)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 130)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(679, 261)
        Me.GroupBox3.TabIndex = 46
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Font Inputs"
        '
        'nudFontSize
        '
        Me.nudFontSize.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudFontSize.Location = New System.Drawing.Point(153, 64)
        Me.nudFontSize.Name = "nudFontSize"
        Me.nudFontSize.Size = New System.Drawing.Size(69, 22)
        Me.nudFontSize.TabIndex = 43
        Me.ToolTip1.SetToolTip(Me.nudFontSize, "Adjust size of preview only." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Does not affect size of GCode!")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 16)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Font Size (preview)"
        Me.ToolTip1.SetToolTip(Me.Label5, "Adjust size of preview only." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Does not affect size of GCode!")
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.AutoScrollMinSize = New System.Drawing.Size(1000, 1000)
        Me.Panel1.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel1.Controls.Add(Me.cbShowPoints)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1107, 125)
        Me.Panel1.TabIndex = 47
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1090, 1000)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(979, 584)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 46)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save G-Code " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to File"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cbSendCode
        '
        Me.cbSendCode.AutoSize = True
        Me.cbSendCode.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSendCode.Location = New System.Drawing.Point(511, 91)
        Me.cbSendCode.Name = "cbSendCode"
        Me.cbSendCode.Size = New System.Drawing.Size(125, 34)
        Me.cbSendCode.TabIndex = 42
        Me.cbSendCode.Text = "Send generated code " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "direct to UCCNC"
        Me.cbSendCode.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.Location = New System.Drawing.Point(695, 604)
        Me.btnAbout.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(81, 26)
        Me.btnAbout.TabIndex = 4
        Me.btnAbout.Text = "About"
        Me.btnAbout.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'PluginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1107, 668)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.rtbGCode)
        Me.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.Name = "PluginForm"
        Me.Text = "UC_Engraver"
        Me.gbOriginBoxes.ResumeLayout(False)
        Me.gbOriginBoxes.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.nudFontSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents But_GenPlot As System.Windows.Forms.Button
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents TB_SafeZ As System.Windows.Forms.TextBox
    Friend WithEvents TB_DepthZ As System.Windows.Forms.TextBox
    Friend WithEvents TB_CutFeed As System.Windows.Forms.TextBox
    Friend WithEvents TB_speed As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TB_Xneg As System.Windows.Forms.TextBox
    Friend WithEvents TB_Xpos As System.Windows.Forms.TextBox
    Friend WithEvents TB_Yneg As System.Windows.Forms.TextBox
    Friend WithEvents TB_Ypos As System.Windows.Forms.TextBox
    Friend WithEvents TB_Xsize As System.Windows.Forms.TextBox
    Friend WithEvents TB_Ysize As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents TB_XOffset As System.Windows.Forms.TextBox
    Friend WithEvents TB_YOffset As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents rtbGCode As System.Windows.Forms.RichTextBox
    Friend WithEvents TB_DropFeed As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents gbOriginBoxes As GroupBox
    Friend WithEvents rbLL As RadioButton
    Friend WithEvents rbCenter As RadioButton
    Friend WithEvents rbLR As RadioButton
    Friend WithEvents rbTR As RadioButton
    Friend WithEvents rbTL As RadioButton
    Friend WithEvents cbShowPoints As CheckBox
    Friend WithEvents rbWidth As RadioButton
    Friend WithEvents rbHeight As RadioButton
    Friend WithEvents tbZSurface As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnFont As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbRightAlign As RadioButton
    Friend WithEvents rbMidALign As RadioButton
    Friend WithEvents rbLeftAlign As RadioButton
    Friend WithEvents rtbText As RichTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents nudFontSize As NumericUpDown
    Friend WithEvents btnSave As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents cbSendCode As CheckBox
    Friend WithEvents btnAbout As Button
End Class
