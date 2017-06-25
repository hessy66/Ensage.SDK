// <copyright file="OracleFalsePromise.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_oracle
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.oracle_false_promise)]
    public class OracleFalsePromise : IAbilityComponent
    {
        [ImportingConstructor]
        public OracleFalsePromise([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.oracle_false_promise))
        {
        }

        public OracleFalsePromise(IServiceContext context, IAbilityComponent ability)
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