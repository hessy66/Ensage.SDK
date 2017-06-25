// <copyright file="IChannableComponent.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Components
{
    public interface IChannableComponent
    {
        float Duration { get; }

        bool IsChanneling { get; }

        float RemainingDuration { get; }
    }
}