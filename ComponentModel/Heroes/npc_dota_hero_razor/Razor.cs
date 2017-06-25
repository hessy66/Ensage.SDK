// <copyright file="Razor.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_razor
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_razor)]
    public class Razor : IHeroComponent
    {
        [ImportingConstructor]
        public Razor([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Razor(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.PlasmaField = new RazorPlasmaField(context);
            this.StaticLink = new RazorStaticLink(context);
            this.UnstableCurrent = new RazorUnstableCurrent(context);
            this.EyeOfTheStorm = new RazorEyeOfTheStorm(context);
        }

        public RazorEyeOfTheStorm EyeOfTheStorm { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public RazorPlasmaField PlasmaField { get; }

        public RazorStaticLink StaticLink { get; }

        public RazorUnstableCurrent UnstableCurrent { get; }
    }
}