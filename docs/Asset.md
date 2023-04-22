# L3vels.Sdk.Model.Asset

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier for the asset entity. | 
**TokenId** | **decimal** | The token id of the asset. | 
**Name** | **string** | The name of the asset. | 
**ParentId** | **string** | ID of the parent asset. | 
**Properties** | **Object** | Custom properties of the asset. | 
**Attributes** | **Object** | Custom attributes of the asset. | 
**Description** | **string** | The description of the asset. | 
**Status** | **string** | The status of the asset. | 
**Price** | **decimal** | The price of the asset. | 
**Supply** | **decimal** | The supply of the asset. | 
**MintedAmount** | **decimal** | The minted amount of the asset. | 
**AssetType** | **string** | The asset type. Can be main or nested. | 
**AssetUrl** | **string** | The asset URL. | 
**Medias** | **List&lt;string&gt;** | Additional images associated with the asset, such as screenshots or promotional images. | 
**MainMedia** | **string** | The main or featured image associated with the asset. You can set it from the Dashboard as main image. | 
**AccountId** | **string** | The unique identifier of the account that the Collection belongs to. | 
**GameId** | **string** | The unique identifier of the game that the asset is associated with. This allows developers to organize their assets by game and helps with tracking and reporting. | 
**CollectionId** | **string** | The unique identifier of the collection that the asset is associated with. This allows developers to organize their collections by game and helps with tracking and reporting. | 
**CreatedOn** | **DateTimeOffset** | The date when the collection was created. | 
**ModifiedOn** | **DateTimeOffset** | The date when the collection was last modified. | 
**CreatedBy** | **string** | The Id of the user who created the collection. | 
**ModifiedBy** | **string** | The Id of the user who last modified the collection. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

