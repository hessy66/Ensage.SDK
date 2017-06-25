// <copyright file="DoomBringer.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_doom_bringer
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_doom_bringer)]
    public class DoomBringer : IHeroComponent
    {
        [ImportingConstructor]
        public DoomBringer([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public DoomBringer(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Devour = new DoomBringerDevour(context);
            this.ScorchedEarth = new DoomBringerScorchedEarth(context);
            this.InfernalBlade = new DoomBringerInfernalBlade(context);
            this.Doom = new DoomBringerDoom(context);
            this.Empty1 = new DoomBringerEmpty1(context);
            this.Empty2 = new DoomBringerEmpty2(context);
        }

        public DoomBringerDevour Devour { get; }

        public DoomBringerDoom Doom { get; }

        public DoomBringerEmpty1 Empty1 { get; }

        public DoomBringerEmpty2 Empty2 { get; }

        public IHeroComponent Hero { get; }

        public DoomBringerInfernalBlade InfernalBlade { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public DoomBringerScorchedEarth ScorchedEarth { get; }
    }
}