﻿// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2012. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 17/267 Nepean Hwy, 
//  Seaford, Vic 3198, Australia and are supplied subject to licence terms.
// 
//
// *****************************************************************************

using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.ComponentModel.Design;
using ComponentFactory.Krypton.Toolkit;

namespace ComponentFactory.Krypton.Ribbon
{
	internal class KryptonRibbonGroupTripleCollectionEditor : CollectionEditor
	{
		/// <summary>
        /// Initialize a new instance of the KryptonRibbonGroupTripleCollectionEditor class.
		/// </summary>
        public KryptonRibbonGroupTripleCollectionEditor()
            : base(typeof(KryptonRibbonGroupTripleCollection))
		{
		}

		/// <summary>
		/// Gets the data types that this collection editor can contain. 
		/// </summary>
		/// <returns>An array of data types that this collection can contain.</returns>
		protected override Type[] CreateNewItemTypes()
		{
            return new Type[] { typeof(KryptonRibbonGroupButton),
                                typeof(KryptonRibbonGroupColorButton),
                                typeof(KryptonRibbonGroupCheckBox),
                                typeof(KryptonRibbonGroupComboBox),
                                typeof(KryptonRibbonGroupCustomControl),
                                typeof(KryptonRibbonGroupDateTimePicker),
                                typeof(KryptonRibbonGroupLabel),
                                typeof(KryptonRibbonGroupRadioButton),
                                typeof(KryptonRibbonGroupRichTextBox),
                                typeof(KryptonRibbonGroupTextBox),
                                typeof(KryptonRibbonGroupMaskedTextBox)};
		}
	}
}
