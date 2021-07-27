using System;

namespace CrossScope.LivingDocumentation {
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	public sealed class GuidedTour : Attribute {
		private readonly int _someConstant;
		private readonly string[] _extraInfo;

		public GuidedTour(int someConstant, params string[] extraInfo) {
			_someConstant = someConstant;
			_extraInfo = extraInfo;
		}

	}
}
