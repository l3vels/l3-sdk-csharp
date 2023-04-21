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
    /// SetContractUriDto
    /// </summary>
    [DataContract(Name = "SetContractUriDto")]
    public partial class SetContractUriDto : IEquatable<SetContractUriDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetContractUriDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SetContractUriDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SetContractUriDto" /> class.
        /// </summary>
        /// <param name="projectId">Project Id (required).</param>
        /// <param name="collectionId">Collection Id (required).</param>
        /// <param name="contractUri">Contract URI (required).</param>
        public SetContractUriDto(string projectId = default(string), string collectionId = default(string), string contractUri = default(string))
        {
            // to ensure "projectId" is required (not null)
            if (projectId == null)
            {
                throw new ArgumentNullException("projectId is a required property for SetContractUriDto and cannot be null");
            }
            this.ProjectId = projectId;
            // to ensure "collectionId" is required (not null)
            if (collectionId == null)
            {
                throw new ArgumentNullException("collectionId is a required property for SetContractUriDto and cannot be null");
            }
            this.CollectionId = collectionId;
            // to ensure "contractUri" is required (not null)
            if (contractUri == null)
            {
                throw new ArgumentNullException("contractUri is a required property for SetContractUriDto and cannot be null");
            }
            this.ContractUri = contractUri;
        }

        /// <summary>
        /// Project Id
        /// </summary>
        /// <value>Project Id</value>
        /// <example>&quot;a44b646a-ae14-4e05-ae09-b12d5e7269bf&quot;</example>
        [DataMember(Name = "project_id", IsRequired = true, EmitDefaultValue = true)]
        public string ProjectId { get; set; }

        /// <summary>
        /// Collection Id
        /// </summary>
        /// <value>Collection Id</value>
        /// <example>&quot;a44b646a-ae14-4e05-ae09-b12d5e7269bf&quot;</example>
        [DataMember(Name = "collection_id", IsRequired = true, EmitDefaultValue = true)]
        public string CollectionId { get; set; }

        /// <summary>
        /// Contract URI
        /// </summary>
        /// <value>Contract URI</value>
        /// <example>&quot;https://api.example.com/contract/{contractAddress}&quot;</example>
        [DataMember(Name = "contract_uri", IsRequired = true, EmitDefaultValue = true)]
        public string ContractUri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SetContractUriDto {\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  CollectionId: ").Append(CollectionId).Append("\n");
            sb.Append("  ContractUri: ").Append(ContractUri).Append("\n");
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
            return this.Equals(input as SetContractUriDto);
        }

        /// <summary>
        /// Returns true if SetContractUriDto instances are equal
        /// </summary>
        /// <param name="input">Instance of SetContractUriDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetContractUriDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.CollectionId == input.CollectionId ||
                    (this.CollectionId != null &&
                    this.CollectionId.Equals(input.CollectionId))
                ) && 
                (
                    this.ContractUri == input.ContractUri ||
                    (this.ContractUri != null &&
                    this.ContractUri.Equals(input.ContractUri))
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
                if (this.ProjectId != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectId.GetHashCode();
                }
                if (this.CollectionId != null)
                {
                    hashCode = (hashCode * 59) + this.CollectionId.GetHashCode();
                }
                if (this.ContractUri != null)
                {
                    hashCode = (hashCode * 59) + this.ContractUri.GetHashCode();
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