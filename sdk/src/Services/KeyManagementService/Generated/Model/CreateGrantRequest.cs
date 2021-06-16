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
    /// Container for the parameters to the CreateGrant operation.
    /// Adds a grant to a customer master key (CMK). 
    /// 
    ///  
    /// <para>
    /// A <i>grant</i> is a policy instrument that allows AWS principals to use AWS KMS customer
    /// master keys (CMKs) in cryptographic operations. It also can allow them to view a CMK
    /// (<a>DescribeKey</a>) and create and manage grants. When authorizing access to a CMK,
    /// grants are considered along with key policies and IAM policies. Grants are often used
    /// for temporary permissions because you can create one, use its permissions, and delete
    /// it without changing your key policies or IAM policies. 
    /// </para>
    ///  
    /// <para>
    /// For detailed information about grants, including grant terminology, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Using
    /// grants</a> in the <i> <i>AWS Key Management Service Developer Guide</i> </i>. For
    /// examples of working with grants in several programming languages, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/programming-grants.html">Programming
    /// grants</a>.
    /// </para>
    ///  
    /// <para>
    /// The <code>CreateGrant</code> operation returns a <code>GrantToken</code> and a <code>GrantId</code>.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// When you create, retire, or revoke a grant, there might be a brief delay, usually
    /// less than five minutes, until the grant is available throughout AWS KMS. This state
    /// is known as <i>eventual consistency</i>. Once the grant has achieved eventual consistency,
    /// the grantee principal can use the permissions in the grant without identifying the
    /// grant. 
    /// </para>
    ///  
    /// <para>
    /// However, to use the permissions in the grant immediately, use the <code>GrantToken</code>
    /// that <code>CreateGrant</code> returns. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/using-grant-token.html">Using
    /// a grant token</a> in the <i> <i>AWS Key Management Service Developer Guide</i> </i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <code>CreateGrant</code> operation also returns a <code>GrantId</code>. You can
    /// use the <code>GrantId</code> and a key identifier to identify the grant in the <a>RetireGrant</a>
    /// and <a>RevokeGrant</a> operations. To find the grant ID, use the <a>ListGrants</a>
    /// or <a>ListRetirableGrants</a> operations.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For information about symmetric and asymmetric CMKs, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
    /// Symmetric and Asymmetric CMKs</a> in the <i>AWS Key Management Service Developer Guide</i>.
    /// For more information about grants, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Grants</a>
    /// in the <i> <i>AWS Key Management Service Developer Guide</i> </i>.
    /// </para>
    ///  
    /// <para>
    /// The CMK that you use for this operation must be in a compatible key state. For details,
    /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
    /// state: Effect on your CMK</a> in the <i>AWS Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use</b>: Yes. To perform this operation on a CMK in a different
    /// AWS account, specify the key ARN in the value of the <code>KeyId</code> parameter.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:CreateGrant</a>
    /// (key policy)
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>ListGrants</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListRetirableGrants</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>RetireGrant</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>RevokeGrant</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateGrantRequest : AmazonKeyManagementServiceRequest
    {
        private GrantConstraints _constraints;
        private string _granteePrincipal;
        private List<string> _grantTokens = new List<string>();
        private string _keyId;
        private string _name;
        private List<string> _operations = new List<string>();
        private string _retiringPrincipal;

        /// <summary>
        /// Gets and sets the property Constraints. 
        /// <para>
        /// Specifies a grant constraint. 
        /// </para>
        ///  
        /// <para>
        /// AWS KMS supports the <code>EncryptionContextEquals</code> and <code>EncryptionContextSubset</code>
        /// grant constraints. Each constraint value can include up to 8 encryption context pairs.
        /// The encryption context value in each constraint cannot exceed 384 characters.
        /// </para>
        ///  
        /// <para>
        /// These grant constraints allow a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#cryptographic-operations">cryptographic
        /// operation</a> only when the encryption context in the request matches (<code>EncryptionContextEquals</code>)
        /// or includes (<code>EncryptionContextSubset</code>) the encryption context specified
        /// in this structure. For more information about encryption context, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context">Encryption
        /// Context</a> in the <i> <i>AWS Key Management Service Developer Guide</i> </i>. For
        /// information about grant constraints, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-grant-overview.html#grant-constraints">Using
        /// grant constraints</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The encryption context grant constraints are supported only on operations that include
        /// an encryption context. You cannot use an encryption context grant constraint for cryptographic
        /// operations with asymmetric CMKs or for management operations, such as <a>DescribeKey</a>
        /// or <a>RetireGrant</a>.
        /// </para>
        /// </summary>
        public GrantConstraints Constraints
        {
            get { return this._constraints; }
            set { this._constraints = value; }
        }

        // Check to see if Constraints property is set
        internal bool IsSetConstraints()
        {
            return this._constraints != null;
        }

        /// <summary>
        /// Gets and sets the property GranteePrincipal. 
        /// <para>
        /// The identity that gets the permissions specified in the grant.
        /// </para>
        ///  
        /// <para>
        /// To specify the principal, use the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of an AWS principal. Valid AWS principals include AWS accounts
        /// (root), IAM users, IAM roles, federated users, and assumed role users. For examples
        /// of the ARN syntax to use for specifying a principal, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#arn-syntax-iam">AWS
        /// Identity and Access Management (IAM)</a> in the Example ARNs section of the <i>AWS
        /// General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string GranteePrincipal
        {
            get { return this._granteePrincipal; }
            set { this._granteePrincipal = value; }
        }

        // Check to see if GranteePrincipal property is set
        internal bool IsSetGranteePrincipal()
        {
            return this._granteePrincipal != null;
        }

        /// <summary>
        /// Gets and sets the property GrantTokens. 
        /// <para>
        /// A list of grant tokens. 
        /// </para>
        ///  
        /// <para>
        /// Use a grant token when your permission to call this operation comes from a new grant
        /// that has not yet achieved <i>eventual consistency</i>. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#grant_token">Grant
        /// token</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> GrantTokens
        {
            get { return this._grantTokens; }
            set { this._grantTokens = value; }
        }

        // Check to see if GrantTokens property is set
        internal bool IsSetGrantTokens()
        {
            return this._grantTokens != null && this._grantTokens.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// Identifies the customer master key (CMK) for the grant. The grant gives principals
        /// permission to use this CMK.
        /// </para>
        ///  
        /// <para>
        /// Specify the key ID or key ARN of the CMK. To specify a CMK in a different AWS account,
        /// you must use the key ARN.
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

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A friendly name for the grant. Use this value to prevent the unintended creation of
        /// duplicate grants when retrying this request.
        /// </para>
        ///  
        /// <para>
        /// When this value is absent, all <code>CreateGrant</code> requests result in a new grant
        /// with a unique <code>GrantId</code> even if all the supplied parameters are identical.
        /// This can result in unintended duplicates when you retry the <code>CreateGrant</code>
        /// request.
        /// </para>
        ///  
        /// <para>
        /// When this value is present, you can retry a <code>CreateGrant</code> request with
        /// identical parameters; if the grant already exists, the original <code>GrantId</code>
        /// is returned without creating a new grant. Note that the returned grant token is unique
        /// with every <code>CreateGrant</code> request, even when a duplicate <code>GrantId</code>
        /// is returned. All grant tokens for the same grant ID can be used interchangeably.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Operations. 
        /// <para>
        /// A list of operations that the grant permits. 
        /// </para>
        ///  
        /// <para>
        /// The operation must be supported on the CMK. For example, you cannot create a grant
        /// for a symmetric CMK that allows the <a>Sign</a> operation, or a grant for an asymmetric
        /// CMK that allows the <a>GenerateDataKey</a> operation. If you try, AWS KMS returns
        /// a <code>ValidationError</code> exception. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html#terms-grant-operations">Grant
        /// operations</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Operations
        {
            get { return this._operations; }
            set { this._operations = value; }
        }

        // Check to see if Operations property is set
        internal bool IsSetOperations()
        {
            return this._operations != null && this._operations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RetiringPrincipal. 
        /// <para>
        /// The principal that is given permission to retire the grant by using <a>RetireGrant</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// To specify the principal, use the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of an AWS principal. Valid AWS principals include AWS accounts
        /// (root), IAM users, federated users, and assumed role users. For examples of the ARN
        /// syntax to use for specifying a principal, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#arn-syntax-iam">AWS
        /// Identity and Access Management (IAM)</a> in the Example ARNs section of the <i>AWS
        /// General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string RetiringPrincipal
        {
            get { return this._retiringPrincipal; }
            set { this._retiringPrincipal = value; }
        }

        // Check to see if RetiringPrincipal property is set
        internal bool IsSetRetiringPrincipal()
        {
            return this._retiringPrincipal != null;
        }

    }
}