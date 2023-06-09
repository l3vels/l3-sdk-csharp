/*
 * L3vels Api
 *
 * L3vels API for Game developers
 *
 * The version of the OpenAPI document: 0.3
 * Contact: support@l3vels.xyz
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = L3vels.Sdk.Client.OpenAPIDateConverter;

namespace L3vels.Sdk.Model
{
    /// <summary>
    /// SetSaleStatusInput
    /// </summary>
    [DataContract(Name = "SetSaleStatusInput")]
    public partial class SetSaleStatusInput : IEquatable<SetSaleStatusInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetSaleStatusInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SetSaleStatusInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SetSaleStatusInput" /> class.
        /// </summary>
        /// <param name="gameId">Game Id (required).</param>
        /// <param name="collectionId">Collection Id (required).</param>
        /// <param name="saleStatus">Sale Status of the contract (required).</param>
        public SetSaleStatusInput(string gameId = default(string), string collectionId = default(string), Object saleStatus = default(Object))
        {
            // to ensure "gameId" is required (not null)
            if (gameId == null)
            {
                throw new ArgumentNullException("gameId is a required property for SetSaleStatusInput and cannot be null");
            }
            this.GameId = gameId;
            // to ensure "collectionId" is required (not null)
            if (collectionId == null)
            {
                throw new ArgumentNullException("collectionId is a required property for SetSaleStatusInput and cannot be null");
            }
            this.CollectionId = collectionId;
            // to ensure "saleStatus" is required (not null)
            if (saleStatus == null)
            {
                throw new ArgumentNullException("saleStatus is a required property for SetSaleStatusInput and cannot be null");
            }
            this.SaleStatus = saleStatus;
        }

        /// <summary>
        /// Game Id
        /// </summary>
        /// <value>Game Id</value>
        /// <example>&quot;a44b646a-ae14-4e05-ae09-b12d5e7269bf&quot;</example>
        [DataMember(Name = "game_id", IsRequired = true, EmitDefaultValue = true)]
        public string GameId { get; set; }

        /// <summary>
        /// Collection Id
        /// </summary>
        /// <value>Collection Id</value>
        /// <example>&quot;a44b646a-ae14-4e05-ae09-b12d5e7269bf&quot;</example>
        [DataMember(Name = "collection_id", IsRequired = true, EmitDefaultValue = true)]
        public string CollectionId { get; set; }

        /// <summary>
        /// Sale Status of the contract
        /// </summary>
        /// <value>Sale Status of the contract</value>
        [DataMember(Name = "sale_status", IsRequired = true, EmitDefaultValue = true)]
        public Object SaleStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SetSaleStatusInput {\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  CollectionId: ").Append(CollectionId).Append("\n");
            sb.Append("  SaleStatus: ").Append(SaleStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetSaleStatusInput);
        }

        /// <summary>
        /// Returns true if SetSaleStatusInput instances are equal
        /// </summary>
        /// <param name="input">Instance of SetSaleStatusInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetSaleStatusInput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GameId == input.GameId ||
                    (this.GameId != null &&
                    this.GameId.Equals(input.GameId))
                ) && 
                (
                    this.CollectionId == input.CollectionId ||
                    (this.CollectionId != null &&
                    this.CollectionId.Equals(input.CollectionId))
                ) && 
                (
                    this.SaleStatus == input.SaleStatus ||
                    (this.SaleStatus != null &&
                    this.SaleStatus.Equals(input.SaleStatus))
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
                if (this.GameId != null)
                {
                    hashCode = (hashCode * 59) + this.GameId.GetHashCode();
                }
                if (this.CollectionId != null)
                {
                    hashCode = (hashCode * 59) + this.CollectionId.GetHashCode();
                }
                if (this.SaleStatus != null)
                {
                    hashCode = (hashCode * 59) + this.SaleStatus.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
