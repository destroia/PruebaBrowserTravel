using AutoMapper;
using Moq;
using NUnit.Framework;
using PruebaBrowserTravel.Api;
using PruebaBrowserTravel.Api.Controllers;
using PruebaBrowserTravel.Business.Interfaces;
using PruebaBrowserTravel.DTO;

namespace PruevaBrowserTravel.Test
{
    public class AutorControllerTest
    {
        Mock<IAutorBI> mock = new Mock<IAutorBI>();
        AutorDto autor = new AutorDto() { Id = 0, Nombre = "David", Apellido = "Bedoya" };
        AutoresController Controller;
        public AutorControllerTest()
        {   
        }
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async void Post()
        {
            var a = new PruebaBrowserTravel.Models.Autor()
            { Id = 0, Nombre = autor.Nombre, Apellido = autor.Apellido };

              mock.Setup(x =>  x.Post(a)).Callback(() =>
              {
                 
              });
            IMapper Mapper = ConfigurarMapper.ConfiguraMapper();
            Controller = new AutoresController(mock.Object, Mapper);

            var aut = await Controller.Post(autor);
            Assert.IsTrue(aut != null);
        }
    }
}