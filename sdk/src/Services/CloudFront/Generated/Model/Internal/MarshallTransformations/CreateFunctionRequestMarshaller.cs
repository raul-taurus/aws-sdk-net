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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFront.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateFunction Request Marshaller
    /// </summary>       
    public class CreateFunctionRequestMarshaller : IMarshaller<IRequest, CreateFunctionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateFunctionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateFunctionRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            request.HttpMethod = "POST";
            request.ResourcePath = "/2020-05-31/function";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                xmlWriter.WriteStartElement("CreateFunctionRequest", "http://cloudfront.amazonaws.com/doc/2020-05-31/");    
                if(publicRequest.IsSetFunctionCode())
                    xmlWriter.WriteElementString("FunctionCode", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromMemoryStream(publicRequest.FunctionCode));                    

                
                if (publicRequest.FunctionConfig != null) 
                {
                    xmlWriter.WriteStartElement("FunctionConfig", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                    if(publicRequest.FunctionConfig.IsSetComment())
                        xmlWriter.WriteElementString("Comment", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.FunctionConfig.Comment));                 

                
                    if (publicRequest.FunctionConfig.KeyValueStoreAssociations != null) 
                    {
                        xmlWriter.WriteStartElement("KeyValueStoreAssociations", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                        var publicRequestFunctionConfigKeyValueStoreAssociationsItems = publicRequest.FunctionConfig.KeyValueStoreAssociations.Items;
                        if (publicRequestFunctionConfigKeyValueStoreAssociationsItems != null && publicRequestFunctionConfigKeyValueStoreAssociationsItems.Count > 0) 
                        {                        
                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2020-05-31/");
                            foreach (var publicRequestFunctionConfigKeyValueStoreAssociationsItemsValue in publicRequestFunctionConfigKeyValueStoreAssociationsItems) 
                            {
                
                            if (publicRequestFunctionConfigKeyValueStoreAssociationsItemsValue != null) 
                            {
                                xmlWriter.WriteStartElement("KeyValueStoreAssociation", "http://cloudfront.amazonaws.com/doc/2020-05-31/");            
                                if(publicRequestFunctionConfigKeyValueStoreAssociationsItemsValue.IsSetKeyValueStoreARN())
                                    xmlWriter.WriteElementString("KeyValueStoreARN", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequestFunctionConfigKeyValueStoreAssociationsItemsValue.KeyValueStoreARN));                 

                                xmlWriter.WriteEndElement();
                            }
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.FunctionConfig.KeyValueStoreAssociations.IsSetQuantity())
                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromInt(publicRequest.FunctionConfig.KeyValueStoreAssociations.Quantity));                 

                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.FunctionConfig.IsSetRuntime())
                        xmlWriter.WriteElementString("Runtime", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.FunctionConfig.Runtime));                 

                    xmlWriter.WriteEndElement();
                }
                if(publicRequest.IsSetName())
                    xmlWriter.WriteElementString("Name", "http://cloudfront.amazonaws.com/doc/2020-05-31/", StringUtils.FromString(publicRequest.Name));                    


                xmlWriter.WriteEndElement();
            }
            try 
            {
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers["Content-Type"] = "application/xml";
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-05-31";            
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            return request;
        }
        private static CreateFunctionRequestMarshaller _instance = new CreateFunctionRequestMarshaller();        

        internal static CreateFunctionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateFunctionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}