// <copyright file="QueenofpainSonicWave.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_queenofpain
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.queenofpain_sonic_wave)]
    public class QueenofpainSonicWave : IAbilityComponent
    {
        [ImportingConstructor]
        public QueenofpainSonicWave([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.queenofpain_sonic_wave))
        {
        }

        public QueenofpainSonicWave(IServiceContext context, IAbilityComponent ability)
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