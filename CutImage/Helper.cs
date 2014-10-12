using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace CutImg
{
    public  class Helper
    {
        public  static void DrawImg1( string sourceFile  ,string savePath ,int startIndex)
        {
            int iStep = 256;
            int iLeft = 0, iTop = 0, iWidth = iStep, iHeight = iStep;
            // 加载图片
            System.Drawing.Image image = new System.Drawing.Bitmap( sourceFile );
			int curStep = startIndex;
            int heightCount = image.Height % iStep == 0 ? image.Height / iStep : image.Height / iStep + 1;
            int weightCount = image.Width / iStep == 0 ? image.Width / iStep : image.Width / iStep + 1;
            for (int i = 0; i < heightCount; i++)
            {
                iTop = i * iStep;
                for (int j = 0; j < weightCount; j++)
                {

                    iLeft = j * iStep;

                    // 目标区域
                    Rectangle destRect = new Rectangle(0, 0, iWidth, iHeight);
                  
                    // 源图区域
                    Rectangle srcRect = new Rectangle(iLeft, iTop, iWidth, iHeight);

                    // 新建Graphics对象
                    System.Drawing.Image newImage = new Bitmap(iWidth, iHeight, PixelFormat.Format32bppRgb);
                    


                    Graphics g = Graphics.FromImage(newImage);
                    //Brush blackBrush = new SolidBrush(Color.FromArgb(13,13,13));
                    //g.FillRectangle(blackBrush, destRect);
                    

                    //// 绘图平滑程序
                    //g.SmoothingMode = SmoothingMode.HighSpeed;

                    //// 图片输出质量
                    //g.CompositingQuality = CompositingQuality.HighSpeed;
                    g.Clear(Color.FromArgb(221,221,221));


                    // 输出到newImage对象
                    g.DrawImage(image, destRect, srcRect, GraphicsUnit.Pixel);

                    // 释放绘图对象
                    g.Dispose();


                    //string strDestFile = string.Format("{0}\\x{1}y{2}.jpg",tbDestPath.Text, iLeft, iTop, iStep );
					string strDestFile = string.Format("{0}\\{1},{2}.jpg", savePath, i + curStep, j);
                    
                    newImage.Save(strDestFile);
                    newImage.Dispose();
                    GC.Collect(); 
                    GC.WaitForPendingFinalizers();
                }
            }

            // 释放图像资源
            image.Dispose();
        }

        private static void DrawImg()
        {
            int iStep = 256;
            int iLeft = 0, iTop = 0, iWidth = iStep, iHeight = iStep;
            // 加载图片
            System.Drawing.Image image = new System.Drawing.Bitmap(GetConfig("sourceFile"));
            int heightCount = image.Height % iStep == 0 ? image.Height / iStep : image.Height / iStep + 1;
            int weightCount = image.Width / iStep==0?image.Width / iStep:image.Width / iStep+1;
            for (int i = 0; i < heightCount; i++)
            {
                iTop = i * iStep;
                for (int j = 0; j < weightCount; j++)
                {

                    iLeft = j * iStep;

                    // 目标区域
                    Rectangle destRect = new Rectangle(0, 0, iWidth, iHeight);
                    // 源图区域
                    Rectangle srcRect = new Rectangle(iLeft, iTop, iWidth, iHeight);

                    // 新建Graphics对象
                    Bitmap newImage = new Bitmap(iWidth, iHeight);
                    Graphics g = Graphics.FromImage(newImage);

                    // 绘图平滑程序
                    g.SmoothingMode = SmoothingMode.HighSpeed;

                    // 图片输出质量
                    g.CompositingQuality = CompositingQuality.HighSpeed;

                    // 输出到newImage对象
                    g.DrawImage(image, destRect, srcRect, GraphicsUnit.Pixel);

                    // 释放绘图对象
                    g.Dispose();


                    //string strDestFile = string.Format("{0}\\x{1}y{2}.jpg",tbDestPath.Text, iLeft, iTop, iStep );
                    string strDestFile = string.Format("{0}\\{1},{2}.jpg", GetConfig("saveDirectory"), i, j);
                    newImage.Save(strDestFile);

                }
            }

            // 释放图像资源
            image.Dispose();
        }

        /// <summary>
        /// 读取配置文件的节点值
        /// </summary>
        /// <param name="key">节点名</param>
        public static string GetConfig(string key)
        {
            return System.Configuration.ConfigurationSettings.AppSettings[key];
        }
    }
}
