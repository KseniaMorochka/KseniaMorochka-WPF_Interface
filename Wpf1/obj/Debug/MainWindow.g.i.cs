﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "88DF6A0148FA0FF0B6A4F06B2830893C046B6E9EA93ACABC3877D8F55B0E2B5D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using Wpf1;


namespace Wpf1 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf1.MainWindow window;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock stbar;
        
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
            System.Uri resourceLocater = new System.Uri("/Wpf1;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.window = ((Wpf1.MainWindow)(target));
            return;
            case 2:
            
            #line 12 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Menu)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Menu_MouseEnter_Menu);
            
            #line default
            #line hidden
            
            #line 13 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Menu)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Menu_MouseLeave_Menu);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 16 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_Color_Black);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 17 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_Color_White);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 18 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_Color_Red);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 19 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_Color_Green);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 20 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_Color_Blue);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 22 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_Info);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 24 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_Close);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 27 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ToolBar)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Menu_MouseEnter_ToolBar);
            
            #line default
            #line hidden
            
            #line 28 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ToolBar)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Menu_MouseLeave_ToolBar);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 32 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_Color_Black);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 35 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_Color_White);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 38 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_Color_Red);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 41 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_Color_Green);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 44 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_Color_Blue);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 49 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ToolBar)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Menu_MouseEnter_ToolBar);
            
            #line default
            #line hidden
            
            #line 50 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ToolBar)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Menu_MouseLeave_ToolBar);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 52 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_Info);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 55 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_Close);
            
            #line default
            #line hidden
            return;
            case 19:
            this.stbar = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

