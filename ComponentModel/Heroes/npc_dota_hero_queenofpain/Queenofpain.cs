// <copyright file="Queenofpain.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_queenofpain
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_queenofpain)]
    public class Queenofpain : IHeroComponent
    {
        [ImportingConstructor]
        public Queenofpain([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Queenofpain(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.ShadowStrike = new QueenofpainShadowStrike(context);
            this.Blink = new QueenofpainBlink(context);
            this.ScreamOfPain = new QueenofpainScreamOfPain(context);
            this.SonicWave = new QueenofpainSonicWave(context);
        }

        public QueenofpainBlink Blink { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public QueenofpainScreamOfPain ScreamOfPain { get; }

        public QueenofpainShadowStrike ShadowStrike { get; }

        public QueenofpainSonicWave SonicWave { get; }
    }
}