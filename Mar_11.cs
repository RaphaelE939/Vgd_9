// Today we learned how to code character escape sequences
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
\n // for 'new line'
\t // for 'tab'
\ // puts things in quotations
// How to code 
Console.WriteLine("Hello \"World\"!")//: (I don't know how this works)
Console.WriteLine("c:\\source\\repos");//: Double slash
// How to format output using character escape sequences
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
// And how to code a verbatim string literal. In order to do so, use the '@' symbol
Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");
// As well as how to format verbatim string literals
// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");
