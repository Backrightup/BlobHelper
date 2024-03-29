﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks; 

namespace BlobHelper
{
    /// <summary>
    /// Storage type.
    /// </summary>
    public enum StorageType
    {
        /// <summary>
        /// Amazon Simple Storage Service.
        /// </summary>
        [EnumMember(Value = "AwsS3")]
        AwsS3,
        /// <summary>
        /// Microsoft Azure BLOB Storage Service.
        /// </summary>
        [EnumMember(Value = "Azure")]
        Azure,
        /// <summary>
        /// Local filesystem/disk storage.
        /// </summary>
        [EnumMember(Value = "Disk")]
        Disk,
        /// <summary>
        /// Komodo index.
        /// </summary>
        [EnumMember(Value = "Komodo")]
        Komodo,
        /// <summary>
        /// Kvpbase Storage Server.
        /// </summary>
        [EnumMember(Value = "Kvpbase")]
        Kvpbase 
    }
}
