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
 * Do not modify this file. This file is generated from the controltower-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ControlTower.Model
{
    /// <summary>
    /// This is the response object from the ListLandingZones operation.
    /// </summary>
    public partial class ListLandingZonesResponse : AmazonWebServiceResponse
    {
        private List<LandingZoneSummary> _landingZones = new List<LandingZoneSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property LandingZones. 
        /// <para>
        /// The ARN of the landing zone.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1)]
        public List<LandingZoneSummary> LandingZones
        {
            get { return this._landingZones; }
            set { this._landingZones = value; }
        }

        // Check to see if LandingZones property is set
        internal bool IsSetLandingZones()
        {
            return this._landingZones != null && this._landingZones.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Retrieves the next page of results. If the string is empty, the response is the end
        /// of the results.
        /// </para>
        /// </summary>
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