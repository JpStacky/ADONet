using System.Data.SqlClient;

namespace ADONet
{
    public class UpdateSalary
    {
        public void Update()
        {
            try
            {
                string connstring = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = payroll_service; Integrated Security = true";
                SqlConnection con = new SqlConnection(connstring);
                con.Open();
                int sal = 3000000;
                string name = "TERISA";
                string query = "UPDATE EMPLOYEE_PAYROLL SET SALARY = " + sal + " WHERE NAME = '" + name + "'";
                SqlCommand cmd = new SqlCommand(query, con);
               cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
