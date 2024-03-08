using ScottPlot;
using System.Drawing;
using System.Globalization;
using Color = ScottPlot.Color;

namespace PotatoKMeans
{
    public partial class Form1 : Form
    {
        public struct ClusterPoint(double x, double y)
        {
            public double X { get; } = x;
            public double Y { get; } = y;
        }

        private double?[] dataX, dataY;
        private string axisX, axisY;
        private byte?[] dataAffiliation;
        private ClusterPoint?[]? clusterPoints;

        private Random random;
        private Color[]? colors;
        private Plot plot;

        public Form1()
        {
            InitializeComponent();
            InitPlot();
        }

        private void InitPlot()
        {
            random = new Random();
            plot = formsPlot1.Plot;
            Status(false);
        }

        private void Status(bool working)
        {
            if (!working)
            {
                StatusLabel.BackColor = System.Drawing.Color.FromArgb(255, 255, 200);
                StatusLabel.Text = "Idle";
                Enabled = true;
            }
            else
            {
                StatusLabel.BackColor = System.Drawing.Color.FromArgb(255, 200, 200);
                StatusLabel.Text = "Working";
                Enabled = false;
            }
        }

        private void LoadFile()
        {
            openFileDialog1.ShowDialog();
            colors = null;
            clusterPoints = null;
            dataAffiliation = null;
            string filePath = openFileDialog1.FileName;
            string[] splitPath = filePath.Split('.');
            if (!File.Exists(filePath) || splitPath.Length < 2 || splitPath[1] != "csv")
            {
                selectDataBtn.Enabled = false;
                fileLabel.Text = "Open a valid .csv file!";
                return;
            }
            fileLabel.Text = openFileDialog1.SafeFileName;
            selectDataBtn.Enabled = true;
        }

        private void ColumnToArray(List<string[]> data, ref double?[] array, int col)
        {
            array = new double?[data.Count];
            if (data[0][col - 1] != null && !double.TryParse(data[0][col - 1], out double _))
            {
                if (axisX == null) axisX = data[0][col - 1];
                else axisY = data[0][col - 1];
            }
            for (int i = 0; i < data.Count; i++)
            {
                string value = data[i][col - 1];
                if (double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out double result))
                {
                    array[i] = result;
                }
            }
        }

        private void LoadData()
        {
            Status(true);
            axisX = null; axisY = null;
            clusterGroupBox.Enabled = false;
            string filePath = openFileDialog1.FileName;
            using StreamReader sr = new(filePath);
            string? line = sr.ReadLine();
            if (line == null) return;
            string[] splitLine = line.Split(',');
            int cols = splitLine.Length;
            if (cols < 2) return;
            List<string[]> data = [];
            while (line != null)
            {
                data.Add(line.Split(','));
                line = sr.ReadLine();
            }
            Form2 form2 = new(data);
            form2.ShowDialog();
            Tuple<int, int>? dataColNums = form2.GetColNums();
            if (dataColNums == null) return;
            ColumnToArray(data, ref dataX, dataColNums.Item1);
            ColumnToArray(data, ref dataY, dataColNums.Item2);
            clusterGroupBox.Enabled = true;
            plot.XLabel(axisX ?? "");
            plot.YLabel(axisY ?? "");
            ResetClusters();
            Status(false);
        }

        private int Step(bool plot = false)
        {
            byte clusters = (byte)clustersNo.Value;
            UpdateCentroids(clusters);
            int updatedPoints = UpdateDataAffiliation(clusters);
            if (plot) Plot();
            return updatedPoints;
        }

        private void UpdateCentroids(byte clusters)
        {
            if (clusterPoints == null)
            {
                clusterPoints = new ClusterPoint?[clusters];
                for (int i = 0; i < clusters; i++)
                {
                    int j = 0, tryCounter = 0;
                    bool uniqueCentroid = false;
                    while (!uniqueCentroid && tryCounter < 110)
                    {
                        tryCounter++;
                        j = random.Next(0, dataX.Length);
                        int nullCounter = 0;
                        while ((dataX[j] == null || dataY[j] == null) && nullCounter < 500)
                        {
                            j = random.Next(0, dataX.Length);
                            nullCounter++;
                        }
                        if (!(nullCounter < 500)) continue;
                        uniqueCentroid = true;
                        for (int k = 0; k < i; k++)
                        {
                            ClusterPoint existingPoint = clusterPoints[k].Value;
                            if (existingPoint.X == dataX[j] && existingPoint.Y == dataY[j])
                            {
                                uniqueCentroid = false;
                                break;
                            }
                        }
                    }
                    if (!(tryCounter < 110))
                    {
                        throw new Exception("More clusters than valid datapoints!");
                    }
                    clusterPoints[i] = new ClusterPoint((double)dataX[j], (double)dataY[j]);
                }
                clustersNo.Enabled = false;
                return;
            }
            if (dataAffiliation == null) return;
            for (int i = 0; i < clusters; i++)
            {
                double xSum = 0, ySum = 0;
                int validData = 0;
                for (int j = 0; j < dataX.Length; j++)
                {
                    if (dataAffiliation[j] == null || dataAffiliation[j] != i) continue;
                    if (dataX[j] == null || dataY[j] == null) continue;
                    xSum += (double)dataX[j];
                    ySum += (double)dataY[j];
                    validData++;
                }
                double newX = xSum / validData;
                double newY = ySum / validData;
                clusterPoints[i] = new ClusterPoint(newX, newY);
            }
        }

        private int UpdateDataAffiliation(byte clusters)
        {
            if (colors == null)
            {
                colors = new Color[clusters];
                for (int i = 0; i < clusters; i++)
                {
                    float colorSplit = (float)1.0 / clusters;
                    colors[i] = Color.FromHSL(colorSplit * (i + 1), 0.5f, 0.45f);
                }
                dataAffiliation = new byte?[dataX.Length];
            }
            int updatedPoints = 0;
            for (int i = 0; i < dataX.Length; i++)
            {
                if (dataX[i] == null || dataY[i] == null) continue;
                byte closestPoint = 0;
                double? closestDistance = null;
                for (byte j = 0; j < clusters; j++)
                {
                    if (!clusterPoints[j].HasValue) continue;
                    double tempX = Math.Abs((double)(clusterPoints[j].Value.X - dataX[i]));
                    double tempY = Math.Abs((double)(clusterPoints[j].Value.Y - dataY[i]));
                    double distance = Math.Sqrt(Math.Pow(tempX, 2) + Math.Pow(tempY, 2));
                    if (closestDistance == null || distance < closestDistance)
                    {
                        closestPoint = j;
                        closestDistance = distance;
                    }
                }
                if (dataAffiliation[i] != closestPoint)
                {
                    dataAffiliation[i] = closestPoint;
                    updatedPoints++;
                }
            }
            return updatedPoints;
        }

        public void Plot(int higlightNo = -1)
        {
            if (dataX == null) return;
            plot.Clear();
            for (int i = 0; i < dataX.Length; i++)
            {
                if (dataX[i] == null || dataY[i] == null) continue;
                Color color = new(80, 80, 80, 200);
                if (dataAffiliation != null && dataAffiliation[i] != null && colors != null)
                {
                    color = colors[(byte)dataAffiliation[i]];
                    color = color.WithLightness(-0.3f);
                    if(higlightNo != -1)
                    {
                        if (higlightNo != dataAffiliation[i])
                        {
                            color = color.WithLightness(-0.1f);
                            color = color.WithAlpha(200);
                        }
                    }
                }
                plot.Add.Marker((double)dataX[i], (double)dataY[i], color: color);
            }
            if (clusterPoints != null)
            {
                for (int i = 0; i < clusterPoints.Length; i++)
                {
                    if (clusterPoints == null) continue;
                    ClusterPoint? point = clusterPoints[i];
                    if (point == null) continue;
                    var color = colors[i];
                    if (higlightNo != -1)
                    {
                        if (higlightNo != i)
                        {
                            color = color.WithAlpha(150);
                        }
                    }
                    plot.Add.Marker(point.Value.X, point.Value.Y, MarkerShape.Cross, 20, color);
                }
            }
            PlotScale();
        }

        private void PlotScale()
        {
            plot.Axes.AutoScale();
            formsPlot1.Refresh();
        }

        private void ResetClusters()
        {
            colors = null;
            clusterPoints = null;
            clustersNo.Enabled = true;
            Plot();
        }

        private async void FinishClustering()
        {
            Step(plot: true);
            await Task.Run(AutoCluster);
            Step(plot: true);
            Form3 form3 = new(clusterPoints, axisX, axisY);
            form3.Owner = this;
            form3.Show();
        }

        private void AutoCluster()
        {
            int threshold = (int)(dataX.Length * 0.0001);
            int maxIterations = 100000000;
            int i = 0;
            while (i < maxIterations)
            {
                int updatedPoints = Step();
                if (updatedPoints <= threshold) break;
                i++;
            }
        }
    }
}
