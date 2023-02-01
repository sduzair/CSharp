using csharpdatenowstaticreadonly;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(InvoiceSpecification.DueDate.Second);
    Thread.Sleep(1000);
    var invoice = new InvoiceSpecification();
    Console.WriteLine(invoice.InvoiceDate.Second);
}