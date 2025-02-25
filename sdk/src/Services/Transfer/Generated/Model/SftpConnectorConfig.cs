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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Contains the details for an SFTP connector object. The connector object is used for
    /// transferring files to and from a partner's SFTP server.
    /// </summary>
    public partial class SftpConnectorConfig
    {
        private List<string> _trustedHostKeys = new List<string>();
        private string _userSecretId;

        /// <summary>
        /// Gets and sets the property TrustedHostKeys. 
        /// <para>
        /// The public portion of the host key, or keys, that are used to identify the external
        /// server to which you are connecting. You can use the <c>ssh-keyscan</c> command against
        /// the SFTP server to retrieve the necessary key.
        /// </para>
        ///  
        /// <para>
        /// The three standard SSH public key format elements are <c>&lt;key type&gt;</c>, <c>&lt;body
        /// base64&gt;</c>, and an optional <c>&lt;comment&gt;</c>, with spaces between each element.
        /// Specify only the <c>&lt;key type&gt;</c> and <c>&lt;body base64&gt;</c>: do not enter
        /// the <c>&lt;comment&gt;</c> portion of the key.
        /// </para>
        ///  
        /// <para>
        /// For the trusted host key, Transfer Family accepts RSA and ECDSA keys.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For RSA keys, the <c>&lt;key type&gt;</c> string is <c>ssh-rsa</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For ECDSA keys, the <c>&lt;key type&gt;</c> string is either <c>ecdsa-sha2-nistp256</c>,
        /// <c>ecdsa-sha2-nistp384</c>, or <c>ecdsa-sha2-nistp521</c>, depending on the size of
        /// the key you generated.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> TrustedHostKeys
        {
            get { return this._trustedHostKeys; }
            set { this._trustedHostKeys = value; }
        }

        // Check to see if TrustedHostKeys property is set
        internal bool IsSetTrustedHostKeys()
        {
            return this._trustedHostKeys != null && this._trustedHostKeys.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserSecretId. 
        /// <para>
        /// The identifier for the secret (in Amazon Web Services Secrets Manager) that contains
        /// the SFTP user's private key, password, or both. The identifier must be the Amazon
        /// Resource Name (ARN) of the secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string UserSecretId
        {
            get { return this._userSecretId; }
            set { this._userSecretId = value; }
        }

        // Check to see if UserSecretId property is set
        internal bool IsSetUserSecretId()
        {
            return this._userSecretId != null;
        }

    }
}