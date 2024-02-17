//string GetTemprature(int temp)
//{


//    if (temp > 20)
//    {
//        return "Isti";
//    }
//    else if (temp < 20)
//    {
//        return "Soyuq";
//    }
//    else
//    {
//        return "Mulayim";
//    }


//}
//int temp = int.Parse(Console.ReadLine());

//string result = GetTemprature(temp);
//Console.WriteLine(result);

//int GetNumbersCount(int a,int b)
//{
//    int count = 0;

//    for (int i = a; i <b; i++)
//    {
//        count++;
//    }

//    return count;
//}

//int result = GetNumbersCount(5,10);
//Console.WriteLine(result);

//int SumOfArray( int[] arr1, int[] arr2)
//{
//    int sum = 0;


//    for (int i = 0; i < arr1.Length; i++)
//    {
//        sum+= arr1[i];
//    }


//    for (int i = 0; i < arr2.Length; i++)
//    {
//        sum += arr2[i];
//    }


//    return sum;

//}

//int[] arr1 = { 1, 2, 3, 4, 5 };
//int[] arr2 = { 2, 3, 3, 7, 8 };

//int finalResult= SumOfArray(arr1 , arr2);
//Console.WriteLine(finalResult);

//int PowerOfNUmber(int n)
//{
//    int power = n * n;
//    return power;
//}

//int result3= PowerOfNUmber(10);
//Console.WriteLine(result3);

//int SumOfNumbers(int n)
//{ 
//    int sum = 0;
//    for (int i = 1;i <=n;i++)
//    {
//        if (i%2==0)
//        {
//            sum += i;
//        }


//    }
//    return sum;

//}
//int result4 = SumOfNumbers(10);
//Console.WriteLine(result4);

//1) Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.

//string IsDivide(int n)
//{
//    string message;

//    if (n % 3 == 0 && n % 7 == 0)
//    {
//        message = "Bölünür";
//    }
//    else
//    {
//        message = "Bölünmür";
//    }

//    return message;
//}
//string result = IsDivide(56);

//Console.WriteLine(result);


//2) n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.


//int SumOfEvenNumbers(int n,int m)
//{
//    int sum = 0;

//    if (n%2==0 && m%2==0)
//    {
//        sum = n + m;
//    }

//    return sum;
//}

//int result = SumOfEvenNumbers(6,10);
//Console.WriteLine(result);

//3) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.

//int GetOddNumbersCount(int n,int m)
//{
//    int count = 0;

//    for (int i = n; i <= m; i++)
//    {
//        if (i%2==1)
//        {
//            count++;
//        }

//    }

//    return count;
//}

//int result = GetOddNumbersCount(3, 8);
//Console.WriteLine(result);


//4) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.

//int SumOfOddNumbers(int n,int m)
//{
//    int sum = 0;

//    for (int i = n; i < m; i++)
//    {
//        if (i%2==1)
//        {
//            sum += i;
//        }
//    }

//    return sum;
//}

//int result = SumOfOddNumbers(3,8);
//Console.WriteLine(result);


//5)Verilmish arrayin icindeki tek ededlerin cemini tapin.

//int SumOfArrayOddItems(int[] arr)
//{
//    int sum = 0;
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i]%2==1)
//        {
//            sum += arr[i];
//        }
//    }

//    return sum;
//}
//int[] arr = { 1, 4, 6, 2, 8, 9, 5 };
//int result = SumOfArrayOddItems(arr);
//Console.WriteLine(result);


//6)Verilmish arrayin icindeki cut ededlerin sayini tapin.

//int GetEvenNumbersCount(int[] arr)
//{
//    int count = 0;

//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i]%2==0)
//        {
//            count++;
//        }
//    }
//    return count;
//}

//int[] arr = { 2, 1, 4, 6, 2, 8, 9, 5 };
//int result = GetEvenNumbersCount(arr);
//Console.WriteLine(result);

//7) Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.

//string IsPrimeOrComposite(int n)
//{
//    string message="";
//    int count = 0;
//    if (n == 1)
//    {
//        message = $"{n} - Nə sadə ədəddir nə mürəkkəb";
//    }
//    else if(n>1)
//    {

//        for (int i = 2; i <= n; i++)
//        {
//            if (n % i == 0)
//            {
//                count++;
//            }
//            if (count > 2)
//            {
//                message = $"{n}- Mürəkkəb ədəddir";
//            }
//            else
//            {
//                message = $"{n}-Sadə ədəddir";
//            }
//        }
//    }

//    return message;
//}

//string result = IsPrimeOrComposite(11);
//Console.WriteLine(result);

//8) n ededi gelir. 2-ni hansisa quvvete yukseltdikde n-in alinan cavaba beraber olub-olmamasını tapın.
//    Meselen: Cavablar ola biler:2,4,8,16,32 ve s. Yeni n bele ededler olmalidir.

//string IsPower(int n)
//{
//    int count = 0;
//    string message = "";

//    if (n == 1)
//    {
//        message = $"{n} ədədi 2-nin 0-cı dərəcədən qüvvətidir";
//    }

//    for (int i = 2; i <=n; i*=2)
//    {
//        if (n>1)
//        {
//            if (n % 2 == 0)
//            {
//                count++;
//                message = $"{n} ədədi 2-nin {count} dərəcədən qüvvətidir";
//            }
//            else
//            {
//                message = $"{n} ədədi 2-nin qüvvəti deyil";
//            }
//        }
//    }

//    return message;
//}
//string result = IsPower(16);
//Console.WriteLine(result);

//9)Verilmish arrayin-in elementlerinin icinden 1-20 arasinda olanlarinin hasilini tapmaq.Mes ([1,3,55,6,33], cavab: 18).

//int GetMultiply(int[] nums)
//{
//	int multiply = 1;
//	foreach (var num in nums)
//	{
//		if (num>1 && num<20)
//		{
//			multiply *= num;
//		}
//	}

//	return multiply;
//}

//int[] nums = {2,15,34,25,3,6,67,4 };
//int result = GetMultiply(nums);

//Console.WriteLine(result);


//10)Verilmish arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq.

//int PowerOfSum(int[] nums)
//{
//	int power = 1;
//	int sum = 0;
//	foreach (var num in nums)
//	{
//		if (num%2==0)
//		{
//			sum += num;
//		}
//	}
//	power = sum * sum;

//	return power;
//}
//int[] nums = { 2, 15, 4, 3, 6, 4 };
//int result = PowerOfSum(nums);
//Console.WriteLine(result);
