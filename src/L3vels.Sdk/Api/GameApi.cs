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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace L3vels.Sdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGameApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieve Game
        /// </summary>
        /// <remarks>
        /// Get game/project by ID created on the platform.
        /// </remarks>
        /// <exception cref="L3vels.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">API key is associated with multiple projects. Please include it in to use developers API.</param>
        /// <param name="id">Game or Project Id</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Project</returns>
        Project GetGameById(string authorization, string id, int operationIndex = 0);

        /// <summary>
        /// Retrieve Game
        /// </summary>
        /// <remarks>
        /// Get game/project by ID created on the platform.
        /// </remarks>
        /// <exception cref="L3vels.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">API key is associated with multiple projects. Please include it in to use developers API.</param>
        /// <param name="id">Game or Project Id</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Project</returns>
        ApiResponse<Project> GetGameByIdWithHttpInfo(string authorization, string id, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGameApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Retrieve Game
        /// </summary>
        /// <remarks>
        /// Get game/project by ID created on the platform.
        /// </remarks>
        /// <exception cref="L3vels.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">API key is associated with multiple projects. Please include it in to use developers API.</param>
        /// <param name="id">Game or Project Id</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Project</returns>
        System.Threading.Tasks.Task<Project> GetGameByIdAsync(string authorization, string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieve Game
        /// </summary>
        /// <remarks>
        /// Get game/project by ID created on the platform.
        /// </remarks>
        /// <exception cref="L3vels.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">API key is associated with multiple projects. Please include it in to use developers API.</param>
        /// <param name="id">Game or Project Id</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Project)</returns>
        System.Threading.Tasks.Task<ApiResponse<Project>> GetGameByIdWithHttpInfoAsync(string authorization, string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGameApi : IGameApiSync, IGameApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class GameApi : IGameApi
    {
        private L3vels.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="GameApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GameApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GameApi(string basePath)
        {
            this.Configuration = L3vels.Sdk.Client.Configuration.MergeConfigurations(
                L3vels.Sdk.Client.GlobalConfiguration.Instance,
                new L3vels.Sdk.Client.Configuration { BasePath = basePath }
            );
            this.Client = new L3vels.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new L3vels.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = L3vels.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GameApi(L3vels.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = L3vels.Sdk.Client.Configuration.MergeConfigurations(
                L3vels.Sdk.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new L3vels.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new L3vels.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = L3vels.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public GameApi(L3vels.Sdk.Client.ISynchronousClient client, L3vels.Sdk.Client.IAsynchronousClient asyncClient, L3vels.Sdk.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = L3vels.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public L3vels.Sdk.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public L3vels.Sdk.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public L3vels.Sdk.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public L3vels.Sdk.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Retrieve Game Get game/project by ID created on the platform.
        /// </summary>
        /// <exception cref="L3vels.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">API key is associated with multiple projects. Please include it in to use developers API.</param>
        /// <param name="id">Game or Project Id</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Project</returns>
        public Project GetGameById(string authorization, string id, int operationIndex = 0)
        {
            L3vels.Sdk.Client.ApiResponse<Project> localVarResponse = GetGameByIdWithHttpInfo(authorization, id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve Game Get game/project by ID created on the platform.
        /// </summary>
        /// <exception cref="L3vels.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">API key is associated with multiple projects. Please include it in to use developers API.</param>
        /// <param name="id">Game or Project Id</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Project</returns>
        public L3vels.Sdk.Client.ApiResponse<Project> GetGameByIdWithHttpInfo(string authorization, string id, int operationIndex = 0)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null)
            {
                throw new L3vels.Sdk.Client.ApiException(400, "Missing required parameter 'authorization' when calling GameApi->GetGameById");
            }

            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new L3vels.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling GameApi->GetGameById");
            }

            L3vels.Sdk.Client.RequestOptions localVarRequestOptions = new L3vels.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = L3vels.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = L3vels.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", L3vels.Sdk.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("Authorization", L3vels.Sdk.Client.ClientUtils.ParameterToString(authorization)); // header parameter

            localVarRequestOptions.Operation = "GameApi.GetGameById";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<Project>("/v1/game/{id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetGameById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve Game Get game/project by ID created on the platform.
        /// </summary>
        /// <exception cref="L3vels.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">API key is associated with multiple projects. Please include it in to use developers API.</param>
        /// <param name="id">Game or Project Id</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Project</returns>
        public async System.Threading.Tasks.Task<Project> GetGameByIdAsync(string authorization, string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            L3vels.Sdk.Client.ApiResponse<Project> localVarResponse = await GetGameByIdWithHttpInfoAsync(authorization, id, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve Game Get game/project by ID created on the platform.
        /// </summary>
        /// <exception cref="L3vels.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">API key is associated with multiple projects. Please include it in to use developers API.</param>
        /// <param name="id">Game or Project Id</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Project)</returns>
        public async System.Threading.Tasks.Task<L3vels.Sdk.Client.ApiResponse<Project>> GetGameByIdWithHttpInfoAsync(string authorization, string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null)
            {
                throw new L3vels.Sdk.Client.ApiException(400, "Missing required parameter 'authorization' when calling GameApi->GetGameById");
            }

            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new L3vels.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling GameApi->GetGameById");
            }


            L3vels.Sdk.Client.RequestOptions localVarRequestOptions = new L3vels.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = L3vels.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = L3vels.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", L3vels.Sdk.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("Authorization", L3vels.Sdk.Client.ClientUtils.ParameterToString(authorization)); // header parameter

            localVarRequestOptions.Operation = "GameApi.GetGameById";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<Project>("/v1/game/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetGameById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
