namespace PotatoKMeans
{
    public partial class Form1 : Form
    {
        private void StepBtn_Click(object sender, EventArgs e)
        {
            Status(true);
            Step(plot: true);
            Status(false);
        }

        private void AutoScaleBtn_Click(object sender, EventArgs e)
        {
            Status(true);
            PlotScale();
            Status(false);
        }
        private void resetBtn_Click(object sender, EventArgs e)
        {
            Status(true);
            ResetClusters();
            Status(false);
        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            Status(true);
            FinishClustering();
            Status(false);
        }

        private void loadFileBtn_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void selectDataBtn_Click(object sender, EventArgs e)
        {
            Status(true);
            LoadData();
            Status(false);
        }

        private void lightDataCheck_CheckedChanged(object sender, EventArgs e)
        {
            Plot((byte)clustersNo.Value);
        }
    }
}