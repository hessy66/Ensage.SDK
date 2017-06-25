// <copyright file="DisruptorStaticStorm.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_disruptor
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.disruptor_static_storm)]
    public class DisruptorStaticStorm : IAbilityComponent
    {
        [ImportingConstructor]
        public DisruptorStaticStorm([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.disruptor_static_storm))
        {
        }

        public DisruptorStaticStorm(IServiceContext context, IAbilityComponent ability)
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