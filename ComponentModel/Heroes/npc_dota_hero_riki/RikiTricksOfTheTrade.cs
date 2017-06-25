// <copyright file="RikiTricksOfTheTrade.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_riki
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.riki_tricks_of_the_trade)]
    public class RikiTricksOfTheTrade : IAbilityComponent
    {
        [ImportingConstructor]
        public RikiTricksOfTheTrade([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.riki_tricks_of_the_trade))
        {
        }

        public RikiTricksOfTheTrade(IServiceContext context, IAbilityComponent ability)
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