using System;
using System.Collections.Generic;
using UnityEngine;

namespace Holylib.DebugConsole {

    // This is a template for adding more categories 
public static partial class HolyDebugGroupStyles {
    
    public const string Uncategorized = "Uncategorized";
    [DebugCommandGroup(Uncategorized)] public static readonly DebugGroupStyle UncategorizedStyle 
        = new DebugGroupStyle("❔ Uncategorized", Color.white);
    
    public const string SaveSytem = "Save System 💾";
    [DebugCommandGroup(SaveSytem)] public static readonly DebugGroupStyle SaveSystemStyle 
        = new DebugGroupStyle("Save System", new Color(0.39f, 0.35f, 0.58f));
    
    public const string Enemy = "Enemy 👾";
    [DebugCommandGroup(Enemy)] public static readonly DebugGroupStyle EnemyStyle 
        = new DebugGroupStyle("Enemy", new Color(0.8f, 0.2f, 0.2f));
    
    public const string Tower = "Tower 🗼";
    [DebugCommandGroup(Tower)] public static readonly DebugGroupStyle TowerStyle 
        = new DebugGroupStyle("Tower", new Color(0.2f, 0.6f, 0.8f));

    public const string Loot = "Loot 💰";
    [DebugCommandGroup(Loot)] public static readonly DebugGroupStyle LootStyle 
        = new DebugGroupStyle("Loot", new Color(1f, 0.84f, 0f));
}

public readonly struct DebugGroupStyle : IEquatable<DebugGroupStyle>
{
    public readonly string Name;
    public readonly Color Color;

    public DebugGroupStyle(string name, Color color)
    {
        Name = name;
        Color = color;
    }

    public bool Equals(DebugGroupStyle other)
    {
        return Name == other.Name && Color.Equals(other.Color);
    }

    public override bool Equals(object obj)
    {
        return obj is DebugGroupStyle other && Equals(other);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Color);
    }
}

[Flags]
public enum HolyLogType {
    None    = 0,
    Log    = 1 << 0,
    Warning = 1 << 1,
    Error   = 1 << 2,
    Assert  = 1 << 3,
    Exception = 1 << 4,
}

}