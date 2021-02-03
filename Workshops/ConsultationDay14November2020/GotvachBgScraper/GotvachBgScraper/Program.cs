namespace GotvachBgScraper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Text.RegularExpressions;
    
    using AngleSharp;
    using AngleSharp.Dom;

    class Program
    {

        static void Main()
        {
            var config = Configuration.Default.WithDefaultLoader();
            var context = BrowsingContext.New(config);
            var document = context
                .OpenAsync("https://www.1001recepti.com/recipe/?recipe_id=1")
                .GetAwaiter()
                .GetResult();

            if (document.StatusCode == HttpStatusCode.NotFound ||
                document.DocumentElement.OuterHtml.Contains("Тази страница не е намерена"))
            {
                throw new InvalidOperationException();
            }

            //Recipename
            string recipeName = RecipeName(document);

            //Cooking time           
            string cookingTime = CookingTime(document);

            //Ingredients 
            var ingredients = Ingredients(document);

        }

        private static string RecipeName(IDocument document)
        {

            var list = document
                .QuerySelectorAll("div.box")
                .SelectMany(c => c.Children)
                .ToList();

            var collection = document.All.Where(m => m.LocalName == "article")
                .FirstOrDefault();

            foreach (var item in collection.Children)
            {
                if (item.LocalName == "h1")
                {
                    return item.TextContent;
                }
            }

            return null;
        }

        private static string CookingTime(IDocument document)
        {
            var co = document
               .QuerySelectorAll("#rtime")
                .Select(x => x.TextContent)
                .FirstOrDefault()
                .ToString();


            return null;
        }

        private static Dictionary<string, string> Ingredients(IDocument document)
        {
            Dictionary<string, string> ingrediantWithCounts =
                new Dictionary<string, string>();

            var list = document
                .QuerySelectorAll("#ringr > ul > li")
                .SelectMany(c => c.Children)
                .ToList();

            foreach (var item in list)
            {
                var quantity = item.Children
                    .Where(a => a.LocalName == "span")
                    .Select(i => i.TextContent)
                    .LastOrDefault();

                var ingrediantRaw = item.Children
                    .Where(a => a.LocalName == "a")
                    .Select(i => i.TextContent)
                    .LastOrDefault();
                var ingredient = RemoveNewLineTabs(ingrediantRaw);

                try
                {
                    ingrediantWithCounts.Add(ingredient, quantity);
                }
                catch (ArgumentException a) { }
            }

            return ingrediantWithCounts;
        }

        private static string RemoveNewLineTabs(string item)
        {
            var str = Regex.Replace(item, @"\t|\n|\r", "");

            return str;
        }
    }
}
