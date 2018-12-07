using System;
using System.IO;
using System.Windows.Forms;

namespace BigFileSender
{
    partial class Form1
        {
            ///<summary>
            /// Обязательная переменная конструктора.
            ///</summary>
            private System.ComponentModel.IContainer components = null;

            ///<summary>
            /// Освободить все используемые ресурсы.
            ///</summary>
            ///<paramname="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            #region Код, автоматически созданный конструктором форм Windows

            ///<summary>
            /// Требуемый метод для поддержки конструктора — не изменяйте 
            /// содержимое этого метода с помощью редактора кода.
            ///</summary>
            private void InitializeComponent()
            {
                this.label1 = new System.Windows.Forms.Label();
                this.button1 = new System.Windows.Forms.Button();
                this.textBox1 = new System.Windows.Forms.TextBox();
                this.textBox2 = new System.Windows.Forms.TextBox();
                this.button2 = new System.Windows.Forms.Button();
                this.comboBox1 = new System.Windows.Forms.ComboBox();
                this.label2 = new System.Windows.Forms.Label();
                this.label3 = new System.Windows.Forms.Label();
                this.label4 = new System.Windows.Forms.Label();
                this.textBox3 = new System.Windows.Forms.TextBox();
                this.button3 = new System.Windows.Forms.Button();
                this.comboBox2 = new System.Windows.Forms.ComboBox();
                this.textBox4 = new System.Windows.Forms.TextBox();
                this.button4 = new System.Windows.Forms.Button();
                this.SuspendLayout();
                // 
                // label1
                // 
                this.label1.AutoSize = true;
                this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.label1.Location = new System.Drawing.Point(9, 9);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(108, 18);
                this.label1.TabIndex = 0;
                this.label1.Text = "Записьфайла:";
                // 
                // button1
                // 
                this.button1.Location = new System.Drawing.Point(240, 36);
                this.button1.Name = "button1";
                this.button1.Size = new System.Drawing.Size(61, 36);
                this.button1.TabIndex = 1;
                this.button1.Text = "Выбрать";
                this.button1.UseVisualStyleBackColor = true;
                this.button1.Click += new System.EventHandler(this.button1_Click);
                // 
                // textBox1
                // 
                this.textBox1.Location = new System.Drawing.Point(12, 45);
                this.textBox1.Name = "textBox1";
                this.textBox1.Size = new System.Drawing.Size(222, 20);
                this.textBox1.TabIndex = 2;
                this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
                // 
                // textBox2
                // 
                this.textBox2.Location = new System.Drawing.Point(12, 124);
                this.textBox2.Multiline = true;
                this.textBox2.Name = "textBox2";
                this.textBox2.ReadOnly = true;
                this.textBox2.Size = new System.Drawing.Size(221, 42);
                this.textBox2.TabIndex = 3;
                this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
                // 
                // button2
                // 
                this.button2.Location = new System.Drawing.Point(12, 172);
                this.button2.Name = "button2";
                this.button2.Size = new System.Drawing.Size(222, 52);
                this.button2.TabIndex = 4;
                this.button2.Text = "Запись";
                this.button2.UseVisualStyleBackColor = true;
                this.button2.Click += new System.EventHandler(this.button2_Click);
                // 
                // comboBox1
                // 
                this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.comboBox1.FormattingEnabled = true;
                this.comboBox1.Location = new System.Drawing.Point(12, 84);
                this.comboBox1.Name = "comboBox1";
                this.comboBox1.Size = new System.Drawing.Size(221, 21);
                this.comboBox1.TabIndex = 5;
                // 
                // label2
                // 
                this.label2.AutoSize = true;
                this.label2.Location = new System.Drawing.Point(12, 68);
                this.label2.Name = "label2";
                this.label2.Size = new System.Drawing.Size(0, 13);
                this.label2.TabIndex = 6;
                // 
                // label3
                // 
                this.label3.AutoSize = true;
                this.label3.Location = new System.Drawing.Point(12, 108);
                this.label3.Name = "label3";
                this.label3.Size = new System.Drawing.Size(0, 13);
                this.label3.TabIndex = 7;
                // 
                // label4
                // 
                this.label4.AutoSize = true;
                this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.label4.Location = new System.Drawing.Point(352, 9);
                this.label4.Name = "label4";
                this.label4.Size = new System.Drawing.Size(174, 18);
                this.label4.TabIndex = 8;
                this.label4.Text = "Восстановлениефайла:";
                // 
                // textBox3
                // 
                this.textBox3.Location = new System.Drawing.Point(355, 45);
                this.textBox3.Name = "textBox3";
                this.textBox3.ReadOnly = true;
                this.textBox3.Size = new System.Drawing.Size(222, 20);
                this.textBox3.TabIndex = 9;
                // 
                // button3
                // 
                this.button3.Location = new System.Drawing.Point(583, 36);
                this.button3.Name = "button3";
                this.button3.Size = new System.Drawing.Size(61, 36);
                this.button3.TabIndex = 10;
                this.button3.Text = "Выбрать";
                this.button3.UseVisualStyleBackColor = true;
                this.button3.Click += new System.EventHandler(this.button3_Click);
                // 
                // comboBox2
                // 
                this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.comboBox2.FormattingEnabled = true;
                this.comboBox2.Location = new System.Drawing.Point(355, 84);
                this.comboBox2.Name = "comboBox2";
                this.comboBox2.Size = new System.Drawing.Size(221, 21);
                this.comboBox2.TabIndex = 11;
                // 
                // textBox4
                // 
                this.textBox4.Location = new System.Drawing.Point(355, 124);
                this.textBox4.Multiline = true;
                this.textBox4.Name = "textBox4";
                this.textBox4.ReadOnly = true;
                this.textBox4.Size = new System.Drawing.Size(221, 42);
                this.textBox4.TabIndex = 12;
                // 
                // button4
                // 
                this.button4.Location = new System.Drawing.Point(355, 172);
                this.button4.Name = "button4";
                this.button4.Size = new System.Drawing.Size(222, 52);
                this.button4.TabIndex = 13;
                this.button4.Text = "Восстановить";
                this.button4.UseVisualStyleBackColor = true;
                this.button4.Click += new System.EventHandler(this.button4_Click);
                // 
                // Form1
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(649, 243);
                this.Controls.Add(this.button4);
                this.Controls.Add(this.textBox4);
                this.Controls.Add(this.comboBox2);
                this.Controls.Add(this.button3);
                this.Controls.Add(this.textBox3);
                this.Controls.Add(this.label4);
                this.Controls.Add(this.label3);
                this.Controls.Add(this.label2);
                this.Controls.Add(this.comboBox1);
                this.Controls.Add(this.button2);
                this.Controls.Add(this.textBox2);
                this.Controls.Add(this.textBox1);
                this.Controls.Add(this.button1);
                this.Controls.Add(this.label1);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                this.Name = "Form1";
                this.Text = "OSCourse";
                this.ResumeLayout(false);
                this.PerformLayout();

            }
        private long readed = 0;
            private void button4_Click(object sender, EventArgs e)
            {
                string filename = comboBox2.SelectedItem.ToString();

                string[] files = Directory.GetFiles(textBox3.Text);
                int parts = 0;
                for (int i = 0; i < files.Length; i++)
                {
                    if ((files[i].IndexOf("FCHUNK") > 0) && (files[i].IndexOf(filename) > 0))
                    {
                        String tmp = files[i].Substring(files[i].IndexOf("(&%") + 3);
                        tmp = tmp.Split(')')[0];
                        tmp = tmp.Substring(0, tmp.IndexOf("FCHUNK"));
                        parts = int.Parse(tmp);
                        break;
                    }
                }
                Stream full = File.Create(textBox3.Text + "\\" + filename);

                for (int i = 0; i <= parts; i++)
                {
                    Stream part;
                    if (i == parts)
                        part = File.OpenRead(textBox3.Text + "\\(&%" + i + "FCHUNK)" + filename);
                    else
                        part = File.OpenRead(textBox3.Text + "\\(" + i + "CHUNK)" + filename);
                    byte[] buffer = new byte[20971520];
                    long bytesread = 0;
                    while (bytesread < part.Length)
                    {
                        part.Position = bytesread;
                        if ((part.Length - bytesread) < 20971520)
                        {
                            int tmp = int.Parse((part.Length - bytesread).ToString());
                            part.Read(buffer, 0, tmp);
                            full.Write(buffer, 0, tmp);
                            bytesread += tmp;
                            break;
                        }
                        part.Read(buffer, 0, 20971520);
                        full.Write(buffer, 0, 20971520);
                        bytesread += 20971520;
                    }
                    part.Close();
                }
                full.Flush();
                full.Close();

                textBox4.Text = "Успешно восстановлено";

            }

            private void button3_Click(object sender, EventArgs e)
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    textBox3.Text = fbd.SelectedPath;
                    string[] files = Directory.GetFiles(textBox3.Text);
                    string name = "";
                    for (int i = 0; i < files.Length; i++) {
                        if (files[i].IndexOf(')') != -1)
                        {
                            string tmp = files[i];
                            name = tmp.Substring(tmp.IndexOf(')') + 1);
                            if(!comboBox2.Items.Contains(name))
                                comboBox2.Items.Add(name);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка открытия директории");
                    return;
                }

            }

            private void button2_Click(object sender, EventArgs e)
            {
                DriveInfo drinf = (DriveInfo)comboBox1.SelectedItem;
                long bytesremaining = 0;
                    FileInfo fi = new FileInfo(textBox1.Text);
                    if (readed == 0 && fi.Length <= drinf.AvailableFreeSpace)
                    {
                        File.Copy(textBox1.Text, comboBox1.Text + fi.Name);
                        textBox2.Text = "Файл успешно скопирован";
                        return;
                    }
                    else
                    {
                        input = File.OpenRead(fi.FullName);
                        
                        bytesremaining = input.Length-readed;
                        long chunk = drinf.AvailableFreeSpace;
                        Stream output;
                        byte[] buffer = new byte[20971520];
                        int bytesread = 0;
                        if (chunk > bytesremaining)
                        {
                            chunk = bytesremaining;
                            output = File.Create(drinf.RootDirectory.ToString() + "(&%" + chunkindex + "FCHUNK)" + fi.Name);
                        }
                        else
                        {
                            output = File.Create(drinf.RootDirectory.ToString() + "(" + chunkindex + "CHUNK)" + fi.Name);
                        }
                        while (bytesread < chunk)
                        {
                            input.Position = readed;
                            if ((chunk - bytesread) < 20971520)
                            {
                                int tmp = int.Parse((chunk - bytesread).ToString());                               
                                input.Read(buffer, 0, tmp);
                                output.Write(buffer, 0, tmp);
                                bytesread += tmp;
                                readed += tmp;
                                break;
                            }

                            input.Read(buffer, 0, 20971520);
                            output.Write(buffer, 0, 20971520);
                            bytesread += 20971520;
                            readed += 20971520;
                        }
                        output.Flush();
                        output.Close();
                        chunkindex++;
                        button2.Text = "Далее";
                        textBox2.AppendText("Вставьте следующий носитель\n");
                        readed = bytesread;

                        bytesremaining = bytesremaining - chunk;
                        if (bytesremaining == 0)
                        {
                            textBox2.AppendText("Запись прошла успешно\n");
                            button2.Text = "Запись";
                            label3.Text = "Свободно " + (((drinf.TotalFreeSpace) / 1024) / 1024).ToString() + " МБ";
                            input.Close();
                            input = null;
                            chunkindex = 0;
                            bytesremaining = 0;
                            readed = 0;
                        }

                    }
                }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == UsbNotification.WmDevicechange)
            {
                switch ((int)m.WParam)
                {
                    case UsbNotification.DbtDeviceremovecomplete:
                        comboBox1.Items.Clear();

                        foreach (DriveInfo drive in DriveInfo.GetDrives())
                        {
                            if (drive.DriveType == DriveType.Removable)
                            {
                                comboBox1.Items.Add(drive);
                            }
                        }
                        break;
                    case UsbNotification.DbtDevicearrival:
                        comboBox1.Items.Clear();
                        comboBox2.Items.Clear();

                        foreach (DriveInfo drive in DriveInfo.GetDrives())
                        {
                            if (drive.DriveType == DriveType.Removable)
                            {
                                comboBox1.Items.Add(drive);
                            }
                        }
                        break;
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = "C:\\";
                ofd.RestoreDirectory = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = ofd.FileName;
                    FileInfo fi = new FileInfo(ofd.FileName);
                    label2.Text = (((fi.Length) / 1024) / 1024).ToString() + " МБ";
                    textBox2.Text = "";
                    chunkindex = 1;
                }
                else
                {
                    MessageBox.Show("Ошибка открытия файла");
                }

            }

            #endregion

            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.Button button1;
            private System.Windows.Forms.TextBox textBox1;
            private System.Windows.Forms.TextBox textBox2;
            private System.Windows.Forms.Button button2;
            private System.Windows.Forms.ComboBox comboBox1;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.Label label3;
            private System.Windows.Forms.Label label4;
            private System.Windows.Forms.TextBox textBox3;
            private System.Windows.Forms.Button button3;
            private System.Windows.Forms.ComboBox comboBox2;
            private System.Windows.Forms.TextBox textBox4;
            private System.Windows.Forms.Button button4;
            private EventHandler comboBox1_SelectedIndexChanged;
            private int chunkindex;
        private FileStream input;

        public EventHandler Form1_Load { get; private set; }
    }
}
