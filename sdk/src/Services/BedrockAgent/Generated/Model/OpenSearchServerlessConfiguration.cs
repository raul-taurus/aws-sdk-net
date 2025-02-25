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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Contains the configurations to use OpenSearch Serverless to store knowledge base data.
    /// </summary>
    public partial class OpenSearchServerlessConfiguration
    {
        private string _collectionArn;
        private OpenSearchServerlessFieldMapping _fieldMapping;
        private string _vectorIndexName;

        /// <summary>
        /// Gets and sets the property CollectionArn.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string CollectionArn
        {
            get { return this._collectionArn; }
            set { this._collectionArn = value; }
        }

        // Check to see if CollectionArn property is set
        internal bool IsSetCollectionArn()
        {
            return this._collectionArn != null;
        }

        /// <summary>
        /// Gets and sets the property FieldMapping.
        /// </summary>
        [AWSProperty(Required=true)]
        public OpenSearchServerlessFieldMapping FieldMapping
        {
            get { return this._fieldMapping; }
            set { this._fieldMapping = value; }
        }

        // Check to see if FieldMapping property is set
        internal bool IsSetFieldMapping()
        {
            return this._fieldMapping != null;
        }

        /// <summary>
        /// Gets and sets the property VectorIndexName.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string VectorIndexName
        {
            get { return this._vectorIndexName; }
            set { this._vectorIndexName = value; }
        }

        // Check to see if VectorIndexName property is set
        internal bool IsSetVectorIndexName()
        {
            return this._vectorIndexName != null;
        }

    }
}