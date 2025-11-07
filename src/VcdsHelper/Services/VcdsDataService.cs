using Newtonsoft.Json;
using VcdsHelper.Models;
using System.Reflection;

namespace VcdsHelper.Services;

/// <summary>
/// VCDS veritabanı servisi - Embedded resources'dan veri yükler
/// </summary>
public class VcdsDataService
{
    private readonly Assembly _assembly;
    private List<VcdsParameter>? _parameters;
    private List<LeuchteChannel>? _leuchteChannels;
    private List<CodingRecipe>? _codingRecipes;
    private List<ParameterCategory>? _categories;

    public VcdsDataService()
    {
        _assembly = Assembly.GetExecutingAssembly();
    }

    /// <summary>
    /// Embedded resource'dan JSON dosyasını okur
    /// </summary>
    private string ReadEmbeddedResource(string fileName)
    {
        var resourceName = $"VcdsHelper.Data.{fileName}";
        
        using (var stream = _assembly.GetManifestResourceStream(resourceName))
        {
            if (stream == null)
            {
                throw new FileNotFoundException($"Embedded resource '{resourceName}' bulunamadı!");
            }
            
            using (var reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }

    /// <summary>
    /// Tüm parametreleri yükle
    /// </summary>
    public List<VcdsParameter> GetParameters()
    {
        if (_parameters != null) return _parameters;

        try
        {
            var json = ReadEmbeddedResource("parameters.json");
            _parameters = JsonConvert.DeserializeObject<List<VcdsParameter>>(json) ?? new List<VcdsParameter>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Parametre yükleme hatası: {ex.Message}");
            _parameters = new List<VcdsParameter>();
        }

        return _parameters;
    }

    /// <summary>
    /// Leuchte kanallarını yükle
    /// </summary>
    public List<LeuchteChannel> GetLeuchteChannels()
    {
        if (_leuchteChannels != null) return _leuchteChannels;

        try
        {
            var json = ReadEmbeddedResource("leuchte.json");
            _leuchteChannels = JsonConvert.DeserializeObject<List<LeuchteChannel>>(json) ?? new List<LeuchteChannel>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Leuchte yükleme hatası: {ex.Message}");
            _leuchteChannels = new List<LeuchteChannel>();
        }

        return _leuchteChannels;
    }

    /// <summary>
    /// Kodlama tariflerini yükle
    /// </summary>
    public List<CodingRecipe> GetCodingRecipes()
    {
        if (_codingRecipes != null) return _codingRecipes;

        try
        {
            var json = ReadEmbeddedResource("recipes.json");
            _codingRecipes = JsonConvert.DeserializeObject<List<CodingRecipe>>(json) ?? new List<CodingRecipe>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Kodlama tarifleri yükleme hatası: {ex.Message}");
            _codingRecipes = new List<CodingRecipe>();
        }

        return _codingRecipes;
    }

    /// <summary>
    /// Kategorileri yükle
    /// </summary>
    public List<ParameterCategory> GetCategories()
    {
        if (_categories != null) return _categories;

        try
        {
            var json = ReadEmbeddedResource("categories.json");
            _categories = JsonConvert.DeserializeObject<List<ParameterCategory>>(json) ?? new List<ParameterCategory>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Kategori yükleme hatası: {ex.Message}");
            _categories = new List<ParameterCategory>();
        }

        return _categories.OrderBy(c => c.Order).ToList();
    }

    /// <summary>
    /// Kategoriye göre parametreleri getir
    /// </summary>
    public List<VcdsParameter> GetParametersByCategory(string category)
    {
        return GetParameters().Where(p => p.Category == category).ToList();
    }

    /// <summary>
    /// Modüle göre parametreleri getir
    /// </summary>
    public List<VcdsParameter> GetParametersByModule(string module)
    {
        return GetParameters().Where(p => p.Module == module).ToList();
    }

    /// <summary>
    /// Parametre ara
    /// </summary>
    public List<VcdsParameter> SearchParameters(string query)
    {
        query = query.ToLowerInvariant();
        return GetParameters()
            .Where(p => 
                p.Name.ToLowerInvariant().Contains(query) ||
                p.Description.ToLowerInvariant().Contains(query) ||
                p.Category.ToLowerInvariant().Contains(query))
            .ToList();
    }

    /// <summary>
    /// Leuchte kanalı ara
    /// </summary>
    public LeuchteChannel? GetLeuchteChannel(string channel)
    {
        return GetLeuchteChannels().FirstOrDefault(l => l.Channel.Equals(channel, StringComparison.OrdinalIgnoreCase));
    }

    /// <summary>
    /// Kodlama tarifi ara
    /// </summary>
    public CodingRecipe? GetCodingRecipe(string id)
    {
        return GetCodingRecipes().FirstOrDefault(r => r.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
    }

    /// <summary>
    /// Kategoriye göre kodlama tarifleri
    /// </summary>
    public List<CodingRecipe> GetRecipesByCategory(string category)
    {
        return GetCodingRecipes().Where(r => r.Category == category).ToList();
    }
}
