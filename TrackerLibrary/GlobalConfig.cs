using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; }

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if(database)
            {
                //TODO create SQL connection
            }

            if(textFiles)
            {
                //TODO Create Text Connection
            }
            
        }

    }
}
