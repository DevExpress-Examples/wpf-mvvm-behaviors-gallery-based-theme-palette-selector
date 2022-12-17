Imports DevExpress.Xpf.Core
Imports System.Windows
Imports System.Windows.Media

Namespace ThemeHelperWPF

    Public Partial Class App
        Inherits Application

        Public Sub New()
            Call Theme.RegisterPredefinedPaletteThemes()
            Dim customPalette = New ThemePalette("CustomPalette")
            customPalette.SetColor("Foreground", Colors.Red)
            Dim customTheme = Theme.CreateTheme(customPalette, Theme.Office2016ColorfulSE)
            Theme.RegisterTheme(customTheme)
        End Sub
    End Class
End Namespace
