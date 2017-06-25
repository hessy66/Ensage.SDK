// <copyright file="LifeStealer.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_life_stealer
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_life_stealer)]
    public class LifeStealer : IHeroComponent
    {
        [ImportingConstructor]
        public LifeStealer([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public LifeStealer(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Rage = new LifeStealerRage(context);
            this.Feast = new LifeStealerFeast(context);
            this.OpenWounds = new LifeStealerOpenWounds(context);
            this.Infest = new LifeStealerInfest(context);
            this.Consume = new LifeStealerConsume(context);
            this.Control = new LifeStealerControl(context);
            this.Empty1 = new LifeStealerEmpty1(context);
            this.Empty2 = new LifeStealerEmpty2(context);
            this.Empty3 = new LifeStealerEmpty3(context);
            this.Empty4 = new LifeStealerEmpty4(context);
            this.Assimilate = new LifeStealerAssimilate(context);
            this.AssimilateEject = new LifeStealerAssimilateEject(context);
        }

        public LifeStealerAssimilate Assimilate { get; }

        public LifeStealerAssimilateEject AssimilateEject { get; }

        public LifeStealerConsume Consume { get; }

        public LifeStealerControl Control { get; }

        public LifeStealerEmpty1 Empty1 { get; }

        public LifeStealerEmpty2 Empty2 { get; }

        public LifeStealerEmpty3 Empty3 { get; }

        public LifeStealerEmpty4 Empty4 { get; }

        public LifeStealerFeast Feast { get; }

        public IHeroComponent Hero { get; }

        public LifeStealerInfest Infest { get; }

        public LifeStealerOpenWounds OpenWounds { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public LifeStealerRage Rage { get; }
    }
}