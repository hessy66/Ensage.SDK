// <copyright file="LifeStealerEmpty3.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_life_stealer
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.life_stealer_empty_3)]
    public class LifeStealerEmpty3 : IAbilityComponent
    {
        [ImportingConstructor]
        public LifeStealerEmpty3([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.life_stealer_empty_3))
        {
        }

        public LifeStealerEmpty3(IServiceContext context, IAbilityComponent ability)
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