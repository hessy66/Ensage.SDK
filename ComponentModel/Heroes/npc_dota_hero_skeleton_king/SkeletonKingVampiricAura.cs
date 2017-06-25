// <copyright file="SkeletonKingVampiricAura.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_skeleton_king
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.skeleton_king_vampiric_aura)]
    public class SkeletonKingVampiricAura : IAbilityComponent
    {
        [ImportingConstructor]
        public SkeletonKingVampiricAura([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.skeleton_king_vampiric_aura))
        {
        }

        public SkeletonKingVampiricAura(IServiceContext context, IAbilityComponent ability)
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