<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.BunifuFormDock1 = New Bunifu.UI.WinForms.BunifuFormDock()
        Me.BunifuGradientPanel1 = New Bunifu.UI.WinForms.BunifuGradientPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuFormDock1
        '
        Me.BunifuFormDock1.AllowFormDragging = True
        Me.BunifuFormDock1.AllowFormDropShadow = True
        Me.BunifuFormDock1.AllowFormResizing = False
        Me.BunifuFormDock1.AllowHidingBottomRegion = True
        Me.BunifuFormDock1.AllowOpacityChangesWhileDragging = False
        Me.BunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver
        Me.BunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1
        Me.BunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = True
        Me.BunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver
        Me.BunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1
        Me.BunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = True
        Me.BunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver
        Me.BunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1
        Me.BunifuFormDock1.BorderOptions.RightBorder.ShowBorder = True
        Me.BunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver
        Me.BunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1
        Me.BunifuFormDock1.BorderOptions.TopBorder.ShowBorder = True
        Me.BunifuFormDock1.ContainerControl = Me
        Me.BunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.BunifuFormDock1.DockingIndicatorsOpacity = 0.5R
        Me.BunifuFormDock1.DockingOptions.DockAll = True
        Me.BunifuFormDock1.DockingOptions.DockBottomLeft = True
        Me.BunifuFormDock1.DockingOptions.DockBottomRight = True
        Me.BunifuFormDock1.DockingOptions.DockFullScreen = True
        Me.BunifuFormDock1.DockingOptions.DockLeft = True
        Me.BunifuFormDock1.DockingOptions.DockRight = True
        Me.BunifuFormDock1.DockingOptions.DockTopLeft = True
        Me.BunifuFormDock1.DockingOptions.DockTopRight = True
        Me.BunifuFormDock1.FormDraggingOpacity = 0.9R
        Me.BunifuFormDock1.ParentForm = Me
        Me.BunifuFormDock1.ShowCursorChanges = True
        Me.BunifuFormDock1.ShowDockingIndicators = False
        Me.BunifuFormDock1.TitleBarOptions.AllowFormDragging = True
        Me.BunifuFormDock1.TitleBarOptions.BunifuFormDock = Me.BunifuFormDock1
        Me.BunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = True
        Me.BunifuFormDock1.TitleBarOptions.TitleBarControl = Nothing
        Me.BunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = False
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.BorderRadius = 1
        Me.BunifuGradientPanel1.Controls.Add(Me.IconButton1)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label1)
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox1)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuLabel2)
        Me.BunifuGradientPanel1.Controls.Add(Me.Panel1)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DodgerBlue
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(239, 450)
        Me.BunifuGradientPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(85, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Sacco Project"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SaccoProject.My.Resources.Resources.logo_g101176c3f_640
        Me.PictureBox1.Location = New System.Drawing.Point(16, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(63, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AllowParentOverrides = False
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.CursorType = Nothing
        Me.BunifuLabel2.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.BunifuLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuLabel2.Location = New System.Drawing.Point(90, 67)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(112, 21)
        Me.BunifuLabel2.TabIndex = 6
        Me.BunifuLabel2.Text = "Changing Lives"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(239, 135)
        Me.Panel1.TabIndex = 8
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.Transparent
        Me.IconButton1.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.Location = New System.Drawing.Point(0, 135)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(239, 47)
        Me.IconButton1.TabIndex = 9
        Me.IconButton1.Text = "IconButton1"
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuFormDock1 As Bunifu.UI.WinForms.BunifuFormDock
    Friend WithEvents BunifuGradientPanel1 As Bunifu.UI.WinForms.BunifuGradientPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
