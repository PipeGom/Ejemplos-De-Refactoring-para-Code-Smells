using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosDeRefactoring


{   
    // Ejemplo #1 

    // Se repite el mismo metodo en ambas clases.
    class FileLogger 
    {
        public bool IsLogMessageValid(string message) 
        {
            //Check if the message cotains sentive data such as SSN, Credit Card number, etc.
            return (!string.IsNullOrEmpty(message));
        }

        public bool DoLog(string message) 
        {
            //Code to log to a text file 
            return true;
        }

    }
    class DbLogger {
        public bool IsLogMessageValid(string message) 
        {
            // Check if the message cotains sentive data such as SSN, Credit Card number, etc.
            return (!string.IsNullOrEmpty(message));

        }
        public bool DoLog(string message)
        {
            //Code to log to a database 
            return true;
        }
    }

    // Para solucionar este Code Smell, se recurre a la Refactorización por abstracción
    public abstract class BaseLogger 
    {
        // Comenzamos por introducir los metodos reduntantes en una clase abstracta. a esto se le conoce como Pull up
        // Basicamente subimos los metodos que se repiten en ambas clases.
        public bool IsLogMessageValid(string message)
        {
            
            return (!string.IsNullOrEmpty(message));

        }
        public abstract bool DoLog(string message);

    }
    class FileLoggerRefactorizado : BaseLogger
    {
        public override bool DoLog(string message)
        { 

            //Code to log to a text file 
            return true;
        }
    }
    class DbLoggerRefactorizado : BaseLogger
    {
        public override bool DoLog(string message)
        {
            //Code to log to a database 
            return true;
        }
    }
}
