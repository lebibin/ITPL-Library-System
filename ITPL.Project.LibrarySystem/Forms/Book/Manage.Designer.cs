namespace ITPL.Project.LibrarySystem.Forms.Book
{
    partial class Manage
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
            this.components = new System.ComponentModel.Container();
            this.tabBookAdd = new System.Windows.Forms.TabPage();
            this.imgBook = new System.Windows.Forms.PictureBox();
            this.lblAddBook = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.imgLU = new System.Windows.Forms.PictureBox();
            this.lblLookup = new System.Windows.Forms.Label();
            this.imgGR = new System.Windows.Forms.PictureBox();
            this.tbGRSearch = new System.Windows.Forms.TextBox();
            this.lblGuide = new System.Windows.Forms.Label();
            this.btnLookup = new System.Windows.Forms.Button();
            this.picBook = new System.Windows.Forms.PictureBox();
            this.tabBookContainer = new System.Windows.Forms.TabControl();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbDatePublished = new System.Windows.Forms.TextBox();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pbRating = new System.Windows.Forms.ProgressBar();
            this.tabBookAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBook)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBook)).BeginInit();
            this.tabBookContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // tabBookAdd
            // 
            this.tabBookAdd.Controls.Add(this.panel1);
            this.tabBookAdd.Controls.Add(this.lblAddBook);
            this.tabBookAdd.Controls.Add(this.imgBook);
            this.tabBookAdd.Controls.Add(this.shapeContainer1);
            this.tabBookAdd.Location = new System.Drawing.Point(4, 22);
            this.tabBookAdd.Name = "tabBookAdd";
            this.tabBookAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabBookAdd.Size = new System.Drawing.Size(818, 465);
            this.tabBookAdd.TabIndex = 0;
            this.tabBookAdd.Text = "Search";
            this.tabBookAdd.UseVisualStyleBackColor = true;
            this.tabBookAdd.Click += new System.EventHandler(this.tabBookAdd_Click);
            // 
            // imgBook
            // 
            this.imgBook.Image = global::ITPL.Project.LibrarySystem.Properties.Resources.glyphicons_071_book;
            this.imgBook.Location = new System.Drawing.Point(19, 23);
            this.imgBook.Name = "imgBook";
            this.imgBook.Size = new System.Drawing.Size(30, 30);
            this.imgBook.TabIndex = 0;
            this.imgBook.TabStop = false;
            // 
            // lblAddBook
            // 
            this.lblAddBook.AutoSize = true;
            this.lblAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddBook.Location = new System.Drawing.Point(55, 23);
            this.lblAddBook.Name = "lblAddBook";
            this.lblAddBook.Size = new System.Drawing.Size(185, 29);
            this.lblAddBook.TabIndex = 1;
            this.lblAddBook.Text = "Search for Book";
            this.lblAddBook.Click += new System.EventHandler(this.lblAddBook_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pbRating);
            this.panel1.Controls.Add(this.tbLocation);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.tbDatePublished);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.picBook);
            this.panel1.Controls.Add(this.btnLookup);
            this.panel1.Controls.Add(this.lblGuide);
            this.panel1.Controls.Add(this.tbGRSearch);
            this.panel1.Controls.Add(this.imgGR);
            this.panel1.Controls.Add(this.lblLookup);
            this.panel1.Controls.Add(this.imgLU);
            this.panel1.Controls.Add(this.tbAuthor);
            this.panel1.Controls.Add(this.tbTitle);
            this.panel1.Controls.Add(this.shapeContainer3);
            this.panel1.Location = new System.Drawing.Point(22, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 377);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tbTitle
            // 
            this.tbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tbTitle.Location = new System.Drawing.Point(392, 209);
            this.tbTitle.Multiline = true;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.ReadOnly = true;
            this.tbTitle.Size = new System.Drawing.Size(324, 30);
            this.tbTitle.TabIndex = 4;
            this.tbTitle.TextChanged += new System.EventHandler(this.tbTitle_TextChanged);
            // 
            // tbAuthor
            // 
            this.tbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tbAuthor.Location = new System.Drawing.Point(392, 245);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.ReadOnly = true;
            this.tbAuthor.Size = new System.Drawing.Size(324, 23);
            this.tbAuthor.TabIndex = 6;
            this.tbAuthor.TextChanged += new System.EventHandler(this.tbAuthor_TextChanged);
            // 
            // imgLU
            // 
            this.imgLU.Image = global::ITPL.Project.LibrarySystem.Properties.Resources.glyphicons_027_search;
            this.imgLU.Location = new System.Drawing.Point(74, 103);
            this.imgLU.Name = "imgLU";
            this.imgLU.Size = new System.Drawing.Size(31, 31);
            this.imgLU.TabIndex = 14;
            this.imgLU.TabStop = false;
            // 
            // lblLookup
            // 
            this.lblLookup.AutoSize = true;
            this.lblLookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLookup.Location = new System.Drawing.Point(111, 103);
            this.lblLookup.Name = "lblLookup";
            this.lblLookup.Size = new System.Drawing.Size(101, 24);
            this.lblLookup.TabIndex = 6;
            this.lblLookup.Text = "Lookup via";
            // 
            // imgGR
            // 
            this.imgGR.Image = global::ITPL.Project.LibrarySystem.Properties.Resources.logo_442d9afca63dc7e8b9d988f811fb9cbd;
            this.imgGR.Location = new System.Drawing.Point(38, 140);
            this.imgGR.Name = "imgGR";
            this.imgGR.Size = new System.Drawing.Size(202, 45);
            this.imgGR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGR.TabIndex = 15;
            this.imgGR.TabStop = false;
            this.imgGR.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // tbGRSearch
            // 
            this.tbGRSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGRSearch.Location = new System.Drawing.Point(38, 192);
            this.tbGRSearch.Name = "tbGRSearch";
            this.tbGRSearch.Size = new System.Drawing.Size(138, 23);
            this.tbGRSearch.TabIndex = 16;
            this.tbGRSearch.TextChanged += new System.EventHandler(this.tbGRSearch_TextChanged);
            // 
            // lblGuide
            // 
            this.lblGuide.AutoSize = true;
            this.lblGuide.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblGuide.Location = new System.Drawing.Point(35, 218);
            this.lblGuide.Name = "lblGuide";
            this.lblGuide.Size = new System.Drawing.Size(114, 13);
            this.lblGuide.TabIndex = 17;
            this.lblGuide.Text = "* ISBN, Title, or Author";
            this.lblGuide.Click += new System.EventHandler(this.lblGuide_Click);
            // 
            // btnLookup
            // 
            this.btnLookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLookup.Location = new System.Drawing.Point(182, 192);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(67, 23);
            this.btnLookup.TabIndex = 18;
            this.btnLookup.Text = "Lookup";
            this.btnLookup.UseVisualStyleBackColor = true;
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
            // 
            // picBook
            // 
            this.picBook.Image = global::ITPL.Project.LibrarySystem.Properties.Resources.goodreads_icon_100x100_bff70f2a14699328631d91f1b40e2d5a;
            this.picBook.Location = new System.Drawing.Point(392, 16);
            this.picBook.Name = "picBook";
            this.picBook.Size = new System.Drawing.Size(324, 182);
            this.picBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBook.TabIndex = 19;
            this.picBook.TabStop = false;
            // 
            // tabBookContainer
            // 
            this.tabBookContainer.Controls.Add(this.tabBookAdd);
            this.tabBookContainer.Location = new System.Drawing.Point(12, 12);
            this.tabBookContainer.Name = "tabBookContainer";
            this.tabBookContainer.SelectedIndex = 0;
            this.tabBookContainer.Size = new System.Drawing.Size(826, 491);
            this.tabBookContainer.TabIndex = 0;
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3});
            this.shapeContainer3.Size = new System.Drawing.Size(772, 377);
            this.shapeContainer3.TabIndex = 13;
            this.shapeContainer3.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 295;
            this.lineShape3.X2 = 295;
            this.lineShape3.Y1 = 34;
            this.lineShape3.Y2 = 304;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 3);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(812, 459);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 19;
            this.lineShape1.X2 = 790;
            this.lineShape1.Y1 = 65;
            this.lineShape1.Y2 = 65;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ITPL.Project.LibrarySystem.Properties.Resources.glyphicons_071_book;
            this.pictureBox1.Location = new System.Drawing.Point(346, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Title");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ITPL.Project.LibrarySystem.Properties.Resources.glyphicons_003_user;
            this.pictureBox2.Location = new System.Drawing.Point(346, 245);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Author");
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ITPL.Project.LibrarySystem.Properties.Resources.glyphicons_045_calendar;
            this.pictureBox3.Location = new System.Drawing.Point(346, 273);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Date published");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // tbDatePublished
            // 
            this.tbDatePublished.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tbDatePublished.Location = new System.Drawing.Point(392, 274);
            this.tbDatePublished.Name = "tbDatePublished";
            this.tbDatePublished.ReadOnly = true;
            this.tbDatePublished.Size = new System.Drawing.Size(324, 23);
            this.tbDatePublished.TabIndex = 23;
            // 
            // tbLocation
            // 
            this.tbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tbLocation.Location = new System.Drawing.Point(392, 303);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.ReadOnly = true;
            this.tbLocation.Size = new System.Drawing.Size(324, 23);
            this.tbLocation.TabIndex = 25;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ITPL.Project.LibrarySystem.Properties.Resources.glyphicons_242_google_maps;
            this.pictureBox4.Location = new System.Drawing.Point(352, 302);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(16, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox4, "Call number");
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ITPL.Project.LibrarySystem.Properties.Resources.glyphicons_049_star;
            this.pictureBox5.Location = new System.Drawing.Point(346, 332);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 27;
            this.pictureBox5.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox5, "Rating");
            // 
            // pbRating
            // 
            this.pbRating.Location = new System.Drawing.Point(392, 333);
            this.pbRating.Name = "pbRating";
            this.pbRating.Size = new System.Drawing.Size(324, 23);
            this.pbRating.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbRating.TabIndex = 26;
            this.pbRating.Click += new System.EventHandler(this.pbRating_Click);
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 515);
            this.Controls.Add(this.tabBookContainer);
            this.Name = "Manage";
            this.Text = "Library System - ITPL - Admin";
            this.tabBookAdd.ResumeLayout(false);
            this.tabBookAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBook)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBook)).EndInit();
            this.tabBookContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabBookAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picBook;
        private System.Windows.Forms.Button btnLookup;
        private System.Windows.Forms.Label lblGuide;
        private System.Windows.Forms.TextBox tbGRSearch;
        private System.Windows.Forms.PictureBox imgGR;
        private System.Windows.Forms.Label lblLookup;
        private System.Windows.Forms.PictureBox imgLU;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.TextBox tbTitle;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.Label lblAddBook;
        private System.Windows.Forms.PictureBox imgBook;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TabControl tabBookContainer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox tbDatePublished;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ProgressBar pbRating;


    }
}