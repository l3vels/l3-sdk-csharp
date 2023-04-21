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
    /// MintDto
    /// </summary>
    [DataContract(Name = "MintDto")]
    public partial class MintDto : IEquatable<MintDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MintDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MintDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MintDto" /> class.
        /// </summary>
        /// <param name="contractId">Contract ID.</param>
        /// <param name="projectId">Game/project ID. Example: Call of Duty (required).</param>
        /// <param name="collectionId">Collection ID to use. Example: Characters, Weapons, etc. (required).</param>
        /// <param name="playerAddress">Player address to mint token to. You can provide player ID or player address.</param>
        /// <param name="playerId">Player ID to mint to. You can provide player ID or player address.</param>
        /// <param name="asset">asset (required).</param>
        public MintDto(string contractId = default(string), string projectId = default(string), string collectionId = default(string), string playerAddress = default(string), string playerId = default(string), MintDtoAsset asset = default(MintDtoAsset))
        {
            // to ensure "projectId" is required (not null)
            if (projectId == null)
            {
                throw new ArgumentNullException("projectId is a required property for MintDto and cannot be null");
            }
            this.ProjectId = projectId;
            // to ensure "collectionId" is required (not null)
            if (collectionId == null)
            {
                throw new ArgumentNullException("collectionId is a required property for MintDto and cannot be null");
            }
            this.CollectionId = collectionId;
            // to ensure "asset" is required (not null)
            if (asset == null)
            {
                throw new ArgumentNullException("asset is a required property for MintDto and cannot be null");
            }
            this.Asset = asset;
            this.ContractId = contractId;
            this.PlayerAddress = playerAddress;
            this.PlayerId = playerId;
        }

        /// <summary>
        /// Contract ID
        /// </summary>
        /// <value>Contract ID</value>
        /// <example>&quot;a44b646a-ae14-4e05-ae09-b12d5e7269bf&quot;</example>
        [DataMember(Name = "contract_id", EmitDefaultValue = false)]
        public string ContractId { get; set; }

        /// <summary>
        /// Game/project ID. Example: Call of Duty
        /// </summary>
        /// <value>Game/project ID. Example: Call of Duty</value>
        /// <example>&quot;a44b646a-ae14-4e05-ae09-b12d5e7269bf&quot;</example>
        [DataMember(Name = "project_id", IsRequired = true, EmitDefaultValue = true)]
        public string ProjectId { get; set; }

        /// <summary>
        /// Collection ID to use. Example: Characters, Weapons, etc.
        /// </summary>
        /// <value>Collection ID to use. Example: Characters, Weapons, etc.</value>
        /// <example>&quot;a44b646a-ae14-4e05-ae09-b12d5e7269bf&quot;</example>
        [DataMember(Name = "collection_id", IsRequired = true, EmitDefaultValue = true)]
        public string CollectionId { get; set; }

        /// <summary>
        /// Player address to mint token to. You can provide player ID or player address
        /// </summary>
        /// <value>Player address to mint token to. You can provide player ID or player address</value>
        /// <example>&quot;0x0000000000000000000000000000000000000000&quot;</example>
        [DataMember(Name = "player_address", EmitDefaultValue = false)]
        public string PlayerAddress { get; set; }

        /// <summary>
        /// Player ID to mint to. You can provide player ID or player address
        /// </summary>
        /// <value>Player ID to mint to. You can provide player ID or player address</value>
        /// <example>&quot;a44b646a-ae14-4e05-ae09-b12d5e7269bf&quot;</example>
        [DataMember(Name = "player_id", EmitDefaultValue = false)]
        public string PlayerId { get; set; }

        /// <summary>
        /// Gets or Sets Asset
        /// </summary>
        [DataMember(Name = "asset", IsRequired = true, EmitDefaultValue = true)]
        public MintDtoAsset Asset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MintDto {\n");
            sb.Append("  ContractId: ").Append(ContractId).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  CollectionId: ").Append(CollectionId).Append("\n");
            sb.Append("  PlayerAddress: ").Append(PlayerAddress).Append("\n");
            sb.Append("  PlayerId: ").Append(PlayerId).Append("\n");
            sb.Append("  Asset: ").Append(Asset).Append("\n");
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
            return this.Equals(input as MintDto);
        }

        /// <summary>
        /// Returns true if MintDto instances are equal
        /// </summary>
        /// <param name="input">Instance of MintDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MintDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ContractId == input.ContractId ||
                    (this.ContractId != null &&
                    this.ContractId.Equals(input.ContractId))
                ) && 
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
                    this.PlayerAddress == input.PlayerAddress ||
                    (this.PlayerAddress != null &&
                    this.PlayerAddress.Equals(input.PlayerAddress))
                ) && 
                (
                    this.PlayerId == input.PlayerId ||
                    (this.PlayerId != null &&
                    this.PlayerId.Equals(input.PlayerId))
                ) && 
                (
                    this.Asset == input.Asset ||
                    (this.Asset != null &&
                    this.Asset.Equals(input.Asset))
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
                if (this.ContractId != null)
                {
                    hashCode = (hashCode * 59) + this.ContractId.GetHashCode();
                }
                if (this.ProjectId != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectId.GetHashCode();
                }
                if (this.CollectionId != null)
                {
                    hashCode = (hashCode * 59) + this.CollectionId.GetHashCode();
                }
                if (this.PlayerAddress != null)
                {
                    hashCode = (hashCode * 59) + this.PlayerAddress.GetHashCode();
                }
                if (this.PlayerId != null)
                {
                    hashCode = (hashCode * 59) + this.PlayerId.GetHashCode();
                }
                if (this.Asset != null)
                {
                    hashCode = (hashCode * 59) + this.Asset.GetHashCode();
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