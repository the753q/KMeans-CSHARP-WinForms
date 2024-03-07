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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
