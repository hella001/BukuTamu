using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace BukuTamu
{
    public partial class AmbilFoto : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        public string SavedFilePath { get; private set; }

        public AmbilFoto()
        {
            InitializeComponent();
            LoadVideoDevices();
        }

        private void LoadVideoDevices()
        {
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (videoDevices.Count == 0)
                {
                    MessageBox.Show("No video devices found.");
                    return;
                }

                foreach (FilterInfo device in videoDevices)
                {
                    MenuWebcam.Items.Add(device.Name);
                }

                MenuWebcam.SelectedIndex = 0;
                StartCamera();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading video devices: " + ex.Message);
            }
        }

        private void StartCamera()
        {
            try
            {
                if (videoSource != null && videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    videoSource.WaitForStop();
                }

                videoSource = new VideoCaptureDevice(videoDevices[MenuWebcam.SelectedIndex].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
                videoSource.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error starting video source: " + ex.Message);
            }
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                Bitmap img = (Bitmap)eventArgs.Frame.Clone();
                PreviewFoto.Image = img;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying video frame: " + ex.Message);
            }
        }

        private void BtnAmbil_Click(object sender, EventArgs e)
        {
            try
            {
                if (videoSource != null && videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    videoSource.WaitForStop();
                }

                if (PreviewFoto.Image != null)
                {
                    string tempFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sementara");
                    if (!Directory.Exists(tempFolderPath))
                    {
                        Directory.CreateDirectory(tempFolderPath);
                    }

                    string filePath = Path.Combine(tempFolderPath, Guid.NewGuid().ToString() + ".jpg");
                    PreviewFoto.Image.Save(filePath);
                    SavedFilePath = filePath;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error capturing photo: " + ex.Message);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void MenuWebcam_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartCamera();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
            base.OnFormClosing(e);
        }
    }
}