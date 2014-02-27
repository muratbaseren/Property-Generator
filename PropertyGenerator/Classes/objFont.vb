Imports System.Drawing

Public Class objFont

    Private FntFmly_ As FontFamily

    Public Property FntFmly() As FontFamily
        Get
            Return Me.FntFmly_
        End Get
        Set(ByVal value As FontFamily)
            Me.FntFmly_ = value
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(ByVal family As FontFamily)
        Me.FntFmly_ = family
    End Sub

    Public Overrides Function ToString() As String
        Return Me.FntFmly_.Name.ToString()
    End Function
End Class
