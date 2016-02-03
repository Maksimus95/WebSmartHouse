﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSmartHouse
{
    class Lamp : Device, IState
    {
        private int brightness;
        private System.Drawing.Color colorLight;

        private List<string> help;
        private List<System.Drawing.Color> colors;



        public Lamp(string name, bool state, int brightnes)
        {
            this.state = state;
            this.name = name;
            brightness = brightnes;
            colorLight = System.Drawing.Color.White;
            id = "Lamp";
        }


        public bool Switch()
        {
            if (this.state)
            {
                this.state = false;
            }
            else
            {
                this.state = true;
            }

            return this.state;
        }

        public override string ToString()
        {
            string state;
            if (this.state)
            {
                state = "Включен";
            }
            else
            {
                state = "Выключен";
            }
            return state;
        }

        public int BrightnesUp()
        {
            if (this.brightness < 100)
                this.brightness += 5;

            return this.brightness;
        }
        public int BrightnesDown()
        {
            if (this.brightness > 10)
                this.brightness += -5;

            return this.brightness;
        }

        public string BrightnessRetutn()
        {
            return Convert.ToString(this.brightness);
        }

        public void SelectColor(string idColor)
        {

            colors = new List<System.Drawing.Color>();

            colors.Add(System.Drawing.Color.White);
            colors.Add(System.Drawing.Color.Green);
            colors.Add(System.Drawing.Color.Blue);
            colors.Add(System.Drawing.Color.Red);
            colors.Add(System.Drawing.Color.Yellow);


            switch (idColor)
            {
                case "White":
                    colorLight = colors[0];
                    break;
                case "Green":
                    colorLight = colors[1];
                    break;
                case "Blue":
                    colorLight = colors[2];
                    break;
                case "Red":
                    colorLight = colors[3];
                    break;
                case "Yellow":
                    colorLight = colors[4];
                    break;

            }

        }

        public System.Drawing.Color ReturnColor()
        {
            return this.colorLight;
        }



        public List<string> Help()
        {
            help = new List<string>();
            string val;

            val = "Доступные команды:";
            help.Add(val);
            val = "ON  for switch on";
            help.Add(val);
            val = "OFF  for switch off";
            help.Add(val);
            val = "BR for change brightness";
            help.Add(val);
            val = "CL for change light`s color";
            help.Add(val);
            val = "del for delete";
            help.Add(val);
            val = "Press anykey for continue";
            help.Add(val);

            return help;

        }
    }
}
