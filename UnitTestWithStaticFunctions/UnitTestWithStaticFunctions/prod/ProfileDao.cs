using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestWithStaticFunctions.prod
{
	public static class ProfileDao
	{
		//just simulate data source
		private static Dictionary<string, string> fakePasswordDataset = new Dictionary<string, string>
		{
			{"joey","1234"},
			{"demo","!@#$"},
		};

		internal static string GetPassword(string account)
		{
			if (!fakePasswordDataset.ContainsKey(account))
			{
				throw new Exception("account not exist");
			}

			return fakePasswordDataset[account];
		}

		internal static string GetToken(string account)
		{
			//just for demo, it's insecure
			var seed = new Random((account.GetHashCode() + (int)DateTime.Now.Ticks) & 0x0000FFFF);
			var result = seed.Next(0, 999999);
			return result.ToString("000000");
		}
	}
}
