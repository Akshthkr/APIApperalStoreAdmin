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
    public class CategoryTestController
    {
        private ApplicationDbContext context;
        public static DbContextOptions<ApplicationDbContext> dbContextOptions { get; set; }
        public static string connnectionString = "Data Source=TRD-501; Initial Catalog=MainApparelDb ;Integrated Security=True;";
        static CategoryTestController()
        {
            dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer(connnectionString).Options;
        }
        public CategoryTestController()
        {
            context = new ApplicationDbContext(dbContextOptions);
        }
        //[Fact]
        //public async void Task_GetById_Return_OkResult()
        //{
        //    var controller = new CategoryController(context);
        //    var CatId = 1;
        //    var data = await controller.Get(CatId);
        //    Assert.IsType<OkObjectResult>(data);
        //}
        //[Fact]
        //public async void Task_GetById_Return_NOFResult()
        //{
        //    var controller = new CategoryController(context);
        //    var CatId = 9;
        //    var data = await controller.Get(CatId);
        //    Assert.IsType<NotFoundResult>(data);
        //}
        //[Fact]
        //public async void Task_GetById_Return_MatchResult()
        //{
        //    var controller = new CategoryController(context);
        //    var Id = 1;
        //    var data = await controller.Get(Id);
        //    Assert.IsType<OkObjectResult>(data);
        //    var okResult = data.Should().BeOfType<OkObjectResult>().Subject;
        //    var cat = okResult.Value.Should().BeAssignableTo<Category>().Subject;
        //    Assert.Equal("Shoes", cat.CategoryName);
        //}
        //[Fact]
        //public async void Task_Add_Return_OkRequest()
        //{
        //    var controller = new CategoryController(context);
        //    var user = new Category()
        //    {
        //        CategoryName = "bottle",
        //        CategoryDescription = "pure"
        //    };
        //    var data = await controller.Post(user);
        //    Assert.IsType<CreatedAtActionResult>(data);
        //}
        //[Fact]
        //public async void Task_Add_InvalidData_Return_BadRequest()
        //{
        //    var controller = new CategoryController(context);
        //    var user = new Category()
        //    {
        //        CategoryName = "bottlekajscklkjxhcjsd",
        //        CategoryDescription = "pure"
        //    };
        //    var data = await controller.Post(user);
        //    Assert.IsType<BadRequestResult>(data);
        //}
        //[Fact]
        //public async void Task_delete_Return_okResult()
        //{
        //    var controller = new CategoryController(context);
        //    var id = 10;
        //    var data = await controller.Delete(id);
        //    Assert.IsType<OkObjectResult>(data);
        //}

        //[Fact]
        //public async void Task_delete_Return_notfound()
        //{
        //    var controller = new CategoryController(context);
        //    var id = 100;
        //    var data = await controller.Delete(id);
        //    Assert.IsType<NotFoundResult>(data);
        //}
        //[Fact]
        //public async void Task_delete_Return_badrequest()
        //{
        //    var controller = new CategoryController(context);
        //    int? id = null;
        //    var data = await controller.Delete(id);
        //    Assert.IsType<BadRequestResult>(data);
        //}
        //[Fact]
        //public async void Task_update_Return_ok()
        //{

        //    var id = 5;

        //    var controller = new CategoryController(context);
        //    var user = new Category()
        //    {
        //        CategoryId = 5,
        //        CategoryName = "Bislei",
        //        CategoryDescription = "Good One"
        //    };
        //    var data1 = await controller.Put(id, user);
        //    Assert.IsType<OkObjectResult>(data1);
        //}
        //[Fact]
        //public async void Task_update_Return_Badreq()
        //{
        //    var controller = new CategoryController(context);
        //    int? id = null;

        //    var user = new Category()
        //    {
        //        CategoryId = 11,
        //        CategoryName = "Bislerasasi",
        //        CategoryDescription = "sadxz"
        //    };
        //    var data1 = await controller.Put(id, user);
        //    Assert.IsType<BadRequestResult>(data1);
        //}
        //[Fact]
        //public async void Task_update_Return_notfound()
        //{
        //    var controller = new CategoryController(context);
        //    var id = 12;
        //    var user = new Category()
        //    {
        //        CategoryId = 11,
        //        CategoryName = "Bislerasasi",
        //        CategoryDescription = "sadxz"
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
        //    var controller = new CategoryController(context);
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
