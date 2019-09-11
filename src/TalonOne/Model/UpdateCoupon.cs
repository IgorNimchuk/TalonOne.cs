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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = TalonOne.Client.SwaggerDateConverter;

namespace TalonOne.Model
{
    /// <summary>
    /// UpdateCoupon
    /// </summary>
    [DataContract]
    public partial class UpdateCoupon :  IEquatable<UpdateCoupon>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCoupon" /> class.
        /// </summary>
        /// <param name="usageLimit">The number of times a coupon code can be redeemed. This can be set to 0 for no limit, but any campaign usage limits will still apply. .</param>
        /// <param name="startDate">Timestamp at which point the coupon becomes valid..</param>
        /// <param name="expiryDate">Expiry date of the coupon. Coupon never expires if this is omitted, zero, or negative..</param>
        /// <param name="recipientIntegrationId">The integration ID for this coupon&#39;s beneficiary&#39;s profile.</param>
        /// <param name="attributes">Arbitrary properties associated with this item.</param>
        public UpdateCoupon(int? usageLimit = default(int?), DateTime? startDate = default(DateTime?), DateTime? expiryDate = default(DateTime?), string recipientIntegrationId = default(string), Object attributes = default(Object))
        {
            this.UsageLimit = usageLimit;
            this.StartDate = startDate;
            this.ExpiryDate = expiryDate;
            this.RecipientIntegrationId = recipientIntegrationId;
            this.Attributes = attributes;
        }
        
        /// <summary>
        /// The number of times a coupon code can be redeemed. This can be set to 0 for no limit, but any campaign usage limits will still apply. 
        /// </summary>
        /// <value>The number of times a coupon code can be redeemed. This can be set to 0 for no limit, but any campaign usage limits will still apply. </value>
        [DataMember(Name="usageLimit", EmitDefaultValue=false)]
        public int? UsageLimit { get; set; }

        /// <summary>
        /// Timestamp at which point the coupon becomes valid.
        /// </summary>
        /// <value>Timestamp at which point the coupon becomes valid.</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Expiry date of the coupon. Coupon never expires if this is omitted, zero, or negative.
        /// </summary>
        /// <value>Expiry date of the coupon. Coupon never expires if this is omitted, zero, or negative.</value>
        [DataMember(Name="expiryDate", EmitDefaultValue=false)]
        public DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// The integration ID for this coupon&#39;s beneficiary&#39;s profile
        /// </summary>
        /// <value>The integration ID for this coupon&#39;s beneficiary&#39;s profile</value>
        [DataMember(Name="recipientIntegrationId", EmitDefaultValue=false)]
        public string RecipientIntegrationId { get; set; }

        /// <summary>
        /// Arbitrary properties associated with this item
        /// </summary>
        /// <value>Arbitrary properties associated with this item</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Object Attributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCoupon {\n");
            sb.Append("  UsageLimit: ").Append(UsageLimit).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("  RecipientIntegrationId: ").Append(RecipientIntegrationId).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateCoupon);
        }

        /// <summary>
        /// Returns true if UpdateCoupon instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateCoupon to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateCoupon input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UsageLimit == input.UsageLimit ||
                    (this.UsageLimit != null &&
                    this.UsageLimit.Equals(input.UsageLimit))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.ExpiryDate == input.ExpiryDate ||
                    (this.ExpiryDate != null &&
                    this.ExpiryDate.Equals(input.ExpiryDate))
                ) && 
                (
                    this.RecipientIntegrationId == input.RecipientIntegrationId ||
                    (this.RecipientIntegrationId != null &&
                    this.RecipientIntegrationId.Equals(input.RecipientIntegrationId))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.UsageLimit != null)
                    hashCode = hashCode * 59 + this.UsageLimit.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.ExpiryDate != null)
                    hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
                if (this.RecipientIntegrationId != null)
                    hashCode = hashCode * 59 + this.RecipientIntegrationId.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // UsageLimit (int?) maximum
            if(this.UsageLimit > (int?)999999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UsageLimit, must be a value less than or equal to 999999.", new [] { "UsageLimit" });
            }

            // UsageLimit (int?) minimum
            if(this.UsageLimit < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UsageLimit, must be a value greater than or equal to 0.", new [] { "UsageLimit" });
            }

            yield break;
        }
    }

}