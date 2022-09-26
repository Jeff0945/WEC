using System;
using System.Collections.Generic;

namespace WEC {
    internal class Calculations {

        public int animationDuration = 100;
        internal double EaseInOut(double time, double initialValue, double finalValue) {
            time /= animationDuration / 2;
            if (time < 1)
                return (finalValue - initialValue) / 2 * Math.Pow(time, 4) + initialValue;
            time -= 2;
            return -(finalValue - initialValue) / 2 * (Math.Pow(time, 4) - 2) + initialValue;
        }

        internal double EaseInOut(double time, double initialValue, double finalValue, int roundOffDecimalPlace) {
            time /= animationDuration / 2;
            if (time < 1)
                return Math.Round((finalValue - initialValue) / 2 * Math.Pow(time, 4) + initialValue, roundOffDecimalPlace);
            time -= 2;
            return Math.Round(-(finalValue - initialValue) / 2 * (Math.Pow(time, 4) - 2) + initialValue, roundOffDecimalPlace);
        }

        public List<double> NormalizeGraph(List<double> Frequencies, List<double> FrequencyResponse) {
            double difference = Interpolate(Frequencies, FrequencyResponse, 1000);
            for(int i = 0; i < FrequencyResponse.Count; i++)
                FrequencyResponse[i] = FrequencyResponse[i] - difference;
            return FrequencyResponse;
        }

        public double Interpolate(List<double> Frequencies, List<double> FrequencyResponse, double number) {
            double result = -743;
            int index = Search(Frequencies, number);
            double x0, y0, x1, y1, m, b;
            if (index != -1) {
                x0 = Frequencies[index];
                y0 = FrequencyResponse[index];
                x1 = Frequencies[index + 1];
                y1 = FrequencyResponse[index + 1];

                //m = (y1 - y0) / Math.Log10(x1 / x0);
                //b = y0 - (m * Math.Log10(x0));
                //result = (m * Math.Log10(number)) + b;
                result = ((y1 - y0) / Math.Log10(x1 / x0)) * Math.Log10(x0) + (y0 - (((y1 - y0) / Math.Log10(x1 / x0)) * Math.Log10(x0)));
            }
            return result;
        }

        private int Search(List<double> list, double value) {
            int index = -1;
            for (int i = 0; i < list.Count - 1; i++) {
                if (list[i] == value) {
                    index = i;
                    break;
                } else if (i < list.Count - 1) {
                    if (list[i + 1] > value) {
                        index = i;
                        break;
                    }
                }
            }
            return index;
        }
    }
}