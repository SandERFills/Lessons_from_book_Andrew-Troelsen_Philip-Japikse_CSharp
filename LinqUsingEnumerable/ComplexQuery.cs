using System;
using System.Linq;

namespace LinqUsingEnumerable
{
    class VeryComplexQueryExpression
    {
        public static void QueryStringsWithRawDelegates(){
        Console.WriteLine("Using Raw Delegates");
        string[] currentVidoGames={"Morrowind","Uncharted 2","Fallout 3","Dexter","System Shock 2"};
        Func<string,bool> searchFilter=new Func<string,bool>(Filter);
        Func<string,string> itemProcess=new Func <string,string>(ProcessItem);
        var subset=currentVidoGames.Where(searchFilter).OrderBy(itemProcess).Select(itemProcess);
        foreach (var item in subset)
        {
            System.Console.WriteLine("Item: {0}",item);
        }
}
public static bool Filter(string game){return game.Contains(" ");}
public static string ProcessItem(string game){return game;}

    }
}