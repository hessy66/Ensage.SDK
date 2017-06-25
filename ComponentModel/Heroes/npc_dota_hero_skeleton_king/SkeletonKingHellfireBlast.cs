// <copyright file="SkeletonKingHellfireBlast.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_skeleton_king
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.skeleton_king_hellfire_blast)]
    public class SkeletonKingHellfireBlast : IAbilityComponent
    {
        [ImportingConstructor]
        public SkeletonKingHellfireBlast([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.skeleton_king_hellfire_blast))
        {
        }

        public SkeletonKingHellfireBlast(IServiceContext context, IAbilityComponent ability)
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