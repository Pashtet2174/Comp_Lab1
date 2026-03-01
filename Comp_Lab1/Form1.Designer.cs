namespace Comp_Lab1;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        menuStrip1 = new System.Windows.Forms.MenuStrip();
        файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        текстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        отменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        повторитToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        выделитьВсёToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        текстToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        постановкаЗадачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        грамматикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        классификацияГрамматикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        методАнализаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        тестовыйПримерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        списокЛитературыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        исходныйКодПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        пускToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        вызовСправкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        toolStrip1 = new System.Windows.Forms.ToolStrip();
        toolStripButton1 = new System.Windows.Forms.ToolStripButton();
        toolStripButton2 = new System.Windows.Forms.ToolStripButton();
        toolStripButton3 = new System.Windows.Forms.ToolStripButton();
        toolStripButton4 = new System.Windows.Forms.ToolStripButton();
        toolStripButton5 = new System.Windows.Forms.ToolStripButton();
        toolStripButton6 = new System.Windows.Forms.ToolStripButton();
        toolStripButton7 = new System.Windows.Forms.ToolStripButton();
        toolStripButton9 = new System.Windows.Forms.ToolStripButton();
        toolStripButton10 = new System.Windows.Forms.ToolStripButton();
        toolStripButton11 = new System.Windows.Forms.ToolStripButton();
        toolStripButton8 = new System.Windows.Forms.ToolStripButton();
        splitContainer1 = new System.Windows.Forms.SplitContainer();
        tabControlEditor = new System.Windows.Forms.TabControl();
        textBox1 = new System.Windows.Forms.TextBox();
        menuStrip1.SuspendLayout();
        toolStrip1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
        menuStrip1.Font = new System.Drawing.Font("Wide Latin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
        menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { файлToolStripMenuItem, текстToolStripMenuItem, текстToolStripMenuItem1, пускToolStripMenuItem, справкаToolStripMenuItem });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 650);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Padding = new System.Windows.Forms.Padding(0);
        menuStrip1.Size = new System.Drawing.Size(2079, 32);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // файлToolStripMenuItem
        // 
        файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { создатьToolStripMenuItem, открытьToolStripMenuItem, сохранитьToolStripMenuItem, сохранитьКакToolStripMenuItem, выходToolStripMenuItem });
        файлToolStripMenuItem.Name = "файлToolStripMenuItem";
        файлToolStripMenuItem.Size = new System.Drawing.Size(73, 32);
        файлToolStripMenuItem.Text = "Файл";
        // 
        // создатьToolStripMenuItem
        // 
        создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
        создатьToolStripMenuItem.Size = new System.Drawing.Size(231, 32);
        создатьToolStripMenuItem.Text = "Создать";
        создатьToolStripMenuItem.Click += CreateFile;
        // 
        // открытьToolStripMenuItem
        // 
        открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
        открытьToolStripMenuItem.Size = new System.Drawing.Size(231, 32);
        открытьToolStripMenuItem.Text = "Открыть";
        открытьToolStripMenuItem.Click += OpenFile;
        // 
        // сохранитьToolStripMenuItem
        // 
        сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
        сохранитьToolStripMenuItem.Size = new System.Drawing.Size(231, 32);
        сохранитьToolStripMenuItem.Text = "Сохранить";
        сохранитьToolStripMenuItem.Click += SaveFile;
        // 
        // сохранитьКакToolStripMenuItem
        // 
        сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
        сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(231, 32);
        сохранитьКакToolStripMenuItem.Text = "Сохранить как";
        сохранитьКакToolStripMenuItem.Click += SaveFileAs;
        // 
        // выходToolStripMenuItem
        // 
        выходToolStripMenuItem.Name = "выходToolStripMenuItem";
        выходToolStripMenuItem.Size = new System.Drawing.Size(231, 32);
        выходToolStripMenuItem.Text = "Выход";
        выходToolStripMenuItem.Click += ExitApp;
        // 
        // текстToolStripMenuItem
        // 
        текстToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { отменитьToolStripMenuItem, повторитToolStripMenuItem, вырезатьToolStripMenuItem, копироватьToolStripMenuItem, вставитьToolStripMenuItem, удалитьToolStripMenuItem, выделитьВсёToolStripMenuItem });
        текстToolStripMenuItem.Name = "текстToolStripMenuItem";
        текстToolStripMenuItem.Size = new System.Drawing.Size(90, 32);
        текстToolStripMenuItem.Text = "Правка";
        // 
        // отменитьToolStripMenuItem
        // 
        отменитьToolStripMenuItem.Name = "отменитьToolStripMenuItem";
        отменитьToolStripMenuItem.Size = new System.Drawing.Size(227, 32);
        отменитьToolStripMenuItem.Text = "Отменить";
        отменитьToolStripMenuItem.Click += Undo_Click;
        // 
        // повторитToolStripMenuItem
        // 
        повторитToolStripMenuItem.Name = "повторитToolStripMenuItem";
        повторитToolStripMenuItem.Size = new System.Drawing.Size(227, 32);
        повторитToolStripMenuItem.Text = "Повторить";
        повторитToolStripMenuItem.Click += Redo_Click;
        // 
        // вырезатьToolStripMenuItem
        // 
        вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
        вырезатьToolStripMenuItem.Size = new System.Drawing.Size(227, 32);
        вырезатьToolStripMenuItem.Text = "Вырезать";
        вырезатьToolStripMenuItem.Click += Cut_Click;
        // 
        // копироватьToolStripMenuItem
        // 
        копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
        копироватьToolStripMenuItem.Size = new System.Drawing.Size(227, 32);
        копироватьToolStripMenuItem.Text = "Копировать";
        копироватьToolStripMenuItem.Click += Copy_Click;
        // 
        // вставитьToolStripMenuItem
        // 
        вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
        вставитьToolStripMenuItem.Size = new System.Drawing.Size(227, 32);
        вставитьToolStripMenuItem.Text = "Вставить";
        вставитьToolStripMenuItem.Click += Paste_Click;
        // 
        // удалитьToolStripMenuItem
        // 
        удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
        удалитьToolStripMenuItem.Size = new System.Drawing.Size(227, 32);
        удалитьToolStripMenuItem.Text = "Удалить";
        удалитьToolStripMenuItem.Click += Delete_Click;
        // 
        // выделитьВсёToolStripMenuItem
        // 
        выделитьВсёToolStripMenuItem.Name = "выделитьВсёToolStripMenuItem";
        выделитьВсёToolStripMenuItem.Size = new System.Drawing.Size(227, 32);
        выделитьВсёToolStripMenuItem.Text = "Выделить всё";
        выделитьВсёToolStripMenuItem.Click += SelectAll_Click;
        // 
        // текстToolStripMenuItem1
        // 
        текстToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { постановкаЗадачиToolStripMenuItem, грамматикаToolStripMenuItem, классификацияГрамматикиToolStripMenuItem, методАнализаToolStripMenuItem, тестовыйПримерToolStripMenuItem, списокЛитературыToolStripMenuItem, исходныйКодПрограммыToolStripMenuItem });
        текстToolStripMenuItem1.Name = "текстToolStripMenuItem1";
        текстToolStripMenuItem1.Size = new System.Drawing.Size(78, 32);
        текстToolStripMenuItem1.Text = "Текст";
        // 
        // постановкаЗадачиToolStripMenuItem
        // 
        постановкаЗадачиToolStripMenuItem.Name = "постановкаЗадачиToolStripMenuItem";
        постановкаЗадачиToolStripMenuItem.Size = new System.Drawing.Size(351, 32);
        постановкаЗадачиToolStripMenuItem.Text = "Постановка задачи";
        постановкаЗадачиToolStripMenuItem.Click += Placeholder_Click;
        // 
        // грамматикаToolStripMenuItem
        // 
        грамматикаToolStripMenuItem.Name = "грамматикаToolStripMenuItem";
        грамматикаToolStripMenuItem.Size = new System.Drawing.Size(351, 32);
        грамматикаToolStripMenuItem.Text = "Грамматика";
        грамматикаToolStripMenuItem.Click += Placeholder_Click;
        // 
        // классификацияГрамматикиToolStripMenuItem
        // 
        классификацияГрамматикиToolStripMenuItem.Name = "классификацияГрамматикиToolStripMenuItem";
        классификацияГрамматикиToolStripMenuItem.Size = new System.Drawing.Size(351, 32);
        классификацияГрамматикиToolStripMenuItem.Text = "Классификация грамматики";
        классификацияГрамматикиToolStripMenuItem.Click += Placeholder_Click;
        // 
        // методАнализаToolStripMenuItem
        // 
        методАнализаToolStripMenuItem.Name = "методАнализаToolStripMenuItem";
        методАнализаToolStripMenuItem.Size = new System.Drawing.Size(351, 32);
        методАнализаToolStripMenuItem.Text = "Метод анализа";
        методАнализаToolStripMenuItem.Click += Placeholder_Click;
        // 
        // тестовыйПримерToolStripMenuItem
        // 
        тестовыйПримерToolStripMenuItem.Name = "тестовыйПримерToolStripMenuItem";
        тестовыйПримерToolStripMenuItem.Size = new System.Drawing.Size(351, 32);
        тестовыйПримерToolStripMenuItem.Text = "Тестовый пример";
        тестовыйПримерToolStripMenuItem.Click += Placeholder_Click;
        // 
        // списокЛитературыToolStripMenuItem
        // 
        списокЛитературыToolStripMenuItem.Name = "списокЛитературыToolStripMenuItem";
        списокЛитературыToolStripMenuItem.Size = new System.Drawing.Size(351, 32);
        списокЛитературыToolStripMenuItem.Text = "Список литературы";
        списокЛитературыToolStripMenuItem.Click += Placeholder_Click;
        // 
        // исходныйКодПрограммыToolStripMenuItem
        // 
        исходныйКодПрограммыToolStripMenuItem.Name = "исходныйКодПрограммыToolStripMenuItem";
        исходныйКодПрограммыToolStripMenuItem.Size = new System.Drawing.Size(351, 32);
        исходныйКодПрограммыToolStripMenuItem.Text = "Исходный код программы";
        исходныйКодПрограммыToolStripMenuItem.Click += Placeholder_Click;
        // 
        // пускToolStripMenuItem
        // 
        пускToolStripMenuItem.Name = "пускToolStripMenuItem";
        пускToolStripMenuItem.Size = new System.Drawing.Size(67, 32);
        пускToolStripMenuItem.Text = "Пуск";
        пускToolStripMenuItem.Click += RunParser;
        // 
        // справкаToolStripMenuItem
        // 
        справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { вызовСправкиToolStripMenuItem, оПрограммеToolStripMenuItem });
        справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
        справкаToolStripMenuItem.Size = new System.Drawing.Size(101, 32);
        справкаToolStripMenuItem.Text = "Справка";
        // 
        // вызовСправкиToolStripMenuItem
        // 
        вызовСправкиToolStripMenuItem.Name = "вызовСправкиToolStripMenuItem";
        вызовСправкиToolStripMenuItem.Size = new System.Drawing.Size(235, 32);
        вызовСправкиToolStripMenuItem.Text = "Вызов справки";
        вызовСправкиToolStripMenuItem.Click += ShowHelp;
        // 
        // оПрограммеToolStripMenuItem
        // 
        оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
        оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(235, 32);
        оПрограммеToolStripMenuItem.Text = "О программе";
        оПрограммеToolStripMenuItem.Click += ShowAbout;
        // 
        // toolStrip1
        // 
        toolStrip1.BackColor = System.Drawing.Color.Gainsboro;
        toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
        toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4, toolStripButton5, toolStripButton6, toolStripButton7, toolStripButton9, toolStripButton10, toolStripButton11, toolStripButton8 });
        toolStrip1.Location = new System.Drawing.Point(0, 32);
        toolStrip1.Name = "toolStrip1";
        toolStrip1.Padding = new System.Windows.Forms.Padding(0);
        toolStrip1.Size = new System.Drawing.Size(2079, 47);
        toolStrip1.TabIndex = 0;
        toolStrip1.Text = "toolStrip1";
        // 
        // toolStripButton1
        // 
        toolStripButton1.BackColor = System.Drawing.Color.Transparent;
        toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        toolStripButton1.Image = ((System.Drawing.Image)resources.GetObject("toolStripButton1.Image"));
        toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
        toolStripButton1.Name = "toolStripButton1";
        toolStripButton1.Size = new System.Drawing.Size(44, 44);
        toolStripButton1.Text = "Создать";
        toolStripButton1.Click += CreateFile;
        // 
        // toolStripButton2
        // 
        toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        toolStripButton2.Image = ((System.Drawing.Image)resources.GetObject("toolStripButton2.Image"));
        toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
        toolStripButton2.Name = "toolStripButton2";
        toolStripButton2.Size = new System.Drawing.Size(44, 44);
        toolStripButton2.Text = "Открыть";
        toolStripButton2.Click += OpenFile;
        // 
        // toolStripButton3
        // 
        toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        toolStripButton3.Image = ((System.Drawing.Image)resources.GetObject("toolStripButton3.Image"));
        toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
        toolStripButton3.Name = "toolStripButton3";
        toolStripButton3.Size = new System.Drawing.Size(44, 44);
        toolStripButton3.Text = "Сохранить";
        toolStripButton3.Click += SaveFile;
        // 
        // toolStripButton4
        // 
        toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        toolStripButton4.Image = ((System.Drawing.Image)resources.GetObject("toolStripButton4.Image"));
        toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
        toolStripButton4.Name = "toolStripButton4";
        toolStripButton4.Size = new System.Drawing.Size(44, 44);
        toolStripButton4.Text = "Отмена";
        toolStripButton4.Click += Undo_Click;
        // 
        // toolStripButton5
        // 
        toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        toolStripButton5.Image = ((System.Drawing.Image)resources.GetObject("toolStripButton5.Image"));
        toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
        toolStripButton5.Name = "toolStripButton5";
        toolStripButton5.Size = new System.Drawing.Size(44, 44);
        toolStripButton5.Text = "Повтор";
        toolStripButton5.Click += Redo_Click;
        // 
        // toolStripButton6
        // 
        toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        toolStripButton6.Image = ((System.Drawing.Image)resources.GetObject("toolStripButton6.Image"));
        toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
        toolStripButton6.Name = "toolStripButton6";
        toolStripButton6.Size = new System.Drawing.Size(44, 44);
        toolStripButton6.Text = "Копировать";
        toolStripButton6.Click += Copy_Click;
        // 
        // toolStripButton7
        // 
        toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        toolStripButton7.Image = ((System.Drawing.Image)resources.GetObject("toolStripButton7.Image"));
        toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
        toolStripButton7.Name = "toolStripButton7";
        toolStripButton7.Size = new System.Drawing.Size(44, 44);
        toolStripButton7.Text = "Вырезать";
        toolStripButton7.Click += Cut_Click;
        // 
        // toolStripButton9
        // 
        toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        toolStripButton9.Image = ((System.Drawing.Image)resources.GetObject("toolStripButton9.Image"));
        toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
        toolStripButton9.Name = "toolStripButton9";
        toolStripButton9.Size = new System.Drawing.Size(44, 44);
        toolStripButton9.Text = "Вставить";
        toolStripButton9.Click += Paste_Click;
        // 
        // toolStripButton10
        // 
        toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        toolStripButton10.Image = ((System.Drawing.Image)resources.GetObject("toolStripButton10.Image"));
        toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
        toolStripButton10.Name = "toolStripButton10";
        toolStripButton10.Size = new System.Drawing.Size(44, 44);
        toolStripButton10.Text = "Запустить";
        toolStripButton10.Click += RunParser;
        // 
        // toolStripButton11
        // 
        toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        toolStripButton11.Image = ((System.Drawing.Image)resources.GetObject("toolStripButton11.Image"));
        toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
        toolStripButton11.Name = "toolStripButton11";
        toolStripButton11.Size = new System.Drawing.Size(44, 44);
        toolStripButton11.Text = "Справка";
        toolStripButton11.Click += ShowHelp;
        // 
        // toolStripButton8
        // 
        toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        toolStripButton8.Image = ((System.Drawing.Image)resources.GetObject("toolStripButton8.Image"));
        toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
        toolStripButton8.Name = "toolStripButton8";
        toolStripButton8.Size = new System.Drawing.Size(44, 44);
        toolStripButton8.Text = "О программе";
        toolStripButton8.Click += ShowAbout;
        // 
        // splitContainer1
        // 
        splitContainer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
        splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
        splitContainer1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
        splitContainer1.Location = new System.Drawing.Point(0, 79);
        splitContainer1.Margin = new System.Windows.Forms.Padding(358438, 3, 358438, 3);
        splitContainer1.Name = "splitContainer1";
        splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(tabControlEditor);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(textBox1);
        splitContainer1.Size = new System.Drawing.Size(2079, 704);
        splitContainer1.SplitterDistance = 320;
        splitContainer1.SplitterWidth = 121;
        splitContainer1.TabIndex = 2;
        splitContainer1.Text = "splitContainer1";
        // 
        // tabControlEditor
        // 
        tabControlEditor.Dock = System.Windows.Forms.DockStyle.Fill;
        tabControlEditor.Location = new System.Drawing.Point(0, 0);
        tabControlEditor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tabControlEditor.Name = "tabControlEditor";
        tabControlEditor.SelectedIndex = 0;
        tabControlEditor.Size = new System.Drawing.Size(2079, 320);
        tabControlEditor.TabIndex = 0;
        // 
        // textBox1
        // 
        textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        textBox1.Location = new System.Drawing.Point(0, 0);
        textBox1.Margin = new System.Windows.Forms.Padding(358438, 3, 358438, 3);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.ReadOnly = true;
        textBox1.Size = new System.Drawing.Size(2079, 263);
        textBox1.TabIndex = 0;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(2079, 783);
        Controls.Add(splitContainer1);
        Controls.Add(toolStrip1);
        Controls.Add(menuStrip1);
        Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        ForeColor = System.Drawing.SystemColors.AppWorkspace;
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        MainMenuStrip = menuStrip1;
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        MinimumSize = new System.Drawing.Size(700, 600);
        Text = "Компилятор";
        FormClosing += Form1_FormClosing;
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        toolStrip1.ResumeLayout(false);
        toolStrip1.PerformLayout();
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        splitContainer1.Panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TabControl tabControlEditor;


    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.SplitContainer splitContainer1;

    private System.Windows.Forms.ToolStripButton toolStripButton3;
    private System.Windows.Forms.ToolStripButton toolStripButton4;
    private System.Windows.Forms.ToolStripButton toolStripButton5;
    private System.Windows.Forms.ToolStripButton toolStripButton6;
    private System.Windows.Forms.ToolStripButton toolStripButton7;
    private System.Windows.Forms.ToolStripButton toolStripButton8;
    private System.Windows.Forms.ToolStripButton toolStripButton9;
    private System.Windows.Forms.ToolStripButton toolStripButton10;
    private System.Windows.Forms.ToolStripButton toolStripButton11;

    private System.Windows.Forms.ToolStripButton toolStripButton2;

    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton toolStripButton1;

    private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem вызовСправкиToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem исходныйКодПрограммыToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem списокЛитературыToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem тестовыйПримерToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem методАнализаToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem классификацияГрамматикиToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem грамматикаToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem постановкаЗадачиToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem выделитьВсёToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem повторитToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem отменитьToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem пускToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem текстToolStripMenuItem1;

    private System.Windows.Forms.ToolStripMenuItem текстToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;

    private System.Windows.Forms.MenuStrip menuStrip1;

    #endregion
}