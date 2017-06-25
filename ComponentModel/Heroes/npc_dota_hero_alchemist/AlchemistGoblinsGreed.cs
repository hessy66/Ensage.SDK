// <copyright file="AlchemistGoblinsGreed.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_alchemist
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.alchemist_goblins_greed)]
    public class AlchemistGoblinsGreed : IAbilityComponent
    {
        [ImportingConstructor]
        public AlchemistGoblinsGreed([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.alchemist_goblins_greed))
        {
        }

        public AlchemistGoblinsGreed(IServiceContext context, IAbilityComponent ability)
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