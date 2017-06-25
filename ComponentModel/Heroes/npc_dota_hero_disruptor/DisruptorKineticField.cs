// <copyright file="DisruptorKineticField.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_disruptor
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.disruptor_kinetic_field)]
    public class DisruptorKineticField : IAbilityComponent
    {
        [ImportingConstructor]
        public DisruptorKineticField([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.disruptor_kinetic_field))
        {
        }

        public DisruptorKineticField(IServiceContext context, IAbilityComponent ability)
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