// <copyright file="NecrolyteReapersScythe.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_necrolyte
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.necrolyte_reapers_scythe)]
    public class NecrolyteReapersScythe : IAbilityComponent
    {
        [ImportingConstructor]
        public NecrolyteReapersScythe([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.necrolyte_reapers_scythe))
        {
        }

        public NecrolyteReapersScythe(IServiceContext context, IAbilityComponent ability)
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