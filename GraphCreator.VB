Imports System
''' <summary>This makes a Bitmap of a graph with the specified parameters.</summary>
<ComponentModel.Description("This makes a Bitmap of a graph with the specified parameters.")> _
Public Module GraphCreator
    ' ''' <summary>Represents a Point structure which can hold Decimal values for the X and Y co-ordinates.</summary>
    '<ComponentModel.Description("Represents a Point structure which can hold Decimal values for the X and Y co-ordinates.")> _
    'Public Structure PointD
    '    Public Property X As Decimal
    '    Public Property Y As Decimal
    '    ''' <summary>Creates a new instance of the PointD structure.</summary>
    '    ''' <param name="X">The X co-ordinate of the PointD structure.</param>
    '    ''' <param name="Y">The Y co-ordinate of the PointD structure.</param>
    '    <ComponentModel.Description("Creates a new instance of the PointD structure.")> _
    '    Public Sub New(X As Decimal, Y As Decimal)
    '        Me.X = X
    '        Me.Y = Y
    '    End Sub
    'End Structure
    ''' <summary>Creates a graph Bitmap with the specified parameters.</summary>
    ''' <param name="XAxisName">The label to keep for the X Axis (horizontal line).</param>
    ''' <param name="YAxisName">The label to keep for the Y Axis (vertical line).</param>
    ''' <param name="XAxisInterval">The interval of each division of the X Axis. For example, if you specify 5, the graph will show like 5, 10, 15, 20... on each division.</param>
    ''' <param name="YAxisInterval">The interval of each division of the Y Axis. For example, if you specify 5, the graph will show like 5, 10, 15, 20... on each division.</param>
    ''' <param name="Points">The 1-dimensional array of the points on the graph. Example: [0, 0], [1, 1].</param>
    ''' <returns>This function returns a Bitmap of a graph with the specified parameters.</returns>
    ''' <remarks>A tip: The order of the points matters. The order you specify will be exactly followed.</remarks>
    Public Function MakeGraph(XAxisName$, YAxisName$, XAxisInterval As Decimal, YAxisInterval As Decimal, Points() As PointF) As Bitmap
        ' BLOCK "This is for finding the Highest X and Y values of the points"
        Dim HighestPointX As Decimal = 0, HighestPointY As Decimal = 0
        Dim LowestPointX As Decimal = 0, LowestPointY As Decimal = 0
        For Each Point As PointF In Points
            'If Point.X > HighestPointX Then HighestPointX = Point.X
            'If Point.Y > HighestPointY Then HighestPointY = Point.Y
            'If Point.X < LowestPointX Then LowestPointX = Point.X
            'If Point.Y < LowestPointY Then LowestPointY = Point.Y
            HighestPointX = Math.Max(HighestPointX, Point.X)
            HighestPointY = Math.Max(HighestPointY, Point.Y)
            LowestPointX = Math.Min(LowestPointX, Point.X)
            LowestPointY = Math.Min(LowestPointY, Point.Y)
        Next
        'HighestPointX *= 10
        'LowestPointX *= 10
        'HighestPointY *= 10
        'LowestPointY *= 10
        ' END BLOCK
        ' BLOCK "This is for finding the total number of pixels that'll be taken by the points"
        Dim TotalPixelsX% = ((HighestPointX - LowestPointX) / XAxisInterval) * 10
        Dim TotalPixelsY% = ((HighestPointY - LowestPointY) / YAxisInterval) * 10
        ' END BLOCK
        ' BLOCK "This declares the starting position [0, 0] for reference"
        Dim StartPosX% = 25, StartPosY% = TotalPixelsY + 25
        Dim StartPos As New PointF(StartPosX, StartPosY)
        ' END BLOCK

        Dim BMP As New Bitmap(TotalPixelsX + 50, TotalPixelsY + 50)
        Dim G As Graphics = Graphics.FromImage(BMP)
        G.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        G.Clear(Color.White) 'This clears everything and fills with the White color
        BMP.SetPixel(StartPosX, StartPosY, Color.Black) 'This marks the starting point [0, 0] with a black pixel
        G.DrawLine(Pens.Black, StartPos, New PointF(TotalPixelsX + 25, StartPosY)) 'This is for drawing the X Axis LINE 
        G.DrawLine(Pens.Black, StartPos, New PointF(StartPosX, 25)) 'This is for drawing the Y Axis LINE 
        For X = 0 To TotalPixelsX Step 10 'This is for dividing the X Axis line equally with the specified interval
            Dim NewPoint As New PointF(StartPosX + X, StartPosY)
            BMP.SetPixel(NewPoint.X, NewPoint.Y, Color.Red)
            G.DrawLine(Pens.Red, NewPoint, New PointF(NewPoint.X, NewPoint.Y - 3))
        Next
        For Y = 0 To TotalPixelsY Step 10 'This is for dividing the Y Axis line equally with the specified interval
            Dim NewPoint As New PointF(StartPosX, StartPosY - Y)
            BMP.SetPixel(NewPoint.X, NewPoint.Y, Color.Red)
            G.DrawLine(Pens.Red, NewPoint, New PointF(NewPoint.X + 3, NewPoint.Y))
        Next

        Dim DisplayPoints As New List(Of PointF)
        For Each Point As PointF In Points
            Dim NewPoint As New PointF(StartPosX + ((Point.X * 10) / XAxisInterval),
                                       StartPosY - ((Point.Y * 10) / YAxisInterval))
            DisplayPoints.Add(NewPoint)
        Next
        'Select Case DisplayPoints.Count
        '    Case 2
        '        G.DrawLine(Pens.Lime, DisplayPoints(0), DisplayPoints(1))
        '    Case Is > 2
        '        G.DrawLines(Pens.Lime, DisplayPoints.ToArray())
        'End Select
        G.DrawLines(Pens.Lime, DisplayPoints.ToArray)
        For Each Point As PointF In DisplayPoints
            'BMP.SetPixel(Point.X, Point.Y, Color.Blue)
            G.FillRectangle(Brushes.Blue, New RectangleF(Point, New SizeF(1, 1)))
        Next

        Return BMP
    End Function
End Module