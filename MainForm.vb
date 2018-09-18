Public Class MainForm
    ''' <summary>This function plots a graph of a Linear equation in the form of ax + by + c = 0.</summary>
    ''' <param name="a">The value of the variable "a" in ax + by + c = 0.</param>
    ''' <param name="b">The value of the variable "b" in ax + by + c = 0.</param>
    ''' <param name="c">The value of the variable "c" in ax + by + c = 0.</param>
    ''' <param name="XAxisInterval">The length, in "units", of each division of the X axis.</param>
    ''' <param name="YAxisInterval">The length, in "units", of each division of the Y axis.</param>
    ''' <param name="XAxisDivLength">The length, in pixels, of each displayed division of the X axis.</param>
    ''' <param name="YAxisDivLength">The length, in pixels, of each displayed division of the Y axis.</param>
    ''' <param name="MaxXNegative">The negative limit of the X axis. Must be equal or less than 0, If not then the graph may be plotted out of the Bitmap range.</param>
    ''' <param name="MaxXPositive">The positive limit of the X axis. Must be equal or more than 0. If not then the graph may be plotted out of the Bitmap.</param>
    ''' <param name="MaxYNegative">The negative limit of the Y axis. Must be equal or less than 0, If not then the graph may be plotted out of the Bitmap range.</param>
    ''' <param name="MaxYPositive">The positive limit of the Y axis. Must be equal or more than 0. If not then the graph may be plotted out of the Bitmap.</param>
    ''' <param name="Back">The background color used in the final Bitmap.</param>
    ''' <param name="Axes">The System.Pen style to be used to draw each of the X and Y axes.</param>
    ''' <param name="AxesDiv">The System.Pen style to be used to draw each of the divisions of the X and Y axes.</param>
    ''' <param name="AxesDivLength">The height/displacement of each of the divisions from the X and Y axes.</param>
    ''' <param name="Line">The System.Pen style to be used to draw the actual graphing line.</param>
    ''' <param name="LineAxesIntersectionDot">[OPTIONAL] The color of the dot (circle) to be placed at the intersection of the actual line on the X and Y axes. Provide a null value to not place a dot.</param>
    ''' <param name="Padding">[OPTIONAL] The padding of the drawn graph from the bounds of the final Bitmap. Leave it empty to have a default padding of 10 pixels.</param>
    Public Shared Function CreateLinearEquationGraph(a!, b!, c!, XAxisInterval!, YAxisInterval!, XAxisDivLength%, YAxisDivLength%, MaxXNegative!, MaxXPositive!, MaxYNegative!, MaxYPositive!,
                                                     Back As Color, Axes As Pen, AxesDiv As Pen, AxesDivLength!, Line As Pen, Optional LineAxesIntersectionDot As Color = Nothing, Optional Padding As Padding = Nothing) As Bitmap
        'Code by Sreenikethan I of IX-D (2018)
        'youtube.com/SreenikethanIyer

        'Initialize null parameters
        Padding = If(IsNothing(Padding), New Padding(10), Padding)

        'Calculate graphing parameters and references
        Dim Width! = (((MaxXPositive - MaxXNegative) / XAxisInterval) * XAxisDivLength) + Padding.Left + Padding.Right
        Dim Height! = (((MaxYPositive - MaxYNegative) / YAxisInterval) * YAxisDivLength) + Padding.Top + Padding.Bottom
        Dim StartPos As New PointF(Padding.Left + ((MaxXNegative * -1 * XAxisDivLength) / XAxisInterval), Height - Padding.Bottom - ((MaxYNegative * -1 * YAxisDivLength) / YAxisInterval))
        Dim PaddingBounds As New RectangleF(Padding.Left, Padding.Top, Math.Ceiling(Width - Padding.Horizontal), Math.Ceiling(Height - Padding.Vertical))

        'Prepare Bitmap and Graphics as surface
        Dim Final As New Bitmap(Integer.Parse(Math.Ceiling(Width)), Integer.Parse(Math.Ceiling(Height)))
        Dim G As Graphics = Graphics.FromImage(Final)
        G.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        G.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
        G.Clear(Back)
        
        'Draw the axes
        Dim X1 As New PointF(Padding.Left, StartPos.Y)
        Dim X2 As New PointF(Width - Padding.Right, StartPos.Y)
        Dim Y1 As New PointF(StartPos.X, Padding.Top)
        Dim Y2 As New PointF(StartPos.X, Height - Padding.Bottom)
        G.DrawLine(Axes, X1, X2)
        G.DrawLine(Axes, Y1, Y2)

        'Draw the axes' divisions
        For DivXRight! = StartPos.X To Width - Padding.Right Step XAxisDivLength
            G.DrawLine(AxesDiv, New PointF(DivXRight, StartPos.Y - AxesDivLength), New PointF(DivXRight, StartPos.Y + AxesDivLength))
        Next
        For DivXLeft! = StartPos.X To Padding.Left Step -XAxisDivLength
            If DivXLeft = StartPos.X Then Continue For
            G.DrawLine(AxesDiv, New PointF(DivXLeft, StartPos.Y - AxesDivLength), New PointF(DivXLeft, StartPos.Y + AxesDivLength))
        Next
        For DivYDown! = StartPos.Y To Height - Padding.Bottom Step YAxisDivLength
            G.DrawLine(AxesDiv, New PointF(StartPos.X - AxesDivLength, DivYDown), New PointF(StartPos.X + AxesDivLength, DivYDown))
        Next
        For DivYUp! = StartPos.Y To Padding.Top Step -YAxisDivLength
            If DivYUp = StartPos.Y Then Continue For
            G.DrawLine(AxesDiv, New PointF(StartPos.X - AxesDivLength, DivYUp), New PointF(StartPos.X + AxesDivLength, DivYUp))
        Next

        'Prepare and draw endpoints
        Dim Leftmost As New PointF(StartPos.X + ((MaxXNegative / XAxisInterval) * XAxisDivLength),
                                   StartPos.Y - ((LinearEquations2Vars.FindY(a, b, c, MaxXNegative) / YAxisInterval) * YAxisDivLength))
        Dim Rightmost As New PointF(StartPos.X + ((MaxXPositive / XAxisInterval) * XAxisDivLength),
                                    StartPos.Y - ((LinearEquations2Vars.FindY(a, b, c, MaxXPositive) / YAxisInterval) * YAxisDivLength))
        Dim XAxisMeetingPoint As New PointF(StartPos.X + ((0 / XAxisInterval) * XAxisDivLength),
                                            StartPos.Y - ((LinearEquations2Vars.FindY(a, b, c, 0) / YAxisInterval) * YAxisDivLength))
        Dim YAxisMeetingPoint As New PointF(StartPos.X + ((LinearEquations2Vars.FindX(a, b, c, 0) / XAxisInterval) * XAxisDivLength),
                                            StartPos.Y - ((0 / YAxisInterval) * YAxisDivLength))
        If Not RectFContainsIncl(PaddingBounds, Leftmost) Then Leftmost = New PointF(StartPos.X + ((LinearEquations2Vars.FindX(a, b, c, MaxYPositive) / XAxisInterval) * XAxisDivLength),
                                                                                     StartPos.Y - ((MaxYPositive / YAxisInterval) * YAxisDivLength))
        If Not RectFContainsIncl(PaddingBounds, Rightmost) Then Rightmost = New PointF(StartPos.X + ((LinearEquations2Vars.FindX(a, b, c, MaxYNegative) / XAxisInterval) * XAxisDivLength),
                                                                                       StartPos.Y - ((MaxYNegative / YAxisInterval) * YAxisDivLength))
        G.DrawLine(Line, Leftmost, Rightmost)
        If RectFContainsIncl(PaddingBounds, XAxisMeetingPoint) Then G.FillEllipse(New SolidBrush(LineAxesIntersectionDot), New Rectangle(XAxisMeetingPoint.X - (Axes.Width * 3), XAxisMeetingPoint.Y - (Axes.Width * 3), Axes.Width * 6, Axes.Width * 6))
        If RectFContainsIncl(PaddingBounds, YAxisMeetingPoint) Then G.FillEllipse(New SolidBrush(LineAxesIntersectionDot), New Rectangle(YAxisMeetingPoint.X - (Axes.Width * 3), YAxisMeetingPoint.Y - (Axes.Width * 3), Axes.Width * 6, Axes.Width * 6))

        'Return final Bitmap and cleanup
        G.Dispose()
        Try
            Return Final.Clone
        Finally
            Final.Dispose()
        End Try
    End Function
    Public Shared Function RectFContainsIncl(RectF As RectangleF, PointFToCheck As PointF) As Boolean
        Return (PointFToCheck.X >= RectF.X) And (PointFToCheck.Y >= RectF.Y) And (PointFToCheck.X <= RectF.Width + RectF.X) And (PointFToCheck.Y <= RectF.Height + RectF.Y)
    End Function

    Public Sub MeLoad() Handles Me.Load
        a.Minimum = Decimal.MinValue : a.Maximum = Decimal.MaxValue
        b.Minimum = Decimal.MinValue : b.Maximum = Decimal.MaxValue
        c.Minimum = Decimal.MinValue : c.Maximum = Decimal.MaxValue
        minX.Minimum = Decimal.MinValue : minX.Maximum = Decimal.MaxValue
        minY.Minimum = Decimal.MinValue : minY.Maximum = Decimal.MaxValue
        maxX.Minimum = Decimal.MinValue : maxX.Maximum = Decimal.MaxValue
        maxY.Minimum = Decimal.MinValue : maxY.Maximum = Decimal.MaxValue
    End Sub
    Public Sub Start() Handles Me.Click
        'Me.BackgroundImage = GraphCreator.MakeGraph("", "", 1, 1, {New PointF(20, LinearEquations2Vars.FindY(a.Value, b.Value, c.Value, 20)), New PointF(LinearEquations2Vars.FindX(a.Value, b.Value, c.Value, 20), 20)})
        Dim LineCap As New Drawing2D.AdjustableArrowCap(3.75, 3.75, True)
        'LineCap.BaseCap = Drawing2D.LineCap.ArrowAnchor
        On Error Resume Next
        Dim Final As Bitmap = CreateLinearEquationGraph(a.Value, b.Value, c.Value, 1, 1, 35, 35, minX.Value, maxX.Value, minY.Value, maxY.Value, Color.FromArgb(49, 49, 49), Pens.Gainsboro, Pens.Red, 5, New Pen(Brushes.Lime) With {.StartCap = Drawing2D.LineCap.Custom, .EndCap = Drawing2D.LineCap.Custom, .CustomStartCap = LineCap, .CustomEndCap = LineCap}, Color.Orange, New Padding(10))
        MainDisplay.Image = Final
    End Sub
    Public Sub UpdateFinalEquation() Handles Me.Load, a.ValueChanged, b.ValueChanged, c.ValueChanged, minX.ValueChanged, minY.ValueChanged, maxX.ValueChanged, maxY.ValueChanged
        FinalEqn.Text = a.Value & "x " _
                      & If(b.Value < 0, "-", "+") & " " & Math.Abs(b.Value) & "y " _
                      & If(c.Value < 0, "-", "+") & " " & Math.Abs(c.Value) & " = 0"
        Start()
    End Sub
    Public Sub KeyboardShortcuts(S As Object, E As KeyEventArgs) Handles Me.KeyUp
        If Not S Is Me Then Exit Sub
        'If E.Control And Not E.Alt And Not E.Shift And E.KeyCode = Keys.S Then SaveGraph()
        If E.Control And Not E.Alt And Not E.Shift And E.KeyCode = Keys.P Then PenEditor.Show() : PenEditor.Focus()
    End Sub
    Public Sub SaveGraph()
        If IsNothing(MainDisplay.Image) Then Exit Sub
        Dim SDialog As New SaveFileDialog With {.AddExtension = True,
                                                .DereferenceLinks = True,
                                                .Filter = "Bitmap images (*.BMP; *.DIB)|*.BMP; *.DIB|Joint Photographic Experts Group (JPEG) image format (*.JPG; *.JPEG; *.JPE; *.JFIF)|*.JPG; *.JPEG; *.JPE; *.JFIF|Graphics Interchange Format (*.GIF)|*.GIF|Tagged Image File Format (*.TIF; *.TIFF)|*.TIF; *.TIFF|Portable Network Graphics (*.PNG)|*.PNG",
                                                .FilterIndex = 5,
                                                .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop,
                                                .OverwritePrompt = True,
                                                .Title = "Save image as..."}
        If Not SDialog.ShowDialog = Windows.Forms.DialogResult.OK Then Exit Sub
        Dim ImageFileFormat As Imaging.ImageFormat
        Select Case SDialog.FilterIndex
            Case 1 : ImageFileFormat = Imaging.ImageFormat.Bmp
            Case 2 : ImageFileFormat = Imaging.ImageFormat.Jpeg
            Case 3 : ImageFileFormat = Imaging.ImageFormat.Gif
            Case 4 : ImageFileFormat = Imaging.ImageFormat.Tiff
            Case 5 : ImageFileFormat = Imaging.ImageFormat.Png
            Case Else : ImageFileFormat = Imaging.ImageFormat.Png
        End Select
        MainDisplay.Image.Save(SDialog.FileName, ImageFileFormat)
    End Sub
End Class

Public MustInherit Class LinearEquations2Vars
    Public Shared Function FindX!(a!, b!, c!, y!)
        Dim Final! = ((-(b * y) - c)) / a
        Return Final
    End Function
    Public Shared Function FindY!(a!, b!, c!, x!)
        Dim Final! = ((-(a * x) - c)) / b
        Return Final
    End Function
End Class