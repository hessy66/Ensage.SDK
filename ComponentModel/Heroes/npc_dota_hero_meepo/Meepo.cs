// <copyright file="Meepo.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_meepo
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_meepo)]
    public class Meepo : IHeroComponent
    {
        [ImportingConstructor]
        public Meepo([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Meepo(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Earthbind = new MeepoEarthbind(context);
            this.Poof = new MeepoPoof(context);
            this.Geostrike = new MeepoGeostrike(context);
            this.DividedWeStand = new MeepoDividedWeStand(context);
        }

        public MeepoDividedWeStand DividedWeStand { get; }

        public MeepoEarthbind Earthbind { get; }

        public MeepoGeostrike Geostrike { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public MeepoPoof Poof { get; }
    }
}