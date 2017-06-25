// <copyright file="Alchemist.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_alchemist
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_alchemist)]
    public class Alchemist : IHeroComponent
    {
        [ImportingConstructor]
        public Alchemist([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Alchemist(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.AcidSpray = new AlchemistAcidSpray(context);
            this.UnstableConcoction = new AlchemistUnstableConcoction(context);
            this.UnstableConcoctionThrow = new AlchemistUnstableConcoctionThrow(context);
            this.GoblinsGreed = new AlchemistGoblinsGreed(context);
            this.ChemicalRage = new AlchemistChemicalRage(context);
        }

        public AlchemistAcidSpray AcidSpray { get; }

        public AlchemistChemicalRage ChemicalRage { get; }

        public AlchemistGoblinsGreed GoblinsGreed { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public AlchemistUnstableConcoction UnstableConcoction { get; }

        public AlchemistUnstableConcoctionThrow UnstableConcoctionThrow { get; }
    }
}