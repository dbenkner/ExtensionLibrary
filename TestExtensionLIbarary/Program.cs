
using ExtensionLibrary;

var s = "   $123,456.78";
var d = "$ 432,432,122.54";

Console.WriteLine($"{s} as a deciaml is {s.ToDecimal():C}");
Console.WriteLine($"{d} as a deciaml is {d.ToDecimal():C}");

s.WriteLine();
var e = "This is a string";
e.WriteLine();

int a =4;
Console.WriteLine(a.Eval());


/*
var s = "sadKSfasFDSdfs";

var sAllCaps = s.AllCaps();
var sAllSmall = sAllCaps.AllSmall();

Console.WriteLine($"{s} as all caps is {sAllCaps} and all small is {sAllSmall}");
*/
