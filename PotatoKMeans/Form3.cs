namespace PotatoKMeans
{
    using Centroid = Form1.Centroid;

    public partial class Form3 : Form
    {
        private int highlightNo;

        public Form3(List<object> data)
        {
            InitializeComponent();
            ShowData(data);
            highlightNo = 0;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            (Owner as Form1).Plot(highlightNo);
        }

        private void ShowData(List<object> data)
        {
            Centroid?[] centroids = (Centroid?[])data[0];
            string axisX = (string)data[1];
            string axisY = (string)data[2];
            Dictionary<byte, int> groupSize = (Dictionary<byte, int>)data[3];
            Dictionary<byte, double> centroidProximities = (Dictionary<byte, double>)data[4];
            dataGridView1.Columns.Add($"CentroidNo", $"Centroid");
            dataGridView1.Columns.Add($"X axis", $"{axisX ?? "X axis"}");
            dataGridView1.Columns.Add($"Y axis", $"{axisY ?? "Y axis"}");
            dataGridView1.Columns.Add($"Cluster Size", "Cluster Size");
            dataGridView1.Columns.Add($"Centroid Proximities", "Centroid Proximities");
            int centroidNo = 1;
            for (byte i = 0; i < centroids.Length; i++)
            {
                if (centroids[i] == null) continue;
                Centroid point = centroids[i].Value;
                object[] row = [centroidNo, point.X, point.Y, groupSize[i], centroidProximities[i]];
                dataGridView1.Rows.Add(row);
                centroidNo++;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int lastHighlight = highlightNo;
            if (int.TryParse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), out int centroid))
            {
                highlightNo = centroid - 1;
            }
            if (lastHighlight == highlightNo) return;
            (Owner as Form1).Plot(highlightNo);
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            (Owner as Form1).Plot();
        }
    }
}
