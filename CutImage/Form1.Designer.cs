namespace CutImage
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.btnSavePath = new System.Windows.Forms.Button();
			this.txtImgPath = new System.Windows.Forms.TextBox();
			this.txtSavePath = new System.Windows.Forms.TextBox();
			this.txtIndex = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnBegin = new System.Windows.Forms.Button();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(412, 28);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(42, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "浏览";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnSavePath
			// 
			this.btnSavePath.Location = new System.Drawing.Point(412, 63);
			this.btnSavePath.Name = "btnSavePath";
			this.btnSavePath.Size = new System.Drawing.Size(42, 23);
			this.btnSavePath.TabIndex = 1;
			this.btnSavePath.Text = "浏览";
			this.btnSavePath.UseVisualStyleBackColor = true;
			this.btnSavePath.Click += new System.EventHandler(this.btnSavePath_Click);
			// 
			// txtImgPath
			// 
			this.txtImgPath.Location = new System.Drawing.Point(90, 30);
			this.txtImgPath.Name = "txtImgPath";
			this.txtImgPath.Size = new System.Drawing.Size(316, 21);
			this.txtImgPath.TabIndex = 2;
			// 
			// txtSavePath
			// 
			this.txtSavePath.Location = new System.Drawing.Point(90, 65);
			this.txtSavePath.Name = "txtSavePath";
			this.txtSavePath.Size = new System.Drawing.Size(316, 21);
			this.txtSavePath.TabIndex = 3;
			// 
			// txtIndex
			// 
			this.txtIndex.Location = new System.Drawing.Point(126, 103);
			this.txtIndex.Name = "txtIndex";
			this.txtIndex.Size = new System.Drawing.Size(52, 21);
			this.txtIndex.TabIndex = 4;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 5;
			this.label1.Text = "源图片：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(31, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 12);
			this.label2.TabIndex = 6;
			this.label2.Text = "保存到：";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(31, 106);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 12);
			this.label3.TabIndex = 7;
			this.label3.Text = "命名起始索引：";
			// 
			// btnBegin
			// 
			this.btnBegin.Location = new System.Drawing.Point(383, 128);
			this.btnBegin.Name = "btnBegin";
			this.btnBegin.Size = new System.Drawing.Size(71, 30);
			this.btnBegin.TabIndex = 8;
			this.btnBegin.Text = "开始";
			this.btnBegin.UseVisualStyleBackColor = true;
			this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(480, 170);
			this.Controls.Add(this.btnBegin);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtIndex);
			this.Controls.Add(this.txtSavePath);
			this.Controls.Add(this.txtImgPath);
			this.Controls.Add(this.btnSavePath);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnSavePath;
		private System.Windows.Forms.TextBox txtImgPath;
		private System.Windows.Forms.TextBox txtSavePath;
		private System.Windows.Forms.TextBox txtIndex;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnBegin;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
	}
}

