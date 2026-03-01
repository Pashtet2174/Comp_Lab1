using FastColoredTextBoxNS;

namespace Comp_Lab1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        // 1. Разрешаем форме принимать файлы
        this.AllowDrop = true;
        this.DragEnter += Form1_DragEnter;
        this.DragDrop += Form1_DragDrop;

        // 2. Рекурсивно разрешаем всем дочерним элементам (TabControl, Панели и т.д.) 
        // принимать файлы и перенаправлять их обработчикам формы
        EnableDragDropForAll(this);
    }
    private void EnableDragDropForAll(Control parent)
    {
        foreach (Control c in parent.Controls)
        {
            c.AllowDrop = true;
            c.DragEnter += Form1_DragEnter;
            c.DragDrop += Form1_DragDrop;
        
            // Если внутри элемента есть другие элементы (например, в SplitContainer)
            if (c.HasChildren)
            {
                EnableDragDropForAll(c);
            }
        }
    }


    private void Form1_DragEnter(object sender, DragEventArgs e)
    {
        if (e.Data.GetDataPresent(DataFormats.FileDrop))
        {
            e.Effect = DragDropEffects.Copy;
        }
    }

    private void Form1_DragDrop(object sender, DragEventArgs e)
    {
        string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
        foreach (string filePath in files)
        {
            try
            {
                string content = System.IO.File.ReadAllText(filePath);
                CreateNewTab(filePath, content);
            }
            catch (Exception ex) { MessageBox.Show("Ошибка: " + ex.Message); }
        }
    }
    private void CreateFile(object sender = null, EventArgs e = null)
    {
        CreateNewTab("Новый файл");
    }

    private void OpenFile(object sender = null, EventArgs e = null)
    {
        OpenFileDialog ofd = new OpenFileDialog { Filter = "Text Files|*.txt|All Files|*.*" };
        if (ofd.ShowDialog() == DialogResult.OK)
        {
            string content = System.IO.File.ReadAllText(ofd.FileName);
            // Метод CreateNewTab сам запишет путь в Tag и создаст вкладку
            CreateNewTab(ofd.FileName, content);
        }
    }
    private void SaveFile(object sender = null, EventArgs e = null) {
        if (tabControlEditor.SelectedTab == null || CurrentEditor == null) return;

        // Читаем путь из Tag текущей вкладки
        string path = tabControlEditor.SelectedTab.Tag as string;

        // Если в Tag написано "Новый файл" или там пусто — вызываем "Сохранить как"
        if (string.IsNullOrEmpty(path) || path == "Новый файл") {
            SaveFileAs(); 
        } else {
            System.IO.File.WriteAllText(path, CurrentEditor.Text);
            CurrentEditor.IsChanged = false;
            // Можно обновить заголовок вкладки (убрать звездочку, если она была)
            tabControlEditor.SelectedTab.Text = System.IO.Path.GetFileName(path);
        }
    }
    private void SaveFileAs(object sender = null, EventArgs e = null) {
        if (tabControlEditor.SelectedTab == null) return;

        SaveFileDialog sfd = new SaveFileDialog { Filter = "Text Files|*.txt|All Files|*.*" };
        if (sfd.ShowDialog() == DialogResult.OK) {
            // Обновляем путь в Tag вкладки
            tabControlEditor.SelectedTab.Tag = sfd.FileName;
            // Обновляем текст на самой вкладке
            tabControlEditor.SelectedTab.Text = System.IO.Path.GetFileName(sfd.FileName);
        
            SaveFile(); // Теперь SaveFile увидит новый путь в Tag и сохранит
        }
    }
    private void ExitApp(object sender = null, EventArgs e = null)
    {
        this.Close(); // Это вызовет FormClosing, и сработает наша проверка
    }
    
    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        foreach (TabPage tab in tabControlEditor.TabPages)
        {
            var fctb = tab.Controls[0] as FastColoredTextBox;
            if (fctb != null && fctb.IsChanged)
            {
                tabControlEditor.SelectedTab = tab; // Переключаемся на измененный файл
                var result = MessageBox.Show($"Сохранить изменения в файле {tab.Text}?", "Выход", 
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) SaveFile();
                else if (result == DialogResult.Cancel) { e.Cancel = true; return; }
            }
        }
    }
    private void RunParser(object sender = null, EventArgs e = null) 
    {
        // 1. Получаем текст из редактора для анализа
        string codeToAnalyze = CurrentEditor.Text;

        // 2. Проверяем, не пустой ли он
        if (string.IsNullOrWhiteSpace(codeToAnalyze))
        {
            MessageBox.Show("Нет текста для анализа!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // 3. Имитируем работу анализатора (здесь позже будет твоя логика)
        // Пока просто выводим сообщение об успехе
        string resultMessage = "Синтаксический анализ завершен успешно.\n\n" +
                               "Проверено строк: " + CurrentEditor.LinesCount + "\n" +
                               "Ошибок не обнаружено.";

        MessageBox.Show(resultMessage, "Результат анализа", MessageBoxButtons.OK, MessageBoxIcon.Information);
    
        // Также хорошим тоном будет дублировать это в нижнее окно (если оно есть)
        // richTextBoxOutput.Text = "Анализ выполнен в " + DateTime.Now.ToLongTimeString();
    }
    private void ShowAbout(object sender, EventArgs e) {
        MessageBox.Show("Текстовый редактор / Языковой процессор\nВерсия 1.0\nРазработчик: Твоё Имя", "О программе");
    }

    private void ShowHelp(object sender, EventArgs e) {
        MessageBox.Show("Руководство пользователя:\n1. Используйте меню Файл для работы с документами.\n2. Правка - для редактирования.\n3. Кнопка 'Пуск' запустит анализ кода.", "Справка");
    }
    private void Undo_Click(object sender, EventArgs e) {
        if (CurrentEditor.UndoEnabled) CurrentEditor.Undo();
    }

    private void Redo_Click(object sender, EventArgs e) {
        if (CurrentEditor.RedoEnabled) CurrentEditor.Redo();
    }

    private void Cut_Click(object sender, EventArgs e) {
        CurrentEditor.Cut();
    }

    private void Copy_Click(object sender, EventArgs e) {
        CurrentEditor.Copy();
    }

    private void Paste_Click(object sender, EventArgs e) {
        CurrentEditor.Paste();
    }

    private void Delete_Click(object sender, EventArgs e) {
        CurrentEditor.SelectedText = "";
    }

    private void SelectAll_Click(object sender, EventArgs e) {
        CurrentEditor.SelectAll();
    }
    private void Placeholder_Click(object sender, EventArgs e)
    {
        MessageBox.Show($"Функционал для  еще не реализован.", "Заглушка");
    }
    
    private FastColoredTextBox CreateNewTab(string fileName = "Новый файл", string content = "")
    {
        TabPage newTabPage = new TabPage(System.IO.Path.GetFileName(fileName));
        newTabPage.Tag = (fileName == "Новый файл") ? "" : fileName;
        FastColoredTextBox fctb = new FastColoredTextBox();
        fctb.Dock = DockStyle.Fill;
        fctb.Language = FastColoredTextBoxNS.Language.CSharp;
        fctb.Text = content;

        // --- НАСТРОЙКА ГОРЯЧИХ КЛАВИШ ---
        fctb.HotkeysMapping.Clear();

// Используем полный путь к ServiceAction, чтобы точно не было ошибок
        fctb.HotkeysMapping.Add(Keys.C | Keys.Control, FCTBAction.Copy);
        fctb.HotkeysMapping.Add(Keys.V | Keys.Control, FCTBAction.Paste);
        fctb.HotkeysMapping.Add(Keys.X | Keys.Control, FCTBAction.Cut);
        fctb.HotkeysMapping.Add(Keys.A | Keys.Control, FCTBAction.SelectAll);
        fctb.HotkeysMapping.Add(Keys.Z | Keys.Control, FCTBAction.Undo);
        fctb.HotkeysMapping.Add(Keys.Y | Keys.Control, FCTBAction.Redo);

// Поиск и замена
        fctb.HotkeysMapping.Add(Keys.F | Keys.Control, FCTBAction.FindDialog);
        fctb.HotkeysMapping.Add(Keys.H | Keys.Control, FCTBAction.ReplaceDialog);

// Навигация и строки
        fctb.HotkeysMapping.Add(Keys.G | Keys.Control, FCTBAction.GoToDialog);

// Отступы
        fctb.HotkeysMapping.Add(Keys.Tab, FCTBAction.IndentIncrease);
        fctb.HotkeysMapping.Add(Keys.Tab | Keys.Shift, FCTBAction.IndentDecrease);
        // --- КОНЕЦ НАСТРОЙКИ ---

        newTabPage.Controls.Add(fctb);
        tabControlEditor.TabPages.Add(newTabPage);
        tabControlEditor.SelectedTab = newTabPage;
        
        // Сбрасываем флаг изменений, так как файл только что создан/открыт
        fctb.IsChanged = false;

        return fctb;
    }
    private FastColoredTextBox CurrentEditor => 
        tabControlEditor.SelectedTab?.Controls[0] as FastColoredTextBox;
}