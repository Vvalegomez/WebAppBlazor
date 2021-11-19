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

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public DepartamentController(IConfiguration configuration)
        {
            _configuration = configuration;
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
            using(SqlConnection sqlConexion = new SqlConnection(sqlDataSource))
            {
                sqlConexion.Open();
                using(SqlCommand cmd = new SqlCommand(query,sqlConexion))
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
        public JsonResult Post(Departament departament)
        {
            string query = @"
               insert into dbo.Departament values (@DepartamentName)
             ";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("EmployeeAppCon");
            SqlDataReader reader;
            using (SqlConnection sqlConexion = new SqlConnection(sqlDataSource))
            {
                sqlConexion.Open();
                using (SqlCommand cmd = new SqlCommand(query, sqlConexion))
                {
                    cmd.Parameters.AddWithValue("@DepartamentName", departament.DepartamentName);
                    reader = cmd.ExecuteReader();
                    table.Load(reader);
                    reader.Close();
                    sqlConexion.Close();
                }
            }

            return new JsonResult(table);
        }

        [HttpPut]
        public JsonResult Put(Departament departament)
        {
            string query = @"
               update dbo.Departament set DepartamentName = @DepartamentName where DepartamentId = @DepartamentId
             ";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("EmployeeAppCon");
            SqlDataReader reader;
            using (SqlConnection sqlConexion = new SqlConnection(sqlDataSource))
            {
                sqlConexion.Open();
                using (SqlCommand cmd = new SqlCommand(query, sqlConexion))
                {
                    cmd.Parameters.AddWithValue("@DepartamentId", departament.DepartamentId);
                    cmd.Parameters.AddWithValue("@DepartamentName", departament.DepartamentName);
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
               delete from dbo.Departament where DepartamentId = @DepartamentId
             ";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("EmployeeAppCon");
            SqlDataReader reader;
            using (SqlConnection sqlConexion = new SqlConnection(sqlDataSource))
            {
                sqlConexion.Open();
                using (SqlCommand cmd = new SqlCommand(query, sqlConexion))
                {
                    cmd.Parameters.AddWithValue("@DepartamentId", id);
                    
                    reader = cmd.ExecuteReader();
                    table.Load(reader);
                    reader.Close();
                    sqlConexion.Close();
                }
            }

            return new JsonResult(table);
        }

    }
}
