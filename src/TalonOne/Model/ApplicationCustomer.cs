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
    /// ApplicationCustomer
    /// </summary>
    [DataContract]
    public partial class ApplicationCustomer :  IEquatable<ApplicationCustomer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationCustomer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApplicationCustomer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationCustomer" /> class.
        /// </summary>
        /// <param name="id">Unique ID for this entity. (required).</param>
        /// <param name="created">The exact moment this entity was created. The exact moment this entity was created. The exact moment this entity was created. (required).</param>
        /// <param name="integrationId">The ID used for this entity in the application system. The ID used for this entity in the application system. (required).</param>
        /// <param name="attributes">Arbitrary properties associated with this item (required).</param>
        /// <param name="accountId">The ID of the Talon.One account that owns this profile. The ID of the Talon.One account that owns this profile. (required).</param>
        /// <param name="closedSessions">The total amount of closed sessions by a customer. A closed session is a successful purchase. (required).</param>
        /// <param name="totalSales">Sum of all purchases made by this customer (required).</param>
        /// <param name="loyaltyMemberships">A list of loyalty programs joined by the customer.</param>
        /// <param name="lastActivity">Timestamp of the most recent event received from this customer (required).</param>
        public ApplicationCustomer(int? id = default(int?), DateTime? created = default(DateTime?), string integrationId = default(string), Object attributes = default(Object), int? accountId = default(int?), int? closedSessions = default(int?), decimal? totalSales = default(decimal?), List<LoyaltyMembership> loyaltyMemberships = default(List<LoyaltyMembership>), DateTime? lastActivity = default(DateTime?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for ApplicationCustomer and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new InvalidDataException("created is a required property for ApplicationCustomer and cannot be null");
            }
            else
            {
                this.Created = created;
            }
            // to ensure "integrationId" is required (not null)
            if (integrationId == null)
            {
                throw new InvalidDataException("integrationId is a required property for ApplicationCustomer and cannot be null");
            }
            else
            {
                this.IntegrationId = integrationId;
            }
            // to ensure "attributes" is required (not null)
            if (attributes == null)
            {
                throw new InvalidDataException("attributes is a required property for ApplicationCustomer and cannot be null");
            }
            else
            {
                this.Attributes = attributes;
            }
            // to ensure "accountId" is required (not null)
            if (accountId == null)
            {
                throw new InvalidDataException("accountId is a required property for ApplicationCustomer and cannot be null");
            }
            else
            {
                this.AccountId = accountId;
            }
            // to ensure "closedSessions" is required (not null)
            if (closedSessions == null)
            {
                throw new InvalidDataException("closedSessions is a required property for ApplicationCustomer and cannot be null");
            }
            else
            {
                this.ClosedSessions = closedSessions;
            }
            // to ensure "totalSales" is required (not null)
            if (totalSales == null)
            {
                throw new InvalidDataException("totalSales is a required property for ApplicationCustomer and cannot be null");
            }
            else
            {
                this.TotalSales = totalSales;
            }
            // to ensure "lastActivity" is required (not null)
            if (lastActivity == null)
            {
                throw new InvalidDataException("lastActivity is a required property for ApplicationCustomer and cannot be null");
            }
            else
            {
                this.LastActivity = lastActivity;
            }
            this.LoyaltyMemberships = loyaltyMemberships;
        }
        
        /// <summary>
        /// Unique ID for this entity.
        /// </summary>
        /// <value>Unique ID for this entity.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The exact moment this entity was created. The exact moment this entity was created. The exact moment this entity was created.
        /// </summary>
        /// <value>The exact moment this entity was created. The exact moment this entity was created. The exact moment this entity was created.</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The ID used for this entity in the application system. The ID used for this entity in the application system.
        /// </summary>
        /// <value>The ID used for this entity in the application system. The ID used for this entity in the application system.</value>
        [DataMember(Name="integrationId", EmitDefaultValue=false)]
        public string IntegrationId { get; set; }

        /// <summary>
        /// Arbitrary properties associated with this item
        /// </summary>
        /// <value>Arbitrary properties associated with this item</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Object Attributes { get; set; }

        /// <summary>
        /// The ID of the Talon.One account that owns this profile. The ID of the Talon.One account that owns this profile.
        /// </summary>
        /// <value>The ID of the Talon.One account that owns this profile. The ID of the Talon.One account that owns this profile.</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public int? AccountId { get; set; }

        /// <summary>
        /// The total amount of closed sessions by a customer. A closed session is a successful purchase.
        /// </summary>
        /// <value>The total amount of closed sessions by a customer. A closed session is a successful purchase.</value>
        [DataMember(Name="closedSessions", EmitDefaultValue=false)]
        public int? ClosedSessions { get; set; }

        /// <summary>
        /// Sum of all purchases made by this customer
        /// </summary>
        /// <value>Sum of all purchases made by this customer</value>
        [DataMember(Name="totalSales", EmitDefaultValue=false)]
        public decimal? TotalSales { get; set; }

        /// <summary>
        /// A list of loyalty programs joined by the customer
        /// </summary>
        /// <value>A list of loyalty programs joined by the customer</value>
        [DataMember(Name="loyaltyMemberships", EmitDefaultValue=false)]
        public List<LoyaltyMembership> LoyaltyMemberships { get; set; }

        /// <summary>
        /// Timestamp of the most recent event received from this customer
        /// </summary>
        /// <value>Timestamp of the most recent event received from this customer</value>
        [DataMember(Name="lastActivity", EmitDefaultValue=false)]
        public DateTime? LastActivity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationCustomer {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  ClosedSessions: ").Append(ClosedSessions).Append("\n");
            sb.Append("  TotalSales: ").Append(TotalSales).Append("\n");
            sb.Append("  LoyaltyMemberships: ").Append(LoyaltyMemberships).Append("\n");
            sb.Append("  LastActivity: ").Append(LastActivity).Append("\n");
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
            return this.Equals(input as ApplicationCustomer);
        }

        /// <summary>
        /// Returns true if ApplicationCustomer instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationCustomer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationCustomer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.IntegrationId == input.IntegrationId ||
                    (this.IntegrationId != null &&
                    this.IntegrationId.Equals(input.IntegrationId))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.ClosedSessions == input.ClosedSessions ||
                    (this.ClosedSessions != null &&
                    this.ClosedSessions.Equals(input.ClosedSessions))
                ) && 
                (
                    this.TotalSales == input.TotalSales ||
                    (this.TotalSales != null &&
                    this.TotalSales.Equals(input.TotalSales))
                ) && 
                (
                    this.LoyaltyMemberships == input.LoyaltyMemberships ||
                    this.LoyaltyMemberships != null &&
                    this.LoyaltyMemberships.SequenceEqual(input.LoyaltyMemberships)
                ) && 
                (
                    this.LastActivity == input.LastActivity ||
                    (this.LastActivity != null &&
                    this.LastActivity.Equals(input.LastActivity))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.IntegrationId != null)
                    hashCode = hashCode * 59 + this.IntegrationId.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.ClosedSessions != null)
                    hashCode = hashCode * 59 + this.ClosedSessions.GetHashCode();
                if (this.TotalSales != null)
                    hashCode = hashCode * 59 + this.TotalSales.GetHashCode();
                if (this.LoyaltyMemberships != null)
                    hashCode = hashCode * 59 + this.LoyaltyMemberships.GetHashCode();
                if (this.LastActivity != null)
                    hashCode = hashCode * 59 + this.LastActivity.GetHashCode();
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
            yield break;
        }
    }

}