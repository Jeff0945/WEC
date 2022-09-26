using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;

namespace WEC {
    internal class DataProcessing {
        #region Frequency Response List
        private List<double> FixedDefault = new List<double>();
        private readonly char[] delims = { ' ', '\t', ',' };
        private string[] split;

        private readonly List<double> DefaultFrequencies = new List<double>() { 20, 20.2, 20.4, 20.61, 20.81, 21.02, 21.23, 21.44, 21.66, 21.87, 22.09, 22.31, 22.54, 22.76, 22.99, 23.22, 23.45, 23.69, 23.92, 24.16, 24.4, 24.65, 24.89, 25.14, 25.39, 25.65, 25.91, 26.16, 26.43, 26.69, 26.96, 27.23, 27.5, 27.77, 28.05, 28.33, 28.62, 28.9, 29.19, 29.48, 29.78, 30.08, 30.38, 30.68, 30.99, 31.3, 31.61, 31.93, 32.24, 32.57, 32.89, 33.22, 33.55, 33.89, 34.23, 34.57, 34.92, 35.27, 35.62, 35.97, 36.33, 36.7, 37.06, 37.43, 37.81, 38.19, 38.57, 38.95, 39.34, 39.74, 40.14, 40.54, 40.94, 41.35, 41.76, 42.18, 42.6, 43.03, 43.46, 43.9, 44.33, 44.78, 45.23, 45.68, 46.13, 46.6, 47.06, 47.53, 48.01, 48.49, 48.97, 49.46, 49.96, 50.46, 50.96, 51.47, 51.99, 52.51, 53.03, 53.56, 54.1, 54.64, 55.18, 55.74, 56.29, 56.86, 57.42, 58, 58.58, 59.16, 59.76, 60.35, 60.96, 61.57, 62.18, 62.8, 63.43, 64.07, 64.71, 65.35, 66.01, 66.67, 67.33, 68.01, 68.69, 69.37, 70.07, 70.77, 71.48, 72.19, 72.91, 73.64, 74.38, 75.12, 75.87, 76.63, 77.4, 78.17, 78.95, 79.74, 80.54, 81.35, 82.16, 82.98, 83.81, 84.65, 85.5, 86.35, 87.22, 88.09, 88.97, 89.86, 90.76, 91.66, 92.58, 93.51, 94.44, 95.39, 96.34, 97.3, 98.28, 99.26, 100.25, 101.25, 102.27, 103.29, 104.32, 105.37, 106.42, 107.48, 108.56, 109.64, 110.74, 111.85, 112.97, 114.1, 115.24, 116.39, 117.55, 118.73, 119.92, 121.12, 122.33, 123.55, 124.79, 126.03, 127.29, 128.57, 129.85, 131.15, 132.46, 133.79, 135.12, 136.48, 137.84, 139.22, 140.61, 142.02, 143.44, 144.87, 146.32, 147.78, 149.26, 150.75, 152.26, 153.78, 155.32, 156.88, 158.44, 160.03, 161.63, 163.24, 164.88, 166.53, 168.19, 169.87, 171.57, 173.29, 175.02, 176.77, 178.54, 180.32, 182.13, 183.95, 185.79, 187.65, 189.52, 191.42, 193.33, 195.27, 197.22, 199.19, 201.18, 203.19, 205.23, 207.28, 209.35, 211.44, 213.56, 215.69, 217.85, 220.03, 222.23, 224.45, 226.7, 228.96, 231.25, 233.57, 235.9, 238.26, 240.64, 243.05, 245.48, 247.93, 250.41, 252.92, 255.45, 258, 260.58, 263.19, 265.82, 268.48, 271.16, 273.87, 276.61, 279.38, 282.17, 284.99, 287.84, 290.72, 293.63, 296.57, 299.53, 302.53, 305.55, 308.61, 311.69, 314.81, 317.96, 321.14, 324.35, 327.59, 330.87, 334.18, 337.52, 340.9, 344.3, 347.75, 351.23, 354.74, 358.28, 361.87, 365.49, 369.14, 372.83, 376.56, 380.33, 384.13, 387.97, 391.85, 395.77, 399.73, 403.72, 407.76, 411.84, 415.96, 420.12, 424.32, 428.56, 432.85, 437.18, 441.55, 445.96, 450.42, 454.93, 459.48, 464.07, 468.71, 473.4, 478.13, 482.91, 487.74, 492.62, 497.55, 502.52, 507.55, 512.62, 517.75, 522.93, 528.16, 533.44, 538.77, 544.16, 549.6, 555.1, 560.65, 566.25, 571.92, 577.64, 583.41, 589.25, 595.14, 601.09, 607.1, 613.17, 619.3, 625.5, 631.75, 638.07, 644.45, 650.89, 657.4, 663.98, 670.62, 677.32, 684.1, 690.94, 697.85, 704.83, 711.87, 718.99, 726.18, 733.44, 740.78, 748.19, 755.67, 763.23, 770.86, 778.57, 786.35, 794.22, 802.16, 810.18, 818.28, 826.46, 834.73, 843.08, 851.51, 860.02, 868.62, 877.31, 886.08, 894.94, 903.89, 912.93, 922.06, 931.28, 940.59, 950, 959.5, 969.09, 978.78, 988.57, 998.46, 1008.44, 1018.53, 1028.71, 1039, 1049.39, 1059.88, 1070.48, 1081.19, 1092, 1102.92, 1113.95, 1125.09, 1136.34, 1147.7, 1159.18, 1170.77, 1182.48, 1194.3, 1206.25, 1218.31, 1230.49, 1242.8, 1255.22, 1267.78, 1280.45, 1293.26, 1306.19, 1319.25, 1332.45, 1345.77, 1359.23, 1372.82, 1386.55, 1400.41, 1414.42, 1428.56, 1442.85, 1457.28, 1471.85, 1486.57, 1501.43, 1516.45, 1531.61, 1546.93, 1562.4, 1578.02, 1593.8, 1609.74, 1625.84, 1642.1, 1658.52, 1675.1, 1691.85, 1708.77, 1725.86, 1743.12, 1760.55, 1778.15, 1795.94, 1813.9, 1832.03, 1850.36, 1868.86, 1887.55, 1906.42, 1925.49, 1944.74, 1964.19, 1983.83, 2003.67, 2023.71, 2043.94, 2064.38, 2085.03, 2105.88, 2126.94, 2148.2, 2169.69, 2191.38, 2213.3, 2235.43, 2257.78, 2280.36, 2303.17, 2326.2, 2349.46, 2372.95, 2396.68, 2420.65, 2444.86, 2469.31, 2494, 2518.94, 2544.13, 2569.57, 2595.27, 2621.22, 2647.43, 2673.9, 2700.64, 2727.65, 2754.93, 2782.48, 2810.3, 2838.4, 2866.79, 2895.46, 2924.41, 2953.65, 2983.19, 3013.02, 3043.15, 3073.58, 3104.32, 3135.36, 3166.72, 3198.38, 3230.37, 3262.67, 3295.3, 3328.25, 3361.53, 3395.15, 3429.1, 3463.39, 3498.03, 3533.01, 3568.34, 3604.02, 3640.06, 3676.46, 3713.22, 3750.36, 3787.86, 3825.74, 3864, 3902.64, 3941.66, 3981.08, 4020.89, 4061.1, 4101.71, 4142.73, 4184.15, 4226, 4268.26, 4310.94, 4354.05, 4397.59, 4441.56, 4485.98, 4530.84, 4576.15, 4621.91, 4668.13, 4714.81, 4761.96, 4809.58, 4857.67, 4906.25, 4955.31, 5004.87, 5054.91, 5105.46, 5156.52, 5208.08, 5260.16, 5312.77, 5365.89, 5419.55, 5473.75, 5528.49, 5583.77, 5639.61, 5696, 5752.96, 5810.49, 5868.6, 5927.28, 5986.56, 6046.42, 6106.89, 6167.96, 6229.64, 6291.93, 6354.85, 6418.4, 6482.58, 6547.41, 6612.88, 6679.01, 6745.8, 6813.26, 6881.39, 6950.21, 7019.71, 7089.91, 7160.81, 7232.41, 7304.74, 7377.79, 7451.56, 7526.08, 7601.34, 7677.35, 7754.13, 7831.67, 7909.98, 7989.08, 8068.98, 8149.67, 8231.16, 8313.47, 8396.61, 8480.57, 8565.38, 8651.03, 8737.54, 8824.92, 8913.17, 9002.3, 9092.32, 9183.25, 9275.08, 9367.83, 9461.51, 9556.12, 9651.68, 9748.2, 9845.68, 9944.14, 10043.58, 10144.02, 10245.46, 10347.91, 10451.39, 10555.91, 10661.46, 10768.08, 10875.76, 10984.52, 11094.36, 11205.31, 11317.36, 11430.53, 11544.84, 11660.29, 11776.89, 11894.66, 12013.6, 12133.74, 12255.08, 12377.63, 12501.41, 12626.42, 12752.68, 12880.21, 13009.01, 13139.1, 13270.49, 13403.2, 13537.23, 13672.6, 13809.33, 13947.42, 14086.9, 14227.77, 14370.04, 14513.74, 14658.88, 14805.47, 14953.52, 15103.06, 15254.09, 15406.63, 15560.7, 15716.3, 15873.47, 16032.2, 16192.52, 16354.45, 16517.99, 16683.17, 16850.01, 17018.51, 17188.69, 17360.58, 17534.18, 17709.53, 17886.62, 18065.49, 18246.14, 18428.6, 18612.89, 18799.02, 18987.01, 19176.88, 19368.65, 19562.33, 19757.96, 19955.54 };
        public readonly List<double> CalibrationFrequencies = new List<double>() { 20, 21, 22, 23, 24, 26, 27, 29, 30, 32, 34, 36, 38, 40, 43, 45, 48, 50, 53, 56, 59, 63, 66, 70, 74, 78, 83, 87, 92, 97, 103, 109, 115, 121, 128, 136, 143, 151, 160, 169, 178, 188, 199, 210, 222, 235, 248, 262, 277, 292, 309, 326, 345, 364, 385, 406, 429, 453, 479, 506, 534, 565, 596, 630, 665, 703, 743, 784, 829, 875, 924, 977, 1032, 1090, 1151, 1216, 1284, 1357, 1433, 1514, 1599, 1689, 1784, 1885, 1991, 2103, 2221, 2347, 2479, 2618, 2766, 2921, 3086, 3260, 3443, 3637, 3842, 4058, 4287, 4528, 4783, 5052, 5337, 5637, 5955, 6290, 6644, 7018, 7414, 7831, 8272, 8738, 9230, 9749, 10298, 10878, 11490, 12137, 12821, 13543, 14305, 15110, 15961, 16860, 17809, 18812, 19871 };
        private List<double> FRFrequencies = new List<double>();
        private List<double> FrequencyResponse = new List<double>();
        private List<double> TRFrequencies = new List<double>() { 20, 20000 };
        private List<double> OTargetResponse = new List<double>() { 0, 0 };
        private List<double> TargetResponse = new List<double>() { 0, 0 };
        public List<double> Calibration = new List<double>();
        private List<double> PredictedResponse = new List<double>();
        #endregion

        #region Chart Animations
        private List<double> AFR = new List<double>();
        private List<double> ATR = new List<double>();
        private List<double> AC = new List<double>();
        private List<double> APR = new List<double>();
        #endregion

        #region Objects
        private Calculations calculations = new Calculations();
        private AccurateTimer aT;
        public WECUI mainUI;
        #endregion

        #region Animations
        int mainPanelPos = 0;
        bool a = true, b = true, c = true, d = true, initPanel = true;
        int ia = 0, ib = 0, ic = 0, id = 0, ipc = 0;

        private void startTimer() {
            if (aT != null && !aT.IsRunning)
                aT = new AccurateTimer(mainUI, new Action(ticked), 5);
            else if (aT == null)
                aT = new AccurateTimer(mainUI, new Action(ticked), 5);
        }

        private void ticked() {
            if (ia < AnimDuration + 1 && a == false) {
                for (int i = 0; i < FrequencyResponse.Count; i++)
                    AFR[i] = calculations.EaseInOut(ia, 0, FrequencyResponse[i]);
                if (ia == AnimDuration) {
                    a = true;
                    ia = 0;
                    mainUI.chart1.Series[0].Points.DataBindXY(FRFrequencies, FrequencyResponse);
                    mainUI.trV = true;
                    AFR.Clear();
                } else
                    mainUI.chart1.Series[0].Points.DataBindXY(FRFrequencies, AFR);
                ia++;
            }
            if (ib < AnimDuration + 1 && b == false) {
                for (int i = 0; i < TargetResponse.Count; i++)
                    ATR[i] = calculations.EaseInOut(ib, 0, TargetResponse[i]);
                if (ib == AnimDuration) {
                    b = true;
                    ib = 0;
                    mainUI.chart1.Series[1].Points.DataBindXY(TRFrequencies, TargetResponse);
                    ATR.Clear();
                } else
                    mainUI.chart1.Series[1].Points.DataBindXY(TRFrequencies, ATR);
                ib++;
            }
            if (ic < AnimDuration + 1 && c == false) {
                for (int i = 0; i < Calibration.Count; i++)
                    AC[i] = calculations.EaseInOut(ic, 0, Calibration[i]);
                if (ic == AnimDuration) {
                    c = true;
                    ic = 0;
                    mainUI.chart1.Series[2].Points.DataBindXY(CalibrationFrequencies, Calibration);
                    AC.Clear();
                } else
                    mainUI.chart1.Series[2].Points.DataBindXY(CalibrationFrequencies, AC);
                ic++;
            }
            if (id < AnimDuration + 1 && d == false) {
                for (int i = 0; i < PredictedResponse.Count; i++)
                    APR[i] = calculations.EaseInOut(id, 0, PredictedResponse[i]);
                if (id == AnimDuration) {
                    d = true;
                    id = 0;
                    mainUI.chart1.Series[3].Points.DataBindXY(FRFrequencies, PredictedResponse);
                    APR.Clear();
                } else
                    mainUI.chart1.Series[3].Points.DataBindXY(FRFrequencies, APR);
                id++;
            }
            if (ipc < AnimDuration + 1 && initPanel == false) {
                if (mainPanelPos == 220) {
                    mainUI.mainPanel.Location = new Point(Convert.ToInt32(calculations.EaseInOut(ipc, mainPanelPos, -560, 1)), mainUI.mainPanel.Location.Y);
                    mainUI.calibPanel.Location = new Point(Convert.ToInt32(calculations.EaseInOut(ipc, mainPanelPos + 780, 220, 1)), mainUI.mainPanel.Location.Y);
                    if (mainUI.mainPanel.Location.X == -560) {
                        initPanel = true;
                        ipc = 0;
                    }
                } else if (mainPanelPos == -560) {
                    mainUI.mainPanel.Location = new Point(Convert.ToInt32(calculations.EaseInOut(ipc, mainPanelPos, 220, 1)), mainUI.mainPanel.Location.Y);
                    mainUI.calibPanel.Location = new Point(Convert.ToInt32(calculations.EaseInOut(ipc, mainPanelPos + 780, 1000, 1)), mainUI.mainPanel.Location.Y);
                    if (mainUI.mainPanel.Location.X == 220) {
                        initPanel = true;
                        ipc = 0;
                    }
                }
                ipc++;
            }
            if ((a && b && c && d && initPanel) == true)
                aT.Stop();
        }
        #endregion

        #region Switch Panels
        public void SwitchToCalibPanel(int panelPosX) {
            AC.Clear();
            APR.Clear();
            Calibration.Clear();
            PredictedResponse.Clear();
            mainPanelPos = panelPosX;
            initPanel = false;
            double gain = 0;
            for (int i = 0; i < CalibrationFrequencies.Count; i++) {
                if (CalibrationFrequencies[i] <= FRFrequencies[FRFrequencies.Count - 1] && CalibrationFrequencies[i] >= FRFrequencies[0]) {
                    double left = calculations.Interpolate(TRFrequencies, TargetResponse, CalibrationFrequencies[i]);
                    double right = calculations.Interpolate(FRFrequencies, FrequencyResponse, CalibrationFrequencies[i]);
                    gain = Math.Round(left - right, 1);
                    if (left == -743 || right == -743)
                        gain = 0;
                    if (gain > 30)
                        gain = 30;
                    Calibration.Add(gain);
                    mainUI.calibrationData.Rows[i].Cells[1].Value = gain;
                } else if (i == CalibrationFrequencies.Count - 1 && FRFrequencies[FRFrequencies.Count - 1] < CalibrationFrequencies[CalibrationFrequencies.Count - 1]) {
                    double x0, y0, x1, y1, m, b;
                    x0 = FRFrequencies[FRFrequencies.Count - 2];
                    y0 = FrequencyResponse[FRFrequencies.Count - 2];
                    x1 = FRFrequencies[FRFrequencies.Count - 1];
                    y1 = FrequencyResponse[FRFrequencies.Count - 1];

                    m = (y1 - y0) / Math.Log10(x1 / x0);
                    b = y0 - (m * Math.Log10(x0));
                    gain = Math.Round((m * Math.Log10(CalibrationFrequencies[CalibrationFrequencies.Count - 1])) + b, 1) * -1;
                    Calibration.Add(gain);
                    mainUI.calibrationData.Rows[i].Cells[1].Value = gain;
                } else {
                    Calibration.Add(0);
                    mainUI.calibrationData.Rows[i].Cells[1].Value = 0;
                }
                AC.Add(0);
            }
            for (int i = 0; i < FRFrequencies.Count; i++) {
                if (FRFrequencies[i] <= CalibrationFrequencies[CalibrationFrequencies.Count - 1])
                    PredictedResponse.Add(Math.Round(FrequencyResponse[i] + calculations.Interpolate(CalibrationFrequencies, Calibration, FRFrequencies[i]), 1));
                else
                    PredictedResponse.Add(FrequencyResponse[i]);
                APR.Add(0);
            }
            mainUI.chart1.Series[2].Points.DataBindXY(CalibrationFrequencies, AC);
            mainUI.chart1.Series[3].Points.DataBindXY(FRFrequencies, APR);
            c = false;
            d = false;
            startTimer();
        }

        public void SwitchToMainPanel(int panelPosX) {
            mainPanelPos = panelPosX;
            initPanel = false;
            startTimer();
        }
        #endregion

        #region External Calls
        public void calChanged(double value, int index) {
            Calibration[index] = value;
            for (int i = 0; i < FRFrequencies.Count; i++) {
                if (FRFrequencies[i] <= CalibrationFrequencies[CalibrationFrequencies.Count - 1]) {
                    double inter = calculations.Interpolate(CalibrationFrequencies, Calibration, FRFrequencies[i]);
                    PredictedResponse[i] = Math.Round(FrequencyResponse[i] + inter, 1);
                    if (inter == -743)
                        PredictedResponse[i] = FrequencyResponse[i];
                }
                else
                    PredictedResponse[i] = FrequencyResponse[i];
            }
            mainUI.chart1.Series[2].Points.DataBindXY(CalibrationFrequencies, Calibration);
            mainUI.chart1.Series[3].Points.DataBindXY(FRFrequencies, PredictedResponse);
        }

        public int AnimDuration {
            get { return calculations.animationDuration; }
            set { calculations.animationDuration = value; }
        }

        public double TROffset {
            set { 
                for(int i = 0; i < TargetResponse.Count; i++)
                    TargetResponse[i] = OTargetResponse[i] + value;
                mainUI.chart1.Series[1].Points.DataBindXY(TRFrequencies, TargetResponse);
            }
        }
        #endregion

        #region Read Frequency Responses
        public string SHFrequencyResponse {
            set {
                AFR.Clear();
                FrequencyResponse.Clear();
                FRFrequencies.Clear();

                using (StreamReader sr = new StreamReader(value)) {
                    string line;
                    while ((line = sr.ReadLine()) != null) {
                        line = Regex.Replace(line, @"\s+", " ");
                        double result;
                        split = line.Split(delims);
                        if (double.TryParse(split[0], out result)) {
                            FRFrequencies.Add(Convert.ToDouble(split[0]));
                            FrequencyResponse.Add(Convert.ToDouble(split[1]));
                        }
                    }
                }

                if (FRFrequencies.Count > 695) {
                    for (int i = 0; i < DefaultFrequencies.Count; i++) {
                        double interpolated = calculations.Interpolate(FRFrequencies, FrequencyResponse, DefaultFrequencies[i]);
                        if (interpolated != -743) {
                            FixedDefault.Add(interpolated);
                            AFR.Add(0);
                        }
                    }
                    FRFrequencies.Clear();
                    FrequencyResponse.Clear();
                    FrequencyResponse.AddRange(FixedDefault);
                    for (int i = 0; i < FrequencyResponse.Count; i++)
                        FRFrequencies.Add(DefaultFrequencies[i]);
                } else
                    for (int i = 0; i < FRFrequencies.Count; i++)
                        AFR.Add(0);

                FrequencyResponse = calculations.NormalizeGraph(FRFrequencies, FrequencyResponse);
                mainUI.chart1.Series[0].Points.DataBindXY(FRFrequencies, AFR);
                startTimer();
                a = false;
                FixedDefault.Clear();
            }
        }

        public string TFrequencyResponse {
            set {
                ATR.Clear();
                TargetResponse.Clear();
                TRFrequencies.Clear();

                using (StreamReader sr = new StreamReader(value)) {
                    string line;
                    while ((line = sr.ReadLine()) != null) {
                        line = Regex.Replace(line, @"\s+", " ");
                        double result;
                        split = line.Split(delims);
                        if (double.TryParse(split[0], out result)) {
                            TRFrequencies.Add(Convert.ToDouble(split[0]));
                            TargetResponse.Add(Convert.ToDouble(split[1]));
                        }
                    }
                }

                if (!TRFrequencies.Contains(20)) {
                    TRFrequencies.Insert(0, 20);
                    TargetResponse.Insert(0, TargetResponse[0]);
                }

                if (TRFrequencies.Count > 695) {
                    for (int i = 0; i < DefaultFrequencies.Count; i++) {
                        double interpolated = calculations.Interpolate(TRFrequencies, TargetResponse, DefaultFrequencies[i]);
                        if (interpolated != -743) {
                            FixedDefault.Add(interpolated);
                            ATR.Add(0);
                        }
                    }
                    TRFrequencies.Clear();
                    TargetResponse.Clear();
                    TargetResponse.AddRange(FixedDefault);
                    for (int i = 0; i < TargetResponse.Count; i++)
                        TRFrequencies.Add(DefaultFrequencies[i]);
                } else
                    for (int i = 0; i < TRFrequencies.Count; i++)
                        ATR.Add(0);

                TargetResponse = calculations.NormalizeGraph(TRFrequencies, TargetResponse);
                startTimer();
                OTargetResponse.Clear();
                OTargetResponse.AddRange(TargetResponse);
                mainUI.offset.Enabled = true;
                b = false;
                FixedDefault.Clear();
            }
        }
        #endregion
    }
}