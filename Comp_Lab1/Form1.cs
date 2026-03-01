namespace Comp_Lab1;

public partial class Form1 : Form
{
    string currentFilePath = null;
    public Form1()
    {
        InitializeComponent();
    }


    private void fastColoredTextBox1_DragEnter(object sender, DragEventArgs e)
    {
        if (e.Data.GetDataPresent(DataFormats.FileDrop))
        {
            e.Effect = DragDropEffects.Copy;
        }
    }

    private void fastColoredTextBox1_DragDrop(object sender, DragEventArgs e)
    {
        string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

        if (files.Length > 0)
        {
            string filePath = files[0]; 
            try
            {
                string content = System.IO.File.ReadAllText(filePath);
                fastColoredTextBox1.Text = content;
                fastColoredTextBox1.IsChanged = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при открытии файла: " + ex.Message);
            }
        }
    }
    private void CreateFile(object sender = null, EventArgs e = null)
    {
        if (fastColoredTextBox1.IsChanged)
        {
            var result = MessageBox.Show("Сохранить текущие изменения?", "Создание файла", 
                MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes) SaveFile();
            else if (result == DialogResult.Cancel) return; // Прерываем создание
        }
        fastColoredTextBox1.Clear();
        currentFilePath = null;
        fastColoredTextBox1.IsChanged = false;
    }
    private void OpenFile(object sender = null, EventArgs e = null)
    {
        if (fastColoredTextBox1.IsChanged)
        {
            var result = MessageBox.Show("Сохранить текущие изменения перед открытием нового файла?", 
                "Открытие файла", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes) SaveFile();
            else if (result == DialogResult.Cancel) return; // Прерываем открытие
        }

        OpenFileDialog ofd = new OpenFileDialog { Filter = "Text Files|*.txt|All Files|*.*" };
        if (ofd.ShowDialog() == DialogResult.OK)
        {
            fastColoredTextBox1.Text = System.IO.File.ReadAllText(ofd.FileName);
            currentFilePath = ofd.FileName;
            fastColoredTextBox1.IsChanged = false;
        }
    }
    private void SaveFile(object sender = null, EventArgs e = null) {
        if (string.IsNullOrEmpty(currentFilePath)) {
            SaveFileAs(); // Теперь это сработает, так как аргументы могут быть null
        } else {
            System.IO.File.WriteAllText(currentFilePath, fastColoredTextBox1.Text);
            fastColoredTextBox1.IsChanged = false;
        }
    }
    private void SaveFileAs(object sender = null, EventArgs e = null) {
        SaveFileDialog sfd = new SaveFileDialog { Filter = "Text Files|*.txt|All Files|*.*" };
        if (sfd.ShowDialog() == DialogResult.OK) {
            currentFilePath = sfd.FileName;
            SaveFile(); // Вызов без параметров
        }
    }
    private void ExitApp(object sender = null, EventArgs e = null)
    {
        this.Close(); // Это вызовет FormClosing, и сработает наша проверка
    }
    
    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        // Если текст был изменен
        if (fastColoredTextBox1.IsChanged)
        {
            var result = MessageBox.Show("Сохранить изменения перед выходом?", "Выход", 
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SaveFile(); // Сохраняем и выходим
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true; // ОСТАНАВЛИВАЕМ закрытие программы
            }
            // Если выбрано "No", программа просто закроется сама
        }
    }
    private void RunParser(object sender = null, EventArgs e = null) 
    {
        // 1. Получаем текст из редактора для анализа
        string codeToAnalyze = fastColoredTextBox1.Text;

        // 2. Проверяем, не пустой ли он
        if (string.IsNullOrWhiteSpace(codeToAnalyze))
        {
            MessageBox.Show("Нет текста для анализа!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // 3. Имитируем работу анализатора (здесь позже будет твоя логика)
        // Пока просто выводим сообщение об успехе
        string resultMessage = "Синтаксический анализ завершен успешно.\n\n" +
                               "Проверено строк: " + fastColoredTextBox1.LinesCount + "\n" +
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
        if (fastColoredTextBox1.UndoEnabled) fastColoredTextBox1.Undo();
    }

    private void Redo_Click(object sender, EventArgs e) {
        if (fastColoredTextBox1.RedoEnabled) fastColoredTextBox1.Redo();
    }

    private void Cut_Click(object sender, EventArgs e) {
        fastColoredTextBox1.Cut();
    }

    private void Copy_Click(object sender, EventArgs e) {
        fastColoredTextBox1.Copy();
    }

    private void Paste_Click(object sender, EventArgs e) {
        fastColoredTextBox1.Paste();
    }

    private void Delete_Click(object sender, EventArgs e) {
        fastColoredTextBox1.SelectedText = "";
    }

    private void SelectAll_Click(object sender, EventArgs e) {
        fastColoredTextBox1.SelectAll();
    }
    private void Placeholder_Click(object sender, EventArgs e)
    {
        MessageBox.Show($"Функционал для  еще не реализован.", "Заглушка");
    }
}