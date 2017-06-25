// <copyright file="InvokerEmpty1.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_invoker
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.invoker_empty1)]
    public class InvokerEmpty1 : IAbilityComponent
    {
        [ImportingConstructor]
        public InvokerEmpty1([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.invoker_empty1))
        {
        }

        public InvokerEmpty1(IServiceContext context, IAbilityComponent ability)
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