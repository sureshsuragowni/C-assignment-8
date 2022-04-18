using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAttribute
{
    [AttributeUsage(                 
    AttributeTargets.Class |
    AttributeTargets.Constructor |
    AttributeTargets.Field |
    AttributeTargets.Method |
    AttributeTargets.Property,
    AllowMultiple = true)]

    public class SoftwareAttribute : System.Attribute  
    {
        private String projectName;
        private String description;
        private String clientName;
        private String startedDate;
        private String endDate;


        public SoftwareAttribute(String Pn, String Dn, String Cn, String Sd, String Ed)
        {
            this.projectName = Pn;
            this.description = Dn;
            this.clientName = Cn;
            this.startedDate = Sd;
            this.endDate = Ed;
        }

        public String ProjectName
        {
            get { return this.projectName; }
        }
        public String Description
        {
            get { return this.description; }
        }
        public String ClientName
        {
            get { return this.clientName; }
        }
        public String StartedDate
        {
            get { return this.startedDate; }
        }
        public String EndingDate
        {
            get { return this.endDate; }
        }

    }
    [SoftwareAttribute("smart farm monitoring", "agriculture purpose", "google cloud", "30 / 04/ 2022", "12/10/2025")]
    [SoftwareAttribute("Gps tracking", "about Maps", "solutions tech", "20 / 5 / 2022", "31/01/2028")]
    class HDFCAccount
    {
        
        protected int accountNumber;
        protected String customerName;
        public HDFCAccount(int acNumber, String customerName)
        {
            this.accountNumber = acNumber;
            this.customerName = customerName;
        }
        [SoftwareAttribute("smart farm monitoring", "agriculture purpose", "google cloud", "30 / 04/ 2022", "12/10/2025")]

        public int AcNumber
        {
            get
            {
                return this.accountNumber;
            }

        }
        public String CustomerName
        {
            get { return this.customerName; }
        }

        public void DisplayHDFCAccountDetails()
        {
            Console.WriteLine("HDFC Account number : " + accountNumber);
            Console.WriteLine("HDFC Customer Name : " + customerName);
            Console.ReadKey();
        }

    }
    [SoftwareAttribute("smart farm monitoring", "agriculture purpose", "google cloud", "30 / 04/ 2022", "12/10/2025")]
    [SoftwareAttribute("Gps tracking", "about Maps", "solutions tech", "20 / 5 / 2022", "31/01/2028")]
    public class ICICIAccount
    {
        public int iciciAcNumber;
        public String iciciCustomerName;

        public ICICIAccount(int iciciAcNumber, String iciciCustomerName)
        {
            this.iciciAcNumber = iciciAcNumber;
            this.iciciCustomerName = iciciCustomerName;
        }
        [SoftwareAttribute("Gps tracking", "about Maps", "solutions tech", "20 / 5 / 2022", "31/01/2028")]

        public int IciciAcNumber
        {
            get { return this.iciciAcNumber; }
        }
        public String IciciCustomerName
        {
            get { return this.iciciCustomerName; }
        }
        public void DisplayICICIAccountDetails()
        {
            Console.WriteLine("ICICI Account Number :  " + iciciAcNumber);
            Console.WriteLine("ICICI Customer Name : " + iciciCustomerName);
        }

    }

    public class Attribute
    {
        static void Main(String[] args)
        {
            HDFCAccount hdfc = new HDFCAccount(8474646, "Suresh Gowd");
            hdfc.DisplayHDFCAccountDetails();
            Console.WriteLine("Press Enter to view ICICI Account Number : ");
            Console.ReadKey();
            ICICIAccount icici = new ICICIAccount(9484876, "Ramesh Gupta");
            icici.DisplayICICIAccountDetails();

            SoftwareAttribute customAttribute = new SoftwareAttribute("Atm machines", "Atm Controlling", "Capgemini", "12/04/2022", "03/05/2023");

        }
    }
}