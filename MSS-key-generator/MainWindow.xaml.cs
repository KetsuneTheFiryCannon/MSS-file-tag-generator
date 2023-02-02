using System.Collections.Generic;
using System.Windows.Controls;

namespace MSS_key_generator;

public partial class MainWindow : Window
{
    private readonly Logger _logger = new();
    private readonly KeyGenerator _generator = new();

    public MainWindow()
    {
        InitializeComponent();

        FileTypeComboBox.ItemsSource = Enum.GetValues<FileType>();
        FileTypeComboBox.SelectedIndex = 0;
#if DEBUG
        var list = new List<GenerationData>();
        var item = _generator.GenerateCreateFile("s2", FileType.DF_MF, 100);
        list.Add(item);
        LastCommandsListView.ItemsSource = list;
#endif
    }

    private void GenerateOnClick(object sender, RoutedEventArgs e)
    {
        var sizeText = FileSizeTextBox.Text;
        if (!int.TryParse(sizeText, out var size))
        {
            MessageBox.Show("Размер файла должен быть числом");
            return;
        }

        var data = _generator.GenerateCreateFile(FileNameTextBox.Text, (FileType)FileTypeComboBox.SelectedItem, size);
        _logger.Log(data.ToString());
    }

    private void OpenLogOnClick(object sender, RoutedEventArgs e)
    {
        Process.Start("explorer.exe", _logger.LogFilePath);
    }

    private void FileNameOnTextChanged(object sender, TextChangedEventArgs e)
    {
        var box = (TextBox)sender;
        if (box.Text is { Length: < 3 }) return;

        box.Undo();
        MessageBox.Show("Имя файла должно состоять максимум из 2 символов");
    }
}