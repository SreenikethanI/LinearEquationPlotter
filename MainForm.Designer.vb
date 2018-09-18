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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.a = New System.Windows.Forms.NumericUpDown()
        Me.b = New System.Windows.Forms.NumericUpDown()
        Me.c = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FinalEqn = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.maxX = New System.Windows.Forms.NumericUpDown()
        Me.minX = New System.Windows.Forms.NumericUpDown()
        Me.maxY = New System.Windows.Forms.NumericUpDown()
        Me.minY = New System.Windows.Forms.NumericUpDown()
        Me.MainDisplay = New LinearEquationGraphPlotter.SmartSizingPictureBox()
        CType(Me.a, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.b, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maxX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maxY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Coefficient for 'x' (&a):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Coefficient for 'y' (&b):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Constant (&c):"
        '
        'a
        '
        Me.a.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.a.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.a.DecimalPlaces = 3
        Me.a.Location = New System.Drawing.Point(134, 12)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(240, 19)
        Me.a.TabIndex = 3
        Me.a.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'b
        '
        Me.b.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.b.DecimalPlaces = 3
        Me.b.Location = New System.Drawing.Point(134, 37)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(240, 19)
        Me.b.TabIndex = 4
        Me.b.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'c
        '
        Me.c.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.c.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.c.DecimalPlaces = 3
        Me.c.Location = New System.Drawing.Point(134, 62)
        Me.c.Name = "c"
        Me.c.Size = New System.Drawing.Size(240, 19)
        Me.c.TabIndex = 5
        Me.c.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Final equation:"
        '
        'FinalEqn
        '
        Me.FinalEqn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FinalEqn.AutoEllipsis = True
        Me.FinalEqn.Font = New System.Drawing.Font("Georgia", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinalEqn.Location = New System.Drawing.Point(131, 84)
        Me.FinalEqn.Name = "FinalEqn"
        Me.FinalEqn.Size = New System.Drawing.Size(547, 34)
        Me.FinalEqn.TabIndex = 7
        Me.FinalEqn.Text = "ax + by + c = 0"
        Me.FinalEqn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(380, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Minimum X, Y:"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(379, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Maximum X, Y:"
        '
        'maxX
        '
        Me.maxX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maxX.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.maxX.DecimalPlaces = 3
        Me.maxX.Location = New System.Drawing.Point(472, 37)
        Me.maxX.Name = "maxX"
        Me.maxX.Size = New System.Drawing.Size(100, 19)
        Me.maxX.TabIndex = 11
        Me.maxX.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'minX
        '
        Me.minX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minX.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.minX.DecimalPlaces = 3
        Me.minX.Location = New System.Drawing.Point(472, 12)
        Me.minX.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.minX.Name = "minX"
        Me.minX.Size = New System.Drawing.Size(100, 19)
        Me.minX.TabIndex = 10
        Me.minX.Value = New Decimal(New Integer() {5, 0, 0, -2147483648})
        '
        'maxY
        '
        Me.maxY.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maxY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.maxY.DecimalPlaces = 3
        Me.maxY.Location = New System.Drawing.Point(578, 37)
        Me.maxY.Name = "maxY"
        Me.maxY.Size = New System.Drawing.Size(100, 19)
        Me.maxY.TabIndex = 13
        Me.maxY.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'minY
        '
        Me.minY.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.minY.DecimalPlaces = 3
        Me.minY.Location = New System.Drawing.Point(578, 12)
        Me.minY.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.minY.Name = "minY"
        Me.minY.Size = New System.Drawing.Size(100, 19)
        Me.minY.TabIndex = 12
        Me.minY.Value = New Decimal(New Integer() {5, 0, 0, -2147483648})
        '
        'MainDisplay
        '
        Me.MainDisplay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainDisplay.ErrorImage = Nothing
        Me.MainDisplay.Image = Nothing
        Me.MainDisplay.InitialImage = Nothing
        Me.MainDisplay.Location = New System.Drawing.Point(12, 121)
        Me.MainDisplay.Name = "MainDisplay"
        Me.MainDisplay.Size = New System.Drawing.Size(666, 168)
        Me.MainDisplay.TabIndex = 14
        Me.MainDisplay.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(690, 301)
        Me.Controls.Add(Me.MainDisplay)
        Me.Controls.Add(Me.maxY)
        Me.Controls.Add(Me.minY)
        Me.Controls.Add(Me.maxX)
        Me.Controls.Add(Me.minX)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.FinalEqn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.c)
        Me.Controls.Add(Me.b)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Gainsboro
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Linear Equation Graph Plotter | Sreenikethan I of IX-D (2018) | youtube.com/Sreen" & _
    "ikethanIyer"
        CType(Me.a, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.b, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maxX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maxY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents a As System.Windows.Forms.NumericUpDown
    Friend WithEvents b As System.Windows.Forms.NumericUpDown
    Friend WithEvents c As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FinalEqn As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents maxX As System.Windows.Forms.NumericUpDown
    Friend WithEvents minX As System.Windows.Forms.NumericUpDown
    Friend WithEvents maxY As System.Windows.Forms.NumericUpDown
    Friend WithEvents minY As System.Windows.Forms.NumericUpDown
    Friend WithEvents MainDisplay As LinearEquationGraphPlotter.SmartSizingPictureBox

End Class
