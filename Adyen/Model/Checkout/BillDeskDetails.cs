#region Licence

// 
//                        ######
//                        ######
//  ############    ####( ######  #####. ######  ############   ############
//  #############  #####( ######  #####. ######  #############  #############
//         ######  #####( ######  #####. ######  #####  ######  #####  ######
//  ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  ###### ######  #####( ######  #####. ######  #####          #####  ######
//  #############  #############  #############  #############  #####  ######
//   ############   ############  #############   ############  #####  ######
//                                       ######
//                                #############
//                                ############
// 
//  Adyen Dotnet API Library
// 
//  Copyright (c) 2020 Adyen B.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.

#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// BillDeskDetails
    /// </summary>
    [DataContract]
    public partial class BillDeskDetails : IEquatable<BillDeskDetails>, IValidatableObject
    {
        /// <summary>
        /// **billdesk**
        /// </summary>
        /// <value>**billdesk**</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Online for value: billdesk_online
            /// </summary>
            [EnumMember(Value = "billdesk_online")] Online = 1,

            /// <summary>
            /// Enum Wallet for value: billdesk_wallet
            /// </summary>
            [EnumMember(Value = "billdesk_wallet")] Wallet = 2
        }

        /// <summary>
        /// **billdesk**
        /// </summary>
        /// <value>**billdesk**</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillDeskDetails" /> class.
        /// </summary>
        /// <param name="issuer">The issuer id of the shopper&#x27;s selected bank. (required).</param>
        /// <param name="type">**billdesk** (required).</param>
        public BillDeskDetails(string issuer = default(string), TypeEnum type = default(TypeEnum))
        {
            // to ensure "issuer" is required (not null)
            if (issuer == null)
            {
                throw new InvalidDataException("issuer is a required property for BillDeskDetails and cannot be null");
            }
            else
            {
                this.Issuer = issuer;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for BillDeskDetails and cannot be null");
            }
            else
            {
                this.Type = type;
            }
        }

        /// <summary>
        /// The issuer id of the shopper&#x27;s selected bank.
        /// </summary>
        /// <value>The issuer id of the shopper&#x27;s selected bank.</value>
        [DataMember(Name = "issuer", EmitDefaultValue = false)]
        public string Issuer { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillDeskDetails {\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as BillDeskDetails);
        }

        /// <summary>
        /// Returns true if BillDeskDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of BillDeskDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillDeskDetails input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Issuer == input.Issuer ||
                    this.Issuer != null &&
                    this.Issuer.Equals(input.Issuer)
                ) &&
                (
                    this.Type == input.Type ||
                    this.Type != null &&
                    this.Type.Equals(input.Type)
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
                if (this.Issuer != null)
                    hashCode = hashCode * 59 + this.Issuer.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(
            ValidationContext validationContext)
        {
            yield break;
        }
    }
}