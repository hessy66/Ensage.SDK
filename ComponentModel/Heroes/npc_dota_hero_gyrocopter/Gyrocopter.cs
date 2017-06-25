// <copyright file="Gyrocopter.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_gyrocopter
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_gyrocopter)]
    public class Gyrocopter : IHeroComponent
    {
        [ImportingConstructor]
        public Gyrocopter([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Gyrocopter(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.RocketBarrage = new GyrocopterRocketBarrage(context);
            this.HomingMissile = new GyrocopterHomingMissile(context);
            this.FlakCannon = new GyrocopterFlakCannon(context);
            this.CallDown = new GyrocopterCallDown(context);
        }

        public GyrocopterCallDown CallDown { get; }

        public GyrocopterFlakCannon FlakCannon { get; }

        public IHeroComponent Hero { get; }

        public GyrocopterHomingMissile HomingMissile { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public GyrocopterRocketBarrage RocketBarrage { get; }
    }
}