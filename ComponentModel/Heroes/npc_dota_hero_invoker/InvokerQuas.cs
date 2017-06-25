// <copyright file="InvokerQuas.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_invoker
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.invoker_quas)]
    public class InvokerQuas : IAbilityComponent
    {
        [ImportingConstructor]
        public InvokerQuas([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.invoker_quas))
        {
        }

        public InvokerQuas(IServiceContext context, IAbilityComponent ability)
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