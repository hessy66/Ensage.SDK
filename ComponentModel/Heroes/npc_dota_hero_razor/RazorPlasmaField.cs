// <copyright file="RazorPlasmaField.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_razor
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.razor_plasma_field)]
    public class RazorPlasmaField : IAbilityComponent
    {
        [ImportingConstructor]
        public RazorPlasmaField([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.razor_plasma_field))
        {
        }

        public RazorPlasmaField(IServiceContext context, IAbilityComponent ability)
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