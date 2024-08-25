var list = Enumerable.Range(0, 1000);

var newList = list.AsParallel().AsOrdered().Select(x=>x*x*x); 

foreach (var item in newList)
{
    Console.WriteLine(item);
}
