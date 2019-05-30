namespace Client {
    partial class MainForm {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlJoin = new System.Windows.Forms.Panel();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNickname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnJoinCancel = new System.Windows.Forms.Button();
            this.btnJoin_Join = new System.Windows.Forms.Button();
            this.pnlWaitScreen = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnJoin = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoginPW = new System.Windows.Forms.TextBox();
            this.txtLoginID = new System.Windows.Forms.TextBox();
            this.pnlJoin.SuspendLayout();
            this.pnlWaitScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlJoin
            // 
            this.pnlJoin.BackColor = System.Drawing.Color.OldLace;
            this.pnlJoin.Controls.Add(this.txtNickname);
            this.pnlJoin.Controls.Add(this.textBox2);
            this.pnlJoin.Controls.Add(this.textBox1);
            this.pnlJoin.Controls.Add(this.lblNickname);
            this.pnlJoin.Controls.Add(this.label4);
            this.pnlJoin.Controls.Add(this.label5);
            this.pnlJoin.Controls.Add(this.btnJoinCancel);
            this.pnlJoin.Controls.Add(this.btnJoin_Join);
            this.pnlJoin.Location = new System.Drawing.Point(249, 119);
            this.pnlJoin.Margin = new System.Windows.Forms.Padding(2);
            this.pnlJoin.Name = "pnlJoin";
            this.pnlJoin.Size = new System.Drawing.Size(506, 303);
            this.pnlJoin.TabIndex = 7;
            this.pnlJoin.Visible = false;
            // 
            // txtNickname
            // 
            this.txtNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtNickname.Location = new System.Drawing.Point(179, 164);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(288, 26);
            this.txtNickname.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(179, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(288, 26);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(179, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 26);
            this.textBox1.TabIndex = 8;
            // 
            // lblNickname
            // 
            this.lblNickname.AutoSize = true;
            this.lblNickname.Font = new System.Drawing.Font("타이포_크레파스 M", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickname.Location = new System.Drawing.Point(49, 166);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(118, 20);
            this.lblNickname.TabIndex = 5;
            this.lblNickname.Text = "NICKNAME :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("타이포_크레파스 M", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(47, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "PASSWORD :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("타이포_크레파스 M", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(126, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "ID :";
            // 
            // btnJoinCancel
            // 
            this.btnJoinCancel.FlatAppearance.BorderSize = 0;
            this.btnJoinCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoinCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnJoinCancel.Image")));
            this.btnJoinCancel.Location = new System.Drawing.Point(287, 219);
            this.btnJoinCancel.Name = "btnJoinCancel";
            this.btnJoinCancel.Size = new System.Drawing.Size(70, 48);
            this.btnJoinCancel.TabIndex = 3;
            this.btnJoinCancel.UseVisualStyleBackColor = true;
            this.btnJoinCancel.Click += new System.EventHandler(this.btnJoinCancel_Click);
            // 
            // btnJoin_Join
            // 
            this.btnJoin_Join.FlatAppearance.BorderSize = 0;
            this.btnJoin_Join.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoin_Join.Image = ((System.Drawing.Image)(resources.GetObject("btnJoin_Join.Image")));
            this.btnJoin_Join.Location = new System.Drawing.Point(161, 219);
            this.btnJoin_Join.Name = "btnJoin_Join";
            this.btnJoin_Join.Size = new System.Drawing.Size(120, 48);
            this.btnJoin_Join.TabIndex = 4;
            this.btnJoin_Join.UseVisualStyleBackColor = true;
            // 
            // pnlWaitScreen
            // 
            this.pnlWaitScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlWaitScreen.BackgroundImage")));
            this.pnlWaitScreen.Controls.Add(this.pictureBox1);
            this.pnlWaitScreen.Location = new System.Drawing.Point(11, 11);
            this.pnlWaitScreen.Margin = new System.Windows.Forms.Padding(2);
            this.pnlWaitScreen.Name = "pnlWaitScreen";
            this.pnlWaitScreen.Size = new System.Drawing.Size(1000, 550);
            this.pnlWaitScreen.TabIndex = 8;
            this.pnlWaitScreen.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnJoin
            // 
            this.btnJoin.BackColor = System.Drawing.Color.Transparent;
            this.btnJoin.FlatAppearance.BorderSize = 0;
            this.btnJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoin.ForeColor = System.Drawing.Color.White;
            this.btnJoin.Image = ((System.Drawing.Image)(resources.GetObject("btnJoin.Image")));
            this.btnJoin.Location = new System.Drawing.Point(578, 356);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(75, 23);
            this.btnJoin.TabIndex = 20;
            this.btnJoin.UseVisualStyleBackColor = false;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(372, 354);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.Location = new System.Drawing.Point(633, 217);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(80, 100);
            this.btnLogin.TabIndex = 18;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("타이포_크레파스 M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("타이포_크레파스 M", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "ID";
            // 
            // txtLoginPW
            // 
            this.txtLoginPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtLoginPW.Location = new System.Drawing.Point(420, 289);
            this.txtLoginPW.Name = "txtLoginPW";
            this.txtLoginPW.Size = new System.Drawing.Size(192, 29);
            this.txtLoginPW.TabIndex = 14;
            // 
            // txtLoginID
            // 
            this.txtLoginID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtLoginID.Location = new System.Drawing.Point(420, 217);
            this.txtLoginID.Name = "txtLoginID";
            this.txtLoginID.Size = new System.Drawing.Size(192, 29);
            this.txtLoginID.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 567);
            this.Controls.Add(this.pnlWaitScreen);
            this.Controls.Add(this.pnlJoin);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLoginPW);
            this.Controls.Add(this.txtLoginID);
            this.Controls.Add(this.btnJoin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "CatchMind";
            this.pnlJoin.ResumeLayout(false);
            this.pnlJoin.PerformLayout();
            this.pnlWaitScreen.ResumeLayout(false);
            this.pnlWaitScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlJoin;
        private System.Windows.Forms.Panel pnlWaitScreen;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLoginPW;
        private System.Windows.Forms.TextBox txtLoginID;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnJoinCancel;
        private System.Windows.Forms.Button btnJoin_Join;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.Label lblNickname;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

