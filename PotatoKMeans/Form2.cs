namespace PotatoKMeans
{
    public partial class Form2 : Form
    {
        private bool confirmed = false;

        public Form2(List<string[]> data)
        {
            InitializeComponent();
            xColNo.Maximum = data[0].Length;
            yColNo.Maximum = data[0].Length;
            ShowData(data);
        }

        public Tuple<int, int>? GetColNums()
        {
            if (!confirmed) return null;
            return Tuple.Create((int)xColNo.Value, (int)yColNo.Value);
        }

        private void ShowData(List<string[]> data)
        {
            for (int i = 0; i < data[0].Length; i++)
            {
                dataGridView1.Columns.Add($"{i}", $"{i + 1}");
            }
            for (int i = 0; i < 20; i++)
            {
                dataGridView1.Rows.Add(data[i]);
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            confirmed = true;
            Close();
        }

        private void ColNo_ValueChanged(object sender, EventArgs e)
        {
            confirmBtn.Enabled = xColNo.Value != yColNo.Value;
        }
    }
}
