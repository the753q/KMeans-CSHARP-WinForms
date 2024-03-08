namespace PotatoKMeans
{
    using ClusterPoint = Form1.ClusterPoint;

    public partial class Form3 : Form
    {
        public Form3(ClusterPoint?[] clusterPoints, string axisX, string axisY)
        {
            InitializeComponent();
            ShowData(clusterPoints, axisX, axisY);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            (Owner as Form1).Plot(higlightNo: 0);
        }

        private void ShowData(ClusterPoint?[] clusterPoints, string axisX, string axisY)
        {
            dataGridView1.Columns.Add($"CentroidNo", $"Centroid");
            dataGridView1.Columns.Add($"X axis", $"{axisX ?? "X axis"}");
            dataGridView1.Columns.Add($"Y axis", $"{axisY ?? "Y axis"}");
            int centroidNo = 1;
            for (int i = 0; i < clusterPoints.Length; i++)
            {
                if (clusterPoints[i] == null) continue;
                ClusterPoint point = clusterPoints[i].Value;
                string[] coords = [$"{centroidNo}", point.X.ToString(), point.Y.ToString()];
                dataGridView1.Rows.Add(coords);
                centroidNo++;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int highlightNo = dataGridView1.SelectedRows[0].HeaderCell.RowIndex;
            (Owner as Form1).Plot(highlightNo);
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            (Owner as Form1).Plot();
        }
    }
}
