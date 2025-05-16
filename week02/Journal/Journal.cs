using System;
using System.IO;
using System.Text.Json; 
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
        Console.WriteLine("Entry added!\n");
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.\n");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveToFile()
    {
        Console.Write("Enter filename to save journal: ");
        string filename = Console.ReadLine();
        string entryString = "";

        try
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (var entry in _entries)
                {
                    entryString = $"{entry._dateCreated}|{entry._prompt}|{entry._response}|{entry._status}";
                    outputFile.WriteLine(entryString);
                }
            }
            Console.WriteLine("Journal saved successfully.\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving file: {ex.Message}\n");
        }
    }

    public void LoadFromFile()
    {
        Console.Write("Enter filename to load journal: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.\n");
        }

        try
        {
            List<Entry> loadedEntries = new List<Entry>();
            foreach (var line in File.ReadAllLines(filename))
            {
                Entry entry = new Entry();
                var parts = line.Split('|');
                if (parts.Length == 4)
                {
                    entry._dateCreated = parts[0];
                    entry._prompt = parts[1];
                    entry._response = parts[2];
                    entry._status = parts[3];
                }
                if (entry != null)
                    loadedEntries.Add(entry);
            }
            _entries = loadedEntries;
            Console.WriteLine("Journal loaded successfully.\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}\n");
        }
    }

}
