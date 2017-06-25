// <copyright file="SandKing.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_sand_king
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_sand_king)]
    public class SandKing : IHeroComponent
    {
        [ImportingConstructor]
        public SandKing([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public SandKing(IServiceContext context, IHeroComponent hero)
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