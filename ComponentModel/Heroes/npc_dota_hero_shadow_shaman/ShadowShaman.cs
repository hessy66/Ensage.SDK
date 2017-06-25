// <copyright file="ShadowShaman.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_shadow_shaman
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_shadow_shaman)]
    public class ShadowShaman : IHeroComponent
    {
        [ImportingConstructor]
        public ShadowShaman([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public ShadowShaman(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.EtherShock = new ShadowShamanEtherShock(context);
            this.Voodoo = new ShadowShamanVoodoo(context);
            this.Shackles = new ShadowShamanShackles(context);
            this.MassSerpentWard = new ShadowShamanMassSerpentWard(context);
        }

        public ShadowShamanEtherShock EtherShock { get; }

        public IHeroComponent Hero { get; }

        public ShadowShamanMassSerpentWard MassSerpentWard { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public ShadowShamanShackles Shackles { get; }

        public ShadowShamanVoodoo Voodoo { get; }
    }
}