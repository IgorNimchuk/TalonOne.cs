/* 
 * Talon.One API
 *
 * The Talon.One API is used to manage applications and campaigns, as well as to integrate with your application. The operations in the _Integration API_ section are used to integrate with our platform, while the other operations are used to manage applications and campaigns.  ### Where is the API?  The API is available at the same hostname as these docs. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerProfile][] operation is `https://mycompany.talon.one/v1/customer_profiles/id`  [updateCustomerProfile]: #operation- -v1-customer_profiles- -integrationId- -put 
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using TalonOne.Client;
using TalonOne.Api;
using TalonOne.Model;

namespace TalonOne.Test
{
    /// <summary>
    ///  Class for testing IntegrationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class IntegrationApiTests
    {
        private IntegrationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new IntegrationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of IntegrationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' IntegrationApi
            //Assert.IsInstanceOfType(typeof(IntegrationApi), instance, "instance is a IntegrationApi");
        }

        
        /// <summary>
        /// Test CreateCouponReservation
        /// </summary>
        [Test]
        public void CreateCouponReservationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string couponValue = null;
            //CouponReservations body = null;
            //var response = instance.CreateCouponReservation(couponValue, body);
            //Assert.IsInstanceOf<Coupon> (response, "response is Coupon");
        }
        
        /// <summary>
        /// Test CreateReferral
        /// </summary>
        [Test]
        public void CreateReferralTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //NewReferral body = null;
            //var response = instance.CreateReferral(body);
            //Assert.IsInstanceOf<Referral> (response, "response is Referral");
        }
        
        /// <summary>
        /// Test DeleteCouponReservation
        /// </summary>
        [Test]
        public void DeleteCouponReservationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string couponValue = null;
            //CouponReservations body = null;
            //instance.DeleteCouponReservation(couponValue, body);
            
        }
        
        /// <summary>
        /// Test DeleteCustomerData
        /// </summary>
        [Test]
        public void DeleteCustomerDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string integrationId = null;
            //instance.DeleteCustomerData(integrationId);
            
        }
        
        /// <summary>
        /// Test GetReservedCoupons
        /// </summary>
        [Test]
        public void GetReservedCouponsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string integrationId = null;
            //var response = instance.GetReservedCoupons(integrationId);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test GetReservedCustomers
        /// </summary>
        [Test]
        public void GetReservedCustomersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string couponValue = null;
            //var response = instance.GetReservedCustomers(couponValue);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test TrackEvent
        /// </summary>
        [Test]
        public void TrackEventTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //NewEvent body = null;
            //var response = instance.TrackEvent(body);
            //Assert.IsInstanceOf<IntegrationState> (response, "response is IntegrationState");
        }
        
        /// <summary>
        /// Test UpdateCustomerProfile
        /// </summary>
        [Test]
        public void UpdateCustomerProfileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string integrationId = null;
            //NewCustomerProfile body = null;
            //var response = instance.UpdateCustomerProfile(integrationId, body);
            //Assert.IsInstanceOf<IntegrationState> (response, "response is IntegrationState");
        }
        
        /// <summary>
        /// Test UpdateCustomerSession
        /// </summary>
        [Test]
        public void UpdateCustomerSessionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customerSessionId = null;
            //NewCustomerSession body = null;
            //var response = instance.UpdateCustomerSession(customerSessionId, body);
            //Assert.IsInstanceOf<IntegrationState> (response, "response is IntegrationState");
        }
        
    }

}
