# TalonOne.Model.ApplicationCustomer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Unique ID for this entity. | 
**Created** | **DateTime?** | The exact moment this entity was created. The exact moment this entity was created. The exact moment this entity was created. | 
**IntegrationId** | **string** | The ID used for this entity in the application system. The ID used for this entity in the application system. | 
**Attributes** | **Object** | Arbitrary properties associated with this item | 
**AccountId** | **int?** | The ID of the Talon.One account that owns this profile. The ID of the Talon.One account that owns this profile. | 
**ClosedSessions** | **int?** | The total amount of closed sessions by a customer. A closed session is a successful purchase. | 
**TotalSales** | **decimal?** | Sum of all purchases made by this customer | 
**LoyaltyMemberships** | [**List&lt;LoyaltyMembership&gt;**](LoyaltyMembership.md) | A list of loyalty programs joined by the customer | [optional] 
**LastActivity** | **DateTime?** | Timestamp of the most recent event received from this customer | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

