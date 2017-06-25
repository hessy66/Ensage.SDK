// <copyright file="Earthshaker.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_earthshaker
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_earthshaker)]
    public class Earthshaker : IHeroComponent
    {
        [ImportingConstructor]
        public Earthshaker([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Earthshaker(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Fissure = new EarthshakerFissure(context);
            this.EnchantTotem = new EarthshakerEnchantTotem(context);
            this.Aftershock = new EarthshakerAftershock(context);
            this.EchoSlam = new EarthshakerEchoSlam(context);
        }

        public EarthshakerAftershock Aftershock { get; }

        public EarthshakerEchoSlam EchoSlam { get; }

        public EarthshakerEnchantTotem EnchantTotem { get; }

        public EarthshakerFissure Fissure { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }
    }
}