

using Emgu.CV;
using Emgu.CV.Structure;
namespace openCV
{
    public partial class FormMain : Form
    {
        private VideoCapture? _videoCapture = null;
        private Mat? _frame;
        private bool isCameraConnected = false;
        private bool isRecord = false;

        public FormMain()
        {
            InitializeComponent();
            Image<Bgr, byte> image = new Image<Bgr, byte>(@"Image\Disconnect.jpg");
            imageBoxLive.Image = image;
        }

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

        private void Connect_Click(object sender, EventArgs e)
        {
            try
            {
                camStatus.Text = "Waiting...";
                if (!isCameraConnected)
                {
                    _videoCapture = new VideoCapture();
                    _videoCapture.ImageGrabbed += ProcessFrame;
                    _frame = new Mat();

                    this.Connect.Text = "Disconnect";
                    camStatus.Text = "Connected";
                    this.Start.Enabled = true;
                    isCameraConnected = true;

                    Image<Bgr, byte> image = new Image<Bgr, byte>(@"Image\Connect.jpg");
                    imageBoxLive.Image = image;
                }
                else
                {
                    if (_videoCapture != null)
                    {
                        _videoCapture.Pause();
                        _videoCapture.Dispose();

                        this.Connect.Text = "Connect";
                        camStatus.Text = "Disconnect";
                        this.Start.Enabled = false;
                        isCameraConnected = false;

                        Image<Bgr, byte> image = new Image<Bgr, byte>(@"Image\Disconnect.jpg");
                        imageBoxLive.Image = image;
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
                    recStatus.Text = "Recording";
                    this.Connect.Enabled = false;
                    this.Start.Text = "Stop";
                    isRecord = true;
                }
                else
                {
                    _videoCapture.Stop();
                    recStatus.Text = "Stop Record";
                    this.Connect.Enabled = true;
                    this.Start.Text = "Start";
                    isRecord = false;
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


    }
}
