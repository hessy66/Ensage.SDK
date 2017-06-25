// <copyright file="ExportHeroComponentAttribute.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Metadata
{
    using System;
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;

    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class)]
    public class ExportHeroComponentAttribute : ExportAttribute, IHeroComponentMetadata
    {
        public ExportHeroComponentAttribute(HeroId id)
            : base(typeof(IHeroComponent))
        {
            this.Id = id;
        }

        public HeroId Id { get; }
    }
}