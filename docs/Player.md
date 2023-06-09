# L3vels.Sdk.Model.Player

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier for the Player entity. | 
**UniqueId** | **string** | The unique ID of the Player that can be provided by customers or generated by us. | 
**Name** | **string** | The name of the player | 
**Username** | **string** | Username of the player | 
**Email** | **string** | Email of the player | 
**Avatar** | **string** | Avatar URL of the player | 
**CustomProps** | **Object** | Custom props for player | 
**LastSeen** | **DateTimeOffset** | The date when player was active last time | 
**AccountId** | **string** | The unique identifier of the account that the Player belongs to. | 
**GameId** | **string** | The unique identifier of the game that the Player is associated with. This allows developers to organize their players by game and helps with tracking and reporting. Example: Player Jack is associated with game Fortnite. | 
**CreatedOn** | **DateTimeOffset** | The date when the player was created. | 
**ModifiedOn** | **DateTimeOffset** | The date when the player was last modified. | 
**CreatedBy** | **string** | The Id of the user who created the player. | 
**ModifiedBy** | **string** | The Id of the user who last modified the player. | 
**IsCreateWallet** | **bool** | Boolean value indicating whether the player has wallet or not | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

