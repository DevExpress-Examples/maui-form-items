<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/617812916/23.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1166146)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# DevExpress Form Items for .NET MAUI

This example uses various form items to create an intuitive/easy-to-use mobile settings page.

![DevExpress Form Items for .NET MAUI - Demo app preview](Images/form-items-preview.png)

## Implementation Details

* This project implements the following form items:

    | Item | Description |
    |-|-|
    | [FormItem](https://docs.devexpress.com/MAUI/DevExpress.Maui.Editors.FormItem) | Displays custom content (an image or a text field). You can also use this class to display a menu item that takes you to another page.  |
    | [FormSwitchItem](https://docs.devexpress.com/MAUI/DevExpress.Maui.Editors.FormSwitchItem)| Allows you to edit a Boolean value. |
    | [FormListPickerItem](https://docs.devexpress.com/MAUI/DevExpress.Maui.Editors.FormListPickerItem) | Displays a list with the option to select a single or multiple items. |
    | [FormGroupItem](https://docs.devexpress.com/MAUI/DevExpress.Maui.Editors.FormGroupItem) | Allows you to group items. |

* The [FormItem.ImageTemplate](https://docs.devexpress.com/MAUI/DevExpress.Maui.Editors.FormItemBase.ImageTemplate) property embeds custom content:

    ```xml
    <dxe:FormItem.ImageTemplate>
        <DataTemplate>
            <dxco:DXImage Margin="0,0,10,0" Aspect="AspectFit" HeightRequest="60" Source="jennievalintine" WidthRequest="60">
                <dxco:DXImage.Clip>
                    <EllipseGeometry Center="30,30" RadiusX="30" RadiusY="30" />
                </dxco:DXImage.Clip>
            </dxco:DXImage>
        </DataTemplate>
    </dxe:FormItem.ImageTemplate>
    ```
* The [FormListPickerItem](https://docs.devexpress.com/MAUI/DevExpress.Maui.Editors.FormListPickerItem) object allows users to select items from a list. The list can appear in a [Popup control](https://docs.devexpress.com/MAUI/DevExpress.Maui.Controls.DXPopup), a [BottomSheet](https://docs.devexpress.com/MAUI/DevExpress.Maui.Controls.BottomSheet), or a page. This example uses this item type to display the following pickers:

    | Field | Notes | Customization Properties |
    |-|-|-|
    | Language | A language picker. Appears on a separate page. | - |
    | Vibrate | A single-selection picker. Appears in a Popup control. | [PickerShowMode](https://docs.devexpress.com/MAUI/DevExpress.Maui.Editors.FormPickerItemBase.PickerShowMode) = Popup|
    | Blacklist | A multiple-selection picker with an integrated search bar. Appears on a separate page. | [IsMultipleSelectionEnabled](https://docs.devexpress.com/MAUI/DevExpress.Maui.Editors.FormListPickerItem.IsMultipleSelectionEnabled) = true; [ShowSearchPanel](https://docs.devexpress.com/MAUI/DevExpress.Maui.Editors.FormListPickerItem.ShowSearchPanel) = true |

* One [FormItem](https://docs.devexpress.com/MAUI/DevExpress.Maui.Editors.FormItem) opens a page with a multiline text editor bound to the *bio* field. The code saves changes when a user navigates back to the main page.
* The "Private Chat" item binds its [FormSwitchItem.IsToggled](https://docs.devexpress.com/MAUI/DevExpress.Maui.Editors.FormSwitchItem.IsToggled) property to a Boolean field.
  
  ```xml
  <dxe:FormSwitchItem ImageSource="priv" IsToggled="{Binding IsPrivateChatEnabled}" Text="Private Chat" />
  ```

* The [FormItem.ImageSource](https://docs.devexpress.com/MAUI/DevExpress.Maui.Editors.FormItemBase.ImageSource) property specifies an icon. 

    ```xml
    <dxe:FormItem ImageSource="email" Text="Email" />
    ```

    The [ImageColor](https://docs.devexpress.com/MAUI/DevExpress.Maui.Editors.FormItemBase.ImageColor) property customizes image color (uses theme colors for this example):

    ```xml
    <Setter Property="ImageColor" Value="{AppThemeBinding Light={StaticResource Gray600}, Dark={StaticResource Gray200}}" />
    ```

* The [FormGroupItem](https://docs.devexpress.com/MAUI/DevExpress.Maui.Editors.FormGroupItem) object visually separates form items into groups. The [FormItemGroup.Header](https://docs.devexpress.com/MAUI/DevExpress.Maui.Editors.FormGroupItem.Header) property specifies group header content.
* Form items support a variety of customization options, including the ability to modify colors, fonts, paddings, margins, and other style attributes.

## Files to Review

- [SettingsPage.xaml](./CS/Views/SettingsPage.xaml)

## Documentation

- [Form Items](https://docs.devexpress.com/MAUI/404418/form-items/form-items?v=23.1)

## More Examples

- [DevExpress Editors for .NET MAUI](https://github.com/DevExpress-Examples/maui-editors-get-started)
- [DevExpress .NET MAUI Editors - Create Login and Sign-Up Forms](https://github.com/DevExpress-Examples/maui-editors-access-form)
