// <copyright file="LionFingerOfDeath.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_lion
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.lion_finger_of_death)]
    public class LionFingerOfDeath : IAbilityComponent
    {
        [ImportingConstructor]
        public LionFingerOfDeath([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.lion_finger_of_death))
        {
        }

        public LionFingerOfDeath(IServiceContext context, IAbilityComponent ability)
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