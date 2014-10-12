using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CutImage
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
			txtImgPath.Text = openFileDialog1.FileName;
		}
			

		private void btnSavePath_Click(object sender, EventArgs e)
		{
			folderBrowserDialog1.ShowDialog();
			txtSavePath.Text = folderBrowserDialog1.SelectedPath;
		}

		private void btnBegin_Click(object sender, EventArgs e)
		{
			string sourImg = txtImgPath.Text.Trim();
			string savePath = txtSavePath.Text.Trim();
			int indexStep  = 0;
			try
			{
				indexStep = Convert.ToInt32(txtIndex.Text.Trim());
			}
			catch
			{
				MessageBox.Show("谁让你不输入数字的？？？" );
			}

			if (string.IsNullOrEmpty(sourImg) || string.IsNullOrEmpty(savePath)) return;

			CutImg.Helper.DrawImg1(sourImg ,savePath ,indexStep  );
			MessageBox.Show("恭喜你,切割成功。。。。");
		}
	}
}