using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateBaseFaculty
{

    public class  CRUD:Form
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
      



        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        
        public DataTable Select()
        {
         
            

            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {

                
              

                string sql = "SELECT s.StudentId,s.LastName,s.FirstName,s.Age,c.City,c.Address,c.Phone" +
                   " FROM Students as s LEFT JOIN Contacts as c ON s.StudentId=c.StudentId";

                string sql1 = "SELECT s.TeacherID,s.LastName,s.FirstName,s.Age,c.City,c.Address,c.Phone" +
                   " FROM Teachers as s LEFT JOIN Contacts as c ON s.TeacherID=c.TeacherID";

                string connect = null;

                if (TrueOrFalse.Get() == true)
                    connect = sql;
                else
                    connect = sql1;




                SqlCommand cmd = new SqlCommand(connect, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
           
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();

            }
            return dt;
        }
     public bool Insert(CRUD crud)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string teacher =

                  " INSERT INTO Teachers" +
               "(LastName,FirstName,Age)" +
               "VALUES" +
               "(@LastName,@FirstName,@Age)";

                string student =
               " INSERT INTO Students" +
               "(LastName,FirstName,Age)" +
               "VALUES" +
               "(@LastName,@FirstName,@Age)";

                string contacts
                    = "INSERT INTO  Contacts(StudentID,City,Address,Phone) " +
                    "VALUES (@ID,@City,@Address,@Phone)";

                string contacts1
                    = "INSERT INTO  Contacts(TeacherID,City,Address,Phone) " +
                    "VALUES (@ID,@City,@Address,@Phone)";


                string connect = null;

                if (TrueOrFalse.Get() == true)
                    connect = student+ contacts ;
                else
                    connect = teacher + contacts1 ;








                SqlCommand cmd = new SqlCommand(connect, conn);

                cmd.Parameters.AddWithValue("@Id", crud.ID);
                cmd.Parameters.AddWithValue("@FirstName", crud.FirstName);
                cmd.Parameters.AddWithValue("@LastName", crud.LastName);
                cmd.Parameters.AddWithValue("@Age", crud.Age);
                cmd.Parameters.AddWithValue("@City", crud.City);
                cmd.Parameters.AddWithValue("@Address", crud.Address);
                cmd.Parameters.AddWithValue("@Phone", crud.Phone);
             


                conn.Open();
                int rows = cmd.ExecuteNonQuery();
            
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
   public bool Update(CRUD crud)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            
            try
            {
                string connect = null;
                if (TrueOrFalse.Get() == true)
                    connect = "UPDATE Students SET LastName=@LastName,FirstName=@FirstName,Age=@Age WHERE StudentID=@ID ";
                else
                    connect = "UPDATE Teachers SET LastName=@LastName,FirstName=@FirstName,Age=@Age WHERE TeacherID=@ID ";


                string sql = connect+
                 "UPDATE Contacts SET  City=@City,Address=@Address,Phone=@Phone  WHERE ContactID=@ID";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Id", crud.ID);
                cmd.Parameters.AddWithValue("@LastName", crud.LastName);
                cmd.Parameters.AddWithValue("@FirstName", crud.FirstName);
                cmd.Parameters.AddWithValue("@Age", crud.Age);
                cmd.Parameters.AddWithValue("@City", crud.City);
                cmd.Parameters.AddWithValue("@Address", crud.Address);
                cmd.Parameters.AddWithValue("@Phone", crud.Phone);
              




                conn.Open();
                int rows = cmd.ExecuteNonQuery();
              
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

       public bool Delete(CRUD crud)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                int currentnumber = ID - 1;
                string lastarg = currentnumber.ToString()+" )";
                string foo = "DBCC CHECKIDENT(Students, RESEED, "+ lastarg;
                string foo1 = "DBCC CHECKIDENT(Contacts, RESEED, " + lastarg;

                if (TrueOrFalse.Get()==false)
                    foo= "DBCC CHECKIDENT(Teachers, RESEED, " + lastarg;


                string connect = null;
                if (TrueOrFalse.Get() == true)
                    connect = foo1+"DELETE FROM Students WHERE StudentId=@Id " + foo ;
                else
                    connect = foo1+"DELETE FROM Teachers WHERE TeacherID=@Id "+ foo;



                

                  
                    
                   
                   
                SqlCommand cmd = new SqlCommand(connect, conn);
                cmd.Parameters.AddWithValue("@ID", crud.ID);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;

                }
                else
                {
                    isSuccess = false;
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }


    }
}

