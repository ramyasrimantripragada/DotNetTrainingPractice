using System.Data.SqlClient;
using System.Data;

namespace EmployeeRecordManagement
{
    public class EmployeeDB
    {
        SqlConnection connection;
        public void CreateConnection()
        {
            this.connection = new SqlConnection();
            this.connection.ConnectionString = "data source=EPINHYDW0B9D\\SQLEXPRESS; Initial Catalog= WordVoyager; Integrated Security=True";
            this.connection.Open();
        }

        public int InsertEmployee(string name, string designation, string department)
        {
            SqlCommand command = new SqlCommand("uspInsertEmployee", connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter nameParam = new SqlParameter()
            {
                ParameterName = "@Name",
                Value = name,
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
            };
            command.Parameters.Add(nameParam);
            SqlParameter designationParam = new SqlParameter()
            {
                ParameterName = "@Designation",
                Value = designation,
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
            };
            command.Parameters.Add(designationParam);
            SqlParameter departmentParam = new SqlParameter()
            {
                ParameterName = "@Department",
                Value = department,
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
            };
            command.Parameters.Add(departmentParam);
            SqlParameter idParam = new SqlParameter()
            {
                ParameterName = "@EmployeeId",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Output,
            };
            command.Parameters.Add(idParam);
            command.ExecuteNonQuery();
            return int.Parse(idParam.Value.ToString());
        }

        public int DeleteEmployee(int id)
        {
            SqlCommand command = new SqlCommand("uspDeleteEmployee", connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter idParam = new SqlParameter()
            {
                ParameterName = "@EmployeeId",
                Value = id,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
            };
            command.Parameters.Add(idParam);
            return command.ExecuteNonQuery();
        }

        public DataSet DisplayEmployees()
        {
            SqlCommand command = new SqlCommand("uspGetEmployeeRecords", connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "EMPLOYEE");
            adapter.SelectCommand = command;
            DataSet dataSet = new DataSet("EMPLOYEE");
            adapter.Fill(dataSet);
            return dataSet;
        }

        public int UpdateEmployeeDetails(int empId, string name, string designation, string department)
        {
            SqlCommand command = new SqlCommand("uspUpdateEmployeeDetails", connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter idParam = new SqlParameter()
            {
                ParameterName = "@EmployeeId",
                Value = empId,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
            };
            command.Parameters.Add(idParam);
            SqlParameter nameParam = new SqlParameter()
            {
                ParameterName = "@Name",
                Value = name,
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
            };
            command.Parameters.Add(nameParam);
            SqlParameter designationParam = new SqlParameter()
            {
                ParameterName = "@Designation",
                Value = designation,
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
            };
            command.Parameters.Add(designationParam);
            SqlParameter departmentParam = new SqlParameter()
            {
                ParameterName = "@Department",
                Value = department,
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
            };
            command.Parameters.Add(departmentParam);
            return command.ExecuteNonQuery();
        }

        public void CloseConnection()
        {
            this.connection.Close();
        }
    }
}

