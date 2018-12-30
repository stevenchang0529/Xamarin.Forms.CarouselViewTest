using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Forms.CarouselViewTest
{

    public class DataModel
    {
        public List<string> Items { get; set; } = new List<string>();
        public DataModel()
        {
            for (int i = 0; i < 6; i++)
                this.Items.Add($"第{i}個");
        }
    }
}
