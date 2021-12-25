<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.rtbAboutPlugin = New System.Windows.Forms.RichTextBox()
        Me.lblAppVersion = New System.Windows.Forms.Label()
        Me.linkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.linkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rtbAboutPlugin
        '
        Me.rtbAboutPlugin.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.rtbAboutPlugin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbAboutPlugin.Location = New System.Drawing.Point(13, 136)
        Me.rtbAboutPlugin.Margin = New System.Windows.Forms.Padding(4)
        Me.rtbAboutPlugin.Name = "rtbAboutPlugin"
        Me.rtbAboutPlugin.ReadOnly = True
        Me.rtbAboutPlugin.Size = New System.Drawing.Size(292, 166)
        Me.rtbAboutPlugin.TabIndex = 64
        Me.rtbAboutPlugin.Text = resources.GetString("rtbAboutPlugin.Text")
        '
        'lblAppVersion
        '
        Me.lblAppVersion.AutoSize = True
        Me.lblAppVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblAppVersion.Location = New System.Drawing.Point(173, 13)
        Me.lblAppVersion.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblAppVersion.Name = "lblAppVersion"
        Me.lblAppVersion.Size = New System.Drawing.Size(131, 16)
        Me.lblAppVersion.TabIndex = 63
        Me.lblAppVersion.Text = "Plugin Version: 1.000"
        Me.lblAppVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'linkLabel2
        '
        Me.linkLabel2.AutoSize = True
        Me.linkLabel2.Location = New System.Drawing.Point(33, 88)
        Me.linkLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linkLabel2.Name = "linkLabel2"
        Me.linkLabel2.Size = New System.Drawing.Size(101, 13)
        Me.linkLabel2.TabIndex = 62
        Me.linkLabel2.TabStop = True
        Me.linkLabel2.Text = "www.craftycnc.com"
        '
        'linkLabel1
        '
        Me.linkLabel1.AutoSize = True
        Me.linkLabel1.Location = New System.Drawing.Point(33, 110)
        Me.linkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linkLabel1.Name = "linkLabel1"
        Me.linkLabel1.Size = New System.Drawing.Size(120, 13)
        Me.linkLabel1.TabIndex = 60
        Me.linkLabel1.TabStop = True
        Me.linkLabel1.Tag = "mailto:eabrust@craftycnc.com"
        Me.linkLabel1.Text = "eabrust@craftycnc.com"
        '
        'pictureBox1
        '
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox1.ErrorImage = CType(resources.GetObject("pictureBox1.ErrorImage"), System.Drawing.Image)
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.InitialImage = CType(resources.GetObject("pictureBox1.InitialImage"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(36, 13)
        Me.pictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(108, 71)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 61
        Me.pictureBox1.TabStop = False
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 315)
        Me.Controls.Add(Me.rtbAboutPlugin)
        Me.Controls.Add(Me.lblAppVersion)
        Me.Controls.Add(Me.linkLabel2)
        Me.Controls.Add(Me.linkLabel1)
        Me.Controls.Add(Me.pictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "About"
        Me.Text = "About UC_Engrave"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rtbAboutPlugin As Windows.Forms.RichTextBox
    Public WithEvents lblAppVersion As Windows.Forms.Label
    Private WithEvents linkLabel2 As Windows.Forms.LinkLabel
    Private WithEvents linkLabel1 As Windows.Forms.LinkLabel
    Private WithEvents pictureBox1 As Windows.Forms.PictureBox
End Class
