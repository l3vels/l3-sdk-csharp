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
    /// AssetsResponseDto
    /// </summary>
    [DataContract(Name = "AssetsResponseDto")]
    public partial class AssetsResponseDto : IEquatable<AssetsResponseDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetsResponseDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AssetsResponseDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetsResponseDto" /> class.
        /// </summary>
        /// <param name="items">Number of assets to return per page (required).</param>
        /// <param name="total">Number of total items (required).</param>
        /// <param name="limit">Number of items to return per page (required).</param>
        /// <param name="page">Page number (required).</param>
        public AssetsResponseDto(List<Asset> items = default(List<Asset>), decimal total = default(decimal), decimal limit = default(decimal), decimal page = default(decimal))
        {
            // to ensure "items" is required (not null)
            if (items == null)
            {
                throw new ArgumentNullException("items is a required property for AssetsResponseDto and cannot be null");
            }
            this.Items = items;
            this.Total = total;
            this.Limit = limit;
            this.Page = page;
        }

        /// <summary>
        /// Number of assets to return per page
        /// </summary>
        /// <value>Number of assets to return per page</value>
        [DataMember(Name = "items", IsRequired = true, EmitDefaultValue = true)]
        public List<Asset> Items { get; set; }

        /// <summary>
        /// Number of total items
        /// </summary>
        /// <value>Number of total items</value>
        /// <example>10</example>
        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = true)]
        public decimal Total { get; set; }

        /// <summary>
        /// Number of items to return per page
        /// </summary>
        /// <value>Number of items to return per page</value>
        /// <example>10</example>
        [DataMember(Name = "limit", IsRequired = true, EmitDefaultValue = true)]
        public decimal Limit { get; set; }

        /// <summary>
        /// Page number
        /// </summary>
        /// <value>Page number</value>
        /// <example>1</example>
        [DataMember(Name = "page", IsRequired = true, EmitDefaultValue = true)]
        public decimal Page { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AssetsResponseDto {\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
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
            return this.Equals(input as AssetsResponseDto);
        }

        /// <summary>
        /// Returns true if AssetsResponseDto instances are equal
        /// </summary>
        /// <param name="input">Instance of AssetsResponseDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetsResponseDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.Limit == input.Limit ||
                    this.Limit.Equals(input.Limit)
                ) && 
                (
                    this.Page == input.Page ||
                    this.Page.Equals(input.Page)
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
                if (this.Items != null)
                {
                    hashCode = (hashCode * 59) + this.Items.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Total.GetHashCode();
                hashCode = (hashCode * 59) + this.Limit.GetHashCode();
                hashCode = (hashCode * 59) + this.Page.GetHashCode();
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