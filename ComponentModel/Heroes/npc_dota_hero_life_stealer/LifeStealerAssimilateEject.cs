// <copyright file="LifeStealerAssimilateEject.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_life_stealer
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.life_stealer_assimilate_eject)]
    public class LifeStealerAssimilateEject : IAbilityComponent
    {
        [ImportingConstructor]
        public LifeStealerAssimilateEject([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.life_stealer_assimilate_eject))
        {
        }

        public LifeStealerAssimilateEject(IServiceContext context, IAbilityComponent ability)
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