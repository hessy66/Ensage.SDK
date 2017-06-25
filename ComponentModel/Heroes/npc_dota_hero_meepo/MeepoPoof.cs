// <copyright file="MeepoPoof.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_meepo
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.meepo_poof)]
    public class MeepoPoof : IAbilityComponent
    {
        [ImportingConstructor]
        public MeepoPoof([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.meepo_poof))
        {
        }

        public MeepoPoof(IServiceContext context, IAbilityComponent ability)
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