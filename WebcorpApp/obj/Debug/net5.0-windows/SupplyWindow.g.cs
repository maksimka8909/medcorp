#pragma checksum "..\..\..\SupplyWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2920F0ACEF6E544CBD366B6EBE76365AC7A7FE25"
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
using System.Windows.Controls.Ribbon;
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
using WebcorpApp;


namespace WebcorpApp {
    
    
    /// <summary>
    /// SupplyWindow
    /// </summary>
    public partial class SupplyWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\SupplyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbEquipment;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\SupplyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbDrug;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\SupplyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbEquipment;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\SupplyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbDrug;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\SupplyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbQuantity;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\SupplyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\SupplyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgEquipment;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\SupplyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem cmEquipmentDelete;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\SupplyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgDrugs;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\SupplyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem cmDrugDelete;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\SupplyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\SupplyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnConfirm;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WebcorpApp;component/supplywindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\SupplyWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\SupplyWindow.xaml"
            ((WebcorpApp.SupplyWindow)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            
            #line 8 "..\..\..\SupplyWindow.xaml"
            ((WebcorpApp.SupplyWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.rbEquipment = ((System.Windows.Controls.RadioButton)(target));
            
            #line 32 "..\..\..\SupplyWindow.xaml"
            this.rbEquipment.Checked += new System.Windows.RoutedEventHandler(this.rbEquipment_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.rbDrug = ((System.Windows.Controls.RadioButton)(target));
            
            #line 33 "..\..\..\SupplyWindow.xaml"
            this.rbDrug.Checked += new System.Windows.RoutedEventHandler(this.rbDrug_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cbEquipment = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.cbDrug = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.tbQuantity = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\SupplyWindow.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.btnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.dgEquipment = ((System.Windows.Controls.DataGrid)(target));
            
            #line 51 "..\..\..\SupplyWindow.xaml"
            this.dgEquipment.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgEquipment_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.cmEquipmentDelete = ((System.Windows.Controls.MenuItem)(target));
            
            #line 54 "..\..\..\SupplyWindow.xaml"
            this.cmEquipmentDelete.Click += new System.Windows.RoutedEventHandler(this.cmEquipmentDelete_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.dgDrugs = ((System.Windows.Controls.DataGrid)(target));
            
            #line 63 "..\..\..\SupplyWindow.xaml"
            this.dgDrugs.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgDrugs_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.cmDrugDelete = ((System.Windows.Controls.MenuItem)(target));
            
            #line 66 "..\..\..\SupplyWindow.xaml"
            this.cmDrugDelete.Click += new System.Windows.RoutedEventHandler(this.cmDrugDelete_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\SupplyWindow.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.btnCancel_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.btnConfirm = ((System.Windows.Controls.Button)(target));
            
            #line 92 "..\..\..\SupplyWindow.xaml"
            this.btnConfirm.Click += new System.Windows.RoutedEventHandler(this.btnConfirm_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

