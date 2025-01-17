# TalonOne.Model.Application
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Unique ID for this entity. | 
**Created** | **DateTime?** | The exact moment this entity was created. | 
**Modified** | **DateTime?** | The exact moment this entity was last modified. | 
**AccountId** | **int?** | The ID of the account that owns this entity. | 
**Name** | **string** | The name of this application. | 
**Description** | **string** | A longer description of the application. | [optional] 
**Key** | **string** | Hex key for HMAC-signing API calls as coming from this application (16 hex digits) | 
**Timezone** | **string** | A string containing an IANA timezone descriptor. | 
**Currency** | **string** | A string describing a default currency for new customer sessions. | 
**CaseSensitivity** | **string** | A string indicating how should campaigns in this application deal with case sensitivity on coupon codes. | [optional] 
**Attributes** | **Object** | Arbitrary properties associated with this campaign | [optional] 
**Limits** | [**List&lt;LimitConfig&gt;**](LimitConfig.md) | Default limits for campaigns created in this application | [optional] 
**LoyaltyPrograms** | [**List&lt;LoyaltyProgram&gt;**](LoyaltyProgram.md) | An array containing all the loyalty programs to which this application is subscribed | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

