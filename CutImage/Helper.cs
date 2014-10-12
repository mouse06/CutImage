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
            // ����ͼƬ
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

                    // Ŀ������
                    Rectangle destRect = new Rectangle(0, 0, iWidth, iHeight);
                  
                    // Դͼ����
                    Rectangle srcRect = new Rectangle(iLeft, iTop, iWidth, iHeight);

                    // �½�Graphics����
                    System.Drawing.Image newImage = new Bitmap(iWidth, iHeight, PixelFormat.Format32bppRgb);
                    


                    Graphics g = Graphics.FromImage(newImage);
                    //Brush blackBrush = new SolidBrush(Color.FromArgb(13,13,13));
                    //g.FillRectangle(blackBrush, destRect);
                    

                    //// ��ͼƽ������
                    //g.SmoothingMode = SmoothingMode.HighSpeed;

                    //// ͼƬ�������
                    //g.CompositingQuality = CompositingQuality.HighSpeed;
                    g.Clear(Color.FromArgb(221,221,221));


                    // �����newImage����
                    g.DrawImage(image, destRect, srcRect, GraphicsUnit.Pixel);

                    // �ͷŻ�ͼ����
                    g.Dispose();


                    //string strDestFile = string.Format("{0}\\x{1}y{2}.jpg",tbDestPath.Text, iLeft, iTop, iStep );
					string strDestFile = string.Format("{0}\\{1},{2}.jpg", savePath, i + curStep, j);
                    
                    newImage.Save(strDestFile);
                    newImage.Dispose();
                    GC.Collect(); 
                    GC.WaitForPendingFinalizers();
                }
            }

            // �ͷ�ͼ����Դ
            image.Dispose();
        }

        private static void DrawImg()
        {
            int iStep = 256;
            int iLeft = 0, iTop = 0, iWidth = iStep, iHeight = iStep;
            // ����ͼƬ
            System.Drawing.Image image = new System.Drawing.Bitmap(GetConfig("sourceFile"));
            int heightCount = image.Height % iStep == 0 ? image.Height / iStep : image.Height / iStep + 1;
            int weightCount = image.Width / iStep==0?image.Width / iStep:image.Width / iStep+1;
            for (int i = 0; i < heightCount; i++)
            {
                iTop = i * iStep;
                for (int j = 0; j < weightCount; j++)
                {

                    iLeft = j * iStep;

                    // Ŀ������
                    Rectangle destRect = new Rectangle(0, 0, iWidth, iHeight);
                    // Դͼ����
                    Rectangle srcRect = new Rectangle(iLeft, iTop, iWidth, iHeight);

                    // �½�Graphics����
                    Bitmap newImage = new Bitmap(iWidth, iHeight);
                    Graphics g = Graphics.FromImage(newImage);

                    // ��ͼƽ������
                    g.SmoothingMode = SmoothingMode.HighSpeed;

                    // ͼƬ�������
                    g.CompositingQuality = CompositingQuality.HighSpeed;

                    // �����newImage����
                    g.DrawImage(image, destRect, srcRect, GraphicsUnit.Pixel);

                    // �ͷŻ�ͼ����
                    g.Dispose();


                    //string strDestFile = string.Format("{0}\\x{1}y{2}.jpg",tbDestPath.Text, iLeft, iTop, iStep );
                    string strDestFile = string.Format("{0}\\{1},{2}.jpg", GetConfig("saveDirectory"), i, j);
                    newImage.Save(strDestFile);

                }
            }

            // �ͷ�ͼ����Դ
            image.Dispose();
        }

        /// <summary>
        /// ��ȡ�����ļ��Ľڵ�ֵ
        /// </summary>
        /// <param name="key">�ڵ���</param>
        public static string GetConfig(string key)
        {
            return System.Configuration.ConfigurationSettings.AppSettings[key];
        }
    }
}
