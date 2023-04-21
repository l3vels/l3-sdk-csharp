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
    /// Asset
    /// </summary>
    [DataContract(Name = "Asset")]
    public partial class Asset : IEquatable<Asset>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Asset" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Asset() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Asset" /> class.
        /// </summary>
        /// <param name="id">The unique identifier for the asset entity. (required).</param>
        /// <param name="tokenId">The token id of the asset. (required).</param>
        /// <param name="name">The name of the asset. (required).</param>
        /// <param name="parentId">ID of the parent asset. (required).</param>
        /// <param name="properties">Custom properties of the asset. (required).</param>
        /// <param name="attributes">Custom attributes of the asset. (required).</param>
        /// <param name="description">The description of the asset. (required).</param>
        /// <param name="status">The status of the asset. (required).</param>
        /// <param name="price">The price of the asset. (required).</param>
        /// <param name="supply">The supply of the asset. (required).</param>
        /// <param name="mintedAmount">The minted amount of the asset. (required).</param>
        /// <param name="assetType">The asset type. Can be main or nested. (required).</param>
        /// <param name="assetUrl">The asset URL. (required).</param>
        /// <param name="medias">Additional images associated with the asset, such as screenshots or promotional images. (required).</param>
        /// <param name="mainMedia">The main or featured image associated with the asset. You can set it from the Dashboard as main image. (required).</param>
        /// <param name="accountId">The unique identifier of the account that the Collection belongs to. (required).</param>
        /// <param name="projectId">The unique identifier of the project that the asset is associated with. This allows developers to organize their assets by project and helps with tracking and reporting. (required).</param>
        /// <param name="collectionId">The unique identifier of the collection that the asset is associated with. This allows developers to organize their collections by project and helps with tracking and reporting. (required).</param>
        /// <param name="createdOn">The date when the collection was created. (required).</param>
        /// <param name="modifiedOn">The date when the collection was last modified. (required).</param>
        /// <param name="createdBy">The Id of the user who created the collection. (required).</param>
        /// <param name="modifiedBy">The Id of the user who last modified the collection. (required).</param>
        public Asset(string id = default(string), decimal tokenId = default(decimal), string name = default(string), string parentId = default(string), Object properties = default(Object), Object attributes = default(Object), string description = default(string), string status = default(string), decimal price = default(decimal), decimal supply = default(decimal), decimal mintedAmount = default(decimal), string assetType = default(string), string assetUrl = default(string), List<string> medias = default(List<string>), string mainMedia = default(string), decimal accountId = default(decimal), string projectId = default(string), string collectionId = default(string), DateTimeOffset createdOn = default(DateTimeOffset), DateTimeOffset modifiedOn = default(DateTimeOffset), decimal createdBy = default(decimal), decimal modifiedBy = default(decimal))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for Asset and cannot be null");
            }
            this.Id = id;
            this.TokenId = tokenId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for Asset and cannot be null");
            }
            this.Name = name;
            // to ensure "parentId" is required (not null)
            if (parentId == null)
            {
                throw new ArgumentNullException("parentId is a required property for Asset and cannot be null");
            }
            this.ParentId = parentId;
            // to ensure "properties" is required (not null)
            if (properties == null)
            {
                throw new ArgumentNullException("properties is a required property for Asset and cannot be null");
            }
            this.Properties = properties;
            // to ensure "attributes" is required (not null)
            if (attributes == null)
            {
                throw new ArgumentNullException("attributes is a required property for Asset and cannot be null");
            }
            this.Attributes = attributes;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for Asset and cannot be null");
            }
            this.Description = description;
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for Asset and cannot be null");
            }
            this.Status = status;
            this.Price = price;
            this.Supply = supply;
            this.MintedAmount = mintedAmount;
            // to ensure "assetType" is required (not null)
            if (assetType == null)
            {
                throw new ArgumentNullException("assetType is a required property for Asset and cannot be null");
            }
            this.AssetType = assetType;
            // to ensure "assetUrl" is required (not null)
            if (assetUrl == null)
            {
                throw new ArgumentNullException("assetUrl is a required property for Asset and cannot be null");
            }
            this.AssetUrl = assetUrl;
            // to ensure "medias" is required (not null)
            if (medias == null)
            {
                throw new ArgumentNullException("medias is a required property for Asset and cannot be null");
            }
            this.Medias = medias;
            // to ensure "mainMedia" is required (not null)
            if (mainMedia == null)
            {
                throw new ArgumentNullException("mainMedia is a required property for Asset and cannot be null");
            }
            this.MainMedia = mainMedia;
            this.AccountId = accountId;
            // to ensure "projectId" is required (not null)
            if (projectId == null)
            {
                throw new ArgumentNullException("projectId is a required property for Asset and cannot be null");
            }
            this.ProjectId = projectId;
            // to ensure "collectionId" is required (not null)
            if (collectionId == null)
            {
                throw new ArgumentNullException("collectionId is a required property for Asset and cannot be null");
            }
            this.CollectionId = collectionId;
            this.CreatedOn = createdOn;
            this.ModifiedOn = modifiedOn;
            this.CreatedBy = createdBy;
            this.ModifiedBy = modifiedBy;
        }

        /// <summary>
        /// The unique identifier for the asset entity.
        /// </summary>
        /// <value>The unique identifier for the asset entity.</value>
        /// <example>&quot;05450af0-4522-4e79-9acc-c1c09aae9152&quot;</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The token id of the asset.
        /// </summary>
        /// <value>The token id of the asset.</value>
        /// <example>1</example>
        [DataMember(Name = "token_id", IsRequired = true, EmitDefaultValue = true)]
        public decimal TokenId { get; set; }

        /// <summary>
        /// The name of the asset.
        /// </summary>
        /// <value>The name of the asset.</value>
        /// <example>&quot;AK-47&quot;</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// ID of the parent asset.
        /// </summary>
        /// <value>ID of the parent asset.</value>
        /// <example>&quot;05450af0-4522-4e79-9acc-c1c09aae9152&quot;</example>
        [DataMember(Name = "parent_id", IsRequired = true, EmitDefaultValue = true)]
        public string ParentId { get; set; }

        /// <summary>
        /// Custom properties of the asset.
        /// </summary>
        /// <value>Custom properties of the asset.</value>
        [DataMember(Name = "properties", IsRequired = true, EmitDefaultValue = true)]
        public Object Properties { get; set; }

        /// <summary>
        /// Custom attributes of the asset.
        /// </summary>
        /// <value>Custom attributes of the asset.</value>
        [DataMember(Name = "attributes", IsRequired = true, EmitDefaultValue = true)]
        public Object Attributes { get; set; }

        /// <summary>
        /// The description of the asset.
        /// </summary>
        /// <value>The description of the asset.</value>
        /// <example>&quot;Assault rifle operated by gas pressure. Developed in the Soviet Union.&quot;</example>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The status of the asset.
        /// </summary>
        /// <value>The status of the asset.</value>
        /// <example>&quot;Available&quot;</example>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// The price of the asset.
        /// </summary>
        /// <value>The price of the asset.</value>
        /// <example>10</example>
        [DataMember(Name = "price", IsRequired = true, EmitDefaultValue = true)]
        public decimal Price { get; set; }

        /// <summary>
        /// The supply of the asset.
        /// </summary>
        /// <value>The supply of the asset.</value>
        /// <example>100</example>
        [DataMember(Name = "supply", IsRequired = true, EmitDefaultValue = true)]
        public decimal Supply { get; set; }

        /// <summary>
        /// The minted amount of the asset.
        /// </summary>
        /// <value>The minted amount of the asset.</value>
        /// <example>15</example>
        [DataMember(Name = "minted_amount", IsRequired = true, EmitDefaultValue = true)]
        public decimal MintedAmount { get; set; }

        /// <summary>
        /// The asset type. Can be main or nested.
        /// </summary>
        /// <value>The asset type. Can be main or nested.</value>
        /// <example>&quot;Main&quot;</example>
        [DataMember(Name = "asset_type", IsRequired = true, EmitDefaultValue = true)]
        public string AssetType { get; set; }

        /// <summary>
        /// The asset URL.
        /// </summary>
        /// <value>The asset URL.</value>
        /// <example>&quot;https://example.com/assets/1&quot;</example>
        [DataMember(Name = "asset_url", IsRequired = true, EmitDefaultValue = true)]
        public string AssetUrl { get; set; }

        /// <summary>
        /// Additional images associated with the asset, such as screenshots or promotional images.
        /// </summary>
        /// <value>Additional images associated with the asset, such as screenshots or promotional images.</value>
        [DataMember(Name = "medias", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Medias { get; set; }

        /// <summary>
        /// The main or featured image associated with the asset. You can set it from the Dashboard as main image.
        /// </summary>
        /// <value>The main or featured image associated with the asset. You can set it from the Dashboard as main image.</value>
        /// <example>&quot;&quot;</example>
        [DataMember(Name = "main_media", IsRequired = true, EmitDefaultValue = true)]
        public string MainMedia { get; set; }

        /// <summary>
        /// The unique identifier of the account that the Collection belongs to.
        /// </summary>
        /// <value>The unique identifier of the account that the Collection belongs to.</value>
        [DataMember(Name = "account_id", IsRequired = true, EmitDefaultValue = true)]
        public decimal AccountId { get; set; }

        /// <summary>
        /// The unique identifier of the project that the asset is associated with. This allows developers to organize their assets by project and helps with tracking and reporting.
        /// </summary>
        /// <value>The unique identifier of the project that the asset is associated with. This allows developers to organize their assets by project and helps with tracking and reporting.</value>
        /// <example>&quot;fd1895eb-6301-4107-a248-c3f2ae5bcaad&quot;</example>
        [DataMember(Name = "project_id", IsRequired = true, EmitDefaultValue = true)]
        public string ProjectId { get; set; }

        /// <summary>
        /// The unique identifier of the collection that the asset is associated with. This allows developers to organize their collections by project and helps with tracking and reporting.
        /// </summary>
        /// <value>The unique identifier of the collection that the asset is associated with. This allows developers to organize their collections by project and helps with tracking and reporting.</value>
        /// <example>&quot;fd1895eb-6301-4107-a248-c3f2ae5bcaad&quot;</example>
        [DataMember(Name = "collection_id", IsRequired = true, EmitDefaultValue = true)]
        public string CollectionId { get; set; }

        /// <summary>
        /// The date when the collection was created.
        /// </summary>
        /// <value>The date when the collection was created.</value>
        [DataMember(Name = "created_on", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset CreatedOn { get; set; }

        /// <summary>
        /// The date when the collection was last modified.
        /// </summary>
        /// <value>The date when the collection was last modified.</value>
        [DataMember(Name = "modified_on", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset ModifiedOn { get; set; }

        /// <summary>
        /// The Id of the user who created the collection.
        /// </summary>
        /// <value>The Id of the user who created the collection.</value>
        [DataMember(Name = "created_by", IsRequired = true, EmitDefaultValue = true)]
        public decimal CreatedBy { get; set; }

        /// <summary>
        /// The Id of the user who last modified the collection.
        /// </summary>
        /// <value>The Id of the user who last modified the collection.</value>
        [DataMember(Name = "modified_by", IsRequired = true, EmitDefaultValue = true)]
        public decimal ModifiedBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Asset {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Supply: ").Append(Supply).Append("\n");
            sb.Append("  MintedAmount: ").Append(MintedAmount).Append("\n");
            sb.Append("  AssetType: ").Append(AssetType).Append("\n");
            sb.Append("  AssetUrl: ").Append(AssetUrl).Append("\n");
            sb.Append("  Medias: ").Append(Medias).Append("\n");
            sb.Append("  MainMedia: ").Append(MainMedia).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  CollectionId: ").Append(CollectionId).Append("\n");
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
            return this.Equals(input as Asset);
        }

        /// <summary>
        /// Returns true if Asset instances are equal
        /// </summary>
        /// <param name="input">Instance of Asset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Asset input)
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
                    this.TokenId == input.TokenId ||
                    this.TokenId.Equals(input.TokenId)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.Properties == input.Properties ||
                    (this.Properties != null &&
                    this.Properties.Equals(input.Properties))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Price == input.Price ||
                    this.Price.Equals(input.Price)
                ) && 
                (
                    this.Supply == input.Supply ||
                    this.Supply.Equals(input.Supply)
                ) && 
                (
                    this.MintedAmount == input.MintedAmount ||
                    this.MintedAmount.Equals(input.MintedAmount)
                ) && 
                (
                    this.AssetType == input.AssetType ||
                    (this.AssetType != null &&
                    this.AssetType.Equals(input.AssetType))
                ) && 
                (
                    this.AssetUrl == input.AssetUrl ||
                    (this.AssetUrl != null &&
                    this.AssetUrl.Equals(input.AssetUrl))
                ) && 
                (
                    this.Medias == input.Medias ||
                    this.Medias != null &&
                    input.Medias != null &&
                    this.Medias.SequenceEqual(input.Medias)
                ) && 
                (
                    this.MainMedia == input.MainMedia ||
                    (this.MainMedia != null &&
                    this.MainMedia.Equals(input.MainMedia))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    this.AccountId.Equals(input.AccountId)
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
                    this.CreatedBy.Equals(input.CreatedBy)
                ) && 
                (
                    this.ModifiedBy == input.ModifiedBy ||
                    this.ModifiedBy.Equals(input.ModifiedBy)
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
                hashCode = (hashCode * 59) + this.TokenId.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.ParentId != null)
                {
                    hashCode = (hashCode * 59) + this.ParentId.GetHashCode();
                }
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
                }
                if (this.Attributes != null)
                {
                    hashCode = (hashCode * 59) + this.Attributes.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Price.GetHashCode();
                hashCode = (hashCode * 59) + this.Supply.GetHashCode();
                hashCode = (hashCode * 59) + this.MintedAmount.GetHashCode();
                if (this.AssetType != null)
                {
                    hashCode = (hashCode * 59) + this.AssetType.GetHashCode();
                }
                if (this.AssetUrl != null)
                {
                    hashCode = (hashCode * 59) + this.AssetUrl.GetHashCode();
                }
                if (this.Medias != null)
                {
                    hashCode = (hashCode * 59) + this.Medias.GetHashCode();
                }
                if (this.MainMedia != null)
                {
                    hashCode = (hashCode * 59) + this.MainMedia.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                if (this.ProjectId != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectId.GetHashCode();
                }
                if (this.CollectionId != null)
                {
                    hashCode = (hashCode * 59) + this.CollectionId.GetHashCode();
                }
                if (this.CreatedOn != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedOn.GetHashCode();
                }
                if (this.ModifiedOn != null)
                {
                    hashCode = (hashCode * 59) + this.ModifiedOn.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CreatedBy.GetHashCode();
                hashCode = (hashCode * 59) + this.ModifiedBy.GetHashCode();
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
