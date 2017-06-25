// <copyright file="SkeletonKing.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_skeleton_king
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_skeleton_king)]
    public class SkeletonKing : IHeroComponent
    {
        [ImportingConstructor]
        public SkeletonKing([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public SkeletonKing(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.HellfireBlast = new SkeletonKingHellfireBlast(context);
            this.VampiricAura = new SkeletonKingVampiricAura(context);
            this.MortalStrike = new SkeletonKingMortalStrike(context);
            this.Reincarnation = new SkeletonKingReincarnation(context);
        }

        public SkeletonKingHellfireBlast HellfireBlast { get; }

        public IHeroComponent Hero { get; }

        public SkeletonKingMortalStrike MortalStrike { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public SkeletonKingReincarnation Reincarnation { get; }

        public SkeletonKingVampiricAura VampiricAura { get; }
    }
}