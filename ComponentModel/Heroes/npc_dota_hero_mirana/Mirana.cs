// <copyright file="Mirana.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_mirana
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_mirana)]
    public class Mirana : IHeroComponent
    {
        [ImportingConstructor]
        public Mirana([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Mirana(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Arrow = new MiranaArrow(context);
            this.Invis = new MiranaInvis(context);
            this.Leap = new MiranaLeap(context);
            this.Starfall = new MiranaStarfall(context);
        }

        public MiranaArrow Arrow { get; }

        public IHeroComponent Hero { get; }

        public MiranaInvis Invis { get; }

        public MiranaLeap Leap { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public MiranaStarfall Starfall { get; }
    }
}