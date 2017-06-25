// <copyright file="IEntityComponent.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Components
{
    public interface IEntityComponent<out T>
        where T : Entity
    {
        T Instance { get; }
    }
}