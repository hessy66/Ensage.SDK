// <copyright file="IAreaOfEffectComponent.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Components
{
    public interface IAreaOfEffectComponent : IRangedComponent
    {
        float Radius { get; }

        string RadiusName { get; }
    }
}