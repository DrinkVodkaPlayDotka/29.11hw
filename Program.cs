using System.Collections;
using System.Diagnostics;

var list=new List<int>();
var Alist = new ArrayList();
var LList = new LinkedList<int>();
Stopwatch SWlist=new Stopwatch();
Stopwatch SWAlist = new Stopwatch();
Stopwatch SWLList = new Stopwatch();
Stopwatch SWListTimer = new Stopwatch();
Stopwatch LSW777 = new Stopwatch();
Stopwatch SW777 = new Stopwatch();
Stopwatch LLSW777 = new Stopwatch();


SWAlist.Start();
for(int i = 0; i < 1000000; i++)
{
    Alist.Add(i);   
}
SWAlist.Stop ();


SWLList.Start();
for(int i = 0; i < 1000000; i++)
{
    LList.AddLast(i);
    
}
SWLList.Stop();


SWlist.Start();
for (int i = 0; i < 1000000; i++)
{
    list.Add(i);
}
SWlist.Stop();

SWListTimer.Start();
for (int i =0;i<= 496753; i++)
{
    if (list[496753] == list[i])
    {
        SWListTimer.Stop();
        Console.WriteLine("Timer search "+SWListTimer.Elapsed); //номер 4
        break;
    }
}


SW777.Start();  
for (int i = 0; i < list.Count; i++)//List
{
    if (list[i] % 777 == 0)
    {
        /*Console.WriteLine(list[i]);*/
    }
}
SW777.Stop();


LSW777.Start();
for (int i = 0; i < Alist.Count; i++) //ArrayList
{
    int AlisToInt=System.Convert.ToInt32(Alist[i]);
    if (AlisToInt % 777 == 0)
    {
        /*Console.WriteLine(Alist[i]);*/
    }
}
LSW777.Stop();

LLSW777.Start();
for (int i = 0; i < LList.Count; i=i+777) //LinkedList этот способ именно такой т.к ElementAt(i) очень медленно работал
{
    int k = LList.ElementAt(i);


    Console.WriteLine(k);

}
LLSW777.Stop();



Console.WriteLine("List 777:  "+SW777.Elapsed);//НОМЕР 5
Console.WriteLine("ArrayList 777:  " + LSW777.Elapsed);
Console.WriteLine("LinkedList 777:  " + LLSW777.Elapsed);
Console.WriteLine("RunTime List:" + SWlist.Elapsed +"\n" +"RunTime AList:" + SWAlist.Elapsed + "\n" + "RunTime LList:" + SWLList.Elapsed); ;//номер 3

