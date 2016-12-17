using NWMessaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace NWTest
{
    
    
    /// <summary>
    ///This is a test class for NWCustomerOrder_To_FKSupplierPOTest and is intended
    ///to contain all NWCustomerOrder_To_FKSupplierPOTest Unit Tests
    ///</summary>
    [TestClass()]
    public class NWCustomerOrder_To_FKSupplierPOTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for NWCustomerOrder_To_FKSupplierPO Constructor
        ///</summary>
        [TestMethod()]
        public void NWCustomerOrder_To_FKSupplierPOConstructorTest()
        {
            
            NWCustomerOrder_To_FKSupplierPO target = new NWCustomerOrder_To_FKSupplierPO();
            string sourceFile = @"C:\Labs\Lab 4\Start\CustomerOrder.xml";
            string destFile = @"C:\Labs\Lab 4\Start\SupplierPO.xml";

            target.ValidateOutput = true;
            target.TestMap(sourceFile,
            Microsoft.BizTalk.TestTools.Schema.InputInstanceType.Xml,
            destFile, Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.XML);

            Assert.IsTrue(File.Exists(destFile));
            
        }
    }
}
