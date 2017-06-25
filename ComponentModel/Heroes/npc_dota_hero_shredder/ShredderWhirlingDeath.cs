// <copyright file="ShredderWhirlingDeath.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_shredder
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.shredder_whirling_death)]
    public class ShredderWhirlingDeath : IAbilityComponent
    {
        [ImportingConstructor]
        public ShredderWhirlingDeath([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.shredder_whirling_death))
        {
        }

        public ShredderWhirlingDeath(IServiceContext context, IAbilityComponent ability)
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