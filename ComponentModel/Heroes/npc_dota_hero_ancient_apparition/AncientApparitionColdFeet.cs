// <copyright file="AncientApparitionColdFeet.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_ancient_apparition
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.ancient_apparition_cold_feet)]
    public class AncientApparitionColdFeet : IAbilityComponent
    {
        [ImportingConstructor]
        public AncientApparitionColdFeet([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.ancient_apparition_cold_feet))
        {
        }

        public AncientApparitionColdFeet(IServiceContext context, IAbilityComponent ability)
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