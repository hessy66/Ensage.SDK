// <copyright file="Kunkka.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_kunkka
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_kunkka)]
    public class Kunkka : IHeroComponent
    {
        [ImportingConstructor]
        public Kunkka([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Kunkka(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Torrent = new KunkkaTorrent(context);
            this.Tidebringer = new KunkkaTidebringer(context);
            this.XMarksTheSpot = new KunkkaXMarksTheSpot(context);
            this.Return = new KunkkaReturn(context);
            this.Ghostship = new KunkkaGhostship(context);
        }

        public KunkkaGhostship Ghostship { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public KunkkaReturn Return { get; }

        public KunkkaTidebringer Tidebringer { get; }

        public KunkkaTorrent Torrent { get; }

        public KunkkaXMarksTheSpot XMarksTheSpot { get; }
    }
}