// <copyright file="BeastmasterWildAxes.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_beastmaster
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.beastmaster_wild_axes)]
    public class BeastmasterWildAxes : IAbilityComponent
    {
        [ImportingConstructor]
        public BeastmasterWildAxes([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.beastmaster_wild_axes))
        {
        }

        public BeastmasterWildAxes(IServiceContext context, IAbilityComponent ability)
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