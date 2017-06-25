// <copyright file="LichChainFrost.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_lich
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.lich_chain_frost)]
    public class LichChainFrost : IAbilityComponent
    {
        [ImportingConstructor]
        public LichChainFrost([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.lich_chain_frost))
        {
        }

        public LichChainFrost(IServiceContext context, IAbilityComponent ability)
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