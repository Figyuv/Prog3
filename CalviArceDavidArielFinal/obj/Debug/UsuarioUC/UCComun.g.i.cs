// Updated by XamlIntelliSenseFileGenerator 6/13/2022 12:37:46 AM
#pragma checksum "..\..\..\UsuarioUC\UCComun.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9F166454C0E431AFB3DBAA6CD8D24233EE1BE4B1D70E145E45327389B420948A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using CalviArceDavidArielFinal.UsuarioUC;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace CalviArceDavidArielFinal.UsuarioUC
{


    /// <summary>
    /// UCComun
    /// </summary>
    public partial class UCComun : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {


#line 27 "..\..\..\UsuarioUC\UCComun.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView dgvUsers;

#line default
#line hidden


#line 28 "..\..\..\UsuarioUC\UCComun.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddConf;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CalviArceDavidArielFinal;component/usuariouc/uccomun.xaml", System.UriKind.Relative);

#line 1 "..\..\..\UsuarioUC\UCComun.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 9 "..\..\..\UsuarioUC\UCComun.xaml"
                    ((CalviArceDavidArielFinal.UsuarioUC.UCComun)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);

#line default
#line hidden
                    return;
                case 2:
                    this.dgvUsers = ((System.Windows.Controls.ListView)(target));
                    return;
                case 3:
                    this.btnAddConf = ((System.Windows.Controls.Button)(target));

#line 28 "..\..\..\UsuarioUC\UCComun.xaml"
                    this.btnAddConf.Click += new System.Windows.RoutedEventHandler(this.btnAddConf_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.TextBox txtName;
        internal System.Windows.Controls.Button btnAdd;
    }
}

