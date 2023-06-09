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
    /// PlayerAsset
    /// </summary>
    [DataContract(Name = "PlayerAsset")]
    public partial class PlayerAsset : IEquatable<PlayerAsset>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerAsset" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PlayerAsset() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerAsset" /> class.
        /// </summary>
        /// <param name="id">The unique identifier for the Player asset entity. (required).</param>
        /// <param name="amount">The amount of the specific asset that the player has. (required).</param>
        /// <param name="playerId">The unique identifier of the player that the asset is associated with. (required).</param>
        /// <param name="assetId">The unique identifier of the asset that the asset is associated with. (required).</param>
        /// <param name="collectionId">The unique identifier of the collection that the Player asset is associated with. (required).</param>
        /// <param name="accountId">The unique identifier of the account that the Player belongs to. (required).</param>
        /// <param name="gameId">The unique identifier of the game that the Player is associated with. This allows developers to organize their players by game and helps with tracking and reporting. (required).</param>
        /// <param name="createdOn">The date when the player was created. (required).</param>
        /// <param name="modifiedOn">The date when the player was last modified. (required).</param>
        /// <param name="createdBy">The Id of the user who created the player. (required).</param>
        /// <param name="modifiedBy">The Id of the user who last modified the player. (required).</param>
        public PlayerAsset(string id = default(string), decimal amount = default(decimal), string playerId = default(string), string assetId = default(string), string collectionId = default(string), string accountId = default(string), string gameId = default(string), DateTimeOffset createdOn = default(DateTimeOffset), DateTimeOffset modifiedOn = default(DateTimeOffset), string createdBy = default(string), string modifiedBy = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for PlayerAsset and cannot be null");
            }
            this.Id = id;
            this.Amount = amount;
            // to ensure "playerId" is required (not null)
            if (playerId == null)
            {
                throw new ArgumentNullException("playerId is a required property for PlayerAsset and cannot be null");
            }
            this.PlayerId = playerId;
            // to ensure "assetId" is required (not null)
            if (assetId == null)
            {
                throw new ArgumentNullException("assetId is a required property for PlayerAsset and cannot be null");
            }
            this.AssetId = assetId;
            // to ensure "collectionId" is required (not null)
            if (collectionId == null)
            {
                throw new ArgumentNullException("collectionId is a required property for PlayerAsset and cannot be null");
            }
            this.CollectionId = collectionId;
            // to ensure "accountId" is required (not null)
            if (accountId == null)
            {
                throw new ArgumentNullException("accountId is a required property for PlayerAsset and cannot be null");
            }
            this.AccountId = accountId;
            // to ensure "gameId" is required (not null)
            if (gameId == null)
            {
                throw new ArgumentNullException("gameId is a required property for PlayerAsset and cannot be null");
            }
            this.GameId = gameId;
            this.CreatedOn = createdOn;
            this.ModifiedOn = modifiedOn;
            // to ensure "createdBy" is required (not null)
            if (createdBy == null)
            {
                throw new ArgumentNullException("createdBy is a required property for PlayerAsset and cannot be null");
            }
            this.CreatedBy = createdBy;
            // to ensure "modifiedBy" is required (not null)
            if (modifiedBy == null)
            {
                throw new ArgumentNullException("modifiedBy is a required property for PlayerAsset and cannot be null");
            }
            this.ModifiedBy = modifiedBy;
        }

        /// <summary>
        /// The unique identifier for the Player asset entity.
        /// </summary>
        /// <value>The unique identifier for the Player asset entity.</value>
        /// <example>&quot;&quot;</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The amount of the specific asset that the player has.
        /// </summary>
        /// <value>The amount of the specific asset that the player has.</value>
        /// <example>1</example>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public decimal Amount { get; set; }

        /// <summary>
        /// The unique identifier of the player that the asset is associated with.
        /// </summary>
        /// <value>The unique identifier of the player that the asset is associated with.</value>
        /// <example>&quot;fd1895eb-6301-4107-a248-c3f2ae5bcaad&quot;</example>
        [DataMember(Name = "player_id", IsRequired = true, EmitDefaultValue = true)]
        public string PlayerId { get; set; }

        /// <summary>
        /// The unique identifier of the asset that the asset is associated with.
        /// </summary>
        /// <value>The unique identifier of the asset that the asset is associated with.</value>
        /// <example>&quot;fd1895eb-6301-4107-a248-c3f2ae5bcaad&quot;</example>
        [DataMember(Name = "asset_id", IsRequired = true, EmitDefaultValue = true)]
        public string AssetId { get; set; }

        /// <summary>
        /// The unique identifier of the collection that the Player asset is associated with.
        /// </summary>
        /// <value>The unique identifier of the collection that the Player asset is associated with.</value>
        /// <example>&quot;fd1895eb-6301-4107-a248-c3f2ae5bcaad&quot;</example>
        [DataMember(Name = "collection_id", IsRequired = true, EmitDefaultValue = true)]
        public string CollectionId { get; set; }

        /// <summary>
        /// The unique identifier of the account that the Player belongs to.
        /// </summary>
        /// <value>The unique identifier of the account that the Player belongs to.</value>
        /// <example>&quot;313a56d2-b900-456b-ae11-829c8e5661a7&quot;</example>
        [DataMember(Name = "account_id", IsRequired = true, EmitDefaultValue = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// The unique identifier of the game that the Player is associated with. This allows developers to organize their players by game and helps with tracking and reporting.
        /// </summary>
        /// <value>The unique identifier of the game that the Player is associated with. This allows developers to organize their players by game and helps with tracking and reporting.</value>
        /// <example>&quot;fd1895eb-6301-4107-a248-c3f2ae5bcaad&quot;</example>
        [DataMember(Name = "game_id", IsRequired = true, EmitDefaultValue = true)]
        public string GameId { get; set; }

        /// <summary>
        /// The date when the player was created.
        /// </summary>
        /// <value>The date when the player was created.</value>
        [DataMember(Name = "created_on", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset CreatedOn { get; set; }

        /// <summary>
        /// The date when the player was last modified.
        /// </summary>
        /// <value>The date when the player was last modified.</value>
        [DataMember(Name = "modified_on", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset ModifiedOn { get; set; }

        /// <summary>
        /// The Id of the user who created the player.
        /// </summary>
        /// <value>The Id of the user who created the player.</value>
        /// <example>&quot;f414ea43-7afc-424f-bed4-704bafa52093&quot;</example>
        [DataMember(Name = "created_by", IsRequired = true, EmitDefaultValue = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// The Id of the user who last modified the player.
        /// </summary>
        /// <value>The Id of the user who last modified the player.</value>
        /// <example>&quot;f414ea43-7afc-424f-bed4-704bafa52093&quot;</example>
        [DataMember(Name = "modified_by", IsRequired = true, EmitDefaultValue = true)]
        public string ModifiedBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayerAsset {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  PlayerId: ").Append(PlayerId).Append("\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  CollectionId: ").Append(CollectionId).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  ModifiedOn: ").Append(ModifiedOn).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
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
            return this.Equals(input as PlayerAsset);
        }

        /// <summary>
        /// Returns true if PlayerAsset instances are equal
        /// </summary>
        /// <param name="input">Instance of PlayerAsset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlayerAsset input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.PlayerId == input.PlayerId ||
                    (this.PlayerId != null &&
                    this.PlayerId.Equals(input.PlayerId))
                ) && 
                (
                    this.AssetId == input.AssetId ||
                    (this.AssetId != null &&
                    this.AssetId.Equals(input.AssetId))
                ) && 
                (
                    this.CollectionId == input.CollectionId ||
                    (this.CollectionId != null &&
                    this.CollectionId.Equals(input.CollectionId))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.GameId == input.GameId ||
                    (this.GameId != null &&
                    this.GameId.Equals(input.GameId))
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.ModifiedOn == input.ModifiedOn ||
                    (this.ModifiedOn != null &&
                    this.ModifiedOn.Equals(input.ModifiedOn))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.ModifiedBy == input.ModifiedBy ||
                    (this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(input.ModifiedBy))
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
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                if (this.PlayerId != null)
                {
                    hashCode = (hashCode * 59) + this.PlayerId.GetHashCode();
                }
                if (this.AssetId != null)
                {
                    hashCode = (hashCode * 59) + this.AssetId.GetHashCode();
                }
                if (this.CollectionId != null)
                {
                    hashCode = (hashCode * 59) + this.CollectionId.GetHashCode();
                }
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.GameId != null)
                {
                    hashCode = (hashCode * 59) + this.GameId.GetHashCode();
                }
                if (this.CreatedOn != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedOn.GetHashCode();
                }
                if (this.ModifiedOn != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedOn.GetHashCode();
                }
                if (this.CreatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedBy.GetHashCode();
                }
                if (this.ModifiedBy != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedBy.GetHashCode();
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
