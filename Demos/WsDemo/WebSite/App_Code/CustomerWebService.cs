using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for GetCustomerNumber
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class CustomerWebService : System.Web.Services.WebService
{
    [WebMethod]
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

