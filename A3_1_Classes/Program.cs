using System;

namespace A3_1_Classes
{
    class Program
    {
        static void Main()
        {
            Invoice item1 = new Invoice("Bread", 2.50m, 1);
            Invoice item2 = new Invoice("Cucumber", 1.26m, 2);
            Invoice item3 = new Invoice("Peanut butter", 2.48m, 3);
            Invoice item4 = new Invoice("Syrup", 3.99m, 4);
            Invoice item5 = new Invoice("Jam", 3.99m, 5);
            Invoice item6 = new Invoice("Acorn", 0.02m, 6);
            Invoice item7 = new Invoice("Chocolate Chips", 1.98m, 7);
            Invoice item8 = new Invoice("Milk", 2.18m, 8);
            Invoice item9 = new Invoice("Ketchup", 3.56m, 9);
            
            Console.WriteLine($"Item# {item1.Num} - {item1.Item} costs {item1.price:c}");
            Console.WriteLine($"Item# {item2.Num} - {item2.Item} costs {item2.price:c}");
            Console.WriteLine($"Item# {item3.Num} - {item3.Item} costs {item3.price:c}");
            Console.WriteLine($"Item# {item4.Num} - {item4.Item} costs {item4.price:c}");
            Console.WriteLine($"Item# {item5.Num} - {item5.Item} costs {item5.price:c}");
            Console.WriteLine($"Item# {item6.Num} - {item6.Item} costs {item6.price:c}");
            Console.WriteLine($"Item# {item7.Num} - {item7.Item} costs {item7.price:c}");
            Console.WriteLine($"Item# {item8.Num} - {item8.Item} costs {item8.price:c}");
            Console.WriteLine($"Item# {item9.Num} - {item9.Item} costs {item9.price:c}");
        }
    }
}



/*items
 * -bread 1
 * cucumber 2
 * peanut butter 3
 * syrup 4
 * jam 5 
 * acorn 6 
 * chocolate chips 7
 * milk 8
 * ketchup 9
 */