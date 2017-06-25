// <copyright file="TrollWarlordBattleTrance.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_troll_warlord
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.troll_warlord_battle_trance)]
    public class TrollWarlordBattleTrance : IAbilityComponent
    {
        [ImportingConstructor]
        public TrollWarlordBattleTrance([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.troll_warlord_battle_trance))
        {
        }

        public TrollWarlordBattleTrance(IServiceContext context, IAbilityComponent ability)
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