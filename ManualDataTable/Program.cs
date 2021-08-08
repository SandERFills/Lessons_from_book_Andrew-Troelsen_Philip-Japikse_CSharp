using System;
using System.Data;

namespace ManualDataTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MultiIndexerWithDataTable();
        }
        static void MultiIndexerWithDataTable(){
            DataTable myTable=new DataTable();
            myTable.Columns.Add(new DataColumn("FirstName"));
            myTable.Columns.Add(new DataColumn("LastName"));
            myTable.Columns.Add(new DataColumn("Age"));
            //Добавить строку в таблицу
            myTable.Rows.Add("Mel","Appleby",60);
            System.Console.WriteLine("First name: {0}",myTable.Rows[0][0]);
            System.Console.WriteLine("Last name: {0}",myTable.Rows[0][1]);
            System.Console.WriteLine("Age: {0}",myTable.Rows[0][2]);
        }
    }
}
