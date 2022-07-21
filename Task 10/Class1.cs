using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class Angle
    {
        public double degree;
        public double minute;
        public double second;
        public bool isCorrect = true;
        public double Degree
        {
            get
            {
                return degree;
            }
            set
            {
                if (degree < 0 || degree >=359)
                    isCorrect = false;
                else
                    degree = value;
            }
        }
        public double Minute
        {
            get
            {
                return minute;
            }
            set
            {
                if (minute < 0 || minute >=60)
                    isCorrect = false;
                else
                    Degree += value;
                minute = value;
            }
        }
        public double Second
        {
            get
            {
                return second;
            }
            set
            {
                if (second < 0 || second >= 60)
                    isCorrect = false;
                else
                    Minute += value;
                second = value;
            }
        }
        public double ToRadian()
        {
            return ((second / 3600 + minute / 60 + degree)* Math.PI / 180);
        }
    }
}

