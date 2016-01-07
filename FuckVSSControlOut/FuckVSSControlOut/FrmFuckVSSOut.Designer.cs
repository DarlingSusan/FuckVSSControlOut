namespace FuckVSSControlOut
{
    partial class FrmFuckVSSOut
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuckVSSOut));
            this.btnStart = new System.Windows.Forms.Button();
            this.tbxDirectory = new System.Windows.Forms.TextBox();
            this.btnChooseDirect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(12, 87);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(320, 32);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始移除VSS控制代码";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbxDirectory
            // 
            this.tbxDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDirectory.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxDirectory.Location = new System.Drawing.Point(12, 52);
            this.tbxDirectory.Name = "tbxDirectory";
            this.tbxDirectory.Size = new System.Drawing.Size(320, 29);
            this.tbxDirectory.TabIndex = 1;
            // 
            // btnChooseDirect
            // 
            this.btnChooseDirect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseDirect.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChooseDirect.Location = new System.Drawing.Point(12, 12);
            this.btnChooseDirect.Name = "btnChooseDirect";
            this.btnChooseDirect.Size = new System.Drawing.Size(320, 34);
            this.btnChooseDirect.TabIndex = 2;
            this.btnChooseDirect.Text = "选择目录";
            this.btnChooseDirect.UseVisualStyleBackColor = true;
            this.btnChooseDirect.Click += new System.EventHandler(this.btnChooseDirect_Click);
            // 
            // FrmFuckVSSOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 137);
            this.Controls.Add(this.btnChooseDirect);
            this.Controls.Add(this.tbxDirectory);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFuckVSSOut";
            this.Text = "清除VSS控制小工具";
            this.Activated += new System.EventHandler(this.FrmFuckVSSOut_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbxDirectory;
        private System.Windows.Forms.Button btnChooseDirect;
    }
}