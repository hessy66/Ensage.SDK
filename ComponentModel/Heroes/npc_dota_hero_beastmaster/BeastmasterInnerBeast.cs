// <copyright file="BeastmasterInnerBeast.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_beastmaster
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.beastmaster_inner_beast)]
    public class BeastmasterInnerBeast : IAbilityComponent
    {
        [ImportingConstructor]
        public BeastmasterInnerBeast([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.beastmaster_inner_beast))
        {
        }

        public BeastmasterInnerBeast(IServiceContext context, IAbilityComponent ability)
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