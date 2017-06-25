// <copyright file="RazorStaticLink.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_razor
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.razor_static_link)]
    public class RazorStaticLink : IAbilityComponent
    {
        [ImportingConstructor]
        public RazorStaticLink([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.razor_static_link))
        {
        }

        public RazorStaticLink(IServiceContext context, IAbilityComponent ability)
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