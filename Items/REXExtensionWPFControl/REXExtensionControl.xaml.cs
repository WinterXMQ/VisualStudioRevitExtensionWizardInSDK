using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace $rootnamespace$
{
    /// <summary>
    /// Interaction logic for SubControl.xaml
    /// </summary>
    public partial class $safeitemname$ : REX.Common.REXExtensionControl
    {
        public $safeitemname$()
        {
            InitializeComponent();
        }
        public $safeitemname$(REX.Common.REXExtension extension)
            : base(extension)
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get the main extension.
        /// </summary>
        /// <value>The main extension.</value>
        internal Extension ThisMainExtension
        {
            get
            {
                return (Extension)ThisExtension;
            }
        }
        /// <summary>
        /// Get the Data structure.
        /// </summary>
        /// <value>The main Data.</value>
        internal Data ThisMainData
        {
            get
            {
                return ThisMainExtension.Data;
            }
        }
    }
}
