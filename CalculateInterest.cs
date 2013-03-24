using System;

namespace CalculateInterest
{
	public class Program
	{
		public static void Main ()
		{
			Console.Write ("Enter principal: ");
			string sPrincipal = Console.ReadLine ();
			decimal mPrincipal = Convert.ToDecimal (sPrincipal);

			if (mPrincipal < 0) {
				Console.WriteLine ("Principal cannot be negative");
				mPrincipal = 0;
			}

			Console.Write ("Enter interest: ");
			string sInterest = Console.ReadLine ();
			decimal mInterest = Convert.ToDecimal (sInterest);

			if (mInterest < 0) {
				Console.WriteLine("Interest cannot be negative");

			}

			decimal mInterestPaid;
			mInterestPaid = mPrincipal * (mInterest / 100);

			decimal mTotal = mPrincipal + mInterestPaid;
		}
			
	}

}

