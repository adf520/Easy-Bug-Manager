﻿#pragma checksum "..\..\..\..\..\..\Xaml\Control\Perfab\MainUi\CreateProjectButtonControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6A2AC40A626F204FEE2177215040767D4F2B5C8024CEB429A77C73CE7B452780"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using EasyBugManager;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace EasyBugManager {
    
    
    /// <summary>
    /// CreateProjectButtonControl
    /// </summary>
    public partial class CreateProjectButtonControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\..\..\Xaml\Control\Perfab\MainUi\CreateProjectButtonControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal EasyBugManager.CreateProjectButtonControl CreateProjectButtonUserControl;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\..\..\Xaml\Control\Perfab\MainUi\CreateProjectButtonControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BaseButton;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\..\..\Xaml\Control\Perfab\MainUi\CreateProjectButtonControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border ButtonImageBorder;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\..\..\Xaml\Control\Perfab\MainUi\CreateProjectButtonControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ScaleTransform BaseButtonScaleTransform;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/EasyBugManager;component/xaml/control/perfab/mainui/createprojectbuttoncontrol.x" +
                    "aml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Xaml\Control\Perfab\MainUi\CreateProjectButtonControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.CreateProjectButtonUserControl = ((EasyBugManager.CreateProjectButtonControl)(target));
            return;
            case 2:
            this.BaseButton = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\..\..\..\Xaml\Control\Perfab\MainUi\CreateProjectButtonControl.xaml"
            this.BaseButton.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Button_OnPreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 20 "..\..\..\..\..\..\Xaml\Control\Perfab\MainUi\CreateProjectButtonControl.xaml"
            this.BaseButton.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Button_OnPreviewMouseUp);
            
            #line default
            #line hidden
            
            #line 21 "..\..\..\..\..\..\Xaml\Control\Perfab\MainUi\CreateProjectButtonControl.xaml"
            this.BaseButton.MouseEnter += new System.Windows.Input.MouseEventHandler(this.BaseButton_OnMouseEnter);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\..\..\..\Xaml\Control\Perfab\MainUi\CreateProjectButtonControl.xaml"
            this.BaseButton.MouseLeave += new System.Windows.Input.MouseEventHandler(this.BaseButton_OnMouseLeave);
            
            #line default
            #line hidden
            
            #line 23 "..\..\..\..\..\..\Xaml\Control\Perfab\MainUi\CreateProjectButtonControl.xaml"
            this.BaseButton.Click += new System.Windows.RoutedEventHandler(this.Button_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ButtonImageBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 4:
            this.BaseButtonScaleTransform = ((System.Windows.Media.ScaleTransform)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

