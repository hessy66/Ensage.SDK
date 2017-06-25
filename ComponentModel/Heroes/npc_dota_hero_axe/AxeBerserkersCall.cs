// <copyright file="AxeBerserkersCall.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_axe
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.axe_berserkers_call)]
    public class AxeBerserkersCall : IAbilityComponent
    {
        [ImportingConstructor]
        public AxeBerserkersCall([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.axe_berserkers_call))
        {
        }

        public AxeBerserkersCall(IServiceContext context, IAbilityComponent ability)
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