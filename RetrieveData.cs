using System.Data.SqlClient;

namespace ADONet
{
    public class RetrieveData
    {
        public void Retrieve()
        {
            try
            {
                string connstring = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = payroll_service; Integrated Security = true";
                SqlConnection con = new SqlConnection(connstring);
                con.Open();
                string query = "Select * from EMPLOYEE_PAYROLL";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string output = "Output = " + reader.GetValue(0) + "--" + reader.GetValue(1) + "--" + reader.GetValue(2) + "--" + reader.GetValue(3) + "--" + reader.GetValue(4);
                    Console.WriteLine(output);
                }
            }
            catch (Exception e)
            { 
                Console.WriteLine(e.Message); 
            }
        }
    }
}
