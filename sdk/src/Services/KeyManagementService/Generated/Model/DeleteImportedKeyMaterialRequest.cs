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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteImportedKeyMaterial operation.
    /// Deletes key material that you previously imported. This operation makes the specified
    /// customer master key (CMK) unusable. For more information about importing key material
    /// into AWS KMS, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">Importing
    /// Key Material</a> in the <i>AWS Key Management Service Developer Guide</i>. 
    /// 
    ///  
    /// <para>
    /// When the specified CMK is in the <code>PendingDeletion</code> state, this operation
    /// does not change the CMK's state. Otherwise, it changes the CMK's state to <code>PendingImport</code>.
    /// </para>
    ///  
    /// <para>
    /// After you delete key material, you can use <a>ImportKeyMaterial</a> to reimport the
    /// same key material into the CMK.
    /// </para>
    ///  
    /// <para>
    /// The CMK that you use for this operation must be in a compatible key state. For details,
    /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
    /// state: Effect on your CMK</a> in the <i>AWS Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use</b>: No. You cannot perform this operation on a CMK in a different
    /// AWS account.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DeleteImportedKeyMaterial</a>
    /// (key policy)
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>GetParametersForImport</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ImportKeyMaterial</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteImportedKeyMaterialRequest : AmazonKeyManagementServiceRequest
    {
        private string _keyId;

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// Identifies the CMK from which you are deleting imported key material. The <code>Origin</code>
        /// of the CMK must be <code>EXTERNAL</code>.
        /// </para>
        ///  
        /// <para>
        /// Specify the key ID or key ARN of the CMK.
        /// </para>
        ///  
        /// <para>
        /// For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string KeyId
        {
            get { return this._keyId; }
            set { this._keyId = value; }
        }

        // Check to see if KeyId property is set
        internal bool IsSetKeyId()
        {
            return this._keyId != null;
        }

    }
}