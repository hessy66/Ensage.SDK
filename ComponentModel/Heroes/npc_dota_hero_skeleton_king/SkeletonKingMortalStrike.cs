// <copyright file="SkeletonKingMortalStrike.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_skeleton_king
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.skeleton_king_mortal_strike)]
    public class SkeletonKingMortalStrike : IAbilityComponent
    {
        [ImportingConstructor]
        public SkeletonKingMortalStrike([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.skeleton_king_mortal_strike))
        {
        }

        public SkeletonKingMortalStrike(IServiceContext context, IAbilityComponent ability)
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