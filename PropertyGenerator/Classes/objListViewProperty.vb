Public Class objListViewProperty

#Region "Local Variables"
    Private lsvCaption_ As String
    Private lblCount_ As ToolStripStatusLabel
#End Region

#Region "Properties"
    Public Property lsvCaption() As String
        Get
            Return Me.lsvCaption_
        End Get
        Set(ByVal value As String)
            Me.lsvCaption_ = value
        End Set
    End Property
    Public Property lblCount() As ToolStripStatusLabel
        Get
            Return Me.lblCount_
        End Get
        Set(ByVal value As ToolStripStatusLabel)
            Me.lblCount_ = value
        End Set
    End Property
#End Region

#Region "Constructors"
    Public Sub New()

    End Sub
    Public Sub New(ByVal lsvCaption As String)
        Me.lsvCaption_ = lsvCaption
    End Sub
    Public Sub New(ByVal lblCount As ToolStripStatusLabel)
        Me.lblCount_ = lblCount
    End Sub
    Public Sub New(ByVal lsvCaption As String, ByVal lblCount As ToolStripStatusLabel)
        Me.lsvCaption_ = lsvCaption
        Me.lblCount_ = lblCount
    End Sub
#End Region

#Region "Methods"

#End Region
End Class
