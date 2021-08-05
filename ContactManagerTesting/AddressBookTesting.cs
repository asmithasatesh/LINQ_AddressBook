using Microsoft.VisualStudio.TestTools.UnitTesting;
using LINQ_AddressBook;

namespace ContactManagerTesting
{
    [TestClass]
    public class AddressBookTesting
    {
        DataTableManger dataTableManger;

        [TestInitialize]
        public void SetUp()
        {
            dataTableManger = new DataTableManger();
        }

        //Usecase 1: Create and Insert values in DataTable
        [TestMethod]
        [TestCategory("Insert Values in Data Table")]
        public void GivenInsertValues_returnInteger()
        {
            int expected = 3;
            int actual=dataTableManger.AddValues();
            Assert.AreEqual(actual, expected);
        }
        //Usecase 2: Modify values in DataTable based on Name
        [TestMethod]
        [TestCategory("Modify Values in Data Table")]
        public void GivenModifyValues_returnInteger()
        {
            int expected = 1;
            int actual = dataTableManger.EditDataTable("lalita", "Lastname");
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        [TestCategory("Modify Values in Data Table-Negative Test Case")]
        public void GivenWrong_ModifyValues_returnInteger()
        {
            int expected = 0;
            int actual = dataTableManger.EditDataTable("mam", "Lastname");
            Assert.AreEqual(actual, expected);
        }
        //Usecase 3: Delete values in DataTable based on Name
        [TestMethod]
        [TestCategory("Delete Row in Data Table")]
        public void GivenDeleteQuery_returnInteger()
        {
            int expected = 1;
            int actual = dataTableManger.DeleteRowInDataTable("lalita");
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        [TestCategory("Delete Row in Data Table-Negative Test Case")]
        public void GivenWrongDeleteQuery_returnInteger()
        {
            int expected = 0;
            int actual = dataTableManger.DeleteRowInDataTable("lala");
            Assert.AreEqual(actual, expected);
        }
        //Usecase 4: Retrieve values from DataTable based on City or State
        [TestMethod]
        [TestCategory("Retrieve Row in Data Table based on City ")]
        public void GivenRetrieveQuery_BasedOnCityandState_returnString()
        {
            string expected = "lalita Merra ";
            string actual = dataTableManger.RetrieveBasedOnCityorState("Lucknow","TN");
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        [TestCategory("Retrieve Row in Data Table based on state ")]
        public void GivenRetrieveQuery_BasedOnCityorState_returnString()
        {
            string expected = "Ash lalita Merra ";
            string actual = dataTableManger.RetrieveBasedOnCityorState("Lucknow", "UP");
            Assert.AreEqual(actual, expected);
        }
        //Usecase 5: Retrieve count values from DataTable based on City or State
        [TestMethod]
        [TestCategory("Retrieve Row in Data Table based on City ")]
        public void GivenRetrieveCountQuery_BasedOnCityandState_returnString()
        {
            string expected = "1 2 ";
            string actual = dataTableManger.RetrieveCountBasedOnCityorState();
            Assert.AreEqual(actual, expected);
        }
        //Usecase 6: Sort based on City
        [TestMethod]
        [TestCategory("Sort based on City")]
        public void GivenSortQuery_BasedOnCityandState_returnString()
        {
            string expected = "lalita Merra ";
            string actual = dataTableManger.SortBasedOnNameInDataTable("Lucknow");
            Assert.AreEqual(actual, expected);
        }
        //Usecase 6: Count based on Contact Type
        [TestMethod]
        [TestCategory("Sort based on City")]
        public void GivenCountQuery_BasedOnCityandState_returnString()
        {
            string expected = "1 1 1 ";
            string actual = dataTableManger.RetrieveCountBasedOnType();
            Assert.AreEqual(actual, expected);
        }
    }
}
