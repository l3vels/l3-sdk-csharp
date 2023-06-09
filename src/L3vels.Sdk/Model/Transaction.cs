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
    /// Transaction
    /// </summary>
    [DataContract(Name = "Transaction")]
    public partial class Transaction : IEquatable<Transaction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Transaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Transaction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Transaction" /> class.
        /// </summary>
        /// <param name="id">The unique identifier for the transaction entity. (required).</param>
        /// <param name="status">Transaction status in Blockchain. Can be pending, success or fail (required).</param>
        /// <param name="from">Address of the sender of the transaction. (required).</param>
        /// <param name="to">Address of the receiver of the transaction. It can be contract address or player address if it is a transfer transaction. (required).</param>
        /// <param name="contractId">Contract ID the transaction is associated with. (required).</param>
        /// <param name="contractAddress">Contract address where the transaction happened. (required).</param>
        /// <param name="blockchain">Main blockchain identifier: Ethereum, Polygon, etc. (required).</param>
        /// <param name="chainName">Chain name identifier: Ethereum, Goerli, Sepolia, PolygonPoS, etc. (required).</param>
        /// <param name="chainId">Chain ID: 1 for Ethereum, 5 for Goerli, 80001 for Polygon Mumbai, etc. (required).</param>
        /// <param name="environment">Chain environment: Testnet, Mainnet, etc. (required).</param>
        /// <param name="transactionHash">Unique transaction hash in the blockchain. (required).</param>
        /// <param name="blockNumber">Unique block number in the blockchain. (required).</param>
        /// <param name="type">Transaction type: Mint, Transfer, Award, Airdrop, etc. (required).</param>
        /// <param name="method">Function method name that was called in smart contract (required).</param>
        /// <param name="events">List of events that were emitted in the transaction (required).</param>
        /// <param name="gameId">The unique identifier of the game that the transaction is associated with. This allows developers to organize their transactions by game and helps with tracking and reporting. (required).</param>
        /// <param name="collectionId">The unique identifier of the collection that the transaction is associated with. This allows developers to organize their transactions by game and helps with tracking and reporting. (required).</param>
        /// <param name="accountId">The unique identifier of the account that the transaction belongs to. (required).</param>
        /// <param name="createdOn">The date when the collection was created. (required).</param>
        /// <param name="modifiedOn">The date when the collection was last modified. (required).</param>
        /// <param name="createdBy">The Id of the user who created the collection. (required).</param>
        /// <param name="modifiedBy">The Id of the user who last modified the collection. (required).</param>
        public Transaction(string id = default(string), string status = default(string), string from = default(string), string to = default(string), string contractId = default(string), string contractAddress = default(string), string blockchain = default(string), string chainName = default(string), decimal chainId = default(decimal), string environment = default(string), string transactionHash = default(string), decimal blockNumber = default(decimal), string type = default(string), string method = default(string), List<string> events = default(List<string>), string gameId = default(string), string collectionId = default(string), string accountId = default(string), DateTimeOffset createdOn = default(DateTimeOffset), DateTimeOffset modifiedOn = default(DateTimeOffset), string createdBy = default(string), string modifiedBy = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for Transaction and cannot be null");
            }
            this.Id = id;
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for Transaction and cannot be null");
            }
            this.Status = status;
            // to ensure "from" is required (not null)
            if (from == null)
            {
                throw new ArgumentNullException("from is a required property for Transaction and cannot be null");
            }
            this.From = from;
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new ArgumentNullException("to is a required property for Transaction and cannot be null");
            }
            this.To = to;
            // to ensure "contractId" is required (not null)
            if (contractId == null)
            {
                throw new ArgumentNullException("contractId is a required property for Transaction and cannot be null");
            }
            this.ContractId = contractId;
            // to ensure "contractAddress" is required (not null)
            if (contractAddress == null)
            {
                throw new ArgumentNullException("contractAddress is a required property for Transaction and cannot be null");
            }
            this.ContractAddress = contractAddress;
            // to ensure "blockchain" is required (not null)
            if (blockchain == null)
            {
                throw new ArgumentNullException("blockchain is a required property for Transaction and cannot be null");
            }
            this.Blockchain = blockchain;
            // to ensure "chainName" is required (not null)
            if (chainName == null)
            {
                throw new ArgumentNullException("chainName is a required property for Transaction and cannot be null");
            }
            this.ChainName = chainName;
            this.ChainId = chainId;
            // to ensure "environment" is required (not null)
            if (environment == null)
            {
                throw new ArgumentNullException("environment is a required property for Transaction and cannot be null");
            }
            this.Environment = environment;
            // to ensure "transactionHash" is required (not null)
            if (transactionHash == null)
            {
                throw new ArgumentNullException("transactionHash is a required property for Transaction and cannot be null");
            }
            this.TransactionHash = transactionHash;
            this.BlockNumber = blockNumber;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for Transaction and cannot be null");
            }
            this.Type = type;
            // to ensure "method" is required (not null)
            if (method == null)
            {
                throw new ArgumentNullException("method is a required property for Transaction and cannot be null");
            }
            this.Method = method;
            // to ensure "events" is required (not null)
            if (events == null)
            {
                throw new ArgumentNullException("events is a required property for Transaction and cannot be null");
            }
            this.Events = events;
            // to ensure "gameId" is required (not null)
            if (gameId == null)
            {
                throw new ArgumentNullException("gameId is a required property for Transaction and cannot be null");
            }
            this.GameId = gameId;
            // to ensure "collectionId" is required (not null)
            if (collectionId == null)
            {
                throw new ArgumentNullException("collectionId is a required property for Transaction and cannot be null");
            }
            this.CollectionId = collectionId;
            // to ensure "accountId" is required (not null)
            if (accountId == null)
            {
                throw new ArgumentNullException("accountId is a required property for Transaction and cannot be null");
            }
            this.AccountId = accountId;
            this.CreatedOn = createdOn;
            this.ModifiedOn = modifiedOn;
            // to ensure "createdBy" is required (not null)
            if (createdBy == null)
            {
                throw new ArgumentNullException("createdBy is a required property for Transaction and cannot be null");
            }
            this.CreatedBy = createdBy;
            // to ensure "modifiedBy" is required (not null)
            if (modifiedBy == null)
            {
                throw new ArgumentNullException("modifiedBy is a required property for Transaction and cannot be null");
            }
            this.ModifiedBy = modifiedBy;
        }

        /// <summary>
        /// The unique identifier for the transaction entity.
        /// </summary>
        /// <value>The unique identifier for the transaction entity.</value>
        /// <example>&quot;05450af0-4522-4e79-9acc-c1c09aae9152&quot;</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Transaction status in Blockchain. Can be pending, success or fail
        /// </summary>
        /// <value>Transaction status in Blockchain. Can be pending, success or fail</value>
        /// <example>&quot;Success&quot;</example>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Address of the sender of the transaction.
        /// </summary>
        /// <value>Address of the sender of the transaction.</value>
        /// <example>&quot;0xBd876ACF229C18A861d561a2b83B70193E659794&quot;</example>
        [DataMember(Name = "from", IsRequired = true, EmitDefaultValue = true)]
        public string From { get; set; }

        /// <summary>
        /// Address of the receiver of the transaction. It can be contract address or player address if it is a transfer transaction.
        /// </summary>
        /// <value>Address of the receiver of the transaction. It can be contract address or player address if it is a transfer transaction.</value>
        /// <example>&quot;0xd873927250e1353ba4eae9b7de599017f3002913&quot;</example>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = true)]
        public string To { get; set; }

        /// <summary>
        /// Contract ID the transaction is associated with.
        /// </summary>
        /// <value>Contract ID the transaction is associated with.</value>
        /// <example>&quot;05450af0-4522-4e79-9acc-c1c09aae9152&quot;</example>
        [DataMember(Name = "contract_id", IsRequired = true, EmitDefaultValue = true)]
        public string ContractId { get; set; }

        /// <summary>
        /// Contract address where the transaction happened.
        /// </summary>
        /// <value>Contract address where the transaction happened.</value>
        /// <example>&quot;0xd873927250e1353ba4eae9b7de599017f3002913&quot;</example>
        [DataMember(Name = "contract_address", IsRequired = true, EmitDefaultValue = true)]
        public string ContractAddress { get; set; }

        /// <summary>
        /// Main blockchain identifier: Ethereum, Polygon, etc.
        /// </summary>
        /// <value>Main blockchain identifier: Ethereum, Polygon, etc.</value>
        /// <example>&quot;Polygon&quot;</example>
        [DataMember(Name = "blockchain", IsRequired = true, EmitDefaultValue = true)]
        public string Blockchain { get; set; }

        /// <summary>
        /// Chain name identifier: Ethereum, Goerli, Sepolia, PolygonPoS, etc.
        /// </summary>
        /// <value>Chain name identifier: Ethereum, Goerli, Sepolia, PolygonPoS, etc.</value>
        /// <example>&quot;Polygon&quot;</example>
        [DataMember(Name = "chain_name", IsRequired = true, EmitDefaultValue = true)]
        public string ChainName { get; set; }

        /// <summary>
        /// Chain ID: 1 for Ethereum, 5 for Goerli, 80001 for Polygon Mumbai, etc.
        /// </summary>
        /// <value>Chain ID: 1 for Ethereum, 5 for Goerli, 80001 for Polygon Mumbai, etc.</value>
        /// <example>80001</example>
        [DataMember(Name = "chain_id", IsRequired = true, EmitDefaultValue = true)]
        public decimal ChainId { get; set; }

        /// <summary>
        /// Chain environment: Testnet, Mainnet, etc.
        /// </summary>
        /// <value>Chain environment: Testnet, Mainnet, etc.</value>
        /// <example>&quot;Testnet&quot;</example>
        [DataMember(Name = "environment", IsRequired = true, EmitDefaultValue = true)]
        public string Environment { get; set; }

        /// <summary>
        /// Unique transaction hash in the blockchain.
        /// </summary>
        /// <value>Unique transaction hash in the blockchain.</value>
        /// <example>&quot;0xbd4afbce29951be8ac6b4cfe79771c0159d461e51044cebe852ddb4ead7fa166&quot;</example>
        [DataMember(Name = "transaction_hash", IsRequired = true, EmitDefaultValue = true)]
        public string TransactionHash { get; set; }

        /// <summary>
        /// Unique block number in the blockchain.
        /// </summary>
        /// <value>Unique block number in the blockchain.</value>
        /// <example>34609977</example>
        [DataMember(Name = "block_number", IsRequired = true, EmitDefaultValue = true)]
        public decimal BlockNumber { get; set; }

        /// <summary>
        /// Transaction type: Mint, Transfer, Award, Airdrop, etc.
        /// </summary>
        /// <value>Transaction type: Mint, Transfer, Award, Airdrop, etc.</value>
        /// <example>&quot;Mint&quot;</example>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Function method name that was called in smart contract
        /// </summary>
        /// <value>Function method name that was called in smart contract</value>
        /// <example>&quot;award&quot;</example>
        [DataMember(Name = "method", IsRequired = true, EmitDefaultValue = true)]
        public string Method { get; set; }

        /// <summary>
        /// List of events that were emitted in the transaction
        /// </summary>
        /// <value>List of events that were emitted in the transaction</value>
        [DataMember(Name = "events", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Events { get; set; }

        /// <summary>
        /// The unique identifier of the game that the transaction is associated with. This allows developers to organize their transactions by game and helps with tracking and reporting.
        /// </summary>
        /// <value>The unique identifier of the game that the transaction is associated with. This allows developers to organize their transactions by game and helps with tracking and reporting.</value>
        /// <example>&quot;fd1895eb-6301-4107-a248-c3f2ae5bcaad&quot;</example>
        [DataMember(Name = "game_id", IsRequired = true, EmitDefaultValue = true)]
        public string GameId { get; set; }

        /// <summary>
        /// The unique identifier of the collection that the transaction is associated with. This allows developers to organize their transactions by game and helps with tracking and reporting.
        /// </summary>
        /// <value>The unique identifier of the collection that the transaction is associated with. This allows developers to organize their transactions by game and helps with tracking and reporting.</value>
        /// <example>&quot;fd1895eb-6301-4107-a248-c3f2ae5bcaad&quot;</example>
        [DataMember(Name = "collection_id", IsRequired = true, EmitDefaultValue = true)]
        public string CollectionId { get; set; }

        /// <summary>
        /// The unique identifier of the account that the transaction belongs to.
        /// </summary>
        /// <value>The unique identifier of the account that the transaction belongs to.</value>
        /// <example>&quot;313a56d2-b900-456b-ae11-829c8e5661a7&quot;</example>
        [DataMember(Name = "account_id", IsRequired = true, EmitDefaultValue = true)]
        public string AccountId { get; set; }

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
        /// <example>&quot;f414ea43-7afc-424f-bed4-704bafa52093&quot;</example>
        [DataMember(Name = "created_by", IsRequired = true, EmitDefaultValue = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// The Id of the user who last modified the collection.
        /// </summary>
        /// <value>The Id of the user who last modified the collection.</value>
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
            sb.Append("class Transaction {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  ContractId: ").Append(ContractId).Append("\n");
            sb.Append("  ContractAddress: ").Append(ContractAddress).Append("\n");
            sb.Append("  Blockchain: ").Append(Blockchain).Append("\n");
            sb.Append("  ChainName: ").Append(ChainName).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  Environment: ").Append(Environment).Append("\n");
            sb.Append("  TransactionHash: ").Append(TransactionHash).Append("\n");
            sb.Append("  BlockNumber: ").Append(BlockNumber).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  CollectionId: ").Append(CollectionId).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
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
            return this.Equals(input as Transaction);
        }

        /// <summary>
        /// Returns true if Transaction instances are equal
        /// </summary>
        /// <param name="input">Instance of Transaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Transaction input)
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
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.ContractId == input.ContractId ||
                    (this.ContractId != null &&
                    this.ContractId.Equals(input.ContractId))
                ) && 
                (
                    this.ContractAddress == input.ContractAddress ||
                    (this.ContractAddress != null &&
                    this.ContractAddress.Equals(input.ContractAddress))
                ) && 
                (
                    this.Blockchain == input.Blockchain ||
                    (this.Blockchain != null &&
                    this.Blockchain.Equals(input.Blockchain))
                ) && 
                (
                    this.ChainName == input.ChainName ||
                    (this.ChainName != null &&
                    this.ChainName.Equals(input.ChainName))
                ) && 
                (
                    this.ChainId == input.ChainId ||
                    this.ChainId.Equals(input.ChainId)
                ) && 
                (
                    this.Environment == input.Environment ||
                    (this.Environment != null &&
                    this.Environment.Equals(input.Environment))
                ) && 
                (
                    this.TransactionHash == input.TransactionHash ||
                    (this.TransactionHash != null &&
                    this.TransactionHash.Equals(input.TransactionHash))
                ) && 
                (
                    this.BlockNumber == input.BlockNumber ||
                    this.BlockNumber.Equals(input.BlockNumber)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && 
                (
                    this.Events == input.Events ||
                    this.Events != null &&
                    input.Events != null &&
                    this.Events.SequenceEqual(input.Events)
                ) && 
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
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
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
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.From != null)
                {
                    hashCode = (hashCode * 59) + this.From.GetHashCode();
                }
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                if (this.ContractId != null)
                {
                    hashCode = (hashCode * 59) + this.ContractId.GetHashCode();
                }
                if (this.ContractAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ContractAddress.GetHashCode();
                }
                if (this.Blockchain != null)
                {
                    hashCode = (hashCode * 59) + this.Blockchain.GetHashCode();
                }
                if (this.ChainName != null)
                {
                    hashCode = (hashCode * 59) + this.ChainName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ChainId.GetHashCode();
                if (this.Environment != null)
                {
                    hashCode = (hashCode * 59) + this.Environment.GetHashCode();
                }
                if (this.TransactionHash != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionHash.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BlockNumber.GetHashCode();
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Method != null)
                {
                    hashCode = (hashCode * 59) + this.Method.GetHashCode();
                }
                if (this.Events != null)
                {
                    hashCode = (hashCode * 59) + this.Events.GetHashCode();
                }
                if (this.GameId != null)
                {
                    hashCode = (hashCode * 59) + this.GameId.GetHashCode();
                }
                if (this.CollectionId != null)
                {
                    hashCode = (hashCode * 59) + this.CollectionId.GetHashCode();
                }
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
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
