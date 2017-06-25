// <copyright file="Zuus.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_zuus
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_zuus)]
    public class Zuus : IHeroComponent
    {
        [ImportingConstructor]
        public Zuus([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Zuus(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.ArcLightning = new ZuusArcLightning(context);
            this.LightningBolt = new ZuusLightningBolt(context);
            this.StaticField = new ZuusStaticField(context);
            this.ThundergodsWrath = new ZuusThundergodsWrath(context);
            this.Cloud = new ZuusCloud(context);
        }

        public ZuusArcLightning ArcLightning { get; }

        public ZuusCloud Cloud { get; }

        public IHeroComponent Hero { get; }

        public ZuusLightningBolt LightningBolt { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public ZuusStaticField StaticField { get; }

        public ZuusThundergodsWrath ThundergodsWrath { get; }
    }
}