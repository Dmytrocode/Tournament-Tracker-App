using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;


namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = Connections = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool textFiles)
        {
            
            if(database)
            {
               
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if(textFiles)
            {
                //TODO Create Text Connection
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
            
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
