// <copyright file="PhantomAssassin.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_phantom_assassin
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_phantom_assassin)]
    public class PhantomAssassin : IHeroComponent
    {
        [ImportingConstructor]
        public PhantomAssassin([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public PhantomAssassin(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.StiflingDagger = new PhantomAssassinStiflingDagger(context);
            this.PhantomStrike = new PhantomAssassinPhantomStrike(context);
            this.Blur = new PhantomAssassinBlur(context);
            this.CoupDeGrace = new PhantomAssassinCoupDeGrace(context);
        }

        public PhantomAssassinBlur Blur { get; }

        public PhantomAssassinCoupDeGrace CoupDeGrace { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public PhantomAssassinPhantomStrike PhantomStrike { get; }

        public PhantomAssassinStiflingDagger StiflingDagger { get; }
    }
}