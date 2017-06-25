// <copyright file="Techies.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_techies
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_techies)]
    public class Techies : IHeroComponent
    {
        [ImportingConstructor]
        public Techies([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Techies(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.LandMines = new TechiesLandMines(context);
            this.StasisTrap = new TechiesStasisTrap(context);
            this.Suicide = new TechiesSuicide(context);
            this.RemoteMines = new TechiesRemoteMines(context);
            this.FocusedDetonate = new TechiesFocusedDetonate(context);
            this.RemoteMinesSelfDetonate = new TechiesRemoteMinesSelfDetonate(context);
            this.MinefieldSign = new TechiesMinefieldSign(context);
        }

        public TechiesFocusedDetonate FocusedDetonate { get; }

        public IHeroComponent Hero { get; }

        public TechiesLandMines LandMines { get; }

        public TechiesMinefieldSign MinefieldSign { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public TechiesRemoteMines RemoteMines { get; }

        public TechiesRemoteMinesSelfDetonate RemoteMinesSelfDetonate { get; }

        public TechiesStasisTrap StasisTrap { get; }

        public TechiesSuicide Suicide { get; }
    }
}