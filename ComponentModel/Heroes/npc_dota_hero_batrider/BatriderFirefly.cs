// <copyright file="BatriderFirefly.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_batrider
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.batrider_firefly)]
    public class BatriderFirefly : IAbilityComponent
    {
        [ImportingConstructor]
        public BatriderFirefly([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.batrider_firefly))
        {
        }

        public BatriderFirefly(IServiceContext context, IAbilityComponent ability)
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