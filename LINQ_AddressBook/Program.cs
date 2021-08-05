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
            ContactDataManager contactDataManagersss = new ContactDataManager();
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
            //Insert Values into Table
            contactDataManagersss.FirstName = "lalita";
            contactDataManagersss.LastName = "poojah";
            contactDataManagersss.PhoneNumber = 7742905050;
            contactDataManagersss.Email = "lalita@gmail.com";
            contactDataManagersss.Address = "Catherine Street B PB marg";
            contactDataManagersss.City = "chennai";
            contactDataManagersss.State = "TN";
            contactDataManagersss.zip = 123001;
            contactDataManagersss.AddressBookName = "Ashs book";
            contactDataManagersss.Type = "Friends";
            dataTableManger.InsertintoDataTable(contactDataManagers);

            dataTableManger.Display();
            //string varl = dataTableManger.RetrieveCountBasedOnType();
            //Console.WriteLine("Success"+varl);
        }
    }
}
