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
    ///  Class for testing UpdateUser
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class UpdateUserTests
    {
        // TODO uncomment below to declare an instance variable for UpdateUser
        //private UpdateUser instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of UpdateUser
            //instance = new UpdateUser();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UpdateUser
        /// </summary>
        [Test]
        public void UpdateUserInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" UpdateUser
            //Assert.IsInstanceOfType<UpdateUser> (instance, "variable 'instance' is a UpdateUser");
        }


        /// <summary>
        /// Test the property 'Email'
        /// </summary>
        [Test]
        public void EmailTest()
        {
            // TODO unit test for the property 'Email'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Password'
        /// </summary>
        [Test]
        public void PasswordTest()
        {
            // TODO unit test for the property 'Password'
        }
        /// <summary>
        /// Test the property 'NewPassword'
        /// </summary>
        [Test]
        public void NewPasswordTest()
        {
            // TODO unit test for the property 'NewPassword'
        }
        /// <summary>
        /// Test the property 'Policy'
        /// </summary>
        [Test]
        public void PolicyTest()
        {
            // TODO unit test for the property 'Policy'
        }
        /// <summary>
        /// Test the property 'State'
        /// </summary>
        [Test]
        public void StateTest()
        {
            // TODO unit test for the property 'State'
        }
        /// <summary>
        /// Test the property 'ReleaseUpdate'
        /// </summary>
        [Test]
        public void ReleaseUpdateTest()
        {
            // TODO unit test for the property 'ReleaseUpdate'
        }
        /// <summary>
        /// Test the property 'LatestFeature'
        /// </summary>
        [Test]
        public void LatestFeatureTest()
        {
            // TODO unit test for the property 'LatestFeature'
        }
        /// <summary>
        /// Test the property 'Roles'
        /// </summary>
        [Test]
        public void RolesTest()
        {
            // TODO unit test for the property 'Roles'
        }
        /// <summary>
        /// Test the property 'ApplicationNotificationSubscriptions'
        /// </summary>
        [Test]
        public void ApplicationNotificationSubscriptionsTest()
        {
            // TODO unit test for the property 'ApplicationNotificationSubscriptions'
        }

    }

}
