''' <summary>A control for displaying images. This has the feature of Smart Sizing, which controls how the image is displayed based on its resolution.</summary>
<System.ComponentModel.Description("A control for displaying images. This has the feature of Smart Sizing, which controls how the image is displayed based on its resolution.")> _
Public Class SmartSizingPictureBox
    Inherits Windows.Forms.PictureBox
    Private _SmartSizingEnabled As Boolean = True
    ''' <summary>Gets or sets whether Smart Sizing is enabled.</summary>
    <System.ComponentModel.Description("Gets or sets whether Smart Sizing is enabled.")>
    <System.ComponentModel.DefaultValue(True)>
    Public Property SmartSizingEnabled As Boolean
        Get
            Return _SmartSizingEnabled
        End Get
        Set(NewValue As Boolean)
            Dim OldValue As Boolean = _SmartSizingEnabled
            _SmartSizingEnabled = NewValue
            SmartPictureSizing()
            If Not OldValue = NewValue Then RaiseEvent SmartSizingEnabledChanged(Me, New SmartSizingEnabledChangedEventArgs(OldValue, NewValue))
        End Set
    End Property
    Private Sub SmartPictureSizing() Handles MyBase.SizeChanged ', Me.ImageChanged, Me.SmartSizingEnabledChanged <== not handling them here because this must be called BEFORE the event is raised.
        If Not SmartSizingEnabled Then Exit Sub ' Me.SizeMode = PictureBoxSizeMode.Normal : Exit Sub
        Dim P As PictureBox = Me
        If IsNothing(P.Image) Then Exit Sub
        If P.Height > P.Image.Height Or P.Width > P.Image.Width Then P.SizeMode = PictureBoxSizeMode.CenterImage
        If P.Height < P.Image.Height Or P.Width < P.Image.Width Then P.SizeMode = PictureBoxSizeMode.Zoom
    End Sub
    Public Overloads Property Image As Image
        Get
            Return MyBase.Image
        End Get
        Set(value As Image)
            Dim OldImage As Image = If(IsNothing(MyBase.Image), Nothing, MyBase.Image.Clone)
            MyBase.Image = value
            SmartPictureSizing()
            RaiseEvent ImageChanged(Me, New ImageChangedEventArgs(OldImage.Clone, value))
            If Not IsNothing(OldImage) Then OldImage.Dispose()
        End Set
    End Property
#Region "ImageChanged"
    ''' <summary>Occurs when the Image property changes.</summary>
    ''' <param name="Sender">The object which raised this event.</param>
    ''' <param name="EventArguments">The information about the event raised.</param>
    <System.ComponentModel.Description("Occurs when the Image property changes.")> _
    Public Event ImageChanged(Sender As Object, EventArguments As ImageChangedEventArgs)
    ''' <summary>This class contains data about the change in the Image property.</summary>
    <System.ComponentModel.Description("This class contains data about the change in the Image property.")> _
    Public Class ImageChangedEventArgs
        Private _OldValue As Image, _NewValue As Image
        ''' <summary>Gets the value which was before the change occured.</summary>
        <System.ComponentModel.Description("Gets the value which was before the change occured.")> _
        Public ReadOnly Property OldValue
            Get
                Return _OldValue
            End Get
        End Property
        ''' <summary>Gets the value which is after the change occured.</summary>
        <System.ComponentModel.Description("Gets the value which is after the change occured.")> _
        Public ReadOnly Property NewValue
            Get
                Return _NewValue
            End Get
        End Property
        ''' <summary>Creates a new instance of the ImageChangedEventArgs class.</summary>
        ''' <param name="OldValue">The value which was before the change occured.</param>
        ''' <param name="NewValue">The value which is after the change occured.</param>
        <System.ComponentModel.Description("Creates a new instance of the ImageChangedEventArgs class.")> _
        Public Sub New(OldValue As Image, NewValue As Image)
            _OldValue = OldValue
            _NewValue = NewValue
        End Sub
    End Class
#End Region
#Region "SmartSizingEnabledChanged"
    ''' <summary>Occurs when the SmartSizingEnabled property changes.</summary>
    ''' <param name="Sender">The object which raised this event.</param>
    ''' <param name="EventArguments">The information about the event raised.</param>
    <System.ComponentModel.Description("Occurs when the SmartSizingEnabled property changes.")> _
    Public Event SmartSizingEnabledChanged(Sender As Object, EventArguments As SmartSizingEnabledChangedEventArgs)
    ''' <summary>This class contains data about the change in the SmartSizingEnabled property.</summary>
    <System.ComponentModel.Description("This class contains data about the change in the SmartSizingEnabled property.")> _
    Public Class SmartSizingEnabledChangedEventArgs
        Private _OldValue As Boolean, _NewValue As Boolean
        ''' <summary>Gets the value which was before the change occured.</summary>
        <System.ComponentModel.Description("Gets the value which was before the change occured.")> _
        Public ReadOnly Property OldValue
            Get
                Return _OldValue
            End Get
        End Property
        ''' <summary>Gets the value which is after the change occured.</summary>
        <System.ComponentModel.Description("Gets the value which is after the change occured.")> _
        Public ReadOnly Property NewValue
            Get
                Return _NewValue
            End Get
        End Property
        ''' <summary>Creates a new instance of the SmartSizingEnabledChangedEventArgs class.</summary>
        ''' <param name="OldValue">The value which was before the change occured.</param>
        ''' <param name="NewValue">The value which is after the change occured.</param>
        <System.ComponentModel.Description("Creates a new instance of the SmartSizingEnabledChangedEventArgs class.")> _
        Public Sub New(OldValue As Boolean, NewValue As Boolean)
            _OldValue = OldValue
            _NewValue = NewValue
        End Sub
    End Class
#End Region
End Class