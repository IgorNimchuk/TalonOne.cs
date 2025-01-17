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
    ///  Class for testing AccountLimits
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AccountLimitsTests
    {
        // TODO uncomment below to declare an instance variable for AccountLimits
        //private AccountLimits instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of AccountLimits
            //instance = new AccountLimits();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AccountLimits
        /// </summary>
        [Test]
        public void AccountLimitsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" AccountLimits
            //Assert.IsInstanceOfType<AccountLimits> (instance, "variable 'instance' is a AccountLimits");
        }


        /// <summary>
        /// Test the property 'LiveApplications'
        /// </summary>
        [Test]
        public void LiveApplicationsTest()
        {
            // TODO unit test for the property 'LiveApplications'
        }
        /// <summary>
        /// Test the property 'SandboxApplications'
        /// </summary>
        [Test]
        public void SandboxApplicationsTest()
        {
            // TODO unit test for the property 'SandboxApplications'
        }
        /// <summary>
        /// Test the property 'ActiveCampaigns'
        /// </summary>
        [Test]
        public void ActiveCampaignsTest()
        {
            // TODO unit test for the property 'ActiveCampaigns'
        }
        /// <summary>
        /// Test the property 'Coupons'
        /// </summary>
        [Test]
        public void CouponsTest()
        {
            // TODO unit test for the property 'Coupons'
        }
        /// <summary>
        /// Test the property 'ReferralCodes'
        /// </summary>
        [Test]
        public void ReferralCodesTest()
        {
            // TODO unit test for the property 'ReferralCodes'
        }
        /// <summary>
        /// Test the property 'LiveLoyaltyPrograms'
        /// </summary>
        [Test]
        public void LiveLoyaltyProgramsTest()
        {
            // TODO unit test for the property 'LiveLoyaltyPrograms'
        }
        /// <summary>
        /// Test the property 'SandboxLoyaltyPrograms'
        /// </summary>
        [Test]
        public void SandboxLoyaltyProgramsTest()
        {
            // TODO unit test for the property 'SandboxLoyaltyPrograms'
        }
        /// <summary>
        /// Test the property 'Webhooks'
        /// </summary>
        [Test]
        public void WebhooksTest()
        {
            // TODO unit test for the property 'Webhooks'
        }
        /// <summary>
        /// Test the property 'Users'
        /// </summary>
        [Test]
        public void UsersTest()
        {
            // TODO unit test for the property 'Users'
        }
        /// <summary>
        /// Test the property 'ApiVolume'
        /// </summary>
        [Test]
        public void ApiVolumeTest()
        {
            // TODO unit test for the property 'ApiVolume'
        }
        /// <summary>
        /// Test the property 'PromotionTypes'
        /// </summary>
        [Test]
        public void PromotionTypesTest()
        {
            // TODO unit test for the property 'PromotionTypes'
        }

    }

}
