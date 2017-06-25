// <copyright file="KeeperOfTheLight.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_keeper_of_the_light
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_keeper_of_the_light)]
    public class KeeperOfTheLight : IHeroComponent
    {
        [ImportingConstructor]
        public KeeperOfTheLight([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public KeeperOfTheLight(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Illuminate = new KeeperOfTheLightIlluminate(context);
            this.ManaLeak = new KeeperOfTheLightManaLeak(context);
            this.ChakraMagic = new KeeperOfTheLightChakraMagic(context);
            this.SpiritForm = new KeeperOfTheLightSpiritForm(context);
            this.Recall = new KeeperOfTheLightRecall(context);
            this.BlindingLight = new KeeperOfTheLightBlindingLight(context);
            this.IlluminateEnd = new KeeperOfTheLightIlluminateEnd(context);
            this.SpiritFormIlluminate = new KeeperOfTheLightSpiritFormIlluminate(context);
            this.Empty1 = new KeeperOfTheLightEmpty1(context);
            this.Empty2 = new KeeperOfTheLightEmpty2(context);
            this.SpiritFormIlluminateEnd = new KeeperOfTheLightSpiritFormIlluminateEnd(context);
        }

        public KeeperOfTheLightBlindingLight BlindingLight { get; }

        public KeeperOfTheLightChakraMagic ChakraMagic { get; }

        public KeeperOfTheLightEmpty1 Empty1 { get; }

        public KeeperOfTheLightEmpty2 Empty2 { get; }

        public IHeroComponent Hero { get; }

        public KeeperOfTheLightIlluminate Illuminate { get; }

        public KeeperOfTheLightIlluminateEnd IlluminateEnd { get; }

        public KeeperOfTheLightManaLeak ManaLeak { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public KeeperOfTheLightRecall Recall { get; }

        public KeeperOfTheLightSpiritForm SpiritForm { get; }

        public KeeperOfTheLightSpiritFormIlluminate SpiritFormIlluminate { get; }

        public KeeperOfTheLightSpiritFormIlluminateEnd SpiritFormIlluminateEnd { get; }
    }
}