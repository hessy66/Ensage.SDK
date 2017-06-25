// <copyright file="Lina.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_lina
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_lina)]
    public class Lina : IHeroComponent
    {
        [ImportingConstructor]
        public Lina([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Lina(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.DragonSlave = new LinaDragonSlave(context);
            this.LightStrikeArray = new LinaLightStrikeArray(context);
            this.FierySoul = new LinaFierySoul(context);
            this.LagunaBlade = new LinaLagunaBlade(context);
        }

        public LinaDragonSlave DragonSlave { get; }

        public LinaFierySoul FierySoul { get; }

        public IHeroComponent Hero { get; }

        public LinaLagunaBlade LagunaBlade { get; }

        public LinaLightStrikeArray LightStrikeArray { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }
    }
}