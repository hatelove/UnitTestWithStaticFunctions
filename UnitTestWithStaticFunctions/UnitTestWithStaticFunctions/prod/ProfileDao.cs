using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestWithStaticFunctions.prod
{
	public static class ProfileDao
	{
		private static IProfileDao _profileDao;

		//add internal setter for unit test to inject stub object
		internal static IProfileDao MyProfileDao
		{
			get
			{
				if (_profileDao == null)
				{
					// add a ProfileDaoImpl class and extract the original static function content to this class
					_profileDao = new ProfileDaoImpl();
				}

				return _profileDao;
			}
			set { _profileDao = value; }
		}

		internal static string GetPassword(string account)
		{
			// replace _profileDao filed to static property
			return MyProfileDao.GetPassword(account);
		}

		internal static string GetToken(string account)
		{
			// replace _profileDao filed to static property
			return MyProfileDao.GetToken(account);
		}
	}
}