using sealednamespace;

Demo d1 = Demo.GetInstance();
Demo d2 = Demo.GetInstance();

Console.WriteLine(d1.GetNum() + "==>" + d2.GetNum());
Console.WriteLine((d1 == d2));

Type a = d1.GetType();
Console.WriteLine(a);


// Console.WriteLine("");
