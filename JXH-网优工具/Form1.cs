using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JXH_网优工具
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gMapControl1.ShowCenter = false; //不显示中心十字点
            gMapControl1.DragButton = MouseButtons.Left; //左键拖拽地图
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly; //服务器模式
            gMapControl1.MapProvider = GMapProviders.GoogleChinaHybridMap;
        }
    }
}
