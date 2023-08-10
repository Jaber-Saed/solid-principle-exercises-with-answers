// See https://aka.ms/new-console-template for more information
using ISP.Model;

Console.WriteLine("Hello, World!");
//Using HPLaserJetPrinter we can access all Printer Services
HPLaserJetPrinter hPLaserJetPrinter = new HPLaserJetPrinter();
hPLaserJetPrinter.Print("Printing");
hPLaserJetPrinter.Scan("Scanning");
hPLaserJetPrinter.Fax("Faxing");
hPLaserJetPrinter.PrintDuplex("PrintDuplex");
//Using LiquidInkjetPrinter we can only Access Print and Scan Printer Services
LiquidInkjetPrinter liquidInkjetPrinter = new LiquidInkjetPrinter();
liquidInkjetPrinter.Print("Printing");
liquidInkjetPrinter.Scan("Scanning");
liquidInkjetPrinter.PrintDuplex("PrintDuplex");
liquidInkjetPrinter.Fax("Faxing");