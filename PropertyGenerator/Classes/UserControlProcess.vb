#Region "imports"
Imports System.Text
#End Region

Public Class UserControlProcess

    Public Sub New()

    End Sub

    Public Function CreateClassText(ByVal ClassName As String, ByVal SubList As ListView, ByVal InheritanceList As ListView, ByVal ImportanceList As ListView) As String
        Dim ClassText As StringBuilder = New StringBuilder
        Dim VariableText As StringBuilder = New StringBuilder
        Dim PropertyText As StringBuilder = New StringBuilder
        Dim SubText As StringBuilder = New StringBuilder
        Dim InheritText As StringBuilder = New StringBuilder
        Dim ImportText As StringBuilder = New StringBuilder

        Dim itm As ListViewItem



        'ImportText
        '==============================================================================
        ImportText.Append("#Region " & Chr(34) & "Imports" & Chr(34) & vbCrLf)
        For Each itm In ImportanceList.Items
            ImportText.Append("Imports " & itm.SubItems(0).Text & vbCrLf)
        Next
        ImportText.Append("#End Region" & vbCrLf & vbCrLf)
        ImportText.Append("Public Class " & ClassName & vbCrLf & vbCrLf)



        'InheritText
        '==============================================================================
        For Each itm In InheritanceList.Items
            InheritText.Append("    Inherits " & itm.SubItems(0).Text & vbCrLf)
        Next
        InheritText.Append(vbCrLf)



        'VariableText
        '==============================================================================
        VariableText.Append("#Region " & Chr(34) & "LocalVariables" & Chr(34) & vbCrLf)
        For Each itm In SubList.Items
            If itm.SubItems(1).Text.ToLower = "variable" Then
                VariableText.Append("    " & itm.SubItems(0).Text & " " & itm.SubItems(2).Text & "_ As " & itm.SubItems(4).Text & vbCrLf)
            End If
        Next
        VariableText.Append("#End Region" & vbCrLf & vbCrLf)



        'PropertyText
        '==============================================================================
        PropertyText.Append("#Region " & Chr(34) & "Properties" & Chr(34) & vbCrLf)
        For Each itm In SubList.Items
            If itm.SubItems(1).Text.ToLower = "property" OrElse itm.SubItems(1).Text.ToLower = "readonly property" Then
                PropertyText.Append("    " & itm.SubItems(0).Text & " " & itm.SubItems(1).Text & " " & itm.SubItems(2).Text & "() As " & itm.SubItems(4).Text & vbCrLf)
                PropertyText.Append("        Get" & vbCrLf)
                PropertyText.Append("            Return Me." & itm.SubItems(2).Text & "_" & vbCrLf)
                PropertyText.Append("        End Get" & vbCrLf)

                If itm.SubItems(1).Text.ToLower = "property" Then
                    PropertyText.Append("        Set(ByVal value As " & itm.SubItems(4).Text & ")" & vbCrLf)
                    PropertyText.Append("            Me." & itm.SubItems(2).Text & "_ = value" & vbCrLf)
                    PropertyText.Append("        End Set" & vbCrLf)
                End If

                PropertyText.Append("    End Property" & vbCrLf)
            End If
        Next
        PropertyText.Append("#End Region" & vbCrLf & vbCrLf)



        Dim arr As ArrayList
        Dim arr2 As ArrayList

        'SubText-Constructor
        '==============================================================================
        SubText.Append("#Region " & Chr(34) & "Constructors" & Chr(34) & vbCrLf)
        For Each itm In SubList.Items
            If itm.SubItems(2).Text.ToLower = "new" Then
                SubText.Append("    " & itm.SubItems(0).Text & " " & itm.SubItems(1).Text & " " & itm.SubItems(2).Text)
                If itm.SubItems(3).Text.ToLower = "none" Then
                    SubText.Append("()")
                    If itm.SubItems(1).Text.ToLower = "function" Then SubText.Append(" As " & itm.SubItems(4).Text)
                    SubText.Append(vbCrLf)
                Else
                    SubText.Append(" " & itm.SubItems(3).Text)
                    If itm.SubItems(1).Text.ToLower = "function" Then SubText.Append(" As " & itm.SubItems(4).Text)
                    SubText.Append(vbCrLf)
                    Dim params As String = itm.SubItems(3).Text.Substring(1, itm.SubItems(3).Text.Length - 2)
                    arr = New ArrayList
                    arr.Add(params.ToString.Split(","))

                    For Each str As String In arr.Item(0)
                        'Dim str As String = arr(0)(i).ToString
                        arr2 = New ArrayList
                        arr2.Add(str.Trim.Split(" "))

                        SubText.Append("        Me." & arr2(0)(1).ToString & "_ = " & arr2(0)(1).ToString & vbCrLf)
                    Next
                End If
                SubText.Append("    End " & itm.SubItems(1).Text & vbCrLf & vbCrLf)
            End If
        Next
        SubText.Append("#End Region" & vbCrLf & vbCrLf)



        'SubText-Methods
        '==============================================================================
        SubText.Append("#Region " & Chr(34) & "Methods" & Chr(34) & vbCrLf)
        For Each itm In SubList.Items
            If itm.SubItems(2).Text.ToLower <> "new" AndAlso _
               itm.SubItems(1).Text.ToLower <> "property" AndAlso _
               itm.SubItems(1).Text.ToLower <> "readonly property" AndAlso _
               itm.SubItems(1).Text.ToLower <> "variable" Then
                SubText.Append("    " & itm.SubItems(0).Text & " " & itm.SubItems(1).Text & " " & itm.SubItems(2).Text)
                If itm.SubItems(3).Text.ToLower = "none" Then
                    SubText.Append("()")
                    If itm.SubItems(1).Text.ToLower = "function" Then SubText.Append(" As " & itm.SubItems(4).Text)
                    SubText.Append(vbCrLf)
                Else
                    SubText.Append(" " & itm.SubItems(3).Text)
                    If itm.SubItems(1).Text.ToLower = "function" Then SubText.Append(" As " & itm.SubItems(4).Text)
                    SubText.Append(vbCrLf)


                    Dim params As String = itm.SubItems(3).Text.Substring(1, itm.SubItems(3).Text.Length - 1)
                    arr = New ArrayList
                    arr.Add(params.ToString.Split(","))

                    For Each str As String In arr.Item(0)
                        arr2 = New ArrayList
                        arr2.Add(str.Trim.Split(" "))

                        SubText.Append("        Me." & arr2(0)(1).ToString & "_ = " & arr2(0)(1).ToString & vbCrLf)
                    Next
                End If

                If itm.SubItems(1).Text.ToLower = "protected sub" Then
                    SubText.Append("    End Sub" & vbCrLf & vbCrLf)
                ElseIf itm.SubItems(1).Text.ToLower = "function" Then
                    SubText.Append("        Return " & itm.SubItems(2).Text & vbCrLf)
                    SubText.Append("    End " & itm.SubItems(1).Text & vbCrLf & vbCrLf)
                Else
                    SubText.Append("    End " & itm.SubItems(1).Text & vbCrLf & vbCrLf)
                End If
            End If
        Next
        SubText.Append("#End Region" & vbCrLf & vbCrLf)

        ClassText.Append(ImportText.ToString & InheritText.ToString & VariableText.ToString & PropertyText.ToString & SubText.ToString)
        ClassText.Append("End Class")

        Return ClassText.ToString
    End Function

End Class