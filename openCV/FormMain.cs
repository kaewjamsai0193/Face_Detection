
using Emgu.CV;
using Emgu.CV.Structure;
namespace openCV
{
    public partial class FormMain : Form
    {
        private VideoCapture _camera;
        private VideoWriter _videoWriter;
        private CascadeClassifier? _faceDetector;

        private bool _isRecording = false;
        private bool isCameraConnected = false;
        private bool isRecord = false;

        private string selectedFolderPath = string.Empty;
        public FormMain()
        {
            
            InitializeComponent();

            //กำหนดสถานะ status เริ่มต้น
            SetConnectedStatus("disconnect");
            SetRecordingStatus("stop");

            snapshotTimer.Tick += (s, e) => SaveSnapshot();
            Snipshot.CheckedChanged += (s, e) => UpdateSnapshotTimer();
            sectime.ValueChanged += (s, e) => UpdateSnapshotTimer();
            
            Browse.Enabled = false;
            Recognizer.Enabled = false;
            Snipshot.Enabled = false;
            //โหลด model face detection
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
        private void ProcessFrame(object sender, EventArgs e)
        {
            try
            {
                if (_camera != null && _camera.Ptr != IntPtr.Zero)
                {
                    var frame = new Mat();
                    _camera.Retrieve(frame);
                    var image = frame.ToImage<Bgr, byte>();

                    // Convert to grayscale and display
                    var grayImage = image.Convert<Gray, byte>();

                    // Detect faces
                    if (_faceDetector != null)
                    {
                        var faces = _faceDetector.DetectMultiScale(grayImage, 1.1, 10, Size.Empty);

                        foreach (var face in faces)
                        {
                            image.Draw(face, new Bgr(Color.Red), 2); // Draw rectangle around face
                        }

                        // Crop the first detected face and display in grayscale
                        if (faces.Length > 0)
                        {
                            var faceRect = faces[0];
                            var faceImage = grayImage.Copy(faceRect);
                            var resizedFaceImage = faceImage.Resize(pictureBoxGray.Width, pictureBoxGray.Height, Emgu.CV.CvEnum.Inter.Linear);
                            pictureBoxGray.Image = resizedFaceImage.ToBitmap();
                        }
                        else
                        {
                            pictureBoxGray.Image = null;
                        }

                        live.Image = image.ToBitmap();

                        if (_isRecording && _videoWriter != null)
                        {
                            _videoWriter.Write(frame);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing frame: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #region Button
        private async void Connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isCameraConnected)
                {
                    camStatus.Text = "WAITING...";
                    camStatus.BackColor = Color.Cyan;
                    camStatus.ForeColor = Color.Black;

                    await Task.Run(() =>
                    {
                        _camera = new VideoCapture(0);
                        _camera.ImageGrabbed += ProcessFrame;
                    });

                    SetConnectedStatus("connect");
                    Recognizer.Enabled = true;
                    Snipshot.Enabled = true;
                    logbox.Text = $"---------- Program is Connected ----------{Environment.NewLine}";
                    logbox.TextAlign = HorizontalAlignment.Center;
                }
                else
                {
                    _camera?.Pause();
                    _camera?.Dispose();
                    SetConnectedStatus("disconnect");
                    Recognizer.Enabled = false;
                    Recognizer.Checked = false;
                    Snipshot.Enabled = false;
                    Snipshot.Checked = false;
                    logbox.Text = $"---------- Program is Disconnect ----------{Environment.NewLine}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void Start_Click(object sender, EventArgs e)
        {
            if (_camera == null) return;

            if (Snipshot.Checked && string.IsNullOrEmpty(selectedFolderPath))
            {
                MessageBox.Show("กรุณาเลือกโฟลเดอร์สำหรับบันทึกภาพก่อนการจับภาพ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            recStatus.Text = "WAITING...";
            recStatus.BackColor = Color.Cyan;
            recStatus.ForeColor = Color.Black;

            if (isRecord)
            {
                await Task.Run(() => _camera.Stop());
                SetRecordingStatus("pause");
                ToggleControls(true);
                logbox.Text += $"---------- Stop Recond ----------{Environment.NewLine}";
                snapshotTimer.Stop(); // หยุดจับภาพเมื่อ Pause
            }
            else
            {
                await Task.Run(() => _camera.Start());
                SetRecordingStatus("record");
                logbox.Text = $"---------- Start Reconding ----------{Environment.NewLine}";
                ToggleControls(false);

                // เริ่มจับภาพเฉพาะเมื่อ Snipshot ถูกเลือก
                if (Snipshot.Checked)
                {
                    UpdateSnapshotTimer();
                }
            }
        }


        #endregion

        #region Time
        private void timer1_Tick(object sender, EventArgs e)
        {
            string formatClock = "HH:mm:ss";
            string formatDate = "yyyy-MMM-dd";

            DateTime dateTime = DateTime.Now;
            time.Text = dateTime.ToString(formatClock);
            dateset.Text = dateTime.ToString(formatDate);
        }
        #endregion

        #region Status
        private void SetConnectedStatus(string status)
        {
            bool isConnected = status == "connect";

            Connect.Text = isConnected ? "DISCONNECT" : "CONNECT";
            camStatus.Text = isConnected ? "CONNECT" : "DISCONNECT";

            camStatus.BackColor = isConnected ? Color.Green : Color.Red;
            camStatus.ForeColor = Color.White;

            Start.Enabled = isConnected;

            isCameraConnected = isConnected;

        }

        private void SetRecordingStatus(string status)
        {
            bool isRecording = status == "record";

            recStatus.Text = isRecording ? "Recording" : "Pause";
            recStatus.BackColor = isRecording ? Color.Green : Color.Red;
            recStatus.ForeColor = Color.White;

            Connect.Enabled = !isRecording;
            Start.Text = isRecording ? "Pause" : "Start";

            isRecord = isRecording;

        }
        private void ToggleControls(bool enable)
        {
            Browse.Enabled = enable;
            Snipshot.Enabled = enable;
            Recognizer.Enabled = enable;
            sectime.Enabled = enable;
        }
        #endregion

        #region Browse_Click
        private void Browse_Click(object sender, EventArgs e)
        {
            // ใช้ FolderBrowserDialog เพื่อเลือกโฟลเดอร์
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                // ถ้าเลือกโฟลเดอร์แล้ว
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFolderPath = folderDialog.SelectedPath; // เก็บที่อยู่ของโฟลเดอร์ที่เลือก
                    foldertext.Text = "โฟลเดอร์: " + selectedFolderPath; // แสดงที่อยู่โฟลเดอร์ใน Label (ถ้ามี)
                }
            }
        }
        #endregion

        #region checklist
        private void Recognizer_CheckedChanged(object sender, EventArgs e)
        {
            if (Recognizer.Checked) // ถ้า Recognizer ถูกติ๊ก
            {
                Snipshot.Checked = false;
            }
        }

        private void Snipshot_CheckedChanged(object sender, EventArgs e)
        {
            if (Snipshot.Checked)
            {
                Recognizer.Checked = false;
                Browse.Enabled = true;
                snapshotTimer.Stop(); // หยุดจับภาพก่อนกด Start
            }
            else
            {
                Browse.Enabled = false;
            }
        }

        #endregion


        private void SaveSnapshot()
        {
            // ตรวจสอบว่า pictureBoxGray มีภาพหรือไม่
            if (pictureBoxGray.Image != null)
            {
                // ตั้งชื่อไฟล์ snapshot ตามเวลา
                string filePath = Path.Combine(selectedFolderPath, $"snapshot_{DateTime.Now:yyyyMMdd_HHmmss}.png");
                pictureBoxGray.Image.Save(filePath, System.Drawing.Imaging.ImageFormat.Png); // บันทึกภาพ

                // แสดงข้อความใน log box เมื่อบันทึกภาพสำเร็จ
                logbox.AppendText($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] บันทึกภาพสำเร็จ: {filePath}{Environment.NewLine}");
            }
            else
            {
                // ถ้าไม่มีภาพใน pictureBoxGray
                logbox.AppendText($"No picture in pictureBoxGray {Environment.NewLine}");
                
            }
        }

        private void UpdateSnapshotTimer()
        {
            if (isRecord && Snipshot.Checked) // ตรวจสอบว่ากด Start หรือยัง
            {
                snapshotTimer.Interval = (int)sectime.Value * 1000;
                snapshotTimer.Start();
            }
            else
            {
                snapshotTimer.Stop();
            }
        }


    }
}
