using DevExpress.Xpf.Core;
using System.Windows;
using System.Windows.Media;

namespace ThemeHelperWPF {
    public partial class App : Application {
        public App() {
            Theme.RegisterPredefinedPaletteThemes();

            var customPalette = new ThemePalette("CustomPalette");
            customPalette.SetColor("Foreground", Colors.Red);
            var customTheme = Theme.CreateTheme(customPalette, Theme.Office2016ColorfulSE);
            Theme.RegisterTheme(customTheme);
        }
    }
}
