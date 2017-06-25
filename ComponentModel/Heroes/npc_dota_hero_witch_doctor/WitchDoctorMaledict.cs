// <copyright file="WitchDoctorMaledict.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_witch_doctor
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.witch_doctor_maledict)]
    public class WitchDoctorMaledict : IAbilityComponent
    {
        [ImportingConstructor]
        public WitchDoctorMaledict([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.witch_doctor_maledict))
        {
        }

        public WitchDoctorMaledict(IServiceContext context, IAbilityComponent ability)
        {
            this.Context = context;
            this.Ability = ability;
        }

        public IAbilityComponent Ability { get; }

        public IServiceContext Context { get; }

        public Ability Instance
        {
            get
            {
                return this.Ability.Instance;
            }
        }
    }
}