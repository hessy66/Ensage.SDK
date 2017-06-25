// <copyright file="AxeBattleHunger.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_axe
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.axe_battle_hunger)]
    public class AxeBattleHunger : IAbilityComponent
    {
        [ImportingConstructor]
        public AxeBattleHunger([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.axe_battle_hunger))
        {
        }

        public AxeBattleHunger(IServiceContext context, IAbilityComponent ability)
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