//string prefix,firstName,lastName;
//int studentId;
//double height, weight;

Console.WriteLine("Enter Your Prefix (Mr/Ms) :");
string prefix = Console.ReadLine();
Console.Clear();
Console.WriteLine("Enter Your FirstName :");
string firstName = Console.ReadLine();
Console.Clear();
Console.WriteLine("Enter Your LastName :");
string lastName = Console.ReadLine();
Console.Clear();
Console.WriteLine("Enter Your StudentID :");
int studentId = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine("Enter Your Height :");
double height = Convert.ToDouble(Console.ReadLine());
Console.Clear();
Console.WriteLine("Enter Your Weight :");
double weight = Convert.ToDouble(Console.ReadLine());
Console.Clear();
double Result = weight / ((height / 100) * (height / 100));


Console.WriteLine("*******************");
Console.WriteLine("Student ID : {0}", studentId);
Console.WriteLine("Fullname : {0}", prefix+"."+firstName+" "+lastName);
Console.WriteLine("You Height : {0}", height);
Console.WriteLine("You Weight : {0}", weight);
Console.WriteLine("You BMI : {0}", Result);
Console.WriteLine("*******************");