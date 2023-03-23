namespace WindowsFormsAppPrincipal
{
    partial class FormGrupoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGrupoUsuario));
            this.permissoesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.permissoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.permissoesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.permissoesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupoUsuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonAdicionarDescricao = new System.Windows.Forms.Button();
            this.buttonExcluirDescricao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesBindingNavigator)).BeginInit();
            this.permissoesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // permissoesBindingNavigator
            // 
            this.permissoesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.permissoesBindingNavigator.BindingSource = this.permissoesBindingSource;
            this.permissoesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.permissoesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.permissoesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.permissoesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.permissoesBindingNavigatorSaveItem});
            this.permissoesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.permissoesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.permissoesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.permissoesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.permissoesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.permissoesBindingNavigator.Name = "permissoesBindingNavigator";
            this.permissoesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.permissoesBindingNavigator.Size = new System.Drawing.Size(958, 27);
            this.permissoesBindingNavigator.TabIndex = 0;
            this.permissoesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // permissoesBindingSource
            // 
            this.permissoesBindingSource.DataSource = typeof(Models.Permissao);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // permissoesBindingNavigatorSaveItem
            // 
            this.permissoesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.permissoesBindingNavigatorSaveItem.Enabled = false;
            this.permissoesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("permissoesBindingNavigatorSaveItem.Image")));
            this.permissoesBindingNavigatorSaveItem.Name = "permissoesBindingNavigatorSaveItem";
            this.permissoesBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.permissoesBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // permissoesDataGridView
            // 
            this.permissoesDataGridView.AllowUserToAddRows = false;
            this.permissoesDataGridView.AllowUserToDeleteRows = false;
            this.permissoesDataGridView.AllowUserToOrderColumns = true;
            this.permissoesDataGridView.AutoGenerateColumns = false;
            this.permissoesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.permissoesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.permissoesDataGridView.DataSource = this.permissoesBindingSource;
            this.permissoesDataGridView.Location = new System.Drawing.Point(527, 113);
            this.permissoesDataGridView.Name = "permissoesDataGridView";
            this.permissoesDataGridView.ReadOnly = true;
            this.permissoesDataGridView.RowHeadersWidth = 51;
            this.permissoesDataGridView.RowTemplate.Height = 24;
            this.permissoesDataGridView.Size = new System.Drawing.Size(300, 220);
            this.permissoesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn1.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // grupoUsuarioBindingSource
            // 
            this.grupoUsuarioBindingSource.DataSource = typeof(Models.GrupoUsuario);
            // 
            // grupoUsuarioDataGridView
            // 
            this.grupoUsuarioDataGridView.AllowUserToAddRows = false;
            this.grupoUsuarioDataGridView.AllowUserToDeleteRows = false;
            this.grupoUsuarioDataGridView.AllowUserToOrderColumns = true;
            this.grupoUsuarioDataGridView.AutoGenerateColumns = false;
            this.grupoUsuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grupoUsuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.grupoUsuarioDataGridView.DataSource = this.grupoUsuarioBindingSource;
            this.grupoUsuarioDataGridView.Location = new System.Drawing.Point(74, 113);
            this.grupoUsuarioDataGridView.Name = "grupoUsuarioDataGridView";
            this.grupoUsuarioDataGridView.ReadOnly = true;
            this.grupoUsuarioDataGridView.RowHeadersWidth = 51;
            this.grupoUsuarioDataGridView.RowTemplate.Height = 24;
            this.grupoUsuarioDataGridView.Size = new System.Drawing.Size(300, 220);
            this.grupoUsuarioDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeGrupo";
            this.dataGridViewTextBoxColumn2.HeaderText = "NomeGrupo";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(225, 84);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionar.TabIndex = 3;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(306, 84);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 4;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionarDescricao
            // 
            this.buttonAdicionarDescricao.Location = new System.Drawing.Point(671, 84);
            this.buttonAdicionarDescricao.Name = "buttonAdicionarDescricao";
            this.buttonAdicionarDescricao.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionarDescricao.TabIndex = 5;
            this.buttonAdicionarDescricao.Text = "Adicionar";
            this.buttonAdicionarDescricao.UseVisualStyleBackColor = true;
            // 
            // buttonExcluirDescricao
            // 
            this.buttonExcluirDescricao.Location = new System.Drawing.Point(752, 84);
            this.buttonExcluirDescricao.Name = "buttonExcluirDescricao";
            this.buttonExcluirDescricao.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirDescricao.TabIndex = 6;
            this.buttonExcluirDescricao.Text = "Excluir";
            this.buttonExcluirDescricao.UseVisualStyleBackColor = true;
            // 
            // FormGrupoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.Controls.Add(this.buttonExcluirDescricao);
            this.Controls.Add(this.buttonAdicionarDescricao);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.grupoUsuarioDataGridView);
            this.Controls.Add(this.permissoesDataGridView);
            this.Controls.Add(this.permissoesBindingNavigator);
            this.Name = "FormGrupoUsuario";
            this.Text = "FormGrupoUsuario";
            this.Load += new System.EventHandler(this.FormGrupoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.permissoesBindingNavigator)).EndInit();
            this.permissoesBindingNavigator.ResumeLayout(false);
            this.permissoesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource permissoesBindingSource;
        private System.Windows.Forms.BindingNavigator permissoesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton permissoesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView permissoesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource;
        private System.Windows.Forms.DataGridView grupoUsuarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonAdicionarDescricao;
        private System.Windows.Forms.Button buttonExcluirDescricao;
    }
}