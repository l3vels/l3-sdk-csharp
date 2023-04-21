# L3vels.Sdk.Model.Transaction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier for the transaction entity. | 
**Status** | **string** | Transaction status in Blockchain. Can be pending, success or fail | 
**From** | **string** | Address of the sender of the transaction. | 
**To** | **string** | Address of the receiver of the transaction. It can be contract address or player address if it is a transfer transaction. | 
**ContractId** | **string** | Contract ID the transaction is associated with. | 
**ContractAddress** | **string** | Contract address where the transaction happened. | 
**Blockchain** | **string** | Main blockchain identifier: Ethereum, Polygon, etc. | 
**ChainName** | **string** | Chain name identifier: Ethereum, Goerli, Sepolia, PolygonPoS, etc. | 
**ChainId** | **decimal** | Chain ID: 1 for Ethereum, 5 for Goerli, 80001 for Polygon Mumbai, etc. | 
**Environment** | **string** | Chain environment: Testnet, Mainnet, etc. | 
**TransactionHash** | **string** | Unique transaction hash in the blockchain. | 
**BlockNumber** | **decimal** | Unique block number in the blockchain. | 
**Type** | **string** | Transaction type: Mint, Transfer, Award, Airdrop, etc. | 
**Method** | **string** | Function method name that was called in smart contract | 
**Events** | **List&lt;string&gt;** | List of events that were emitted in the transaction | 
**ProjectId** | **string** | The unique identifier of the project that the transaction is associated with. This allows developers to organize their transactions by project and helps with tracking and reporting. | 
**CollectionId** | **string** | The unique identifier of the collection that the transaction is associated with. This allows developers to organize their transactions by project and helps with tracking and reporting. | 
**AccountId** | **decimal** | The unique identifier of the account that the transaction belongs to. | 
**CreatedOn** | **DateTimeOffset** | The date when the collection was created. | 
**ModifiedOn** | **DateTimeOffset** | The date when the collection was last modified. | 
**CreatedBy** | **decimal** | The Id of the user who created the collection. | 
**ModifiedBy** | **decimal** | The Id of the user who last modified the collection. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

