// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Reflection;

namespace Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore
{
    public class PropertyMetadata : IPropertyMetadata
    {
        internal PropertyMetadata()
        {
        }

        /// <summary>
        /// Use this constructor when the model is being used without datacontext.
        /// It will set the property as:
        ///   Non primary 
        ///   Non foreign key.
        ///   Non autogenerated
        ///   Writable
        ///   Non Enum type
        /// </summary>
        /// <param name="property"></param>
        public PropertyMetadata(PropertyInfo property)
        {
            Contract.Assert(property != null && property.Name != null && property.PropertyType != null);
            PropertyName = property.Name;
            TypeName = property.PropertyType.FullName;

            ShortTypeName = TypeUtil.GetShortTypeName(property.PropertyType);
            Scaffold = true;
            var scaffoldAttr = property.GetCustomAttribute(typeof(ScaffoldColumnAttribute)) as ScaffoldColumnAttribute;
            if (scaffoldAttr != null && !scaffoldAttr.Scaffold)
            {
                Scaffold = false;
            }

            // Since this is not being treated as an EF based model,
            // below values are set as false.
            IsPrimaryKey = false;
            IsForeignKey = false;
            IsEnum = false; 
            IsEnumFlags = false;
            IsReadOnly = false;
            IsAutoGenerated = false;
        }

        public bool IsAutoGenerated { get; set; }

        public bool IsEnum { get; set; }

        public bool IsEnumFlags { get; set; }

        public bool IsForeignKey { get; set; }

        public bool IsPrimaryKey { get; set; }

        public bool IsReadOnly { get; set; }

        public string PropertyName { get; set; }

        public bool Scaffold { get; set; }

        public string ShortTypeName { get; set; }

        public string TypeName { get; set; }
    }
}