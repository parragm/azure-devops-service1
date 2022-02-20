namespace Service1.Controllers
{
    using System;
    //using System.Net.Http;
    //using System.Data.SqlClient;
    using Microsoft.AspNetCore.Mvc;
    using Service1.Models;

    [Route("api/service1")]
    public class HomeController : ControllerBase
    {
        //private readonly HttpClient client = new HttpClient();

        [HttpGet]
        public IActionResult GetServiceName()
        {
            Console.WriteLine("GetServiceName called on Service1");

            return Ok(
                new ServiceModel
                {
                    Id = 1,
                    Name = "Service1"
                }
            );
        }

        //[HttpGet]
        //public IActionResult GetServiceDetails()
        //{
        //    Console.WriteLine("GetServiceDetails called on Service1");

        //    var connStr = "";

        //    using (var conn = new SqlConnection(connStr))
        //    {
        //        conn.Open();
                
        //    }

        //    return Ok(
        //        new ServiceModel
        //        {
        //            Id = 1,
        //            Name = "Service1"
        //        }
        //    );
        //}

        //[Route("call")]
        //[HttpPost]
        //public IActionResult CallExternalService()
        //{
        //    Console.WriteLine("Calling Service2");

        //    try
        //    {
        //        var response = client.GetAsync("http://service2-clusterip:80/api/service2").Result;

        //        response.EnsureSuccessStatusCode();
        //        Console.WriteLine(response);

        //        return Ok(response.StatusCode);
        //    }
        //    catch(Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        return StatusCode(500, ex.Message);
        //    }
        //}
    }
}