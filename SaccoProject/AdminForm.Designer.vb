<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminForm))
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuGradientPanel3 = New Bunifu.UI.WinForms.BunifuGradientPanel()
        Me.BunifuGradientPanel2 = New Bunifu.UI.WinForms.BunifuGradientPanel()
        Me.BunifuGradientPanel1 = New Bunifu.UI.WinForms.BunifuGradientPanel()
        Me.BunifuPictureBox1 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.BunifuLabel15 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel16 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.pnl_activity = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BunifuLabel17 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel18 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel19 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel20 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel21 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.btnClose = New FontAwesome.Sharp.IconButton()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(131, 594)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.pnl_activity)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(127, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(320, 594)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.BunifuLabel15)
        Me.Panel3.Controls.Add(Me.BunifuPictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(317, 247)
        Me.Panel3.TabIndex = 0
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 5
        Me.BunifuElipse2.TargetControl = Nothing
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuCards1.Controls.Add(Me.Panel5)
        Me.BunifuCards1.Controls.Add(Me.Panel4)
        Me.BunifuCards1.Controls.Add(Me.BunifuLabel16)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(466, 284)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 60
        Me.BunifuCards1.Size = New System.Drawing.Size(783, 375)
        Me.BunifuCards1.TabIndex = 6
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.BunifuLabel1.Location = New System.Drawing.Point(450, 3)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(126, 32)
        Me.BunifuLabel1.TabIndex = 7
        Me.BunifuLabel1.Text = "Dashboard"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AllowParentOverrides = False
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.CursorType = Nothing
        Me.BunifuLabel2.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.BunifuLabel2.Location = New System.Drawing.Point(450, 50)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(200, 25)
        Me.BunifuLabel2.TabIndex = 8
        Me.BunifuLabel2.Text = "See progress and decline"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuGradientPanel3
        '
        Me.BunifuGradientPanel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel3.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel3.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel3.BorderRadius = 1
        Me.BunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.DeepPink
        Me.BunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.DodgerBlue
        Me.BunifuGradientPanel3.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BunifuGradientPanel3.Location = New System.Drawing.Point(1026, 95)
        Me.BunifuGradientPanel3.Name = "BunifuGradientPanel3"
        Me.BunifuGradientPanel3.Quality = 10
        Me.BunifuGradientPanel3.Size = New System.Drawing.Size(223, 150)
        Me.BunifuGradientPanel3.TabIndex = 5
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.BorderRadius = 1
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.DeepPink
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.DodgerBlue
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(739, 95)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(223, 150)
        Me.BunifuGradientPanel2.TabIndex = 4
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.BorderRadius = 1
        Me.BunifuGradientPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DeepPink
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DodgerBlue
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(466, 97)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(223, 150)
        Me.BunifuGradientPanel1.TabIndex = 3
        '
        'BunifuPictureBox1
        '
        Me.BunifuPictureBox1.AllowFocused = False
        Me.BunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox1.AutoSizeHeight = True
        Me.BunifuPictureBox1.BorderRadius = 50
        Me.BunifuPictureBox1.Image = Global.SaccoProject.My.Resources.Resources.logo_g101176c3f_640
        Me.BunifuPictureBox1.IsCircle = True
        Me.BunifuPictureBox1.Location = New System.Drawing.Point(10, 6)
        Me.BunifuPictureBox1.Name = "BunifuPictureBox1"
        Me.BunifuPictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.BunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuPictureBox1.TabIndex = 0
        Me.BunifuPictureBox1.TabStop = False
        Me.BunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle
        '
        'BunifuLabel15
        '
        Me.BunifuLabel15.AllowParentOverrides = False
        Me.BunifuLabel15.AutoEllipsis = False
        Me.BunifuLabel15.CursorType = Nothing
        Me.BunifuLabel15.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!)
        Me.BunifuLabel15.Location = New System.Drawing.Point(10, 157)
        Me.BunifuLabel15.Name = "BunifuLabel15"
        Me.BunifuLabel15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel15.Size = New System.Drawing.Size(138, 32)
        Me.BunifuLabel15.TabIndex = 12
        Me.BunifuLabel15.Text = "Admin panel"
        Me.BunifuLabel15.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel15.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel16
        '
        Me.BunifuLabel16.AllowParentOverrides = False
        Me.BunifuLabel16.AutoEllipsis = False
        Me.BunifuLabel16.CursorType = Nothing
        Me.BunifuLabel16.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!)
        Me.BunifuLabel16.Location = New System.Drawing.Point(13, 24)
        Me.BunifuLabel16.Name = "BunifuLabel16"
        Me.BunifuLabel16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel16.Size = New System.Drawing.Size(228, 32)
        Me.BunifuLabel16.TabIndex = 13
        Me.BunifuLabel16.Text = "Today's Performance"
        Me.BunifuLabel16.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel16.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'pnl_activity
        '
        Me.pnl_activity.Location = New System.Drawing.Point(10, 266)
        Me.pnl_activity.Name = "pnl_activity"
        Me.pnl_activity.Size = New System.Drawing.Size(297, 282)
        Me.pnl_activity.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Chart1)
        Me.Panel4.Controls.Add(Me.BunifuLabel17)
        Me.Panel4.Location = New System.Drawing.Point(3, 89)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(346, 241)
        Me.Panel4.TabIndex = 14
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.BunifuLabel18)
        Me.Panel5.Location = New System.Drawing.Point(368, 89)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(365, 241)
        Me.Panel5.TabIndex = 15
        '
        'BunifuLabel17
        '
        Me.BunifuLabel17.AllowParentOverrides = False
        Me.BunifuLabel17.AutoEllipsis = False
        Me.BunifuLabel17.CursorType = Nothing
        Me.BunifuLabel17.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.BunifuLabel17.Location = New System.Drawing.Point(10, 14)
        Me.BunifuLabel17.Name = "BunifuLabel17"
        Me.BunifuLabel17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel17.Size = New System.Drawing.Size(42, 21)
        Me.BunifuLabel17.TabIndex = 13
        Me.BunifuLabel17.Text = "Loans"
        Me.BunifuLabel17.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel17.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel18
        '
        Me.BunifuLabel18.AllowParentOverrides = False
        Me.BunifuLabel18.AutoEllipsis = False
        Me.BunifuLabel18.CursorType = Nothing
        Me.BunifuLabel18.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.BunifuLabel18.Location = New System.Drawing.Point(14, 14)
        Me.BunifuLabel18.Name = "BunifuLabel18"
        Me.BunifuLabel18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel18.Size = New System.Drawing.Size(55, 21)
        Me.BunifuLabel18.TabIndex = 14
        Me.BunifuLabel18.Text = "Savings"
        Me.BunifuLabel18.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel18.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel19
        '
        Me.BunifuLabel19.AllowParentOverrides = False
        Me.BunifuLabel19.AutoEllipsis = False
        Me.BunifuLabel19.CursorType = Nothing
        Me.BunifuLabel19.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.BunifuLabel19.ForeColor = System.Drawing.Color.Lime
        Me.BunifuLabel19.Location = New System.Drawing.Point(987, 6)
        Me.BunifuLabel19.Name = "BunifuLabel19"
        Me.BunifuLabel19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel19.Size = New System.Drawing.Size(46, 21)
        Me.BunifuLabel19.TabIndex = 14
        Me.BunifuLabel19.Text = "About"
        Me.BunifuLabel19.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel19.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel20
        '
        Me.BunifuLabel20.AllowParentOverrides = False
        Me.BunifuLabel20.AutoEllipsis = False
        Me.BunifuLabel20.CursorType = Nothing
        Me.BunifuLabel20.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.BunifuLabel20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BunifuLabel20.Location = New System.Drawing.Point(1075, 6)
        Me.BunifuLabel20.Name = "BunifuLabel20"
        Me.BunifuLabel20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel20.Size = New System.Drawing.Size(40, 21)
        Me.BunifuLabel20.TabIndex = 15
        Me.BunifuLabel20.Text = "Tools"
        Me.BunifuLabel20.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel20.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel21
        '
        Me.BunifuLabel21.AllowParentOverrides = False
        Me.BunifuLabel21.AutoEllipsis = False
        Me.BunifuLabel21.CursorType = Nothing
        Me.BunifuLabel21.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.BunifuLabel21.ForeColor = System.Drawing.Color.Red
        Me.BunifuLabel21.Location = New System.Drawing.Point(1148, 6)
        Me.BunifuLabel21.Name = "BunifuLabel21"
        Me.BunifuLabel21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel21.Size = New System.Drawing.Size(35, 21)
        Me.BunifuLabel21.TabIndex = 16
        Me.BunifuLabel21.Text = "Help"
        Me.BunifuLabel21.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel21.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.IconChar = FontAwesome.Sharp.IconChar.X
        Me.btnClose.IconColor = System.Drawing.Color.DimGray
        Me.btnClose.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnClose.IconSize = 19
        Me.btnClose.Location = New System.Drawing.Point(1233, 9)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(31, 26)
        Me.btnClose.TabIndex = 17
        Me.btnClose.Tag = "Close Application"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Chart1
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(73, 14)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(300, 300)
        Me.Chart1.TabIndex = 14
        Me.Chart1.Text = "Chart1"
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1309, 594)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.BunifuLabel21)
        Me.Controls.Add(Me.BunifuLabel20)
        Me.Controls.Add(Me.BunifuLabel19)
        Me.Controls.Add(Me.BunifuLabel2)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.Controls.Add(Me.BunifuCards1)
        Me.Controls.Add(Me.BunifuGradientPanel3)
        Me.Controls.Add(Me.BunifuGradientPanel2)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminForm"
        Me.Text = "AdminForm"
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuGradientPanel3 As Bunifu.UI.WinForms.BunifuGradientPanel
    Friend WithEvents BunifuGradientPanel2 As Bunifu.UI.WinForms.BunifuGradientPanel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.UI.WinForms.BunifuGradientPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel15 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuPictureBox1 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents BunifuLabel21 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel20 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel19 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BunifuLabel18 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BunifuLabel17 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel16 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents pnl_activity As Panel
    Friend WithEvents btnClose As FontAwesome.Sharp.IconButton
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
