using System;

namespace LINQ_AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LINQ AddressBookSystem!");
            //Create Object for DataTable
            ContactDataManager contactDataManager = new ContactDataManager();
            ContactDataManager contactDataManagers = new ContactDataManager();
            DataTableManger dataTableManger = new DataTableManger();
            dataTableManger.CreateDataTable();

            //Insert Values into Table
            contactDataManager.FirstName = "Ash";
            contactDataManager.LastName = "Satesh";
            contactDataManager.PhoneNumber = 9842905050;
            contactDataManager.Email = "asmitha@gmail.com";
            contactDataManager.Address = "139 B PB marg";
            contactDataManager.City = "Bareilly";
            contactDataManager.State = "UP";
            contactDataManager.zip = 243001;
            contactDataManager.AddressBookName = "Ashs book";
            contactDataManager.Type = "Family";
            dataTableManger.InsertintoDataTable(contactDataManager);

            //Insert Values into Table
            contactDataManagers.FirstName = "lalita";
            contactDataManagers.LastName = "poojah";
            contactDataManagers.PhoneNumber = 7742905050;
            contactDataManagers.Email = "lalita@gmail.com";
            contactDataManagers.Address = "Catherine Street B PB marg";
            contactDataManagers.City = "chennai";
            contactDataManagers.State = "TN";
            contactDataManagers.zip = 123001;
            contactDataManagers.AddressBookName = "Ashs book";
            contactDataManagers.Type = "Family";
            dataTableManger.InsertintoDataTable(contactDataManagers);
            ContactDataManager contactDataManagerss = new ContactDataManager();
            contactDataManagerss.FirstName = "lalita";
            contactDataManagerss.LastName = "poojah";
            contactDataManagerss.PhoneNumber = 7742905050;
            contactDataManagerss.Email = "lalita@gmail.com";
            contactDataManagerss.Address = "Catherine Street B PB marg";
            contactDataManagerss.City = "chennai";
            contactDataManagerss.State = "TNc";
            contactDataManagerss.zip = 123001;
            contactDataManagerss.AddressBookName = "Pramelas book";
            contactDataManagerss.Type = "Profession";
            dataTableManger.InsertintoDataTable(contactDataManagerss);
            dataTableManger.Display();
            string varl = dataTableManger.RetrieveCountBasedOnType();
            Console.WriteLine("Success"+varl);
        }
    }
}
