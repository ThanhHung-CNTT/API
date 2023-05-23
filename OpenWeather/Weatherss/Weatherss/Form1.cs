using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weatherss
{
    public partial class Form1 : Form
    {
        const string APPID = "";
        string cityID = "1566083";
        public Form1()
        {
            InitializeComponent();
            getWeather("1566083");
            //getForcast("1566083");

        }
        void getWeather(string city)
        {
            using (WebClient web  = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?id={0}&appid={1}&units=metric&cnt=6", city,APPID);
                var json = web.DownloadString(url);

                var result = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                WeatherInfo.root outPut = result;

                lbl_textCity.Text = string.Format("{0}", outPut.name);
                lbl_Country.Text = string.Format("{0}", outPut.sys.country);
                lbl_DoCe.Text = string.Format("{0} \u00B0" + "C", outPut.main.temp);


            }
        }
        //Vì giới hạn tài khoảng free, nên chỉ có thể gọi api lấy nhiệt độ mà thôi 
        //void getForcast(string city)
        //{
        //    int day = 2;
        //    string url = string.Format("https://api.openweathermap.org/data/2.5/forecast/weather?id={0}&units=metric&cnt={1}&appid={2}", city, day, APPID);
        //    using (WebClient web = new WebClient())
        //    {

        //        var json = web.DownloadString(url);

        //        var Object = JsonConvert.DeserializeObject<WeatherForcasts>(json);

        //        WeatherForcasts forcasts = Object;

        //        lbl_Con.Text = string.Format("{0}", forcasts.list[1].weather[0].main);
        //        lbl_Des.Text = string.Format("{0}", forcasts.list[1].weather[0].descriptions);
        //        lbl_Des2.Text = string.Format("{0} \u00B0" + "C", forcasts.list[1].temp);
        //        lbl_speed.Text = string.Format("{0}", forcasts.list[1].speed);
        //    }
        //}
    }
}
