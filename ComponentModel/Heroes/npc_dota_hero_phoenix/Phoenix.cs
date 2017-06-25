// <copyright file="Phoenix.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_phoenix
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_phoenix)]
    public class Phoenix : IHeroComponent
    {
        [ImportingConstructor]
        public Phoenix([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Phoenix(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.IcarusDive = new PhoenixIcarusDive(context);
            this.IcarusDiveStop = new PhoenixIcarusDiveStop(context);
            this.FireSpirits = new PhoenixFireSpirits(context);
            this.SunRay = new PhoenixSunRay(context);
            this.SunRayStop = new PhoenixSunRayStop(context);
            this.SunRayToggleMove = new PhoenixSunRayToggleMove(context);
            this.Supernova = new PhoenixSupernova(context);
            this.LaunchFireSpirit = new PhoenixLaunchFireSpirit(context);
        }

        public PhoenixFireSpirits FireSpirits { get; }

        public IHeroComponent Hero { get; }

        public PhoenixIcarusDive IcarusDive { get; }

        public PhoenixIcarusDiveStop IcarusDiveStop { get; }

        public PhoenixLaunchFireSpirit LaunchFireSpirit { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public PhoenixSunRay SunRay { get; }

        public PhoenixSunRayStop SunRayStop { get; }

        public PhoenixSunRayToggleMove SunRayToggleMove { get; }

        public PhoenixSupernova Supernova { get; }
    }
}