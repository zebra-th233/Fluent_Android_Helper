﻿#pragma checksum "..\..\..\Second Level Item\UI_Modify.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CCECBEDEA1E0FF845AABB8F6CBDFE3E0F69FB48DBD65EFD1292F6A94D677F414"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Fluent_Android_Helper;
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


namespace Fluent_Android_Helper {
    
    
    /// <summary>
    /// UI_Modify
    /// </summary>
    public partial class UI_Modify : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Second Level Item\UI_Modify.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangeDPI;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Second Level Item\UI_Modify.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangeWindow;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Second Level Item\UI_Modify.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangeGD;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Second Level Item\UI_Modify.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangeAnimator;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Second Level Item\UI_Modify.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboWindow;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Second Level Item\UI_Modify.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboGD;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Second Level Item\UI_Modify.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboAni;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Second Level Item\UI_Modify.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DPI;
        
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
            System.Uri resourceLocater = new System.Uri("/Fluent_Android_Helper;component/second%20level%20item/ui_modify.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Second Level Item\UI_Modify.xaml"
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
            this.ChangeDPI = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\Second Level Item\UI_Modify.xaml"
            this.ChangeDPI.Click += new System.Windows.RoutedEventHandler(this.ChangeDPI_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ChangeWindow = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\Second Level Item\UI_Modify.xaml"
            this.ChangeWindow.Click += new System.Windows.RoutedEventHandler(this.ChangeWindow_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ChangeGD = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\Second Level Item\UI_Modify.xaml"
            this.ChangeGD.Click += new System.Windows.RoutedEventHandler(this.ChangeGD_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ChangeAnimator = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Second Level Item\UI_Modify.xaml"
            this.ChangeAnimator.Click += new System.Windows.RoutedEventHandler(this.ChangeAnimator_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ComboWindow = ((System.Windows.Controls.ComboBox)(target));
            
            #line 20 "..\..\..\Second Level Item\UI_Modify.xaml"
            this.ComboWindow.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboWindow_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ComboGD = ((System.Windows.Controls.ComboBox)(target));
            
            #line 28 "..\..\..\Second Level Item\UI_Modify.xaml"
            this.ComboGD.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboGD_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ComboAni = ((System.Windows.Controls.ComboBox)(target));
            
            #line 36 "..\..\..\Second Level Item\UI_Modify.xaml"
            this.ComboAni.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.DPI = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
