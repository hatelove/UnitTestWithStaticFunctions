using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestWithStaticFunctions.prod
{
	public class AuthService
	{
		public bool IsValid(string account, string password)
		{
			string passwordFromDao = ProfileDao.GetPassword(account);
			string token = ProfileDao.GetToken(account);

			var validPassword = passwordFromDao + token;

			var isValid = validPassword == password;
			return isValid;
		}
	}
}
