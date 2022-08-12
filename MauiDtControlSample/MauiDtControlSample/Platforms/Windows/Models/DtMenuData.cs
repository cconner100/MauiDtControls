namespace MauiDtControlSample.Models;

using Microsoft.UI.Xaml.Controls;

using System.Collections.Generic;

public partial class DtMenuData : IDtMenu
{
    readonly List<DtMenuItem> dtmenudata = new List<DtMenuItem>();

    readonly List<DtMenuItem> dtmenufooterdata = new List<DtMenuItem>();
    public void InitMenuData()
    {
        // create the static menu
        // Major Units
        dtmenudata.Add(DtMenuItem.MakeMenuItem(0, 0, "MAJOR_UNITS", Symbol.Page));
        dtmenudata.Add(DtMenuItem.MakeMenuItem(1, 0, "MAJOR_UNITS_INVOICING", Symbol.OtherUser, typeof(int)));
        dtmenudata.Add(DtMenuItem.MakeMenuItem(2, 0, "MUSALES_LIST", Symbol.SwitchApps,typeof(int)));
        dtmenudata.Add(DtMenuItem.MakeMenuItem(3, 0, "ORDERING", Symbol.Street, typeof(int)));
        dtmenudata.Add(DtMenuItem.MakeMenuItem(4, 0, "MURECEIVINGWITHPO", Symbol.Sort,typeof(int)));
        dtmenudata.Add(DtMenuItem.MakeMenuItem(5, 0, "MAJORUNITMANAGEMENT_GROUP", Symbol.WebCam,typeof(int)));
        dtmenudata.Add(DtMenuItem.MakeMenuItem(6, 5, "MUINVENTORY_LIST", Symbol.WebCam, typeof(int)));
        dtmenudata.Add(DtMenuItem.MakeMenuItem(7, 5, "MU_RECEIVE_TRANSFER", Symbol.WebCam, typeof(int)));
        dtmenudata.Add(DtMenuItem.MakeMenuItem(8, 5, "MODELMANAGEMENT_LIST", Symbol.WebCam, typeof(int)));
        dtmenudata.Add(DtMenuItem.MakeMenuItem(9, 5, "MU_CATEGORY_LIST", Symbol.WebCam, typeof(int)));
        dtmenudata.Add(DtMenuItem.MakeMenuItem(10, 5, "BUNDLE_LIST", Symbol.WebCam, typeof(int)));
        dtmenudata.Add(DtMenuItem.MakeMenuItem(11, 5, "INCENTIVE_LIST", Symbol.WebCam, typeof(int)));
        dtmenudata.Add(DtMenuItem.MakeMenuItem(12, 5, "NEWFISALE", Symbol.WebCam, typeof(int)));
        dtmenudata.Add(DtMenuItem.MakeMenuItem(20, 0, "MAJORUNITREPORTS", Symbol.WebCam, typeof(int)));

        // parts
        dtmenudata.Add(DtMenuItem.MakeMenuItem(100, 100, "GROUP_PARTS", Symbol.WebCam));
        dtmenudata.Add(DtMenuItem.MakeMenuItem(101, 100, "INVOICE", Symbol.WebCam, typeof(int)));
        dtmenudata.Add(DtMenuItem.MakeMenuItem(102, 100, "PART_INVOICE_LIST", Symbol.WebCam, typeof(int)));
        dtmenudata.Add(DtMenuItem.MakeMenuItem(103, 100, "PARTSORDERING", Symbol.WebCam, typeof(int)));
        dtmenudata.Add(DtMenuItem.MakeMenuItem(104, 100, "PARTSRECEIVING", Symbol.WebCam, typeof(int)));
        dtmenudata.Add(DtMenuItem.MakeMenuItem(105, 100, "PARTSMANAGEMENT_GROUP",Symbol.WebCam));
        dtmenudata.Add(DtMenuItem.MakeMenuItem(106, 105, "PARTSINVENTORY_LIST", Symbol.WebCam, typeof(int)));
        dtmenudata.Add(DtMenuItem.MakeMenuItem(107, 105, "PART_TRANSFER_IN", Symbol.WebCam, typeof(int)));
        dtmenudata.Add(DtMenuItem.MakeMenuItem(108, 105, "TRANSFEROUTOFINVENTORY", Symbol.WebCam, typeof(int)));
        dtmenudata.Add(DtMenuItem.MakeMenuItem(109, 105, "PARTSVENDORRETURN", Symbol.WebCam, typeof(int)));
        dtmenudata.Add(DtMenuItem.MakeMenuItem(110, 105, "PHYSICALINVENTORY", Symbol.WebCam, typeof(int)));
        dtmenudata.Add(DtMenuItem.MakeMenuItem(111, 105, "PART_CATEGORY_LIST", Symbol.WebCam, typeof(int)));
        dtmenudata.Add(DtMenuItem.MakeMenuItem(112, 105, "SEASONAL_ORDERING", Symbol.WebCam, typeof(int)));
        dtmenudata.Add(DtMenuItem.MakeMenuItem(113, 105, "PROFITMARGIN", Symbol.WebCam, typeof(int)));
        dtmenudata.Add(DtMenuItem.MakeMenuItem(120, 100, "PARTSREPORTS", Symbol.WebCam, typeof(int)));

        //// service
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(200, 200, "service"));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(201, 200, "serviceinvoicing", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(202, 200, "serviceinvoicelist", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(203, 200, "servicewarrantyprocessing", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(204, 200, "servicemanagement"));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(210, 204, "servicestandardjobtemplate", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(211, 204, "servicelabor", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(212, 204, "servicesubletlabor", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(213, 204, "servicetechnitiontimeclock", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(220, 200, "servicereports", typeof(int)));

        //// accounting
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(300, 300, "accounting"));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(301, 300, "accountinggeneralledger"));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(302, 301, "accountingjournalentry", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(303, 301, "accountingsearchtransactions", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(304, 301, "accountingviewscheduleaccounts", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(304, 301, "accountingchartofaccounts", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(310, 300, "accountingpayables"));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(311, 310, "accountingpackingslips", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(312, 310, "accountingcreatebills", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(313, 310, "accountingpaybills", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(314, 310, "accountingquickbills", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(315, 310, "accountingaddcreditcard", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(316, 310, "accountingvendorinquiry", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(317, 300, "accountingprintchecks"));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(320, 317, "accountingreceivables", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(321, 317, "accountingreceivepayment", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(322, 317, "accountingarcustomerinquiry", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(323, 317, "accountingstatements", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(330, 300, "accountingcashinbank"));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(331, 330, "accountingreconcile", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(332, 330, "accountingtransfers", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(333, 330, "accountingbankdeposits", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(340, 300, "accountingmaintenance"));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(341, 340, "accountingvendors", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(342, 340, "accountingpaymentmethods", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(343, 340, "accountingterms", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(344, 340, "accountingimportpayrollje", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(345, 340, "accountingrecurringtransactions", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(346, 340, "accountingdepartments", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(347, 340, "accountingtimeclockmanagement", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(350, 300, "accountingreports", typeof(int)));

        //// cashier
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(400, 400, "cashier"));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(401, 400, "cashiermiscreceipts", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(402, 400, "cashierreceivepayments", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(403, 400, "cashieropenclosecashier", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(404, 400, "cashiermanagement", typeof(int)));

        //// contacts
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(500, 500, "contacts"));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(501, 500, "contactscustomers", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(502, 500, "contactsemployees", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(503, 500, "contactssuppliers", typeof(int)));

        //// misc
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(600, 600, "misc"));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(601, 600, "miscdealershipsettings", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(602, 600, "miscfees", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(603, 600, "miscmisc", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(604, 600, "miscnonstockcategories", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(605, 600, "miscmassupdate", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(606, 600, "misclabelprinting", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(607, 600, "misclabeleditor", typeof(int)));
        //dtmenudata.Add(DtMenuItem.MakeMenuItem(608, 600, "miscdealershipsetup", typeof(int)));

        // Footer data menu
        dtmenufooterdata.Add(DtMenuItem.MakeMenuItem(0, 0, "HELP", Symbol.Help, typeof(int)));
        dtmenufooterdata.Add(DtMenuItem.MakeMenuItem(1, 0, "ACCOUNT", Symbol.Account, typeof(int)));
    }

    public List<DtMenuItem> GetPlatformMenu()
    {
        return dtmenudata;
    }

    public List<DtMenuItem> GetPlatformFooterMenu()
    {
        return dtmenufooterdata;
    }

}
