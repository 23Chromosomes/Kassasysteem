﻿#pragma checksum "..\..\BestelControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C8B2ABA651C77B8FADD223E1C408E398B9E2418F188B395CDAB54F79B7FF2612"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using KassaApp;
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


namespace KassaApp {
    
    
    /// <summary>
    /// BestelControl
    /// </summary>
    public partial class BestelControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\BestelControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGProduct;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\BestelControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGBestelling;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\BestelControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BestelBtn;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\BestelControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AnnuleerBtn;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\BestelControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox NaamSelectorCMB;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\BestelControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HoeveelheidBox;
        
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
            System.Uri resourceLocater = new System.Uri("/KassaApp;component/bestelcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\BestelControl.xaml"
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
            this.DGProduct = ((System.Windows.Controls.DataGrid)(target));
            
            #line 18 "..\..\BestelControl.xaml"
            this.DGProduct.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.DGProduct_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DGBestelling = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.BestelBtn = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\BestelControl.xaml"
            this.BestelBtn.Click += new System.Windows.RoutedEventHandler(this.BestelBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AnnuleerBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.NaamSelectorCMB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.HoeveelheidBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

