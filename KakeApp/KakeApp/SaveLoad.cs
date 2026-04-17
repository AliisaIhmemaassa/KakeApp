using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace KakeForm
{
    public class SaveLoad
    {
		static readonly string folder = AppContext.BaseDirectory;

		private static readonly JsonSerializerOptions Options = new JsonSerializerOptions
		{
			WriteIndented = true
		};

		public static bool SaveToJson<T>(T data, string filename)
		{
			string path = Path.Combine(folder, filename);
			try
			{
				// Serialize first (catches circular refs, invalid types)
				string json = JsonSerializer.Serialize(data, Options);

				// Ensure directory exists
				Directory.CreateDirectory(Path.GetDirectoryName(path)!);

				File.WriteAllText(path, json);
				return true;
			}
			catch (JsonException ex)
			{
				Console.WriteLine($"JSON serialization failed for {filename}: {ex.Message}");
				return false;
			}
			catch (UnauthorizedAccessException ex)
			{
				Console.WriteLine($"Permission denied saving {filename}: {ex.Message}");
				return false;
			}
			catch (IOException ex)
			{
				Console.WriteLine($"IO error saving {filename}: {ex.Message}");
				return false;
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Unexpected error saving {filename}: {ex.Message}");
				return false;
			}
		}


		public static T? LoadFromJson<T>(string filename) where T : class
		{
			string path = Path.Combine(folder, filename);
			try
			{
				if (!File.Exists(path))
					throw new FileNotFoundException($"File not found: {path}");

				string json = File.ReadAllText(path);
				return JsonSerializer.Deserialize<T>(json, Options);
			}
			catch (FileNotFoundException ex)
			{
				Console.WriteLine($"File error: {ex.Message}");
				return null;
			}
			catch (JsonException ex)
			{
				Console.WriteLine($"JSON error in {filename}: {ex.Message}");
				return null;
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Unexpected error loading {filename}: {ex.Message}");
				return null;
			}
			finally
			{
				Console.WriteLine("Load attempt done");  // Fixed "sage"
			}
		}
	}

}