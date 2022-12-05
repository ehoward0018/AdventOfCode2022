using System.Diagnostics;

namespace AdventOfCode2022
{
    public class CalorieCounting
    {
        //static void Main()
        //{
        //    var path = Path.Combine(Directory.GetCurrentDirectory(), "CalorieCounting.txt");
        //    string[] numbers = File.ReadAllLines(path);
        //    int calorieCountMax = 0;
        //    int calorieCount = 0;
        //    List<int> calorieCountMaxes = new List<int>();


        //    foreach (string number in numbers)
        //    {
        //        if (String.IsNullOrEmpty(number))
        //        {
        //            if (calorieCount > calorieCountMax)
        //                calorieCountMax = calorieCount;
        //            calorieCount = 0;
        //        }
        //        else calorieCount += int.Parse(number);

        //    }

        //    Debug.WriteLine($"CalorieCountMax: {calorieCountMax}");


        //    calorieCount = 0;
        //    calorieCountMax = 0;

        //    foreach (string number in numbers)
        //    {
        //        if (String.IsNullOrEmpty(number))
        //        {
        //            if (calorieCountMaxes.Count < 3) calorieCountMaxes.Add(calorieCount);
        //            else
        //            {
        //                int index = 0;
        //                int difference = 0;
        //                for (int i = 0; i < calorieCountMaxes.Count; i++)
        //                {
        //                    if (calorieCount > calorieCountMaxes[i] && (calorieCount - calorieCountMaxes[i]) > difference)
        //                    {
        //                        difference = calorieCount - calorieCountMaxes[i];
        //                        index = i;
        //                    }
        //                }
        //                if (difference > 0) calorieCountMaxes[index] = calorieCount;
        //            }
        //            calorieCount = 0;
        //        }
        //        else calorieCount += int.Parse(number);
        //    }


        //    foreach (int cMax in calorieCountMaxes)
        //        calorieCountMax += cMax;

        //    Debug.WriteLine($"CalorieCountMaxes: {calorieCountMax}");
        //}
    }
}
