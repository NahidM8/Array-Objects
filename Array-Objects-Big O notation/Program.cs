#region Task1

//int[] numbers = { 40, 23, 22, 8, 1, 55 };
//int sum = 0;

//for (int i = 0; i <= numbers.Length-1; i++)
//{
//    sum += numbers[i];
//}

//Console.WriteLine(sum);

#endregion
#region Task2

//int[] numbers = { 40, 23, 225, 8, 1, 55 };
//int max = numbers[0];

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i]>max)
//    {
//        max = numbers[i];
//    }
//}

//Console.WriteLine(max);

#endregion
#region Task3

//int[] numbers = { 40, 23, 225, 8, 1, 55 };

//Console.WriteLine(numbers[0] + numbers[numbers.Length - 1]);

#endregion
#region Task4

//while (true)
//{
//    double n = Convert.ToInt32(Console.ReadLine());
//    if (n > 0)
//    {
//        while (n > 1)
//        {
//            n /= 2;
//        }
//        if (n == 1)
//        {
//            Console.WriteLine("n 2-nin quvvetidir");
//            break;
//        }
//        else
//        {
//            Console.WriteLine("n 2-nin quvveti deyil");
//            break;
//        }
//    }
//    else Console.WriteLine("Musbet tam eded daxil edin");
//}

#endregion
#region Task5

//int n = Convert.ToInt32(Console.ReadLine());
//int count = 0;

//if (n != 0)
//{
//    if (n < 0)
//    {
//        n = -n;
//    }
//    while (n>=1)
//    {
//        n /= 10;
//        count++;
//    }
//}
//else count +=1 ;
//Console.WriteLine(count);

#endregion
#region Task6

//int[] numbers = { 12, 22, 25, 34, 40, 55, 68, 98, 100, 101 };
//int target = 55;
//int index = -1;

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] == target)
//    {
//        index = i; break;
//    }
//}
//Console.WriteLine(index);

#endregion
#region Task7

//int[] numbers = { 400, 23, 220, 8, 1, -100, 99 };
//int sum = 0;

//for (int i = 0; i <= numbers.Length - 1; i++)
//{
//    if (numbers[i] >= 100 || numbers[i] <= -100)
//    {
//        sum += numbers[i];
//    }
//}

//Console.WriteLine(sum);

#endregion
#region Task8

//var student1 = new
//{
//    GroupNo = "PB302",
//    point = 76
//};
//var student2 = new
//{
//    GroupNo = "PB304",
//    point = 66
//};
//var student3 = new
//{
//    GroupNo = "PB302",
//    point = 81
//};
//double count = 0;
//double sum = 0;

//object[] students = { student1, student2, student3 };

//if (student1.GroupNo == "PB302")
//{
//    sum += student1.point;
//    count++;
//}
//if (student2.GroupNo == "PB302")
//{
//    sum += student2.point;
//    count++;
//}
//if (student3.GroupNo == "PB302")
//{
//    sum += student3.point;
//    count++;
//}

//double average = sum / count;
//Console.WriteLine($"Average: {average}");


#endregion