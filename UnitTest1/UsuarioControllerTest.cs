//using Fiap.Api.Donation2.Controllers;
//using Fiap.Api.Donation2.Models;
//using Fiap.Api.Donation2.Repository.Interface;
//using Microsoft.AspNetCore.Mvc;
//using Moq;

//namespace UnitTest1
//{
//    public class UsuarioControllerTest
//    {
//        [Fact]
//        public async void GetResultOkWithUsuarios()
//        {
//            var usuario = new List<UsuarioModel>()
//            {
//                new UsuarioModel()
//            }; 
//            var mockRepository = new Mock<IUsuarioRepository>();
//            mockRepository.Setup(r => r.FindAll()).Returns(usuario);


//            var controller = new UsuarioController(mockRepository.Object);

//            var result = controller.GetAll();


//            var resultType = Assert.IsType<OkObjectResult>(result.Result);
//            var resultValue = Assert.IsType<List<UsuarioModel>>(resultType.Value);


//            Assert.Single(resultValue);
             

//        }
//        [Fact]
//        public async void GetUsuarioResultOkWith3Usuarios()
//        {
//            var usuario = new List<UsuarioModel>()
//            {
//                new UsuarioModel(),
//                new UsuarioModel(),
//                new UsuarioModel()
//            };
//            var mockRepository = new Mock<IUsuarioRepository>();
//            mockRepository.Setup(r => r.FindAll()).ReturnsAsync(usuario);


//            var controller = new UsuarioController(mockRepository.Object);

//            var result = await controller.GetAllAsync();


//            var resultType = Assert.IsType<OkObjectResult>(result.Result);
//            var resultValue = Assert.IsType<List<UsuarioModel>>(resultType.Value);


//            Assert.Equal(3, resultValue.Count);
//        }

//        [Fact]
//        public async void GetUsuarioResultNoContent()
//        {
//            var mockRepository = new Mock<IUsuarioRepository>();
//            mockRepository.Setup(r => r.FindAll()).Returns(new List<UsuarioModel>()); 


//            var controller = new UsuarioController(mockRepository.Object);

//            var result = controller.GetAll(); 


//            Assert.IsType<NoContentResult>(result.Result);
//        }
//    }
//}