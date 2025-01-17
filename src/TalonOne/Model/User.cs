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
    /// User
    /// </summary>
    [DataContract]
    public partial class User :  IEquatable<User>, IValidatableObject
    {
        /// <summary>
        /// Current user state.
        /// </summary>
        /// <value>Current user state.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum Invited for value: invited
            /// </summary>
            [EnumMember(Value = "invited")]
            Invited = 1,
            
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 2,
            
            /// <summary>
            /// Enum Deactivated for value: deactivated
            /// </summary>
            [EnumMember(Value = "deactivated")]
            Deactivated = 3
        }

        /// <summary>
        /// Current user state.
        /// </summary>
        /// <value>Current user state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected User() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="id">Unique ID for this entity. (required).</param>
        /// <param name="created">The exact moment this entity was created. (required).</param>
        /// <param name="modified">The exact moment this entity was last modified. (required).</param>
        /// <param name="email">The email address associated with your account. (required).</param>
        /// <param name="accountId">The ID of the account that owns this entity. (required).</param>
        /// <param name="inviteToken">Invite token, empty if the user as already accepted their invite. (required).</param>
        /// <param name="state">Current user state. (required).</param>
        /// <param name="name">Full name (required).</param>
        /// <param name="policy">A blob of ACL JSON (required).</param>
        /// <param name="releaseUpdate">Update the user via email (required).</param>
        /// <param name="latestFeature">Latest feature the user has been notified..</param>
        /// <param name="roles">Contains a list of all roles a user is a memeber of.</param>
        /// <param name="applicationNotificationSubscriptions">applicationNotificationSubscriptions.</param>
        public User(int? id = default(int?), DateTime? created = default(DateTime?), DateTime? modified = default(DateTime?), string email = default(string), int? accountId = default(int?), string inviteToken = default(string), StateEnum state = default(StateEnum), string name = default(string), string policy = default(string), bool? releaseUpdate = default(bool?), string latestFeature = default(string), List<int?> roles = default(List<int?>), Object applicationNotificationSubscriptions = default(Object))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for User and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new InvalidDataException("created is a required property for User and cannot be null");
            }
            else
            {
                this.Created = created;
            }
            // to ensure "modified" is required (not null)
            if (modified == null)
            {
                throw new InvalidDataException("modified is a required property for User and cannot be null");
            }
            else
            {
                this.Modified = modified;
            }
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for User and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            // to ensure "accountId" is required (not null)
            if (accountId == null)
            {
                throw new InvalidDataException("accountId is a required property for User and cannot be null");
            }
            else
            {
                this.AccountId = accountId;
            }
            // to ensure "inviteToken" is required (not null)
            if (inviteToken == null)
            {
                throw new InvalidDataException("inviteToken is a required property for User and cannot be null");
            }
            else
            {
                this.InviteToken = inviteToken;
            }
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new InvalidDataException("state is a required property for User and cannot be null");
            }
            else
            {
                this.State = state;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for User and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "policy" is required (not null)
            if (policy == null)
            {
                throw new InvalidDataException("policy is a required property for User and cannot be null");
            }
            else
            {
                this.Policy = policy;
            }
            // to ensure "releaseUpdate" is required (not null)
            if (releaseUpdate == null)
            {
                throw new InvalidDataException("releaseUpdate is a required property for User and cannot be null");
            }
            else
            {
                this.ReleaseUpdate = releaseUpdate;
            }
            this.LatestFeature = latestFeature;
            this.Roles = roles;
            this.ApplicationNotificationSubscriptions = applicationNotificationSubscriptions;
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
        /// The exact moment this entity was last modified.
        /// </summary>
        /// <value>The exact moment this entity was last modified.</value>
        [DataMember(Name="modified", EmitDefaultValue=false)]
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The email address associated with your account.
        /// </summary>
        /// <value>The email address associated with your account.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// The ID of the account that owns this entity.
        /// </summary>
        /// <value>The ID of the account that owns this entity.</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public int? AccountId { get; set; }

        /// <summary>
        /// Invite token, empty if the user as already accepted their invite.
        /// </summary>
        /// <value>Invite token, empty if the user as already accepted their invite.</value>
        [DataMember(Name="inviteToken", EmitDefaultValue=false)]
        public string InviteToken { get; set; }


        /// <summary>
        /// Full name
        /// </summary>
        /// <value>Full name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// A blob of ACL JSON
        /// </summary>
        /// <value>A blob of ACL JSON</value>
        [DataMember(Name="policy", EmitDefaultValue=false)]
        public string Policy { get; set; }

        /// <summary>
        /// Update the user via email
        /// </summary>
        /// <value>Update the user via email</value>
        [DataMember(Name="releaseUpdate", EmitDefaultValue=false)]
        public bool? ReleaseUpdate { get; set; }

        /// <summary>
        /// Latest feature the user has been notified.
        /// </summary>
        /// <value>Latest feature the user has been notified.</value>
        [DataMember(Name="latestFeature", EmitDefaultValue=false)]
        public string LatestFeature { get; set; }

        /// <summary>
        /// Contains a list of all roles a user is a memeber of
        /// </summary>
        /// <value>Contains a list of all roles a user is a memeber of</value>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public List<int?> Roles { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationNotificationSubscriptions
        /// </summary>
        [DataMember(Name="applicationNotificationSubscriptions", EmitDefaultValue=false)]
        public Object ApplicationNotificationSubscriptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  InviteToken: ").Append(InviteToken).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
            sb.Append("  ReleaseUpdate: ").Append(ReleaseUpdate).Append("\n");
            sb.Append("  LatestFeature: ").Append(LatestFeature).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  ApplicationNotificationSubscriptions: ").Append(ApplicationNotificationSubscriptions).Append("\n");
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
            return this.Equals(input as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="input">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User input)
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
                    this.Modified == input.Modified ||
                    (this.Modified != null &&
                    this.Modified.Equals(input.Modified))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.InviteToken == input.InviteToken ||
                    (this.InviteToken != null &&
                    this.InviteToken.Equals(input.InviteToken))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Policy == input.Policy ||
                    (this.Policy != null &&
                    this.Policy.Equals(input.Policy))
                ) && 
                (
                    this.ReleaseUpdate == input.ReleaseUpdate ||
                    (this.ReleaseUpdate != null &&
                    this.ReleaseUpdate.Equals(input.ReleaseUpdate))
                ) && 
                (
                    this.LatestFeature == input.LatestFeature ||
                    (this.LatestFeature != null &&
                    this.LatestFeature.Equals(input.LatestFeature))
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
                ) && 
                (
                    this.ApplicationNotificationSubscriptions == input.ApplicationNotificationSubscriptions ||
                    (this.ApplicationNotificationSubscriptions != null &&
                    this.ApplicationNotificationSubscriptions.Equals(input.ApplicationNotificationSubscriptions))
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
                if (this.Modified != null)
                    hashCode = hashCode * 59 + this.Modified.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.InviteToken != null)
                    hashCode = hashCode * 59 + this.InviteToken.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Policy != null)
                    hashCode = hashCode * 59 + this.Policy.GetHashCode();
                if (this.ReleaseUpdate != null)
                    hashCode = hashCode * 59 + this.ReleaseUpdate.GetHashCode();
                if (this.LatestFeature != null)
                    hashCode = hashCode * 59 + this.LatestFeature.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                if (this.ApplicationNotificationSubscriptions != null)
                    hashCode = hashCode * 59 + this.ApplicationNotificationSubscriptions.GetHashCode();
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
