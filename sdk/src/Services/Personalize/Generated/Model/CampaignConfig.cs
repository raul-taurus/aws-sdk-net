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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// The configuration details of a campaign.
    /// </summary>
    public partial class CampaignConfig
    {
        private bool? _enableMetadataWithRecommendations;
        private Dictionary<string, string> _itemExplorationConfig = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property EnableMetadataWithRecommendations. 
        /// <para>
        /// Whether metadata with recommendations is enabled for the campaign. If enabled, you
        /// can specify the columns from your Items dataset in your request for recommendations.
        /// Amazon Personalize returns this data for each item in the recommendation response.
        /// For information about enabling metadata for a campaign, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/campaigns.html#create-campaign-return-metadata">Enabling
        /// metadata in recommendations for a campaign</a>.
        /// </para>
        ///  
        /// <para>
        ///  If you enable metadata in recommendations, you will incur additional costs. For more
        /// information, see <a href="https://aws.amazon.com/personalize/pricing/">Amazon Personalize
        /// pricing</a>. 
        /// </para>
        /// </summary>
        public bool EnableMetadataWithRecommendations
        {
            get { return this._enableMetadataWithRecommendations.GetValueOrDefault(); }
            set { this._enableMetadataWithRecommendations = value; }
        }

        // Check to see if EnableMetadataWithRecommendations property is set
        internal bool IsSetEnableMetadataWithRecommendations()
        {
            return this._enableMetadataWithRecommendations.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ItemExplorationConfig. 
        /// <para>
        /// Specifies the exploration configuration hyperparameters, including <c>explorationWeight</c>
        /// and <c>explorationItemAgeCutOff</c>, you want to use to configure the amount of item
        /// exploration Amazon Personalize uses when recommending items. Provide <c>itemExplorationConfig</c>
        /// data only if your solution uses the <a href="https://docs.aws.amazon.com/personalize/latest/dg/native-recipe-new-item-USER_PERSONALIZATION.html">User-Personalization</a>
        /// recipe.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public Dictionary<string, string> ItemExplorationConfig
        {
            get { return this._itemExplorationConfig; }
            set { this._itemExplorationConfig = value; }
        }

        // Check to see if ItemExplorationConfig property is set
        internal bool IsSetItemExplorationConfig()
        {
            return this._itemExplorationConfig != null && this._itemExplorationConfig.Count > 0; 
        }

    }
}