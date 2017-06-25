// <copyright file="NagaSirenSongOfTheSiren.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_naga_siren
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.naga_siren_song_of_the_siren)]
    public class NagaSirenSongOfTheSiren : IAbilityComponent
    {
        [ImportingConstructor]
        public NagaSirenSongOfTheSiren([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.naga_siren_song_of_the_siren))
        {
        }

        public NagaSirenSongOfTheSiren(IServiceContext context, IAbilityComponent ability)
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