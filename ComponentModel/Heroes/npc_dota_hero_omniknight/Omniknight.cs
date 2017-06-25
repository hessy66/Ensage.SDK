// <copyright file="Omniknight.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_omniknight
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_omniknight)]
    public class Omniknight : IHeroComponent
    {
        [ImportingConstructor]
        public Omniknight([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Omniknight(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Purification = new OmniknightPurification(context);
            this.Repel = new OmniknightRepel(context);
            this.DegenAura = new OmniknightDegenAura(context);
            this.GuardianAngel = new OmniknightGuardianAngel(context);
        }

        public OmniknightDegenAura DegenAura { get; }

        public OmniknightGuardianAngel GuardianAngel { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public OmniknightPurification Purification { get; }

        public OmniknightRepel Repel { get; }
    }
}