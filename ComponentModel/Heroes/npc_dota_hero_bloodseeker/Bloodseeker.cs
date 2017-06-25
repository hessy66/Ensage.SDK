// <copyright file="Bloodseeker.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_bloodseeker
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_bloodseeker)]
    public class Bloodseeker : IHeroComponent
    {
        [ImportingConstructor]
        public Bloodseeker([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Bloodseeker(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Bloodrage = new BloodseekerBloodrage(context);
            this.BloodBath = new BloodseekerBloodBath(context);
            this.Thirst = new BloodseekerThirst(context);
            this.Rupture = new BloodseekerRupture(context);
        }

        public BloodseekerBloodBath BloodBath { get; }

        public BloodseekerBloodrage Bloodrage { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public BloodseekerRupture Rupture { get; }

        public BloodseekerThirst Thirst { get; }
    }
}