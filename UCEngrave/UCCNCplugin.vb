Option Explicit Off

Imports System.Threading
Imports System.Windows.Forms
Imports System.Text
Imports System.Drawing
Imports System.Data
Imports System.Text.RegularExpressions
Imports System.Xml
Imports System.Reflection
Imports System.IO






'Public
Public Class UCCNCplugin
    Public UC As Plugininterface.Entry

    Friend LoopStop As Boolean
    Friend LoopWorking As Boolean

    Dim FirstRun As Boolean = True
    Dim MyForm As PluginForm

    Public running As Boolean
    Public idled As Boolean
    Public lastrunning As Boolean = False
    Public filefinished As Boolean = False

    Private _swenab As New Stopwatch
    Private _swdisab As New Stopwatch
    Private incycle As Boolean = False


    Private curtext As String
    Private curline As String


    Private lasttext As String
    Private curtool As String
    Private lasttool As String = ""

    Private curGloading As Boolean = False
    Private lastGloading As Boolean = False

    Private lastJSP As Boolean = False
    Private curJSP As Boolean = False

    Dim curWorkCoord, lastWorkCoord As Int16



    ' Called when the plugin is initialised.
    ' The parameter is the Plugin interface object which contains all functions prototypes for calls and callbacks.
    Public Sub Init_event(UC As Plugininterface.Entry)
        Me.UC = UC
        MyForm = New PluginForm(Me)
    End Sub

    ' Called when the plugin is loaded, the author of the plugin should set the details of the plugin here.
    Public Function Getproperties_event(ByVal Properties As Plugininterface.Entry.Pluginproperties) As Plugininterface.Entry.Pluginproperties
        Properties.author = "E Brust / CraftyCNC"
        Properties.pluginname = "UC_Engrave"
        Properties.pluginversion = "1.0000"
        'Properties.pluginversion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString ' Get version from Assembly info
        Return Properties
    End Function

    ' Called from UCCNC when the user presses the Configuration button in the Plugin configuration menu.
    ' Typically the plugin configuration window is shown to the user.
    Public Sub Configure_event()
        Dim CForm As New ConfigForm(Me)
        CForm.Show()
    End Sub

    ' Called from UCCNC when the plugin is loaded and started.
    Public Sub Startup_event()
        If MyForm.IsDisposed Then
            MyForm = New PluginForm(Me)
        End If
        MyForm.Show()
    End Sub

    ' Called when the Pluginshowup(string Pluginfilename); function is executed in the UCCNC.
    Public Sub Showup_event()
        If MyForm.IsDisposed Then
            MyForm = New PluginForm(Me)
        End If
        MyForm.Show()
        MyForm.BringToFront()
    End Sub

    ' Called when the UCCNC software is closing.
    Public Sub Shutdown_event()
        Try
            MyForm.Close()
        Catch ex As Exception

        End Try
    End Sub

    ' Called in a loop with a 25Hz interval.
    Public Sub Loop_event()
        If LoopStop Then
            Return
        End If
        LoopWorking = True
        If MyForm Is Nothing Or MyForm.IsDisposed Then
            Return
        End If
        If FirstRun Then
            FirstRun = False
            ' Write code here which has to be run on first cycle only...
        End If
        Try



        Catch ex As Exception

        End Try
        LoopWorking = False
        ' Console.WriteLine("" + Convert.ToInt32("A"))
    End Sub





    ' This is a direct function call addressed to this plugin dll
    ' The function can be called by macros or by another plugin
    ' The passed parameter is an object and the return value is also an object
    Public Function Informplugin_event(Message As Object) As Object
        If Not (MyForm Is Nothing Or MyForm.IsDisposed) Then
            If TypeOf Message Is String Then
                Dim receivedstr As String = Message
                MsgBox("Informplugin message received by Plugintest! Message was: " + receivedstr)
            End If
        End If
        Dim returnstr As String = "Return string by Plugintest"
        Return returnstr
    End Function

    ' This is a function call made to all plugin dll files
    ' The function can be called by macros or by another plugin
    ' The passed parameter is an object and there is no return value
    Public Sub Informplugins_event(Message As Object)
        If Not (MyForm Is Nothing Or MyForm.IsDisposed) Then
            If TypeOf Message Is String Then
                Dim receivedstr As String = Message
                MsgBox("Informplugins message received by Plugintest! Message was: " + receivedstr)
            End If
        End If
    End Sub

    ' Called when the user presses a button on the UCCNC GUI or if a Callbutton function is executed.
    ' The int buttonnumber parameter is the ID of the caller button.
    ' The bool onscreen parameter is true if the button was pressed on the GUI and is false if the Callbutton function was called.
    Public Sub Buttonpress_event(ByVal ButtonNumber As Integer, ByVal OnScreen As Boolean)
        If OnScreen Then
            If ButtonNumber = My.Settings.OpenCode Then

                UC.Pluginshowup("UC_engrave.dll")

                'OR
                'This doesnt work well, issues with loop restart and things not working right afterwards....  Use above!

                'Dim thrShowForm As Thread = New Thread(New ThreadStart(AddressOf showform))
                'thrShowForm.CurrentCulture = Thread.CurrentThread.CurrentCulture
                'thrShowForm.Start()

                'LoopStop = False ' re-enable lo

            End If
        End If
    End Sub

    ' Called when the user clicks and enters a Textfield on the screen
    ' The labelnumber parameter is the ID of the accessed Textfield
    ' The bool Ismainscreen parameter is true is the Textfield is on the main screen and false if it is on the jog screen
    Public Sub Textfieldclick_event(labelnumber As Integer, Ismainscreen As Boolean)
        If Ismainscreen Then
            If labelnumber = 1000 Then
                ' Your code here...
            End If
        End If
    End Sub

    ' Called when the user enters text into the Textfield and it gets validated
    ' The labelnumber parameter is the ID of the accessed Textfield
    ' The bool Ismainscreen parameter is true is the Textfield is on the main screen and false if it is on the jog screen.
    ' The text parameter is the text entered and validated by the user
    Public Sub Textfieldtexttyped_event(labelnumber As Integer, Ismainscreen As Boolean, text As String)
        If Ismainscreen Then
            If labelnumber = 1000 Then
                ' Your code here...
            End If
        End If
    End Sub

    ' Called when the user presses the Cycle start button and before the Cycle starts
    ' This event may be used to show messages or do actions on Cycle start 
    ' For example to cancel the Cycle if a condition met before the Cycle starts with calling the Button code 130 Cycle stop
    Public Sub Cyclethreadstart_event()
        ' MsgBox("Cycle is starting...")
    End Sub

    Public Sub Cyclethreadstop_event()
        ' MsgBox("Cycle is stopping...")
    End Sub

    Public Sub Toolpathclick_event(X As Double, Y As Double, Istopview As Boolean)
        ' Toolpath clicked
    End Sub

    ' Public Function Get_event(pluginfilename As String, exec As Executer) As Boolean ---->>>> ?




End Class



Public Class FormSerialisor
    Sub Serialise(ByVal c As Control, ByVal XmlFileName As String)
        Dim xmlSerialisedForm As XmlTextWriter = New XmlTextWriter(XmlFileName, System.Text.Encoding.[Default])
        xmlSerialisedForm.Formatting = Formatting.Indented
        xmlSerialisedForm.WriteStartDocument()
        xmlSerialisedForm.WriteStartElement("ChildForm")
        AddChildControls(xmlSerialisedForm, c)
        xmlSerialisedForm.WriteEndElement()
        xmlSerialisedForm.WriteEndDocument()
        xmlSerialisedForm.Flush()
        xmlSerialisedForm.Close()
    End Sub

    Private Sub AddChildControls(ByVal xmlSerialisedForm As XmlTextWriter, ByVal c As Control)
        For Each childCtrl As Control In c.Controls

            If Not (TypeOf childCtrl Is Label) Then
                xmlSerialisedForm.WriteStartElement("Control")
                xmlSerialisedForm.WriteAttributeString("Type", childCtrl.[GetType]().ToString())
                xmlSerialisedForm.WriteAttributeString("Name", childCtrl.Name)

                If TypeOf childCtrl Is TextBox Then
                    xmlSerialisedForm.WriteElementString("Text", (CType(childCtrl, TextBox)).Text)
                ElseIf TypeOf childCtrl Is ComboBox Then
                    xmlSerialisedForm.WriteElementString("Text", (CType(childCtrl, ComboBox)).Text)
                    xmlSerialisedForm.WriteElementString("SelectedIndex", (CType(childCtrl, ComboBox)).SelectedIndex.ToString())
                ElseIf TypeOf childCtrl Is ListBox Then
                    Dim lst As ListBox = CType(childCtrl, ListBox)

                    If lst.SelectedIndex = -1 Then
                        xmlSerialisedForm.WriteElementString("SelectedIndex", "-1")
                    Else

                        For i As Integer = 0 To lst.SelectedIndices.Count - 1
                            xmlSerialisedForm.WriteElementString("SelectedIndex", (lst.SelectedIndices(i).ToString()))
                        Next
                    End If
                ElseIf TypeOf childCtrl Is CheckBox Then
                    xmlSerialisedForm.WriteElementString("Checked", (CType(childCtrl, CheckBox)).Checked.ToString())
                ElseIf TypeOf childCtrl Is NumericUpDown Then
                    xmlSerialisedForm.WriteElementString("Value", (CType(childCtrl, NumericUpDown)).Value.ToString())
                ElseIf TypeOf childCtrl Is RadioButton Then
                    xmlSerialisedForm.WriteElementString("Checked", (CType(childCtrl, RadioButton)).Checked.ToString())
                ElseIf TypeOf childCtrl Is DataGridView Then
                    'do nothing
                End If

                Dim visible As Boolean = CBool(GetType(Control).GetMethod("GetState", BindingFlags.Instance Or BindingFlags.NonPublic).Invoke(childCtrl, New Object() {2}))
                xmlSerialisedForm.WriteElementString("Visible", visible.ToString())

                If childCtrl.HasChildren Then
                    If Not TypeOf childCtrl Is NumericUpDown Then
                        If TypeOf childCtrl Is SplitContainer Then
                            AddChildControls(xmlSerialisedForm, (CType(childCtrl, SplitContainer)).Panel1)
                            AddChildControls(xmlSerialisedForm, (CType(childCtrl, SplitContainer)).Panel2)
                        ElseIf TypeOf childCtrl Is DataGridView Then
                            'do nothing
                        Else
                            AddChildControls(xmlSerialisedForm, childCtrl)
                        End If
                    End If
                End If

                xmlSerialisedForm.WriteEndElement()
            End If
        Next
    End Sub

    Sub Deserialise(ByVal c As Control, ByVal XmlFileName As String)
        If File.Exists(XmlFileName) Then
            Dim xmlSerialisedForm As XmlDocument = New XmlDocument()
            xmlSerialisedForm.Load(XmlFileName)
            Dim topLevel As XmlNode = xmlSerialisedForm.ChildNodes(1)

            For Each n As XmlNode In topLevel.ChildNodes

                Try
                    SetControlProperties(CType(c, Control), n)
                Catch
                End Try
            Next
        End If
    End Sub

    Private Sub SetControlProperties(ByVal currentCtrl As Control, ByVal n As XmlNode)
        Dim controlName As String = n.Attributes("Name").Value
        Dim controlType As String = n.Attributes("Type").Value
        Dim ctrl As Control() = currentCtrl.Controls.Find(controlName, True)

        If ctrl.Length = 0 Then
            MessageBox.Show("can't find control")
        Else
            Dim ctrlToSet As Control = GetImmediateChildControl(ctrl, currentCtrl)

            If ctrlToSet IsNot Nothing Then

                If ctrlToSet.[GetType]().ToString() = controlType Then

                    Select Case controlType
                        Case "System.Windows.Forms.TextBox"
                            CType(ctrlToSet, System.Windows.Forms.TextBox).Text = n("Text").InnerText
                        Case "System.Windows.Forms.ComboBox"
                            CType(ctrlToSet, System.Windows.Forms.ComboBox).Text = n("Text").InnerText
                        Case "System.Windows.Forms.ListBox"
                            Dim lst As ListBox = CType(ctrlToSet, ListBox)
                            Dim xnlSelectedIndex As XmlNodeList = n.SelectNodes("SelectedIndex")

                            For i As Integer = 0 To xnlSelectedIndex.Count - 1
                                lst.SelectedIndex = Convert.ToInt32(xnlSelectedIndex(i).InnerText)
                            Next

                        Case "System.Windows.Forms.CheckBox"
                            CType(ctrlToSet, System.Windows.Forms.CheckBox).Checked = Convert.ToBoolean(n("Checked").InnerText)
                        Case "System.Windows.Forms.NumericUpDown"
                            CType(ctrlToSet, System.Windows.Forms.NumericUpDown).Value = Convert.ToDecimal(n("Value").InnerText)
                        Case "System.Windows.Forms.RadioButton"
                            CType(ctrlToSet, System.Windows.Forms.RadioButton).Checked = Convert.ToBoolean(n("Checked").InnerText)

                            'Case "System.Windows.Forms.DataGridView"
                            '    CType(ctrlToSet, System.Windows.Forms.RadioButton).Checked = Convert.ToBoolean(n("Checked").InnerText)

                    End Select

                    ctrlToSet.Visible = Convert.ToBoolean(n("Visible").InnerText)

                    If n.HasChildNodes AndAlso ctrlToSet.HasChildren Then
                        Dim xnlControls As XmlNodeList = n.SelectNodes("Control")

                        For Each n2 As XmlNode In xnlControls
                            SetControlProperties(ctrlToSet, n2)
                        Next
                    End If
                Else
                    MessageBox.Show("wrong type")
                End If
            Else
                MessageBox.Show("can't find")
            End If
        End If
    End Sub

    Private Function GetImmediateChildControl(ByVal ctrl As Control(), ByVal currentCtrl As Control) As Control
        Dim c As Control = Nothing

        For i As Integer = 0 To ctrl.Length - 1

            If (ctrl(i).Parent.Name = currentCtrl.Name) OrElse (TypeOf currentCtrl Is SplitContainer AndAlso ctrl(i).Parent.Parent.Name = currentCtrl.Name) Then
                c = ctrl(i)
                Exit For
            End If
        Next

        Return c
    End Function
End Class


