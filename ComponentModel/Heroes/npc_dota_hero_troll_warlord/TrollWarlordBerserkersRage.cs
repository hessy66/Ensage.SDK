// <copyright file="TrollWarlordBerserkersRage.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_troll_warlord
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.troll_warlord_berserkers_rage)]
    public class TrollWarlordBerserkersRage : IAbilityComponent
    {
        [ImportingConstructor]
        public TrollWarlordBerserkersRage([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.troll_warlord_berserkers_rage))
        {
        }

        public TrollWarlordBerserkersRage(IServiceContext context, IAbilityComponent ability)
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