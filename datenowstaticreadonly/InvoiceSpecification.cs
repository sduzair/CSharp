using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdatenowstaticreadonly;

//internal class InvoiceSpecification
//{
//    public static readonly DateTime InvoiceDate = DateTime.Now;

//    public static readonly DateTime DueDate = InvoiceDate.AddDays(30);
//}

internal class InvoiceSpecification
{
    public readonly DateTime InvoiceDate;

    public static readonly DateTime DueDate = DateTime.UtcNow;      // takes the time when the class field is invoked for the first time

    public InvoiceSpecification()
    {
        InvoiceDate = DateTime.UtcNow;
    }
    
}