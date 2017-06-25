// <copyright file="RikiBlinkStrike.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_riki
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.riki_blink_strike)]
    public class RikiBlinkStrike : IAbilityComponent
    {
        [ImportingConstructor]
        public RikiBlinkStrike([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.riki_blink_strike))
        {
        }

        public RikiBlinkStrike(IServiceContext context, IAbilityComponent ability)
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