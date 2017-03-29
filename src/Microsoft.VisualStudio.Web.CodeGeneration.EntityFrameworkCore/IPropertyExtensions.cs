﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore
{
    internal static class IPropertyExtensions
    {
        internal static IPropertyMetadata ToPropertyMetadata(this IProperty property, Type dbContextType)
        {
            Contract.Assert(property != null);
            Contract.Assert(property.ClrType != null); //Do we need to make sure this is not called on Shadow properties?

            var propertyMetadata = new PropertyMetadata();
            propertyMetadata.PropertyName = property.Name;
            propertyMetadata.TypeName = property.ClrType.FullName;

            propertyMetadata.IsPrimaryKey = property.IsPrimaryKey();
            // The old scaffolding has some logic for this property in an edge case which is
            // not clear if needed any more; see EntityFrameworkColumnProvider.DetermineIsForeignKeyComponent
            propertyMetadata.IsForeignKey = property.IsForeignKey();

            propertyMetadata.IsEnum = property.ClrType.GetTypeInfo().IsEnum;
            propertyMetadata.IsReadOnly = property.IsReadOnlyBeforeSave;

            //TODO: RequiresValueGenerator() is an internal EF Core method.
            // Need to confirm with EF if this is ok to use. 
            propertyMetadata.IsAutoGenerated = ((property.RequiresValueGenerator()
                    || property.IsStoreGeneratedAlways)
                && (property.ValueGenerated != ValueGenerated.Never));

            propertyMetadata.ShortTypeName = TypeUtil.GetShortTypeName(property.ClrType);

            propertyMetadata.Scaffold = true;
            var reflectionProperty = property.DeclaringEntityType.ClrType.GetProperty(property.Name);
            if (reflectionProperty != null)
            {
                var scaffoldAttr = reflectionProperty.GetCustomAttribute(typeof(ScaffoldColumnAttribute)) as ScaffoldColumnAttribute;
                if (scaffoldAttr != null)
                {
                    propertyMetadata.Scaffold = scaffoldAttr.Scaffold;
                }
            }

            propertyMetadata.IsEnumFlags = false;
            if (propertyMetadata.IsEnum)
            {
                var flagsAttr = property.ClrType.GetTypeInfo().GetCustomAttribute(typeof(FlagsAttribute)) as FlagsAttribute;
                propertyMetadata.IsEnumFlags = (flagsAttr != null);
            }

            return propertyMetadata;
        }
    }
}
