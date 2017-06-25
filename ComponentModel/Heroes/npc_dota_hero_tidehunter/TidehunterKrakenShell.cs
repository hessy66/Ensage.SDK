// <copyright file="TidehunterKrakenShell.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_tidehunter
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.tidehunter_kraken_shell)]
    public class TidehunterKrakenShell : IAbilityComponent
    {
        [ImportingConstructor]
        public TidehunterKrakenShell([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.tidehunter_kraken_shell))
        {
        }

        public TidehunterKrakenShell(IServiceContext context, IAbilityComponent ability)
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