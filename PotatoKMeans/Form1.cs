using ScottPlot;
using System.Globalization;
using Color = ScottPlot.Color;

namespace PotatoKMeans
{
    public partial class Form1 : Form
    {
        public struct Centroid(double x, double y)
        {
            public double X { get; } = x;
            public double Y { get; } = y;
        }

        private double?[] dataX, dataY;
        private string axisX, axisY; // nazvy osi zo zdrojovych dat
        private byte?[] dataAffiliation; // prislusnost dat k skupine
        private Centroid?[]? centroids; // pozicie centroidov

        private Random random;
        private Plot plot;
        private Color[]? colors; // farby pre kazdu skupinu

        public Form1() // inicializacia objektu okna
        {
            InitializeComponent();
            random = new Random();
            plot = formsPlot1.Plot;
            Status(false);
        }

        private void Status(bool working) // meni stav programu
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

        private void NullData() // resetuje premenne
        {
            colors = null;
            centroids = null;
            dataAffiliation = null;
            dataX = null; dataY = null;
            axisX = null; axisY = null;
        }

        private void LoadFile() // vyber a nacitanie .csv suboru s datasetom
        {
            clusterGroupBox.Enabled = false;
            openFileDialog1.ShowDialog();
            NullData();
            Plot();
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

        // prevod string hodnot stlpca do pola hodnot double
        private void ColumnToArray(List<string[]> data, ref double?[] array, int col)
        {
            array = new double?[data.Count];
            if (data[0][col - 1] != null && !double.TryParse(data[0][col - 1], out double _))
            {
                if (axisX == null) axisX = data[0][col - 1]; // nacitanie nazvov osi, ak su
                else axisY = data[0][col - 1];
            }
            for (int i = 0; i < data.Count; i++)
            {
                string value = data[i][col - 1];
                if (double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out double result))
                {
                    array[i] = result; // zapisanie hodnoty zo stlpca, ak je v ciselnom tvare
                }
            }
        }

        private void LoadData() // nacitanie dat z vybraneho suboru
        {
            NullData();
            Status(working: true);
            string filePath = openFileDialog1.FileName;
            using StreamReader sr = new(filePath);
            string? line = sr.ReadLine();
            if (line == null) return;
            string[] splitLine = line.Split(',');
            int cols = splitLine.Length;
            if (cols < 2) return;
            List<string[]> data = [];
            while (line != null) // nacitanie surovych dat
            {
                data.Add(line.Split(','));
                line = sr.ReadLine();
            }
            Form2 form2 = new(data);
            form2.ShowDialog(); // otvorenie okna na vyber osi X a Y
            Tuple<int, int>? dataColNums = form2.GetColNums();
            if (dataColNums == null) return; // kontrola vybranych osi
            ColumnToArray(data, ref dataX, dataColNums.Item1);
            ColumnToArray(data, ref dataY, dataColNums.Item2);
            clusterGroupBox.Enabled = true;
            plot.XLabel(axisX ?? ""); // ak nazvy os neexistuju, budu prazdne
            plot.YLabel(axisY ?? "");
            ResetCentroids(); // vymazanie predoslych centroidov
            Status(working: false);
        }

        private int Step(bool plot = false) // krok vpred pre centroidy
        {
            byte clusters = (byte)clustersNo.Value;
            UpdateCentroids(clusters); // prepocita pozicie centroidov
            int updatedPoints = UpdateDataAffiliation(clusters);
            if (plot) Plot();
            return updatedPoints; // vrati pocet prestupenych bodov
        }

        private void GenerateCentroids(byte clusters) // generuje centroidy
        {
            centroids = new Centroid?[clusters];
            for (int i = 0; i < clusters; i++)
            {
                int j = 0, tryCounter = 0;
                bool uniqueCentroid = false;
                while (!uniqueCentroid && tryCounter < 110)
                { // nahodna pozicia centroidov sa vyberie z existujucich bodov
                    tryCounter++;
                    j = random.Next(0, dataX.Length);
                    int nullCounter = 0;
                    while ((dataX[j] == null || dataY[j] == null) && nullCounter < 500)
                    { // skusa najst validny bod
                        j = random.Next(0, dataX.Length);
                        nullCounter++;
                    }
                    if (!(nullCounter < 500)) continue;
                    uniqueCentroid = true;
                    for (int k = 0; k < i; k++)
                    { // skusa najst neobsadeny bod
                        Centroid existingPoint = centroids[k].Value;
                        if (existingPoint.X == dataX[j] && existingPoint.Y == dataY[j])
                        {
                            uniqueCentroid = false;
                            break;
                        }
                    }
                }
                if (!(tryCounter < 110))
                { // vyhodi chybu ak sa centroidy nepodarilo vytvorit
                    throw new Exception("More clusters than valid datapoints!");
                }
                centroids[i] = new Centroid((double)dataX[j], (double)dataY[j]);
            }
            clustersNo.Enabled = false;
        }

        private void UpdateCentroids(byte clusters) // aktualizuje pozicie centroidov
        {
            if (centroids == null) // vygeneruje centroidy
            {
                GenerateCentroids(clusters);
                return;
            }
            if (dataAffiliation == null) return;
            for (int i = 0; i < clusters; i++)
            { // aktualizuje pozicie centroidov
                double xSum = 0, ySum = 0;
                int validData = 0;
                for (int j = 0; j < dataX.Length; j++)
                { // podla skupiny bodov vypocita priemerne hodnoty X a Y pre centroid skupiny
                    if (dataAffiliation[j] == null || dataAffiliation[j] != i) continue;
                    if (dataX[j] == null || dataY[j] == null) continue;
                    xSum += (double)dataX[j];
                    ySum += (double)dataY[j];
                    validData++;
                }
                double newX = xSum / validData;
                double newY = ySum / validData;
                centroids[i] = new Centroid(newX, newY);
            }
        }

        private double CalculateDistance(Centroid centroid, double pointX, double pointY)
        {
            double tempX = Math.Abs((double)(centroid.X - pointX));
            double tempY = Math.Abs((double)(centroid.Y - pointY));
            return Math.Sqrt(Math.Pow(tempX, 2) + Math.Pow(tempY, 2));
        }

        private int UpdateDataAffiliation(byte clusters) // aktualizuje prislusnost bodov ku skupinam
        {
            if (colors == null)
            { // vypocita novu farebnu skalu podla poctu skupin
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
            { // kazdemu bodu urci prislusnost k najblizsiemu centroidu
                if (dataX[i] == null || dataY[i] == null) continue;
                byte closestPoint = 0;
                double? closestDistance = null;
                for (byte j = 0; j < clusters; j++)
                {
                    if (!centroids[j].HasValue) continue;
                    double distance = CalculateDistance((Centroid)centroids[j], (double)dataX[i], (double)dataY[i]);
                    if (closestDistance == null || distance < closestDistance)
                    {
                        closestPoint = j;
                        closestDistance = distance;
                    }
                }
                if (dataAffiliation[i] != closestPoint)
                { // zmeni prislusnost ak je bod blizsie k inemu centroidu
                    dataAffiliation[i] = closestPoint;
                    updatedPoints++;
                }
            }
            return updatedPoints;
        }

        public void Plot(int higlightNo = -1) // vykresli body na grafe
        {
            plot.Clear();
            if (dataX == null)
            {
                plot.XLabel("");
                plot.YLabel("");
                RefreshPlot();
                return;
            }
            for (int i = 0; i < dataX.Length; i++)
            {
                if (dataX[i] == null || dataY[i] == null) continue;
                Color color = new(80, 80, 80, 200);
                if (dataAffiliation != null && dataAffiliation[i] != null && colors != null)
                { // zafarbi body podla prislusnoti k skupine
                    color = colors[(byte)dataAffiliation[i]];
                    color = color.WithLightness(0.7f);
                    if (higlightNo != -1)
                    { // zprehliadni body ostatnych skupin pri zobrazeni jednej
                        if (higlightNo != dataAffiliation[i])
                        {
                            color = color.WithLightness(0.9f);
                            color = color.WithAlpha(200);
                        }
                    }
                }
                plot.Add.Marker((double)dataX[i], (double)dataY[i], color: color);
            }
            if (centroids != null)
            { // vykresli centroidy
                for (int i = 0; i < centroids.Length; i++)
                {
                    if (centroids == null) continue;
                    Centroid? point = centroids[i];
                    if (point == null) continue;
                    var color = colors[i];
                    if (higlightNo != -1)
                    { // zprehliadni centroidy ostatnych skupin pri zobrazeni jednej
                        if (higlightNo != i)
                        {
                            color = color.WithAlpha(150);
                        }
                    }
                    plot.Add.Marker(point.Value.X, point.Value.Y, MarkerShape.Cross, 20, color);
                }
            }
            RefreshPlot(scale: higlightNo == -1);
        }

        private void RefreshPlot(bool scale = true) // prekresli graf
        {
            if (scale) plot.Axes.AutoScale();
            formsPlot1.Refresh();
        }

        private void ResetCentroids() // resetuje centroidy
        {
            colors = null;
            centroids = null;
            clustersNo.Enabled = true;
            Plot();
        }

        private Dictionary<byte, int> GetClusterSizes() // ziska velkosti skupin
        {
            Dictionary<byte, int> clusterSizes = new();
            for (int i = 0; i < dataAffiliation.Length; i++)
            {
                if (dataAffiliation[i] == null) continue;
                byte cluster = dataAffiliation[i].Value;
                if (!clusterSizes.ContainsKey(cluster)) clusterSizes.Add(cluster, 0);
                clusterSizes[cluster]++; // inkrementuje pre kazdy bod prisluchajuci skupine
            }
            return clusterSizes;
        }

        // ziska skore hodnotiace pocet a blizkost bodov skupin k ich centroidom
        // cim nizsie cislo, tym lepsie
        private Dictionary<byte, double> GetCentroidProximities(Dictionary<byte, int> clusterSizes)
        {
            Dictionary<byte, double> centroidProximities = new();
            for (int i = 0; i < dataAffiliation.Length; i++)
            { // pre kazdu skupinu vypocita sumu vzdialenosti bodov
                if (dataAffiliation[i] == null) continue;
                byte cluster = dataAffiliation[i].Value;
                if (!centroidProximities.ContainsKey(cluster)) centroidProximities.Add(cluster, 0);
                double distance = CalculateDistance((Centroid)centroids[cluster], (double)dataX[i], (double)dataY[i]);
                centroidProximities[cluster] += distance;
            }
            for (byte i = 0; i < clustersNo.Value; i++)
            { // pre kazdu skupinu vydeli sumu vzdialenosti poctom bodov v skupine
                double distance = centroidProximities[i];
                centroidProximities[i] = distance / clusterSizes[i];
            }
            return centroidProximities;
        }

        private void FinishClustering() // dokonci zoskupovanie
        {
            AutoCluster();
            Dictionary<byte, int> clusterSizes = GetClusterSizes();
            Dictionary<byte, double> centroidProximities = GetCentroidProximities(clusterSizes);
            List<object> data = [centroids, axisX, axisY, clusterSizes, centroidProximities];
            Form3 form3 = new(data);
            form3.Owner = this;
            form3.Show(); // zobrazi okno so zoznamom centroidov
        }

        private void AutoCluster() // automaticky dokonci zoskupovanie
        {
            // pocet bodov, ktorych prislusnost moze kazdy krok preskakovat
            int threshold = (int)(dataX.Length * 0.0001);
            int maxIterations = 100000000;
            int i = 0;
            while (i < maxIterations)
            { // vykona krok pokial nedosiahne max iteracii
                int updatedPoints = Step();
                // predcasne ukonci zoskupovanie ak sa prislusnost vacsiny bodov nemeni
                if (updatedPoints <= threshold) break;
                i++;
            }
        }
    }
}
