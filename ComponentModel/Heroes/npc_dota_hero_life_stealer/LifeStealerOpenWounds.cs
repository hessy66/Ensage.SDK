// <copyright file="LifeStealerOpenWounds.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_life_stealer
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.life_stealer_open_wounds)]
    public class LifeStealerOpenWounds : IAbilityComponent
    {
        [ImportingConstructor]
        public LifeStealerOpenWounds([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.life_stealer_open_wounds))
        {
        }

        public LifeStealerOpenWounds(IServiceContext context, IAbilityComponent ability)
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