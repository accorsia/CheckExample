using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

public class CSVCore
{
    public CSVCore()
    {
    }

    public static List<string> ReadCSV(string path, string delimiter, bool hasHeader, int colNumber)
    {
        //  Parametric configuration of csv file (elements of Form)
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = delimiter.Trim(),
            HasHeaderRecord = hasHeader
        };

        //  CSV readers
        var reader = new StreamReader(path);
        var csv = new CsvReader(reader, config);

        //  Read the header to get column names
        csv.Read();
        csv.ReadHeader();
        List<string> headers = csv.HeaderRecord.ToList();
        string selectedColumn = headers[colNumber];

        //  Read all records as dynamic object
        var records = csv.GetRecords<dynamic>().ToList();

        List<string> recordList = [];
        foreach (var record in records)
        {
            /*string nameFromPath = record.PercorsoFile;

            //  Extract zip number from current record
            Match match = Regex.Match(record.ZipFile, @"-(\d+)\.zip$");
            string zipNumber = match.Groups[1].Value;

            recordList.Add($"{nameFromPath} - {zipNumber}");*/

            //  Convert each record into Dictionary - then select the right column
            var recordDict = record as IDictionary<string, object>;
            if (recordDict != null && recordDict.ContainsKey(selectedColumn))
            {
                recordList.Add(recordDict[selectedColumn].ToString());
            }
        }

        return recordList;
    }

    /*public static (Dictionary<string, int>, int) NumFilesXZip(List<string> recordList, bool output = false)
    {
        Dictionary<string, int> countsForZip = [];

        foreach (var record in recordList)
        {
            string zipNumber = record.Split('-')[^1];

            //  Counter (NumberOfFiles X Zip) += 1
            if (countsForZip.ContainsKey(zipNumber))
                countsForZip[zipNumber]++;
            else
                countsForZip[zipNumber] = 1;
        }

        //  Output
        if (output)
        {
            foreach (var entry in countsForZip)
                Console.WriteLine($"Zip: {entry.Key} -> {entry.Value} files");
        }

        int biggestZipNumber = countsForZip.Keys.Select(int.Parse).Max();   // select all keys (zip numbers) -> convert them in int --> select biggest value

        return (countsForZip, biggestZipNumber);
    }

    public static List<string> ExtractRecordsOfZip(List<string> recordList, string selectedZip = "12", bool output = false)
    {
        List<string> recordsOfZip = [];

        foreach (var record in recordList)
        {
            string zipNumber = record.Split('-')[^1];

            //  File of zip we are extracting for
            if (zipNumber.Trim() == selectedZip)
            {
                recordsOfZip.Add(record.Replace($" - {zipNumber}", ""));
            }
        }

        //  Output
        if (output)
        {
            Console.WriteLine($"Number of files in zip {selectedZip}:\t{recordsOfZip.Count}");
        }

        return recordsOfZip;
    }

    private static int NumDuplicatesInList(List<string> records, bool output = false)
    {
        List<string> noDuplicatesRecords = records.Distinct().ToList();
        int diff = records.Count - noDuplicatesRecords.Count;

        // Output   
        if (output)
        {
            Console.WriteLine("* # of record in List:\t\t\t" + records.Count);
            Console.WriteLine("* # of record in List.Distinct():\t" + noDuplicatesRecords.Count + "\n");

            if (diff > 0)
                Console.WriteLine($"--> TRUE: {diff} duplicates found");
            else
                Console.WriteLine("--> FALSE: No duplicates found");
        }


        return diff;
    }*/

    /*
     * -- Benchmark ---
     * medium.csv: 63749 records --> 38s
     */
    public static Dictionary<string, string> GetDuplicatesFromList(List<string> list)
    {
        var duplicateXCount = new Dictionary<string, string>();
        List<string> seenItems = [];

        for (int i = 0; i < list.Count; i++)
        {
            string currentItem = list[i];

            //  Item already seen
            if (seenItems.Contains(currentItem))
            {
                //  Add repetition: concatenate index to string
                if (duplicateXCount.ContainsKey(currentItem))
                    duplicateXCount[currentItem] += $", {i}";

                //  First repetition: create entry in return Dictionary
                else
                    duplicateXCount[currentItem] = i.ToString();
            }
            //  Never seen before
            else
            {
                seenItems.Add(currentItem);
            }
        }

        return duplicateXCount;
    }


    public void RemoveSharedPrexis(ref List<string> recordList)
    {
        Console.WriteLine("TODO");
    }


}
