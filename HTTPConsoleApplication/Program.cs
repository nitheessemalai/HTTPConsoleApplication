
using HTTPConsole_ApplicationLibrary.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace HTTPConsoleApplication
{
     public class Program
    {
        //public object ModelState { get;set; }
        public static void Main(string[] args)
        {
            HTTPRepository obj = new HTTPRepository();
            obj.GetStaff();
        }


    } 
}
