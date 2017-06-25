// <copyright file="OracleFatesEdict.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_oracle
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.oracle_fates_edict)]
    public class OracleFatesEdict : IAbilityComponent
    {
        [ImportingConstructor]
        public OracleFatesEdict([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.oracle_fates_edict))
        {
        }

        public OracleFatesEdict(IServiceContext context, IAbilityComponent ability)
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