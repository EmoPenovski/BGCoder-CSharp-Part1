using System;
using System.Threading;
using System.Globalization;

class Garden
{
    static void Main(string[] args)
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InstalledUICulture;

        int tomatoSeed = int.Parse(Console.ReadLine());
        int tomatoArea = int.Parse(Console.ReadLine());
        int cucumberSeed = int.Parse(Console.ReadLine());
        int cucumberArea = int.Parse(Console.ReadLine());
        int potateSeed = int.Parse(Console.ReadLine());
        int potateArea = int.Parse(Console.ReadLine());
        int carroSeed = int.Parse(Console.ReadLine());
        int carroArea = int.Parse(Console.ReadLine());
        int cabbaseSeed = int.Parse(Console.ReadLine());
        int cabbaseArea = int.Parse(Console.ReadLine());
        int beanSeed = int.Parse(Console.ReadLine());


        double tomatoCost = 0.5;
        double cucumberCost = 0.4;
        double potatoCost = 0.25;
        double carrotCost = 0.6;
        double cabbageCost = 0.3;
        double beanCost = 0.4;

        double totalCost = tomatoSeed * tomatoCost + cucumberSeed * cucumberCost + potateSeed * potatoCost + carroSeed * carrotCost + cabbaseSeed * cabbageCost + beanSeed*beanCost;
        Console.WriteLine("Total costs: {0:F2}",totalCost);
        int beansArea = 250 - tomatoArea - cucumberArea - potateArea - carroArea - cabbaseArea;
        if(beansArea>0)
        {
            Console.WriteLine("Beans area: "+beansArea);
        }
        else if(beansArea==0)
        {
            Console.WriteLine("No area for beans");
        }
        else
        {
            Console.WriteLine("Insufficient area");
        }
    }
}

