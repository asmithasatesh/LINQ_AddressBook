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

        [TestMethod]
        [TestCategory("Insert Values in Data Table")]
        public void GivenInsertValues_returnInteger()
        {
            int expected = 2;
            int actual=dataTableManger.AddValues();
            Assert.AreEqual(actual, expected);
        }
    }
}
