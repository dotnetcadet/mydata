﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System;

public record Either<T1, T2> : IEither
{
    #region Implicit Conversion From Value
    public static implicit operator Either<T1, T2>(T1 value) => new Either<T1, T2>(value);
    public static implicit operator Either<T1, T2>(T2 value) => new Either<T1, T2>(value);
    #endregion Implicit Conversion From Value

    #region Implicit Conversion By Type Swap
    public static implicit operator Either<T1, T2>(Either<T2, T1> other)
    {
        int[] map = new[] { 2, 1 };
        return new Either<T1, T2>(map[other._typeIndex - 1], other._value);
    }
    #endregion Implicit Conversion By Type Swap

    #region Implicit Widening Conversions
    #endregion Implicit Widening Conversions

    #region Constructors
    public Either(T1 value) { _value = value; _typeIndex = 1; }
    public Either(T2 value) { _value = value; _typeIndex = 2; }
    #endregion Constructors

    #region Or methods
    public Either<T1, T2, T3> Or<T3>() => this
        .Match((T1 v1) => new Either<T1, T2, T3>(v1))
        .Match((T2 v2) => new Either<T1, T2, T3>(v2));
    public Either<T1, T2, T3, T4> Or<T3, T4>() => this
        .Match((T1 v1) => new Either<T1, T2, T3, T4>(v1))
        .Match((T2 v2) => new Either<T1, T2, T3, T4>(v2));
    public Either<T1, T2, T3, T4, T5> Or<T3, T4, T5>() => this
        .Match((T1 v1) => new Either<T1, T2, T3, T4, T5>(v1))
        .Match((T2 v2) => new Either<T1, T2, T3, T4, T5>(v2));
    #endregion Or methods

    #region IEither Implementation
    int _typeIndex;
    object? _value;

    int IEither.TypeIndex => _typeIndex;

    Type IEither.Type => _typeIndex switch
    {
        1 => typeof(T1),
        2 => typeof(T2),
        _ => throw new InvalidOperationException()
    };

    object IEither.Value => _value;

    Either(int typeIndex, object value) => (_typeIndex, _value) = (typeIndex, value);
    #endregion IEither Implementation

    #region Value Casts
    T1 AsT1 => (T1)_value;
    T2 AsT2 => (T2)_value;
    #endregion Value Casts

    #region Explicit Casts
    public static explicit operator T1(Either<T1, T2> either) => either.AsT1;
    public static explicit operator T2(Either<T1, T2> either) => either.AsT2;
    #endregion Explicit Casts

    #region Switch method
    public void Switch(Action<T1> ifT1, Action<T2> ifT2)
    {
        switch (_typeIndex)
        {
            case 1: ifT1(AsT1); break;
            case 2: ifT2(AsT2); break;
            default: throw new InvalidOperationException();
        }
    }
    #endregion Switch method

    #region Nonreductive Match
    public Either<TResult1, T2> Match<TResult1>(Func<T1, TResult1> ifT1) => _typeIndex switch
    {
        1 => ifT1(AsT1),
        2 => AsT2,
        _ => throw new InvalidOperationException()
    };
    public Either<T1, T2, TResult1> Match<TResult1>
        (Func<T1, TResult1> ifT1, Func<T1, bool> when) => _typeIndex switch
        {
            1 when (when(AsT1)) => ifT1(AsT1),
            2 => AsT2,
            1 => AsT1,
            _ => throw new InvalidOperationException()
        };
    public Either<T1, TResult2> Match<TResult2>(Func<T2, TResult2> ifT2) => _typeIndex switch
    {
        1 => AsT1,
        2 => ifT2(AsT2),
        _ => throw new InvalidOperationException()
    };
    public Either<T1, T2, TResult2> Match<TResult2>
        (Func<T2, TResult2> ifT2, Func<T2, bool> when) => _typeIndex switch
        {
            1 => AsT1,
            2 when (when(AsT2)) => ifT2(AsT2),
            2 => AsT2,
            _ => throw new InvalidOperationException()
        };
    #endregion Nonreductive Match

    #region Nonreductive Match - Compositional
    public Either<TResult1, T2> Match<TResult1>(Func<T1, Either<TResult1, T2>> ifT1) => _typeIndex switch
    {
        1 => ifT1(AsT1),
        2 => AsT2,
        _ => throw new InvalidOperationException()
    };
    public Either<T1, T2, TResult1> Match<TResult1>
        (Func<T1, Either<T1, T2, TResult1>> ifT1, Func<T1, bool> when) => _typeIndex switch
        {
            1 when (when(AsT1)) => ifT1(AsT1),
            2 => AsT2,
            1 => AsT1,
            _ => throw new InvalidOperationException()
        };
    public Either<T1, TResult2> Match<TResult2>(Func<T2, Either<T1, TResult2>> ifT2) => _typeIndex switch
    {
        1 => AsT1,
        2 => ifT2(AsT2),
        _ => throw new InvalidOperationException()
    };
    public Either<T1, T2, TResult2> Match<TResult2>
        (Func<T2, Either<T1, T2, TResult2>> ifT2, Func<T2, bool> when) => _typeIndex switch
        {
            1 => AsT1,
            2 when (when(AsT2)) => ifT2(AsT2),
            2 => AsT2,
            _ => throw new InvalidOperationException()
        };
    #endregion Nonreductive Match - Compositional

    #region Reductive Match
    public T2 Match
        (Func<T1, T2> ifT1) => _typeIndex switch
        {
            1 => ifT1(AsT1),
            2 => AsT2,
            _ => throw new InvalidOperationException()
        };
    public Either<T1, T2> Match
        (Func<T1, T2> ifT1, Func<T1, bool> when) => _typeIndex switch
        {
            1 when (when(AsT1)) => ifT1(AsT1),
            2 => AsT2,
            1 => AsT1,
            _ => throw new InvalidOperationException()
        };
    public T1 Match
        (Func<T2, T1> ifT2) => _typeIndex switch
        {
            1 => AsT1,
            2 => ifT2(AsT2),
            _ => throw new InvalidOperationException()
        };
    public Either<T1, T2> Match
        (Func<T2, T1> ifT2, Func<T2, bool> when) => _typeIndex switch
        {
            1 => AsT1,
            2 when (when(AsT2)) => ifT2(AsT2),
            2 => AsT2,
            _ => throw new InvalidOperationException()
        };
    #endregion Reductive Match

    #region Throw Methods
    public T2 ThrowIf
        (Func<T1, Exception> ifT1) => _typeIndex switch
        {
            1 => throw ifT1(AsT1),
            2 => AsT2,
            _ => throw new InvalidOperationException()
        };
    public Either<T1, T2> ThrowIf
        (Func<T1, Exception> ifT1, Func<T1, bool> when) => _typeIndex switch
        {
            1 when (when(AsT1)) => throw ifT1(AsT1),
            2 => AsT2,
            1 => AsT1,
            _ => throw new InvalidOperationException()
        };
    public T1 ThrowIf
        (Func<T2, Exception> ifT2) => _typeIndex switch
        {
            1 => AsT1,
            2 => throw ifT2(AsT2),
            _ => throw new InvalidOperationException()
        };
    public Either<T1, T2> ThrowIf
        (Func<T2, Exception> ifT2, Func<T2, bool> when) => _typeIndex switch
        {
            1 => AsT1,
            2 when (when(AsT2)) => throw ifT2(AsT2),
            2 => AsT2,
            _ => throw new InvalidOperationException()
        };
    #endregion Throw Methods

    #region If (methods)
    public bool If(out T1 @if) => If(out @if, out _);
    public bool If(out T1 @if, out T2 @else)
    {
        switch (_typeIndex)
        {
            case 1:
                @if = AsT1;
                @else = default!;
                return true;
            case 2:
                @if = default!;
                @else = AsT2;
                return false;
            default:
                throw new InvalidOperationException();
        }
    }
    public bool If(out T2 @if) => If(out @if, out _);
    public bool If(out T2 @if, out T1 @else)
    {
        switch (_typeIndex)
        {
            case 1:
                @if = default;
                @else = AsT1;
                return false;
            case 2:
                @if = AsT2;
                @else = default;
                return true;
            default:
                throw new InvalidOperationException();
        }
    }
    #endregion If (methods)

    #region ToString
    public override string ToString() => $"{((IEither)this).Type.Name}:{_value}";

    // For LINQPad:
    object ToDump() => new { Type = ((IEither)this).Type, Value = ((IEither)this).Value };
    #endregion ToString
}