using Microsoft.VisualBasic.FileIO;

string[] ourList1 = new string [4] {"Hello", "2", "world", ":-)"};
string[] ourList2 = new string [4]{"1234", "1567", "-2", "computer science"};
string[] ourList3 = new string [3]{"Russia", "Denmark", "Kazan"};
int n = 3;

string[] CreateNewArray(string[]ourList){
    List<string> newArray = new List<string>();
    for(int i = 0;i< ourList.Length;i++){
        if (ourList[i].Length <= n){
            newArray.Add(ourList[i]);
        }
    }
    return newArray.ToArray();
}


string[] newArray1 = CreateNewArray(ourList1);
Console.WriteLine($"[{string.Join(", " , ourList1)}]");
Console.WriteLine($"[{string.Join(", " , newArray1)}]");
Console.WriteLine("");

string[] newArray2 = CreateNewArray(ourList2);
Console.WriteLine($"[{string.Join(", " , ourList2)}]");
Console.WriteLine($"[{string.Join(", " , newArray2)}]");
Console.WriteLine("");

string[] newArray3 = CreateNewArray(ourList3);
Console.WriteLine($"[{string.Join(", " , ourList3)}]");
Console.WriteLine($"[{string.Join(", " , newArray3)}]");
