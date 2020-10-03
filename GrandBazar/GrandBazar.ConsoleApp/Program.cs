using GrandBazar.Data;
using System;

namespace GrandBazar.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new GrandBazarDbContext();
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
        }
    }
}
