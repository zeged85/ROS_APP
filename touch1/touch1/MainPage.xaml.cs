using AiForms.Effects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace touch1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();






            var recognizer = AddTouch.GetRecognizer(container);

            recognizer.TouchBegin += (sender, e) => {
                Debug.WriteLine("TouchBegin");
            };

            recognizer.TouchMove += (sender, e) => {
                Debug.WriteLine("TouchMove");
                Debug.WriteLine($"X: {e.Location.X} Y:{e.Location.Y}");
            };

            recognizer.TouchEnd += (sender, e) => {
                Debug.WriteLine("TouchEnd");
            };

            recognizer.TouchCancel += (sender, e) => {
                Debug.WriteLine("TouchCancel");
            };

        }







    }





}
