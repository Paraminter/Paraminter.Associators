﻿namespace Paraminter.Commands;

using Paraminter.Arguments.Models;
using Paraminter.Cqs;
using Paraminter.Parameters.Models;

/// <summary>Represents a command to associate an argument with a parameter.</summary>
/// <typeparam name="TParameter">The type representing the parameters.</typeparam>
/// <typeparam name="TArgumentData">The type representing data about the arguments.</typeparam>
public interface IAssociateIndividualArgumentCommand<out TParameter, out TArgumentData>
    : ICommand
    where TParameter : IParameter
    where TArgumentData : IArgumentData
{
    /// <summary>The parameter.</summary>
    public abstract TParameter Parameter { get; }

    /// <summary>Data about the argument.</summary>
    public abstract TArgumentData ArgumentData { get; }
}
