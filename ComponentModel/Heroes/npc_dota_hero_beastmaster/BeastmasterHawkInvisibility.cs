// <copyright file="BeastmasterHawkInvisibility.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_beastmaster
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.beastmaster_hawk_invisibility)]
    public class BeastmasterHawkInvisibility : IAbilityComponent
    {
        [ImportingConstructor]
        public BeastmasterHawkInvisibility([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.beastmaster_hawk_invisibility))
        {
        }

        public BeastmasterHawkInvisibility(IServiceContext context, IAbilityComponent ability)
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