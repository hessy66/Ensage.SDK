// <copyright file="NyxAssassin.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_nyx_assassin
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_nyx_assassin)]
    public class NyxAssassin : IHeroComponent
    {
        [ImportingConstructor]
        public NyxAssassin([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public NyxAssassin(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Impale = new NyxAssassinImpale(context);
            this.ManaBurn = new NyxAssassinManaBurn(context);
            this.SpikedCarapace = new NyxAssassinSpikedCarapace(context);
            this.Vendetta = new NyxAssassinVendetta(context);
            this.Burrow = new NyxAssassinBurrow(context);
            this.Unburrow = new NyxAssassinUnburrow(context);
        }

        public NyxAssassinBurrow Burrow { get; }

        public IHeroComponent Hero { get; }

        public NyxAssassinImpale Impale { get; }

        public NyxAssassinManaBurn ManaBurn { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public NyxAssassinSpikedCarapace SpikedCarapace { get; }

        public NyxAssassinUnburrow Unburrow { get; }

        public NyxAssassinVendetta Vendetta { get; }
    }
}