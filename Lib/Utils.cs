using System.Data;

namespace CheckDuplicatesInCSV.lib
{
    internal class Utils
    {
        public static void CSVFileExsists(TextBox txtPath)
        {
            string filePath = txtPath.Text.Trim();

            //  Check: string is actually a file system path
            try
            {
                Path.GetFullPath(filePath);
            }
            catch (Exception)
            {
                throw new Exception("Il Percorso del file non è ben formato\nInserisci un percorso file valido");
            }

            //  Check: file actually exists
            if (!File.Exists(filePath))
            {
                throw new Exception("Il file non esiste\nInserisci un percorso file valido");
            }

        }

        internal static (string, int) GetCSVConfiguration(TextBox txtDelimiter, ComboBox cboSelectedCol)
        {
            //  Checks: delimter, combo box
            if (string.IsNullOrEmpty(txtDelimiter.Text))
                throw new Exception("Il carattere delimitatore non è stato inserito\nInserisci il carattere delimitatore");

            if (cboSelectedCol.SelectedItem == null)
                throw new Exception("Non è stata selezionata la colonna dei duplicati\nInserisci colonna");

            //  Return configuration
            string delimiter = txtDelimiter.Text;
            int selectedCol = int.Parse(cboSelectedCol.SelectedItem.ToString()) - 1; // -1 -> user press '1' to get [0] col

            //  If everything is fine, return delimimter and combobox values
            return (delimiter, selectedCol);
        }


        /// <summary>
        /// This function create a DataTable
        /// Columns values are given by each List<T> contained into param 'List<T> lists'
        /// Columns names are contained into param 'string[] indexes'
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lists">
        /// Container of lists: each list represent a column of the grid. 
        /// They must have same length
        /// It's almost like a matrix where each list is a row</param>
        /// <param name="indexes">Container of names for each column</param>
        /// <returns>DataTable</returns>
        /// <exception cref="Exception"></exception>
        internal static DataTable DataTableFromList<T>(List<List<T>> lists, string[] indexes)
        {
            DataTable dataTable = new DataTable();

            //  Add indexes with columns
            dataTable.Columns.Add("_index_");   //  common columns for every grid
            foreach (string index in indexes)
            {
                dataTable.Columns.Add(index);
            }

            //  Check lengths of each column (list)
            for (int i = 0; i < lists.Count - 1; i++)
            {
                if (lists[i].Count != lists[i + 1].Count)
                    throw new Exception("DataTableFromList:\tlists given to fill the DataTable have different length");
            }

            //  Add every record: scroll 'lists' matrix horizontally
            int numberOfRecords = lists[0].Count;

            for (int i = 0; i < numberOfRecords; i++)
            {
                DataRow dataRow = dataTable.NewRow();

                dataRow[0] = i + 1; //  index as first cell of the row

                //  Add every row of each record: scroll selected column vertically
                for (int j = 0; j < lists.Count; j++)
                {
                    dataRow[j + 1] = lists[j][i];
                }

                dataTable.Rows.Add(dataRow);
            }

            return dataTable;
        }



        //  TODO extract values form dict and put it into List<strgiin>
    }
}

