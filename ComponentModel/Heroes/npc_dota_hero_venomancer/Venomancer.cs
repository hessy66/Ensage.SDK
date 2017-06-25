// <copyright file="Venomancer.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_venomancer
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_venomancer)]
    public class Venomancer : IHeroComponent
    {
        [ImportingConstructor]
        public Venomancer([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Venomancer(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.VenomousGale = new VenomancerVenomousGale(context);
            this.PoisonSting = new VenomancerPoisonSting(context);
            this.PlagueWard = new VenomancerPlagueWard(context);
            this.PoisonNova = new VenomancerPoisonNova(context);
        }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public VenomancerPlagueWard PlagueWard { get; }

        public VenomancerPoisonNova PoisonNova { get; }

        public VenomancerPoisonSting PoisonSting { get; }

        public VenomancerVenomousGale VenomousGale { get; }
    }
}