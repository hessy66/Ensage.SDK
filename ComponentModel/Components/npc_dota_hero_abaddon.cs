// <copyright file="npc_dota_hero_abaddon.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Components
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_abaddon)]
    public class npc_dota_hero_abaddon : IHeroComponent
    {
        [ImportingConstructor]
        public npc_dota_hero_abaddon([Import] IServiceContext context)
            : this(new HeroComponent(context))
        {
        }

        public npc_dota_hero_abaddon(IHeroComponent hero)
        {
            this.Hero = hero;
        }

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