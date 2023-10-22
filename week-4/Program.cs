String[][] data = new string[10][];
data[0] = new string[] {"654245001", "Mr.", "Nattapong", "Boonrod", "75"};
data[1] = new string[] {"654245004", "Mr.", "Tanawin", "Poinsombut", "82"};
data[2] = new string[] {"654245005", "Mr.", "Paruenhat", "Jomruerum", "56"};
data[3] = new string[] {"654245006", "Mr.", "Phoorit", "Pompasert", "66"};
data[4] = new string[] {"654245007", "Mr.", "Phoorin", "Jitpitipamot", "71"};
data[5] = new string[] {"654245009", "Mr.", "Sittipon", "Sopanmo", "54"};
data[6] = new string[] {"654245010", "Mr.", "Anusorn", "Kanin", "48"};
data[7] = new string[] {"654245011", "Mr.", "Apiwatkiti", "Srionn", "79"};
data[8] = new string[] {"654245012", "Ms.", "Sasikan", "Janwan", "66"};
data[9] = new string[] {"654245013", "Ms.", "Tridawan", "Shokaram", "58"};

int point;
string grade;
int i = 0;
for(i=0; i < data.Length; i++){
    point = Int32.Parse(data[i][4]);
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
    Console.WriteLine("StudentId: {0} FullName: {1}{2} {3} Grade:{4}", data[i][0], data[i][1], data[i][2], data[i][3], grade);
}