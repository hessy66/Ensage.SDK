// <copyright file="ZuusLightningBolt.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_zuus
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.zuus_lightning_bolt)]
    public class ZuusLightningBolt : IAbilityComponent
    {
        [ImportingConstructor]
        public ZuusLightningBolt([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.zuus_lightning_bolt))
        {
        }

        public ZuusLightningBolt(IServiceContext context, IAbilityComponent ability)
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