using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
public class Databaselayer
{
    private SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=OMS;Integrated Security=True");
    private SqlCommand cmd;
    private SqlDataAdapter da;
    private SqlDataReader dr;

    public void SQLManagment(string query)
    {
        con.Open();
        try
        {
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }
        catch (Exception exp)
        {
            con.Close();
            
        }
        con.Close();
    }

    public DataSet FetchData(string query)
    {
        DataSet ds = new DataSet();
       
            da = new SqlDataAdapter(query, con);
            ds.Clear();
            da.Fill(ds);
            ds.Dispose();
        
        con.Close();
        return ds;
    }

    public int ExistData(string Query)
    {
        con.Open();
        try
        {
            cmd = new SqlCommand(Query, con);
            
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                con.Close();
                return 1;
            }
            else
            {
                con.Close();
                return 0;
            }
           
        }
        catch (Exception Ex)
        {
            con.Close();
            return 1;
        }

        
    }

    public int GetMaxVal(string TableName, string FileName)
    {
        int maxval = 0;
        string Query = "Select max(" + FileName + ") from " + TableName;
        con.Open();
        try
        {
            cmd = new SqlCommand(Query, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            maxval = Convert.ToInt32(dr[0]);
            maxval++;
        }
        catch (Exception ex)
        {
            maxval = 1;
            con.Close();
        }
        con.Close();
        return maxval;

    }
}