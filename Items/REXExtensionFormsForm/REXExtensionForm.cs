using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace $rootnamespace$
{
    internal partial class $safeitemname$ : REX.Common.REXExtensionForm
    {
        public $safeitemname$(REX.Common.REXExtension Ext)
            : base(Ext)
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
