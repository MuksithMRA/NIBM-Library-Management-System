using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Library_Management_System_v1._1.Model
{
    

    class DatabaseService
    {
        MySqlCommand cmd;
        MySqlConnection con;

        public MySqlConnection Con { get => con; set => con = value; }

        public DatabaseService()
        {
            con = new MySqlConnection("Server=98.142.97.194;Port=3306;Database=irixsolu_coda;Uid=irixsolu_irix;Pwd=Mot413654*;Convert Zero Datetime=True;");
        }

        public int insertData(String query) {
            int i = 0;
            
            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);
                i = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally {
                con.Close();
            }
            return i;
        }


        public int updateData(String query)
        {
            int i = 0;
            
            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);
                i = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return i;
        }


        public int deleteData(String query)
        {
            int i = 0;
            
            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);
                i = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return i;
        }

        public MySqlDataReader readData(String query)
        {
            cmd = new MySqlCommand(query, con);
            cmd.CommandType = System.Data.CommandType.Text;
            MySqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            return sdr;
        }
    }
   
}
