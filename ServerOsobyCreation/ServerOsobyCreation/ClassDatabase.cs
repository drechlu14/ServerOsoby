using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerOsobyCreation
{
    public class ClassDatabase
    {
        // Json connection
        var client = new RestClient("https://vyuka.sps-prosek.cz/phpmyadmin");

        var request = new RestRequest("resource/{id}", Method.POST);
        request.AddParameter("name", "value"); // adds to POST or URL querystring based on Method
    }
}
