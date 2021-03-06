﻿#pragma checksum "..\..\..\ControlWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0151225707F7447D961BB111824193A7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace CountessQuantaControl {
    
    
    /// <summary>
    /// ControlWindow
    /// </summary>
    public partial class ControlWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\ControlWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock servoHardwareState;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\ControlWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock kinectHardwareState;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\ControlWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer LoggingScrollViewer;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\ControlWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LoggingTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/CountessQuantaControl;component/controlwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ControlWindow.xaml"
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
            this.servoHardwareState = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.kinectHardwareState = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            
            #line 25 "..\..\..\ControlWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.InitializeHardware_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 26 "..\..\..\ControlWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RelaxServos_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 29 "..\..\..\ControlWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GenerateExampleXmls_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 30 "..\..\..\ControlWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.TestSpeech_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 31 "..\..\..\ControlWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RunSequence_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 32 "..\..\..\ControlWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SkeletonViewer_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 36 "..\..\..\ControlWindow.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Click += new System.Windows.RoutedEventHandler(this.speechRecognitionEnableCheckbox_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 37 "..\..\..\ControlWindow.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Click += new System.Windows.RoutedEventHandler(this.gestureRecognitionEnableCheckbox_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 38 "..\..\..\ControlWindow.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Click += new System.Windows.RoutedEventHandler(this.personTrackingEnableCheckbox_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.LoggingScrollViewer = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 13:
            this.LoggingTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

