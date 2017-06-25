// <copyright file="ElderTitan.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_elder_titan
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_elder_titan)]
    public class ElderTitan : IHeroComponent
    {
        [ImportingConstructor]
        public ElderTitan([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public ElderTitan(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.EchoStomp = new ElderTitanEchoStomp(context);
            this.EchoStompSpirit = new ElderTitanEchoStompSpirit(context);
            this.AncestralSpirit = new ElderTitanAncestralSpirit(context);
            this.ReturnSpirit = new ElderTitanReturnSpirit(context);
            this.NaturalOrder = new ElderTitanNaturalOrder(context);
            this.EarthSplitter = new ElderTitanEarthSplitter(context);
            this.NaturalOrderSpirit = new ElderTitanNaturalOrderSpirit(context);
        }

        public ElderTitanAncestralSpirit AncestralSpirit { get; }

        public ElderTitanEarthSplitter EarthSplitter { get; }

        public ElderTitanEchoStomp EchoStomp { get; }

        public ElderTitanEchoStompSpirit EchoStompSpirit { get; }

        public IHeroComponent Hero { get; }

        public ElderTitanNaturalOrder NaturalOrder { get; }

        public ElderTitanNaturalOrderSpirit NaturalOrderSpirit { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public ElderTitanReturnSpirit ReturnSpirit { get; }
    }
}