using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WordTest
{
    // мини-программа для тестирования работающего с Word класса
    public partial class FormTestWord : Form
    {
        // ПУТЬ К ШАБЛОНУ ПО ДАННЫМ ФОРМЫ
        private string pathToTemplate { get { return Application.StartupPath + "\\" + pathTextBox.Text; } }

        // ПУТЬ К ВРЕМЕННОМУ ФАЙЛУ ДЛЯ ВСТАВКИ
        private string pathToInsertingDoc { get { return Application.StartupPath + "\\tempWordDoc.doc"; } }
 
        // КОНСТРУКТОР
        public FormTestWord()
        {
            InitializeComponent();
        }

        //КНОПКА, ОТКРЫВАЕМ ПУСТОЙ ДОКУМЕНТ БЕЗ ШАБЛОНА
        private void openBlankButton_Click(object sender, EventArgs e)
        {
            WordDocument testWordDoc;
            try
            {
                testWordDoc = new WordDocument();
            }
            catch (Exception error)
            {
                MessageBox.Show("Ошибка при открытии шаблона Word. Подробности " + error.Message);
                return;
            }
            testWordDoc.Visible = true;
        }

        //КНОПКА,  ПРОСТО ОТКРЫВАЕМ ШАБЛОН
        private void openTemplateButton_Click(object sender, EventArgs e)
        {
            WordDocument wordDoc;
            try
            {
                wordDoc = new WordDocument(pathToTemplate);
            }
            catch (Exception error)
            {
                MessageBox.Show("Ошибка при открытии шаблона Word. Подробности " + error.Message);
                return;
            }
            wordDoc.Visible = true;
        }

        //КНОПКА, ЗАМЕНЯЕМ СТРОКУ В ШАБЛОНЕ
        private void replaceTestButton_Click(object sender, EventArgs e)
        {
            WordDocument wordDoc = null;
            try
            {
                wordDoc = new WordDocument(pathToTemplate);
                if (replaceAllСheckBox.Checked)
                {
                    wordDoc.ReplaceAllStrings(toFindStrTextBox.Text, replaceStrTextBox.Text);
                }
                else 
                {
                    wordDoc.SetSelectionToText(toFindStrTextBox.Text);
                    wordDoc.Selection.Text = replaceStrTextBox.Text;
                }
            }
            catch (Exception error)
            {
                if (wordDoc != null) { wordDoc.Close(); }
                MessageBox.Show("Ошибка при замене текста на метке в документе  Word. Подробности " + error.Message);
                return;
            }
            wordDoc.Visible = true;
        }

        //КНОПКА, ВСТАВЛЯЕМ ТЕКСТ НА ЗАКЛАДКУ
        private void bmarkInsertTextButton_Click(object sender, EventArgs e)
        {
            WordDocument wordDoc = null;
            try
            {
                wordDoc = new WordDocument(pathToTemplate);
                if (isParagraphCheckBox.Checked)
                {
                    wordDoc.SetSelectionToBookmark(bookmarkTextBox.Text, true);
                }
                else
                {
                    wordDoc.SetSelectionToBookmark(bookmarkTextBox.Text);
                }
                wordDoc.Selection.Text = bookmarkInsertTextBox.Text;
            
            }
            catch (Exception error)
            {
                if (wordDoc != null) { wordDoc.Close(); }
                MessageBox.Show("Ошибка при вставке текста на закладку в документе  Word. Подробности " + error.Message);
                return;
            }

            wordDoc.Visible = true;
            
            //завершение private void bmarkInsertTextButton_Click(object sender, EventArgs e)
        }

        //КНОПКА,  СЛОЖНАЯ ВСТАВКА ТЕКСТА С ФОРМАТИРОВАНИЕМ
        private void bookmarkInsertButton_Click(object sender, EventArgs e)
        {
            try
            {
                WordDocument.FillShowTemplate(pathToTemplate, complexInsertText);
            }
            catch (Exception error)
            {
                MessageBox.Show("Ошибка при сложной вставке текста с форматированием на закладку в документе  Word. Подробности " + error.Message);
                return;
            }
        }


        //КНОПКА,  ПОИСК ТЕКСТА И ЕГО ФОРМАТИРОВАНИЕ
        private void searchFormatButton_Click(object sender, EventArgs e)
        {
            try
            {
                WordDocument.FillShowTemplate(pathToTemplate, searchFormatText);
            }
            catch (Exception error)
            {
                MessageBox.Show("Ошибка при поиске и форматировании найденного текста в документе  Word. Подробности " + error.Message);
                return;
            }
        }

        //КНОПКА, ВСТАВКА ТАБЛИЦЫ
        private void tableButton_Click(object sender, EventArgs e)
        {
            try
            {
                WordDocument.FillShowTemplate(pathToTemplate, insertTable);
            }
            catch (Exception error)
            {
                MessageBox.Show("Ошибка при вставкее таблицы в Word. Подробности " + error.Message);
                return;
            }
        }

        // КНОПКА, ВСТАВКА ФАЙЛА-ДОКУМЕНТА В ОТКРЫТЫЙ ДОКУМЕНТ 
        private void insertFileButton_Click(object sender, EventArgs e)
        {

            try
            {
                WordDocument.FillShowTemplate(pathToTemplate, insertTempFile);
            }
            catch (Exception error)
            {
                MessageBox.Show("Ошибка при вставке другого документа Word из временного файла в текущий документ Word. Подробности " + error.Message);
                return;
            }
        }

        // ВСТАВКА ФАЙЛА-ДОКУМЕНТА В ДОКУМЕНТ
        private void insertTempFile(WordDocument wordDoc)
        {
            WordDocument tempWordDoc = null;
            try
            {

                for (int insertCount = 1; insertCount <= insertCountNumUpDown.Value; insertCount++)
                {
                    tempWordDoc = new WordDocument(pathToTemplate);
                    complexInsertText(tempWordDoc);
                    tempWordDoc.Save(pathToInsertingDoc);

                    if (insertCount > 1) { wordDoc.InsertPageAtEnd(); }
                    wordDoc.InsertFile(pathToInsertingDoc);
                    tempWordDoc.Close();
                }

            }
            catch (Exception error)
            {
                if (tempWordDoc != null) { tempWordDoc.Close(); }
                MessageBox.Show(error.Message);
                return;
            }
        }

        // КНОПКА, ВЫБОР И ЗАПОЛНЕНИЕ ИМЕЮЩЕЙСЯ ТАБЛИЦЫ
        private void selectTableButton_Click(object sender, EventArgs e)
        {
            try
            {
                WordDocument.FillShowTemplate(pathToTemplate, fillExistingTable);
            }
            catch (Exception error)
            {
                MessageBox.Show("Ошибка при вставке другого документа Word из временного файла в текущий документ Word. Подробности " + error.Message);
                return;
            }
        }

        //ВЫБОР И ЗАПОЛНЕНИЕ ИМЕЮЩЕЙСЯ ТАБЛИЦЫ
        private void fillExistingTable(WordDocument wordDoc)
        {
            // такая конвертация типов работает не всегда, не на всех сочетаниях типов
            int tableNum = (int)tableNumUpDown.Value;
            wordDoc.SelectTable(tableNum);
            wordDoc.SetSelectionToCell(1, 1);
            wordDoc.Selection.Text = "Ячейка 1 1 ЗАПОЛНЕНА ИЗ КОДА";
            wordDoc.SetSelectionToCell(1, 2);
            wordDoc.Selection.Text = "Ячейка 1 2";
            wordDoc.SetSelectionToCell(2, 1);
            wordDoc.Selection.Text = "Ячейка 2 1";
            //testWordDoc.SetSelectionToCell(2, 2); // ОШИБКА!! НЕТ ТАКОЙ ЯЧЕЙКИ т.к. она обьединена с 1 2

            int addRowsCount = (int)addRowsNumUpDown.Value;

            for (int addRowsNum = 1; addRowsNum <= addRowsCount; addRowsNum++)
            {
                wordDoc.AddRowToTable();
                wordDoc.SetSelectionToCell(addRowsNum + 3, 1);
                wordDoc.Selection.Text = "Строка добавлена из кода";
            }
        }

        // ВСТАВКА ТАБЛИЦЫ
        private void insertTable(WordDocument wordDoc)
        {
            wordDoc.SetSelectionToBookmark(tableBookmarkTextBox.Text);
            
            
            if (tableBorderCheckBox.Checked)
            {
                wordDoc.InsertTable(3, 3, BorderType.None);
                wordDoc.Selection.Border = BorderType.None;
            }
            else
            {
                wordDoc.InsertTable(3, 3);
            }

            wordDoc.SetColumnWidth(1,80);
            wordDoc.SetColumnWidth(2, 400);

            wordDoc.SetSelectionToCell(1, 1);
            wordDoc.Selection.Text = "Ячейка 1 1";

            wordDoc.Selection.Bold = true;
            wordDoc.SetSelectionToCell(1, 2);
            wordDoc.Selection.Text = "ТАБЛИЦА ВСТАВЛЕНА ИЗ КОДА";


            wordDoc.SetSelectionToCell(2, 1);
            wordDoc.Selection.Text = "Ячейка 2 1";
            wordDoc.Selection.FontSize = 23;
            wordDoc.Selection.Aligment = TextAligment.Center;

            wordDoc.SetSelectionToCell(3, 2);
            wordDoc.Selection.Text = "Ячейка 3 2";
            wordDoc.Selection.FontSize = 23;
            wordDoc.Selection.Aligment = TextAligment.Center;
            wordDoc.Selection.Bold = true;
            wordDoc.Selection.Border = BorderType.Double;

        }

        // СЛОЖНАЯ ВСТАВКА ТЕКСТА
        private void complexInsertText(WordDocument wordDoc)
        {
            if (insertToBookmarkRadioButton.Checked)
            {
                wordDoc.SetSelectionToBookmark(bookmarkTextBox.Text);
            }

            wordDoc.InsertParagraphAfter("Вставляем ПЕРВЫЙ параграф с текстом. Параметры по умолчанию.");
            wordDoc.InsertParagraphAfter(); // пустой
            wordDoc.InsertParagraphAfter("Вставляем ВТОРОЙ параграф с текстом. Жирный, выравнивание справа. Размер шрифта 8.");
            wordDoc.Selection.Bold = true;
            wordDoc.Selection.Aligment = TextAligment.Right;
            wordDoc.Selection.FontSize = 8;
            wordDoc.InsertParagraphAfter(); // пустой
            wordDoc.InsertParagraphAfter("Вставляем ТРЕТИЙ параграф с текстом. Курсив, выравнивание по центру. Размер шрифта 18. Рамка.");
            wordDoc.Selection.Italic = true;
            wordDoc.Selection.Aligment = TextAligment.Center;
            wordDoc.Selection.FontSize = 18;
            wordDoc.Selection.Border = BorderType.Double;

            wordDoc.InsertParagraphAfter(); // пустой
            wordDoc.InsertParagraphAfter("Вставляем ЧЕТВЕРТЫЙ параграф с текстом. Параметры по умолчанию. Размер шрифта 12.");
            wordDoc.Selection.FontSize = 12;
        }

        // ПОИСК И ФОРМАТИРОВАНИЕ ТЕКСТА
        private void searchFormatText(WordDocument wordDoc)
        {
            string toFormatStr = searchFormatTextBox.Text;
            if (formatContainerCheckBox.Checked)
            {
                wordDoc.SetSelectionToText(formatContainerTextBox.Text, toFormatStr);
            }
            else
            {
                wordDoc.SetSelectionToText(toFormatStr);
            }

            if (formatBoldCheckBox.Checked)
            {
                wordDoc.Selection.Bold = true;
            }
            if (formatItalicCheckBox.Checked)
            {
                wordDoc.Selection.Italic = true;
            }
            if (formatCenterCheckBox.Checked)
            {
                wordDoc.Selection.Aligment = TextAligment.Center;
            }
            wordDoc.Selection.FontSize = Convert.ToInt32(formatFontSizeNumUpDown.Value);

        }


        // завершение public partial class FormTestWord : Form
    }
}
