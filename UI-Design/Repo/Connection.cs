using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Repo
{
    public class Connection
    {
    public SqlConnection connect;
    public Connection()
    {
        String connectionString = "Data Source=DESKTOP-K4B953D;Initial Catalog=FishHouse;Integrated Security=True";
        connect = new SqlConnection(connectionString);
        connect.Open();

    }
    public Food GetUser(int a)
    {
        Food food = new Food();
        String cmd = "Select * From fishhouse1 Where Id Like {0}";
        cmd = String.Format(cmd, a);
        using (SqlCommand command = new SqlCommand(cmd, this.connect))
        {
            SqlDataAdapter SDA = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            SDA.Fill(table);
                var side = table.Rows.Count;
            for (int i = 0; i < side; i++)
            {
                food.Id = (int)table.Rows[i]["Id"];
                food.FoodName = (string)table.Rows[i]["FoodName"];
                food.FoodImg = (string)table.Rows[i]["FoodImg"];
                food.Description = (string)table.Rows[i]["Description"];
            }
        }
        return food;
    }
}
}
