// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.GeometricModelResource
{
	public partial class @IfcRightCircularCone : IIfcRightCircularCone
	{
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcRightCircularCone.Height 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure((double)Height);
			} 
		}
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcRightCircularCone.BottomRadius 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure((double)BottomRadius);
			} 
		}
	}
}