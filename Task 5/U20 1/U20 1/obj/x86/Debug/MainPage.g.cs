﻿#pragma checksum "C:\Users\namma\source\repos\U20 1\U20 1\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5BA722D93CC408ACBF256F63E33D024E23D2616D14EAAD0792D52D1EE514AE5D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace U20_1
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 58
                {
                    this.MyComboBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // MainPage.xaml line 76
                {
                    this.MyListBox = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.MyListBox).SelectionChanged += this.MyListBox_SelectionChanged;
                }
                break;
            case 4: // MainPage.xaml line 84
                {
                    this.ListBoxResultTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // MainPage.xaml line 66
                {
                    global::Windows.UI.Xaml.Controls.ComboBox element5 = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)element5).SelectionChanged += this.ComboBox_SelectionChanged;
                }
                break;
            case 6: // MainPage.xaml line 71
                {
                    this.ComboBoxResultTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // MainPage.xaml line 47
                {
                    this.YesRadioButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.YesRadioButton).Checked += this.RadioButton_Checked;
                }
                break;
            case 8: // MainPage.xaml line 51
                {
                    this.NoRadioButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.NoRadioButton).Checked += this.RadioButton_Checked;
                }
                break;
            case 9: // MainPage.xaml line 55
                {
                    this.RadioButtonTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10: // MainPage.xaml line 33
                {
                    this.MyCheckBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.MyCheckBox).Tapped += this.MyCheckBox_Tapped;
                }
                break;
            case 11: // MainPage.xaml line 36
                {
                    this.CheckBoxResultTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

