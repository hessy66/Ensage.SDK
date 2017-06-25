// <copyright file="InvokerEmpty2.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_invoker
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.invoker_empty2)]
    public class InvokerEmpty2 : IAbilityComponent
    {
        [ImportingConstructor]
        public InvokerEmpty2([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.invoker_empty2))
        {
        }

        public InvokerEmpty2(IServiceContext context, IAbilityComponent ability)
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