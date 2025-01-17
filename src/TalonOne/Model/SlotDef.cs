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
    /// SlotDef
    /// </summary>
    [DataContract]
    public partial class SlotDef :  IEquatable<SlotDef>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SlotDef" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SlotDef() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SlotDef" /> class.
        /// </summary>
        /// <param name="name">The dot-separated path to this slot for use in Talang. (required).</param>
        /// <param name="type">The type of this slot, one of string, number, boolean, or list[type]. (required).</param>
        /// <param name="title">Campaigner-friendly name for the slot. (required).</param>
        /// <param name="description">A short description of the slot..</param>
        /// <param name="help">Extended help text for the slot..</param>
        /// <param name="writable">Whether or not this slot can be updated by rule effects. (required).</param>
        public SlotDef(string name = default(string), string type = default(string), string title = default(string), string description = default(string), string help = default(string), bool? writable = default(bool?))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for SlotDef and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for SlotDef and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for SlotDef and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            // to ensure "writable" is required (not null)
            if (writable == null)
            {
                throw new InvalidDataException("writable is a required property for SlotDef and cannot be null");
            }
            else
            {
                this.Writable = writable;
            }
            this.Description = description;
            this.Help = help;
        }
        
        /// <summary>
        /// The dot-separated path to this slot for use in Talang.
        /// </summary>
        /// <value>The dot-separated path to this slot for use in Talang.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The type of this slot, one of string, number, boolean, or list[type].
        /// </summary>
        /// <value>The type of this slot, one of string, number, boolean, or list[type].</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Campaigner-friendly name for the slot.
        /// </summary>
        /// <value>Campaigner-friendly name for the slot.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// A short description of the slot.
        /// </summary>
        /// <value>A short description of the slot.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Extended help text for the slot.
        /// </summary>
        /// <value>Extended help text for the slot.</value>
        [DataMember(Name="help", EmitDefaultValue=false)]
        public string Help { get; set; }

        /// <summary>
        /// Whether or not this slot can be updated by rule effects.
        /// </summary>
        /// <value>Whether or not this slot can be updated by rule effects.</value>
        [DataMember(Name="writable", EmitDefaultValue=false)]
        public bool? Writable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SlotDef {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Help: ").Append(Help).Append("\n");
            sb.Append("  Writable: ").Append(Writable).Append("\n");
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
            return this.Equals(input as SlotDef);
        }

        /// <summary>
        /// Returns true if SlotDef instances are equal
        /// </summary>
        /// <param name="input">Instance of SlotDef to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SlotDef input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Help == input.Help ||
                    (this.Help != null &&
                    this.Help.Equals(input.Help))
                ) && 
                (
                    this.Writable == input.Writable ||
                    (this.Writable != null &&
                    this.Writable.Equals(input.Writable))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Help != null)
                    hashCode = hashCode * 59 + this.Help.GetHashCode();
                if (this.Writable != null)
                    hashCode = hashCode * 59 + this.Writable.GetHashCode();
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
