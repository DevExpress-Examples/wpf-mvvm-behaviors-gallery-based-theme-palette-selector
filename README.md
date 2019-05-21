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
