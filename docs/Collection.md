# L3vels.Sdk.Model.Collection

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier for the collection entity. | 
**UniqueId** | **string** | The unique identifier that can be provided by game studio. | 
**Name** | **string** | The name of the collection. | 
**Description** | **string** | A brief description of the collection. | 
**LogoImage** | **string** | An image representing the collection&#39;s logo. | 
**Medias** | **List&lt;string&gt;** | Additional images associated with the collection, such as screenshots or promotional images. | 
**MainMedia** | **string** | The main or featured image associated with the game. You can set it from the dashboard as main image. | 
**Url** | **string** | A unique URL for the collection on the L3vels platform. | 
**WebLink** | **string** | A URL link to the collection&#39;s webpage. | 
**Supply** | **decimal** | The supply represents the number of assets that are available within the Collection. | 
**CustomPropertyProps** | **Object** | Custom properties that are unique to the collection and defined by the developer to categorize and filter them. | 
**SocialLinks** | **List&lt;string&gt;** | Additional social links associated with the collection | 
**CustomAssetProps** | **Object** | Custom assets fields associated with the collection. | 
**Categories** | **Object** | The category or categories that the collection belongs to. | 
**Status** | **string** | The current status of the collection. Possible values are: Draft, Active | 
**AccountId** | **string** | The unique identifier of the account that the Collection belongs to. | 
**GameId** | **string** | The unique identifier of the game that the collection is associated with. This allows developers to organize their collections by game and helps with tracking and reporting. | 
**CreatedOn** | **DateTimeOffset** | The date when the collection was created. | 
**ModifiedOn** | **DateTimeOffset** | The date when the collection was last modified. | 
**CreatedBy** | **string** | The Id of the user who created the collection. | 
**ModifiedBy** | **string** | The Id of the user who last modified the collection. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

