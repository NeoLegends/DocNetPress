﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocNetPress.Development.Generator.Extensions
{
    /// <summary>
    /// Lists all available type-prefix members ("T")
    /// </summary>
    public enum TypeMembers
    {
        /// <summary>
        /// The member is a class
        /// </summary>
        Class,

        /// <summary>
        /// The member is a struct
        /// </summary>
        Struct,

        /// <summary>
        /// The member is an interface
        /// </summary>
        Interface,

        /// <summary>
        /// The member is an enum
        /// </summary>
        Enum,

        /// <summary>
        /// The member is a delegate
        /// </summary>
        Delegate
    }
}