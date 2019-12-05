namespace New_video_Rental
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Database = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtfName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.AddCus = new System.Windows.Forms.Button();
            this.updateCus = new System.Windows.Forms.Button();
            this.DeleteCus = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.MovieId = new System.Windows.Forms.Label();
            this.CustomerID = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.MovieIssueDate = new System.Windows.Forms.DateTimePicker();
            this.MovieReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.AddMovie = new System.Windows.Forms.Button();
            this.UpdateMovie = new System.Windows.Forms.Button();
            this.DeleteMovie = new System.Windows.Forms.Button();
            this.btnMovieIssue = new System.Windows.Forms.Button();
            this.btnMovieReturn = new System.Windows.Forms.Button();
            this.btnMostCustomer = new System.Windows.Forms.Button();
            this.btnMostMovie = new System.Windows.Forms.Button();
            this.ShowCustomer = new System.Windows.Forms.Button();
            this.ShowVideo = new System.Windows.Forms.Button();
            this.ShowRental = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(929, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Database
            // 
            this.Database.BackgroundColor = System.Drawing.Color.Yellow;
            this.Database.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Database.Location = new System.Drawing.Point(12, 347);
            this.Database.Name = "Database";
            this.Database.Size = new System.Drawing.Size(687, 222);
            this.Database.TabIndex = 1;
            this.Database.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.Database.DoubleClick += new System.EventHandler(this.Database_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(386, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Movie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(751, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "On Rent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label5.Location = new System.Drawing.Point(22, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mobile";
            // 
            // txtfName
            // 
            this.txtfName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfName.Location = new System.Drawing.Point(178, 60);
            this.txtfName.Name = "txtfName";
            this.txtfName.Size = new System.Drawing.Size(138, 26);
            this.txtfName.TabIndex = 9;
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(178, 100);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(138, 26);
            this.txtLName.TabIndex = 10;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(178, 145);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(138, 26);
            this.txtAddress.TabIndex = 11;
            // 
            // txtMobile
            // 
            this.txtMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(178, 194);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(138, 26);
            this.txtMobile.TabIndex = 12;
            // 
            // AddCus
            // 
            this.AddCus.BackColor = System.Drawing.Color.Yellow;
            this.AddCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCus.Location = new System.Drawing.Point(12, 240);
            this.AddCus.Name = "AddCus";
            this.AddCus.Size = new System.Drawing.Size(101, 56);
            this.AddCus.TabIndex = 13;
            this.AddCus.Text = "Add Cus.";
            this.AddCus.UseVisualStyleBackColor = false;
            this.AddCus.Click += new System.EventHandler(this.AddCus_Click);
            // 
            // updateCus
            // 
            this.updateCus.BackColor = System.Drawing.Color.Yellow;
            this.updateCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCus.Location = new System.Drawing.Point(137, 240);
            this.updateCus.Name = "updateCus";
            this.updateCus.Size = new System.Drawing.Size(86, 56);
            this.updateCus.TabIndex = 14;
            this.updateCus.Text = "Update ";
            this.updateCus.UseVisualStyleBackColor = false;
            this.updateCus.Click += new System.EventHandler(this.updateCus_Click);
            // 
            // DeleteCus
            // 
            this.DeleteCus.BackColor = System.Drawing.Color.Yellow;
            this.DeleteCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCus.Location = new System.Drawing.Point(249, 240);
            this.DeleteCus.Name = "DeleteCus";
            this.DeleteCus.Size = new System.Drawing.Size(86, 56);
            this.DeleteCus.TabIndex = 15;
            this.DeleteCus.Text = "Delete";
            this.DeleteCus.UseVisualStyleBackColor = false;
            this.DeleteCus.Click += new System.EventHandler(this.DeleteCus_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(340, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(489, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(138, 26);
            this.txtName.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(340, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Score";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(340, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Year";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(340, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "Cost";
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(489, 102);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(138, 26);
            this.txtScore.TabIndex = 21;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(489, 147);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(138, 26);
            this.txtYear.TabIndex = 22;
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(489, 196);
            this.txtCost.Name = "txtCost";
            this.txtCost.ReadOnly = true;
            this.txtCost.Size = new System.Drawing.Size(138, 26);
            this.txtCost.TabIndex = 23;
            // 
            // MovieId
            // 
            this.MovieId.AutoSize = true;
            this.MovieId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieId.Location = new System.Drawing.Point(757, 60);
            this.MovieId.Name = "MovieId";
            this.MovieId.Size = new System.Drawing.Size(0, 24);
            this.MovieId.TabIndex = 24;
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSize = true;
            this.CustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerID.Location = new System.Drawing.Point(757, 103);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(0, 24);
            this.CustomerID.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(648, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 18);
            this.label14.TabIndex = 26;
            this.label14.Text = "Issue Date:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(639, 180);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 18);
            this.label15.TabIndex = 27;
            this.label15.Text = "Return Date:";
            // 
            // MovieIssueDate
            // 
            this.MovieIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.MovieIssueDate.Location = new System.Drawing.Point(741, 144);
            this.MovieIssueDate.Name = "MovieIssueDate";
            this.MovieIssueDate.Size = new System.Drawing.Size(110, 20);
            this.MovieIssueDate.TabIndex = 28;
            // 
            // MovieReturnDate
            // 
            this.MovieReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.MovieReturnDate.Location = new System.Drawing.Point(741, 180);
            this.MovieReturnDate.Name = "MovieReturnDate";
            this.MovieReturnDate.Size = new System.Drawing.Size(110, 20);
            this.MovieReturnDate.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(340, 240);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 25);
            this.label16.TabIndex = 30;
            this.label16.Text = "Copies";
            // 
            // txtCopies
            // 
            this.txtCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCopies.Location = new System.Drawing.Point(489, 241);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(138, 26);
            this.txtCopies.TabIndex = 31;
            // 
            // AddMovie
            // 
            this.AddMovie.BackColor = System.Drawing.Color.Yellow;
            this.AddMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMovie.Location = new System.Drawing.Point(369, 281);
            this.AddMovie.Name = "AddMovie";
            this.AddMovie.Size = new System.Drawing.Size(103, 27);
            this.AddMovie.TabIndex = 32;
            this.AddMovie.Text = "Add Mov.";
            this.AddMovie.UseVisualStyleBackColor = false;
            this.AddMovie.Click += new System.EventHandler(this.AddMovie_Click);
            // 
            // UpdateMovie
            // 
            this.UpdateMovie.BackColor = System.Drawing.Color.Yellow;
            this.UpdateMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateMovie.Location = new System.Drawing.Point(498, 281);
            this.UpdateMovie.Name = "UpdateMovie";
            this.UpdateMovie.Size = new System.Drawing.Size(129, 27);
            this.UpdateMovie.TabIndex = 33;
            this.UpdateMovie.Text = "Update Mov.";
            this.UpdateMovie.UseVisualStyleBackColor = false;
            this.UpdateMovie.Click += new System.EventHandler(this.UpdateMovie_Click);
            // 
            // DeleteMovie
            // 
            this.DeleteMovie.BackColor = System.Drawing.Color.Yellow;
            this.DeleteMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteMovie.Location = new System.Drawing.Point(432, 314);
            this.DeleteMovie.Name = "DeleteMovie";
            this.DeleteMovie.Size = new System.Drawing.Size(103, 27);
            this.DeleteMovie.TabIndex = 34;
            this.DeleteMovie.Text = "Delete ";
            this.DeleteMovie.UseVisualStyleBackColor = false;
            this.DeleteMovie.Click += new System.EventHandler(this.DeleteMovie_Click);
            // 
            // btnMovieIssue
            // 
            this.btnMovieIssue.BackColor = System.Drawing.Color.Yellow;
            this.btnMovieIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovieIssue.Location = new System.Drawing.Point(633, 206);
            this.btnMovieIssue.Name = "btnMovieIssue";
            this.btnMovieIssue.Size = new System.Drawing.Size(129, 27);
            this.btnMovieIssue.TabIndex = 35;
            this.btnMovieIssue.Text = "Issue";
            this.btnMovieIssue.UseVisualStyleBackColor = false;
            this.btnMovieIssue.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnMovieReturn
            // 
            this.btnMovieReturn.BackColor = System.Drawing.Color.Yellow;
            this.btnMovieReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovieReturn.Location = new System.Drawing.Point(771, 206);
            this.btnMovieReturn.Name = "btnMovieReturn";
            this.btnMovieReturn.Size = new System.Drawing.Size(129, 27);
            this.btnMovieReturn.TabIndex = 36;
            this.btnMovieReturn.Text = "Return";
            this.btnMovieReturn.UseVisualStyleBackColor = false;
            this.btnMovieReturn.Click += new System.EventHandler(this.btnMovieReturn_Click);
            // 
            // btnMostCustomer
            // 
            this.btnMostCustomer.BackColor = System.Drawing.Color.Yellow;
            this.btnMostCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostCustomer.Location = new System.Drawing.Point(651, 274);
            this.btnMostCustomer.Name = "btnMostCustomer";
            this.btnMostCustomer.Size = new System.Drawing.Size(231, 27);
            this.btnMostCustomer.TabIndex = 37;
            this.btnMostCustomer.Text = "Loyable Customer";
            this.btnMostCustomer.UseVisualStyleBackColor = false;
            this.btnMostCustomer.Click += new System.EventHandler(this.btnMostCustomer_Click);
            // 
            // btnMostMovie
            // 
            this.btnMostMovie.BackColor = System.Drawing.Color.Yellow;
            this.btnMostMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostMovie.Location = new System.Drawing.Point(722, 307);
            this.btnMostMovie.Name = "btnMostMovie";
            this.btnMostMovie.Size = new System.Drawing.Size(129, 27);
            this.btnMostMovie.TabIndex = 38;
            this.btnMostMovie.Text = "Best Movie";
            this.btnMostMovie.UseVisualStyleBackColor = false;
            this.btnMostMovie.Click += new System.EventHandler(this.btnMostMovie_Click);
            // 
            // ShowCustomer
            // 
            this.ShowCustomer.BackColor = System.Drawing.Color.Yellow;
            this.ShowCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCustomer.Location = new System.Drawing.Point(705, 378);
            this.ShowCustomer.Name = "ShowCustomer";
            this.ShowCustomer.Size = new System.Drawing.Size(184, 27);
            this.ShowCustomer.TabIndex = 39;
            this.ShowCustomer.Text = "Show Customers";
            this.ShowCustomer.UseVisualStyleBackColor = false;
            this.ShowCustomer.Click += new System.EventHandler(this.ShowCustomer_Click);
            // 
            // ShowVideo
            // 
            this.ShowVideo.BackColor = System.Drawing.Color.Yellow;
            this.ShowVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowVideo.Location = new System.Drawing.Point(705, 426);
            this.ShowVideo.Name = "ShowVideo";
            this.ShowVideo.Size = new System.Drawing.Size(184, 27);
            this.ShowVideo.TabIndex = 40;
            this.ShowVideo.Text = "Show Videos";
            this.ShowVideo.UseVisualStyleBackColor = false;
            this.ShowVideo.Click += new System.EventHandler(this.ShowVideo_Click);
            // 
            // ShowRental
            // 
            this.ShowRental.BackColor = System.Drawing.Color.Yellow;
            this.ShowRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowRental.Location = new System.Drawing.Point(705, 474);
            this.ShowRental.Name = "ShowRental";
            this.ShowRental.Size = new System.Drawing.Size(184, 27);
            this.ShowRental.TabIndex = 41;
            this.ShowRental.Text = "Rental History";
            this.ShowRental.UseVisualStyleBackColor = false;
            this.ShowRental.Click += new System.EventHandler(this.ShowRental_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(638, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 24);
            this.label12.TabIndex = 43;
            this.label12.Text = "Customer ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(638, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 24);
            this.label13.TabIndex = 42;
            this.label13.Text = "Movie ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(705, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 27);
            this.button1.TabIndex = 44;
            this.button1.Text = "Delete ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 567);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ShowRental);
            this.Controls.Add(this.ShowVideo);
            this.Controls.Add(this.ShowCustomer);
            this.Controls.Add(this.btnMostMovie);
            this.Controls.Add(this.btnMostCustomer);
            this.Controls.Add(this.btnMovieReturn);
            this.Controls.Add(this.btnMovieIssue);
            this.Controls.Add(this.DeleteMovie);
            this.Controls.Add(this.UpdateMovie);
            this.Controls.Add(this.AddMovie);
            this.Controls.Add(this.txtCopies);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.MovieReturnDate);
            this.Controls.Add(this.MovieIssueDate);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.MovieId);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DeleteCus);
            this.Controls.Add(this.updateCus);
            this.Controls.Add(this.AddCus);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtfName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Database);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView Database;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtfName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Button AddCus;
        private System.Windows.Forms.Button updateCus;
        private System.Windows.Forms.Button DeleteCus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label MovieId;
        private System.Windows.Forms.Label CustomerID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker MovieIssueDate;
        private System.Windows.Forms.DateTimePicker MovieReturnDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCopies;
        private System.Windows.Forms.Button AddMovie;
        private System.Windows.Forms.Button UpdateMovie;
        private System.Windows.Forms.Button DeleteMovie;
        private System.Windows.Forms.Button btnMovieIssue;
        private System.Windows.Forms.Button btnMovieReturn;
        private System.Windows.Forms.Button btnMostCustomer;
        private System.Windows.Forms.Button btnMostMovie;
        private System.Windows.Forms.Button ShowCustomer;
        private System.Windows.Forms.Button ShowVideo;
        private System.Windows.Forms.Button ShowRental;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
    }
}

