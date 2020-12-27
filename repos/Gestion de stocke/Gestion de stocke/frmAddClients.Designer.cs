namespace Gestion_de_stocke
{
    partial class frmAddClients
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
            System.Windows.Forms.Label codeClientLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label adressLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddClients));
            this.bDstockDataSet = new Gestion_de_stocke.BDstockDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Gestion_de_stocke.BDstockDataSetTableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new Gestion_de_stocke.BDstockDataSetTableAdapters.TableAdapterManager();
            this.clientBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clientBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codeClientTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            codeClientLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            adressLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDstockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingNavigator)).BeginInit();
            this.clientBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeClientLabel
            // 
            codeClientLabel.AutoSize = true;
            codeClientLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codeClientLabel.Location = new System.Drawing.Point(65, 76);
            codeClientLabel.Name = "codeClientLabel";
            codeClientLabel.Size = new System.Drawing.Size(154, 24);
            codeClientLabel.TabIndex = 1;
            codeClientLabel.Text = "code Client:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomLabel.Location = new System.Drawing.Point(65, 140);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(58, 24);
            nomLabel.TabIndex = 3;
            nomLabel.Text = "nom:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prenomLabel.Location = new System.Drawing.Point(65, 198);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(94, 24);
            prenomLabel.TabIndex = 5;
            prenomLabel.Text = "prenom:";
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            adressLabel.Location = new System.Drawing.Point(65, 269);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new System.Drawing.Size(94, 24);
            adressLabel.TabIndex = 7;
            adressLabel.Text = "adress:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telephoneLabel.Location = new System.Drawing.Point(65, 329);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(130, 24);
            telephoneLabel.TabIndex = 9;
            telephoneLabel.Text = "telephone:";
            // 
            // bDstockDataSet
            // 
            this.bDstockDataSet.DataSetName = "BDstockDataSet";
            this.bDstockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.bDstockDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.FactureTableAdapter = null;
            this.tableAdapterManager.FournisseurTableAdapter = null;
            this.tableAdapterManager.LigneFactureTableAdapter = null;
            this.tableAdapterManager.ProduitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Gestion_de_stocke.BDstockDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientBindingNavigator
            // 
            this.clientBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clientBindingNavigator.BindingSource = this.clientBindingSource;
            this.clientBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clientBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clientBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.clientBindingNavigatorSaveItem});
            this.clientBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clientBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clientBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clientBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clientBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clientBindingNavigator.Name = "clientBindingNavigator";
            this.clientBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clientBindingNavigator.Size = new System.Drawing.Size(553, 25);
            this.clientBindingNavigator.TabIndex = 0;
            this.clientBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // clientBindingNavigatorSaveItem
            // 
            this.clientBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clientBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clientBindingNavigatorSaveItem.Image")));
            this.clientBindingNavigatorSaveItem.Name = "clientBindingNavigatorSaveItem";
            this.clientBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.clientBindingNavigatorSaveItem.Text = "Save Data";
            this.clientBindingNavigatorSaveItem.Click += new System.EventHandler(this.clientBindingNavigatorSaveItem_Click);
            // 
            // codeClientTextBox
            // 
            this.codeClientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "codeClient", true));
            this.codeClientTextBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeClientTextBox.Location = new System.Drawing.Point(279, 68);
            this.codeClientTextBox.Name = "codeClientTextBox";
            this.codeClientTextBox.Size = new System.Drawing.Size(222, 32);
            this.codeClientTextBox.TabIndex = 2;
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "nom", true));
            this.nomTextBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomTextBox.Location = new System.Drawing.Point(279, 140);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(222, 32);
            this.nomTextBox.TabIndex = 4;
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "prenom", true));
            this.prenomTextBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomTextBox.Location = new System.Drawing.Point(279, 195);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(222, 32);
            this.prenomTextBox.TabIndex = 6;
            // 
            // adressTextBox
            // 
            this.adressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "adress", true));
            this.adressTextBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adressTextBox.Location = new System.Drawing.Point(279, 250);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(222, 32);
            this.adressTextBox.TabIndex = 8;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "telephone", true));
            this.telephoneTextBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephoneTextBox.Location = new System.Drawing.Point(279, 321);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(222, 32);
            this.telephoneTextBox.TabIndex = 10;
            // 
            // frmAddClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 392);
            this.Controls.Add(codeClientLabel);
            this.Controls.Add(this.codeClientTextBox);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.prenomTextBox);
            this.Controls.Add(adressLabel);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(this.telephoneTextBox);
            this.Controls.Add(this.clientBindingNavigator);
            this.MaximizeBox = false;
            this.Name = "frmAddClients";
            this.Text = "frmAddClients";
            this.Load += new System.EventHandler(this.frmAddClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDstockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingNavigator)).EndInit();
            this.clientBindingNavigator.ResumeLayout(false);
            this.clientBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDstockDataSet bDstockDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private BDstockDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private BDstockDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clientBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton clientBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox codeClientTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
    }
}