using ApperalStoreAPI.Controllers;
using ApperalStoreAPI.Models;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;

namespace ApparelStoreAPITest 
{
    public class BrandTestController
    {
        private ApplicationDbContext context;
        public static DbContextOptions<ApplicationDbContext> dbContextOptions { get; set; }
        public static string connnectionString = "Data Source=TRD-501; Initial Catalog=MainApparelDb ;Integrated Security=True;";
        
        static BrandTestController()
        {
            dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer(connnectionString).Options;
        }
        public BrandTestController()
        {
            context = new ApplicationDbContext(dbContextOptions);
        }

        //[Fact]
        //public async void Task_GetById_Return_OkResult()
        //{
        //    var controller = new BrandController(context);
        //    var BrandId = 1;
        //    var data = await controller.Get(BrandId);
        //    Assert.IsType<OkObjectResult>(data);
        //}
        //[Fact]
        //public async void Task_GetById_Return_NFResult()
        //{
        //    var controller = new BrandController(context);
        //    var BrandId = 100;
        //    var data = await controller.Get(BrandId);
        //    Assert.IsType<NotFoundResult>(data);
        //}
        //[Fact]
        //public async void Task_GetById_Return_MatchResult()
        //{
        //    var controller = new BrandController(context);
        //    var Id = 1;
        //    var data = await controller.Get(Id);
        //    Assert.IsType<OkObjectResult>(data);
        //    var okResult = data.Should().BeOfType<OkObjectResult>().Subject;
        //    var brand = okResult.Value.Should().BeAssignableTo<Brand>().Subject;
        //    Assert.Equal("Adidas", brand.BrandName);
        //}
        //[Fact]
        //public async void Task_GetById_Return_BadRequest()
        //{
        //    var controller = new BrandController(context);
        //    int? id = null;
        //    var data = await controller.Get(id);
        //    Assert.IsType<BadRequestResult>(data);
        //}
        //[Fact]
        //public async void Task_Add_Return_OkRequest()
        //{
        //    var controller = new BrandController(context);
        //    var user = new Brand()
        //    {
        //        BrandName = "Bisleri",
        //        BrandDescription = "awesome"
        //    };
        //    var data = await controller.Post(user);
        //    Assert.IsType<CreatedAtActionResult>(data);
        //}
        //[Fact]
        //public async void Task_Add_InvalidData_Return_BadRequest()
        //{
        //    var controller = new BrandController(context);
        //    var user = new Brand()
        //    {
        //        BrandName = "bottlekajscklkjxhcjsd",
        //        BrandDescription = "pure"
        //    };
        //    var data = await controller.Post(user);
        //    Assert.IsType<BadRequestResult>(data);
        //}
        //[Fact]
        //public async void Task_delete_Return_okResult()
        //{
        //    var controller = new BrandController(context);
        //    var id =   7;
        //    var data = await controller.Delete(id);
        //    Assert.IsType<OkObjectResult>(data);
        //}

        //[Fact]
        //public async void Task_delete_Return_notfound()
        //{
        //    var controller = new BrandController(context);
        //    var id = 100;
        //    var data = await controller.Delete(id);
        //    Assert.IsType<NotFoundResult>(data);
        //}
        //[Fact]
        //public async void Task_delete_Return_badrequest()
        //{
        //    var controller = new BrandController(context);
        //    int? id = null;
        //    var data = await controller.Delete(id);
        //    Assert.IsType<BadRequestResult>(data);
        //}
        //[Fact]
        //public async void Task_update_Return_ok()
        //{

        //    var id = 11;

        //    var controller = new BrandController(context);
        //    var user = new Brand()
        //    {
        //        BrandId=11,
        //        BrandName = "Bislerasasi",
        //        BrandDescription = "Good One"
        //    };
        //    var data1 = await controller.Put(id,user);
        //    Assert.IsType<OkObjectResult>(data1);
        //}
        //[Fact]
        //public async void Task_update_Return_Badreq()
        //{
        //    var controller = new BrandController(context);
        //    int? id= null;

        //    var user = new Brand()
        //    {
        //        BrandId = 11,
        //        BrandName = "Bislerasasi",
        //        BrandDescription ="sadxz"
        //    };
        //    var data1 = await controller.Put(id, user);
        //    Assert.IsType<BadRequestResult>(data1);
        //}
        //[Fact]
        //public async void Task_update_Return_notfound()
        //{
        //    var controller = new BrandController(context);
        //    var id = 12;
        //    var user = new Brand()
        //    {
        //        BrandId = 11,
        //        BrandName = "Bislerasasi",
        //        BrandDescription = "awesome"
        //    };
        //    var data = await controller.Put(id, user);
        //    Assert.IsType<NotFoundResult>(data);
        //}
        //[Fact]
        //public async void Task_Return_GetAllUser()
        //{
        //    var controller = new BrandController(context);
        //    var data = await controller.Get();
        //    Assert.IsType<OkObjectResult>(data);
        //}
        //[Fact]
        //public async void Task_getAll_Return_NotFound()
        //{
        //    var controller = new BrandController(context);
        //    var data = await controller.Get();
        //    data = null;
        //    if (data != null)
        //    {
        //        Assert.IsType<OkObjectResult>(data);
        //    }
        //    else
        //    {
        //        Assert.Equal(data, null);
        //    }
        //}
    }
}
