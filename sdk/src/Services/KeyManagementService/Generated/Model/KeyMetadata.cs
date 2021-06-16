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
    /// Contains metadata about a customer master key (CMK).
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element for the <a>CreateKey</a> and <a>DescribeKey</a>
    /// operations.
    /// </para>
    /// </summary>
    public partial class KeyMetadata
    {
        private string _arn;
        private string _awsAccountId;
        private string _cloudHsmClusterId;
        private DateTime? _creationDate;
        private CustomerMasterKeySpec _customerMasterKeySpec;
        private string _customKeyStoreId;
        private DateTime? _deletionDate;
        private string _description;
        private bool? _enabled;
        private List<string> _encryptionAlgorithms = new List<string>();
        private ExpirationModelType _expirationModel;
        private string _keyId;
        private KeyManagerType _keyManager;
        private KeyState _keyState;
        private KeyUsageType _keyUsage;
        private bool? _multiRegion;
        private MultiRegionConfiguration _multiRegionConfiguration;
        private OriginType _origin;
        private int? _pendingDeletionWindowInDays;
        private List<string> _signingAlgorithms = new List<string>();
        private DateTime? _validTo;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the CMK. For examples, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#arn-syntax-kms">AWS
        /// Key Management Service (AWS KMS)</a> in the Example ARNs section of the <i>AWS General
        /// Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AWSAccountId. 
        /// <para>
        /// The twelve-digit account ID of the AWS account that owns the CMK.
        /// </para>
        /// </summary>
        public string AWSAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AWSAccountId property is set
        internal bool IsSetAWSAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property CloudHsmClusterId. 
        /// <para>
        /// The cluster ID of the AWS CloudHSM cluster that contains the key material for the
        /// CMK. When you create a CMK in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>, AWS KMS creates the key material for the CMK in the associated AWS
        /// CloudHSM cluster. This value is present only when the CMK is created in a custom key
        /// store.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=24)]
        public string CloudHsmClusterId
        {
            get { return this._cloudHsmClusterId; }
            set { this._cloudHsmClusterId = value; }
        }

        // Check to see if CloudHsmClusterId property is set
        internal bool IsSetCloudHsmClusterId()
        {
            return this._cloudHsmClusterId != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time when the CMK was created.
        /// </para>
        /// </summary>
        public DateTime CreationDate
        {
            get { return this._creationDate.GetValueOrDefault(); }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomerMasterKeySpec. 
        /// <para>
        /// Describes the type of key material in the CMK.
        /// </para>
        /// </summary>
        public CustomerMasterKeySpec CustomerMasterKeySpec
        {
            get { return this._customerMasterKeySpec; }
            set { this._customerMasterKeySpec = value; }
        }

        // Check to see if CustomerMasterKeySpec property is set
        internal bool IsSetCustomerMasterKeySpec()
        {
            return this._customerMasterKeySpec != null;
        }

        /// <summary>
        /// Gets and sets the property CustomKeyStoreId. 
        /// <para>
        /// A unique identifier for the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a> that contains the CMK. This value is present only when the CMK is created
        /// in a custom key store.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string CustomKeyStoreId
        {
            get { return this._customKeyStoreId; }
            set { this._customKeyStoreId = value; }
        }

        // Check to see if CustomKeyStoreId property is set
        internal bool IsSetCustomKeyStoreId()
        {
            return this._customKeyStoreId != null;
        }

        /// <summary>
        /// Gets and sets the property DeletionDate. 
        /// <para>
        /// The date and time after which AWS KMS deletes this CMK. This value is present only
        /// when the CMK is scheduled for deletion, that is, when its <code>KeyState</code> is
        /// <code>PendingDeletion</code>.
        /// </para>
        ///  
        /// <para>
        /// When the primary key in a multi-Region key is scheduled for deletion but still has
        /// replica keys, its key state is <code>PendingReplicaDeletion</code> and the length
        /// of its waiting period is displayed in the <code>PendingDeletionWindowInDays</code>
        /// field.
        /// </para>
        /// </summary>
        public DateTime DeletionDate
        {
            get { return this._deletionDate.GetValueOrDefault(); }
            set { this._deletionDate = value; }
        }

        // Check to see if DeletionDate property is set
        internal bool IsSetDeletionDate()
        {
            return this._deletionDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the CMK.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether the CMK is enabled. When <code>KeyState</code> is <code>Enabled</code>
        /// this value is true, otherwise it is false.
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EncryptionAlgorithms. 
        /// <para>
        /// The encryption algorithms that the CMK supports. You cannot use the CMK with other
        /// encryption algorithms within AWS KMS.
        /// </para>
        ///  
        /// <para>
        /// This value is present only when the <code>KeyUsage</code> of the CMK is <code>ENCRYPT_DECRYPT</code>.
        /// </para>
        /// </summary>
        public List<string> EncryptionAlgorithms
        {
            get { return this._encryptionAlgorithms; }
            set { this._encryptionAlgorithms = value; }
        }

        // Check to see if EncryptionAlgorithms property is set
        internal bool IsSetEncryptionAlgorithms()
        {
            return this._encryptionAlgorithms != null && this._encryptionAlgorithms.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ExpirationModel. 
        /// <para>
        /// Specifies whether the CMK's key material expires. This value is present only when
        /// <code>Origin</code> is <code>EXTERNAL</code>, otherwise this value is omitted.
        /// </para>
        /// </summary>
        public ExpirationModelType ExpirationModel
        {
            get { return this._expirationModel; }
            set { this._expirationModel = value; }
        }

        // Check to see if ExpirationModel property is set
        internal bool IsSetExpirationModel()
        {
            return this._expirationModel != null;
        }

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The globally unique identifier for the CMK.
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
        /// Gets and sets the property KeyManager. 
        /// <para>
        /// The manager of the CMK. CMKs in your AWS account are either customer managed or AWS
        /// managed. For more information about the difference, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#master_keys">Customer
        /// Master Keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public KeyManagerType KeyManager
        {
            get { return this._keyManager; }
            set { this._keyManager = value; }
        }

        // Check to see if KeyManager property is set
        internal bool IsSetKeyManager()
        {
            return this._keyManager != null;
        }

        /// <summary>
        /// Gets and sets the property KeyState. 
        /// <para>
        /// The current status of the CMK.
        /// </para>
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your CMK</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public KeyState KeyState
        {
            get { return this._keyState; }
            set { this._keyState = value; }
        }

        // Check to see if KeyState property is set
        internal bool IsSetKeyState()
        {
            return this._keyState != null;
        }

        /// <summary>
        /// Gets and sets the property KeyUsage. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#cryptographic-operations">cryptographic
        /// operations</a> for which you can use the CMK.
        /// </para>
        /// </summary>
        public KeyUsageType KeyUsage
        {
            get { return this._keyUsage; }
            set { this._keyUsage = value; }
        }

        // Check to see if KeyUsage property is set
        internal bool IsSetKeyUsage()
        {
            return this._keyUsage != null;
        }

        /// <summary>
        /// Gets and sets the property MultiRegion. 
        /// <para>
        /// Indicates whether the CMK is a multi-Region (<code>True</code>) or regional (<code>False</code>)
        /// key. This value is <code>True</code> for multi-Region primary and replica CMKs and
        /// <code>False</code> for regional CMKs.
        /// </para>
        ///  
        /// <para>
        /// For more information about multi-Region keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html">Using
        /// multi-Region keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public bool MultiRegion
        {
            get { return this._multiRegion.GetValueOrDefault(); }
            set { this._multiRegion = value; }
        }

        // Check to see if MultiRegion property is set
        internal bool IsSetMultiRegion()
        {
            return this._multiRegion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MultiRegionConfiguration. 
        /// <para>
        /// Lists the primary and replica CMKs in same multi-Region CMK. This field is present
        /// only when the value of the <code>MultiRegion</code> field is <code>True</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information about any listed CMK, use the <a>DescribeKey</a> operation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>MultiRegionKeyType</code> indicates whether the CMK is a <code>PRIMARY</code>
        /// or <code>REPLICA</code> key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PrimaryKey</code> displays the key ARN and Region of the primary key. This
        /// field displays the current CMK if it is the primary key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ReplicaKeys</code> displays the key ARNs and Regions of all replica keys. This
        /// field includes the current CMK if it is a replica key.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MultiRegionConfiguration MultiRegionConfiguration
        {
            get { return this._multiRegionConfiguration; }
            set { this._multiRegionConfiguration = value; }
        }

        // Check to see if MultiRegionConfiguration property is set
        internal bool IsSetMultiRegionConfiguration()
        {
            return this._multiRegionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Origin. 
        /// <para>
        /// The source of the CMK's key material. When this value is <code>AWS_KMS</code>, AWS
        /// KMS created the key material. When this value is <code>EXTERNAL</code>, the key material
        /// was imported from your existing key management infrastructure or the CMK lacks key
        /// material. When this value is <code>AWS_CLOUDHSM</code>, the key material was created
        /// in the AWS CloudHSM cluster associated with a custom key store.
        /// </para>
        /// </summary>
        public OriginType Origin
        {
            get { return this._origin; }
            set { this._origin = value; }
        }

        // Check to see if Origin property is set
        internal bool IsSetOrigin()
        {
            return this._origin != null;
        }

        /// <summary>
        /// Gets and sets the property PendingDeletionWindowInDays. 
        /// <para>
        /// The waiting period before the primary key in a multi-Region key is deleted. This waiting
        /// period begins when the last of its replica keys is deleted. This value is present
        /// only when the <code>KeyState</code> of the CMK is <code>PendingReplicaDeletion</code>.
        /// That indicates that the CMK is the primary key in a multi-Region key, it is scheduled
        /// for deletion, and it still has existing replica keys.
        /// </para>
        ///  
        /// <para>
        /// When a regional CMK or a replica key in a multi-Region key is scheduled for deletion,
        /// its deletion date is displayed in the <code>DeletionDate</code> field. However, when
        /// the primary key in a multi-Region key is scheduled for deletion, its waiting period
        /// doesn't begin until all of its replica keys are deleted. This value displays that
        /// waiting period. When the last replica key in the multi-Region key is deleted, the
        /// <code>KeyState</code> of the scheduled primary key changes from <code>PendingReplicaDeletion</code>
        /// to <code>PendingDeletion</code> and the deletion date appears in the <code>DeletionDate</code>
        /// field.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=365)]
        public int PendingDeletionWindowInDays
        {
            get { return this._pendingDeletionWindowInDays.GetValueOrDefault(); }
            set { this._pendingDeletionWindowInDays = value; }
        }

        // Check to see if PendingDeletionWindowInDays property is set
        internal bool IsSetPendingDeletionWindowInDays()
        {
            return this._pendingDeletionWindowInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SigningAlgorithms. 
        /// <para>
        /// The signing algorithms that the CMK supports. You cannot use the CMK with other signing
        /// algorithms within AWS KMS.
        /// </para>
        ///  
        /// <para>
        /// This field appears only when the <code>KeyUsage</code> of the CMK is <code>SIGN_VERIFY</code>.
        /// </para>
        /// </summary>
        public List<string> SigningAlgorithms
        {
            get { return this._signingAlgorithms; }
            set { this._signingAlgorithms = value; }
        }

        // Check to see if SigningAlgorithms property is set
        internal bool IsSetSigningAlgorithms()
        {
            return this._signingAlgorithms != null && this._signingAlgorithms.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ValidTo. 
        /// <para>
        /// The time at which the imported key material expires. When the key material expires,
        /// AWS KMS deletes the key material and the CMK becomes unusable. This value is present
        /// only for CMKs whose <code>Origin</code> is <code>EXTERNAL</code> and whose <code>ExpirationModel</code>
        /// is <code>KEY_MATERIAL_EXPIRES</code>, otherwise this value is omitted.
        /// </para>
        /// </summary>
        public DateTime ValidTo
        {
            get { return this._validTo.GetValueOrDefault(); }
            set { this._validTo = value; }
        }

        // Check to see if ValidTo property is set
        internal bool IsSetValidTo()
        {
            return this._validTo.HasValue; 
        }

    }
}