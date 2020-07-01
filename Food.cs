using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Snake_1._0.Interface;

namespace Snake_1._0
{
    public class Food : IShow
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// 
        //public Food()                                      
        //{
        //}

        private Point origin;                              //定义二维点位置

        public Point Origin                               //封装
        {
            get { return origin; }
            set { origin = value; }
        }

        public void Display(Graphics g)                    //显示食物方法
        {
            SolidBrush b = new SolidBrush(Color.Red);      //定义红色画笔
            g.FillRectangle(b, origin.X, origin.Y, 15, 15);//画实心矩形  
        }

        public void UnDisplay(Graphics g)                  //消除食物方法
        {
            SolidBrush b = new SolidBrush(Color.SpringGreen);   //定义背景色画笔
            g.FillRectangle(b, origin.X, origin.Y, 15, 15);//用背景色重画原来矩形
        }
    }
}
