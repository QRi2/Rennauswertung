﻿#pragma checksum "..\..\Tabelle.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FBA604DB342953ADA55C116013AA8E432ECA040A8289DF879D784FB6514FEE78"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Rennauswertung;
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


namespace Rennauswertung {
    
    
    /// <summary>
    /// Tabelle
    /// </summary>
    public partial class Tabelle : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\Tabelle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Rennauswertung.Tabelle Tabelle1;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\Tabelle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnExport;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\Tabelle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnExport_Copy;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Tabelle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnLinehinzufuegen;
        
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
            System.Uri resourceLocater = new System.Uri("/Rennauswertung;component/tabelle.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Tabelle.xaml"
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
            this.Tabelle1 = ((Rennauswertung.Tabelle)(target));
            return;
            case 2:
            this.BtnExport = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\Tabelle.xaml"
            this.BtnExport.Click += new System.Windows.RoutedEventHandler(this.BtnExport_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnExport_Copy = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\Tabelle.xaml"
            this.BtnExport_Copy.Click += new System.Windows.RoutedEventHandler(this.BtnExport_Copy_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnLinehinzufuegen = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\Tabelle.xaml"
            this.BtnLinehinzufuegen.Click += new System.Windows.RoutedEventHandler(this.BtnLinehinzufuegen_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

