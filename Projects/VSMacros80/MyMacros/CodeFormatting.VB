Imports System
Imports EnvDTE
Imports EnvDTE80
Imports EnvDTE90
Imports System.Diagnostics

Public Module CodeFormatting

    Public Sub UseTabsToIndent()
        InsertTabs = True
        'MsgBox("C# editor will now use tabs for indentation.", MsgBoxStyle.Information, "Tabs enabled")
    End Sub

    Public Sub UseSpacesToIndent()
        InsertTabs = False
        'MsgBox("C# editor will now use spaces for indentation.", MsgBoxStyle.Information, "Spaces enabled")
    End Sub

    Public Property InsertTabs() As Boolean
        Get
            Return DTE.Properties("TextEditor", "CSharp").Item("InsertTabs").Value
        End Get
        Set(ByVal value As Boolean)
            DTE.Properties("TextEditor", "CSharp").Item("InsertTabs").Value = value
        End Set
    End Property

End Module

