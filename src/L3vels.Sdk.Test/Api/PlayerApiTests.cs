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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using L3vels.Sdk.Client;
using L3vels.Sdk.Api;
// uncomment below to import models
//using L3vels.Sdk.Model;

namespace L3vels.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing PlayerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PlayerApiTests : IDisposable
    {
        private PlayerApi instance;

        public PlayerApiTests()
        {
            instance = new PlayerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PlayerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PlayerApi
            //Assert.IsType<PlayerApi>(instance);
        }

        /// <summary>
        /// Test PlayerAssetControllerPlayerAssetById
        /// </summary>
        [Fact]
        public void PlayerAssetControllerPlayerAssetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string id = null;
            //string projectId = null;
            //var response = instance.PlayerAssetControllerPlayerAssetById(authorization, id, projectId);
            //Assert.IsType<PlayerAsset>(response);
        }

        /// <summary>
        /// Test PlayerAssetControllerPlayerAssets
        /// </summary>
        [Fact]
        public void PlayerAssetControllerPlayerAssetsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string projectId = null;
            //string assetId = null;
            //string playerId = null;
            //string sort = null;
            //string order = null;
            //decimal? limit = null;
            //decimal? page = null;
            //var response = instance.PlayerAssetControllerPlayerAssets(authorization, projectId, assetId, playerId, sort, order, limit, page);
            //Assert.IsType<List<PlayerAsset>>(response);
        }

        /// <summary>
        /// Test PlayerControllerCreatePlayer
        /// </summary>
        [Fact]
        public void PlayerControllerCreatePlayerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //CreatePlayerDto createPlayerDto = null;
            //var response = instance.PlayerControllerCreatePlayer(authorization, createPlayerDto);
            //Assert.IsType<Player>(response);
        }

        /// <summary>
        /// Test PlayerControllerDeletePlayer
        /// </summary>
        [Fact]
        public void PlayerControllerDeletePlayerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //instance.PlayerControllerDeletePlayer(authorization);
        }

        /// <summary>
        /// Test PlayerControllerGetPlayers
        /// </summary>
        [Fact]
        public void PlayerControllerGetPlayersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string projectId = null;
            //string sort = null;
            //string order = null;
            //string searchText = null;
            //decimal? limit = null;
            //decimal? page = null;
            //var response = instance.PlayerControllerGetPlayers(authorization, projectId, sort, order, searchText, limit, page);
            //Assert.IsType<List<Player>>(response);
        }

        /// <summary>
        /// Test PlayerControllerPlayerById
        /// </summary>
        [Fact]
        public void PlayerControllerPlayerByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string id = null;
            //string projectId = null;
            //var response = instance.PlayerControllerPlayerById(authorization, id, projectId);
            //Assert.IsType<Player>(response);
        }

        /// <summary>
        /// Test PlayerControllerPlayersCountByGameId
        /// </summary>
        [Fact]
        public void PlayerControllerPlayersCountByGameIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string projectId = null;
            //var response = instance.PlayerControllerPlayersCountByGameId(authorization, projectId);
            //Assert.IsType<decimal>(response);
        }

        /// <summary>
        /// Test PlayerControllerUpdatePlayer
        /// </summary>
        [Fact]
        public void PlayerControllerUpdatePlayerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //var response = instance.PlayerControllerUpdatePlayer(authorization);
            //Assert.IsType<Player>(response);
        }
    }
}
