using Mod4Demo1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
namespace Mod4Test
{
    
    
    /// <summary>
    ///This is a test class for CustomersTest and is intended
    ///to contain all CustomersTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CustomersTest
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
        ///A test for Customers Constructor
        ///</summary>
        [TestMethod()]
        public void CustomersConstructorTest()
        {
            Customers target = new Customers();

            string sourceFile = @"C:\Documents and Settings\Administrator\Local Settings\Temp\_SchemaData\Customers_output.xml";
            Assert.IsTrue(File.Exists(sourceFile));

            Assert.IsTrue(target.ValidateInstance(sourceFile,
                Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.XML));
        }
    }
}
