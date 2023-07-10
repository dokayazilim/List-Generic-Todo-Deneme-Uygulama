using ListGenericTodoUygulama.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListGenericTodoUygulama.database
{
    public static class sanalDatabase
    {
        public static List<kullanici> kullanicitablo;
        public static List<todo> todotablo;

        static sanalDatabase() 
        {
            kullanicitablo = new List<kullanici>();
            kullanicitablo.Add(new kullanici() { id = Guid.NewGuid(), kullaniciAdi = "test1", sifre = "1" });
            todotablo = new List<todo>();


        }

    }
}
