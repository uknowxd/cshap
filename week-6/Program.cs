// See https://aka.ms/new-console-template for more information

int loop = 0; // Loop Data 3 Loop
Console.WriteLine("How Many Records Input : ");
loop = Int32.Parse(Console.ReadLine());
string[][] data = new string[loop][];
string StudentId,Prefix,FirstName,LastName,Score,grade;
int point;
// Loop เพือรับข้อมูลมาเก็บลงไว้ในตัวแปร data[]
for(int i=0; i < loop; i++){
    Console.Write("Input StudentId : ");
    StudentId = Console.ReadLine();
    Console.Write("Input Prefix : ");
    Prefix = Console.ReadLine();
    Console.Write("Input FirstName : ");
    FirstName = Console.ReadLine();
    Console.Write("Input LastName : ");
    LastName = Console.ReadLine();
    Console.Write("Input Score : ");
    Score = Console.ReadLine();
    data[i] = new string[] {StudentId, Prefix, FirstName, LastName, Score};
    Console.WriteLine("================================================");
}
// Loop เพื่อแสดงข้อมูลใน Array ตัวแปร data[]
for(int x=0; x < loop; x++){
    point = Int32.Parse(data[x][4]);
    if (point >= 80){
        grade = "A";
    }else if (point >= 75){
        grade = "B+";
    }else if (point >= 70){
        grade = "B";
    }else if (point >= 65){
        grade = "C+";
    }else if (point >= 60){
        grade = "C";
    }else if (point >= 55){
        grade = "D+";
    }else if (point >= 50){
        grade = "D";
    }else{
        grade = "E";
    }
    Console.WriteLine("StudentId: {0} FullName: {1}{2} {3} Grade:{4}", data[x][0], data[x][1], data[x][2], data[x][3], grade);
}