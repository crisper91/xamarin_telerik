﻿using QSF.ViewModels;
using Xamarin.Forms;

namespace QSF.Examples.TemplatedPickerControl.FirstLookExample
{
    public class ColorViewModel : BindableBase
    {
        private string name;
        private Color color;
        private Color borderColor;

        public ColorViewModel(string name, string color)
            : this(name, Color.FromHex(color))
        {
        }

        public ColorViewModel(string name, Color color)
        {
            this.name = name;
            this.color = color;
            this.borderColor = Xamarin.Forms.Color.Transparent;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (this.name != value)
                {
                    this.name = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public Color Color
        {
            get
            {
                return this.color;
            }
            set
            {
                if (this.color != value)
                {
                    this.color = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public Color BorderColor
        {
            get
            {
                return this.borderColor;
            }
            set
            {
                if(this.borderColor != value)
                {
                    this.borderColor = value;
                    this.OnPropertyChanged();
                }
            }
        }
    }
}
