// <copyright file="WinterWyvern.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_winter_wyvern
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_winter_wyvern)]
    public class WinterWyvern : IHeroComponent
    {
        [ImportingConstructor]
        public WinterWyvern([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public WinterWyvern(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.ArcticBurn = new WinterWyvernArcticBurn(context);
            this.SplinterBlast = new WinterWyvernSplinterBlast(context);
            this.ColdEmbrace = new WinterWyvernColdEmbrace(context);
            this.WintersCurse = new WinterWyvernWintersCurse(context);
        }

        public WinterWyvernArcticBurn ArcticBurn { get; }

        public WinterWyvernColdEmbrace ColdEmbrace { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public WinterWyvernSplinterBlast SplinterBlast { get; }

        public WinterWyvernWintersCurse WintersCurse { get; }
    }
}