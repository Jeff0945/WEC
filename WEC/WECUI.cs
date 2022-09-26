using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WEC {
    public partial class WECUI : Form {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private DataProcessing dp;
        AccurateTimer aT;
        public WECUI() {
            InitializeComponent();
            dp = new DataProcessing();
            dp.mainUI = this;

            for (int i = 0; i < dp.CalibrationFrequencies.Count; i++)
                calibrationData.Rows.Add(dp.CalibrationFrequencies[i], 0);

            vScrollBar1.Maximum = calibrationData.RowCount - 6;
            calibrationData.HorizontalScrollingOffset = calibrationData.HorizontalScrollingOffset;

            for (int i = 0; i < Controls.Count; i++) {
                Controls[i].Click += focusClick;
                for (int n = 0; n < Controls[i].Controls.Count; n++) {
                    Controls[i].Controls[n].Click += focusClick;
                    for (int z = 0; z < Controls[i].Controls[n].Controls.Count; z++)
                        Controls[i].Controls[n].Controls[z].Click += focusClick;
                }
            }

            oV = false;
            trV = false;
            cV = false;
            prV = false;

            calibPanel.Location = new Point(1000, mainPanel.Location.Y);
            calibrationData.Columns[1].DefaultCellStyle.Format = "0.0";
            calibrationData.MouseWheel += CDScroll;
        }

        #region Events
        private void CDScroll(object sender, MouseEventArgs e) {
            if (e.Delta < 0 && vScrollBar1.Value < vScrollBar1.Maximum - 8)
                vScrollBar1.Value++;
            else if (vScrollBar1.Value > 0)
                vScrollBar1.Value--;
        }

        private void vScrollBar1_ValueChanged(object sender, EventArgs e) {
            calibrationData.FirstDisplayedScrollingRowIndex = vScrollBar1.Value;
        }

        private void focusClick(object sender, EventArgs e) {
            var control = (Control)sender;
            control.Focus();
        }

        private void offset_ValueChanged(object sender, EventArgs e) {
            dp.TROffset = (double)offset.Value;
        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e) { calibrationData.FirstDisplayedScrollingRowIndex = e.NewValue; }

        private void calibrationData_Scroll(object sender, ScrollEventArgs e) { vScrollBar1.Value = e.NewValue; }
        #endregion

        #region Move Window
        private void panel1_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region Close/Minimize Buttons
        private void button1_Click(object sender, EventArgs e) { Close(); }

        private void button2_Click(object sender, EventArgs e) { WindowState = FormWindowState.Minimized; }
        #endregion

        #region Graph Visibility
        bool oL = true, trL = true, cL = true, prL = true;
        private bool oV {
            get { return oL; }
            set {
                oL = value;
                if (oL) {
                    originalLabel.Image = Properties.Resources.bluec;
                    chart1.Series[0].Color = Color.FromArgb(82, 120, 209);
                } else {
                    originalLabel.Image = Properties.Resources.blue;
                    chart1.Series[0].Color = Color.FromArgb(0, 0, 0, 0);
                }
            }
        }

        public bool trV {
            get { return trL; }
            set {
                trL = value;
                if (value) {
                    trLabel.Image = Properties.Resources.orangec;
                    chart1.Series[1].Color = Color.FromArgb(255, 83, 65);
                    offset.Enabled = true;
                } else {
                    trLabel.Image = Properties.Resources.orange;
                    chart1.Series[1].Color = Color.FromArgb(0, 0, 0, 0);
                    offset.Enabled = false;
                }
            }
        }

        public bool cV {
            get { return cL; }
            set {
                cL = value;
                if (value) {
                    cLabel.Image = Properties.Resources.greenc;
                    chart1.Series[2].Color = Color.FromArgb(9, 170, 113);
                } else {
                    cLabel.Image = Properties.Resources.green;
                    chart1.Series[2].Color = Color.FromArgb(0, 0, 0, 0);
                }
            }
        }

        public bool prV {
            get { return prL; }
            set {
                prL = value;
                if (prL) {
                    prLabel.Image = Properties.Resources.purplec;
                    chart1.Series[3].Color = Color.FromArgb(232, 14, 225);
                } else {
                    prLabel.Image = Properties.Resources.purple;
                    chart1.Series[3].Color = Color.FromArgb(0, 0, 0, 0);
                }
            }
        }

        private void originalLabel_MouseUp(object sender, MouseEventArgs e) { 
            if (!shResponse.Text.Equals("Browse"))
                oV = !oV;
        }

        private void trLabel_MouseUp(object sender, MouseEventArgs e) {
            if (!shResponse.Text.Equals("Browse"))
                trV = !trV;
        }

        private void cLabel_MouseUp(object sender, MouseEventArgs e) { 
            if (cal)
                cV = !cV;
        }

        private void prLabel_MouseUp(object sender, MouseEventArgs e) { 
            if (cal)
                prV = !prV;
        }
        #endregion

        #region Browse Button Effects
        private void shResponse_MouseEnter(object sender, EventArgs e) {
            FontStyle fs = FontStyle.Bold;
            fs |= FontStyle.Underline;
            shResponse.Font = new Font(shResponse.Font.FontFamily, shResponse.Font.Size, fs);
        }

        private void shResponse_MouseLeave(object sender, EventArgs e) {
            FontStyle fs = FontStyle.Regular;
            fs |= FontStyle.Bold;
            shResponse.Font = new Font(shResponse.Font.FontFamily, shResponse.Font.Size, fs);
        }

        private void tResponse_MouseEnter(object sender, EventArgs e) {
            FontStyle fs = FontStyle.Bold;
            fs |= FontStyle.Underline;
            tResponse.Font = new Font(tResponse.Font.FontFamily, tResponse.Font.Size, fs);
        }

        private void tResponse_MouseLeave(object sender, EventArgs e) {
            FontStyle fs = FontStyle.Regular;
            fs |= FontStyle.Bold;
            tResponse.Font = new Font(tResponse.Font.FontFamily, tResponse.Font.Size, fs);
        }
        #endregion

        #region Browse Button Click
        private void shResponse_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                shResponse.Text = openFileDialog1.FileName;
                oV = true;
                dp.SHFrequencyResponse = openFileDialog1.FileName;
                saveFileDialog1.FileName = Path.GetFileNameWithoutExtension(openFileDialog1.FileName) + " Wavelet EQ.txt";
                savePath.Text = Environment.CurrentDirectory + '\\' + Path.GetFileNameWithoutExtension(openFileDialog1.FileName) + " Wavelet EQ.txt";
            }
        }

        private void tResponse_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                tResponse.Text = openFileDialog1.FileName;
                trV = true;
                dp.TFrequencyResponse = openFileDialog1.FileName;
            }
        }
        #endregion

        #region Back Button
        private void backButton_Click(object sender, EventArgs e) {
            dp.SwitchToMainPanel(mainPanel.Location.X);
            cal = false;
        }

        private void backButton_MouseEnter(object sender, EventArgs e) {
            backButton.BackColor = Color.FromArgb(82, 120, 209);
            backButton.ForeColor = Color.White;
        }

        private void backButton_MouseLeave(object sender, EventArgs e) {
            backButton.BackColor = Color.Transparent;
            backButton.ForeColor = Color.FromArgb(82, 120, 209);
        }
        #endregion

        #region Save Path
        private void savePath_Click(object sender, EventArgs e) {
            saveFileDialog1.FileName = Path.GetFileName(savePath.Text);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                savePath.Text = saveFileDialog1.FileName;
                if (!savePath.Text.EndsWith(".txt"))
                    savePath.Text += ".txt";
            }
        }

        private void savePath_MouseEnter(object sender, EventArgs e) {
            FontStyle fs = FontStyle.Bold;
            fs |= FontStyle.Underline;
            savePath.Font = new Font(savePath.Font.FontFamily, savePath.Font.Size, fs);
        }

        private void savePath_MouseLeave(object sender, EventArgs e) {
            FontStyle fs = FontStyle.Regular;
            fs |= FontStyle.Bold;
            savePath.Font = new Font(savePath.Font.FontFamily, savePath.Font.Size, fs);
        }
        #endregion

        #region Calibration
        bool cal = false;
        private void calibrationData_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            if (cal)
                dp.calChanged(Convert.ToDouble(calibrationData.Rows[e.RowIndex].Cells[1].Value), e.RowIndex);
        }

        private void saveEQ_MouseEnter(object sender, EventArgs e) {
            saveEQ.BackColor = Color.FromArgb(9, 170, 113);
            saveEQ.ForeColor = Color.White;
        }

        private void saveEQ_MouseLeave(object sender, EventArgs e) {
            saveEQ.BackColor = Color.Transparent;
            saveEQ.ForeColor = Color.FromArgb(9, 170, 113);
        }

        private void saveEQ_MouseClick(object sender, MouseEventArgs e) {
            StringBuilder calibData = new StringBuilder("GraphicEQ: ");
            for (int i = 0; i < dp.CalibrationFrequencies.Count; i++) {
                if (i == dp.CalibrationFrequencies.Count - 1)
                    calibData.Append(dp.CalibrationFrequencies[i].ToString() + ' ' + dp.Calibration[i].ToString("0.#"));
                else
                    calibData.Append(dp.CalibrationFrequencies[i].ToString() + ' ' + dp.Calibration[i].ToString("0.#") + "; ");
            }
            File.WriteAllText(savePath.Text, calibData.ToString());
            saveEQ.Text = "SAVED!";
            aT = new AccurateTimer(this, new Action(Time), 1000);
        }

        private void Time() {
            saveEQ.Text = "Save Equalizer Data";
            aT.Stop();
        }

        private void calibrateButton_Click(object sender, EventArgs e) {
            if (shResponse.Text.Equals("Browse"))
                MessageBox.Show("Please select a frequency response.");
            else {
                saveFileDialog1.FileName = Path.GetFileNameWithoutExtension(shResponse.Text) + " Wavelet EQ.txt";
                savePath.Text = Environment.CurrentDirectory + '\\' + Path.GetFileNameWithoutExtension(shResponse.Text) + " Wavelet EQ.txt";
                dp.SwitchToCalibPanel(mainPanel.Location.X);
                cal = true;
                cV = true;
                prV = true;
            }
        }

        private void calibrateButton_MouseEnter(object sender, EventArgs e) {
            calibrateButton.BackColor = Color.FromArgb(9, 170, 113);
            calibrateButton.ForeColor = Color.White;
        }

        private void calibrateButton_MouseLeave(object sender, EventArgs e) {
            calibrateButton.BackColor = Color.Transparent;
            calibrateButton.ForeColor = Color.FromArgb(9, 170, 113);
        }
        #endregion
    }
}