Imports System.Drawing.Drawing2D
Public Class PenEditor
    Private Const CompArrayHelp$ = "A compound line is made up of alternating parallel lines and spaces of varying widths. The values in the array specify the starting points of each component of the compound line relative to the line's width. The first value in the array specifies where the first component (a line) begins as a fraction of the distance across the width of the pen. The second value in the array specifies the beginning of the next component (a space) as a fraction of the distance across the width of the pen. The final value in the array specifies where the last component ends." & vbNewLine & vbNewLine _
                                 & "Suppose you want a line with two parallel lines where the width of the first line is 20 percent of the pen's width, the width of the space that separates the two lines is 50 percent of the pen' s width, and the width of the second line is 30 percent of the pen's width. So you need to set the compound array with the values 0.0, 0.2, 0.7, and 1.0."

    Private Initialized As Boolean = False
    Private _Pen As Pen = Pens.Black 'New Pen(Brushes.Black, 9) With {.DashPattern = {1.0!, 0.5!}, .CompoundArray = {0.0!, 1.0! / 3, 2.0! / 3, 1.0!}}
    Private _PreviewBackground As Color = Color.White
    Private _Smoothening As Boolean = True
    Public Property Pen As Pen
        Get
            Return _Pen
        End Get
        Set(value As Pen)
            If IsNothing(value) Then value = Pens.Black
            _Pen = value
            UpdateInputs()
            DisplayPreview()
        End Set
    End Property
    Public Property PreviewBackground As Color
        Get
            Return _PreviewBackground
        End Get
        Set(value As Color)
            If IsNothing(value) Then value = Color.White
            _PreviewBackground = value
            DisplayPreview()
        End Set
    End Property
    Public Property Smoothening As Boolean
        Get
            Return _Smoothening
        End Get
        Set(value As Boolean)
            _Smoothening = value
            DisplayPreview()
        End Set
    End Property

    Private Sub MeLoad() Handles Me.Load
        Helper.SetHelpString(Label9, CompArrayHelp)
        Helper.SetHelpString(PCompArray, CompArrayHelp)
        InitializeInputs()
        'Me.Show()
        Initialized = True

        UpdatePen()
    End Sub
    Private Sub MeClose(S As Object, E As FormClosingEventArgs) Handles Me.FormClosing
        Initialized = False
    End Sub
    Private Sub InitializeInputs()
        Dim Exclusions() As Object = {LineCap.Custom, LineCap.AnchorMask}
        Dim Defaults() As Object = {LineCap.ArrowAnchor, DashStyle.Solid, DashCap.Flat, PenAlignment.Center}

        'StartCap
        PStartCap.Items.Clear()
        For Each Entry$ In [Enum].GetNames(GetType(LineCap))
            If Exclusions.Contains([Enum].Parse(GetType(LineCap), Entry)) Then Continue For
            Dim CIndex% = PStartCap.Items.Add(Entry)
            If Defaults.Contains([Enum].Parse(GetType(LineCap), Entry)) Then PStartCap.SelectedIndex = CIndex
        Next
        'EndCap
        PEndCap.Items.Clear()
        For Each Entry$ In [Enum].GetNames(GetType(LineCap))
            If Exclusions.Contains([Enum].Parse(GetType(LineCap), Entry)) Then Continue For
            Dim CIndex% = PEndCap.Items.Add(Entry)
            If Defaults.Contains([Enum].Parse(GetType(LineCap), Entry)) Then PEndCap.SelectedIndex = CIndex
        Next
        'DashCap
        PDashCap.Items.Clear()
        For Each Entry$ In [Enum].GetNames(GetType(DashCap))
            If Exclusions.Contains([Enum].Parse(GetType(DashCap), Entry)) Then Continue For
            Dim CIndex% = PDashCap.Items.Add(Entry)
            If Defaults.Contains([Enum].Parse(GetType(DashCap), Entry)) Then PDashCap.SelectedIndex = CIndex
        Next
        'Color
        PColor.BackColor = Pen.Color
        'DashStyle
        PDashStyle.Items.Clear()
        For Each Entry$ In [Enum].GetNames(GetType(DashStyle))
            If Exclusions.Contains([Enum].Parse(GetType(DashStyle), Entry)) Then Continue For
            Dim CIndex% = PDashStyle.Items.Add(Entry)
            If Defaults.Contains([Enum].Parse(GetType(DashStyle), Entry)) Then PDashStyle.SelectedIndex = CIndex
        Next


        'Alignment
        PAlignment.Items.Clear()
        For Each Entry$ In [Enum].GetNames(GetType(PenAlignment))
            If Exclusions.Contains([Enum].Parse(GetType(PenAlignment), Entry)) Then Continue For
            Dim CIndex% = PAlignment.Items.Add(Entry)
            If Defaults.Contains([Enum].Parse(GetType(PenAlignment), Entry)) Then PAlignment.SelectedIndex = CIndex
        Next
    End Sub
    Private Function ParsePDashPattern(IfFailed() As Single) As Single()
        If Not (Not IsNothing(IfFailed) AndAlso IfFailed.Length > 0) Then IfFailed = {1}
        Dim Entries As New ObjectModel.Collection(Of Single)
        For Each Entry$ In PDashPattern.Text.Split({","c})
            Dim Current! = 0
            If Single.TryParse(Entry, Current) AndAlso Current > 0 Then Entries.Add(Current)
        Next
        If Not Entries.Count > 0 Then Return IfFailed : Exit Function
        Return Entries.ToArray
    End Function
    Private Function ParsePCompArray(IfFailed() As Single) As Single()
        'Dim Errors As Byte = 0
        'If Not PCA0.Value <= PCA1.Value Then Errors += 1
        'If Not PCA1.Value <= PCA2.Value Then Errors += 1
        'If Not PCA2.Value <= PCA3.Value Then Errors += 1
        'If Not (Not IsNothing(IfFailed) AndAlso IfFailed.Length > 0) Then IfFailed = {0, 1, 1, 1}
        'Return If(Errors = 0, {Single.Parse(PCA0.Value), Single.Parse(PCA1.Value), Single.Parse(PCA2.Value), Single.Parse(PCA3.Value)}, IfFailed)
        If Not (Not IsNothing(IfFailed) AndAlso IfFailed.Length > 0) Then IfFailed = {0, 1}
        Dim Entries As New ObjectModel.Collection(Of Single)
        Dim Last! = 0
        For Each Entry$ In PCompArray.Text.Split({","c})
            Dim Current! = 0
            If Single.TryParse(Entry, Current) AndAlso Current >= Last AndAlso Current <= 1 AndAlso Current >= 0 Then Entries.Add(Current) : Last = Current
        Next
        If Not Entries.Count Mod 2 = 0 Then Entries.Add(1)
        If Not Entries.Count > 0 Then Return IfFailed : Exit Function
        Return Entries.ToArray
    End Function

    Private Sub UpdateInputs() Handles PDashPattern.LostFocus, PCompArray.LostFocus
        PWidth.Value = Pen.Width
        PStartCap.SelectedIndex = PStartCap.Items.IndexOf([Enum].GetName(GetType(LineCap), Pen.StartCap))
        PEndCap.SelectedIndex = PEndCap.Items.IndexOf([Enum].GetName(GetType(LineCap), Pen.EndCap))
        PColor.BackColor = Color.FromArgb(255, Pen.Color)
        PDashStyle.SelectedIndex = PDashStyle.Items.IndexOf([Enum].GetName(GetType(DashStyle), Pen.DashStyle))
        PDashOffset.Value = Pen.DashOffset

        Dim DashStyleCustom As Boolean = (PDashStyle.SelectedIndex = PDashStyle.Items.IndexOf([Enum].GetName(GetType(DashStyle), DashStyle.Custom)))
        PDashPattern.Enabled = DashStyleCustom
        Label7.Enabled = DashStyleCustom
        If PDashPattern.Enabled And Not PDashPattern.Focused AndAlso DashStyleCustom Then PDashPattern.Text = String.Join(", ", Pen.DashPattern)

        If Not PCompArray.Focused Then PCompArray.Text = String.Join(", ", Pen.CompoundArray)
        'PCA1.Minimum = PCA0.Value
        'PCA2.Minimum = PCA1.Value
        'PCA3.Minimum = PCA2.Value
        'PCA2.Maximum = PCA3.Value
        'PCA1.Maximum = PCA2.Value
        'PCA0.Maximum = PCA1.Value
    End Sub
    Private Sub UpdatePen() Handles PWidth.ValueChanged, PStartCap.SelectedIndexChanged, PEndCap.SelectedIndexChanged, PDashCap.SelectedIndexChanged, PColor.BackColorChanged, PDashStyle.SelectedIndexChanged, PDashOffset.ValueChanged, PDashPattern.TextChanged, PCompArray.TextChanged ', PCA0.ValueChanged, PCA1.ValueChanged, PCA2.ValueChanged, PCA3.ValueChanged
        'Notes: If an exception occurs below regarding parsing of a value, the chances are that the ComboBox's text is empty.
        '       Values of ComboBoxes are filled by InitializeInputs(), in which some values are excluded. If another method sets
        '       Pen.Property to a value which is not an entry in the ComboBox, the ComboBox will remain empty. When it remains empty,
        '       the below method will fail as it relies on parsing a (valid) value of the ComboBox.
        'Notes: The Pen.DashPattern should NOT contain a 0. Please make sure 0 is not included in the array if testing is being done.
        If Not Initialized Then Exit Sub
        Dim Final As New Pen(Brushes.Black) With {.Width = PWidth.Value,
                                                  .StartCap = [Enum].Parse(GetType(LineCap), PStartCap.Text),
                                                  .EndCap = [Enum].Parse(GetType(LineCap), PEndCap.Text),
                                                  .DashCap = [Enum].Parse(GetType(DashCap), PDashCap.Text),
                                                  .Color = PColor.BackColor,
                                                  .DashStyle = [Enum].Parse(GetType(DashStyle), PDashStyle.Text),
                                                  .DashOffset = PDashOffset.Value,
                                                  .CompoundArray = ParsePCompArray({0, 1})}
        Dim ParsedDashPattern() As Single = ParsePDashPattern({1})
        If Final.DashStyle = DashStyle.Custom Then Final.DashPattern = ParsedDashPattern
        Pen = Final
        DisplayPreview()
    End Sub
    Private Sub DisplayPreview() Handles Preview.SizeChanged
        'If IsNothing(Pen) Then Preview.Image = Nothing : Exit Sub
        'If IsNothing(PreviewBackground) Then PreviewBackground = Color.White

        Dim Final As New Bitmap(Preview.Width, Preview.Height)
        Dim G As Graphics = Graphics.FromImage(Final)
        G.Clear(PreviewBackground)
        G.SmoothingMode = If(Smoothening, SmoothingMode.AntiAlias, SmoothingMode.None)
        If Not IsNothing(Pen) Then G.DrawLine(Pen, New PointF(Preview.Height / 2, Preview.Height / 2), New PointF(Preview.Width - (Preview.Height / 2), Preview.Height / 2))

        G.Dispose()
        Preview.Image = Final.Clone
        Final.Dispose()
    End Sub
    Private Sub ChangeColors(S As Object, E As EventArgs) Handles LChangeBG.Click, PColor.Click
        Dim PreviousColor As Color = If(S Is LChangeBG, If(IsNothing(PreviewBackground), Color.White, PreviewBackground), If(S Is PColor, PColor.BackColor, Color.White))
        Dim CDialog As New ColorDialog With {.AllowFullOpen = True,
                                             .AnyColor = True,
                                             .Color = PreviousColor,
                                             .FullOpen = True,
                                             .SolidColorOnly = False}
        If Not CDialog.ShowDialog = Windows.Forms.DialogResult.OK Then Exit Sub
        If S Is LChangeBG Then PreviewBackground = CDialog.Color
        If S Is PColor Then PColor.BackColor = CDialog.Color
        CDialog.Dispose()
    End Sub
End Class

' ╔═════╗╔═══════╗╔══════╗╔═══════╗    
' ╚═╗ ╔═╝║ ╔═══╗ ║╚╗ ╔═╗ ║║ ╔═══╗ ║╔═╗ 
'   ║ ║  ║ ║   ║ ║ ║ ║ ║ ║║ ║   ║ ║╚═╝ 
'   ║ ║  ║ ║   ║ ║ ║ ║ ║ ║║ ║   ║ ║╔═╗ 
'   ║ ║  ║ ╚═══╝ ║╔╝ ╚═╝ ║║ ╚═══╝ ║╚═╝ 
'   ╚═╝  ╚═══════╝╚══════╝╚═══════╝    
' • Update code for Compound Array: UpdateInputs(), UpdatePen(); use ParsePCompArray()
' ○ Add code for OK/Cancel
' ○ Re-set Tab Order
' • Add help messages to elements