// <copyright file="WitchDoctorVoodooRestoration.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_witch_doctor
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.witch_doctor_voodoo_restoration)]
    public class WitchDoctorVoodooRestoration : IAbilityComponent
    {
        [ImportingConstructor]
        public WitchDoctorVoodooRestoration([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.witch_doctor_voodoo_restoration))
        {
        }

        public WitchDoctorVoodooRestoration(IServiceContext context, IAbilityComponent ability)
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