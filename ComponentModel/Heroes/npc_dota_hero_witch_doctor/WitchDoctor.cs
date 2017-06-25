// <copyright file="WitchDoctor.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_witch_doctor
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_witch_doctor)]
    public class WitchDoctor : IHeroComponent
    {
        [ImportingConstructor]
        public WitchDoctor([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public WitchDoctor(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.ParalyzingCask = new WitchDoctorParalyzingCask(context);
            this.VoodooRestoration = new WitchDoctorVoodooRestoration(context);
            this.Maledict = new WitchDoctorMaledict(context);
            this.DeathWard = new WitchDoctorDeathWard(context);
        }

        public WitchDoctorDeathWard DeathWard { get; }

        public IHeroComponent Hero { get; }

        public WitchDoctorMaledict Maledict { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public WitchDoctorParalyzingCask ParalyzingCask { get; }

        public WitchDoctorVoodooRestoration VoodooRestoration { get; }
    }
}