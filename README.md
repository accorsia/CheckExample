# CheckDuplicatesInCSV

## Description
CheckDuplicatesInCSV is a Windows Forms application that reads a CSV file, identifies duplicate records, and displays them in a grid.

## Features
- Load and read CSV files
- Identify duplicate records
- Display data in a user-friendly grid
- Utility methods for enhanced CSV processing

## Installation
1. Clone the repository:
   ```sh
   git clone https://github.com/yourusername/CheckDuplicatesInCSV.git
   ```
2. Open the project in Visual Studio.
3. Build and run the application.

## Usage
- Click the **Browse** button to select a CSV file.
- Click **Read CSV** to load and display the file’s content.
- Click **Find Duplicates** to detect and display duplicate records.

## Class Overview
### CSVCore
Handles CSV processing:
- `ReadCSV(path, delimiter, hasHeader, colNumber)`: Reads a CSV file and returns a list of records.
- `NumFilesXZip(recordList, output)`: Counts files in ZIP archives.
- `ExtractRecordsOfZip(recordList, selectedZip, output)`: Extracts records from a specific ZIP file.
- `GetDuplicatesFromList(list)`: Identifies duplicates.

### Utils
Provides utility functions:
- `CSVFileExists(txtPath)`: Checks if a CSV file exists.
- `GetCSVConfiguration(txtDelimiter, cboSelectedCol)`: Retrieves CSV configurations.
- `DataTableFromList<T>(lists, indexes)`: Converts lists into a DataTable.

### MainForm
Handles UI events and data presentation.

## Contributing
Contributions are welcome! Feel free to fork the repository and submit pull requests.

## License
This project is open-source and available under the [MIT License](LICENSE).

## Tags
- C#
- Windows Forms
- CSV Processing
- Data Management
- Duplicate Finder
