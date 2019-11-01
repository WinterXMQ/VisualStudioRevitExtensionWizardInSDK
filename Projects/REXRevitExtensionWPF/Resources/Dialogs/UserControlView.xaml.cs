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

namespace REX.AREXTemplate.Resources.Dialogs
{
    /// <summary>
    /// Interaction logic for SubControl.xaml
    /// </summary>
    public partial class UserControlView : REX.Common.REXExtensionControl
    {
        public UserControlView()
        {
            InitializeComponent();
        }
        public UserControlView(REX.Common.REXExtension extension)
            : base(extension)
        {
            InitializeComponent();
        }
    }
}
