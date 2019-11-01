using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using REX.Common;

namespace REX.AREXTemplate.Resources.Dialogs
{
    public partial class SubControl : REXExtensionControl
    {
        public SubControl(REXExtension Ext)
            : base(Ext)
        {
            InitializeComponent();      
        }

        /// <summary>
        /// Gets the main extension.
        /// </summary>
        /// <value>The main extension.</value>
        internal Extension ThisMainExtension
        {
            get
            {
                return (Extension)ThisExtension;
            }
        }

        public void SetDialog()
        {
        }

        public void SetData()
        {
        }
    }
}
