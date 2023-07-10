using ListGenericTodoUygulama.database;
using ListGenericTodoUygulama.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListGenericTodoUygulama.businessService
{
    public class todoService
    {
        public int kayitKontrol() 
        {
            return sanalDatabase.todotablo.Count;

        }

        public List<todo> kayitListe() 
        {
            return sanalDatabase.todotablo;
        }

        public int kayitYeni(todo data)
        {
            try
            {
                sanalDatabase.todotablo.Add(data);
                return 1;
            }
            catch (Exception ex)
            {
                return 0;                
            }
            
        }
    }
}
