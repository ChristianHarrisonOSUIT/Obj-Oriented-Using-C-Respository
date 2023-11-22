using NumberCollectionApp;

namespace Week8App
{
    public partial class frmCollections : Form
    {
        private NumberCollection numberCollection = new NumberCollection();
        public frmCollections()

        {
            InitializeComponent();
            InitializeUI();
        }
        private void InitializeUI()
        {
            // Initialize the UI components and event handlers
            button3.Click += AddNumberToCollectionButton_Click;
            button4.Click += ShowStatisticsButton_Click;
            button1.Click += ResetButton_Click;

            KeyPreview = true;
            KeyDown += MainForm_KeyDown;
        }

        private void AddNumberToCollectionButton_Click(object sender, EventArgs e)
        {
            string inputText = richTextBox1.Text;
            int number;
            if (numberCollection.TryAddNumber(inputText, out number))
            {
                UpdateStatsBox($"Added number: {number}");
            }
            else
            {
                UpdateStatsBox(numberCollection.ErrorMessage);
            }

            richTextBox1.Clear();
        }

        private void ShowStatisticsButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = numberCollection.GetCollectionDisplay();
            UpdateStatsBox(numberCollection.GetStatistics());
            numberCollection.ClearCollection();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            numberCollection.ClearCollection();
            textBox1.Clear();
            UpdateStatsBox("Collection has been cleared.");
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                AddNumberToCollectionButton_Click(this, new EventArgs());
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void UpdateStatsBox(string message)
        {
            textBox1.AppendText(message + Environment.NewLine);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

namespace NumberCollectionApp
{
    class NumberCollection
    {
        private List<int> collection = new List<int>();
        private const int MaxCollectionSize = 17;
        private const int MinValue = -1217;
        private const int MaxValue = 1217;
        private string errorMessage = "";

        public string ErrorMessage { get { return errorMessage; } }

        public bool TryAddNumber(string input, out int number)
        {
            if (int.TryParse(input, out number))
            {
                if (collection.Count < MaxCollectionSize)
                {
                    if (number >= MinValue && number <= MaxValue)
                    {
                        collection.Add(number);
                        errorMessage = "";
                        return true;
                    }
                    else
                    {
                        errorMessage = "Value Out Of Range Error";
                    }
                }
                else
                {
                    errorMessage = "Collection Full Error";
                }
            }
            else
            {
                errorMessage = "Invalid input. Please enter a valid integer.";
            }

            number = 0;
            return false;
        }

        public void ClearCollection()
        {
            collection.Clear();
        }

        public string GetCollectionDisplay()
        {
            return string.Join(Environment.NewLine, collection);
        }

        public string GetStatistics()
        {
            if (collection.Count == 0)
            {
                return "No data available.";
            }

            int sum = 0;
            int highest = int.MinValue;
            int lowest = int.MaxValue;

            foreach (int num in collection)
            {
                sum += num;
                highest = Math.Max(highest, num);
                lowest = Math.Min(lowest, num);
            }

            double average = (double)sum / collection.Count;
            return $"Average: {average:F4}\nHighest Number: {highest}\nLowest Number: {lowest}\nNumber of Numbers: {collection.Count}";
        }
    }
}