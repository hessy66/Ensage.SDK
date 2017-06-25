// <copyright file="DisruptorGlimpse.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_disruptor
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.disruptor_glimpse)]
    public class DisruptorGlimpse : IAbilityComponent
    {
        [ImportingConstructor]
        public DisruptorGlimpse([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.disruptor_glimpse))
        {
        }

        public DisruptorGlimpse(IServiceContext context, IAbilityComponent ability)
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