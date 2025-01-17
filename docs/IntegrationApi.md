# TalonOne.Api.IntegrationApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCouponReservation**](IntegrationApi.md#createcouponreservation) | **POST** /v1/coupon_reservations/{couponValue} | Create a new coupon reservation
[**CreateReferral**](IntegrationApi.md#createreferral) | **POST** /v1/referrals | Create a referral code for an advocate
[**DeleteCouponReservation**](IntegrationApi.md#deletecouponreservation) | **DELETE** /v1/coupon_reservations/{couponValue} | Delete coupon reservations
[**DeleteCustomerData**](IntegrationApi.md#deletecustomerdata) | **DELETE** /v1/customer_data/{integrationId} | Delete the personal data of a customer.
[**GetReservedCoupons**](IntegrationApi.md#getreservedcoupons) | **GET** /v1/coupon_reservations/coupons/{integrationId} | Get all valid reserved coupons
[**GetReservedCustomers**](IntegrationApi.md#getreservedcustomers) | **GET** /v1/coupon_reservations/customerprofiles/{couponValue} | Get the users that have this coupon reserved
[**TrackEvent**](IntegrationApi.md#trackevent) | **POST** /v1/events | Track an Event
[**UpdateCustomerProfile**](IntegrationApi.md#updatecustomerprofile) | **PUT** /v1/customer_profiles/{integrationId} | Update a Customer Profile
[**UpdateCustomerSession**](IntegrationApi.md#updatecustomersession) | **PUT** /v1/customer_sessions/{customerSessionId} | Update a Customer Session


<a name="createcouponreservation"></a>
# **CreateCouponReservation**
> Coupon CreateCouponReservation (string couponValue, CouponReservations body)

Create a new coupon reservation

Creates a coupon reservation for all passed customer profiles on this couponID 

### Example
```csharp
using System;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreateCouponReservationExample
    {
        public void main()
        {
            // Configure API key authorization: api_key_v1
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: integration_auth
            Configuration.Default.AddApiKey("Content-Signature", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Content-Signature", "Bearer");

            var apiInstance = new IntegrationApi();
            var couponValue = couponValue_example;  // string | The value of a coupon
            var body = new CouponReservations(); // CouponReservations | 

            try
            {
                // Create a new coupon reservation
                Coupon result = apiInstance.CreateCouponReservation(couponValue, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationApi.CreateCouponReservation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **couponValue** | **string**| The value of a coupon | 
 **body** | [**CouponReservations**](CouponReservations.md)|  | 

### Return type

[**Coupon**](Coupon.md)

### Authorization

[api_key_v1](../README.md#api_key_v1), [integration_auth](../README.md#integration_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createreferral"></a>
# **CreateReferral**
> Referral CreateReferral (NewReferral body)

Create a referral code for an advocate

Creates a referral code for an advocate. The code will be valid for the referral campaign for which is created, indicated in the `campaignId` parameter, and will be associated with the profile specified in the `advocateProfileIntegrationId` parameter as the advocate's profile. 

### Example
```csharp
using System;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class CreateReferralExample
    {
        public void main()
        {
            // Configure API key authorization: api_key_v1
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: integration_auth
            Configuration.Default.AddApiKey("Content-Signature", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Content-Signature", "Bearer");

            var apiInstance = new IntegrationApi();
            var body = new NewReferral(); // NewReferral | 

            try
            {
                // Create a referral code for an advocate
                Referral result = apiInstance.CreateReferral(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationApi.CreateReferral: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NewReferral**](NewReferral.md)|  | 

### Return type

[**Referral**](Referral.md)

### Authorization

[api_key_v1](../README.md#api_key_v1), [integration_auth](../README.md#integration_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecouponreservation"></a>
# **DeleteCouponReservation**
> void DeleteCouponReservation (string couponValue, CouponReservations body)

Delete coupon reservations

Removes all passed customer profiles reservation from this coupon 

### Example
```csharp
using System;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class DeleteCouponReservationExample
    {
        public void main()
        {
            // Configure API key authorization: api_key_v1
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: integration_auth
            Configuration.Default.AddApiKey("Content-Signature", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Content-Signature", "Bearer");

            var apiInstance = new IntegrationApi();
            var couponValue = couponValue_example;  // string | The value of a coupon
            var body = new CouponReservations(); // CouponReservations | 

            try
            {
                // Delete coupon reservations
                apiInstance.DeleteCouponReservation(couponValue, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationApi.DeleteCouponReservation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **couponValue** | **string**| The value of a coupon | 
 **body** | [**CouponReservations**](CouponReservations.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key_v1](../README.md#api_key_v1), [integration_auth](../README.md#integration_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecustomerdata"></a>
# **DeleteCustomerData**
> void DeleteCustomerData (string integrationId)

Delete the personal data of a customer.

Delete all attributes on the customer profile and on entities that reference that customer profile. 

### Example
```csharp
using System;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class DeleteCustomerDataExample
    {
        public void main()
        {
            // Configure API key authorization: api_key_v1
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: integration_auth
            Configuration.Default.AddApiKey("Content-Signature", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Content-Signature", "Bearer");

            var apiInstance = new IntegrationApi();
            var integrationId = integrationId_example;  // string | The custom identifier for this profile, must be unique within the account.

            try
            {
                // Delete the personal data of a customer.
                apiInstance.DeleteCustomerData(integrationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationApi.DeleteCustomerData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **integrationId** | **string**| The custom identifier for this profile, must be unique within the account. | 

### Return type

void (empty response body)

### Authorization

[api_key_v1](../README.md#api_key_v1), [integration_auth](../README.md#integration_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreservedcoupons"></a>
# **GetReservedCoupons**
> InlineResponse2001 GetReservedCoupons (string integrationId)

Get all valid reserved coupons

Returns all coupons this user is subscribed to that are valid and usable 

### Example
```csharp
using System;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetReservedCouponsExample
    {
        public void main()
        {
            // Configure API key authorization: api_key_v1
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: integration_auth
            Configuration.Default.AddApiKey("Content-Signature", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Content-Signature", "Bearer");

            var apiInstance = new IntegrationApi();
            var integrationId = integrationId_example;  // string | The custom identifier for this profile, must be unique within the account.

            try
            {
                // Get all valid reserved coupons
                InlineResponse2001 result = apiInstance.GetReservedCoupons(integrationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationApi.GetReservedCoupons: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **integrationId** | **string**| The custom identifier for this profile, must be unique within the account. | 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[api_key_v1](../README.md#api_key_v1), [integration_auth](../README.md#integration_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreservedcustomers"></a>
# **GetReservedCustomers**
> InlineResponse200 GetReservedCustomers (string couponValue)

Get the users that have this coupon reserved

Returns all users that have this coupon marked as reserved 

### Example
```csharp
using System;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class GetReservedCustomersExample
    {
        public void main()
        {
            // Configure API key authorization: api_key_v1
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: integration_auth
            Configuration.Default.AddApiKey("Content-Signature", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Content-Signature", "Bearer");

            var apiInstance = new IntegrationApi();
            var couponValue = couponValue_example;  // string | The value of a coupon

            try
            {
                // Get the users that have this coupon reserved
                InlineResponse200 result = apiInstance.GetReservedCustomers(couponValue);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationApi.GetReservedCustomers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **couponValue** | **string**| The value of a coupon | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[api_key_v1](../README.md#api_key_v1), [integration_auth](../README.md#integration_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackevent"></a>
# **TrackEvent**
> IntegrationState TrackEvent (NewEvent body)

Track an Event

Records an arbitrary event in a customer session. For example, an integration might record an event when a user updates their payment information.  The `sessionId` body parameter is required, an event is always part of a session. Much like updating a customer session, if either the profile or the session do not exist, a new empty one will be created. Note that if the specified session already exists, it must belong to the same `profileId` or an error will be returned.  As with customer sessions, you can use an empty string for `profileId` to indicate that this is an anonymous session.  Updating a customer profile will return a response with the full integration state. This includes the current state of the customer profile, the customer session, the event that was recorded, and an array of effects that took place. 

### Example
```csharp
using System;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class TrackEventExample
    {
        public void main()
        {
            // Configure API key authorization: api_key_v1
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: integration_auth
            Configuration.Default.AddApiKey("Content-Signature", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Content-Signature", "Bearer");

            var apiInstance = new IntegrationApi();
            var body = new NewEvent(); // NewEvent | 

            try
            {
                // Track an Event
                IntegrationState result = apiInstance.TrackEvent(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationApi.TrackEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NewEvent**](NewEvent.md)|  | 

### Return type

[**IntegrationState**](IntegrationState.md)

### Authorization

[api_key_v1](../README.md#api_key_v1), [integration_auth](../README.md#integration_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecustomerprofile"></a>
# **UpdateCustomerProfile**
> IntegrationState UpdateCustomerProfile (string integrationId, NewCustomerProfile body)

Update a Customer Profile

Update (or create) a [Customer Profile][]. This profile information can then be matched and/or updated by campaign [Rules][].  The `integrationId` may be any identifier that will remain stable for the customer. For example, you might use a database ID, an email, or a phone number as the `integrationId`. It is vital that this ID **not** change over time, so **don't** use any identifier that the customer can update themselves. E.g. if your application allows a customer to update their e-mail address, you should instead use a database ID.  Updating a customer profile will return a response with the full integration state. This includes the current state of the customer profile, the customer session, the event that was recorded, and an array of effects that took place.  [Customer Profile]: /Getting-Started/entities#customer-profile [Rules]: /Getting-Started/entities#campaigns-rulesets-and-coupons 

### Example
```csharp
using System;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class UpdateCustomerProfileExample
    {
        public void main()
        {
            // Configure API key authorization: api_key_v1
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: integration_auth
            Configuration.Default.AddApiKey("Content-Signature", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Content-Signature", "Bearer");

            var apiInstance = new IntegrationApi();
            var integrationId = integrationId_example;  // string | The custom identifier for this profile, must be unique within the account.
            var body = new NewCustomerProfile(); // NewCustomerProfile | 

            try
            {
                // Update a Customer Profile
                IntegrationState result = apiInstance.UpdateCustomerProfile(integrationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationApi.UpdateCustomerProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **integrationId** | **string**| The custom identifier for this profile, must be unique within the account. | 
 **body** | [**NewCustomerProfile**](NewCustomerProfile.md)|  | 

### Return type

[**IntegrationState**](IntegrationState.md)

### Authorization

[api_key_v1](../README.md#api_key_v1), [integration_auth](../README.md#integration_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecustomersession"></a>
# **UpdateCustomerSession**
> IntegrationState UpdateCustomerSession (string customerSessionId, NewCustomerSession body)

Update a Customer Session

Update (or create) a [Customer Session][]. For example, the items in a customers cart are part of a session.  The Talon.One platform supports multiple simultaneous sessions for the same profile, so if you have multiple ways of accessing the same application you have the option of either tracking multiple independent sessions or using the same session across all of them. You should share sessions when application access points share other state, such as the users cart. If two points of access to the application have independent state (e.g. a user can have different items in their cart across the two) they should use independent customer session ID's.  The `profileId` parameter in the request body should correspond to an `integrationId` for a customer profile, to track an anonymous session use the empty string (`\"\"`) as the `profileId`. Note that you do **not** need to create a customer profile first: if the specified profile does not yet exist, an empty profile will be created automatically.  Updating a customer profile will return a response with the full integration state. This includes the current state of the customer profile, the customer session, the event that was recorded, and an array of effects that took place.  The currency for the session and the cart items in the session is the same as that of the application with which the session is associated.  [Customer Session]: /Getting-Started/entities#customer-session 

### Example
```csharp
using System;
using System.Diagnostics;
using TalonOne.Api;
using TalonOne.Client;
using TalonOne.Model;

namespace Example
{
    public class UpdateCustomerSessionExample
    {
        public void main()
        {
            // Configure API key authorization: api_key_v1
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: integration_auth
            Configuration.Default.AddApiKey("Content-Signature", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Content-Signature", "Bearer");

            var apiInstance = new IntegrationApi();
            var customerSessionId = customerSessionId_example;  // string | The custom identifier for this session, must be unique within the account.
            var body = new NewCustomerSession(); // NewCustomerSession | 

            try
            {
                // Update a Customer Session
                IntegrationState result = apiInstance.UpdateCustomerSession(customerSessionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationApi.UpdateCustomerSession: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customerSessionId** | **string**| The custom identifier for this session, must be unique within the account. | 
 **body** | [**NewCustomerSession**](NewCustomerSession.md)|  | 

### Return type

[**IntegrationState**](IntegrationState.md)

### Authorization

[api_key_v1](../README.md#api_key_v1), [integration_auth](../README.md#integration_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

