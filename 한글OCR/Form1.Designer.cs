namespace 한글OCR
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PathBnt = new System.Windows.Forms.Button();
            this.PathText = new System.Windows.Forms.TextBox();
            this.START = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(27, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 239);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PathBnt
            // 
            this.PathBnt.Location = new System.Drawing.Point(440, 27);
            this.PathBnt.Name = "PathBnt";
            this.PathBnt.Size = new System.Drawing.Size(145, 23);
            this.PathBnt.TabIndex = 1;
            this.PathBnt.Text = "불러오기";
            this.PathBnt.UseVisualStyleBackColor = true;
            this.PathBnt.Click += new System.EventHandler(this.PathBnt_Click);
            // 
            // PathText
            // 
            this.PathText.Location = new System.Drawing.Point(591, 29);
            this.PathText.Name = "PathText";
            this.PathText.Size = new System.Drawing.Size(180, 21);
            this.PathText.TabIndex = 2;
            // 
            // START
            // 
            this.START.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.START.Location = new System.Drawing.Point(440, 70);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(331, 99);
            this.START.TabIndex = 3;
            this.START.Text = "판독";
            this.START.UseVisualStyleBackColor = true;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(27, 324);
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(744, 197);
            this.ResultBox.TabIndex = 4;
            this.ResultBox.TextChanged += new System.EventHandler(this.ResultBox_TextChanged);
            this.ResultBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ResultBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "판독결과";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "사진경로";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.START);
            this.Controls.Add(this.PathText);
            this.Controls.Add(this.PathBnt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button PathBnt;
        private System.Windows.Forms.TextBox PathText;
        private System.Windows.Forms.Button START;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
    }
}

