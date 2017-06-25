// <copyright file="Slardar.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_slardar
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_slardar)]
    public class Slardar : IHeroComponent
    {
        [ImportingConstructor]
        public Slardar([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Slardar(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Sprint = new SlardarSprint(context);
            this.SlithereenCrush = new SlardarSlithereenCrush(context);
            this.Bash = new SlardarBash(context);
            this.AmplifyDamage = new SlardarAmplifyDamage(context);
        }

        public SlardarAmplifyDamage AmplifyDamage { get; }

        public SlardarBash Bash { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public SlardarSlithereenCrush SlithereenCrush { get; }

        public SlardarSprint Sprint { get; }
    }
}