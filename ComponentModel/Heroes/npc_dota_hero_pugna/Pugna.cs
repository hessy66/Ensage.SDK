// <copyright file="Pugna.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_pugna
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_pugna)]
    public class Pugna : IHeroComponent
    {
        [ImportingConstructor]
        public Pugna([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Pugna(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.NetherBlast = new PugnaNetherBlast(context);
            this.Decrepify = new PugnaDecrepify(context);
            this.NetherWard = new PugnaNetherWard(context);
            this.LifeDrain = new PugnaLifeDrain(context);
        }

        public PugnaDecrepify Decrepify { get; }

        public IHeroComponent Hero { get; }

        public PugnaLifeDrain LifeDrain { get; }

        public PugnaNetherBlast NetherBlast { get; }

        public PugnaNetherWard NetherWard { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }
    }
}