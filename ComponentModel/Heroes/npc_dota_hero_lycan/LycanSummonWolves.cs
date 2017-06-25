// <copyright file="LycanSummonWolves.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_lycan
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.lycan_summon_wolves)]
    public class LycanSummonWolves : IAbilityComponent
    {
        [ImportingConstructor]
        public LycanSummonWolves([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.lycan_summon_wolves))
        {
        }

        public LycanSummonWolves(IServiceContext context, IAbilityComponent ability)
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