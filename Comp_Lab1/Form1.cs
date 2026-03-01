using FastColoredTextBoxNS;

namespace Comp_Lab1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        this.AllowDrop = true;
        this.DragEnter += Form1_DragEnter;
        this.DragDrop += Form1_DragDrop;
        dgvErrors.MouseEnter += (s, e) => dgvErrors.Focus(); 
        dgvErrors.MouseWheel += DgvErrors_MouseWheel;
        EnableDragDropForAll(this);
    }
    private void EnableDragDropForAll(Control parent)
    {
        foreach (Control c in parent.Controls)
        {
            c.AllowDrop = true;
            c.DragEnter += Form1_DragEnter;
            c.DragDrop += Form1_DragDrop;
        
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
            CreateNewTab(ofd.FileName, content);
        }
    }
    private void SaveFile(object sender = null, EventArgs e = null) {
        if (tabControlEditor.SelectedTab == null || CurrentEditor == null) return;

        string path = tabControlEditor.SelectedTab.Tag as string;

        if (string.IsNullOrEmpty(path) || path == "Новый файл") {
            SaveFileAs(); 
        } else {
            System.IO.File.WriteAllText(path, CurrentEditor.Text);
            CurrentEditor.IsChanged = false;
            tabControlEditor.SelectedTab.Text = System.IO.Path.GetFileName(path);
            lblStatus.Text = "Файл успешно сохранен.";
        }
    }
    private void SaveFileAs(object sender = null, EventArgs e = null) {
        if (tabControlEditor.SelectedTab == null) return;

        SaveFileDialog sfd = new SaveFileDialog { Filter = "Text Files|*.txt|All Files|*.*" };
        if (sfd.ShowDialog() == DialogResult.OK) {
            tabControlEditor.SelectedTab.Tag = sfd.FileName;
            tabControlEditor.SelectedTab.Text = System.IO.Path.GetFileName(sfd.FileName);
        
            SaveFile();
        }
    }
    private void ExitApp(object sender = null, EventArgs e = null)
    {
        this.Close();
    }
    
    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        foreach (TabPage tab in tabControlEditor.TabPages)
        {
            var fctb = tab.Controls[0] as FastColoredTextBox;
            if (fctb != null && fctb.IsChanged)
            {
                tabControlEditor.SelectedTab = tab; 
                var result = MessageBox.Show($"Сохранить изменения в файле {tab.Text}?", "Выход", 
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) SaveFile();
                else if (result == DialogResult.Cancel) { e.Cancel = true; return; }
            }
        }
    }
    private void RunParser(object sender = null, EventArgs e = null) 
    {
        if (tabControlEditor.TabPages.Count == 0 || CurrentEditor == null)
        {
            MessageBox.Show("Сначала создайте или откройте файл для анализа!", 
                "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        string resultMessage = "Ошибок не обнаружено.";
        lblStatus.Text = "Анализ завершен.";
        MessageBox.Show(resultMessage, "Результат анализа", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        fctb.HotkeysMapping.Clear();

        // --- Одиночные клавиши ---
        fctb.HotkeysMapping.Add(Keys.Tab, FCTBAction.IndentIncrease);
        fctb.HotkeysMapping.Add(Keys.Escape, FCTBAction.ClearHints);
        fctb.HotkeysMapping.Add(Keys.PageUp, FCTBAction.GoPageUp);
        fctb.HotkeysMapping.Add(Keys.PageDown, FCTBAction.GoPageDown);
        fctb.HotkeysMapping.Add(Keys.End, FCTBAction.GoEnd);
        fctb.HotkeysMapping.Add(Keys.Home, FCTBAction.GoHome);
        fctb.HotkeysMapping.Add(Keys.Left, FCTBAction.GoLeft);
        fctb.HotkeysMapping.Add(Keys.Up, FCTBAction.GoUp);
        fctb.HotkeysMapping.Add(Keys.Right, FCTBAction.GoRight);
        fctb.HotkeysMapping.Add(Keys.Down, FCTBAction.GoDown);
        fctb.HotkeysMapping.Add(Keys.Insert, FCTBAction.ReplaceMode);
        fctb.HotkeysMapping.Add(Keys.Delete, FCTBAction.DeleteCharRight);
        fctb.HotkeysMapping.Add(Keys.F3, FCTBAction.FindNext);

        // --- Shift + Клавиши (Выделение и правка) ---
        fctb.HotkeysMapping.Add(Keys.Tab | Keys.Shift, FCTBAction.IndentDecrease);
        fctb.HotkeysMapping.Add(Keys.PageUp | Keys.Shift, FCTBAction.GoPageUpWithSelection);
        fctb.HotkeysMapping.Add(Keys.PageDown | Keys.Shift, FCTBAction.GoPageDownWithSelection);
        fctb.HotkeysMapping.Add(Keys.End | Keys.Shift, FCTBAction.GoEndWithSelection);
        fctb.HotkeysMapping.Add(Keys.Home | Keys.Shift, FCTBAction.GoHomeWithSelection);
        fctb.HotkeysMapping.Add(Keys.Left | Keys.Shift, FCTBAction.GoLeftWithSelection);
        fctb.HotkeysMapping.Add(Keys.Up | Keys.Shift, FCTBAction.GoUpWithSelection);
        fctb.HotkeysMapping.Add(Keys.Right | Keys.Shift, FCTBAction.GoRightWithSelection);
        fctb.HotkeysMapping.Add(Keys.Down | Keys.Shift, FCTBAction.GoDownWithSelection);
        fctb.HotkeysMapping.Add(Keys.Insert | Keys.Shift, FCTBAction.Paste);
        fctb.HotkeysMapping.Add(Keys.Delete | Keys.Shift, FCTBAction.Cut);

        // --- CTRL + Клавиши (Навигация и Буфер) ---
        fctb.HotkeysMapping.Add(Keys.Back | Keys.Control, FCTBAction.ClearWordLeft); 

        fctb.HotkeysMapping.Add(Keys.Space | Keys.Control, FCTBAction.AutocompleteMenu);
        fctb.HotkeysMapping.Add(Keys.End | Keys.Control, FCTBAction.GoLastLine);
        fctb.HotkeysMapping.Add(Keys.Home | Keys.Control, FCTBAction.GoFirstLine);
        fctb.HotkeysMapping.Add(Keys.Left | Keys.Control, FCTBAction.GoWordLeft);
        fctb.HotkeysMapping.Add(Keys.Right | Keys.Control, FCTBAction.GoWordRight);
        fctb.HotkeysMapping.Add(Keys.Up | Keys.Control, FCTBAction.ScrollUp);
        fctb.HotkeysMapping.Add(Keys.Down | Keys.Control, FCTBAction.ScrollDown);
        fctb.HotkeysMapping.Add(Keys.Insert | Keys.Control, FCTBAction.Copy);
        fctb.HotkeysMapping.Add(Keys.Delete | Keys.Control, FCTBAction.ClearWordRight);

        // --- CTRL + Буквы (Стандартные команды) ---
        fctb.HotkeysMapping.Add(Keys.D0 | Keys.Control, FCTBAction.ZoomNormal);
        fctb.HotkeysMapping.Add(Keys.A | Keys.Control, FCTBAction.SelectAll);
        fctb.HotkeysMapping.Add(Keys.B | Keys.Control, FCTBAction.BookmarkLine);
        fctb.HotkeysMapping.Add(Keys.C | Keys.Control, FCTBAction.Copy);
        fctb.HotkeysMapping.Add(Keys.E | Keys.Control, FCTBAction.MacroExecute);
        fctb.HotkeysMapping.Add(Keys.F | Keys.Control, FCTBAction.FindDialog);
        fctb.HotkeysMapping.Add(Keys.G | Keys.Control, FCTBAction.GoToDialog);
        fctb.HotkeysMapping.Add(Keys.H | Keys.Control, FCTBAction.ReplaceDialog);
        fctb.HotkeysMapping.Add(Keys.I | Keys.Control, FCTBAction.AutoIndentChars);
        fctb.HotkeysMapping.Add(Keys.M | Keys.Control, FCTBAction.MacroRecord);
        fctb.HotkeysMapping.Add(Keys.N | Keys.Control, FCTBAction.GoNextBookmark);
        fctb.HotkeysMapping.Add(Keys.R | Keys.Control, FCTBAction.Redo);
        fctb.HotkeysMapping.Add(Keys.U | Keys.Control, FCTBAction.UpperCase);
        fctb.HotkeysMapping.Add(Keys.V | Keys.Control, FCTBAction.Paste);
        fctb.HotkeysMapping.Add(Keys.X | Keys.Control, FCTBAction.Cut);
        fctb.HotkeysMapping.Add(Keys.Z | Keys.Control, FCTBAction.Undo);

        // --- Клавиатура Zoom и Навигация ---
        fctb.HotkeysMapping.Add(Keys.Add | Keys.Control, FCTBAction.ZoomIn);
        fctb.HotkeysMapping.Add(Keys.Subtract | Keys.Control, FCTBAction.ZoomOut);
        fctb.HotkeysMapping.Add(Keys.OemMinus | Keys.Control, FCTBAction.NavigateBackward);

        // --- CTRL + SHIFT ---
        fctb.HotkeysMapping.Add(Keys.End | Keys.Control | Keys.Shift, FCTBAction.GoLastLineWithSelection);
        fctb.HotkeysMapping.Add(Keys.Home | Keys.Control | Keys.Shift, FCTBAction.GoFirstLineWithSelection);
        fctb.HotkeysMapping.Add(Keys.Left | Keys.Control | Keys.Shift, FCTBAction.GoWordLeftWithSelection);
        fctb.HotkeysMapping.Add(Keys.Right | Keys.Control | Keys.Shift, FCTBAction.GoWordRightWithSelection);
        fctb.HotkeysMapping.Add(Keys.B | Keys.Control | Keys.Shift, FCTBAction.UnbookmarkLine);
        fctb.HotkeysMapping.Add(Keys.C | Keys.Control | Keys.Shift, FCTBAction.CommentSelected);
        fctb.HotkeysMapping.Add(Keys.N | Keys.Control | Keys.Shift, FCTBAction.GoPrevBookmark);
        fctb.HotkeysMapping.Add(Keys.U | Keys.Control | Keys.Shift, FCTBAction.LowerCase);
        fctb.HotkeysMapping.Add(Keys.OemMinus | Keys.Control | Keys.Shift, FCTBAction.NavigateForward);

        // --- ALT + Клавиши ---
        fctb.HotkeysMapping.Add(Keys.Back | Keys.Alt, FCTBAction.Undo); 

        fctb.HotkeysMapping.Add(Keys.Up | Keys.Alt, FCTBAction.MoveSelectedLinesUp);
        fctb.HotkeysMapping.Add(Keys.Down | Keys.Alt, FCTBAction.MoveSelectedLinesDown);
        fctb.HotkeysMapping.Add(Keys.F | Keys.Alt, FCTBAction.FindChar);

        // --- ALT + SHIFT (Колоночное выделение) ---
        fctb.HotkeysMapping.Add(Keys.Left | Keys.Alt | Keys.Shift, FCTBAction.GoLeft_ColumnSelectionMode);
        fctb.HotkeysMapping.Add(Keys.Up | Keys.Alt | Keys.Shift, FCTBAction.GoUp_ColumnSelectionMode);
        fctb.HotkeysMapping.Add(Keys.Right | Keys.Alt | Keys.Shift, FCTBAction.GoRight_ColumnSelectionMode);
        fctb.HotkeysMapping.Add(Keys.Down | Keys.Alt | Keys.Shift, FCTBAction.GoDown_ColumnSelectionMode);

        newTabPage.Controls.Add(fctb);
        tabControlEditor.TabPages.Add(newTabPage);
        tabControlEditor.SelectedTab = newTabPage;
        fctb.IsChanged = false;
        fctb.SelectionChanged += (s, ev) => {
            int line = fctb.Selection.Start.iLine + 1;
            lblStatus.Text = $"Строка: {line}| Всего строк: {fctb.LinesCount}";
        };
        return fctb;
    }
    private FastColoredTextBox CurrentEditor => 
        tabControlEditor.SelectedTab?.Controls[0] as FastColoredTextBox;
    
    private void DgvErrors_MouseWheel(object sender, MouseEventArgs e)
    {
        if (Control.ModifierKeys == Keys.Control)
        {
            float currentSize = dgvErrors.DefaultCellStyle.Font.Size;
            float newSize = e.Delta > 0 ? currentSize + 1 : currentSize - 1;

            if (newSize >= 6 && newSize <= 32)
            {
                Font newFont = new Font(dgvErrors.Font.FontFamily, newSize);

                dgvErrors.DefaultCellStyle.Font = newFont;

                dgvErrors.ColumnHeadersDefaultCellStyle.Font = newFont;

                dgvErrors.AutoResizeColumnHeadersHeight();
            
                dgvErrors.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
            }

            ((HandledMouseEventArgs)e).Handled = true;
        }
    }
   
}