

using System.Threading;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
namespace openCV
{
    public partial class FormMain : Form
    {
        private VideoCapture? _videoCapture = null;
        private Mat? _frame;
        private CascadeClassifier _faceDetector;
        private bool isCameraConnected = false;
        private bool isRecord = false;

        public FormMain()
        {
            InitializeComponent();
            Image<Bgr, byte> image = new Image<Bgr, byte>(@"Image\Disconnect.jpg");
            imageBoxLive.Image = image;

            try
            {
                string haarcascadePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "haarcascade_frontalface_default.xml");
                if (!File.Exists(haarcascadePath))
                {
                    throw new FileNotFoundException("Haarcascade model file not found.", haarcascadePath);
                }
                _faceDetector = new CascadeClassifier(haarcascadePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Haarcascade model: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*
        private void ProcessFrame(object sender, EventArgs e)
        {
            if (_videoCapture != null && _videoCapture.Ptr != IntPtr.Zero)
            {
                bool canCapture = _videoCapture.Retrieve(_frame, 0);
                if (canCapture)
                {
                    imageBoxLive.Image = _frame;
                }
            }
        }
        */
        private void ProcessFrame(object sender, EventArgs e)
        {
            if (_videoCapture != null && _videoCapture.Ptr != IntPtr.Zero)
            {
                bool canCapture = _videoCapture.Retrieve(_frame, 0);
                if (canCapture)
                {
                    // Convert the frame to grayscale for face detection
                    var grayFrame = _frame.ToImage<Gray, byte>();

                    // Detect faces in the grayscale image
                    var faces = _faceDetector.DetectMultiScale(grayFrame, 1.1, 10, new Size(20, 20));

                    if (faces.Length > 0)
                    {
                        // Process the first detected face
                        var face = faces[0]; // Select the first face for simplicity

                        // Draw a rectangle around the face in the live view
                        CvInvoke.Rectangle(_frame, face, new Bgr(Color.Red).MCvScalar, 2); // สีแดง

                        // Expand the face region (add padding)
                        var padding = 20; // Adjust padding as needed
                        int x = Math.Max(0, face.X - padding);
                        int y = Math.Max(0, face.Y - padding);
                        int width = Math.Min(_frame.Width - x, face.Width + 2 * padding);
                        int height = Math.Min(_frame.Height - y, face.Height + 2 * padding);
                        var extendedFaceRegion = new Rectangle(x, y, width, height);

                        // Crop the extended face region from the grayscale image
                        var faceRegionGray = grayFrame.GetSubRect(extendedFaceRegion);

                        // Resize the cropped grayscale face to fit in the PictureBox
                        var resizedFaceGray = faceRegionGray.Resize(pictureBoxGray.Width, pictureBoxGray.Height, Inter.Linear);

                        // Display the cropped grayscale face in the PictureBox
                        pictureBoxGray.Image = resizedFaceGray.ToBitmap();
                        pictureBoxGray.BackColor = Color.Transparent; // พื้นหลังใสเมื่อมีใบหน้า
                    }
                    else
                    {
                        // Clear PictureBox if no face is detected
                        pictureBoxGray.Image = null;

                        // Set background to gray when no face is detected
                        pictureBoxGray.BackColor = Color.Gray;
                    }

                    // Update the live view with the rectangles drawn
                    imageBoxLive.Image = _frame;
                }
            }
        }




















        private async void Connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isCameraConnected)
                {
                    camStatus.Text = "Waiting...";
                    await Task.Delay(500);
                    await Task.Run(() =>
                    {
                        _videoCapture = new VideoCapture();
                        _videoCapture.ImageGrabbed += ProcessFrame;
                        _frame = new Mat();
                    });

                    SetConnectedStatus();

                }
                else
                {
                    if (_videoCapture != null)
                    {
                        _videoCapture.Pause();
                        _videoCapture.Dispose();
                        SetDisconnectedStatus();
                    }
                }
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (_videoCapture != null)
            {
                recStatus.Text = "Waiting...";
                if (!isRecord)
                {
                    _videoCapture.Start();
                    SetRecordingStatus();
                }
                else
                {
                    _videoCapture.Stop();
                    SetStoppedRecordingStatus();
                }
            }
        }

        private void FlipHor_Click(object sender, EventArgs e)
        {
            if (_videoCapture != null)
            {
                _videoCapture.FlipHorizontal = !_videoCapture.FlipHorizontal;
            }
        }

        private void FlipVer_Click(object sender, EventArgs e)
        {
            if (_videoCapture != null)
            {
                _videoCapture.FlipVertical = !_videoCapture.FlipVertical;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string formatClock = "HH:mm:ss";
            string formatDate = "yyyy-MMM-dd";

            DateTime dateTime = DateTime.Now;
            time.Text = dateTime.ToString(formatClock);
            dateset.Text = dateTime.ToString(formatDate);
        }

        #region Status
        private void SetConnectedStatus()
        {
            this.Connect.Text = "Disconnect";
            camStatus.Text = "Connected";
            this.Start.Enabled = true;
            isCameraConnected = true;

            Image<Bgr, byte> image = new Image<Bgr, byte>(@"Image\Connect.jpg");
            imageBoxLive.Image = image;
        }

        private void SetDisconnectedStatus()
        {
            this.Connect.Text = "Connect";
            camStatus.Text = "Disconnected";
            this.Start.Enabled = false;
            isCameraConnected = false;

            Image<Bgr, byte> image = new Image<Bgr, byte>(@"Image\Disconnect.jpg");
            imageBoxLive.Image = image;
        }

        private void SetRecordingStatus()
        {
            recStatus.Text = "Recording";
            this.Connect.Enabled = false;
            this.Start.Text = "Stop";
            isRecord = true;
        }

        private void SetStoppedRecordingStatus()
        {
            recStatus.Text = "Stopped";
            this.Connect.Enabled = true;
            this.Start.Text = "Start";
            isRecord = false;
        }
        #endregion

    }
}
