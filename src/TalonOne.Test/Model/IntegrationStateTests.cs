/* 
 * Talon.One API
 *
 * The Talon.One API is used to manage applications and campaigns, as well as to integrate with your application. The operations in the _Integration API_ section are used to integrate with our platform, while the other operations are used to manage applications and campaigns.  ### Where is the API?  The API is available at the same hostname as these docs. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerProfile][] operation is `https://mycompany.talon.one/v1/customer_profiles/id`  [updateCustomerProfile]: #operation- -v1-customer_profiles- -integrationId- -put 
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using TalonOne.Api;
using TalonOne.Model;
using TalonOne.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace TalonOne.Test
{
    /// <summary>
    ///  Class for testing IntegrationState
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class IntegrationStateTests
    {
        // TODO uncomment below to declare an instance variable for IntegrationState
        //private IntegrationState instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of IntegrationState
            //instance = new IntegrationState();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of IntegrationState
        /// </summary>
        [Test]
        public void IntegrationStateInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" IntegrationState
            //Assert.IsInstanceOfType<IntegrationState> (instance, "variable 'instance' is a IntegrationState");
        }


        /// <summary>
        /// Test the property 'Session'
        /// </summary>
        [Test]
        public void SessionTest()
        {
            // TODO unit test for the property 'Session'
        }
        /// <summary>
        /// Test the property 'Profile'
        /// </summary>
        [Test]
        public void ProfileTest()
        {
            // TODO unit test for the property 'Profile'
        }
        /// <summary>
        /// Test the property 'Event'
        /// </summary>
        [Test]
        public void EventTest()
        {
            // TODO unit test for the property 'Event'
        }
        /// <summary>
        /// Test the property 'Loyalty'
        /// </summary>
        [Test]
        public void LoyaltyTest()
        {
            // TODO unit test for the property 'Loyalty'
        }

    }

}
