// See https://aka.ms/new-console-template for more information


using AbstractVsInterface;
using System.Collections;
using System.Threading;


dervemethodhiding mdd = new dervemethodhiding();
mdd.method();

methodhiding mb = new methodhiding();
mb.method();

methodhiding md= new dervemethodhiding();
md.method();

#region Boxing and Un-boxing
int i = 10;
object a = i; //i values is moved to reference type
int z=(int)a; // reference type to value type
#endregion

#region casting (data lose)

int cs = 10;
double d = cs;// casting(implict casting)lower dataype to higer datatype
double ch = 100.34;
//int excs = ch; // is throw error
int excs1 =(int) ch;  //explict casting
#endregion

#region Array vs array list
int[] arr=new int[3];
ArrayList arrayList = new ArrayList();
arrayList.Add(arr);
arr[0] = 10;
#endregion

#region generic collection
// its stroingly typed and size is flexible
List<int> list = new List<int>();
list.Add(10);
#endregion



//before changing the interface coding is working
Icustomerdetails customer = new customerdetail();
customer.customerName();

//After changing the interface also exist code is working
Icustomerbankdetais CSB = new customerdetail();
CSB.Customerbankdetails();

virtualoverride ov = new Overidden();
ov.Description();
Console.WriteLine("Hello, World!");
Console.ReadKey();
