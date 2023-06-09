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
    /// CreatePlayerDto
    /// </summary>
    [DataContract(Name = "CreatePlayerDto")]
    public partial class CreatePlayerDto : IEquatable<CreatePlayerDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePlayerDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreatePlayerDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePlayerDto" /> class.
        /// </summary>
        /// <param name="uniqueId">You can send your generated unique ID for player if it&#39;s handy for game. If field is empty, we will generate unique ID..</param>
        /// <param name="name">The name of the player. (required).</param>
        /// <param name="username">The username of the player..</param>
        /// <param name="email">The email of the player..</param>
        /// <param name="avatar">The image URL of the player avatar..</param>
        /// <param name="projectId">Game/project ID to create the player for. Example: Create player Jack for game Fortnite. (required).</param>
        /// <param name="isCreateWallet">Should create wallet for player or not..</param>
        /// <param name="customProps">Custom props for player..</param>
        public CreatePlayerDto(string uniqueId = default(string), string name = default(string), string username = default(string), string email = default(string), string avatar = default(string), string projectId = default(string), bool isCreateWallet = default(bool), List<string> customProps = default(List<string>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CreatePlayerDto and cannot be null");
            }
            this.Name = name;
            // to ensure "projectId" is required (not null)
            if (projectId == null)
            {
                throw new ArgumentNullException("projectId is a required property for CreatePlayerDto and cannot be null");
            }
            this.ProjectId = projectId;
            this.UniqueId = uniqueId;
            this.Username = username;
            this.Email = email;
            this.Avatar = avatar;
            this.IsCreateWallet = isCreateWallet;
            this.CustomProps = customProps;
        }

        /// <summary>
        /// You can send your generated unique ID for player if it&#39;s handy for game. If field is empty, we will generate unique ID.
        /// </summary>
        /// <value>You can send your generated unique ID for player if it&#39;s handy for game. If field is empty, we will generate unique ID.</value>
        /// <example>&quot;f811b994a31&quot;</example>
        [DataMember(Name = "unique_id", EmitDefaultValue = false)]
        public string UniqueId { get; set; }

        /// <summary>
        /// The name of the player.
        /// </summary>
        /// <value>The name of the player.</value>
        /// <example>&quot;Jack&quot;</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The username of the player.
        /// </summary>
        /// <value>The username of the player.</value>
        /// <example>&quot;jack&quot;</example>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// The email of the player.
        /// </summary>
        /// <value>The email of the player.</value>
        /// <example>&quot;jack@gmail.com&quot;</example>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// The image URL of the player avatar.
        /// </summary>
        /// <value>The image URL of the player avatar.</value>
        /// <example>&quot;https://example.com/avatar.png&quot;</example>
        [DataMember(Name = "avatar", EmitDefaultValue = false)]
        public string Avatar { get; set; }

        /// <summary>
        /// Game/project ID to create the player for. Example: Create player Jack for game Fortnite.
        /// </summary>
        /// <value>Game/project ID to create the player for. Example: Create player Jack for game Fortnite.</value>
        /// <example>&quot;353c69f6-76a6-4baa-b68b-852c1c531953&quot;</example>
        [DataMember(Name = "project_id", IsRequired = true, EmitDefaultValue = true)]
        public string ProjectId { get; set; }

        /// <summary>
        /// Should create wallet for player or not.
        /// </summary>
        /// <value>Should create wallet for player or not.</value>
        /// <example>true</example>
        [DataMember(Name = "is_create_wallet", EmitDefaultValue = true)]
        public bool IsCreateWallet { get; set; }

        /// <summary>
        /// Custom props for player.
        /// </summary>
        /// <value>Custom props for player.</value>
        [DataMember(Name = "custom_props", EmitDefaultValue = false)]
        public List<string> CustomProps { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreatePlayerDto {\n");
            sb.Append("  UniqueId: ").Append(UniqueId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  IsCreateWallet: ").Append(IsCreateWallet).Append("\n");
            sb.Append("  CustomProps: ").Append(CustomProps).Append("\n");
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
            return this.Equals(input as CreatePlayerDto);
        }

        /// <summary>
        /// Returns true if CreatePlayerDto instances are equal
        /// </summary>
        /// <param name="input">Instance of CreatePlayerDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePlayerDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UniqueId == input.UniqueId ||
                    (this.UniqueId != null &&
                    this.UniqueId.Equals(input.UniqueId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Avatar == input.Avatar ||
                    (this.Avatar != null &&
                    this.Avatar.Equals(input.Avatar))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.IsCreateWallet == input.IsCreateWallet ||
                    this.IsCreateWallet.Equals(input.IsCreateWallet)
                ) && 
                (
                    this.CustomProps == input.CustomProps ||
                    this.CustomProps != null &&
                    input.CustomProps != null &&
                    this.CustomProps.SequenceEqual(input.CustomProps)
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
                if (this.UniqueId != null)
                {
                    hashCode = (hashCode * 59) + this.UniqueId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Username != null)
                {
                    hashCode = (hashCode * 59) + this.Username.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.Avatar != null)
                {
                    hashCode = (hashCode * 59) + this.Avatar.GetHashCode();
                }
                if (this.ProjectId != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsCreateWallet.GetHashCode();
                if (this.CustomProps != null)
                {
                    hashCode = (hashCode * 59) + this.CustomProps.GetHashCode();
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
