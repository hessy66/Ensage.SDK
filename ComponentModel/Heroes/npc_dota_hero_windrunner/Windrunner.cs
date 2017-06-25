// <copyright file="Windrunner.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_windrunner
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_windrunner)]
    public class Windrunner : IHeroComponent
    {
        [ImportingConstructor]
        public Windrunner([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Windrunner(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Shackleshot = new WindrunnerShackleshot(context);
            this.Powershot = new WindrunnerPowershot(context);
            this.Windrun = new WindrunnerWindrun(context);
            this.Focusfire = new WindrunnerFocusfire(context);
        }

        public WindrunnerFocusfire Focusfire { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public WindrunnerPowershot Powershot { get; }

        public WindrunnerShackleshot Shackleshot { get; }

        public WindrunnerWindrun Windrun { get; }
    }
}