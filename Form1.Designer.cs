namespace ConnectedComponentsMapping
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_SaveImage = new System.Windows.Forms.Button();
            this.button_SaveParam = new System.Windows.Forms.Button();
            this.button_getConnectedComponents = new System.Windows.Forms.Button();
            this.button_CreateImage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_GridY = new System.Windows.Forms.TextBox();
            this.textBox_GridX = new System.Windows.Forms.TextBox();
            this.textBox_SizeY = new System.Windows.Forms.TextBox();
            this.textBox_SizeX = new System.Windows.Forms.TextBox();
            this.pictureBoxEx1 = new PanelPictureBoxSet.PictureBoxEx();
            this.textBox_ComponentsHeightMax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_SaveImage
            // 
            this.button_SaveImage.Location = new System.Drawing.Point(286, 793);
            this.button_SaveImage.Name = "button_SaveImage";
            this.button_SaveImage.Size = new System.Drawing.Size(129, 36);
            this.button_SaveImage.TabIndex = 6;
            this.button_SaveImage.Text = "SaveImage";
            this.button_SaveImage.UseVisualStyleBackColor = true;
            this.button_SaveImage.Click += new System.EventHandler(this.button_SaveImage_Click);
            // 
            // button_SaveParam
            // 
            this.button_SaveParam.Location = new System.Drawing.Point(24, 796);
            this.button_SaveParam.Name = "button_SaveParam";
            this.button_SaveParam.Size = new System.Drawing.Size(129, 36);
            this.button_SaveParam.TabIndex = 7;
            this.button_SaveParam.Text = "SaveParam";
            this.button_SaveParam.UseVisualStyleBackColor = true;
            this.button_SaveParam.Click += new System.EventHandler(this.button_SaveParam_Click);
            // 
            // button_getConnectedComponents
            // 
            this.button_getConnectedComponents.Location = new System.Drawing.Point(27, 286);
            this.button_getConnectedComponents.Name = "button_getConnectedComponents";
            this.button_getConnectedComponents.Size = new System.Drawing.Size(353, 33);
            this.button_getConnectedComponents.TabIndex = 19;
            this.button_getConnectedComponents.Text = "GetConnectedComponents";
            this.button_getConnectedComponents.UseVisualStyleBackColor = true;
            this.button_getConnectedComponents.Click += new System.EventHandler(this.button_getConnectedComponents_Click);
            // 
            // button_CreateImage
            // 
            this.button_CreateImage.Location = new System.Drawing.Point(24, 152);
            this.button_CreateImage.Name = "button_CreateImage";
            this.button_CreateImage.Size = new System.Drawing.Size(353, 33);
            this.button_CreateImage.TabIndex = 20;
            this.button_CreateImage.Text = "CreateImage";
            this.button_CreateImage.UseVisualStyleBackColor = true;
            this.button_CreateImage.Click += new System.EventHandler(this.button_CreateImage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "GridY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "GridX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "SizeY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "SizeX";
            // 
            // textBox_GridY
            // 
            this.textBox_GridY.Location = new System.Drawing.Point(150, 107);
            this.textBox_GridY.Name = "textBox_GridY";
            this.textBox_GridY.Size = new System.Drawing.Size(100, 25);
            this.textBox_GridY.TabIndex = 8;
            this.textBox_GridY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_GridX
            // 
            this.textBox_GridX.Location = new System.Drawing.Point(24, 107);
            this.textBox_GridX.Name = "textBox_GridX";
            this.textBox_GridX.Size = new System.Drawing.Size(100, 25);
            this.textBox_GridX.TabIndex = 10;
            this.textBox_GridX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_SizeY
            // 
            this.textBox_SizeY.Location = new System.Drawing.Point(150, 39);
            this.textBox_SizeY.Name = "textBox_SizeY";
            this.textBox_SizeY.Size = new System.Drawing.Size(100, 25);
            this.textBox_SizeY.TabIndex = 11;
            this.textBox_SizeY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_SizeX
            // 
            this.textBox_SizeX.Location = new System.Drawing.Point(24, 39);
            this.textBox_SizeX.Name = "textBox_SizeX";
            this.textBox_SizeX.Size = new System.Drawing.Size(100, 25);
            this.textBox_SizeX.TabIndex = 12;
            this.textBox_SizeX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBoxEx1
            // 
            this.pictureBoxEx1.Location = new System.Drawing.Point(494, 12);
            this.pictureBoxEx1.Name = "pictureBoxEx1";
            this.pictureBoxEx1.Size = new System.Drawing.Size(681, 817);
            this.pictureBoxEx1.TabIndex = 22;
            // 
            // textBox_ComponentsHeightMax
            // 
            this.textBox_ComponentsHeightMax.Location = new System.Drawing.Point(27, 255);
            this.textBox_ComponentsHeightMax.Name = "textBox_ComponentsHeightMax";
            this.textBox_ComponentsHeightMax.Size = new System.Drawing.Size(100, 25);
            this.textBox_ComponentsHeightMax.TabIndex = 10;
            this.textBox_ComponentsHeightMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "ComponentsHeightMax";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 841);
            this.Controls.Add(this.pictureBoxEx1);
            this.Controls.Add(this.button_getConnectedComponents);
            this.Controls.Add(this.button_CreateImage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_GridY);
            this.Controls.Add(this.textBox_ComponentsHeightMax);
            this.Controls.Add(this.textBox_GridX);
            this.Controls.Add(this.textBox_SizeY);
            this.Controls.Add(this.textBox_SizeX);
            this.Controls.Add(this.button_SaveImage);
            this.Controls.Add(this.button_SaveParam);
            this.Name = "Form1";
            this.Text = "ConnectedComponentsMapping";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_SaveImage;
        private System.Windows.Forms.Button button_SaveParam;
        private System.Windows.Forms.Button button_getConnectedComponents;
        private System.Windows.Forms.Button button_CreateImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_GridY;
        private System.Windows.Forms.TextBox textBox_GridX;
        private System.Windows.Forms.TextBox textBox_SizeY;
        private System.Windows.Forms.TextBox textBox_SizeX;
        private PanelPictureBoxSet.PictureBoxEx pictureBoxEx1;
        private System.Windows.Forms.TextBox textBox_ComponentsHeightMax;
        private System.Windows.Forms.Label label5;
    }
}

