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
    /// LedgerEntry
    /// </summary>
    [DataContract]
    public partial class LedgerEntry :  IEquatable<LedgerEntry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LedgerEntry" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LedgerEntry() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LedgerEntry" /> class.
        /// </summary>
        /// <param name="id">Unique ID for this entity. (required).</param>
        /// <param name="created">The exact moment this entity was created. (required).</param>
        /// <param name="profileId">ID of the customers profile as used within this Talon.One account. May be omitted or set to the empty string if the customer does not yet have a known profile ID. (required).</param>
        /// <param name="accountId">The ID of the Talon.One account that owns this profile. (required).</param>
        /// <param name="loyaltyProgramId">ID of the ledger (required).</param>
        /// <param name="eventId">ID of the related event (required).</param>
        /// <param name="amount">Amount of loyalty points (required).</param>
        /// <param name="reason">reason for awarding/deducting points (required).</param>
        /// <param name="expiryDate">Expiry date of the points (required).</param>
        /// <param name="referenceId">The ID of the balancing ledgerEntry.</param>
        public LedgerEntry(int? id = default(int?), DateTime? created = default(DateTime?), string profileId = default(string), int? accountId = default(int?), int? loyaltyProgramId = default(int?), int? eventId = default(int?), int? amount = default(int?), string reason = default(string), DateTime? expiryDate = default(DateTime?), int? referenceId = default(int?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for LedgerEntry and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new InvalidDataException("created is a required property for LedgerEntry and cannot be null");
            }
            else
            {
                this.Created = created;
            }
            // to ensure "profileId" is required (not null)
            if (profileId == null)
            {
                throw new InvalidDataException("profileId is a required property for LedgerEntry and cannot be null");
            }
            else
            {
                this.ProfileId = profileId;
            }
            // to ensure "accountId" is required (not null)
            if (accountId == null)
            {
                throw new InvalidDataException("accountId is a required property for LedgerEntry and cannot be null");
            }
            else
            {
                this.AccountId = accountId;
            }
            // to ensure "loyaltyProgramId" is required (not null)
            if (loyaltyProgramId == null)
            {
                throw new InvalidDataException("loyaltyProgramId is a required property for LedgerEntry and cannot be null");
            }
            else
            {
                this.LoyaltyProgramId = loyaltyProgramId;
            }
            // to ensure "eventId" is required (not null)
            if (eventId == null)
            {
                throw new InvalidDataException("eventId is a required property for LedgerEntry and cannot be null");
            }
            else
            {
                this.EventId = eventId;
            }
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for LedgerEntry and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
            // to ensure "reason" is required (not null)
            if (reason == null)
            {
                throw new InvalidDataException("reason is a required property for LedgerEntry and cannot be null");
            }
            else
            {
                this.Reason = reason;
            }
            // to ensure "expiryDate" is required (not null)
            if (expiryDate == null)
            {
                throw new InvalidDataException("expiryDate is a required property for LedgerEntry and cannot be null");
            }
            else
            {
                this.ExpiryDate = expiryDate;
            }
            this.ReferenceId = referenceId;
        }
        
        /// <summary>
        /// Unique ID for this entity.
        /// </summary>
        /// <value>Unique ID for this entity.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The exact moment this entity was created.
        /// </summary>
        /// <value>The exact moment this entity was created.</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// ID of the customers profile as used within this Talon.One account. May be omitted or set to the empty string if the customer does not yet have a known profile ID.
        /// </summary>
        /// <value>ID of the customers profile as used within this Talon.One account. May be omitted or set to the empty string if the customer does not yet have a known profile ID.</value>
        [DataMember(Name="profileId", EmitDefaultValue=false)]
        public string ProfileId { get; set; }

        /// <summary>
        /// The ID of the Talon.One account that owns this profile.
        /// </summary>
        /// <value>The ID of the Talon.One account that owns this profile.</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public int? AccountId { get; set; }

        /// <summary>
        /// ID of the ledger
        /// </summary>
        /// <value>ID of the ledger</value>
        [DataMember(Name="loyaltyProgramId", EmitDefaultValue=false)]
        public int? LoyaltyProgramId { get; set; }

        /// <summary>
        /// ID of the related event
        /// </summary>
        /// <value>ID of the related event</value>
        [DataMember(Name="eventId", EmitDefaultValue=false)]
        public int? EventId { get; set; }

        /// <summary>
        /// Amount of loyalty points
        /// </summary>
        /// <value>Amount of loyalty points</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// reason for awarding/deducting points
        /// </summary>
        /// <value>reason for awarding/deducting points</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Expiry date of the points
        /// </summary>
        /// <value>Expiry date of the points</value>
        [DataMember(Name="expiryDate", EmitDefaultValue=false)]
        public DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// The ID of the balancing ledgerEntry
        /// </summary>
        /// <value>The ID of the balancing ledgerEntry</value>
        [DataMember(Name="referenceId", EmitDefaultValue=false)]
        public int? ReferenceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LedgerEntry {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  LoyaltyProgramId: ").Append(LoyaltyProgramId).Append("\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
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
            return this.Equals(input as LedgerEntry);
        }

        /// <summary>
        /// Returns true if LedgerEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of LedgerEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LedgerEntry input)
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
                    this.ProfileId == input.ProfileId ||
                    (this.ProfileId != null &&
                    this.ProfileId.Equals(input.ProfileId))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.LoyaltyProgramId == input.LoyaltyProgramId ||
                    (this.LoyaltyProgramId != null &&
                    this.LoyaltyProgramId.Equals(input.LoyaltyProgramId))
                ) && 
                (
                    this.EventId == input.EventId ||
                    (this.EventId != null &&
                    this.EventId.Equals(input.EventId))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.ExpiryDate == input.ExpiryDate ||
                    (this.ExpiryDate != null &&
                    this.ExpiryDate.Equals(input.ExpiryDate))
                ) && 
                (
                    this.ReferenceId == input.ReferenceId ||
                    (this.ReferenceId != null &&
                    this.ReferenceId.Equals(input.ReferenceId))
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
                if (this.ProfileId != null)
                    hashCode = hashCode * 59 + this.ProfileId.GetHashCode();
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.LoyaltyProgramId != null)
                    hashCode = hashCode * 59 + this.LoyaltyProgramId.GetHashCode();
                if (this.EventId != null)
                    hashCode = hashCode * 59 + this.EventId.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.ExpiryDate != null)
                    hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
                if (this.ReferenceId != null)
                    hashCode = hashCode * 59 + this.ReferenceId.GetHashCode();
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
