// <copyright file="Slark.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_slark
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_slark)]
    public class Slark : IHeroComponent
    {
        [ImportingConstructor]
        public Slark([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Slark(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.DarkPact = new SlarkDarkPact(context);
            this.Pounce = new SlarkPounce(context);
            this.EssenceShift = new SlarkEssenceShift(context);
            this.ShadowDance = new SlarkShadowDance(context);
        }

        public SlarkDarkPact DarkPact { get; }

        public SlarkEssenceShift EssenceShift { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public SlarkPounce Pounce { get; }

        public SlarkShadowDance ShadowDance { get; }
    }
}