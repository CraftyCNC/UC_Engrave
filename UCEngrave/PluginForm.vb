' Font to G-Code by: Jim Steinbrecher 24 Nov 2011


' Plugin is for UCCNC
' Re-written, modified, improve and turned into UC_Engraver by E Brust, 12/19/2021
' Added font smoothing, closing fonts, multi-line, scaling size by width or height.



Imports System.Drawing.Drawing2D
Imports System
Imports System.Windows.Forms
Imports System.Drawing.Text
Imports System.Drawing
Imports System.Threading

Public Class PluginForm



    Friend uccncplugin

    Public UC As Plugininterface.Entry
    Dim PluginMain As UCCNCplugin
    Dim MustClose As Boolean = False





    Dim graphics_pathmain As New Drawing2D.GraphicsPath ' Create a GraphicsPath.
    Dim xmax, xmin, ymax, ymin As Double

    Dim CGx, CGY As Single

    Dim ZType, Org As Byte
    Dim x, y, z, XOffsetSave, YOffsetSave, XSave, YSave, ZSave, ZSurf, ZSafe, ZDepth, Speed, Feed, DFeed, CFeed As Single ' x y z

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        pictureBox1.Refresh()
    End Sub



    Private Sub TB_DepthZ_TextChanged(sender As Object, e As EventArgs) Handles TB_DepthZ.TextChanged, tbZSurface.TextChanged

    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click

        Dim aboutform As New About
        aboutform.ShowDialog()

    End Sub

    Private Sub Panel1_Scroll(sender As Object, e As ScrollEventArgs) Handles Panel1.Scroll
        PlotFlag = True
        PictureBox1.Refresh()
    End Sub






    Dim XOffSet, YOffSet, Xsize, Xscale, Ysize, Yscale, FontSize, XsizeDraw, YsizeDraw As Single ' X & Y Min Max Offset Size Scale
    Dim FontName, GText As String
    Dim FontStyle, i As Integer
    Dim PlotFlag As Boolean = False

    Public Sub New(CallerPluginMain As UCCNCplugin)
        Me.UC = CallerPluginMain.UC
        Me.PluginMain = CallerPluginMain
        InitializeComponent()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'Positive Only boxes
        AssignValidation(tbZSurface, ValidationType.Only_AllNumbers)
        AssignValidation(TB_DepthZ, ValidationType.Only_AllNumbers)
        AssignValidation(TB_XOffset, ValidationType.Only_AllNumbers)
        AssignValidation(TB_XOffset, ValidationType.Only_AllNumbers)
        AssignValidation(TB_YOffset, ValidationType.Only_AllNumbers)

        AssignValidation(TB_CutFeed, ValidationType.Only_PosNumbers)
        AssignValidation(TB_DropFeed, ValidationType.Only_PosNumbers)
        AssignValidation(TB_SafeZ, ValidationType.Only_PosNumbers)
        AssignValidation(TB_Xsize, ValidationType.Only_PosNumbers)
        AssignValidation(TB_Ysize, ValidationType.Only_PosNumbers)
        AssignValidation(TB_speed, ValidationType.Only_PosNumbers)



        PlotFlag = False
        GText = "G00"
        ZSafe = 0.15
        ZDepth = -0.1
        Speed = 5000
        CFeed = 18.0
        DFeed = 9.0
        FontName = "Times New Roman"
        FontStyle = 1
        FontSize = 12
        nudFontSize.Value = FontSize
        'TB_font.Text = FontName & ", Type: " & FontStyle
        TB_Ysize.Text = 1
        rbTL.Checked = True
        rbHeight.Checked = True
        rbLeftAlign.Checked = True
        'PictureBox1.Invalidate()
    End Sub


    Private Sub PluginForm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        ' Do not close the form when the red X button is pressed
        ' But start a Thread which will stop the Loop call from the UCCNC
        ' to prevent the form closing while there is a GUI update in the Loop event

        If goingtoclose = False Then

            res = MessageBox.Show("OK to close, Cancel to minimize to taskbar.", "Close?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

        End If

        If res = DialogResult.Cancel Then

            e.Cancel = True
            Me.WindowState = FormWindowState.Minimized

        Else

            If Not MustClose Then
                goingtoclose = True
                e.Cancel = True
                Dim thrClose As New Thread(Sub() Closeform())
                thrClose.CurrentCulture = Thread.CurrentThread.CurrentCulture ' Preserve regional settings
                thrClose.Start()
            Else
                ' Form is closing here...

            End If

        End If


    End Sub

    Public Sub Closeform()
        ' Stop the Loop event to update the GUI
        PluginMain.LoopStop = True
        ' Wait until the loop exited
        While (PluginMain.LoopWorking)
            Thread.Sleep(10)
        End While
        ' Set the mustclose variable to true and call the .Close() function to close the Form
        MustClose = True
        Me.Close()
    End Sub


    Public Sub GetExtents(ByVal PathPoints() As PointF)
        Dim WantedHeight As Single = 1
        Dim scaleHeight As Single



        xmax = 0
        xmin = 0
        ymax = 0
        ymin = 0

        XOffSet = Convert.ToSingle(TB_XOffset.Text)
        YOffSet = Convert.ToSingle(TB_YOffset.Text)


        'Figure overall size first:
        For i = 0 To PathPoints.Length - 1
            If PathPoints(i).IsEmpty = False Then
                x = PathPoints(i).X ': x = (x / 10) + XOffSet : x = x * Xscale : x = Math.Round(x, 4) 'calc x
                y = PathPoints(i).Y ': y = (y / 10) + YOffSet : y = y * Yscale : y = Math.Round(y, 4) : y = -1* y ' calc y

                If i = 0 Then
                    xmax = x
                    xmin = x
                    ymax = y
                    ymin = y
                End If


                If x < xmin Then xmin = x
                If x > xmax Then xmax = x
                If y < ymin Then ymin = y
                If y > ymax Then ymax = y

            End If

        Next i

        Select Case True ' Find graphic equivalent origin locaiton
            Case rbTL.Checked

                CGx = xmin
                CGY = ymin

            Case rbLL.Checked
                CGx = xmin
                CGY = ymax

            Case rbTR.Checked
                CGx = xmax
                CGY = ymin
            Case rbLR.Checked
                CGx = xmax
                CGY = ymax
            Case rbCenter.Checked
                CGx = (xmax + xmin) / 2
                CGY = (ymax + ymin) / 2
            Case Else

        End Select


        XsizeDraw = xmax - xmin ' Save the drawing size for later use
        YsizeDraw = ymax - ymin
        Xsize = xmax - xmin
        Ysize = ymax - ymin

        'Dim size As Drawing.Size
        'size.Width = CInt(Xsize)
        'size.Height = CInt(Ysize)
        'Panel1.AutoScrollMinSize = size


        If rbHeight.Checked Then
            Try
                WantedHeight = Convert.ToSingle(TB_Ysize.Text)
                scaleHeight = WantedHeight / Ysize
            Catch ex As Exception

            End Try


        ElseIf rbWidth.Checked Then
            Try
                WantedHeight = Convert.ToSingle(TB_Xsize.Text)
                scaleHeight = WantedHeight / Xsize
            Catch ex As Exception

            End Try


        Else
            scaleHeight = 1
        End If

        Xscale = 1
        Yscale = 1

        'MsgBox(scaleHeight)

        Xscale = scaleHeight * Xscale
        Yscale = scaleHeight * Yscale

        Xsize = Math.Round(Xsize * scaleHeight, 3)
        Ysize = Math.Round(Ysize * scaleHeight, 3)

        'update data on extents

        TB_Xsize.Text = fn3(Xsize) ' update stats
        TB_Ysize.Text = fn3(Ysize)

        Select Case True
            Case rbTL.Checked
                XOffSet = XOffSet + (0 - (xmin * scaleHeight))
                YOffSet = YOffSet + (0 + Ysize - (ymin * scaleHeight))
            Case rbLL.Checked
                XOffSet = XOffSet + (0 - (xmin * scaleHeight))
                YOffSet = YOffSet + (0 + Ysize - (ymax * scaleHeight))
            Case rbTR.Checked
                XOffSet = XOffSet + (0 - (xmax * scaleHeight))
                YOffSet = YOffSet + (0 + Ysize - (ymin * scaleHeight))
            Case rbLR.Checked
                XOffSet = XOffSet + (0 - (xmax * scaleHeight))
                YOffSet = YOffSet + (0 + Ysize - (ymax * scaleHeight))
            Case rbCenter.Checked
                XOffSet = XOffSet - (Xsize / 2) + (0 - xmin * scaleHeight)
                YOffSet = YOffSet + (Ysize / 2) - (ymin * scaleHeight)
            Case Else

        End Select


        ProgressBar.Maximum = PathPoints.Length - 1
        For i = 0 To PathPoints.Length - 1
            If PathPoints(i).IsEmpty = False Then
                x = PathPoints(i).X : x = x * Xscale : x = x + XOffSet : x = Math.Round(x, 4) 'calc x
                y = PathPoints(i).Y : y = y * Yscale : y = y + YOffSet : y = Math.Round(y, 4) : y = (-1 * y) + Ysize ' calc y


                If i = 0 Then
                    xmax = x
                    xmin = x
                    ymax = y
                    ymin = y
                End If


                If x < xmin Then xmin = x
                If x > xmax Then xmax = x
                If y < ymin Then ymin = y
                If y > ymax Then ymax = y


            End If

        Next i


        TB_Xneg.Text = fn3(Math.Round(xmin, 4))  'ToString
        TB_Xpos.Text = fn3(Math.Round(xmax, 4))
        TB_Yneg.Text = fn3(Math.Round(ymin, 4))
        TB_Ypos.Text = fn3(Math.Round(ymax, 4))
    End Sub


    Public Sub GetPointData(ByVal PathPoints() As PointF, ByVal pathtypes() As Byte, ByVal xOfset As Integer)
        'Build the G Code in RichTextBox1
        Dim firstrun As Boolean = True


        GetExtents(PathPoints)

        'generate code

        GText = "G00"
        ProgressBar.Maximum = PathPoints.Length - 1
        For i = 0 To PathPoints.Length - 1
            If PathPoints(i).IsEmpty = False Then
                x = PathPoints(i).X : x = x * Xscale : x = x + XOffSet : x = Math.Round(x, 4) 'calc x
                y = PathPoints(i).Y : y = y * Yscale : y = y + YOffSet : y = Math.Round(y, 4) : y = (-1 * y) + Ysize ' calc y



                If firstrun Then
                    XSave = x : YSave = y
                    rtbGCode.AppendText("G00" & " X" & x & " Y" & y & vbCrLf)
                    firstrun = False
                End If


                ZType = pathtypes(i) 'Bit 6: 1=Last line in chr. - Byte: 0=First line, 1=Stright line, 3=Curve 
                If ZType = 0 Then XSave = x : YSave = y 'Type 0 is first line in chr., Save for closure
                If ZType < 128 Then z = ZSurf + ZDepth 'Bit 8 off is pen down
                If ZType > 127 Then z = ZSurf + ZSafe 'Bit 8 on is pen up


                If Feed = CFeed Then rtbGCode.AppendText(GText & " X" & x & " Y" & y & vbCrLf) ' 1st G00 & All G01's Except last one in Chr.
                If Feed = DFeed Then Feed = CFeed : rtbGCode.AppendText(GText & " X" & x & " Y" & y & " F" & CFeed & vbCrLf)
                GText = "G01" : If z > 0 Then GText = "G00" 'Z: <0 = G01, >0 = G00
                If ZType > 127 Then rtbGCode.AppendText("G01" & " X" & XSave & " Y" & YSave & vbCrLf) 'Last G01 line, move to start.
                If ZSave <> z And z > 0 Then rtbGCode.AppendText("G00" & " Z" & z & vbCrLf) 'Z Change, <0 = G01, >0 = G00
                If ZSave <> z And z < 0 Then Feed = DFeed : rtbGCode.AppendText("G01" & " Z" & z & " F" & DFeed & vbCrLf) 'Z Change, <0 = G01, >0 = G00
                ZSave = z
            End If
            ProgressBar.Value = i
        Next i



        ProgressBar.Value = 0
    End Sub

    Private Sub ButCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        'If My.Computer.Keyboard.CtrlKeyDown Then GoTo SaveFile

        Me.rtbGCode.Focus()
        Me.rtbGCode.SelectAll()
        Me.rtbGCode.Copy() 'Copy to Clipboard
        Exit Sub


        'SaveFile:
        '        ' Create a SaveFileDialog to request a path and file name to save to.
        '        Dim saveFile1 As New SaveFileDialog()

        '        ' Initialize the SaveFileDialog to specify the .txt extension for the file.
        '        saveFile1.DefaultExt = "*.txt"
        '        saveFile1.Filter = "*.txt|*.txt"

        '        ' Determine if the user selected a file name from the saveFileDialog.
        '        If (saveFile1.ShowDialog() = System.Windows.Forms.DialogResult.OK) _
        '            And (saveFile1.FileName.Length) > 0 Then

        '            ' Save the contents of the RichTextBox into the file.
        '            RichTextBox1.SaveFile(saveFile1.FileName,
        '                RichTextBoxStreamType.PlainText)
        '        End If
        '        saveFile1.Dispose()
    End Sub

    Private Sub ButSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        ' Create a SaveFileDialog to request a path and file name to save to.
        Dim saveFile1 As New SaveFileDialog()

        ' Initialize the SaveFileDialog to specify the .txt extension for the file.
        saveFile1.DefaultExt = "*.txt"
        saveFile1.Filter = "*.txt|*.txt"

        ' Determine if the user selected a file name from the saveFileDialog.
        If (saveFile1.ShowDialog() = System.Windows.Forms.DialogResult.OK) _
            And (saveFile1.FileName.Length) > 0 Then

            ' Save the contents of the RichTextBox into the file.
            rtbGCode.SaveFile(saveFile1.FileName,
                RichTextBoxStreamType.PlainText)
        End If
        saveFile1.Dispose()
    End Sub


    Private Sub But_GenPlot_Click() Handles But_GenPlot.Click

        'Private Sub But_GenPlot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_GenPlot.Click
        If rtbText.Text = "" Then Exit Sub 'Plot setup
        If graphics_pathmain IsNot Nothing AndAlso graphics_pathmain.PathPoints.Length > 1 Then


            'TB_Xsize.Text = "" : TB_Ysize.Text = ""
            GText = "G00"
            ZSafe = Val(TB_SafeZ.Text)
            ZSurf = Val(tbZSurface.Text)
            ZDepth = Val(TB_DepthZ.Text)
            Speed = Val(TB_speed.Text)
            CFeed = Val(TB_CutFeed.Text)
            DFeed = Val(TB_DropFeed.Text)
            'Xscale = Val(TB_Xscale.Text) : Yscale = Val(TB_Yscale.Text)
            XOffSet = Val(TB_XOffset.Text) : YOffSet = Val(TB_YOffset.Text)
            'TB_Xneg.Text = "*" : TB_Xpos.Text = "*"
            'TB_Yneg.Text = "*" : TB_Ypos.Text = "*"
            rtbGCode.Clear()
            rtbGCode.AppendText("(UC_FontEngraver)" & vbCrLf)
            rtbGCode.AppendText("(Text: " & rtbText.Text & ")" & vbCrLf)
            'RichTextBox1.AppendText("(Font: " & TB_font.Text & ")" & vbCrLf)
            rtbGCode.AppendText("(Font: " & FontName & ")" & vbCrLf)

            Select Case True
                Case rbTL.Checked

                    rtbGCode.AppendText("(X/Y Origin: Top Left)" & vbCrLf)

                Case rbLL.Checked
                    rtbGCode.AppendText("(X/Y Origin: Lower Left)" & vbCrLf)

                Case rbTR.Checked
                    rtbGCode.AppendText("(X/Y Origin: Top Right)" & vbCrLf)

                Case rbLR.Checked
                    rtbGCode.AppendText("(X/Y Origin: Lower Right)" & vbCrLf)

                Case rbCenter.Checked
                    rtbGCode.AppendText("(X/Y Origin: Central)" & vbCrLf)
                Case Else

            End Select

            rtbGCode.AppendText("(Origin Offsets: X: " & fn3(XOffSet) & ", Y: " & fn3(YOffSet) & vbCrLf)
            rtbGCode.AppendText("(Bounds Min: Xmin: " & fn3(xmin) & ", Ymin: " & fn3(ymin) & vbCrLf)
            rtbGCode.AppendText("(Bounds Max: Xmax:" & fn3(xmax) & ", Ymax: " & fn3(ymax) & vbCrLf)

            rtbGCode.AppendText("(" & Date.Now & ")" & vbCrLf)
            rtbGCode.AppendText(GText & " Z" & ZSafe + ZSurf & vbCrLf)
            rtbGCode.AppendText("F" & CFeed & vbCrLf)
            rtbGCode.AppendText("M3 S" & Speed & vbCrLf)


            GetPointData(graphics_pathmain.PathPoints, graphics_pathmain.PathTypes, 0) 'x offset <------- Build the G Code in RichTextBox1


            rtbGCode.AppendText("M5" & vbCrLf)
            rtbGCode.AppendText("M30" & vbCrLf)

            If cbSendCode.Checked Then
                Try
                    Dim fileLocation As String = Application.StartupPath & "\plugins\UC_Engrave_GCode.txt"
                    rtbGCode.SaveFile(fileLocation,
                        RichTextBoxStreamType.PlainText)
                    UC.Loadfile(fileLocation)
                Catch ex As Exception

                End Try

            End If




        End If


    End Sub




    Private Sub But_GenPlot_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pictureBox1.Paint ', TB_font.TextChanged, rtbText.TextChanged


        If rtbText.Text = "" Then Exit Sub 'Plot if have text
        If PlotFlag = False Then Exit Sub 'Only plot 1 time

        Dim centering As New StringFormat()
        Dim graphics_path1 As New Drawing2D.GraphicsPath

        If rbMidALign.Checked Then
            centering.Alignment = StringAlignment.Center

        ElseIf rbLeftAlign.Checked Then
            centering.Alignment = StringAlignment.Near

        ElseIf rbRightAlign.Checked Then
            centering.Alignment = StringAlignment.Far

        End If

        graphics_path1.AddString(rtbText.Text,
            New FontFamily(FontName), FontStyle, FontSize,
            New Point(Me.Width / 2, 2), centering) 'StringFormat.GenericTypographic) ' Screen Start location


        'new
        Dim scalematrix As New Matrix
        scalematrix.Scale(1, 1)

        graphics_path1.Flatten(scalematrix, 0.05) ' This works!  Need to add 'tolerance' (matrix,tolerance)
        ''''


        PlotFlag = False

        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias 'This will smooth out the drawing
        graphics_path1.CloseAllFigures()
        e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
        e.Graphics.DrawPath(New Pen(Color.Black, 0), graphics_path1) ' Draw the path.

        'e.Graphics..FillPath(Brushes.Black, graphics_path1)







        If cbShowPoints.Checked Then


            e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias 'This will smooth out the drawing
            e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.Default

            ''''''''''''' Added from: https://stackoverflow.com/questions/31104155/text-to-polylines-and-arc-conversion
            Dim br As List(Of Brush) = New List(Of Brush)() From {
        Brushes.Red,
        Brushes.Blue,
        Brushes.Green,
        Brushes.Violet,
        Brushes.DarkKhaki,
        Brushes.DarkCyan,
        Brushes.Chocolate
        }

            Dim cc As Integer = 0

            If graphics_path1 IsNot Nothing AndAlso graphics_path1.PathPoints IsNot Nothing AndAlso graphics_path1.PathPoints.Length > 1 Then

                For i As Integer = 0 To graphics_path1.PathPoints.Length - 1
                    Dim pt As PointF = graphics_path1.PathPoints(i)
                    Dim ptype As Integer = graphics_path1.PathTypes(i)

                    If ptype <> 3 Then
                        cc = 0
                    Else
                        cc += 1
                    End If

                    If ptype > 3 Then ptype = 4
                    e.Graphics.FillEllipse(br(ptype + cc Mod 3), pt.X - 1, pt.Y - 1, 2, 2)
                Next
            End If

            '''''''''''''''
        End If

        GetExtents(graphics_path1.PathPoints)
        Dim brush As New SolidBrush(Color.Yellow)
        e.Graphics.FillEllipse(brush, CGx - 3, CGY - 3, 6, 6)

        graphics_pathmain = graphics_path1

        'But_GenPlot_Click()

    End Sub

    Private Sub TBfont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFont.Click

        If FontDialog1.ShowDialog() = DialogResult.OK Then ' change font stats
            FontName = FontDialog1.Font.Name.ToString
            FontStyle = 0
            If FontDialog1.Font.Bold Then FontStyle += 1
            If FontDialog1.Font.Italic Then FontStyle += 2
            If FontDialog1.Font.Underline Then FontStyle += 4
            If FontDialog1.Font.Strikeout Then FontStyle += 8

            FontSize = FontDialog1.Font.Size

            nudFontSize.Value = FontSize

            'rtbText.Font = FontDialog1.Font
            'rtbText.Font.Size = 12
            'TB_font.Text = FontName & ", Type: " & FontStyle

            rtbGCode.Clear()
            PlotFlag = True
            pictureBox1.Refresh()

        End If
    End Sub

    Private Sub TBInput_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtbText.TextChanged, TB_Xsize.LostFocus, TB_Ysize.LostFocus, rbLL.Click, rbLR.Click,
                                rbTL.Click, rbTR.Click, rbCenter.Click, rbRightAlign.Click, rbMidALign.Click, rbLeftAlign.Click, nudFontSize.ValueChanged, TB_XOffset.LostFocus, TB_YOffset.LostFocus

        FontSize = nudFontSize.Value
        rtbGCode.Clear()
        PlotFlag = True
        pictureBox1.Refresh()
    End Sub




    Public Function fn(ByRef val As Double)
        Return String.Format("{0:F4}", val)
        'Return String.Format("f6", val)
    End Function


    Public Function fn2(ByRef val As Double)
        Return String.Format("{0:F2}", val)
        'Return String.Format("f6", val)
    End Function

    Public Function fn3(ByRef val As Double)
        Return String.Format("{0:F3}", val)
        'Return String.Format("f6", val)
    End Function
End Class


