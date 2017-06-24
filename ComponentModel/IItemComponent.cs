// <copyright file="IItemBase.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel
{
    public interface IItemComponent
    {
        AbilityId Id { get; }

        Item[] Instances { get; }
    }

    public interface IAbility
    {
        AbilityId Id { get; }

        Ability[] Instances { get; }
    }

    public interface IHeroComponent
    {
        Hero Owner { get; }
    }
}