using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Reflection;

using WinFormStringCnvClass;
using PanelPictureBoxSet;
using OpenCvSharp;


namespace ConnectedComponentsMapping
{
    public partial class Form1 : Form
    {
        string binLocationDirectory;

        public struct paramSet
        {
            public double SizeX;
            public double SizeY;
            
            public double GridX;
            public double GridY;

        }

        Bitmap createMapFromString(double SizeX, double SizeY, double GridX, double GridY, string[] Lines)
        {
            int mapWidth = (int)(SizeX / GridX);
            int mapHeight = (int)(SizeY / GridY);

            Bitmap MapImage = new Bitmap(mapWidth, mapHeight);
            Graphics g = Graphics.FromImage(MapImage);

            g.FillRectangle(Brushes.Black, 0, 0, mapWidth, mapHeight);

            g.Dispose();

            Color dColor = Color.FromArgb(64, 255, 255, 255);

            //string[] Lines = LinesString.Replace("\r\n","\n").Split('\n');

            foreach (var Line in Lines)
            {
                string[] Cols = Line.Split('\t');
                int posX = (int)(double.Parse(Cols[0]) / GridX);
                int posY = (int)(double.Parse(Cols[1]) / GridY);

                try
                {
                    MapImage.SetPixel(posX, posY, dColor);
                }
                catch { };
            }

            return MapImage;

        }


        public Form1()
        {
            InitializeComponent();
            binLocationDirectory = Path.GetDirectoryName(Application.ExecutablePath);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string paramFilePath = Path.Combine(binLocationDirectory, "param.txt");
            if (File.Exists(paramFilePath))
            {
                WinFormStringCnv.setControlFromString(this, File.ReadAllText(paramFilePath));
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string paramFilePath = Path.Combine(binLocationDirectory, "param.txt");
            File.WriteAllText(paramFilePath, WinFormStringCnv.ToString(this));

        }

        string[] Lines;
        private void button_CreateImage_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TEXT|*.txt";

            if (ofd.ShowDialog() != DialogResult.OK) return;

            double SizeX = double.Parse(textBox_SizeX.Text);
            double SizeY = double.Parse(textBox_SizeY.Text);
           
            double GridX = double.Parse(textBox_GridX.Text);
            double GridY = double.Parse(textBox_GridY.Text);

            Lines = File.ReadAllLines(ofd.FileName);

            pictureBoxEx1.setPictureBox(createMapFromString(SizeX, SizeY, GridX, GridY, Lines));
        }

        private void button_SaveParam_Click(object sender, EventArgs e)
        {
            string paramFilePath = Path.Combine(binLocationDirectory, "param.txt");
            File.WriteAllText(paramFilePath, WinFormStringCnv.ToString(this));
        }

        private void button_SaveImage_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() != DialogResult.OK) return;

            pictureBoxEx1.getImage().Save(sfd.FileName);

        }


        public struct statusValue
        {
            public double xf;
            public double yf;
            public int x;
            public int y;
            public int w;
            public int h;
            public int a;

            /*
            public override string ToString()
            {
                return "(" + xf.ToString("0") + "," + yf.ToString("0") + ")(" + x.ToString() + "," + y.ToString() + ")-(" + w.ToString() + "," + h.ToString() + ")-" + a.ToString();
            }
            */

            public override string ToString()
            {
                return xf.ToString("0") + "\t" + yf.ToString("0") + "\t" + x.ToString() + "\t" + y.ToString() + "\t" + w.ToString() + "\t" + h.ToString() + "\t" + a.ToString();
            }

        }

        private void button_getConnectedComponents_Click(object sender, EventArgs e)
        {
            if (Lines != null)
            {
                double SizeX = double.Parse(textBox_SizeX.Text);
                double SizeY = double.Parse(textBox_SizeY.Text);

                double GridX = double.Parse(textBox_GridX.Text);
                double GridY = double.Parse(textBox_GridY.Text);

                pictureBoxEx1.setPictureBox(createMapFromString(SizeX, SizeY, GridX, GridY, Lines));
            }

            Mat srcImage = OpenCvSharp.Extensions.BitmapConverter.ToMat(pictureBoxEx1.getImage());
            Mat grayscaleImage = new Mat();
            Mat binaryImage = new Mat();

            Cv2.CvtColor(srcImage, grayscaleImage, ColorConversionCodes.RGB2GRAY);
            Cv2.Threshold(grayscaleImage, binaryImage, 32, 255, ThresholdTypes.Binary);

            Mat Labels = new Mat();
            Mat Status = new Mat();
            Mat Centroids = new Mat();

            int LabelsCount = Cv2.ConnectedComponentsWithStats(binaryImage, Labels, Status, Centroids, PixelConnectivity.Connectivity8);

            List<statusValue> ListStatus = new List<statusValue>();
            List<Scalar> ComponentColors = new List<Scalar>();


            // ===================================
            // Initialize ComponentColors
            // backGroudColor by HSVA

            ComponentColors.Add(new Scalar(0, 0, 255, 255));

            double ComponentsHeightMax = double.Parse(textBox_ComponentsHeightMax.Text);
            List<statusValue> svMaxList = new List<statusValue>();

            for (int i = 1; i < LabelsCount; i++)
            {
                double xf = Centroids.At<double>(i, 0);
                double yf = Centroids.At<double>(i, 1);

                int x = Status.At<int>(i, 0);
                int y = Status.At<int>(i, 1);
                int w = Status.At<int>(i, 2);
                int h = Status.At<int>(i, 3);
                int a = Status.At<int>(i, 4);

                int Hue = (int)((ComponentsHeightMax - h) / ComponentsHeightMax * 240.0 / 360.00 * 179.0);
                if (Hue < 0) Hue = 0;
                
                ComponentColors.Add(new Scalar(Hue, 255, 255, 255));

                if (w > 1 || h > 1)
                {
                    statusValue sv = new statusValue();
                    sv.xf = xf;
                    sv.yf = yf;
                    sv.x = x;
                    sv.y = y;
                    sv.w = w;
                    sv.h = h;
                    sv.a = a;

                    ListStatus.Add(sv);

                    if (svMaxList.Count == 0) { svMaxList.Add(sv); }
                    else if (svMaxList[0].h < sv.h) { svMaxList.Clear(); svMaxList.Add(sv); }
                    else if (svMaxList[0].h == sv.h) {  svMaxList.Add(sv); }

                }

            }

            int rows = binaryImage.Rows;
            int cols = binaryImage.Cols;

            Mat hsvColorImage = new Mat(rows, cols, MatType.CV_8UC3);
            var labelIndexer = Labels.GetGenericIndexer<int>();
            var dstIndexer = hsvColorImage.GetGenericIndexer<Vec3b>();

            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < cols; x++)
                {
                    int labelValue = labelIndexer[y, x];
                    dstIndexer[y, x] = ComponentColors[labelValue ].ToVec3b();
                }
            }

            Mat createImage = new Mat();
            Cv2.CvtColor(hsvColorImage, createImage, ColorConversionCodes.HSV2BGR);

            pictureBoxEx1.setPictureBox(OpenCvSharp.Extensions.BitmapConverter.ToBitmap(createImage));

            createImage.Dispose();

            hsvColorImage.Dispose();

            binaryImage.Dispose();
            grayscaleImage.Dispose();
            srcImage.Dispose();

        }
    }
}
