namespace winUpdateDisabler
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.lUpdateState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(12, 47);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(177, 57);
            this.btnEnable.TabIndex = 0;
            this.btnEnable.Text = "Відновити оновлення";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(195, 47);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(177, 57);
            this.btnDisable.TabIndex = 1;
            this.btnDisable.Text = "Призупинити оновлення";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // lUpdateState
            // 
            this.lUpdateState.AutoSize = true;
            this.lUpdateState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lUpdateState.Location = new System.Drawing.Point(12, 9);
            this.lUpdateState.Name = "lUpdateState";
            this.lUpdateState.Size = new System.Drawing.Size(156, 24);
            this.lUpdateState.TabIndex = 2;
            this.lUpdateState.Text = "Стан оновлення";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 114);
            this.Controls.Add(this.lUpdateState);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnEnable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fMain";
            this.Text = "winUpdateDisabler";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Label lUpdateState;
    }
}

