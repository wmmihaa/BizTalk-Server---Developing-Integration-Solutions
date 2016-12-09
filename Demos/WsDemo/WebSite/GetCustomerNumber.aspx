<%@ Page Language="C#" %>

<%
    string name = Page.Request.QueryString["name"];
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
    Page.Response.Write(customerNo);

%>
