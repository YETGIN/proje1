using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Imaging.Filters;
using AForge.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Math.Geometry;
using System.IO.Ports;
using Point = System.Drawing.Point;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection VideoCapTureDevices;
        private VideoCaptureDevice Finalvideo;
        SerialPort arduino = new SerialPort();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VideoCapTureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in VideoCapTureDevices)
            {

                ComboBox1.Items.Add(VideoCaptureDevice.Name);

            }

            ComboBox1.SelectedIndex = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            Finalvideo = new VideoCaptureDevice(VideoCapTureDevices[ComboBox1.SelectedIndex].MonikerString);
            Finalvideo.NewFrame += new NewFrameEventHandler(Finalvideo_NewFrame);
            Finalvideo.DesiredFrameRate = 20;
            Finalvideo.DesiredFrameSize = new Size(500,400);
            Finalvideo.Start();
        }
        void Finalvideo_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {

            Bitmap image = (Bitmap)eventArgs.Frame.Clone();
            Bitmap image1 = (Bitmap)eventArgs.Frame.Clone();
            PictureBox1.Image = image;



            if (RadioButton1.Checked)
            {
                EuclideanColorFiltering filter = new EuclideanColorFiltering();
                filter.CenterColor = new RGB(Color.FromArgb(180, 0, 0));
                filter.Radius = 100;
                filter.ApplyInPlace(image1);
                nesnebul(image1);
            }

            if (RadioButton2.Checked)
            {
                EuclideanColorFiltering filter = new EuclideanColorFiltering();
                filter.CenterColor = new RGB(Color.FromArgb(0, 180, 0));
                filter.Radius = 100;
                filter.ApplyInPlace(image1);
                nesnebul(image1);

            }
            if (RadioButton3.Checked)
            {
                EuclideanColorFiltering filter = new EuclideanColorFiltering();
                filter.CenterColor = new RGB(Color.FromArgb(0, 0, 200));
                filter.Radius = 100;
                filter.ApplyInPlace(image1);
                nesnebul(image1);
            }
        }
        public void nesnebul(Bitmap image)
        {
            BlobCounter blobCounter = new BlobCounter();
            blobCounter.MinWidth = 5;
            blobCounter.MinHeight = 5;
            blobCounter.FilterBlobs = true;
            blobCounter.ObjectsOrder = ObjectsOrder.Size;
            BitmapData objectsData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadOnly, image.PixelFormat);
            Grayscale grayscaleFilter = new Grayscale(0.2125, 0.7154, 0.0721);
            UnmanagedImage grayImage = grayscaleFilter.Apply(new UnmanagedImage(objectsData));
            image.UnlockBits(objectsData);

            blobCounter.ProcessImage(image);
            Rectangle[] rects = blobCounter.GetObjectsRectangles();
            Blob[] blobs = blobCounter.GetObjectsInformation();
            PictureBox2.Image = image;

            if (RadioButton4.Checked)
            {
                //Tek cisim Takibi

                foreach (Rectangle recs in rects)
                {
                    if (rects.Length > 0)
                    {
                        Rectangle objectRect = rects[0];
                        Graphics g = PictureBox1.CreateGraphics();
                        using (Pen pen = new Pen(Color.FromArgb(252, 3, 26), 2))
                        {
                            g.DrawRectangle(pen, objectRect);
                        }
                        int objectX = objectRect.X + (objectRect.Width/2);
                        int objectY = objectRect.Y + (objectRect.Height/2);

                        g.Dispose();

                        if (objectX <= 250 && objectY <= 200)
                        {
                            arduino.Write("1");
                        }
                        if (objectX > 250 && objectX < 500 && objectY <= 200)
                        {
                            arduino.Write("2");
                        }
                        if (objectX >= 500 && objectY <= 200)
                        {
                            arduino.Write("3");
                        }
                        if (objectX < 250 && objectY > 200 && objectY < 400)
                        {
                            arduino.Write("4");
                        }
                        if (objectX > 250 && objectX < 500 && objectY > 200  && objectY < 400)
                        {
                            arduino.Write("5");
                        }
                        if (objectX > 500 && objectY > 200 && objectY < 400)
                        {
                            arduino.Write("6");
                        }
                        if (objectX < 250 && objectY > 400)
                        {
                            arduino.Write("7");
                        }
                        if (objectX > 250 && objectX < 500 && objectY > 400)
                        {
                            arduino.Write("8");
                        }
                        if (objectX > 500 && objectY > 400)
                        {
                            arduino.Write("9");
                        }
                    }
                }
            }
        }
       

        private void Button2_Click(object sender, EventArgs e)
        {
            if (Finalvideo.IsRunning)
            {
                Finalvideo.Stop();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (Finalvideo.IsRunning)
            {
                Finalvideo.Stop();
            }

            Application.Exit();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                String portName = ComboBox2.Text;
                arduino.PortName = portName;
                arduino.BaudRate = 9600;
                arduino.Open();
                ToolStripTextBox1.Text = "bağlandı";
            }
            catch (Exception)
            {

                ToolStripTextBox1.Text = " Porta bağlanmadı ,uygun portu seçin";
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {

            try
            {
                arduino.Close();
                ToolStripTextBox1.Text = "Port bağlantısı kesildi ";
            }
            catch (Exception)
            {

                ToolStripTextBox1.Text = "İlk önce bağlan sonra bağlantıyı kes";
            }
        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
