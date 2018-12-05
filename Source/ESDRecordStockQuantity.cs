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

namespace EcommerceStandardsDocuments
{
    /// <summary>Ecommerce Standards Record that holds data for a stock unit quantity of a product, download or labour. This record typically stores stock quantity data that can updated on a frequent basis.</summary>
    [DataContract]
    public class ESDRecordStockQuantity
    {
        /// <summary>Key of the product record that the stock level quantity is set for</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyProductID { get; set; }
        /// <summary>Key of the download record that the stock level quantity is set for</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyDownloadID { get; set; }
        /// <summary>Key of the labour record that the stock level quantity is set for</summary>
        [DataMember(EmitDefaultValue = false)]
        public string keyLabourID { get; set; }
        /// <summary>Unit quantity of stock available to be purchased</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal qtyAvailable { get; set; }
        /// <summary>Unit quantity of stock on hand at its location</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal qtyOnHand { get; set; }
        /// <summary>Unit quantity of stock that has been ordered by a purchaser</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal qtyOrdered { get; set; }
        /// <summary>Unit quantity of stock that is the maximum amount that can be ordered by a purchaser</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal qtyOrderable { get; set; }
        /// <summary>Unit quantity of stock that has been back ordered from a supplier</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal qtyBackordered { get; set; }
        /// <summary>Unit quantity of stock that has been reserved for given purchasers</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal qtyReserved { get; set; }
        /// <summary>Unit quantity of stock that has been placed at an external location (consigned)</summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal qtyConsigned { get; set; }
        /// <summary>Data Record OPeration. Denotes an operation that may need to be performed on the record when it is being processed. 
        /// Set null, or set it to one of the ESD_RECORD_OPERATION constants in the ESDocumentConstants class to allow the record to be inserted, updated, deleted, or ignored.</summary>
        [DataMember(EmitDefaultValue = false)]
        public int drop { get; set; }
        /// <summary>Stores an identifier that is relevant only to the system referencing and storing the record for its own needs.</summary>
        [DataMember(EmitDefaultValue = false)]
        public string internalID { get; set; }
    }
}
