/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// This is the response object from the ListConfiguredAudienceModels operation.
    /// </summary>
    public partial class ListConfiguredAudienceModelsResponse : AmazonWebServiceResponse
    {
        private List<ConfiguredAudienceModelSummary> _configuredAudienceModels = new List<ConfiguredAudienceModelSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ConfiguredAudienceModels. 
        /// <para>
        /// The configured audience models.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ConfiguredAudienceModelSummary> ConfiguredAudienceModels
        {
            get { return this._configuredAudienceModels; }
            set { this._configuredAudienceModels = value; }
        }

        // Check to see if ConfiguredAudienceModels property is set
        internal bool IsSetConfiguredAudienceModels()
        {
            return this._configuredAudienceModels != null && this._configuredAudienceModels.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token value retrieved from a previous call to access the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10240)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}