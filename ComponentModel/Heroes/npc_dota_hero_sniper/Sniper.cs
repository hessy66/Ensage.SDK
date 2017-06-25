// <copyright file="Sniper.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_sniper
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_sniper)]
    public class Sniper : IHeroComponent
    {
        [ImportingConstructor]
        public Sniper([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Sniper(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Shrapnel = new SniperShrapnel(context);
            this.Headshot = new SniperHeadshot(context);
            this.TakeAim = new SniperTakeAim(context);
            this.Assassinate = new SniperAssassinate(context);
        }

        public SniperAssassinate Assassinate { get; }

        public SniperHeadshot Headshot { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public SniperShrapnel Shrapnel { get; }

        public SniperTakeAim TakeAim { get; }
    }
}