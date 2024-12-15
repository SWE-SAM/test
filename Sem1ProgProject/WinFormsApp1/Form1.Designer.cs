namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            lblName = new Label();
            lblIngredients = new Label();
            txtIngredients = new TextBox();
            lblInstructions = new Label();
            textInstructions = new TextBox();
            btnSaveChanges = new Button();
            listBoxRecipes = new ListBox();
            btnDeleteRecipe = new Button();
            btnEditRecipe = new Button();
            pictureRecipe = new PictureBox();
            label1 = new Label();
            btnViewRecipe = new Button();
            lblSuggested = new Label();
            txtNewRecipe = new TextBox();
            pictureNewRecipe = new PictureBox();
            btnNewRecipe = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureRecipe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureNewRecipe).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Left;
            txtName.BackColor = Color.FromArgb(221, 161, 94);
            txtName.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.Location = new Point(12, 71);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(171, 43);
            txtName.TabIndex = 0;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Left;
            lblName.AutoSize = true;
            lblName.Font = new Font("Castellar", 9F, FontStyle.Bold);
            lblName.Location = new Point(12, 54);
            lblName.Name = "lblName";
            lblName.Size = new Size(112, 14);
            lblName.TabIndex = 1;
            lblName.Text = "Recipe Name:";
            // 
            // lblIngredients
            // 
            lblIngredients.Anchor = AnchorStyles.Left;
            lblIngredients.AutoSize = true;
            lblIngredients.Font = new Font("Castellar", 9F, FontStyle.Bold);
            lblIngredients.Location = new Point(203, 233);
            lblIngredients.Name = "lblIngredients";
            lblIngredients.Size = new Size(168, 14);
            lblIngredients.TabIndex = 2;
            lblIngredients.Text = "Recipe Ingredients:";
            // 
            // txtIngredients
            // 
            txtIngredients.Anchor = AnchorStyles.Left;
            txtIngredients.BackColor = Color.FromArgb(221, 161, 94);
            txtIngredients.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIngredients.Location = new Point(210, 251);
            txtIngredients.Multiline = true;
            txtIngredients.Name = "txtIngredients";
            txtIngredients.Size = new Size(140, 177);
            txtIngredients.TabIndex = 3;
            // 
            // lblInstructions
            // 
            lblInstructions.Anchor = AnchorStyles.Left;
            lblInstructions.AutoSize = true;
            lblInstructions.Font = new Font("Castellar", 9F, FontStyle.Bold);
            lblInstructions.Location = new Point(12, 233);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(179, 14);
            lblInstructions.TabIndex = 4;
            lblInstructions.Text = "Recipe Instructions:";
            // 
            // textInstructions
            // 
            textInstructions.Anchor = AnchorStyles.Left;
            textInstructions.BackColor = Color.FromArgb(221, 161, 94);
            textInstructions.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textInstructions.Location = new Point(12, 251);
            textInstructions.Multiline = true;
            textInstructions.Name = "textInstructions";
            textInstructions.Size = new Size(171, 177);
            textInstructions.TabIndex = 5;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSaveChanges.Location = new Point(394, 402);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(128, 26);
            btnSaveChanges.TabIndex = 6;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // listBoxRecipes
            // 
            listBoxRecipes.Anchor = AnchorStyles.Left;
            listBoxRecipes.BackColor = Color.FromArgb(221, 161, 94);
            listBoxRecipes.Font = new Font("Tahoma", 9F);
            listBoxRecipes.FormattingEnabled = true;
            listBoxRecipes.ItemHeight = 14;
            listBoxRecipes.Location = new Point(210, 71);
            listBoxRecipes.Name = "listBoxRecipes";
            listBoxRecipes.Size = new Size(140, 144);
            listBoxRecipes.TabIndex = 7;
            // 
            // btnDeleteRecipe
            // 
            btnDeleteRecipe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDeleteRecipe.Location = new Point(394, 202);
            btnDeleteRecipe.Name = "btnDeleteRecipe";
            btnDeleteRecipe.Size = new Size(128, 26);
            btnDeleteRecipe.TabIndex = 8;
            btnDeleteRecipe.Text = "Delete Selected Recipe";
            btnDeleteRecipe.UseVisualStyleBackColor = true;
            // 
            // btnEditRecipe
            // 
            btnEditRecipe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEditRecipe.Location = new Point(394, 173);
            btnEditRecipe.Name = "btnEditRecipe";
            btnEditRecipe.Size = new Size(128, 26);
            btnEditRecipe.TabIndex = 9;
            btnEditRecipe.Text = "Edit Selected Recipe";
            btnEditRecipe.UseVisualStyleBackColor = true;
            // 
            // pictureRecipe
            // 
            pictureRecipe.Anchor = AnchorStyles.Left;
            pictureRecipe.Location = new Point(12, 127);
            pictureRecipe.Name = "pictureRecipe";
            pictureRecipe.Size = new Size(171, 101);
            pictureRecipe.TabIndex = 10;
            pictureRecipe.TabStop = false;
            pictureRecipe.Click += pictureRecipe_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(290, 1);
            label1.Name = "label1";
            label1.Size = new Size(267, 44);
            label1.TabIndex = 11;
            label1.Text = "My Recipe Manager";
            // 
            // btnViewRecipe
            // 
            btnViewRecipe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnViewRecipe.Location = new Point(394, 144);
            btnViewRecipe.Name = "btnViewRecipe";
            btnViewRecipe.Size = new Size(128, 26);
            btnViewRecipe.TabIndex = 12;
            btnViewRecipe.Text = "View Selected Recipe";
            btnViewRecipe.UseVisualStyleBackColor = true;
            // 
            // lblSuggested
            // 
            lblSuggested.Anchor = AnchorStyles.Right;
            lblSuggested.AutoSize = true;
            lblSuggested.Font = new Font("Castellar", 9F, FontStyle.Bold);
            lblSuggested.Location = new Point(616, 53);
            lblSuggested.Name = "lblSuggested";
            lblSuggested.Size = new Size(155, 14);
            lblSuggested.TabIndex = 13;
            lblSuggested.Text = "Recipe of the Day";
            // 
            // txtNewRecipe
            // 
            txtNewRecipe.Anchor = AnchorStyles.Right;
            txtNewRecipe.BackColor = Color.FromArgb(221, 161, 94);
            txtNewRecipe.Font = new Font("Tahoma", 11F, FontStyle.Bold);
            txtNewRecipe.Location = new Point(600, 82);
            txtNewRecipe.Multiline = true;
            txtNewRecipe.Name = "txtNewRecipe";
            txtNewRecipe.Size = new Size(171, 32);
            txtNewRecipe.TabIndex = 14;
            txtNewRecipe.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureNewRecipe
            // 
            pictureNewRecipe.Anchor = AnchorStyles.Right;
            pictureNewRecipe.Location = new Point(600, 128);
            pictureNewRecipe.Name = "pictureNewRecipe";
            pictureNewRecipe.Size = new Size(171, 101);
            pictureNewRecipe.TabIndex = 15;
            pictureNewRecipe.TabStop = false;
            pictureNewRecipe.Click += pictureNewRecipe_Click;
            // 
            // btnNewRecipe
            // 
            btnNewRecipe.Anchor = AnchorStyles.Right;
            btnNewRecipe.Location = new Point(627, 233);
            btnNewRecipe.Name = "btnNewRecipe";
            btnNewRecipe.Size = new Size(122, 26);
            btnNewRecipe.TabIndex = 16;
            btnNewRecipe.Text = "Pick New Recipe";
            btnNewRecipe.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Castellar", 9F, FontStyle.Bold);
            label2.Location = new Point(210, 53);
            label2.Name = "label2";
            label2.Size = new Size(99, 14);
            label2.TabIndex = 17;
            label2.Text = "Recipe List:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 192, 128);
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(591, 45);
            label3.MaximumSize = new Size(100, 100);
            label3.MinimumSize = new Size(190, 235);
            label3.Name = "label3";
            label3.Size = new Size(190, 235);
            label3.TabIndex = 18;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 192, 128);
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(3, 45);
            label4.MaximumSize = new Size(100, 100);
            label4.MinimumSize = new Size(375, 390);
            label4.Name = "label4";
            label4.Size = new Size(375, 390);
            label4.TabIndex = 19;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 192, 128);
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.ForeColor = Color.FromArgb(255, 192, 128);
            label5.Location = new Point(384, 45);
            label5.MaximumSize = new Size(100, 100);
            label5.MinimumSize = new Size(150, 390);
            label5.Name = "label5";
            label5.Size = new Size(150, 390);
            label5.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Castellar", 9F, FontStyle.Bold);
            label6.Location = new Point(413, 54);
            label6.Name = "label6";
            label6.Size = new Size(87, 14);
            label6.TabIndex = 21;
            label6.Text = "Controls";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 250, 224);
            ClientSize = new Size(797, 453);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(btnNewRecipe);
            Controls.Add(pictureNewRecipe);
            Controls.Add(txtNewRecipe);
            Controls.Add(lblSuggested);
            Controls.Add(btnViewRecipe);
            Controls.Add(pictureRecipe);
            Controls.Add(btnEditRecipe);
            Controls.Add(btnDeleteRecipe);
            Controls.Add(listBoxRecipes);
            Controls.Add(btnSaveChanges);
            Controls.Add(textInstructions);
            Controls.Add(lblInstructions);
            Controls.Add(txtIngredients);
            Controls.Add(lblIngredients);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label5);
            Name = "Form1";
            Text = "S";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureRecipe).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureNewRecipe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label lblName;
        private Label lblIngredients;
        private TextBox txtIngredients;
        private Label lblInstructions;
        private TextBox textInstructions;
        private Button btnSaveChanges;
        private ListBox listBoxRecipes;
        private Button btnDeleteRecipe;
        private Button btnEditRecipe;
        private PictureBox pictureRecipe;
        private Label label1;
        private Button btnViewRecipe;
        private Label lblSuggested;
        private TextBox txtNewRecipe;
        private PictureBox pictureNewRecipe;
        private Button btnNewRecipe;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
