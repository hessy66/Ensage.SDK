// <copyright file="Lycan.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_lycan
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_lycan)]
    public class Lycan : IHeroComponent
    {
        [ImportingConstructor]
        public Lycan([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Lycan(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.SummonWolves = new LycanSummonWolves(context);
            this.Howl = new LycanHowl(context);
            this.FeralImpulse = new LycanFeralImpulse(context);
            this.Shapeshift = new LycanShapeshift(context);
            this.SummonWolvesCriticalStrike = new LycanSummonWolvesCriticalStrike(context);
            this.SummonWolvesInvisibility = new LycanSummonWolvesInvisibility(context);
        }

        public LycanFeralImpulse FeralImpulse { get; }

        public IHeroComponent Hero { get; }

        public LycanHowl Howl { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public LycanShapeshift Shapeshift { get; }

        public LycanSummonWolves SummonWolves { get; }

        public LycanSummonWolvesCriticalStrike SummonWolvesCriticalStrike { get; }

        public LycanSummonWolvesInvisibility SummonWolvesInvisibility { get; }
    }
}