using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BUPA_Demo.Repository;
using BUPA_Demo.Model;

namespace BUPA_Demo.Tests
{
    [TestClass]
    public class UnitTest1
    {
       

        //public void TestMethod1()
        //{
        //    var result = 

        //}
        [TestMethod]
        public void UserAuthenticationTest()
        {
            UserRepository objUserRepository = new UserRepository();
            User objUser = new User();
            objUser.Username = "test";
            objUser.Password = "test";

            var result = objUserRepository.UserAuthentication(objUser.Username, objUser.Password);

            Assert.IsNotNull(result);
            //Assert.True(!result.ErrorMessage.Any(), "Error Message Found");
            //Assert.True(!result.ValidationMessage.Any(), "Validation Message Found");
            //Assert.True(result.IsSuccess, "Method successful");

        }
    }
}