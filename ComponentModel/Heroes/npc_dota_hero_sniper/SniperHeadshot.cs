// <copyright file="SniperHeadshot.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_sniper
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.sniper_headshot)]
    public class SniperHeadshot : IAbilityComponent
    {
        [ImportingConstructor]
        public SniperHeadshot([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.sniper_headshot))
        {
        }

        public SniperHeadshot(IServiceContext context, IAbilityComponent ability)
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