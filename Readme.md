<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128657953/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T415475)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF Wizard - Generate Pages Based on View Model Collection

This example demonstrates how to define a collection of [wizard pages](https://docs.devexpress.com/WPF/115997/controls-and-libraries/navigation-controls/wizard-control/pages) in the View Model and display them in the [Wizard Control](https://docs.devexpress.com/WPF/115979/controls-and-libraries/navigation-controls/wizard-control).

![image](https://user-images.githubusercontent.com/65009440/227187637-e583a760-7e1b-4e52-8927-1d330e7f678c.png)

1. Bind the `ItemsSource` property to the View Model collection that contains pages.
2. Assign the page content template to the `ItemTemplate` property.
3. Define page settings in the `Style` objects and create a `StyleSelector` descendant that returns one of these objects based on the page type. Assign the selector to the `ItemContainerStyleSelector` property.

## Files to Review

* [ViewModel.cs](./CS/DXSample/ViewModel.cs) (VB: [ViewModel.vb](./VB/DXSample/ViewModel.vb))
* [MainWindow.xaml](./CS/DXSample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DXSample/MainWindow.xaml))
* [PageStyleSelector.cs](./CS/DXSample/PageStyleSelector.cs) (VB: [PageStyleSelector.vb](./VB/DXSample/PageStyleSelector.vb))

## Documentation

* [Wizard Control](https://docs.devexpress.com/WPF/115979/controls-and-libraries/navigation-controls/wizard-control)
* [Wizard Pages](https://docs.devexpress.com/WPF/115997/controls-and-libraries/navigation-controls/wizard-control/pages)
* [Wizard Buttons](https://docs.devexpress.com/WPF/115998/controls-and-libraries/navigation-controls/wizard-control/buttons)

## More Examples

* [Create a Wizard with Pages Defined in XAML](https://github.com/DevExpress-Examples/wpf-create-a-wizard-with-pages-defined-in-xaml)
* [How to Use the WPF WizardService](https://github.com/DevExpress-Examples/how-to-use-the-wpf-wizardservice)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-wizard-generate-pages-based-on-view-model-collection&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-wizard-generate-pages-based-on-view-model-collection&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
