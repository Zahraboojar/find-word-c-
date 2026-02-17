using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace person2
{
    internal class StudentManagerSql : BaseRepo, IDataSourceOperations
    {
        static string cs = "Data Source=.;Initial Catalog=Schooldb;Integrated Security=True;Encrypt=False";
        SqlConnection con = new SqlConnection(cs);
        public void Insert(StudentDto studentDto)
        {
            SqlCommand cmd = new SqlCommand("[dbo].[InsertStudent]");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", studentDto.Name);
            cmd.Parameters.AddWithValue("@Family", studentDto.Family);
            cmd.Parameters.AddWithValue("@National_Code", studentDto.National_Code);
            cmd.Parameters.AddWithValue("@Birth_Date", studentDto.Birth_Date);
            cmd.Parameters.AddWithValue("@Student_Code", studentDto.Student_Code);

            Execute(cmd);
        }
        public void Update(StudentDto studentDto)
        {
            SqlCommand cmd = new SqlCommand("[dbo].[UpdateStudent]");
            cmd.CommandType = CommandType.StoredProcedure;

            //cmd.Parameters.AddWithValue("@Name", studentDto.Name == null ? );
            //cmd.Parameters.AddWithValue("@Family", studentDto.Family);
            //cmd.Parameters.AddWithValue("@National_Code", studentDto.National_Code);
            //cmd.Parameters.AddWithValue("@Birth_Date", studentDto.Birth_Date);
            //cmd.Parameters.AddWithValue("@Student_Code", studentDto.Student_Code);

            Execute(cmd);
        }

        public OperationResult<DataTable> Select(string search)
        {
            
            SqlCommand cmd = new SqlCommand(@"SELECT * FROM Students WHERE Name LIKE '%'+@search+'%' OR Family LIKE '%'+@search+'  %'");
            cmd.Parameters.AddWithValue("@search", search);
            cmd.Connection = con;
            var dt = new DataTable();

            con.Open();
            try
            {
                var adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }

            con.Close();
            return new OperationResult<DataTable>
            {
                Data = dt,
            };

        }
        public void Delete(int id) 
        { 
        }

        //public void GetStudent(int id)
        //{
        //    SqlCommand cmd = new SqlCommand(@"SELECT * FROM Students WHERE Id = @Id");
        //    cmd.Parameters.AddWithValue("@Id", id);
        //    cmd.Connection = con;
        //    var dt = new DataTable();

        //    con.Open();
        //    try
        //    {
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }

        //    con.Close();
        //}
    }
}
