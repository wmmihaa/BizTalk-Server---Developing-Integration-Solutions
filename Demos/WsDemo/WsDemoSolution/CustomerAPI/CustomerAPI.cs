using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CustomerAPI
{
    public int GetCustomerNumber(string name)
    {
        int customerNo = 0;

        switch (name)
        {
            case "Monica":
                customerNo = 1;
                break;
            case "Wenke":
                customerNo = 2;
                break;
            case "Agneta":
                customerNo = 3;
                break;
            case "Tomi":
                customerNo = 4;
                break;
            case "Stefan":
                customerNo = 5;
                break;
            default:
                customerNo = 6;
                break;
        }
        return customerNo;
    }
}