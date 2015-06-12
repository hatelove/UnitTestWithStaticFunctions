using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestWithStaticFunctions.prod
{
	public class AuthService
	{
		private IProfileDao _profileDao;

		internal IProfileDao MyProfileDao
		{
			get
			{
				if (_profileDao == null)
				{
					_profileDao = new ProfileDaoImpl();
				}

				return _profileDao;
			}
			set { _profileDao = value; }
		}

		public bool IsValid(string account, string password)
		{
			//string passwordFromDao = ProfileDao.GetPassword(account);
			//string token = ProfileDao.GetToken(account);
			string passwordFromDao = this.MyProfileDao.GetPassword(account);
			string token = this.MyProfileDao.GetToken(account);

			var validPassword = passwordFromDao + token;

			var isValid = validPassword == password;
			return isValid;
		}
	}
}