﻿/// <remarks>
/// Copyright (C) 2019 Squizz PTY LTD
/// This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
/// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.
/// You should have received a copy of the GNU General Public License along with this program.  If not, see http://www.gnu.org/licenses/.
/// </remarks>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace EcommerceStandardsDocuments
{
    /// <summary>
    /// Ecommerce standards document that holds a list of address records for customer accounts
    /// </summary>
    /// <example>
    /// An example of the Customer Account Address Ecommerce Standards document in its JSON serialised form
    /// <code>
    /// {
    ///     "version": 1.3,
    ///     "resultStatus": 1,
    ///     "message":"The customer account address data has been successfully obtained.",
    ///     "dataTransferMode": "COMPLETE",
    ///     "totalDataRecords": 3,
    ///     "configs":{"dataFields":"keyAddressID,keyCustomerAccountID,description,orgName,contact,phone,fax,address1,address2,address3,region,country,postcode,freightCode,isPrimary,isDelivery"},
    ///     "dataRecords":
    ///      [
    ///         {
    ///             "keyAddressID":"ADD-001"
    ///         },
    ///         {
    ///             "keyAddressID":"ADD002",
    ///             "keyCustomerAccountID":"10",
    ///             "description":"Billing Address",
    ///             "orgName":"ESD Industries",
    ///             "contact":"John Doe",
    ///             "phone":"+61234567890",
    ///             "fax":"+612345678901",
    ///             "address1":"22",
    ///             "address2":"Bourkie Street",
    ///             "address3":"Melbourne",
    ///             "region":"Victoria",
    ///             "country":"Australia",
    ///             "postcode":"3000",
    ///             "freightCode":"01FRE",
    ///             "isPrimary":"Y",
    ///             "isDelivery":"N"
    ///         },
    ///         {
    ///             "keyAddressID":"ADD003",
    ///             "keyCustomerAccountID":"10",
    ///             "description":"Delivery Address",
    ///             "orgName":"ESD Industries",
    ///             "contact":"John Doe",
    ///             "phone":"+61234567890",
    ///             "fax":"+612345678901",
    ///             "address1":"25",
    ///             "address2":"Bourkie Street",
    ///             "address3":"Melbourne",
    ///             "region":"Victoria",
    ///             "country":"Australia",
    ///             "postcode":"3000",
    ///             "freightCode":"02FRE",
    ///             "isPrimary":"N",
    ///             "isDelivery":"Y"
    ///         }
    ///     ]
    /// }
    /// </code>
    /// </example>
    [DataContract]
    public class ESDocumentCustomerAccountAddress : ESDocument
    {
        /// <summary>List of customer account address records</summary>
        [JsonProperty(Order = -4)]
        [DataMember]
        public ESDRecordCustomerAccountAddress[] dataRecords;

        /// <summary>Constructor</summary>
        /// <param name="resultStatus">status of obtaining the customer account address record data</param>
        /// <param name="message">message to accompany the result status</param>
        /// <param name="customerAccountAddresses">list of customer account address records</param>
        /// <param name="configs">A list of key value pairs that contain additional information about the document.
        /// Ensure that a key "dataFields" exists that contains a comma delimited list of the customer account address record properties that have data set. This advises systems processing the data which properties should be read and have defaults set if not included in each record.</param>
        public ESDocumentCustomerAccountAddress(int resultStatus, string message, ESDRecordCustomerAccountAddress[] customerAccountAddresses, Dictionary<string, string> configs)
        {
            this.resultStatus = resultStatus;
            this.message = message;
            this.dataRecords = customerAccountAddresses;
            this.configs = configs;
            if (customerAccountAddresses != null)
            {
                this.totalDataRecords = customerAccountAddresses.Length;
            }
        }
    }
}
