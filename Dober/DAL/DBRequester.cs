using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Dober
{
    public class DBRequester
    {
        Connection dbconnection = new Connection();

        public void InputRequest(string command)
        {
            dbconnection.StartConnection();
            MySqlCommand cmd = dbconnection.Conn.CreateCommand();
            cmd.CommandText = command;
            cmd.ExecuteNonQuery();
            dbconnection.CloseConnection();
        }
        public int inputtestrequest(string command)
        {
            int ding;
            dbconnection.StartConnection();
            MySqlCommand cmd = dbconnection.Conn.CreateCommand();
            cmd.CommandText = command;
            ding = cmd.ExecuteNonQuery();
            dbconnection.CloseConnection();
            return ding;
        }

        public string OutputRequest(string command, string OutputType)
        {
            string output = null;
            MySqlDataReader rdr = null;
            dbconnection.StartConnection();
            MySqlCommand cmd = dbconnection.Conn.CreateCommand();
            cmd.CommandText = command;
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                output = rdr[OutputType].ToString();
            }
            rdr.Close();
            cmd.Dispose();
            dbconnection.CloseConnection();
            return output;
        }

        public List<string> ListOutputRequest(string command, List<string> Outputtypes)
        {
            List<string> outputs = new List<string>();
            MySqlDataReader rdr = null;
            dbconnection.StartConnection();
            MySqlCommand cmd = dbconnection.Conn.CreateCommand();
            cmd.CommandText = command;
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                foreach (var outputtype in Outputtypes)
                {
                    outputs.Add(rdr[outputtype].ToString());
                }

            }
            rdr.Close();
            cmd.Dispose();
            dbconnection.CloseConnection();
            return outputs;

        }
        public List<List<string>> RequestHonden(string command, List<string> Outputtypes, int gebruikersid)
        {
            int aantal = inputtestrequest("SELECT COUNT(*) FROM hond WHERE BaasjeID ='" + gebruikersid.ToString()+ "'");

            List<List<string>> output = new List<List<string>>();
            //MySqlDataReader rdr = null;
            //dbconnection.StartConnection();
            //MySqlCommand cmd = dbconnection.Conn.CreateCommand();

            output[0][0] = aantal.ToString();
            //cmd.CommandText = command;
            //rdr = cmd.ExecuteReader();
            //for (int i = 0; i < aantal; i++)
            //{
            //    while (rdr.Read())
            //    {
            //        foreach (var outputtype in Outputtypes)
            //        {
            //            output[i].Add(rdr[outputtype].ToString());
            //        }

            //    }
            //    if (i < aantal -1)
            //    {
            //        rdr.NextResult();
            //    }
            //}

            //rdr.Close();
            //cmd.Dispose();
            //dbconnection.CloseConnection();
            return output;
        }
    }
}
