// <copyright file="Furion.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_furion
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_furion)]
    public class Furion : IHeroComponent
    {
        [ImportingConstructor]
        public Furion([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Furion(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Sprout = new FurionSprout(context);
            this.Teleportation = new FurionTeleportation(context);
            this.ForceOfNature = new FurionForceOfNature(context);
            this.WrathOfNature = new FurionWrathOfNature(context);
        }

        public FurionForceOfNature ForceOfNature { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public FurionSprout Sprout { get; }

        public FurionTeleportation Teleportation { get; }

        public FurionWrathOfNature WrathOfNature { get; }
    }
}