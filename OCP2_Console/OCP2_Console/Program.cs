// See https://aka.ms/new-console-template for more information
using OCP2.Model;

Console.WriteLine("Hello, World!");
Console.WriteLine("Invoice Amount: 10000");
Invoice FInvoice = new Invoice();
double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000, InvoiceType.FinalInvoice);
Console.WriteLine($"Final Invoive : {FInvoiceAmount}");
Invoice PInvoice = new Invoice();
double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000, InvoiceType.ProposedInvoice);
Console.WriteLine($"Proposed Invoive : {PInvoiceAmount}");
