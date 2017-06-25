// <copyright file="Viper.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_viper
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_viper)]
    public class Viper : IHeroComponent
    {
        [ImportingConstructor]
        public Viper([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Viper(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.PoisonAttack = new ViperPoisonAttack(context);
            this.Nethertoxin = new ViperNethertoxin(context);
            this.CorrosiveSkin = new ViperCorrosiveSkin(context);
            this.Strike = new ViperStrike(context);
        }

        public ViperCorrosiveSkin CorrosiveSkin { get; }

        public IHeroComponent Hero { get; }

        public ViperNethertoxin Nethertoxin { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public ViperPoisonAttack PoisonAttack { get; }

        public ViperStrike Strike { get; }
    }
}