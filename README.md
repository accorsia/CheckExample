# CheckDuplicatesInCSV

Questo progetto fornisce un'applicazione Windows Form per leggere un file CSV, trovare i duplicati e visualizzarli in una griglia.

## Classi

### CSVCore

La classe `CSVCore` fornisce metodi per leggere un file CSV e trovare i duplicati.

- `ReadCSV(string path, string delimiter, bool hasHeader, int colNumber)`: Legge un file CSV e restituisce una lista di record.
- `NumFilesXZip(List<string> recordList, bool output = false)`: Conta il numero di file per ciascun file zip.
- `ExtractRecordsOfZip(List<string> recordList, string selectedZip = "12", bool output = false)`: Estrae i record di un file zip specifico.
- `GetDuplicatesFromList(List<string> list)`: Ottiene i duplicati da una lista.

### Utils

La classe `Utils` fornisce metodi di utilità per l'applicazione.

- `CSVFileExsists(TextBox txtPath)`: Controlla se esiste un file CSV.
- `GetCSVConfiguration(TextBox txtDelimiter, ComboBox cboSelectedCol)`: Ottiene la configurazione del file CSV.
- `DataTableFromList<T>(List<List<T>> lists, string[] indexes)`: Crea un DataTable da una lista di liste.

### MainForm

La classe `MainForm` è la classe principale dell'applicazione Windows Form. Fornisce metodi per gestire gli eventi dei pulsanti e visualizzare i dati nella griglia.

## Utilizzo

1. Fai clic sul pulsante "Sfoglia" per selezionare un file CSV.
2. Fai clic sul pulsante "Leggi CSV" per leggere il file CSV e visualizzare i record nella griglia.
3. Fai clic sul pulsante "Trova duplicati" per trovare i duplicati e visualizzarli nella griglia.
