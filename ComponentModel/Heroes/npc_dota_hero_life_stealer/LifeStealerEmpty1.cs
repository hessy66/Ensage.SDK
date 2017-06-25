// <copyright file="LifeStealerEmpty1.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_life_stealer
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.life_stealer_empty_1)]
    public class LifeStealerEmpty1 : IAbilityComponent
    {
        [ImportingConstructor]
        public LifeStealerEmpty1([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.life_stealer_empty_1))
        {
        }

        public LifeStealerEmpty1(IServiceContext context, IAbilityComponent ability)
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