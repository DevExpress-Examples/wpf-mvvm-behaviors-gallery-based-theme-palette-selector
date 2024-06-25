<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/187842513/19.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T828699)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
<!-- default file list end -->
# How to Implement a Theme Palette Selector Based on a Bar Item


<p>This example demonstrates how to implement the theme palette selector functionality in WPF applications. 
The <strong>RibbonGalleryItemThemePaletteSelectorBehavior</strong> is behavior that automatically populates the associated <strong>RibbonGalleryBarItem</strong> with all available predefined palettes. Use this behavior to choose a palette applied to your application.</p>

```xaml
<dxr:RibbonGalleryBarItem ... >
    <dxmvvm:Interaction.Behaviors>
        <dxr:RibbonGalleryItemThemePaletteSelectorBehavior />
    </dxmvvm:Interaction.Behaviors>
</dxr:RibbonGalleryBarItem>
```
<br/>
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-mvvm-behaviors-gallery-based-theme-palette-selector&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-mvvm-behaviors-gallery-based-theme-palette-selector&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
