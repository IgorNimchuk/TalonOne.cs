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
    /// MiscUpdateUserLatestFeature
    /// </summary>
    [DataContract]
    public partial class MiscUpdateUserLatestFeature :  IEquatable<MiscUpdateUserLatestFeature>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MiscUpdateUserLatestFeature" /> class.
        /// </summary>
        /// <param name="latestFeature">latestFeature.</param>
        public MiscUpdateUserLatestFeature(string latestFeature = default(string))
        {
            this.LatestFeature = latestFeature;
        }
        
        /// <summary>
        /// Gets or Sets LatestFeature
        /// </summary>
        [DataMember(Name="latestFeature", EmitDefaultValue=false)]
        public string LatestFeature { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MiscUpdateUserLatestFeature {\n");
            sb.Append("  LatestFeature: ").Append(LatestFeature).Append("\n");
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
            return this.Equals(input as MiscUpdateUserLatestFeature);
        }

        /// <summary>
        /// Returns true if MiscUpdateUserLatestFeature instances are equal
        /// </summary>
        /// <param name="input">Instance of MiscUpdateUserLatestFeature to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MiscUpdateUserLatestFeature input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LatestFeature == input.LatestFeature ||
                    (this.LatestFeature != null &&
                    this.LatestFeature.Equals(input.LatestFeature))
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
                if (this.LatestFeature != null)
                    hashCode = hashCode * 59 + this.LatestFeature.GetHashCode();
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
