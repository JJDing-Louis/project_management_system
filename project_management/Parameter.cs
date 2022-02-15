using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_management
{
    public static class Parameter
    {
        //db路徑
        public static string db_connection_string = "data source=Localhost;database=projectmanagement_db;user id=root;password=race9912264;pooling=true;charset=utf8;";

        public enum Classification
        {
            Develop,
            Bug,
            Check
        }

        public enum Priority
        {
            High,
            Medium,
            Low
        }

        public enum SoftwareState
        {
            Wait_for_Test,
            Checking,
            Complete,
            Working,
            Undo
        }

        public enum Status
        {
            NextUp,
            InProgress,
            Completed,
            Testing,
            TBD
        }
    }
}