// <copyright file="ElderTitanEarthSplitter.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_elder_titan
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.elder_titan_earth_splitter)]
    public class ElderTitanEarthSplitter : IAbilityComponent
    {
        [ImportingConstructor]
        public ElderTitanEarthSplitter([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.elder_titan_earth_splitter))
        {
        }

        public ElderTitanEarthSplitter(IServiceContext context, IAbilityComponent ability)
        {
            this.Context = context;
            this.Ability = ability;
        }

        public IAbilityComponent Ability { get; }

        public IServiceContext Context { get; }

        public Ability Instance
        {
            get
            {
                return this.Ability.Instance;
            }
        }
    }
}