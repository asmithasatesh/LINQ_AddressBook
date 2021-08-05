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
            dataTableManger.InsertintoDataTable(contactDataManager);

            //Insert Values into Table
            contactDataManagers.FirstName = "lalita";
            contactDataManagers.LastName = "poojah";
            contactDataManagers.PhoneNumber = 7742905050;
            contactDataManagers.Email = "lalita@gmail.com";
            contactDataManagers.Address = "Catherine Street B PB marg";
            contactDataManagers.City = "Bareilly";
            contactDataManagers.State = "UP";
            contactDataManagers.zip = 123001;
            dataTableManger.InsertintoDataTable(contactDataManagers);
            dataTableManger.Display();
        }
    }
}
