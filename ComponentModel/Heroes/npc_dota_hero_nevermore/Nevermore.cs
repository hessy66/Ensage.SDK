// <copyright file="Nevermore.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_nevermore
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_nevermore)]
    public class Nevermore : IHeroComponent
    {
        [ImportingConstructor]
        public Nevermore([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Nevermore(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Shadowraze1 = new NevermoreShadowraze1(context);
            this.Shadowraze2 = new NevermoreShadowraze2(context);
            this.Shadowraze3 = new NevermoreShadowraze3(context);
            this.Necromastery = new NevermoreNecromastery(context);
            this.DarkLord = new NevermoreDarkLord(context);
            this.Requiem = new NevermoreRequiem(context);
        }

        public NevermoreDarkLord DarkLord { get; }

        public IHeroComponent Hero { get; }

        public NevermoreNecromastery Necromastery { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public NevermoreRequiem Requiem { get; }

        public NevermoreShadowraze1 Shadowraze1 { get; }

        public NevermoreShadowraze2 Shadowraze2 { get; }

        public NevermoreShadowraze3 Shadowraze3 { get; }
    }
}