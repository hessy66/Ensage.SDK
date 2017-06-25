// <copyright file="LeshracLightningStorm.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_leshrac
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.leshrac_lightning_storm)]
    public class LeshracLightningStorm : IAbilityComponent
    {
        [ImportingConstructor]
        public LeshracLightningStorm([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.leshrac_lightning_storm))
        {
        }

        public LeshracLightningStorm(IServiceContext context, IAbilityComponent ability)
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