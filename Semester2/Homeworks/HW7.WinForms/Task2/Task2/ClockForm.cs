﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task2
{
    public partial class ClockForm : Form
    {
        public ClockForm()
        {
            InitializeComponent();
            Width = diameter + 23;
            Height = diameter + 57;
        }

        /// <summary>
        /// Hand of the clock.
        /// </summary>
        private class Hand
        {
            /// <summary>
            /// Coordinates of the beginning of the clock hand.
            /// </summary>
            public Point Beginning { get; }

            /// <summary>
            /// Coordinates of the end of the clock hand.
            /// </summary>
            public Point End { get; }

            /// <summary>
            /// Pen for drawing the clock hand.
            /// </summary>
            public Pen Pen { get; }

            /// <summary>
            /// Initializes a new instance of the <see cref="Hand"/> class.
            /// </summary>
            /// <param name="beginning">Coordinates of the beginning</param>
            /// <param name="end">Coordinates of the end</param>
            /// <param name="pen">Pen for drawing</param>
            public Hand(Point beginning, Point end, Pen pen)
            {
                Beginning = beginning;
                End = end;
                Pen = pen;
            }
        }

        /// <summary>
        /// Radius of the clock.
        /// </summary>
        private const int radius = 200;
        private const int diameter = 2 * radius;

        private Hand secondHand;
        private Hand minuteHand;
        private Hand hourHand;

        private Graphics graphics;
        private Bitmap bitmap;

        /// <summary>
        /// Draws the clock face and initializes clock hands during form load.
        /// </summary>
        private void ClockFormLoad(object sender, EventArgs e)
        {
            bitmap = new Bitmap(diameter + 1, diameter + 1);
            graphics = Graphics.FromImage(bitmap);

            DrawClockFace();

            secondHand = new Hand(new Point(0, -20), new Point(0, radius - 10), new Pen(Brushes.Red, 1));
            minuteHand = new Hand(new Point(0, -15), new Point(0, radius - 20), new Pen(Brushes.Black, 2));
            hourHand = new Hand(new Point(0, -10), new Point(0, radius - 60), new Pen(Brushes.Gray, 5));

            TimerTick(timer, EventArgs.Empty);
        }

        /// <summary>
        /// Draws a circle with numbers.
        /// </summary>
        private void DrawClockFace()
        {
            graphics.DrawEllipse(new Pen(Color.Black, 2), 0, 0, diameter, diameter);

            graphics.DrawEllipse(new Pen(Color.Black, 8), radius - 3, radius - 3, 6, 6);

            graphics.DrawString("12", new Font("Arial", 12), Brushes.Black, radius - 18, 5);
            graphics.DrawString("3", new Font("Arial", 12), Brushes.Black, diameter - 25, radius - 12);            
            graphics.DrawString("6", new Font("Arial", 12), Brushes.Black, radius - 10, diameter - 30);
            graphics.DrawString("9", new Font("Arial", 12), Brushes.Black, 3, radius - 12);

            graphics.DrawString("1", new Font("Arial", 12), Brushes.Black, radius + 75, 35);
            graphics.DrawString("2", new Font("Arial", 12), Brushes.Black, diameter - 60, 100);
            graphics.DrawString("4", new Font("Arial", 12), Brushes.Black, diameter - 60, diameter - 125);
            graphics.DrawString("5", new Font("Arial", 12), Brushes.Black, radius + 75, diameter - 60);

            graphics.DrawString("7", new Font("Arial", 12), Brushes.Black, radius - 100, diameter - 60);
            graphics.DrawString("8", new Font("Arial", 12), Brushes.Black, 35, diameter - 125);
            graphics.DrawString("10", new Font("Arial", 12), Brushes.Black, 35, 100);
            graphics.DrawString("11", new Font("Arial", 12), Brushes.Black, radius - 100, 35);         
        }

        /// <summary>
        /// Draws clock hands every timer tick.
        /// </summary>
        private void TimerTick(object sender, EventArgs e)
        {
            Text = DateTime.Now.ToString("HH:mm:ss");

            var tickBitmap = (Bitmap)bitmap.Clone();
            graphics = Graphics.FromImage(tickBitmap);
            graphics.TranslateTransform(radius, radius);
            graphics.ScaleTransform(1, -1);

            var ms = DateTime.Now.Millisecond;
            var sec = DateTime.Now.Second;
            var min = DateTime.Now.Minute;
            var hour = DateTime.Now.Hour;

            DrawHand(secondHand, 360 / 60 * (sec + 1.0 / 1000 * ms));
            DrawHand(minuteHand, 360 / 60 * (min + 1.0 / 60 * sec));
            DrawHand(hourHand, 360 / 12 * (hour + 1.0 / 60 * min));

            pictureBox.Image = tickBitmap;
        }

        /// <summary>
        /// Draws a clock hand.
        /// </summary>
        /// <param name="hand">Clock hand</param>
        /// <param name="angle">Rotation angle clockwise from the 12 o'clock position</param>
        private void DrawHand(Hand hand, double angle)
        {
            var newBeginning = RotateAroundOrigin(hand.Beginning, -angle);
            var newEnd = RotateAroundOrigin(hand.End, -angle);

            graphics.DrawLine(hand.Pen, newBeginning, newEnd);
        }

        /// <summary>
        /// Rotates a point around the origin.
        /// </summary>
        /// <param name="point">Сoordinates of the point</param>
        /// <param name="angle">Rotation angle in degrees</param>
        /// <returns>Сoordinates of the new point</returns>
        private PointF RotateAroundOrigin(PointF point, double angle)
        {
            double angleInRadians = angle * Math.PI / 180;
            var newX = (float)(point.X * Math.Cos(angleInRadians) - point.Y * Math.Sin(angleInRadians));
            var newY = (float)(point.X * Math.Sin(angleInRadians) + point.Y * Math.Cos(angleInRadians));
            return new PointF(newX, newY);
        }
    }
}
