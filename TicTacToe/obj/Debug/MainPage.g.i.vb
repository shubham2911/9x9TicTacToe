﻿

#ExternalChecksum("C:\Users\343-Guilty-Spark\documents\visual studio 2013\Projects\TicTacToe\TicTacToe\MainPage.xaml", "{406ea660-64cf-4c82-b6f0-42d48172a799}", "9AE0EDE3C20CAB4BACFE99BD3B55DA2C")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On


Namespace Global.TicTacToe

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
    Partial Class MainPage
        Inherits Global.Windows.UI.Xaml.Controls.Page

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents Ax As Global.Windows.UI.Xaml.Controls.Image
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents Ao As Global.Windows.UI.Xaml.Controls.Image

        Private _contentLoaded As Boolean

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub InitializeComponent()
            If _contentLoaded Then
                Return
            End If
            _contentLoaded = true

            Dim uri As New Global.System.Uri("ms-appx:///MainPage.xaml")
            Global.Windows.UI.Xaml.Application.LoadComponent(Me, uri, Global.Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application)

            Ax = CType(Me.FindName("Ax"), Global.Windows.UI.Xaml.Controls.Image)
            Ao = CType(Me.FindName("Ao"), Global.Windows.UI.Xaml.Controls.Image)
        End Sub
    End Class

End Namespace


