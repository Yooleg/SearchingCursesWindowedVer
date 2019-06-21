namespace SearchingCurses
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
            this.btn1 = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ArtistInput = new System.Windows.Forms.TextBox();
            this.SongsInput = new System.Windows.Forms.TextBox();
            this.ListOfSongs = new System.Windows.Forms.ListBox();
            this.SaveSong = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DeleteAll = new System.Windows.Forms.Button();
            this.HistoryOfResults = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(428, 286);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(244, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Vulgar check";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(342, 347);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(452, 20);
            this.Result.TabIndex = 1;
            this.Result.TextChanged += new System.EventHandler(this.Result_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Insert the name of the artist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Insert names of the songs";
            // 
            // ArtistInput
            // 
            this.ArtistInput.Location = new System.Drawing.Point(429, 107);
            this.ArtistInput.Name = "ArtistInput";
            this.ArtistInput.Size = new System.Drawing.Size(243, 20);
            this.ArtistInput.TabIndex = 5;
            this.ArtistInput.TextChanged += new System.EventHandler(this.ArtistInput_TextChanged);
            this.ArtistInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ArtistInput_KeyDown);
            // 
            // SongsInput
            // 
            this.SongsInput.Location = new System.Drawing.Point(429, 183);
            this.SongsInput.Multiline = true;
            this.SongsInput.Name = "SongsInput";
            this.SongsInput.Size = new System.Drawing.Size(243, 20);
            this.SongsInput.TabIndex = 6;
            this.SongsInput.TextChanged += new System.EventHandler(this.SongsInput_TextChanged);
            this.SongsInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SongsInput_KeyDown);
            // 
            // ListOfSongs
            // 
            this.ListOfSongs.FormattingEnabled = true;
            this.ListOfSongs.Location = new System.Drawing.Point(810, 69);
            this.ListOfSongs.Name = "ListOfSongs";
            this.ListOfSongs.Size = new System.Drawing.Size(261, 134);
            this.ListOfSongs.TabIndex = 7;
            this.ListOfSongs.SelectedIndexChanged += new System.EventHandler(this.ListOfSongs_SelectedIndexChanged);
            // 
            // SaveSong
            // 
            this.SaveSong.Location = new System.Drawing.Point(719, 92);
            this.SaveSong.Name = "SaveSong";
            this.SaveSong.Size = new System.Drawing.Size(75, 23);
            this.SaveSong.TabIndex = 8;
            this.SaveSong.Text = "Save";
            this.SaveSong.UseVisualStyleBackColor = true;
            this.SaveSong.Click += new System.EventHandler(this.SaveSong_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(719, 126);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 9;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(896, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "List Of Songs";
            // 
            // DeleteAll
            // 
            this.DeleteAll.Location = new System.Drawing.Point(719, 155);
            this.DeleteAll.Name = "DeleteAll";
            this.DeleteAll.Size = new System.Drawing.Size(75, 23);
            this.DeleteAll.TabIndex = 11;
            this.DeleteAll.Text = "Delete All";
            this.DeleteAll.UseVisualStyleBackColor = true;
            this.DeleteAll.Click += new System.EventHandler(this.DeleteAll_Click);
            // 
            // HistoryOfResults
            // 
            this.HistoryOfResults.FormattingEnabled = true;
            this.HistoryOfResults.Location = new System.Drawing.Point(51, 69);
            this.HistoryOfResults.Name = "HistoryOfResults";
            this.HistoryOfResults.Size = new System.Drawing.Size(292, 134);
            this.HistoryOfResults.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "History Of Results";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 494);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HistoryOfResults);
            this.Controls.Add(this.DeleteAll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.SaveSong);
            this.Controls.Add(this.ListOfSongs);
            this.Controls.Add(this.SongsInput);
            this.Controls.Add(this.ArtistInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ArtistInput;
        private System.Windows.Forms.TextBox SongsInput;
        private System.Windows.Forms.ListBox ListOfSongs;
        private System.Windows.Forms.Button SaveSong;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DeleteAll;
        private System.Windows.Forms.ListBox HistoryOfResults;
        private System.Windows.Forms.Label label4;
    }
}