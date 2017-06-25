// <copyright file="Lion.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_lion
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_lion)]
    public class Lion : IHeroComponent
    {
        [ImportingConstructor]
        public Lion([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Lion(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Impale = new LionImpale(context);
            this.Voodoo = new LionVoodoo(context);
            this.ManaDrain = new LionManaDrain(context);
            this.FingerOfDeath = new LionFingerOfDeath(context);
        }

        public LionFingerOfDeath FingerOfDeath { get; }

        public IHeroComponent Hero { get; }

        public LionImpale Impale { get; }

        public LionManaDrain ManaDrain { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public LionVoodoo Voodoo { get; }
    }
}