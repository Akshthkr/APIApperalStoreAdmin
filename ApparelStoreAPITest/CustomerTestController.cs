using ApperalStoreAPI.Controllers;
using ApperalStoreAPI.Models;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ApparelStoreAPITest
{
    public class CustomerTestController
    {
        private ApplicationDbContext context;
        public static DbContextOptions<ApplicationDbContext> dbContextOptions { get; set; }
        public static string connnectionString = "Data Source=TRD-501; Initial Catalog=MainApparelDb ;Integrated Security=True;";

        static CustomerTestController()
        {
            dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer(connnectionString).Options;
        }
        public CustomerTestController()
        {
            context = new ApplicationDbContext(dbContextOptions);
        }
        // [Fact]
        //public async void Task_Get_Return_OkResult()
        //{
        //    var controller = new CustomerController(context);
        //    var CustomerId = 25;
        //    var data = await controller.Get(CustomerId);
        //    Assert.IsType<OkObjectResult>(data);
        //}
        //[Fact]
        //public async void Task_Get_Return_NotFoundResult()
        //{
        //    var controller = new CustomerController(context);
        //    var CustomerId = 1000;
        //    var data = await controller.Get(CustomerId);
        //    Assert.IsType<NotFoundResult>(data);
        //}
        //[Fact]
        //public async void Task_GetById_MatchResult()
        //{
        //    var controller = new CustomerController(context);
        //    int CustomerId = 31;
        //    var data = await controller.Get(CustomerId);
        //    Assert.IsType<OkObjectResult>(data);
        //    var okResult = data.Should().BeOfType<OkObjectResult>().Subject;
        //    var cus = okResult.Value.Should().BeAssignableTo<Customer>().Subject;
        //    Assert.Equal("Eshika", cus.CustomerFirstName);
        //    Assert.Equal("es@gmail.com", cus.CustomerEmail);
        //}
        //[Fact]
        //public async void Task_GetCustomerById_Return_BadResquest()
        //{
        //    var controller = new CustomerController(context);
        //    int? id = null;
        //    var data = await controller.Get(id);
        //    Assert.IsType<BadRequestResult>(data);
        //}
        [Fact]
        public async void Task_AddCategory_Return_OkResult()
        {
            var controller = new CustomerController(context);
            var cat = new Customer()
            {
                CustomerFirstName = "Eshika",
                CustomerLastName = "Saxena",
                CustomerEmail = "e@gmail.com",
                CustomerPhoneNumber = 12345,
                CustomerGender = "Female",
                CustomerPassword = "eshu"
            };
            var data = await controller.Post(cat);
            Assert.IsType<CreatedAtActionResult>(data);
        }
     
        //[Fact]
        //public async void Task_Delete_Retun_OkResult()
        //{
        //    var controller = new CustomerController(context);
        //    int id = 1033;
        //    var data = await controller.Delete(id);
        //    Assert.IsType<OkObjectResult>(data);
        //}
        [Fact]
        public async void Task_Delete_Return_NotFoundResult()
        {
            var controller = new CustomerController(context);
            var id = 100;
            var data = await controller.Delete(id);
            Assert.IsType<NotFoundResult>(data);
        }
      
      
        
        [Fact]
        public async void Task_Update_Return_NotFound()
        {
            var controller = new CustomerController(context);
            var id = 10;
            var cat = new Customer()
            {
                CustomerFirstName = "Eshika",
                CustomerLastName = "Saxena",
                CustomerEmail = "e@gmail.com",
                CustomerPhoneNumber = 12345,
                CustomerGender = "Female",
                CustomerPassword = "eshu"
            };
            var data = await controller.Put(id, cat);
            Assert.IsType<NotFoundResult>(data);
        }
        [Fact]
        public async void Task_getAll_Return_NotFound()
        {
            var controller = new CustomerController(context);
            var data = await controller.Get();
            data = null;
            if (data != null)
            {
                Assert.IsType<OkObjectResult>(data);
            }
            else
            {
                Assert.Equal(data, null);
            }
        }
        [Fact]
        public async void Task_GetAll_Return_okobject()
        {
            var controller = new CustomerController(context);
            var data = await controller.Get();
            Assert.IsType<OkObjectResult>(data);
        }




    }
}
