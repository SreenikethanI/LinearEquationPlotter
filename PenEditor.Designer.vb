<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PenEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PenEditor))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Preview = New System.Windows.Forms.PictureBox()
        Me.LChangeBG = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PWidth = New System.Windows.Forms.NumericUpDown()
        Me.PStartCap = New System.Windows.Forms.ComboBox()
        Me.PEndCap = New System.Windows.Forms.ComboBox()
        Me.TLPEndCaps = New System.Windows.Forms.TableLayoutPanel()
        Me.PDashCap = New System.Windows.Forms.ComboBox()
        Me.PAlignment = New System.Windows.Forms.ComboBox()
        Me.PColor = New System.Windows.Forms.Label()
        Me.PDashStyle = New System.Windows.Forms.ComboBox()
        Me.PDashOffset = New System.Windows.Forms.NumericUpDown()
        Me.HelpInfo = New System.Windows.Forms.Label()
        Me.Helper = New System.Windows.Forms.HelpProvider()
        Me.PDashPattern = New System.Windows.Forms.TextBox()
        Me.PCompArray = New System.Windows.Forms.TextBox()
        Me.BOK = New System.Windows.Forms.Button()
        Me.BCancel = New System.Windows.Forms.Button()
        CType(Me.Preview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLPEndCaps.SuspendLayout()
        CType(Me.PDashOffset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Helper.SetHelpString(Me.Label1, "A preview of the final line style to be used will be displayed on the right side." & _
        "")
        Me.Label1.Location = New System.Drawing.Point(38, 9)
        Me.Label1.Name = "Label1"
        Me.Helper.SetShowHelp(Me.Label1, True)
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Preview:"
        '
        'Preview
        '
        Me.Preview.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Preview.ErrorImage = Nothing
        Me.Helper.SetHelpString(Me.Preview, "A preview of the final line style to be used will be displayed here.")
        Me.Preview.InitialImage = Nothing
        Me.Preview.Location = New System.Drawing.Point(95, 9)
        Me.Preview.Name = "Preview"
        Me.Helper.SetShowHelp(Me.Preview, True)
        Me.Preview.Size = New System.Drawing.Size(365, 50)
        Me.Preview.TabIndex = 1
        Me.Preview.TabStop = False
        '
        'LChangeBG
        '
        Me.LChangeBG.AutoSize = True
        Me.LChangeBG.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Helper.SetHelpString(Me.LChangeBG, "Click here to change the background of the preview on the right side. This does n" & _
        "ot affect the actual line style, and is only for viewing convenience.")
        Me.LChangeBG.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LChangeBG.LinkColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LChangeBG.Location = New System.Drawing.Point(9, 24)
        Me.LChangeBG.Name = "LChangeBG"
        Me.Helper.SetShowHelp(Me.LChangeBG, True)
        Me.LChangeBG.Size = New System.Drawing.Size(80, 15)
        Me.LChangeBG.TabIndex = 1
        Me.LChangeBG.TabStop = True
        Me.LChangeBG.Text = "Background..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Helper.SetHelpString(Me.Label2, "Set the thickness/width of the line.")
        Me.Label2.Location = New System.Drawing.Point(47, 63)
        Me.Label2.Name = "Label2"
        Me.Helper.SetShowHelp(Me.Label2, True)
        Me.Label2.Size = New System.Drawing.Size(62, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Thickness:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Helper.SetHelpString(Me.Label3, "Set the appearance and style of the end-points of the line.")
        Me.Label3.Location = New System.Drawing.Point(28, 85)
        Me.Label3.Name = "Label3"
        Me.Helper.SetShowHelp(Me.Label3, True)
        Me.Label3.Size = New System.Drawing.Size(81, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Start/end cap:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Helper.SetHelpString(Me.Label4, "Set the appearance and style of the caps of each dash (on a dotted/dashed line).")
        Me.Label4.Location = New System.Drawing.Point(51, 108)
        Me.Label4.Name = "Label4"
        Me.Helper.SetShowHelp(Me.Label4, True)
        Me.Label4.Size = New System.Drawing.Size(58, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Dash cap:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Helper.SetHelpString(Me.Label5, "Set the color of the line.")
        Me.Label5.Location = New System.Drawing.Point(70, 131)
        Me.Label5.Name = "Label5"
        Me.Helper.SetShowHelp(Me.Label5, True)
        Me.Label5.Size = New System.Drawing.Size(39, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Color:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Helper.SetHelpString(Me.Label6, "Set the style of the line, whether it is a solid line, or dotted, or dashed, or a" & _
        " combination. Set ""custom"" and change the ""Dash pattern"" setting below, if you w" & _
        "ant a custom style.")
        Me.Label6.Location = New System.Drawing.Point(46, 152)
        Me.Label6.Name = "Label6"
        Me.Helper.SetShowHelp(Me.Label6, True)
        Me.Label6.Size = New System.Drawing.Size(63, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Dash style:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Helper.SetHelpString(Me.Label7, resources.GetString("Label7.HelpString"))
        Me.Label7.Location = New System.Drawing.Point(32, 173)
        Me.Label7.Name = "Label7"
        Me.Helper.SetShowHelp(Me.Label7, True)
        Me.Label7.Size = New System.Drawing.Size(77, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Dash pattern:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Helper.SetHelpString(Me.Label8, resources.GetString("Label8.HelpString"))
        Me.Label8.Location = New System.Drawing.Point(40, 191)
        Me.Label8.Name = "Label8"
        Me.Helper.SetShowHelp(Me.Label8, True)
        Me.Label8.Size = New System.Drawing.Size(69, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Dash offset:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 212)
        Me.Label9.Name = "Label9"
        Me.Helper.SetShowHelp(Me.Label9, True)
        Me.Label9.Size = New System.Drawing.Size(100, 15)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Compound array:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(43, 233)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 15)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Alignment:"
        Me.Label10.Visible = False
        '
        'PWidth
        '
        Me.PWidth.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PWidth.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PWidth.DecimalPlaces = 2
        Me.Helper.SetHelpString(Me.PWidth, "Set the thickness/width of the line.")
        Me.PWidth.Location = New System.Drawing.Point(115, 62)
        Me.PWidth.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.PWidth.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.PWidth.Name = "PWidth"
        Me.Helper.SetShowHelp(Me.PWidth, True)
        Me.PWidth.Size = New System.Drawing.Size(345, 19)
        Me.PWidth.TabIndex = 3
        Me.PWidth.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'PStartCap
        '
        Me.PStartCap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PStartCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PStartCap.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PStartCap.FormattingEnabled = True
        Me.Helper.SetHelpString(Me.PStartCap, "Set the appearance and style of the starting point of the line.")
        Me.PStartCap.Location = New System.Drawing.Point(0, 0)
        Me.PStartCap.Margin = New System.Windows.Forms.Padding(0)
        Me.PStartCap.Name = "PStartCap"
        Me.Helper.SetShowHelp(Me.PStartCap, True)
        Me.PStartCap.Size = New System.Drawing.Size(172, 21)
        Me.PStartCap.TabIndex = 0
        '
        'PEndCap
        '
        Me.PEndCap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PEndCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PEndCap.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PEndCap.FormattingEnabled = True
        Me.Helper.SetHelpString(Me.PEndCap, "Set the appearance and style of the ending point of the line.")
        Me.PEndCap.Location = New System.Drawing.Point(172, 0)
        Me.PEndCap.Margin = New System.Windows.Forms.Padding(0)
        Me.PEndCap.Name = "PEndCap"
        Me.Helper.SetShowHelp(Me.PEndCap, True)
        Me.PEndCap.Size = New System.Drawing.Size(173, 21)
        Me.PEndCap.TabIndex = 1
        '
        'TLPEndCaps
        '
        Me.TLPEndCaps.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TLPEndCaps.ColumnCount = 2
        Me.TLPEndCaps.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPEndCaps.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPEndCaps.Controls.Add(Me.PStartCap, 0, 0)
        Me.TLPEndCaps.Controls.Add(Me.PEndCap, 1, 0)
        Me.Helper.SetHelpString(Me.TLPEndCaps, "Set the appearance and style of the end-points of the line.")
        Me.TLPEndCaps.Location = New System.Drawing.Point(115, 83)
        Me.TLPEndCaps.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TLPEndCaps.Name = "TLPEndCaps"
        Me.TLPEndCaps.RowCount = 1
        Me.TLPEndCaps.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Helper.SetShowHelp(Me.TLPEndCaps, True)
        Me.TLPEndCaps.Size = New System.Drawing.Size(345, 21)
        Me.TLPEndCaps.TabIndex = 5
        '
        'PDashCap
        '
        Me.PDashCap.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PDashCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PDashCap.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PDashCap.FormattingEnabled = True
        Me.Helper.SetHelpString(Me.PDashCap, "Set the appearance and style of the caps of each dash (on a dotted/dashed line).")
        Me.PDashCap.Location = New System.Drawing.Point(115, 106)
        Me.PDashCap.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.PDashCap.Name = "PDashCap"
        Me.Helper.SetShowHelp(Me.PDashCap, True)
        Me.PDashCap.Size = New System.Drawing.Size(345, 21)
        Me.PDashCap.TabIndex = 7
        '
        'PAlignment
        '
        Me.PAlignment.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PAlignment.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PAlignment.FormattingEnabled = True
        Me.PAlignment.Location = New System.Drawing.Point(115, 231)
        Me.PAlignment.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.PAlignment.Name = "PAlignment"
        Me.PAlignment.Size = New System.Drawing.Size(345, 21)
        Me.PAlignment.TabIndex = 19
        Me.PAlignment.Visible = False
        '
        'PColor
        '
        Me.PColor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PColor.AutoEllipsis = True
        Me.PColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PColor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Helper.SetHelpString(Me.PColor, "Set the color of the line.")
        Me.PColor.Location = New System.Drawing.Point(115, 129)
        Me.PColor.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.PColor.Name = "PColor"
        Me.Helper.SetShowHelp(Me.PColor, True)
        Me.PColor.Size = New System.Drawing.Size(345, 19)
        Me.PColor.TabIndex = 9
        Me.PColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PDashStyle
        '
        Me.PDashStyle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PDashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PDashStyle.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PDashStyle.FormattingEnabled = True
        Me.Helper.SetHelpString(Me.PDashStyle, "Set the style of the line, whether it is a solid line, or dotted, or dashed, or a" & _
        " combination. Set ""custom"" and change the ""Dash pattern"" setting below, if you w" & _
        "ant a custom style.")
        Me.PDashStyle.Location = New System.Drawing.Point(115, 150)
        Me.PDashStyle.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.PDashStyle.Name = "PDashStyle"
        Me.Helper.SetShowHelp(Me.PDashStyle, True)
        Me.PDashStyle.Size = New System.Drawing.Size(345, 21)
        Me.PDashStyle.TabIndex = 11
        '
        'PDashOffset
        '
        Me.PDashOffset.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PDashOffset.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PDashOffset.DecimalPlaces = 2
        Me.Helper.SetHelpString(Me.PDashOffset, resources.GetString("PDashOffset.HelpString"))
        Me.PDashOffset.Location = New System.Drawing.Point(115, 191)
        Me.PDashOffset.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.PDashOffset.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.PDashOffset.Name = "PDashOffset"
        Me.Helper.SetShowHelp(Me.PDashOffset, True)
        Me.PDashOffset.Size = New System.Drawing.Size(345, 19)
        Me.PDashOffset.TabIndex = 15
        '
        'HelpInfo
        '
        Me.HelpInfo.AutoEllipsis = True
        Me.HelpInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.HelpInfo.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Helper.SetHelpString(Me.HelpInfo, "Alright, you didn't get me there, I think. You might want to click the element it" & _
        "self on which you need help. Have a good time!")
        Me.HelpInfo.Location = New System.Drawing.Point(0, 292)
        Me.HelpInfo.Name = "HelpInfo"
        Me.HelpInfo.Padding = New System.Windows.Forms.Padding(1)
        Me.Helper.SetShowHelp(Me.HelpInfo, True)
        Me.HelpInfo.Size = New System.Drawing.Size(472, 19)
        Me.HelpInfo.TabIndex = 22
        Me.HelpInfo.Text = "For help, click the ""?"" icon on the title bar, and click on the element you need " & _
    "help with."
        '
        'PDashPattern
        '
        Me.PDashPattern.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PDashPattern.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Helper.SetHelpString(Me.PDashPattern, resources.GetString("PDashPattern.HelpString"))
        Me.PDashPattern.Location = New System.Drawing.Point(115, 173)
        Me.PDashPattern.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.PDashPattern.Name = "PDashPattern"
        Me.Helper.SetShowHelp(Me.PDashPattern, True)
        Me.PDashPattern.Size = New System.Drawing.Size(345, 16)
        Me.PDashPattern.TabIndex = 13
        '
        'PCompArray
        '
        Me.PCompArray.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PCompArray.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Helper.SetHelpString(Me.PCompArray, resources.GetString("PCompArray.HelpString"))
        Me.PCompArray.Location = New System.Drawing.Point(115, 212)
        Me.PCompArray.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.PCompArray.Name = "PCompArray"
        Me.Helper.SetShowHelp(Me.PCompArray, True)
        Me.PCompArray.Size = New System.Drawing.Size(345, 16)
        Me.PCompArray.TabIndex = 23
        '
        'BOK
        '
        Me.BOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BOK.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Helper.SetHelpString(Me.BOK, "The changes made will be applied to the line style you chose to edit.")
        Me.BOK.Location = New System.Drawing.Point(360, 263)
        Me.BOK.Name = "BOK"
        Me.Helper.SetShowHelp(Me.BOK, True)
        Me.BOK.Size = New System.Drawing.Size(100, 23)
        Me.BOK.TabIndex = 20
        Me.BOK.Text = "&OK (Alt+O)"
        Me.BOK.UseVisualStyleBackColor = True
        '
        'BCancel
        '
        Me.BCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BCancel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Helper.SetHelpString(Me.BCancel, "The changes made will be discarded and the previous style will remain unchanged.")
        Me.BCancel.Location = New System.Drawing.Point(254, 263)
        Me.BCancel.Name = "BCancel"
        Me.Helper.SetShowHelp(Me.BCancel, True)
        Me.BCancel.Size = New System.Drawing.Size(100, 23)
        Me.BCancel.TabIndex = 21
        Me.BCancel.Text = "&Cancel (Alt+C)"
        Me.BCancel.UseVisualStyleBackColor = True
        '
        'PenEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(472, 311)
        Me.Controls.Add(Me.PCompArray)
        Me.Controls.Add(Me.BCancel)
        Me.Controls.Add(Me.BOK)
        Me.Controls.Add(Me.PDashPattern)
        Me.Controls.Add(Me.HelpInfo)
        Me.Controls.Add(Me.PDashOffset)
        Me.Controls.Add(Me.PDashStyle)
        Me.Controls.Add(Me.PColor)
        Me.Controls.Add(Me.PAlignment)
        Me.Controls.Add(Me.PDashCap)
        Me.Controls.Add(Me.TLPEndCaps)
        Me.Controls.Add(Me.PWidth)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LChangeBG)
        Me.Controls.Add(Me.Preview)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Gainsboro
        Me.HelpButton = True
        Me.Helper.SetHelpString(Me, "")
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(200, 350)
        Me.Name = "PenEditor"
        Me.Helper.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Line style editor"
        CType(Me.Preview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLPEndCaps.ResumeLayout(False)
        CType(Me.PDashOffset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Preview As System.Windows.Forms.PictureBox
    Private WithEvents LChangeBG As System.Windows.Forms.LinkLabel
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents PWidth As System.Windows.Forms.NumericUpDown
    Private WithEvents PStartCap As System.Windows.Forms.ComboBox
    Private WithEvents PEndCap As System.Windows.Forms.ComboBox
    Private WithEvents TLPEndCaps As System.Windows.Forms.TableLayoutPanel
    Private WithEvents PDashCap As System.Windows.Forms.ComboBox
    Private WithEvents PAlignment As System.Windows.Forms.ComboBox
    Private WithEvents PColor As System.Windows.Forms.Label
    Private WithEvents PDashStyle As System.Windows.Forms.ComboBox
    Private WithEvents PDashOffset As System.Windows.Forms.NumericUpDown
    Private WithEvents HelpInfo As System.Windows.Forms.Label
    Private WithEvents Helper As System.Windows.Forms.HelpProvider
    Private WithEvents PDashPattern As System.Windows.Forms.TextBox
    Private WithEvents BOK As System.Windows.Forms.Button
    Private WithEvents BCancel As System.Windows.Forms.Button
    Private WithEvents PCompArray As System.Windows.Forms.TextBox
End Class
