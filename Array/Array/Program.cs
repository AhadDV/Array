int[] Number = { 1, 2, 3, 4, 5, 6, 7, 3, 8, 2, 1 };

string[] General = { "Hello World", "BackEnd Developer", "FrontEnd Developer", "Test 123", "Test 321" };


#region ArrayTask-1
int[] dubilcates = Number.GroupBy(x => x)
    .Where(x => x.Count() > 1)
    .Select(x => x.Key).ToArray();
#endregion

#region ArrayTask-2
Console.WriteLine("*Add Number*");
string StringNumber = Console.ReadLine();

int.TryParse(StringNumber, out int num);

var result = Array.Exists(Number, x => x == num);

Console.WriteLine(result);
#endregion

#region ArrayTask-3
Console.WriteLine(String.Join(",", Number));
#endregion

#region ArrayTask-4
Console.WriteLine("*Add Text*");
string text = Console.ReadLine();

if (!string.IsNullOrWhiteSpace(text))
{
    string[] Items = General.GroupBy(x => x)
        .Where(x => x.Any(y => y.ToString().ToLower().Contains(text.ToLower().Trim())))
        .Select(x => x.Key).ToArray();

    Console.WriteLine(String.Join(",", Items));
}
#endregion

#region ArrayTask-5
Console.WriteLine("{0},{1}", string.Join(",", General), string.Join(",", Number));
#endregion

#region ArrayTask-6
int[] DubilcateItems = Number.GroupBy(x => x)
    .Where(x => x.Count() > 1)
    .Select(x => x.Key).ToArray();
Console.WriteLine(String.Join(",", DubilcateItems));

int[] NoDubilcateItems = Number.GroupBy(x => x)
    .Where(x => x.Count() !=0)
    .Select(x => x.Key).ToArray();
Console.WriteLine(String.Join(",", NoDubilcateItems));
#endregion












