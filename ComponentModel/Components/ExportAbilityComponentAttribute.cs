// <copyright file="ExportAbilityComponentAttribute.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Components
{
    using System;
    using System.ComponentModel.Composition;

    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class)]
    public class ExportAbilityComponentAttribute : ExportAttribute, IAbilityMetadata
    {
        public ExportAbilityComponentAttribute(AbilityId id)
            : base(typeof(IAbilityComponent))
        {
            this.Id = id;
        }

        public AbilityId Id { get; }
    }
}