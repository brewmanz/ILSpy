﻿#pragma checksum "..\..\OpenFromGacDialog.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "967BEC881A87E0D78DB58D73AC9DD5C7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ICSharpCode.ILSpy;
using ICSharpCode.ILSpy.Controls;
using ICSharpCode.ILSpy.TextView;
using ICSharpCode.TreeView;
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


namespace ICSharpCode.ILSpy {
    
    
    /// <summary>
    /// OpenFromGacDialog
    /// </summary>
    public partial class OpenFromGacDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\OpenFromGacDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox filterTextBox;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\OpenFromGacDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listView;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\OpenFromGacDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ICSharpCode.ILSpy.Controls.SortableGridViewColumn nameColumn;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\OpenFromGacDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button okButton;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\OpenFromGacDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar gacReadingProgressBar;
        
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
            System.Uri resourceLocater = new System.Uri("/ILSpy;component/openfromgacdialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\OpenFromGacDialog.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.filterTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\OpenFromGacDialog.xaml"
            this.filterTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.FilterTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.listView = ((System.Windows.Controls.ListView)(target));
            
            #line 27 "..\..\OpenFromGacDialog.xaml"
            this.listView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.nameColumn = ((ICSharpCode.ILSpy.Controls.SortableGridViewColumn)(target));
            return;
            case 4:
            this.okButton = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\OpenFromGacDialog.xaml"
            this.okButton.Click += new System.Windows.RoutedEventHandler(this.OKButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.gacReadingProgressBar = ((System.Windows.Controls.ProgressBar)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

