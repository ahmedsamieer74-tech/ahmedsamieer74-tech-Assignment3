// cs.proj ==> contains all projects in my solution.
// program.ce ==> The entry point in my file (Main).
// bin ==> the intermmediate file while build
// obj ==> the final file after building done
/* Cs.proj.content
 <Project Sdk="Microsoft.NET.Sdk">

<PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    </PropertyGroup>

    </Project>
 */

namespace CSharpBasicsAssignment;
// The file scope namespace removes a level of identation File-scoped namespace removes one level of indentation
//  because it doesn't create a { } block around the rest of the file.
// my project uses slnx || one advantage of sln ==> broader compatibility with older tooling

class Program
{
    static void Main(string[] args)
    {
        int a = 1;
        long b = 2300;
        double c = 3.14;
        decimal d = 5.5m;
        bool e = true;
        char f = 'a';
        string g = "b";
        var h = "CR7";
        Console.WriteLine($"The value is {a},Type {a.GetType()}");
        Console.WriteLine($"The value is {b},Type {b.GetType()}");
        Console.WriteLine($"The value is {c},Type {c.GetType()}");
        Console.WriteLine($"The value is {d},Type {d.GetType()}");
        Console.WriteLine($"The value is {e},Type {e.GetType()}");
        Console.WriteLine($"The value is {f},Type {f.GetType()}");
        Console.WriteLine($"The value is {g},Type {g.GetType()}");
        Console.WriteLine($"The value is {h},Type {h.GetType()}");
        // implicit casting
        b = a;
        Console.WriteLine(b);
        a = f;
        // Truncate : adjusts the value to the nearest number based on the fractional part. || Rounding : removes the fractional part without rounding
        Console.WriteLine(a);
        // Implicit conversion is allowed because the destination type has a larger range
        a = (int)c;
        Console.WriteLine(a);
        c = Convert.ToInt32(c);
        int x = 5 / 2;
        Console.WriteLine(x);
        double y = 5.0 / 2;
        Console.WriteLine(y);
        object n = 5;
        int z = (int)n;
        Console.WriteLine(z);
        object n2 = z;
        Console.WriteLine(n2);

        int num = int.Parse("42");
        Console.WriteLine(num);
        bool yy = int.TryParse("abc", out int num2);
        if (!yy)
            Console.WriteLine("Invalid input");

        else
            Console.WriteLine(yy);

        float f2 = 3.14f;
        decimal oo = (decimal)f2;

        // The compiler refuses the implicit casting because float and decimal storage datea in different way to avoid losing data .

        point p1 = new point { x = 1, y = 2 };
        point p2 = p1;
        p2.x = 99;
        Console.WriteLine(p1.x);
        Console.WriteLine(p2.x);
        // these different because the struct value type .
        Order o1 = new Order
        {
            CustomerName = "Ahmed",
            OrderId = 123,
            DiscoutPercent = 50m,
            IsPaid = false,
            ItemCode = 2245432353,
            ShippingCity = "London",
            Priority = 'M',
            Quantity = 2,
            TotalPrice = 0,
            UnitPrice = 2.5m
        };
        o1.CalculateTotal();
        Order o2 = o1;
        o2.IsPaid = true;
        Console.WriteLine(o2.IsPaid);
        Console.WriteLine(o1.IsPaid);
        // They must be the same because 2 ref equals that meanings the refs link to the same object in the heap . 
        object boxedOrder = o1;
        Order o3 = (Order)boxedOrder;
        Console.WriteLine(object.ReferenceEquals(o1, o3));
        o2.PrintSummary();

    // value type lives in stack , reference type lives in Heap.
    // (=) in value type copies the value .
    // (=) in reference type copies the Address .
    // storing a ref inside object var doesn't create a new object because (=) copies the ref didn't create a new object    
    string name = "Eng.Abdelrahaman";
    for (int i = 0; i <name.Length ; i++)
    {
        Console.WriteLine(name[i]);
        int count = 0;
        count++;
    }
    
    // count = 5; ==> compile error because here out of the scope declered in it then this destroyed from the stack.

    int total = 100;
    int num3 = 2;
    total += num3; // This equivalent to total = total + num2 ;
    Console.WriteLine($"The total is {total}");
    total -= num3;
    Console.WriteLine($"The total is {total}");
    total *= num3;
    Console.WriteLine($"The total is {total}");
    total /= num3;
    Console.WriteLine($"The total is {total}");
    total %= num3;
    Console.WriteLine($"The total is {total}");

    int aa = 12;//1100
    int bb = 10;//1010
    Console.WriteLine($"The result of & = {aa&bb}");// The result in binary (1000)
    Console.WriteLine($"The result of | = {aa|bb}");// The result in binary (1110)
    Console.WriteLine($"The result of ^ = {aa^bb}");// The result in binary (0110)
    // && doesn't check the right side when left is false while & checks the right side anyway even if it is false

    int[] arr = { 1, 1, 2, 2, 3 };
    int[] arr2 = { 4,4,1,2,2};
    int SingleNumber(int[] nums)
    {

        int result = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            result = result ^ nums[i];


        }

        return result;
        // XOR cancels out pairs of the same number because x ^ x = 0
        // if odd number say 3 then (x^x)^x ==> 0^x = x and so on.
    }

    Console.WriteLine(SingleNumber(arr));
    Console.WriteLine(SingleNumber(arr2));
   
    


    }
    private string _name;

    public void Method()
    {
        string name = "Ahmed";
    }

struct point
{
    public int x, y;
}

}


