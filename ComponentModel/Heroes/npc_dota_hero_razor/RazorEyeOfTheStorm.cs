// <copyright file="RazorEyeOfTheStorm.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_razor
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.razor_eye_of_the_storm)]
    public class RazorEyeOfTheStorm : IAbilityComponent
    {
        [ImportingConstructor]
        public RazorEyeOfTheStorm([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.razor_eye_of_the_storm))
        {
        }

        public RazorEyeOfTheStorm(IServiceContext context, IAbilityComponent ability)
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