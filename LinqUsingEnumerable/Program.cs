using System;
using System.Linq;

namespace LinqUsingEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** LINQ using Enumerable!********");
            QueryStringsWithAnonymousMethods();
            System.Console.WriteLine();
            VeryComplexQueryExpression.QueryStringsWithRawDelegates();
        }
        static void QueryStringWithOperators(){
            System.Console.WriteLine("**** Using Query Operators *****");
            string[] currentVidoGames={"Morrowind","Uncharted 2","Fallout 3","Dexter","System Shock 2"};
            var subset =from game in currentVidoGames where game.Contains(" ") orderby game select game;//построение запроса через встроенные ключевые слова запросов C#

            foreach (var s in subset)
            {
                System.Console.WriteLine("Item: {0}",s);
            }
        }
        static void QueryStringWithEnumerableAndLambdas(){
            string[] currentVidoGames={"Morrowind","Uncharted 2","Fallout 3","Dexter","System Shock 2"};
            //Построение выражение запроса с использованием расширяющих методов
            var subset =currentVidoGames.Where(game=>game.Contains(" ")).OrderBy(game=>game).Select(game=>game);
            foreach (var s in subset)
            {
                Console.WriteLine("Item: {0}",s);
            }
        }
        static void QueryStringWithEnumerableAndLambdas2(){
            string[] currentVidoGames={"Morrowind","Uncharted 2","Fallout 3","Dexter","System Shock 2"};
            //Построение выражение запроса с использованием расширяющих методов
            var gamesWithWhiteSpace =currentVidoGames.Where(game=>game.Contains(" "));
            var orderedGames=gamesWithWhiteSpace.OrderBy(game=>game);
            var selectedGames=orderedGames.Select(game=>game);

            foreach (var s in selectedGames)
            {
                Console.WriteLine("Item: {0}",s);
            }
        }
        static void QueryStringsWithAnonymousMethods(){
            string[] currentVidoGames={"Morrowind","Uncharted 2","Fallout 3","Dexter","System Shock 2"};
            //Построить необходимые делегаты Func<> с использованием анонимных методов
            Func<string,bool> searchFilter=delegate(string game){return game.Contains(" ");};
            Func<string,string> itemProcess=delegate(string s){return s;};
            //Передать делегаты в методы класса Enumerable.
            var subset=currentVidoGames.Where(searchFilter).OrderBy(itemProcess).Select(itemProcess);
            //вывести результат
            foreach(var item in subset){
                System.Console.WriteLine("Item {0}",item);
                System.Console.WriteLine();
            }
        }


    }
}
