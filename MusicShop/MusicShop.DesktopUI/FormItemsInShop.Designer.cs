namespace MusicShop.DesktopUI
{
    partial class FormItemsInShop
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
            this.dataGridViewInStore = new System.Windows.Forms.DataGridView();
            this.buttonToCart = new System.Windows.Forms.Button();
            this.buttonFromCart = new System.Windows.Forms.Button();
            this.dataGridViewInCart = new System.Windows.Forms.DataGridView();
            this.clnAlbumCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAmountCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPriceTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.clnAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInCart)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInStore
            // 
            this.dataGridViewInStore.AllowUserToAddRows = false;
            this.dataGridViewInStore.AllowUserToDeleteRows = false;
            this.dataGridViewInStore.AllowUserToResizeColumns = false;
            this.dataGridViewInStore.AllowUserToResizeRows = false;
            this.dataGridViewInStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInStore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnAlbum,
            this.clnArtist,
            this.clnPrice,
            this.clnGenre,
            this.clnRating,
            this.clnAmount});
            this.dataGridViewInStore.Location = new System.Drawing.Point(12, 73);
            this.dataGridViewInStore.MultiSelect = false;
            this.dataGridViewInStore.Name = "dataGridViewInStore";
            this.dataGridViewInStore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewInStore.Size = new System.Drawing.Size(808, 539);
            this.dataGridViewInStore.TabIndex = 0;
            // 
            // buttonToCart
            // 
            this.buttonToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToCart.Location = new System.Drawing.Point(836, 224);
            this.buttonToCart.Name = "buttonToCart";
            this.buttonToCart.Size = new System.Drawing.Size(60, 39);
            this.buttonToCart.TabIndex = 1;
            this.buttonToCart.Text = ">>";
            this.buttonToCart.UseVisualStyleBackColor = true;
            // 
            // buttonFromCart
            // 
            this.buttonFromCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFromCart.Location = new System.Drawing.Point(836, 334);
            this.buttonFromCart.Name = "buttonFromCart";
            this.buttonFromCart.Size = new System.Drawing.Size(60, 39);
            this.buttonFromCart.TabIndex = 2;
            this.buttonFromCart.Text = "<<";
            this.buttonFromCart.UseVisualStyleBackColor = true;
            // 
            // dataGridViewInCart
            // 
            this.dataGridViewInCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnAlbumCart,
            this.clnAmountCart,
            this.clnPriceTotal});
            this.dataGridViewInCart.Location = new System.Drawing.Point(916, 73);
            this.dataGridViewInCart.Name = "dataGridViewInCart";
            this.dataGridViewInCart.Size = new System.Drawing.Size(336, 539);
            this.dataGridViewInCart.TabIndex = 3;
            // 
            // clnAlbumCart
            // 
            this.clnAlbumCart.Frozen = true;
            this.clnAlbumCart.HeaderText = "Album";
            this.clnAlbumCart.Name = "clnAlbumCart";
            this.clnAlbumCart.ReadOnly = true;
            this.clnAlbumCart.Width = 150;
            // 
            // clnAmountCart
            // 
            this.clnAmountCart.Frozen = true;
            this.clnAmountCart.HeaderText = "Amount";
            this.clnAmountCart.Name = "clnAmountCart";
            this.clnAmountCart.Width = 75;
            // 
            // clnPriceTotal
            // 
            this.clnPriceTotal.Frozen = true;
            this.clnPriceTotal.HeaderText = "Total Price";
            this.clnPriceTotal.Name = "clnPriceTotal";
            this.clnPriceTotal.ReadOnly = true;
            this.clnPriceTotal.Width = 75;
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(90, 36);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(127, 21);
            this.comboBoxGenre.TabIndex = 4;
            this.comboBoxGenre.SelectedIndexChanged += new System.EventHandler(this.comboBoxGenre_SelectedIndexChanged);
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(12, 39);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(72, 13);
            this.labelGenre.TabIndex = 5;
            this.labelGenre.Text = "Genre Select:";
            // 
            // clnAlbum
            // 
            this.clnAlbum.Frozen = true;
            this.clnAlbum.HeaderText = "Album";
            this.clnAlbum.Name = "clnAlbum";
            this.clnAlbum.Width = 200;
            // 
            // clnArtist
            // 
            this.clnArtist.Frozen = true;
            this.clnArtist.HeaderText = "Artist";
            this.clnArtist.Name = "clnArtist";
            this.clnArtist.ReadOnly = true;
            this.clnArtist.Width = 200;
            // 
            // clnPrice
            // 
            this.clnPrice.Frozen = true;
            this.clnPrice.HeaderText = "Price";
            this.clnPrice.Name = "clnPrice";
            this.clnPrice.ReadOnly = true;
            this.clnPrice.Width = 60;
            // 
            // clnGenre
            // 
            this.clnGenre.Frozen = true;
            this.clnGenre.HeaderText = "Genre";
            this.clnGenre.Name = "clnGenre";
            this.clnGenre.ReadOnly = true;
            this.clnGenre.Width = 125;
            // 
            // clnRating
            // 
            this.clnRating.Frozen = true;
            this.clnRating.HeaderText = "AllMusic.com Rating";
            this.clnRating.Name = "clnRating";
            this.clnRating.ReadOnly = true;
            // 
            // clnAmount
            // 
            this.clnAmount.Frozen = true;
            this.clnAmount.HeaderText = "Amount on storage";
            this.clnAmount.Name = "clnAmount";
            this.clnAmount.ReadOnly = true;
            this.clnAmount.Width = 80;
            // 
            // FormItemsInShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.dataGridViewInCart);
            this.Controls.Add(this.buttonFromCart);
            this.Controls.Add(this.buttonToCart);
            this.Controls.Add(this.dataGridViewInStore);
            this.Name = "FormItemsInShop";
            this.Text = "Main Window";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonToCart;
        private System.Windows.Forms.Button buttonFromCart;
        private System.Windows.Forms.DataGridView dataGridViewInCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAlbumCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAmountCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPriceTotal;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        public System.Windows.Forms.DataGridView dataGridViewInStore;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRating;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAmount;
    }
}