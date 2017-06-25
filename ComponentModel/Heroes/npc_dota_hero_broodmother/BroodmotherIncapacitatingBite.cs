// <copyright file="BroodmotherIncapacitatingBite.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_broodmother
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.broodmother_incapacitating_bite)]
    public class BroodmotherIncapacitatingBite : IAbilityComponent
    {
        [ImportingConstructor]
        public BroodmotherIncapacitatingBite([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.broodmother_incapacitating_bite))
        {
        }

        public BroodmotherIncapacitatingBite(IServiceContext context, IAbilityComponent ability)
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