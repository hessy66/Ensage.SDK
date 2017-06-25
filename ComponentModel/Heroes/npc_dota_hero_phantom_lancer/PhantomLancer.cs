// <copyright file="PhantomLancer.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_phantom_lancer
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_phantom_lancer)]
    public class PhantomLancer : IHeroComponent
    {
        [ImportingConstructor]
        public PhantomLancer([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public PhantomLancer(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.SpiritLance = new PhantomLancerSpiritLance(context);
            this.Doppelwalk = new PhantomLancerDoppelwalk(context);
            this.Juxtapose = new PhantomLancerJuxtapose(context);
            this.PhantomEdge = new PhantomLancerPhantomEdge(context);
        }

        public PhantomLancerDoppelwalk Doppelwalk { get; }

        public IHeroComponent Hero { get; }

        public PhantomLancerJuxtapose Juxtapose { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public PhantomLancerPhantomEdge PhantomEdge { get; }

        public PhantomLancerSpiritLance SpiritLance { get; }
    }
}