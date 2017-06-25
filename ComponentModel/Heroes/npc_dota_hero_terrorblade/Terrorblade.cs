// <copyright file="Terrorblade.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_terrorblade
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_terrorblade)]
    public class Terrorblade : IHeroComponent
    {
        [ImportingConstructor]
        public Terrorblade([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Terrorblade(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Reflection = new TerrorbladeReflection(context);
            this.ConjureImage = new TerrorbladeConjureImage(context);
            this.Metamorphosis = new TerrorbladeMetamorphosis(context);
            this.Sunder = new TerrorbladeSunder(context);
        }

        public TerrorbladeConjureImage ConjureImage { get; }

        public IHeroComponent Hero { get; }

        public TerrorbladeMetamorphosis Metamorphosis { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public TerrorbladeReflection Reflection { get; }

        public TerrorbladeSunder Sunder { get; }
    }
}