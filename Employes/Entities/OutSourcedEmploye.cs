using System;

namespace Employes
{
	class OutSourcedEmploye : Employe
	{
		public double AdditionalCharge { get; set; }

		public OutSourcedEmploye()
		{
		}

		public OutSourcedEmploye(string name, int hours, double valuePerHour, double additionalCharge) 
			: base(name, hours, valuePerHour)
		{
			AdditionalCharge = additionalCharge;
		}

		public override double Payment ()
		{
			return base.Payment () + 1.1 * AdditionalCharge;
		}
	}
}

