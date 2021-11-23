using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;
using Api.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _env;
        public EmployeeController(IConfiguration configuration, IWebHostEnvironment env)
        {
            _configuration = configuration;
            _env = env;
        }

        [HttpGet]
        public JsonResult Get()
        {
            string query = @"
               select * from dbo.Departament
             ";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("EmployeeAppCon");
            SqlDataReader reader;
            using (SqlConnection sqlConexion = new SqlConnection(sqlDataSource))
            {
                sqlConexion.Open();
                using (SqlCommand cmd = new SqlCommand(query, sqlConexion))
                {
                    reader = cmd.ExecuteReader();
                    table.Load(reader);
                    reader.Close();
                    sqlConexion.Close();
                }
            }

            return new JsonResult(table);
        }

        [HttpPost]
        public JsonResult Post(Employee employee)
        {
            string query = @"
               insert into dbo.Employee (EmployeeName,Departament,DateOfJoining,PhotoFileName) values
               (@EmployeeName,@Departament,@DateOfJoining,@PhotoFileName)
             ";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("EmployeeAppCon");
            SqlDataReader reader;
            using (SqlConnection sqlConexion = new SqlConnection(sqlDataSource))
            {
                sqlConexion.Open();
                using (SqlCommand cmd = new SqlCommand(query, sqlConexion))
                {
                    cmd.Parameters.AddWithValue("@EmployeeName", employee.EmployeeName);
                    cmd.Parameters.AddWithValue("@Departament", employee.Departament);
                    cmd.Parameters.AddWithValue("@DateOfJoining", employee.DateOfJoining);
                    cmd.Parameters.AddWithValue("@PhotoFileName", employee.PhotoFileName);
                    reader = cmd.ExecuteReader();
                    table.Load(reader);
                    reader.Close();
                    sqlConexion.Close();
                }
            }

            return new JsonResult(table);
        }

        [HttpPut]
        public JsonResult Put(Employee employee)
        {
            string query = @"
               update dbo.Employee set EmployeeName = @EmployeeName,Departament = @Departament,Departament = @Departament,
               DateOfJoining = @DateOfJoining, PhotoFileName = @PhotoFileName
               where EmployeeId = @EmployeeId
             ";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("EmployeeAppCon");
            SqlDataReader reader;
            using (SqlConnection sqlConexion = new SqlConnection(sqlDataSource))
            {
                sqlConexion.Open();
                using (SqlCommand cmd = new SqlCommand(query, sqlConexion))
                {
                    cmd.Parameters.AddWithValue("@EmployeeName", employee.EmployeeName);
                    cmd.Parameters.AddWithValue("@Departament", employee.Departament);
                    cmd.Parameters.AddWithValue("@DateOfJoining", employee.DateOfJoining);
                    cmd.Parameters.AddWithValue("@PhotoFileName", employee.PhotoFileName);
                    reader = cmd.ExecuteReader();
                    table.Load(reader);
                    reader.Close();
                    sqlConexion.Close();
                }
            }

            return new JsonResult(table);
        }

        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            string query = @"
               delete from dbo.Employee where EmployeeId = @EmployeeId
             ";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("EmployeeAppCon");
            SqlDataReader reader;
            using (SqlConnection sqlConexion = new SqlConnection(sqlDataSource))
            {
                sqlConexion.Open();
                using (SqlCommand cmd = new SqlCommand(query, sqlConexion))
                {
                    cmd.Parameters.AddWithValue("@EmployeeId", id);

                    reader = cmd.ExecuteReader();
                    table.Load(reader);
                    reader.Close();
                    sqlConexion.Close();
                }
            }

            return new JsonResult(table);
        }

        [Route("SaveFile")]
        [HttpPost]
        public JsonResult SaveFile()
        {
            try
            {
                var httpRequest = Request.Form;
                var postedFile = httpRequest.Files[0];
                string fileName = postedFile.FileName;
                var physicalPath = _env.ContentRootPath + "/Photos"+ fileName;

                using (var stream = new FileStream(physicalPath, FileMode.Create))
                {
                    postedFile.CopyTo(stream);
                }

                return new JsonResult(fileName);

            }
            catch (Exception)
            {

                return new JsonResult("anonymus.png");
            }
        }

    }
}
