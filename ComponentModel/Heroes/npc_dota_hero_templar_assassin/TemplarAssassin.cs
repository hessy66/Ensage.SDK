// <copyright file="TemplarAssassin.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_templar_assassin
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_templar_assassin)]
    public class TemplarAssassin : IHeroComponent
    {
        [ImportingConstructor]
        public TemplarAssassin([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public TemplarAssassin(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Refraction = new TemplarAssassinRefraction(context);
            this.Meld = new TemplarAssassinMeld(context);
            this.PsiBlades = new TemplarAssassinPsiBlades(context);
            this.PsionicTrap = new TemplarAssassinPsionicTrap(context);
            this.Trap = new TemplarAssassinTrap(context);
            this.SelfTrap = new TemplarAssassinSelfTrap(context);
        }

        public IHeroComponent Hero { get; }

        public TemplarAssassinMeld Meld { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public TemplarAssassinPsiBlades PsiBlades { get; }

        public TemplarAssassinPsionicTrap PsionicTrap { get; }

        public TemplarAssassinRefraction Refraction { get; }

        public TemplarAssassinSelfTrap SelfTrap { get; }

        public TemplarAssassinTrap Trap { get; }
    }
}