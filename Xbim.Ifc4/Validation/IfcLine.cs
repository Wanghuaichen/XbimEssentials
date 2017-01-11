using System;
using log4net;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Xbim.Common.Enumerations;
using Xbim.Common.ExpressValidation;
using Xbim.Ifc4.Interfaces;
using static Xbim.Ifc4.Functions;
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.GeometryResource
{
	public partial class IfcLine : IExpressValidatable
	{
		public enum IfcLineClause
		{
			SameDim,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcLineClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcLineClause.SameDim:
						retVal = Dir.Dim == Pnt.Dim;
						break;
				}
			} catch (Exception ex) {
				var Log = LogManager.GetLogger("Xbim.Ifc4.GeometryResource.IfcLine");
				Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcLine.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcLineClause.SameDim))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcLine.SameDim", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}