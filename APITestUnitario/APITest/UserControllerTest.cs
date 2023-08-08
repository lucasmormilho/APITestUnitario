using APITestUnitario.Controllers;
using APITestUnitario.Entities;
using Microsoft.AspNetCore.Mvc;

namespace APITest
{
    [TestClass]
    public class UserControllerTest
    {

        UserController controller;
        User user;

        [TestInitialize]
        public void Start()
        {
            controller = new UserController();
            user = new User("Lucas", 19);
        }

        //é possivel passar varios nomes por exemplo
        [TestMethod]
        [DataRow("Eduardo")]
        [DataRow("Neymar")]
        [DataRow("Lucas")]
        [DataRow("Yuri")]
        public void Post_Test(string nome)
        {
            user.Nome = nome;
            var responseAPI = controller.Post(user);
            Assert.IsInstanceOfType(responseAPI, typeof(OkResult));
        }

        //teste unitario de OK
        [TestMethod]
        public void Post_Test_OK()
        {
            var responseAPI = controller.Post(user);
            Assert.IsInstanceOfType(responseAPI, typeof(OkResult));
        }

        //testando o BadRequest
        [TestMethod]
        public void Post_Test_BadRequest()
        {
            user.Nome = "Rafael";
            user.Idade = 19;

            var responseAPI = controller.Post(user);
            Assert.IsInstanceOfType(responseAPI, typeof(BadRequestResult));
        }
    }
}