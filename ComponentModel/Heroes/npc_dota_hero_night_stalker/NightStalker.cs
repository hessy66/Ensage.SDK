// <copyright file="NightStalker.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_night_stalker
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_night_stalker)]
    public class NightStalker : IHeroComponent
    {
        [ImportingConstructor]
        public NightStalker([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public NightStalker(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Void = new NightStalkerVoid(context);
            this.CripplingFear = new NightStalkerCripplingFear(context);
            this.HunterInTheNight = new NightStalkerHunterInTheNight(context);
            this.Darkness = new NightStalkerDarkness(context);
        }

        public NightStalkerCripplingFear CripplingFear { get; }

        public NightStalkerDarkness Darkness { get; }

        public IHeroComponent Hero { get; }

        public NightStalkerHunterInTheNight HunterInTheNight { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public NightStalkerVoid Void { get; }
    }
}