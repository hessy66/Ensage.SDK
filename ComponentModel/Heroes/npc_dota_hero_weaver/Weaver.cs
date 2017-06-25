// <copyright file="Weaver.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_weaver
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_weaver)]
    public class Weaver : IHeroComponent
    {
        [ImportingConstructor]
        public Weaver([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Weaver(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.TheSwarm = new WeaverTheSwarm(context);
            this.Shukuchi = new WeaverShukuchi(context);
            this.GeminateAttack = new WeaverGeminateAttack(context);
            this.TimeLapse = new WeaverTimeLapse(context);
        }

        public WeaverGeminateAttack GeminateAttack { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public WeaverShukuchi Shukuchi { get; }

        public WeaverTheSwarm TheSwarm { get; }

        public WeaverTimeLapse TimeLapse { get; }
    }
}