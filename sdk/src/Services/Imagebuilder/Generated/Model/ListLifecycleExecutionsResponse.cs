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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// This is the response object from the ListLifecycleExecutions operation.
    /// </summary>
    public partial class ListLifecycleExecutionsResponse : AmazonWebServiceResponse
    {
        private List<LifecycleExecution> _lifecycleExecutions = new List<LifecycleExecution>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property LifecycleExecutions. 
        /// <para>
        /// A list of lifecycle runtime instances for the specified resource.
        /// </para>
        /// </summary>
        public List<LifecycleExecution> LifecycleExecutions
        {
            get { return this._lifecycleExecutions; }
            set { this._lifecycleExecutions = value; }
        }

        // Check to see if LifecycleExecutions property is set
        internal bool IsSetLifecycleExecutions()
        {
            return this._lifecycleExecutions != null && this._lifecycleExecutions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The next token used for paginated responses. When this field isn't empty, there are
        /// additional elements that the service hasn't included in this request. Use this token
        /// with the next request to retrieve additional objects.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
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