﻿#pragma checksum "..\..\..\Copy of MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "97975E3A9801E4839C06755096B97564"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1008
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


namespace ListViewSandBox {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\Copy of MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MDatei;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Copy of MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MiCsvLoad;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Copy of MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MiCsvSave;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Copy of MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MHinzufügen;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Copy of MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MiAddColumn;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Copy of MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MiAddRow;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Copy of MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mEinstellungen;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Copy of MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvListView;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ListViewSandBox;component/copy%20of%20mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Copy of MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MDatei = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 2:
            this.MiCsvLoad = ((System.Windows.Controls.MenuItem)(target));
            
            #line 34 "..\..\..\Copy of MainWindow.xaml"
            this.MiCsvLoad.Click += new System.Windows.RoutedEventHandler(this.MiCsvLoadClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MiCsvSave = ((System.Windows.Controls.MenuItem)(target));
            
            #line 37 "..\..\..\Copy of MainWindow.xaml"
            this.MiCsvSave.Click += new System.Windows.RoutedEventHandler(this.MiCsvSaveClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MHinzufügen = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 5:
            this.MiAddColumn = ((System.Windows.Controls.MenuItem)(target));
            
            #line 53 "..\..\..\Copy of MainWindow.xaml"
            this.MiAddColumn.Click += new System.Windows.RoutedEventHandler(this.MiAddColumnClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.MiAddRow = ((System.Windows.Controls.MenuItem)(target));
            
            #line 56 "..\..\..\Copy of MainWindow.xaml"
            this.MiAddRow.Click += new System.Windows.RoutedEventHandler(this.MiAddRowClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.mEinstellungen = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 8:
            this.lvListView = ((System.Windows.Controls.ListView)(target));
            
            #line 83 "..\..\..\Copy of MainWindow.xaml"
            this.lvListView.AddHandler(System.Windows.Controls.Primitives.ButtonBase.ClickEvent, new System.Windows.RoutedEventHandler(this.LvListViewClick));
            
            #line default
            #line hidden
            
            #line 84 "..\..\..\Copy of MainWindow.xaml"
            this.lvListView.MouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.LvListView_OnMouseRightButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

