// Copyright (C) NeoAxis Group Ltd. 8 Copthall, Roseau Valley, 00152 Commonwealth of Dominica.
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace NeoAxis
{
	/// <summary>
	/// Pixelization screen effect.
	/// </summary>
	[DefaultOrderOfEffect( 8.2 )]
	public class Component_RenderingEffect_Pixelate : Component_RenderingEffect_Simple
	{
		const string shaderDefault = @"Base\Shaders\Effects\Pixelate_fs.sc";

		//

		public Component_RenderingEffect_Pixelate()
		{
			Shader = shaderDefault;
		}

		/// <summary>
		/// The number of cells vertically.
		/// </summary>
		[DefaultValue( 100 )]
		[Range( 1, 400, RangeAttribute.ConvenientDistributionEnum.Exponential )]
		public Reference<double> Cells
		{
			get { if( _cells.BeginGet() ) Cells = _cells.Get( this ); return _cells.value; }
			set { if( _cells.BeginSet( ref value ) ) { try { CellsChanged?.Invoke( this ); } finally { _cells.EndSet(); } } }
		}
		/// <summary>Occurs when the <see cref="Cells"/> property value changes.</summary>
		public event Action<Component_RenderingEffect_Pixelate> CellsChanged;
		ReferenceField<double> _cells = 100;

		/////////////////////////////////////////

		public override bool LimitedDevicesSupport
		{
			get { return true; }
		}
	}
}
