// <copyright file="Centaur.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_centaur
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_centaur)]
    public class Centaur : IHeroComponent
    {
        [ImportingConstructor]
        public Centaur([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Centaur(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.KhanEnduranceAura = new CentaurKhanEnduranceAura(context);
            this.KhanWarStomp = new CentaurKhanWarStomp(context);
            this.HoofStomp = new CentaurHoofStomp(context);
            this.DoubleEdge = new CentaurDoubleEdge(context);
            this.Return = new CentaurReturn(context);
            this.Stampede = new CentaurStampede(context);
        }

        public CentaurDoubleEdge DoubleEdge { get; }

        public IHeroComponent Hero { get; }

        public CentaurHoofStomp HoofStomp { get; }

        public CentaurKhanEnduranceAura KhanEnduranceAura { get; }

        public CentaurKhanWarStomp KhanWarStomp { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public CentaurReturn Return { get; }

        public CentaurStampede Stampede { get; }
    }
}