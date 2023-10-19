# Creating a project
Create a new BlankApp (Xamarin.Forms.Portable) application in Visual Studio for Xamarin.Forms.

## Adding SfSegmentedControl in Xamarin.Forms
Add the required assembly references to the PCL and renderer projects as discussed in the Assembly deployment  section.

Import the control namespace as shown in the following code.

**[XAML]**

```
xmlns:buttons="clr-namespace:Syncfusion.XForms.Buttons;assembly=Syncfusion.Buttons.XForms"
```
Set the control to content in ContentPage.

**[XAML]**
```
<ContentPage.Content>
    <buttons:SfSegmentedControl  />
</ContentPage.Content>
```
# Dealing with selection changed in Xamarin Segmented Control

The selection changed event occurs when there is a change from one segment item to another in the segmented control. It can be handled by two ways.

## User interface
When users navigate from one item to another, selection is changed, so that the SelectedIndex value is updated to the new index of the item. The segmented control provides the SelectionChanged event, which is triggered when the selection is changed with the SelectionChangedEventArgs.

Index - Gets the current index value of the selected item.

**[XAML]**

```
<buttons:SfSegmentedControl x:Name = "segmentedControl" SelectionChanged="Handle_SelectionChanged"/>
```
## Selected Index through programmatically.
Users can set the default value programmatically for the selection to be placed. The selection is updated based on the index value given for the SelectedIndex.

**[XAML]**
```
<buttons:SfSegmentedControl SelectedIndex="2"/>
```

## Event to command

The SegmentedControl event can be converted into commands using Behaviors. To achieve this, create a command in the ViewModel class and use Behaviors to associate it to the SegmentedControl event.

**[XAML]**
```
<buttons:SfSegmentedControl 
            x:Name="Segment" 
            SelectionTextColor= "White"
            HeightRequest="80"
            VisibleSegmentsCount="5"
            Color="Transparent" 
            BorderColor="#929292"
            SelectedIndex="0" 
            FontColor="#929292"
            BackgroundColor="Transparent"
            ItemsSource="{Binding ItemCollection,Mode=TwoWay}">
    <buttons:SfSegmentedControl.Behaviors>
        <local:EventToCommandBehavior Command="{Binding SelectionChangedCommand}" EventName="SelectionChanged"/>
    </buttons:SfSegmentedControl.Behaviors>
    </buttons:SfSegmentedControl>
```
## How to run this application?

To run this application, you need to first clone the xamarin.forms-segmentedcontrol-with-event-to-command-behavior repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.