using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestWithStaticFunctions.prod;
using Shouldly;
using NSubstitute;

namespace UnitTestWithStaticFunctions
{
	[TestClass]
	public class AuthServiceTest
	{
		[TestMethod]
		public void Test_IsValid_joey_1234666666_Should_Return_True()
		{
			var target = new AuthService();
			var account = "joey";
			var password = "1234666666";

			//add IProfileDao stub
			IProfileDao stubProfileDao = Substitute.For<IProfileDao>();
			stubProfileDao.GetPassword("joey").ReturnsForAnyArgs("1234");
			stubProfileDao.GetToken("joey").ReturnsForAnyArgs("666666");

			//inject to ProfileDao static class
			ProfileDao.MyProfileDao = stubProfileDao;

			var actual = target.IsValid(account, password);

			var expected = true;

			//because of random, it should almost always assert failed
			actual.ShouldBe(expected);
		}
	}
}
