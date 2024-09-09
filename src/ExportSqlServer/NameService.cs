using Finder.Data;
using Microsoft.Extensions.Options;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace Finder;

public class NameService
{
    private static readonly object _sync = new();
    private static HashSet<string>? _femalenames;
    private static HashSet<string>? _malenames;
    private static HashSet<string>? _malesurnames;

    private readonly HashSet<string> _firstnames = new();
    private readonly HashSet<string> _middlenames = new();
    private readonly HashSet<string> _surnames = new();
    private static readonly char[] _nameseparators = [' ', '\t', '\n', '\r'];

    private NameServiceData? _data;

    public NameService(IOptions<ApplicationOptions> options, PersonalDataService personalDataService)
    {
        ApplicationOptions = options.Value;
        PersonalDataService = personalDataService;
    }

    private PersonalDataService PersonalDataService { get; }

    public NameServiceData? Data => _data;

    public static HashSet<string> MaleSurnames
    {
        get
        {
            if (_malesurnames is null)
            {
                lock (_sync)
                {
                    if (_malesurnames is null)
                    {
                        _malesurnames = LoadNames("male_surnames_rus.txt");
                    }
                }
            }
            return _malesurnames;
        }
    }

    public static HashSet<string> FemaleNames
    {
        get
        {
            if (_femalenames is null)
            {
                lock (_sync)
                {
                    if (_femalenames is null)
                    {
                        _femalenames = LoadNames("female_names_rus.txt");
                    }
                }
            }
            return _femalenames;
        }
    }

    public static HashSet<string> MaleNames
    {
        get
        {
            if (_malenames is null)
            {
                lock (_sync)
                {
                    if (_malenames is null)
                    {
                        _malenames = LoadNames("male_names_rus.txt");
                    }
                }
            }
            return _malenames;
        }
    }

    private static HashSet<string> LoadNames(string resourceName)
    {
        using Stream? stream = typeof(DataResources).Assembly.GetManifestResourceStream(typeof(DataResources), resourceName);
        if (stream == null)
        {
            throw new InvalidOperationException($"cannot load {resourceName}");
        }
        TextReader reader = new StreamReader(stream);
        HashSet<string> result = new();
        string? text;
        while ((text = reader.ReadLine()) is not null)
        {
            result.Add(text);
        }
        return result;
    }

    private ApplicationOptions ApplicationOptions { get; }

    public void ParseAndSave()
    {
        HashSet<string> fullNames = PersonalDataService.LoadFullNames();
        Console.WriteLine("Fullnames loaded successfully");

        HashSet<string>[] names = new HashSet<string>[3];
        int surnameOrdinal;
        int firstnameOrdinal;
        int middlenameOrdinal;
        switch (ApplicationOptions.FullNameOrder)
        {
            case FullNameOrder.SFM:
                names[0] = _surnames;
                names[1] = _firstnames;
                names[2] = _middlenames;
                surnameOrdinal = 0;
                firstnameOrdinal = 1;
                middlenameOrdinal = 2;
                break;
            case FullNameOrder.FMS:
                names[0] = _firstnames;
                names[1] = _middlenames;
                names[2] = _surnames;
                firstnameOrdinal = 0;
                middlenameOrdinal = 1;
                surnameOrdinal = 2;
                break;
            default:
                throw new InvalidOperationException($"unsupported full name order: {ApplicationOptions.FullNameOrder}");
        }
        Console.WriteLine($"Splitting fullnames: {ApplicationOptions.FullNameOrder}");
        List<FullNameEntry> fullNameEntries = new();
        foreach (string fullName in fullNames)
        {
            string[] parts = fullName.Split(_nameseparators, StringSplitOptions.TrimEntries);
            if (parts.Length == 0)
            {
                continue;
            }

            if (parts.Length >= 1)
            {
                names[0].Add(parts[0]);
            }
            if (parts.Length >= 2)
            {
                names[1].Add(parts[1]);
            }
            if (parts.Length >= 3)
            {
                names[2].Add(parts[2]);
            }
            Gender gender = Gender.Unknown;
            if (parts.Length > firstnameOrdinal && MaleNames.Contains(parts[firstnameOrdinal]))
            {
                gender = Gender.Male;
            }
            else if (parts.Length > firstnameOrdinal && FemaleNames.Contains(parts[firstnameOrdinal]))
            {
                gender = Gender.Female;
            }
            else if (parts.Length > surnameOrdinal && MaleSurnames.Contains(parts[surnameOrdinal]))
            {
                gender = Gender.Male;
            }
            FullNameEntry entry = new FullNameEntry()
            {
                FullName = fullName,
                FirstName = parts.Length > firstnameOrdinal ? parts[firstnameOrdinal] : default,
                MiddleName = parts.Length > middlenameOrdinal ? parts[middlenameOrdinal] : default,
                Surname = parts.Length > surnameOrdinal ? parts[surnameOrdinal] : default,
                Gender = gender,
            };
            fullNameEntries.Add(entry);
        }
        Console.WriteLine($"Saving names to file: {ApplicationOptions.NamesFileName}");
        NameServiceData data = new();
        data.Entries = fullNameEntries.OrderBy(t => t.FullName).ToList();
        data.FirstNames = data.Entries
            .Where(t => t.FirstName != null)
            .Select(t => t.FirstName!).Union(MaleNames).Union(FemaleNames)
            .ToHashSet(StringComparer.CurrentCultureIgnoreCase)
            .OrderBy(t => t).ToList();
        data.MiddleNames = data.Entries
            .Where(t => t.MiddleName != null)
            .Select(t => t.MiddleName!)
            .ToHashSet(StringComparer.CurrentCultureIgnoreCase)
            .OrderBy(t => t).ToList();
        data.Surnames = data.Entries
            .Where(t => t.Surname != null)
            .Select(t => t.Surname!).Union(MaleSurnames)
            .ToHashSet(StringComparer.CurrentCultureIgnoreCase)
            .OrderBy(t => t).ToList();

        using FileStream file = File.Create(ApplicationOptions.NamesFileName);
        JsonSerializer.Serialize(file, data, new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
            WriteIndented = true,
        });
        using FileStream file1 = File.Create(ApplicationOptions.SubstitutionsFileName);
        List<KeyValuePair<string, string>> allNames = data.GetAllNames().OrderBy(t => t.Key).ToList();
        JsonSerializer.Serialize(file1, allNames, new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
            WriteIndented = true,
        });
        _data = data;
    }
}
