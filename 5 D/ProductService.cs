using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles._5_D
{
    public class ProductService
    {
        private readonly FileLogger _fileLogger = new FileLogger();
        public void LogToFile(string message)
        {
            _fileLogger.Log(message);
        }


        #region private methods
        //private readonly DatabaseLogger _databaseLogger = new DatabaseLogger();

        //public void LogToDatabase(string message)
        //{
        //    _databaseLogger.Log(message);
        //}
        #endregion



    }
}
