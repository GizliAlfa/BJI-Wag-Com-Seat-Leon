namespace VcdsHelper.Models;

/// <summary>
/// VCDS Parametresi
/// </summary>
public class VcdsParameter
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Module { get; set; } = string.Empty;
    public string BytePosition { get; set; } = string.Empty;
    public string BitPosition { get; set; } = string.Empty;
    public List<ParameterValue> Values { get; set; } = new();
    public string DefaultValue { get; set; } = string.Empty;
    public string RecommendedValue { get; set; } = string.Empty;
    public List<string> Notes { get; set; } = new();
    public bool RequiresHardware { get; set; }
    public bool IsUnsure { get; set; }
    public bool IsCritical { get; set; }
}

/// <summary>
/// Parametre değerleri
/// </summary>
public class ParameterValue
{
    public string Value { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public bool IsRecommended { get; set; }
    public bool RequiresHardware { get; set; }
    public string? HardwareRequired { get; set; }
}

/// <summary>
/// Leuchte (Işık) Kanalı
/// </summary>
public class LeuchteChannel
{
    public string Channel { get; set; } = string.Empty; // "Leuchte0"
    public string Name { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public string Function { get; set; } = string.Empty;
    public LeuchteSLH? SLH { get; set; }
    public LeuchteBLK? BLK { get; set; }
    public LeuchteDIM? DIM { get; set; }
    public bool IsStandardInStyle { get; set; }
    public bool IsOptional { get; set; }
}

public class LeuchteSLH
{
    public string DefaultValue { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string LampType { get; set; } = string.Empty; // "LED", "Halogen", "Xenon"
}

public class LeuchteBLK
{
    public string DefaultValue { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<BlinkMode> Modes { get; set; } = new();
}

public class BlinkMode
{
    public string Code { get; set; } = string.Empty; // "BLK0", "BLK2", etc.
    public string Name { get; set; } = string.Empty;
    public string Behavior { get; set; } = string.Empty;
    public string Usage { get; set; } = string.Empty;
}

public class LeuchteDIM
{
    public string DefaultValue { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<DimLevel> Levels { get; set; } = new();
}

public class DimLevel
{
    public string Code { get; set; } = string.Empty; // "DIM0", "DIM10", etc.
    public string Brightness { get; set; } = string.Empty;
    public string Percentage { get; set; } = string.Empty;
    public string Usage { get; set; } = string.Empty;
}

/// <summary>
/// Kodlama Tarifi
/// </summary>
public class CodingRecipe
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Module { get; set; } = string.Empty;
    public List<CodingStep> Steps { get; set; } = new();
    public List<string> Warnings { get; set; } = new();
    public bool RequiresHardware { get; set; }
    public string? HardwareRequired { get; set; }
    public DifficultyLevel Difficulty { get; set; }
}

public class CodingStep
{
    public string Parameter { get; set; } = string.Empty;
    public string DefaultValue { get; set; } = string.Empty;
    public string NewValue { get; set; } = string.Empty;
    public string Explanation { get; set; } = string.Empty;
}

public enum DifficultyLevel
{
    Easy,       // Kolay - Güvenle yapılabilir
    Medium,     // Orta - Dikkatli olunmalı
    Hard,       // Zor - Deneyim gerekli
    Expert      // Uzman - Donanım gerekli
}

/// <summary>
/// Kategori
/// </summary>
public class ParameterCategory
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public int Order { get; set; }
}
