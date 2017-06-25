// <copyright file="Tidehunter.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_tidehunter
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_tidehunter)]
    public class Tidehunter : IHeroComponent
    {
        [ImportingConstructor]
        public Tidehunter([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Tidehunter(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Gush = new TidehunterGush(context);
            this.KrakenShell = new TidehunterKrakenShell(context);
            this.AnchorSmash = new TidehunterAnchorSmash(context);
            this.Ravage = new TidehunterRavage(context);
        }

        public TidehunterAnchorSmash AnchorSmash { get; }

        public TidehunterGush Gush { get; }

        public IHeroComponent Hero { get; }

        public TidehunterKrakenShell KrakenShell { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public TidehunterRavage Ravage { get; }
    }
}