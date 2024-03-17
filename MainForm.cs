using CheckDuplicatesInCSV.lib;
using System.Diagnostics;

namespace CheckExample
{
    public partial class MainForm : Form
    {
        private static List<string> _records = [];
        private static int _selectedCol;

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public MainForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Loading MainForm");
        }

        private void btnReadCSV_Click(object sender, EventArgs e)
        {
            try
            {
                // 1) Check if CSV file exists  
                Utils.CSVFileExsists(txtPath);


                //  2) Get CSV configuration
                (string delimiter, _selectedCol) = Utils.GetCSVConfiguration(txtDelimiter, cboSelectedCol);

                // 3) Read CSV file
                _records = CSVCore.ReadCSV(
                    path: txtPath.Text,
                    delimiter: delimiter,
                    hasHeader: rbtnHeader.Checked,
                    colNumber: _selectedCol);

                lblReadOutcome.Text = $"{_records.Count} records read";

                //  4) Load grid with list of CSV records
                gridReadRecords.DataSource = Utils.DataTableFromList(
                    lists: new List<List<string>>() { _records },
                    indexes: new string[] { $"Col #{_selectedCol}" });

                //  Resize grid
                gridReadRecords.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;



            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Errore - Read CSV",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }


        }

        private void btnFindDuplicates_Click(object sender, EventArgs e)
        {
            try
            {
                //  1) Get list of duplicates 

                //  Start timer
                var stopwatch = new Stopwatch();
                stopwatch.Start();

                Dictionary<string, string> duplicateXCount = CSVCore.GetDuplicatesFromList(_records);

                //  Stop timer
                stopwatch.Stop();
                double elapsedSeconds = stopwatch.Elapsed.TotalSeconds;
                lblTimer.Text = elapsedSeconds.ToString();

                //  2) Number of repetitions and duplicates
                int numItemsDupls = duplicateXCount.Keys.Count;

                int numOfReps = 0;
                foreach (var entry in duplicateXCount)
                {
                    //  number of ',' in the string = number of places in the column where value is repteated (+1 as initial place)
                    numOfReps += entry.Value.Count(c => c == ',') + 1;
                }

                //  3) Show duplicates on the grid
                if (numItemsDupls > 0)
                {
                    txtNumReps.ForeColor = Color.Red; //  Number of duplicates in red

                    //  Load grid with table of 2 columns, 2 indexes
                    gridFindDuplicates.DataSource = Utils.DataTableFromList
                    (
                        lists: new List<List<string>>()
                        {
                            duplicateXCount.Keys.ToList(),  //  1° column
                            duplicateXCount.Values.ToList() //  2° column
                        },
                        indexes: new string[]
                        {
                            "Path",
                            "Indexes of repetition"
                        }
                    );

                    //  Resize grid
                    gridFindDuplicates.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    txtNumReps.ForeColor = Color.Green;   //  0 duplicates -> green '0'
                }

                //  Set TextBox(s)
                txtNumReps.Text = numOfReps.ToString();
                txtItemRepetitions.Text = numItemsDupls.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Errore - Find duplicates",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            //  Pick .csv file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = openFileDialog.FileName;
            }
        }


    }
}
