// <copyright file="Juggernaut.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_juggernaut
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_juggernaut)]
    public class Juggernaut : IHeroComponent
    {
        [ImportingConstructor]
        public Juggernaut([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Juggernaut(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.BladeDance = new JuggernautBladeDance(context);
            this.BladeFury = new JuggernautBladeFury(context);
            this.HealingWard = new JuggernautHealingWard(context);
            this.OmniSlash = new JuggernautOmniSlash(context);
        }

        public JuggernautBladeDance BladeDance { get; }

        public JuggernautBladeFury BladeFury { get; }

        public JuggernautHealingWard HealingWard { get; }

        public IHeroComponent Hero { get; }

        public JuggernautOmniSlash OmniSlash { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }
    }
}