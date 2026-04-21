using System.Globalization;

namespace RustRcon.Types;
// ReSharper disable InconsistentNaming
// Minimal Unity type stubs so that generated DTOs containing Unity structs compile
// without referencing the full UnityEngine assembly. These types are used only for
// JSON deserialization of RCON responses; they are NOT real Unity implementations.

/// <summary>Minimal shim for <c>UnityEngine.Vector3</c> used in generated RCON DTOs.</summary>
public struct Vector3
{
    public float x;
    public float y;
    public float z;

    public Vector3(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public override string ToString() => string.Format(CultureInfo.InvariantCulture, "({0}, {1}, {2})", x, y, z);
}

/// <summary>Minimal shim for <c>UnityEngine.Quaternion</c>.</summary>
public struct Quaternion
{
    public float x;
    public float y;
    public float z;
    public float w;
}

/// <summary>Minimal shim for <c>UnityEngine.Color</c>.</summary>
public struct Color
{
    public float r;
    public float g;
    public float b;
    public float a;
}

/// <summary>Minimal shim for <c>UnityEngine.Color32</c>.</summary>
public struct Color32
{
    public byte r;
    public byte g;
    public byte b;
    public byte a;
}