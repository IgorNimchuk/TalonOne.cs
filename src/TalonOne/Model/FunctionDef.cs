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
    /// FunctionDef
    /// </summary>
    [DataContract]
    public partial class FunctionDef :  IEquatable<FunctionDef>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDef" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FunctionDef() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDef" /> class.
        /// </summary>
        /// <param name="name">The function name used in Talang. (required).</param>
        /// <param name="type">The type of this function argument. (required).</param>
        /// <param name="description">A short description of the function..</param>
        /// <param name="help">Extended help text for the function..</param>
        /// <param name="args">An array of argument definitions. (required).</param>
        public FunctionDef(string name = default(string), string type = default(string), string description = default(string), string help = default(string), List<FuncArgDef> args = default(List<FuncArgDef>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for FunctionDef and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for FunctionDef and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "args" is required (not null)
            if (args == null)
            {
                throw new InvalidDataException("args is a required property for FunctionDef and cannot be null");
            }
            else
            {
                this.Args = args;
            }
            this.Description = description;
            this.Help = help;
        }
        
        /// <summary>
        /// The function name used in Talang.
        /// </summary>
        /// <value>The function name used in Talang.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The type of this function argument.
        /// </summary>
        /// <value>The type of this function argument.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// A short description of the function.
        /// </summary>
        /// <value>A short description of the function.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Extended help text for the function.
        /// </summary>
        /// <value>Extended help text for the function.</value>
        [DataMember(Name="help", EmitDefaultValue=false)]
        public string Help { get; set; }

        /// <summary>
        /// An array of argument definitions.
        /// </summary>
        /// <value>An array of argument definitions.</value>
        [DataMember(Name="args", EmitDefaultValue=false)]
        public List<FuncArgDef> Args { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FunctionDef {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Help: ").Append(Help).Append("\n");
            sb.Append("  Args: ").Append(Args).Append("\n");
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
            return this.Equals(input as FunctionDef);
        }

        /// <summary>
        /// Returns true if FunctionDef instances are equal
        /// </summary>
        /// <param name="input">Instance of FunctionDef to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FunctionDef input)
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
                    this.Args == input.Args ||
                    this.Args != null &&
                    this.Args.SequenceEqual(input.Args)
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Help != null)
                    hashCode = hashCode * 59 + this.Help.GetHashCode();
                if (this.Args != null)
                    hashCode = hashCode * 59 + this.Args.GetHashCode();
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
            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            yield break;
        }
    }

}