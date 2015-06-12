using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestWithStaticFunctions.prod;
using Shouldly;

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
			
			var actual = target.IsValid(account, password);

			var expected = true;

			actual.ShouldBe(expected);
		}
	}
}
