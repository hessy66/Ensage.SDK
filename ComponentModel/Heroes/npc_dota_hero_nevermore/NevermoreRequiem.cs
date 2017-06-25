// <copyright file="NevermoreRequiem.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_nevermore
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.nevermore_requiem)]
    public class NevermoreRequiem : IAbilityComponent
    {
        [ImportingConstructor]
        public NevermoreRequiem([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.nevermore_requiem))
        {
        }

        public NevermoreRequiem(IServiceContext context, IAbilityComponent ability)
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