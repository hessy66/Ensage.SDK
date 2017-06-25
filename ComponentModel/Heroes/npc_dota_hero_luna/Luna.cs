// <copyright file="Luna.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_luna
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_luna)]
    public class Luna : IHeroComponent
    {
        [ImportingConstructor]
        public Luna([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Luna(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.LucentBeam = new LunaLucentBeam(context);
            this.MoonGlaive = new LunaMoonGlaive(context);
            this.LunarBlessing = new LunaLunarBlessing(context);
            this.Eclipse = new LunaEclipse(context);
        }

        public LunaEclipse Eclipse { get; }

        public IHeroComponent Hero { get; }

        public LunaLucentBeam LucentBeam { get; }

        public LunaLunarBlessing LunarBlessing { get; }

        public LunaMoonGlaive MoonGlaive { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }
    }
}