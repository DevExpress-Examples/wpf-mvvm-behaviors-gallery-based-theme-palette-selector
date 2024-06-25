<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/187842513/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T828699)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

#  WPF MVVM Behaviors - Display a Theme Palette Selector Based on a Ribbon Gallery

The [RibbonGalleryItemThemePaletteSelectorBehavior](https://docs.devexpress.com/WPF/DevExpress.Xpf.Ribbon.RibbonGalleryItemThemePaletteSelectorBehavior) populates the associated [RibbonGalleryBarItem](https://docs.devexpress.com/WPF/DevExpress.Xpf.Ribbon.RibbonGalleryBarItem) with the available palettes and allows you to choose the application's palette.

Attach the behavior to a [RibbonGalleryBarItem](https://docs.devexpress.com/WPF/DevExpress.Xpf.Ribbon.RibbonGalleryBarItem) in a [RibbonControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Ribbon.RibbonControl) to use it.

![DevExpress WPF MVVM Behaviors | RibbonGalleryItemThemePaletteSelectorBehavior](https://user-images.githubusercontent.com/12169834/134533357-1bd6f6a7-04da-43b8-ad43-813182a8428a.png)


## Persist Theme Selection between Application Runs

Use can save the application's theme and palette to the configuration file and restore them on the next application run.

To save an applied theme and palette, use the static [ApplicationThemeHelper.SaveApplicationThemeName](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.ApplicationThemeHelper.SaveApplicationThemeName) method to save the theme name specified in the static [ApplicationThemeHelper.ApplicationThemeName](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.ApplicationThemeHelper.ApplicationThemeName) property.

Call the static [ApplicationThemeHelper.UpdateApplicationThemeName](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.ApplicationThemeHelper.UpdateApplicationThemeName) method to retrieve the theme name from the configuration file.

<!-- default file list -->
## Files to Look At

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
<!-- default file list end -->

## Documentation

- [RibbonGalleryItemThemePaletteSelectorBehavior](https://docs.devexpress.com/WPF/DevExpress.Xpf.Ribbon.RibbonGalleryItemThemePaletteSelectorBehavior)
- [Behaviors](https://docs.devexpress.com/WPF/17442/mvvm-framework/behaviors)

## More Examples
- [WPF MVVM Behaviors - Display Theme Selectors Based on BarItems and Hide Themes from List](https://github.com/DevExpress-Examples/wpf-mvvm-behaviors-barItems-based-theme-selectors)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-mvvm-behaviors-gallery-based-theme-palette-selector&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-mvvm-behaviors-gallery-based-theme-palette-selector&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
