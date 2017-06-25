// <copyright file="OracleFortunesEnd.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_oracle
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.oracle_fortunes_end)]
    public class OracleFortunesEnd : IAbilityComponent
    {
        [ImportingConstructor]
        public OracleFortunesEnd([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.oracle_fortunes_end))
        {
        }

        public OracleFortunesEnd(IServiceContext context, IAbilityComponent ability)
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