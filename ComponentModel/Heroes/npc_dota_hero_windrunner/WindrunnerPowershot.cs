// <copyright file="WindrunnerPowershot.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_windrunner
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.windrunner_powershot)]
    public class WindrunnerPowershot : IAbilityComponent
    {
        [ImportingConstructor]
        public WindrunnerPowershot([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.windrunner_powershot))
        {
        }

        public WindrunnerPowershot(IServiceContext context, IAbilityComponent ability)
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