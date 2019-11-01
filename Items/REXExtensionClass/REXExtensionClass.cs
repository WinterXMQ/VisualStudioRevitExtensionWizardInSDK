using System;
using System.Collections.Generic;
using System.Text;

namespace $rootnamespace$
{
    internal class $safeitemname$ : REX.Common.REXExtensionObject 
    {
        public $safeitemname$(REX.Common.REXExtension Ext)
            : base(Ext)
        {
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
