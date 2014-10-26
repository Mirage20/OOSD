using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;


namespace SalesLeadsManagementSystem.General
{
    /// <summary>
    /// Class for manage connections and quarries to the database 
    /// 
    /// </summary>
    class DBLink
    {
        private static MySqlConnection dbConnection;

        /// <summary>
        /// Establish the mysql connection
        /// </summary>
        public static void initialize()
        {
            //string dbConnectionString = "server=sql2.freesqldatabase.com;user=sql250436;database=sql250436;port=3306;password=mV2%tJ8*;";

            string dbConnectionString = "server=localhost;user=development_link;database=salesleads;port=3306;password=pswd_sale";
            dbConnection = new MySqlConnection(dbConnectionString);
            try
            {
               
               //MessageBox.Show("Connecting to MySQL...");
               dbConnection.Open();
               MessageBox.Show("Connected...");
               
            }
            catch 
            {
                MessageBox.Show("Unable to connect to the Sever", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(-1);
            }
            dbConnection.Close();

        }

        /// <summary>
        /// Execute read quarries
        /// </summary>
        /// <param name="quarryString">command for execution</param>
        /// <returns></returns>
        public static MySqlDataReader executeReadQuarry(string quarryString)
        {
            
            MySqlDataReader dbReader=null;

            openConnection();

            MySqlCommand sqlCommand = new MySqlCommand(quarryString, dbConnection);

            dbReader =sqlCommand.ExecuteReader(); 
            
            return dbReader;
        }
        
        public static DataView executeTableQuarry(string quarryString)
        {
            openConnection();
            MySqlDataAdapter dbAdapter = new MySqlDataAdapter(quarryString, dbConnection);
            DataSet dataSet = new DataSet();
            
            dbAdapter.Fill(dataSet);

            DataView dataView = new DataView(dataSet.Tables[0]);
            closeConnection();
            
            
            return dataView;
        }


        /// <summary>
        /// Execute Write quarries
        /// </summary>
        /// <param name="quarryString">command for execution</param>
        /// <returns></returns>
        public static bool executeWriteQuarry(string quarryString)
        {
            
            MySqlCommand sqlCommand = new MySqlCommand(quarryString, dbConnection);

            if (sqlCommand.ExecuteNonQuery() > 0)
                return true;

            return false;
        }

        /// <summary>
        /// Execute Write quarries
        /// </summary>
        /// <param name="quarryString">command for execution</param>
        /// <returns></returns>
        public static bool executeWriteQuarry(string quarryString,string blobParamName,byte[] blobData)
        {

            MySqlCommand sqlCommand = new MySqlCommand(quarryString, dbConnection);
            sqlCommand.Parameters.AddWithValue(blobParamName, blobData);
            if (sqlCommand.ExecuteNonQuery() > 0)
                return true;

            return false;
        }

        /// <summary>
        /// Open the database connection.
        /// </summary>
        /// <remarks>
        /// The connection get reset if the connection is not closed before.
        /// </remarks>
        public static void openConnection()
        {
            try
            {
                dbConnection.Close();
                dbConnection.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
            }

            
        }
        /// <summary>
        /// Close the connection
        /// </summary>
        public static void closeConnection()
        {
            try
            {
                dbConnection.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
