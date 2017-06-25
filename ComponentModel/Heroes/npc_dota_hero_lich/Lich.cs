// <copyright file="Lich.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_lich
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_lich)]
    public class Lich : IHeroComponent
    {
        [ImportingConstructor]
        public Lich([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Lich(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.FrostNova = new LichFrostNova(context);
            this.FrostArmor = new LichFrostArmor(context);
            this.DarkRitual = new LichDarkRitual(context);
            this.ChainFrost = new LichChainFrost(context);
        }

        public LichChainFrost ChainFrost { get; }

        public LichDarkRitual DarkRitual { get; }

        public LichFrostArmor FrostArmor { get; }

        public LichFrostNova FrostNova { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }
    }
}