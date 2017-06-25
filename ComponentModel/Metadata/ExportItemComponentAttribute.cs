// <copyright file="ExportItemComponentAttribute.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Metadata
{
    using System;
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;

    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class)]
    public class ExportItemComponentAttribute : ExportAttribute, IItemComponentMetadata
    {
        public ExportItemComponentAttribute(AbilityId id)
            : base(typeof(IItemComponent))
        {
            this.Id = id;
        }

        public AbilityId Id { get; }
    }
}