// <copyright file="Enchantress.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_enchantress
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_enchantress)]
    public class Enchantress : IHeroComponent
    {
        [ImportingConstructor]
        public Enchantress([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Enchantress(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Untouchable = new EnchantressUntouchable(context);
            this.Enchant = new EnchantressEnchant(context);
            this.NaturesAttendants = new EnchantressNaturesAttendants(context);
            this.Impetus = new EnchantressImpetus(context);
        }

        public EnchantressEnchant Enchant { get; }

        public IHeroComponent Hero { get; }

        public EnchantressImpetus Impetus { get; }

        public EnchantressNaturesAttendants NaturesAttendants { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public EnchantressUntouchable Untouchable { get; }
    }
}