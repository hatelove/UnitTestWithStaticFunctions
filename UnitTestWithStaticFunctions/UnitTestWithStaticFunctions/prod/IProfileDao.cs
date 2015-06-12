using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestWithStaticFunctions.prod
{
	public interface IProfileDao
	{
		string GetPassword(string account);

		string GetToken(string account);
	}
}
