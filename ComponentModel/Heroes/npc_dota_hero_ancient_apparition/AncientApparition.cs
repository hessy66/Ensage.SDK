// <copyright file="AncientApparition.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_ancient_apparition
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_ancient_apparition)]
    public class AncientApparition : IHeroComponent
    {
        [ImportingConstructor]
        public AncientApparition([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public AncientApparition(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.ColdFeet = new AncientApparitionColdFeet(context);
            this.IceVortex = new AncientApparitionIceVortex(context);
            this.ChillingTouch = new AncientApparitionChillingTouch(context);
            this.IceBlast = new AncientApparitionIceBlast(context);
            this.IceBlastRelease = new AncientApparitionIceBlastRelease(context);
        }

        public AncientApparitionChillingTouch ChillingTouch { get; }

        public AncientApparitionColdFeet ColdFeet { get; }

        public IHeroComponent Hero { get; }

        public AncientApparitionIceBlast IceBlast { get; }

        public AncientApparitionIceBlastRelease IceBlastRelease { get; }

        public AncientApparitionIceVortex IceVortex { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }
    }
}